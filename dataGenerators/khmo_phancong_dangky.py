from unidecode import unidecode
from numpy import random

dir_path = "ISS_QLNoiBo/dataGenerators"
out_file = "out.txt"

departms = ['VAN PHONG KHOA', 'BO MON HTTT', 'BO MON CNPM', 'BO MON KHMT',
            'BO MON CNTT', 'BO MON TGMT', 'BO MON MMT VA VIEN THONG']
programs = ['CQ', 'CLC', 'CTTT', 'VP']
courses, max_crs = {}, 6
dept_num, sem_num = 7, 3
lecturers, lect_num = [[] for _ in range(len(departms) - 1)], 80
students, stu_num = [[] for _ in range(len(programs))], 120
min_stu, max_stu = 5, 100
scr_wgts = [0.3, 0.2, 0.5] # prac, proc, final

def pop_courses(dir, folder="tables"):
    file = open(f"{dir}/{folder}/courses.txt", "r", encoding="utf-8")
    idx, prev = 1, ""
    for line in file:
        if line == "\n": continue
        type, name, info = line.split(", ")
        if prev != type: idx = 1
        courses[f'{type}{idx:04}'] = [unidecode(name)] + list(map(int, info.strip().split(" ")))
        idx, prev = idx + 1, type
    file.close()

def pop_lecturers(dir, folder="tables"):
    file = open(f"{dir}/{folder}/lecturers.txt", "r", encoding="utf-8")
    comm, lect_format = "SELECT", "Vd0000"
    for line in file:
        line, lco = line.strip(), len(comm)
        if line[:lco] != comm: continue
        lect = line[lco + 2 : lco + 2 + len(lect_format)]
        lecturers[int(lect[1]) - 2].append(lect)
    file.close()

def pop_students(dir, folder="tables"):
    file = open(f"{dir}/{folder}/students.txt", "r", encoding="utf-8")
    comm, stu_format = "SELECT", "Sp0000"
    for line in file:
        line, lco = line.strip(), len(comm)
        if line[:lco] != comm: continue
        stu = line[lco + 2 : lco + 2 + len(stu_format)]
        students[int(stu[1]) - 1].append(stu)
    file.close()

def gen_khmo(dir, year):
    op_courses = []
    file = open(f"{dir}/out.txt", "w", encoding="utf-8")
    file.write("/* KHMO\n */\n")
    rng = random.default_rng()
    for dept in range(dept_num):
        file.write("INSERT INTO KHMO\n")
        file.write(f"-- {dept + 1}. {departms[dept]}\n")

        crs_idx, idx, ci = {}, 0, 0
        for key in courses.keys():
            if int(key[0]) == dept + 1: crs_idx[idx], idx = key, idx + 1
        crs = rng.choice(len(crs_idx), min(max_crs * sem_num, len(crs_idx)), False)

        for sem in range(sem_num):
            file.write(f"--\t{year} - HOC KY {sem + 1}\n")
            for c in range(max_crs):
                data = f"'{crs_idx[crs[ci]]}', '{sem + 1}', {year}, '{programs[random.randint(len(programs))]}'"
                op_courses.append(data)
                file.write(f"\tSELECT {data} FROM DUAL")
                if sem == sem_num - 1 and (ci == len(crs_idx) - 1 or c == max_crs - 1):
                    file.write(";\n")
                else: file.write(" UNION ALL\n")
                if ci < len(crs_idx) - 1: ci += 1
                else: break
    file.close()
    return op_courses

def gen_phancong(dir, op_courses):
    file = open(f"{dir}/out.txt", "a", encoding="utf-8")
    file.write("\n/* PHANCONG\n */\n")
    rng = random.default_rng()
    pdept, psem = -1, -1
    for i, crs in enumerate(op_courses):
        co, sem, year, _ = crs.split(", ")
        if pdept != int(co[1]):
            if pdept != -1: file.write(";\n")
            pdept = int(co[1])
            file.write("INSERT INTO PHANCONG\n")
            file.write(f"--{pdept}. {departms[pdept - 1]}\n")
        else: file.write(" UNION ALL\n")

        if psem != int(sem[1]):
            psem = int(sem[1])
            file.write(f"--\t{year} - HOC KY {psem}\n")

        if crs[1] != '1': lect = rng.choice(lecturers[int(crs[1]) - 2])
        else: lect = rng.choice(lecturers[random.randint(len(departms) - 1)])
        op_courses[i] = f"'{lect}', {crs}"
        file.write(f"\tSELECT {op_courses[i]} FROM DUAL")
    file.write(";\n")
    file.close()
    return op_courses

def gen_dangky(dir, av_courses:list[str]):
    file = open(f"{dir}/out.txt", "a", encoding="utf-8")
    file.write("\n/* DANGKY\n */\n")
    stu_upds, rng = {}, random.default_rng()
    pdept, psem, skfl = -1, -1, False
    for crs in av_courses:
        _, co, sem, year, cprog = crs.split(", ")
        cprog = programs.index(cprog[1:-1])
        if pdept != int(co[1]):
            if pdept != -1:
                file.write(";\n")
                skfl = True
            pdept = int(co[1])
            file.write("INSERT INTO DANGKY\n")
            file.write(f"--{pdept}. {departms[pdept - 1]}\n")

        if psem != int(sem[1]):
            if psem != -1 and not skfl: file.write(";\nINSERT INTO DANGKY\n")
            skfl = False
            psem = int(sem[1])
            file.write(f"--\t{year} - HOC KY {psem}\n")
        else: file.write(" UNION ALL\n")

        stu_cap = random.randint(min_stu, min(len(students[cprog]), max_stu))
        stus = rng.choice(students[cprog], stu_cap, False)
        for j, st in enumerate(stus):
            prac, proc, final = random.uniform(4, 10, 3)
            prac, proc, final = float('%.2f'%prac), float('%.2f'%proc), float('%.2f'%final)
            total = float('%.2f'%(prac * scr_wgts[0] + proc * scr_wgts[1] + final * scr_wgts[2]))
            file.write(f"\tSELECT '{st}', {crs}, {prac}, {proc}, {final}, {total} FROM DUAL")
            if j != len(stus) - 1: file.write(" UNION ALL\n")

            cred = courses[co[1:-1]][1]
            if st not in stu_upds:
                stu_upds[st] = [cred, total * cred]
                continue
            run_cred, run_numer = stu_upds[st]
            run_cred += cred
            run_numer += total * cred
            stu_upds[st] = [run_cred, run_numer]
    file.write(";\n")
    file.close()
    return stu_upds

def gen_upd_sinhvien(dir, stu_upds):
    file = open(f"{dir}/out.txt", "a", encoding="utf-8")
    file.write("\n/* UPDATE SINHVIEN'S SOTCTL AND DTBTL\n */\n")
    for stu, info in stu_upds.items():
        file.write(f"UPDATE SINHVIEN SET SOTCTL = {info[0]}, DTBTL = {'%.2f'%(info[1] / info[0])} ")
        file.write(f"WHERE MASV = '{stu}';\n")
    file.close()

def main():
    op_courses = gen_khmo(dir_path, 2023)
    av_courses = gen_phancong(dir_path, op_courses)
    stu_upds = gen_dangky(dir_path, av_courses)
    gen_upd_sinhvien(dir_path, stu_upds)

if __name__ == "__main__":
    pop_courses(dir_path)
    pop_lecturers(dir_path)
    pop_students(dir_path)
    main()
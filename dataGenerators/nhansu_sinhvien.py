from unidecode import unidecode
from numpy import random, int64
from string import ascii_uppercase
import time

dir_path = "ISS_QLNoiBo/dataGenerators"
out_file = "out.txt"

last_names = ["Nguyen", "Tran", "Le", "Pham", "Hoang", "Huynh", "Vu", "Vo",
              "Phan", "Truong", "Bui", "Dang", "Do", "Ngo", "Ho", "Duong",
              "Dinh", "Ly"]
male_names, fe_names = [], []

genders = ['NAM', 'NU']
phone_digit_cnt = 10**9
streets, wards, dists, provs_cities = [], [], [], []

departms = ['HTTT', 'CNPM', 'KHMT', 'CNTT', 'TGMT', 'MMT']
programs = ['CQ', 'CLC', 'CTTT', 'VP']

def pop_names(dir, folder="names"):
    file = open(f"{dir}/{folder}/boy.txt", "r", encoding="utf-8")
    for name in file:
        male_names.append(unidecode(name).strip())
    file.close()

    file = open(f"{dir}/{folder}/girl_unsigned.txt", "r", encoding="utf-8")
    for name in file:
        fe_names.append(name.strip())
    file.close()

def pop_addresses(dir, folder="addresses"):
    file = open(f"{dir}/{folder}/districts.txt", "r", encoding="utf-8")
    for st in file:
        streets.append(unidecode(st).strip())
    file.close()

    file = open(f"{dir}/{folder}/wards.txt", "r", encoding="utf-8")
    for wa in file:
        wards.append(unidecode(wa).strip())
    file.close()
    
    file = open(f"{dir}/{folder}/districts.txt", "r", encoding="utf-8")
    for di in file:
        dists.append(unidecode(di).strip())
    file.close()
    
    file = open(f"{dir}/{folder}/provs_cities.txt", "r", encoding="utf-8")
    for pc in file:
        provs_cities.append(unidecode(pc).strip())
    file.close()

def randdate(start, end, time_format='%d/%m/%Y %I:%M%p'):
    if start.find(" ") == -1: start += " 1:00AM"
    if end.find(" ") == -1: end += " 1:00AM"
    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ptime = stime + random.random() * (etime - stime)
    return time.strftime(time_format, time.localtime(ptime))

def randfullname(gender): # 0-male, 1-female
    full_name = last_names[random.randint(len(last_names))]
    if gender: full_name += f" {fe_names[random.randint(len(fe_names))]}"
    else: full_name += f" {male_names[random.randint(len(male_names))]}"
    return full_name

def randaddress():
    addr = f"{random.randint(1, 400)}"
    if random.randint(2):
        addr += f"/{random.randint(1, 50)}"
    if random.randint(2):
        addr += random.choice(list(ascii_uppercase))

    addr += f" duong {streets[random.randint(len(streets))]}, "
    ward = wards[random.randint(len(wards))]
    addr += f"{ward}, " if ward.find("Phuong") != -1 else f"phuong {ward}, "
    
    if random.randint(2):
        dist = dists[random.randint(len(dists))]
        addr += f"{dist}, " if dist.find("Quan") != -1 else f"quan {dist}, "

    addr += f"{provs_cities[random.randint(len(provs_cities))]}"
    return addr

def gen_nhansu(rl, end, branch, dept=None, start=0):
    roles = ['NV', 'V', 'GV', 'TD', 'TK']
    rl, dept = rl - 1, dept if dept else random.randint(1, 7)
    if start: start -= 1
    data = ""
    for i in range(start, end):
        ro = roles[rl] if rl != 1 else f"{roles[rl]}{dept}"
        data += f"\tSELECT '{ro}{i+1:04}', "
        gender = random.randint(len(genders))
        data += f"'{randfullname(gender)}', '{genders[gender]}', "

        date = f"{randdate('02/01/1970', '01/01/2000').split(' ')[0]}"
        data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
        data += f"{random.randint(500, 10000)}, "
        data += f"'09{random.randint(phone_digit_cnt, dtype=int64):09}', "
        data += f"{rl + 1}, {dept}, {branch} FROM DUAL"
        data += " UNION ALL\n" if i != end -1 else ";\n"
    return data

def gen_sinhvien(end, prog=None, dept=None, start=0, is_union=False):
    if start: start -= 1
    data = ""
    for i in range(start, end):
        data += f"\tSELECT 'S{prog}{i+1:04}', "
        gender = random.randint(len(genders))
        data += f"'{randfullname(gender)}', '{genders[gender]}', "

        date = f"{randdate('01/01/2000', '01/01/2006').split(' ')[0]}"
        data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
        data += f"'{randaddress()}', "
        data += f"'09{random.randint(phone_digit_cnt, dtype=int64):09}', "
        data += f"'{programs[prog - 1] if prog else programs[random.randint(len(programs))]}', "
        data += f"'{departms[dept - 1] if dept else departms[random.randint(len(departms))]}', "
        data += "0, 0 FROM DUAL"
        if i != end -1: data += " UNION ALL\n"
    data += " UNION ALL\n" if is_union else ";\n"
    return data

def main():
    file = open(f"{dir_path}/{out_file}", "w", encoding="utf-8")

    # dept, cnt = 1, 10
    # for i in range(1, 60, cnt):
    #     file.write("INSERT INTO NHANSU\n")
    #     file.write(f"-- 2.{dept + 1}. GIANG VIEN {departms[dept - 1]} ({cnt})\n")
    #     data = gen_nhansu(2, i + cnt - 1, 1, dept + 1, i)
    #     file.write(f"{data}")
    #     dept += 1

    dept = 1
    for i in range(1, 120, 20):
        file.write("INSERT INTO SINHVIEN\n")
        file.write(f"-- {dept}. SINH VIEN {departms[dept - 1]}\n")
        for j in range(1, 5):
            file.write(f"--\t{j}. {programs[j - 1]}\n")
            data = gen_sinhvien(i + 5 * j - 1, j, dept, i + 5 * (j - 1), j != 4)
            file.write(f"{data}")
        dept += 1

    file.close()

if __name__ == "__main__":
    pop_names(dir_path)
    pop_addresses(dir_path)
    main()
from unidecode import unidecode

dir_path = "ISS_QLNoiBo/dataGenerators"
out_file = "out.txt"

departms = ['VAN PHONG KHOA', 'BO MON HTTT', 'BO MON CNPM', 'BO MON KHMT',
            'BO MON CNTT', 'BO MON TGMT', 'BO MON MMT VA VIEN THONG']
crs_types = ["BAT BUOC", "TU CHON", "TOT NGHIEP"]

def gen_hocphan(dir):
    file = open(f"{dir}/courses.txt", "r", encoding="utf-8")
    out = open(f"{dir}/out.txt", "w", encoding="utf-8")
    dept, ctype = -1, -1
    idx, prev, pos = 1, "", -1
    for line in file:
        if line == "\n": continue
        type, name, info = line.split(", ")
        info = info.strip().split(" ")

        if dept != int(type[0]):
            dept = int(type[0])
            if pos != -1:
                out.seek(pos)
                out.write(";\n")
            out.write("INSERT INTO HOCPHAN\n")
            out.write(f"-- {dept}. {departms[dept - 1]}\n")
        if ctype != int(type[1]):
            ctype = int(type[1])
            out.write(f"--\t{crs_types[ctype - 1]}\n")

        if prev != type: idx = 1
        data = f"\tSELECT '{type}{idx:04}', '{unidecode(name)}', "
        data += f"{info[0]}, {info[1]}, {info[2]}, 100, {dept} FROM DUAL"
        out.write(data)
        pos = out.tell()
        out.write(" UNION ALL\n")
        idx, prev = idx + 1, type
    out.seek(pos)
    out.write(";\n")
    out.truncate()
    file.close()
    out.close()

def main():
    gen_hocphan(dir_path)

if __name__ == "__main__":
    main()
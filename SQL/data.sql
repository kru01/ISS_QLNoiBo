CL SCR;

ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;

INSERT INTO VAITRO
    SELECT 1, 'NHAN VIEN CO BAN' FROM DUAL UNION ALL
    SELECT 2, 'GIANG VIEN' FROM DUAL UNION ALL
    SELECT 3, 'GIAO VU' FROM DUAL UNION ALL
    SELECT 4, 'TRUONG DON VI' FROM DUAL UNION ALL
    SELECT 5, 'TRUONG KHOA' FROM DUAL;

INSERT INTO DONVI(MADV, TENDV)
    SELECT 1, 'VAN PHONG KHOA' FROM DUAL UNION ALL
    SELECT 2, 'BO MON HTTT' FROM DUAL UNION ALL
    SELECT 3, 'BO MON CNPM' FROM DUAL UNION ALL
    SELECT 4, 'BO MON KHMT' FROM DUAL UNION ALL
    SELECT 5, 'BO MON CNTT' FROM DUAL UNION ALL
    SELECT 6, 'BO MON TGMT' FROM DUAL UNION ALL
    SELECT 7, 'BO MON MMT VA VIEN THONG' FROM DUAL;

INSERT INTO CTDAOTAO
    SELECT 'CQ', 'CHINH QUY' FROM DUAL UNION ALL
    SELECT 'CLC', 'CHAT LUONG CAO' FROM DUAL UNION ALL
    SELECT 'CTTT', 'CHUONG TRINH TIEN TIEN' FROM DUAL UNION ALL
    SELECT 'VP', 'CHUONG TRINH VIET - PHAP' FROM DUAL;

INSERT INTO NGANH
    SELECT 'HTTT', 'HE THONG THONG TIN' FROM DUAL UNION ALL
    SELECT 'CNPM', 'CONG NGHE PHAN MEM' FROM DUAL UNION ALL
    SELECT 'KHMT', 'KHOA HOC MAY TINH' FROM DUAL UNION ALL
    SELECT 'CNTT', 'CONG NGHE TRI THUC' FROM DUAL UNION ALL
    SELECT 'TGMT', 'THI GIAC MAY TINH' FROM DUAL UNION ALL
    SELECT 'MMT', 'MANG MAY TINH VA VIEN THONG' FROM DUAL;

/* NHANSU
 */
INSERT INTO NHANSU
-- 1. NHAN VIEN CO BAN - 1. VAN PHONG KHOA
    SELECT 'NV0001', 'Hoang Phuong Tra', 'NU', TO_DATE('28/07/1980', 'DD/MM/YYYY'), 2427, '09935466760', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0002', 'Duong Thi Cam', 'NU', TO_DATE('28/02/1995', 'DD/MM/YYYY'), 6947, '09397762249', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0003', 'Bui Dieu Hong', 'NU', TO_DATE('31/08/1992', 'DD/MM/YYYY'), 6992, '09425872787', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0004', 'Ngo Huu Phuoc', 'NAM', TO_DATE('19/02/1971', 'DD/MM/YYYY'), 9274, '09691907243', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0005', 'Dinh Duc Bao', 'NAM', TO_DATE('25/01/1977', 'DD/MM/YYYY'), 5885, '09768751682', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0006', 'Huynh Thanh Loi', 'NAM', TO_DATE('08/07/1981', 'DD/MM/YYYY'), 1353, '09498783423', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0007', 'Bui Thi Cam', 'NU', TO_DATE('21/05/1995', 'DD/MM/YYYY'), 4611, '09168500805', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0008', 'Truong Mong Van', 'NU', TO_DATE('23/09/1994', 'DD/MM/YYYY'), 9981, '09705491149', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0009', 'Pham Anh Minh', 'NAM', TO_DATE('04/10/1972', 'DD/MM/YYYY'), 8190, '09353695402', 1, 1 FROM DUAL UNION ALL
    SELECT 'NV0010', 'Ho Gia Duc', 'NAM', TO_DATE('02/03/1975', 'DD/MM/YYYY'), 4716, '09698527961', 1, 1 FROM DUAL UNION ALL
-- 3. GIAO VU - 1. VAN PHONG KHOA
    SELECT 'GV0001', 'Duong Yen Trang', 'NU', TO_DATE('24/08/1982', 'DD/MM/YYYY'), 8554, '09561464695', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0002', 'Duong Kim Thao', 'NU', TO_DATE('05/02/1997', 'DD/MM/YYYY'), 8548, '09403850427', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0003', 'Dinh Thanh Hanh', 'NU', TO_DATE('10/07/1991', 'DD/MM/YYYY'), 9374, '09438731171', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0004', 'Bui Hieu Lam', 'NAM', TO_DATE('27/12/1986', 'DD/MM/YYYY'), 7385, '09383998067', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0005', 'Phan Thanh Son', 'NAM', TO_DATE('01/02/1976', 'DD/MM/YYYY'), 4970, '09482893902', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0006', 'Huynh Thuy Hien', 'NU', TO_DATE('25/10/1975', 'DD/MM/YYYY'), 5758, '09518356923', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0007', 'Vo Viet Phong', 'NAM', TO_DATE('09/11/1972', 'DD/MM/YYYY'), 4375, '09266472531', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0008', 'Ly Minh Thien', 'NAM', TO_DATE('09/10/1973', 'DD/MM/YYYY'), 2899, '09736576222', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0009', 'Vu An Khe', 'NU', TO_DATE('03/09/1980', 'DD/MM/YYYY'), 5260, '09659964719', 3, 1 FROM DUAL UNION ALL
    SELECT 'GV0010', 'Do Thao Hong', 'NU', TO_DATE('22/09/1980', 'DD/MM/YYYY'), 3955, '09737456988', 3, 1 FROM DUAL UNION ALL
-- 4. TRUONG DON VI - 2. HTTT, 3. CNPM, 4. KHMT, 5. CNTT, 6. TGMT, 7. MMT
    SELECT 'TD0001', 'Duong Bao Hue', 'NU', TO_DATE('04/07/1995', 'DD/MM/YYYY'), 9597, '09480787174', 4, 2 FROM DUAL UNION ALL
    SELECT 'TD0002', 'Do Chi Nam', 'NAM', TO_DATE('16/05/1982', 'DD/MM/YYYY'), 1729, '09372403011', 4, 3 FROM DUAL UNION ALL
    SELECT 'TD0003', 'Hoang Thuy Van', 'NU', TO_DATE('09/07/1972', 'DD/MM/YYYY'), 1930, '09550783443', 4, 4 FROM DUAL UNION ALL
    SELECT 'TD0004', 'Le Quang Vu', 'NAM', TO_DATE('27/07/1994', 'DD/MM/YYYY'), 9511, '09948400459', 4, 5 FROM DUAL UNION ALL
    SELECT 'TD0005', 'Huynh Thien Theu', 'NU', TO_DATE('04/08/1997', 'DD/MM/YYYY'), 2513, '09714491762', 4, 6 FROM DUAL UNION ALL
    SELECT 'TD0006', 'Dang My Ngoc', 'NU', TO_DATE('24/12/1996', 'DD/MM/YYYY'), 512, '09222394868', 4, 7 FROM DUAL UNION ALL
-- 5. TRUONG KHOA - 1. VAN PHONG KHOA
    SELECT 'TK0001', 'Nguyen Van Anh', 'NAM', TO_DATE('01/01/1980', 'DD/MM/YYYY'), 10000, '09123456789', 5, 1 FROM DUAL;
INSERT INTO NHANSU
-- 2.2. GIANG VIEN HTTT (10)
	SELECT 'V20001', 'Do Bao Phap', 'NAM', TO_DATE('12/01/1992', 'DD/MM/YYYY'), 2124, '09174882669', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20002', 'Ly Da Nguyet', 'NU', TO_DATE('28/03/1985', 'DD/MM/YYYY'), 773, '09804104706', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20003', 'Pham Phuong Phi', 'NAM', TO_DATE('05/02/1984', 'DD/MM/YYYY'), 926, '09711726859', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20004', 'Nguyen Mai Lien', 'NU', TO_DATE('26/09/1997', 'DD/MM/YYYY'), 1972, '09577169947', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20005', 'Nguyen Thuy Quynh', 'NU', TO_DATE('07/02/1992', 'DD/MM/YYYY'), 1731, '09158215036', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20006', 'Hoang Kieu Anh', 'NU', TO_DATE('18/03/1996', 'DD/MM/YYYY'), 565, '09762471146', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20007', 'Pham Kieu Trinh', 'NU', TO_DATE('18/10/1989', 'DD/MM/YYYY'), 1556, '09522614990', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20008', 'Vu Bao Huy', 'NAM', TO_DATE('24/02/1989', 'DD/MM/YYYY'), 1270, '09443021543', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20009', 'Vu Chanh Viet', 'NAM', TO_DATE('10/04/1979', 'DD/MM/YYYY'), 5206, '09959946572', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20010', 'Bui Hai Duyen', 'NU', TO_DATE('14/08/1971', 'DD/MM/YYYY'), 9973, '09434584487', 2, 2 FROM DUAL;
INSERT INTO NHANSU
-- 2.3. GIANG VIEN CNPM (10)
	SELECT 'V30011', 'Tran Bich Ngan', 'NU', TO_DATE('21/05/1985', 'DD/MM/YYYY'), 3404, '09253648946', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30012', 'Nguyen Thien Mai', 'NU', TO_DATE('28/01/1975', 'DD/MM/YYYY'), 2001, '09575071882', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30013', 'Truong Hanh Dung', 'NU', TO_DATE('15/08/1979', 'DD/MM/YYYY'), 652, '09323216809', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30014', 'Huynh Minh Hieu', 'NAM', TO_DATE('29/01/1992', 'DD/MM/YYYY'), 1777, '09775416992', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30015', 'Phan Quynh Tien', 'NU', TO_DATE('22/08/1983', 'DD/MM/YYYY'), 7117, '09350180856', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30016', 'Phan Lan Chi', 'NU', TO_DATE('08/06/1973', 'DD/MM/YYYY'), 1047, '09238110266', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30017', 'Pham Bao Hoang', 'NAM', TO_DATE('25/06/1975', 'DD/MM/YYYY'), 551, '09472980319', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30018', 'Tran Chan Hung', 'NAM', TO_DATE('02/08/1976', 'DD/MM/YYYY'), 4088, '09305647391', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30019', 'Le Tuyet Oanh', 'NU', TO_DATE('05/05/1990', 'DD/MM/YYYY'), 9601, '09081297271', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30020', 'Tran Khanh Giao', 'NU', TO_DATE('09/08/1982', 'DD/MM/YYYY'), 6117, '09175280918', 2, 3 FROM DUAL;
INSERT INTO NHANSU
-- 2.4. GIANG VIEN KHMT (10)
	SELECT 'V40021', 'Ngo Dinh Loc', 'NAM', TO_DATE('04/08/1974', 'DD/MM/YYYY'), 7756, '09083844777', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40022', 'Truong Minh Hue', 'NU', TO_DATE('03/02/1986', 'DD/MM/YYYY'), 1689, '09119131441', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40023', 'Bui Truc Chi', 'NU', TO_DATE('19/06/1995', 'DD/MM/YYYY'), 5390, '09671230253', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40024', 'Hoang Anh Minh', 'NAM', TO_DATE('24/10/1999', 'DD/MM/YYYY'), 7364, '09168097082', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40025', 'Duong Duy An', 'NAM', TO_DATE('06/01/1993', 'DD/MM/YYYY'), 8030, '09319833207', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40026', 'Vo The Trung', 'NAM', TO_DATE('13/01/1998', 'DD/MM/YYYY'), 2904, '09604416975', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40027', 'Dang Boi Linh', 'NU', TO_DATE('22/10/1981', 'DD/MM/YYYY'), 5746, '09844434984', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40028', 'Tran Nhan Hong', 'NU', TO_DATE('11/02/1986', 'DD/MM/YYYY'), 2857, '09597692536', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40029', 'Truong Huu Hung', 'NAM', TO_DATE('24/10/1970', 'DD/MM/YYYY'), 1270, '09863809781', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40030', 'Pham Thuy Ðao', 'NU', TO_DATE('14/09/1985', 'DD/MM/YYYY'), 9990, '09161942987', 2, 4 FROM DUAL;
INSERT INTO NHANSU
-- 2.5. GIANG VIEN CNTT (10)
	SELECT 'V50031', 'Truong Huyen Trang', 'NU', TO_DATE('19/02/1993', 'DD/MM/YYYY'), 7430, '09362219216', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50032', 'Duong Kieu Mai', 'NU', TO_DATE('27/11/1991', 'DD/MM/YYYY'), 8432, '09550066755', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50033', 'Hoang Phuong Nghi', 'NU', TO_DATE('24/08/1985', 'DD/MM/YYYY'), 3762, '09554908420', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50034', 'Dinh Hong Thuy', 'NU', TO_DATE('14/10/1986', 'DD/MM/YYYY'), 3057, '09479014952', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50035', 'Hoang Kim Vuong', 'NAM', TO_DATE('31/08/1979', 'DD/MM/YYYY'), 7066, '09132136132', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50036', 'Ho Ai Thy', 'NU', TO_DATE('24/05/1990', 'DD/MM/YYYY'), 9955, '09653194727', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50037', 'Phan That Cuong', 'NAM', TO_DATE('14/01/1971', 'DD/MM/YYYY'), 8384, '09165814895', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50038', 'Ho Son Tung', 'NAM', TO_DATE('13/02/1972', 'DD/MM/YYYY'), 8288, '09481324391', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50039', 'Vu Tuyet Hong', 'NU', TO_DATE('02/11/1982', 'DD/MM/YYYY'), 3924, '09154416688', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50040', 'Tran Thuong Khang', 'NAM', TO_DATE('13/07/1986', 'DD/MM/YYYY'), 8538, '09979707230', 2, 5 FROM DUAL;
INSERT INTO NHANSU
-- 2.6. GIANG VIEN TGMT (10)
	SELECT 'V60041', 'Pham Xuan Kien', 'NAM', TO_DATE('15/03/1972', 'DD/MM/YYYY'), 8488, '09175463609', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60042', 'Dang Phuong Tien', 'NU', TO_DATE('12/08/1977', 'DD/MM/YYYY'), 8467, '09484278997', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60043', 'Hoang Uy Phong', 'NAM', TO_DATE('16/01/1999', 'DD/MM/YYYY'), 7442, '09539734716', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60044', 'Phan Truc Dao', 'NU', TO_DATE('25/10/1995', 'DD/MM/YYYY'), 2084, '09009924120', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60045', 'Hoang Thien Duc', 'NAM', TO_DATE('16/04/1970', 'DD/MM/YYYY'), 7884, '09968736755', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60046', 'Ly Thao Nhi', 'NU', TO_DATE('12/12/1993', 'DD/MM/YYYY'), 5076, '09648987510', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60047', 'Vu Phuong Nghi', 'NU', TO_DATE('18/09/1996', 'DD/MM/YYYY'), 6887, '09300310032', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60048', 'Vo Nam Thanh', 'NAM', TO_DATE('07/01/1974', 'DD/MM/YYYY'), 4996, '09195093517', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60049', 'Vo Trung Thuc', 'NAM', TO_DATE('24/09/1988', 'DD/MM/YYYY'), 6451, '09156892087', 2, 6 FROM DUAL UNION ALL
	SELECT 'V60050', 'Le Hai Phong', 'NAM', TO_DATE('19/08/1983', 'DD/MM/YYYY'), 3278, '09879535204', 2, 6 FROM DUAL;
INSERT INTO NHANSU
-- 2.7. GIANG VIEN MMT (10)
	SELECT 'V70051', 'Nguyen Viet Yen', 'NU', TO_DATE('28/12/1985', 'DD/MM/YYYY'), 3407, '09632988669', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70052', 'Dinh Ngoc Ðao', 'NU', TO_DATE('17/05/1996', 'DD/MM/YYYY'), 1157, '09298113642', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70053', 'Bui Tuan Thanh', 'NAM', TO_DATE('02/04/1995', 'DD/MM/YYYY'), 3133, '09011499682', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70054', 'Dinh Trung Chinh', 'NAM', TO_DATE('09/09/1981', 'DD/MM/YYYY'), 3472, '09871107222', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70055', 'Nguyen Duc Long', 'NAM', TO_DATE('23/05/1973', 'DD/MM/YYYY'), 9595, '09920292050', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70056', 'Dinh Minh Vu', 'NAM', TO_DATE('31/10/1984', 'DD/MM/YYYY'), 1711, '09536318555', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70057', 'Ngo Tan Dung', 'NAM', TO_DATE('19/10/1973', 'DD/MM/YYYY'), 5346, '09071027805', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70058', 'Pham Van Ly', 'NAM', TO_DATE('15/03/1987', 'DD/MM/YYYY'), 4192, '09779720821', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70059', 'Dinh Xuan Minh', 'NAM', TO_DATE('05/03/1979', 'DD/MM/YYYY'), 8410, '09041642698', 2, 7 FROM DUAL UNION ALL
	SELECT 'V70060', 'Nguyen Mong Lan', 'NU', TO_DATE('25/07/1971', 'DD/MM/YYYY'), 7971, '09470775032', 2, 7 FROM DUAL;
INSERT INTO NHANSU
-- 2.2. GIANG VIEN HTTT (5)
	SELECT 'V20061', 'Nguyen Phuong Thao', 'NU', TO_DATE('02/04/1991', 'DD/MM/YYYY'), 2063, '09736614815', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20062', 'Ho Hai San', 'NU', TO_DATE('25/06/1971', 'DD/MM/YYYY'), 943, '09785063723', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20063', 'Ho An Binh', 'NU', TO_DATE('15/02/1980', 'DD/MM/YYYY'), 4828, '09692404621', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20064', 'Dinh Xuan Thanh', 'NU', TO_DATE('23/02/1985', 'DD/MM/YYYY'), 7280, '09510645493', 2, 2 FROM DUAL UNION ALL
	SELECT 'V20065', 'Duong Thai Binh', 'NAM', TO_DATE('29/12/1982', 'DD/MM/YYYY'), 4547, '09835258751', 2, 2 FROM DUAL UNION ALL
-- 2.3. GIANG VIEN CNPM (5)
	SELECT 'V30066', 'Truong My Duyen', 'NU', TO_DATE('23/05/1993', 'DD/MM/YYYY'), 3938, '09616491842', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30067', 'Bui Lien Huong', 'NU', TO_DATE('13/03/1975', 'DD/MM/YYYY'), 8755, '09055963257', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30068', 'Phan Thai To', 'NAM', TO_DATE('16/03/1989', 'DD/MM/YYYY'), 9668, '09362356081', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30069', 'Bui Duc Anh', 'NAM', TO_DATE('22/11/1981', 'DD/MM/YYYY'), 4474, '09390208559', 2, 3 FROM DUAL UNION ALL
	SELECT 'V30070', 'Dinh Thach Thao', 'NU', TO_DATE('10/08/1973', 'DD/MM/YYYY'), 8456, '09292009236', 2, 3 FROM DUAL UNION ALL
-- 2.4. GIANG VIEN KHMT (5)
	SELECT 'V40071', 'Duong Hoang Long', 'NAM', TO_DATE('05/05/1980', 'DD/MM/YYYY'), 9242, '09219050616', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40072', 'Hoang Nhat Linh', 'NU', TO_DATE('26/11/1981', 'DD/MM/YYYY'), 2626, '09037421323', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40073', 'Nguyen Thi Thi', 'NU', TO_DATE('07/02/1977', 'DD/MM/YYYY'), 7149, '09233674546', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40074', 'Tran Huyen Thoai', 'NU', TO_DATE('14/02/1996', 'DD/MM/YYYY'), 2396, '09604336667', 2, 4 FROM DUAL UNION ALL
	SELECT 'V40075', 'Ly Huu Chau', 'NAM', TO_DATE('03/01/1984', 'DD/MM/YYYY'), 1233, '09053213118', 2, 4 FROM DUAL UNION ALL
-- 2.5. GIANG VIEN CNTT (5)
	SELECT 'V50076', 'Hoang Thao Huong', 'NU', TO_DATE('26/09/1973', 'DD/MM/YYYY'), 6948, '09286026118', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50077', 'Pham Van Tuyen', 'NAM', TO_DATE('04/11/1974', 'DD/MM/YYYY'), 8673, '09467171583', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50078', 'Dinh Xuan Hoa', 'NAM', TO_DATE('24/02/1996', 'DD/MM/YYYY'), 2770, '09782489677', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50079', 'Dang Quynh Huong', 'NU', TO_DATE('11/12/1977', 'DD/MM/YYYY'), 7322, '09233478750', 2, 5 FROM DUAL UNION ALL
	SELECT 'V50080', 'Duong Bao Truc', 'NU', TO_DATE('07/02/1975', 'DD/MM/YYYY'), 3762, '09793385631', 2, 5 FROM DUAL;

/* UPDATE DONVI.TRGDV
 */
UPDATE DONVI SET TRGDV = 'TK0001' WHERE MADV = 1;
DECLARE CAP INT; IX INT := 1;
BEGIN
    SELECT COUNT(MADV) INTO CAP FROM DONVI;
    LOOP
        EXECUTE IMMEDIATE 'UPDATE DONVI SET TRGDV = ''TD'
            || LPAD(IX, 4, '0') || ''' WHERE MADV = ' || (IX + 1);
        IX := IX + 1;
        EXIT WHEN IX = CAP;
    END LOOP;
END;
/

/* SINHVIEN
 */
INSERT INTO SINHVIEN
-- 1. SINH VIEN HTTT
--	1. CQ
	SELECT 'S10001', 'Ho Hai Duyen', 'NU', TO_DATE('04/07/2000', 'DD/MM/YYYY'), '54B duong Quan 8, phuong Cua Dong, Quan 12, Thanh pho Tra Vinh, Tinh Tra Vinh', '09901102603', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10002', 'Tran Cam Nhi', 'NU', TO_DATE('22/07/2001', 'DD/MM/YYYY'), '358/13Z duong Hong Bang, phuong Cua Nam, Thanh pho Ha Giang, Tinh Ha Giang', '09295615023', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10003', 'Vo My Xuan', 'NU', TO_DATE('03/07/2003', 'DD/MM/YYYY'), '18/41 duong Le Chan, phuong Lac Vien, Quan 10, Thanh pho Ha Tinh, Tinh Ha Tinh', '09729150198', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10004', 'Tran Quoc Toan', 'NAM', TO_DATE('20/01/2004', 'DD/MM/YYYY'), '15/11H duong Tay Ho, phuong Da Kao, quan Bac Tu Liem, Thanh pho Ben Tre, Tinh Ben Tre', '09033967798', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10005', 'Le Xuan Lac', 'NAM', TO_DATE('15/01/2001', 'DD/MM/YYYY'), '147/17 duong Hai Ba Trung, phuong May To, Thanh pho Phan Thiet, Tinh Binh Thuan', '09245501649', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20006', 'Pham Bao Dinh', 'NAM', TO_DATE('20/03/2000', 'DD/MM/YYYY'), '327L duong Binh Tan, phuong Hoa Tho Tay, Thanh pho Hue, Tinh Thua Thien Hue', '09916101939', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20007', 'Bui Thanh Tinh', 'NAM', TO_DATE('25/03/2001', 'DD/MM/YYYY'), '62 duong Quan 12, phuong Cua Dong, quan Lien Chieu, Thanh pho Tuy Hoa, Tinh Phu Yen', '09514372983', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20008', 'Huynh Canh Tuan', 'NAM', TO_DATE('02/07/2005', 'DD/MM/YYYY'), '343N duong Son Tra, phuong Thanh Khe Dong, Thanh pho Bac Kan, Tinh Bac Kan', '09317409036', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20009', 'Dang Hoa Thai', 'NAM', TO_DATE('08/01/2003', 'DD/MM/YYYY'), '103 duong Tan Binh, phuong Dong Nhan, Thanh pho Ninh Binh, Tinh Ninh Binh', '09596631449', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20010', 'Vu Quan Duong', 'NAM', TO_DATE('12/09/2001', 'DD/MM/YYYY'), '52 duong Lien Chieu, phuong Dien Bien, Quan 12, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09086057671', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30011', 'Do Hoang Hai', 'NAM', TO_DATE('08/03/2000', 'DD/MM/YYYY'), '248/6 duong Nam Tu Liem, phuong Linh Nam, quan Duong Kinh, Thanh pho Dong Hoi, Tinh Quang Binh', '09156688487', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30012', 'Huynh Lien Hoa', 'NU', TO_DATE('25/06/2003', 'DD/MM/YYYY'), '82/22C duong Quan 7, phuong Hoa Khanh Nam, Thanh pho Phan Rang - Thap Cham, Tinh Ninh Thuan', '09813942256', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30013', 'Dang Quang Trung', 'NAM', TO_DATE('17/09/2005', 'DD/MM/YYYY'), '291/22 duong Tan Phu, phuong Tan Tao, Thanh pho Vinh Long, Tinh Vinh Long', '09628401567', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30014', 'Ngo Tam Linh', 'NU', TO_DATE('29/06/2000', 'DD/MM/YYYY'), '196S duong Tan Binh, phuong Yet Kieu, quan Nam Tu Liem, Thanh pho Can Tho', '09214035556', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30015', 'Dang Hong Ðiep', 'NU', TO_DATE('24/11/2002', 'DD/MM/YYYY'), '235M duong Lien Chieu, phuong Thoi Hoa, Thanh pho Dien Bien Phu, Tinh Dien Bien', '09097875856', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40016', 'Dinh Huu Trac', 'NAM', TO_DATE('06/12/2003', 'DD/MM/YYYY'), '370 duong Ba Dinh, phuong Tan Quy, quan Ngu Hanh Son, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09998342532', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40017', 'Vo Cong Thanh', 'NAM', TO_DATE('04/05/2003', 'DD/MM/YYYY'), '151/41L duong Cau Giay, phuong Dong Mac, quan Hong Bang, Thanh pho Tay Ninh, Tinh Tay Ninh', '09487189727', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40018', 'Dang Nguyet Nga', 'NU', TO_DATE('21/03/2001', 'DD/MM/YYYY'), '43 duong Quan 11, phuong Nguyen Thai Binh, Quan 3, Thanh pho Bac Lieu, Tinh Bac Lieu', '09121598892', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40019', 'Ly Cong Hao', 'NAM', TO_DATE('19/06/2000', 'DD/MM/YYYY'), '136/11 duong O Mon, phuong Nguyen Trai, Quan 8, Thanh pho Cao Bang, Tinh Cao Bang', '09998013488', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40020', 'Dinh Minh Nguyet', 'NU', TO_DATE('09/09/2003', 'DD/MM/YYYY'), '355U duong Cau Giay, phuong An Phu Dong, quan O Mon, Thanh pho Quang Ngai, Tinh Quang Ngai', '09883782731', 'VP', 'HTTT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 2. SINH VIEN CNPM
--	1. CQ
	SELECT 'S10021', 'Vo Tuan Long', 'NAM', TO_DATE('06/05/2001', 'DD/MM/YYYY'), '125/6T duong Hoan Kiem, phuong Minh Duc, Thanh pho Tra Vinh, Tinh Tra Vinh', '09548527485', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10022', 'Dinh Que Linh', 'NU', TO_DATE('25/04/2003', 'DD/MM/YYYY'), '54/27E duong Quan 12, Phuong 17, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09284576185', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10023', 'Bui Thuan Anh', 'NAM', TO_DATE('03/03/2002', 'DD/MM/YYYY'), '168/34 duong Ninh Kieu, Phuong 3, quan Nam Tu Liem, Thanh pho Hai Duong, Tinh Hai Duong', '09107861238', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10024', 'Tran Thuy Anh', 'NU', TO_DATE('18/03/2001', 'DD/MM/YYYY'), '357V duong Nam Tu Liem, phuong Cau Dat, Thanh pho Tuy Hoa, Tinh Phu Yen', '09729203085', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10025', 'Do Hieu Liem', 'NAM', TO_DATE('30/07/2000', 'DD/MM/YYYY'), '6/29 duong Ninh Kieu, phuong Khue My, quan Son Tra, Thanh pho Ba Ria, Tinh Ba Ria - Vung Tau', '09308883496', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20026', 'Vu Hanh Nhon', 'NU', TO_DATE('24/03/2000', 'DD/MM/YYYY'), '129/42 duong Lien Chieu, phuong Tran Hung Dao, quan Cau Giay, Thanh pho Ninh Binh, Tinh Ninh Binh', '09780796678', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20027', 'Le Quang Hung', 'NAM', TO_DATE('17/05/2003', 'DD/MM/YYYY'), '219V duong Duong Kinh, phuong Hoa Xuan, Thanh pho Thai Binh, Tinh Thai Binh', '09004403365', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20028', 'Bui Lap Thanh', 'NAM', TO_DATE('11/05/2001', 'DD/MM/YYYY'), '138/26I duong Hong Bang, phuong Nghia Tan, quan Hai An, Thanh pho My Tho, Tinh Tien Giang', '09419638672', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20029', 'Vo Phuoc Hue', 'NU', TO_DATE('12/10/2002', 'DD/MM/YYYY'), '380/33D duong Dong Da, phuong Vinh Tuy, quan Thanh Xuan, Thanh pho Vinh Long, Tinh Vinh Long', '09943174078', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20030', 'Nguyen Ba Loc', 'NAM', TO_DATE('24/08/2001', 'DD/MM/YYYY'), '293 duong Son Tra, phuong Dai Kim, Thanh pho Bac Lieu, Tinh Bac Lieu', '09458086147', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30031', 'Dinh Hung Cuong', 'NAM', TO_DATE('09/09/2004', 'DD/MM/YYYY'), '361/38Y duong Hoang Mai, phuong Trang Tien, Quan 7, Thanh pho Tuy Hoa, Tinh Phu Yen', '09918962740', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30032', 'Le Huong Duong', 'NAM', TO_DATE('03/03/2005', 'DD/MM/YYYY'), '313/37E duong Go Vap, phuong Xuan Tao, quan Thanh Xuan, Thanh pho Phan Thiet, Tinh Binh Thuan', '09037466012', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30033', 'Tran Dan Tam', 'NU', TO_DATE('29/10/2000', 'DD/MM/YYYY'), '65/30 duong Lien Chieu, phuong Thanh To, Thanh pho Cao Lanh, Tinh Dong Thap', '09677021026', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30034', 'Dang Thoi Nhiem', 'NAM', TO_DATE('07/01/2004', 'DD/MM/YYYY'), '106/29 duong Hoang Mai, phuong Tan Tao A, Thanh pho Tam Ky, Tinh Quang Nam', '09137014347', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30035', 'Ngo Phong Do', 'NAM', TO_DATE('26/08/2005', 'DD/MM/YYYY'), '377/17P duong Cai Rang, Phuong 17, Thanh pho Da Lat, Tinh Lam Dong', '09246408579', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40036', 'Tran Thien Tien', 'NU', TO_DATE('04/01/2002', 'DD/MM/YYYY'), '282P duong Nam Tu Liem, phuong Xuan Tao, Thanh pho Quy Nhon, Tinh Binh Dinh', '09003830819', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40037', 'Ho Gia Khiem', 'NAM', TO_DATE('16/07/2001', 'DD/MM/YYYY'), '241/15 duong Quan 6, phuong Trung Liet, quan Hoan Kiem, Thanh pho Quy Nhon, Tinh Binh Dinh', '09780244172', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40038', 'Bui Gia Phuc', 'NAM', TO_DATE('05/05/2004', 'DD/MM/YYYY'), '78/41H duong Lien Chieu, phuong Lach Tray, quan Tan Phu, Thanh pho Ha Noi', '09733966598', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40039', 'Ho Ngoc Hanh', 'NU', TO_DATE('29/09/2004', 'DD/MM/YYYY'), '198 duong Do Son, phuong Trang Minh, Thanh pho Viet Tri, Tinh Phu Tho', '09847994651', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40040', 'Hoang Cong Lap', 'NAM', TO_DATE('24/04/2002', 'DD/MM/YYYY'), '290 duong Ninh Kieu, phuong Thoi An Dong, Thanh pho Can Tho', '09474389882', 'VP', 'CNPM', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 3. SINH VIEN KHMT
--	1. CQ
	SELECT 'S10041', 'Dinh Hai Giang', 'NAM', TO_DATE('30/09/2002', 'DD/MM/YYYY'), '249L duong Quan 4, phuong Thuan An, Thanh pho Tam Ky, Tinh Quang Nam', '09091329499', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10042', 'Truong Buu Chuong', 'NAM', TO_DATE('10/03/2001', 'DD/MM/YYYY'), '135/14 duong Quan 4, phuong Thoi Long, Thanh pho Ninh Binh, Tinh Ninh Binh', '09658407845', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10043', 'Le Hai Quan', 'NAM', TO_DATE('02/01/2002', 'DD/MM/YYYY'), '163/35U duong Binh Thuy, phuong An Binh, Thanh pho Long Xuyen, Tinh An Giang', '09144659491', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10044', 'Do Kim Hoang', 'NAM', TO_DATE('04/05/2000', 'DD/MM/YYYY'), '115/24 duong Kien An, phuong Trung Hoa, quan O Mon, Thanh pho Quang Ngai, Tinh Quang Ngai', '09903188205', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10045', 'Ly Huyen Thoai', 'NU', TO_DATE('15/05/2000', 'DD/MM/YYYY'), '107/25 duong Hai Chau, phuong Thuong Dinh, Thanh pho Ha Long, Tinh Quang Ninh', '09870454619', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20046', 'Vu Quang Lan', 'NAM', TO_DATE('09/12/2002', 'DD/MM/YYYY'), '373/19 duong Quan 7, phuong Hoa Hai, quan Duong Kinh, Thanh pho Ha Noi', '09689589123', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20047', 'Vu Dinh Hop', 'NAM', TO_DATE('14/04/2004', 'DD/MM/YYYY'), '141V duong Hai An, phuong Duc Giang, quan Thot Not, Thanh pho Kon Tum, Tinh Kon Tum', '09424583119', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20048', 'Bui Nguyet Cam', 'NU', TO_DATE('13/03/2003', 'DD/MM/YYYY'), '265/16N duong Quan 7, phuong Hoa Minh, quan Hong Bang, Thanh pho Lai Chau, Tinh Lai Chau', '09285876168', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20049', 'Ly Minh Hung', 'NAM', TO_DATE('10/10/2001', 'DD/MM/YYYY'), '356/24 duong Binh Thanh, phuong Cau Ong Lanh, Thanh pho Gia Nghia, Tinh Dak Nong', '09878277209', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20050', 'Bui Nghi Luc', 'NAM', TO_DATE('16/03/2000', 'DD/MM/YYYY'), '197W duong Long Bien, phuong Phuc Dien, Thanh pho Thai Binh, Tinh Thai Binh', '09535734165', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30051', 'Phan Minh Tu', 'NAM', TO_DATE('26/07/2000', 'DD/MM/YYYY'), '372/4 duong Ninh Kieu, phuong Cau Ong Lanh, Thanh pho My Tho, Tinh Tien Giang', '09636027829', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30052', 'Vo Thanh Tuan', 'NAM', TO_DATE('10/08/2003', 'DD/MM/YYYY'), '192/37K duong Go Vap, phuong Kim Lien, quan Dong Da, Thanh pho Hai Duong, Tinh Hai Duong', '09510957214', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30053', 'Duong Huong Xuan', 'NU', TO_DATE('27/08/2005', 'DD/MM/YYYY'), '48/47 duong Ngu Hanh Son, phuong Ha Dinh, Thanh pho Dien Bien Phu, Tinh Dien Bien', '09314064431', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30054', 'Bui Duc Phi', 'NAM', TO_DATE('10/09/2001', 'DD/MM/YYYY'), '262 duong Quan 1, phuong Yen So, quan Son Tra, Thanh pho Bac Ninh, Tinh Bac Ninh', '09864062257', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30055', 'Truong Hai Mien', 'NU', TO_DATE('29/01/2005', 'DD/MM/YYYY'), '251/43 duong Thanh Khe, Phuong 16, Thanh pho Dong Hoi, Tinh Quang Binh', '09808780654', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40056', 'Vu My Dung', 'NU', TO_DATE('26/02/2003', 'DD/MM/YYYY'), '116/1T duong Quan 6, phuong Hung Vuong, Thanh pho Quang Ngai, Tinh Quang Ngai', '09892735073', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40057', 'Tran Huyen Thoai', 'NU', TO_DATE('12/09/2000', 'DD/MM/YYYY'), '112 duong Quan 10, phuong Binh Hung Hoa, Thanh pho Hai Phong', '09236510505', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40058', 'Hoang Dan Tam', 'NAM', TO_DATE('15/10/2001', 'DD/MM/YYYY'), '195 duong Ha Dong, phuong Truc Bach, Quan 12, Thanh pho Long Xuyen, Tinh An Giang', '09532238597', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40059', 'Le Minh Huan', 'NAM', TO_DATE('21/04/2000', 'DD/MM/YYYY'), '33/16N duong Cam Le, phuong Xuan Ha, Thanh pho Soc Trang, Tinh Soc Trang', '09642359466', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40060', 'Huynh Ha Tien', 'NU', TO_DATE('05/10/2000', 'DD/MM/YYYY'), '108/26 duong Quan 10, phuong Binh Tri Dong, Thanh pho Ben Tre, Tinh Ben Tre', '09954555250', 'VP', 'KHMT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 4. SINH VIEN CNTT
--	1. CQ
	SELECT 'S10061', 'Dang Vang Anh', 'NU', TO_DATE('12/12/2002', 'DD/MM/YYYY'), '145 duong Hong Bang, phuong Cu Khoi, Thanh pho Hai Duong, Tinh Hai Duong', '09649113871', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10062', 'Do Hoang Sa', 'NU', TO_DATE('07/06/2004', 'DD/MM/YYYY'), '326X duong Long Bien, phuong Trung Hoa, Thanh pho Tay Ninh, Tinh Tay Ninh', '09784448424', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10063', 'Ly The Nang', 'NAM', TO_DATE('04/06/2005', 'DD/MM/YYYY'), '171/44D duong Hoang Mai, phuong Lieu Giai, quan Hoan Kiem, Thanh pho Hue, Tinh Thua Thien Hue', '09093525853', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10064', 'Ly Hong Chau', 'NU', TO_DATE('04/11/2005', 'DD/MM/YYYY'), '373/25H duong Quan 12, phuong Xuan La, Thanh pho Ha Noi', '09978702520', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10065', 'Dang Truong Vinh', 'NAM', TO_DATE('28/10/2001', 'DD/MM/YYYY'), '307K duong Hong Bang, phuong Trang Tien, Thanh pho Bien Hoa, Tinh Dong Nai', '09543183817', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20066', 'Le An Co', 'NAM', TO_DATE('06/01/2003', 'DD/MM/YYYY'), '231G duong Hong Bang, Phuong 24, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09828513421', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20067', 'Do Hiep Hao', 'NAM', TO_DATE('22/04/2003', 'DD/MM/YYYY'), '286/39 duong Hai Chau, phuong Viet Hung, quan Dong Da, Thanh pho Ha Noi', '09694390268', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20068', 'Bui Quoc Vinh', 'NAM', TO_DATE('10/04/2003', 'DD/MM/YYYY'), '19 duong Quan 1, phuong Dien Bien, quan Le Chan, Thanh pho Dong Hoi, Tinh Quang Binh', '09512241256', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20069', 'Ho Thien Manh', 'NAM', TO_DATE('18/10/2000', 'DD/MM/YYYY'), '3/20 duong Hai An, phuong Van Quan, Thanh pho Hung Yen, Tinh Hung Yen', '09802677572', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20070', 'Bui Khoi Vi', 'NAM', TO_DATE('20/04/2002', 'DD/MM/YYYY'), '277 duong Lien Chieu, Phuong Canh, Thanh pho Gia Nghia, Tinh Dak Nong', '09257983733', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30071', 'Vu Ngoc Canh', 'NAM', TO_DATE('18/01/2004', 'DD/MM/YYYY'), '159 duong Tan Binh, phuong Nam Son, Thanh pho Ha Giang, Tinh Ha Giang', '09639810350', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30072', 'Truong Long Giang', 'NAM', TO_DATE('05/12/2005', 'DD/MM/YYYY'), '145/47H duong Quan 12, phuong Dong Nhan, Thanh pho Hai Phong', '09877878116', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30073', 'Phan Thien Theu', 'NU', TO_DATE('11/08/2003', 'DD/MM/YYYY'), '90/26G duong Quan 7, phuong Sai Dong, Thanh pho Bac Ninh, Tinh Bac Ninh', '09336807978', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30074', 'Nguyen Hoang Kim', 'NU', TO_DATE('13/03/2003', 'DD/MM/YYYY'), '71/46O duong Phu Nhuan, phuong Thanh Loc, Thanh pho Bac Lieu, Tinh Bac Lieu', '09546517127', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30075', 'Ngo Nhat Hoang', 'NAM', TO_DATE('01/07/2001', 'DD/MM/YYYY'), '106/29 duong Quan 7, Phuong 21, Quan 8, Thanh pho Thu Dau Mot, Tinh Binh Duong', '09339570752', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40076', 'Nguyen Duy Thong', 'NAM', TO_DATE('09/03/2004', 'DD/MM/YYYY'), '194/44T duong Quan 8, phuong Tan Phu, Thanh pho My Tho, Tinh Tien Giang', '09030705837', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40077', 'Pham Thanh Kieu', 'NU', TO_DATE('26/07/2003', 'DD/MM/YYYY'), '145 duong Thot Not, phuong Hoang Van Thu, Quan 12, Thanh pho Quy Nhon, Tinh Binh Dinh', '09067855365', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40078', 'Hoang Kim Thu', 'NU', TO_DATE('05/11/2001', 'DD/MM/YYYY'), '134/11 duong Ngo Quyen, phuong Dang Lam, Quan 12, Thanh pho Lai Chau, Tinh Lai Chau', '09826447488', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40079', 'Vu Truong Chinh', 'NAM', TO_DATE('01/12/2000', 'DD/MM/YYYY'), '25/1I duong Quan 3, phuong Ngoc Khanh, Thanh pho Viet Tri, Tinh Phu Tho', '09871780934', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40080', 'Dang Dieu Nga', 'NU', TO_DATE('14/06/2000', 'DD/MM/YYYY'), '273 duong Son Tra, Xuan Phuong, Thanh pho Da Lat, Tinh Lam Dong', '09229090899', 'VP', 'CNTT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 5. SINH VIEN TGMT
--	1. CQ
	SELECT 'S10081', 'Dinh Thu Suong', 'NU', TO_DATE('10/04/2003', 'DD/MM/YYYY'), '313J duong Quan 11, phuong Dong Mai, Thanh pho Bac Ninh, Tinh Bac Ninh', '09257332751', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10082', 'Ly Khac Minh', 'NAM', TO_DATE('09/11/2003', 'DD/MM/YYYY'), '132Z duong Hoang Mai, phuong Hoa Thuan Tay, Thanh pho Tra Vinh, Tinh Tra Vinh', '09411692557', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10083', 'Hoang Vuong Trieu', 'NAM', TO_DATE('22/05/2001', 'DD/MM/YYYY'), '213S duong Cam Le, phuong Cau Den, quan Duong Kinh, Thanh pho Quy Nhon, Tinh Binh Dinh', '09153238418', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10084', 'Nguyen Khoi Phong', 'NAM', TO_DATE('15/08/2004', 'DD/MM/YYYY'), '260/36 duong Cau Giay, phuong Dai Mo, Thanh pho Vi Thanh, Tinh Hau Giang', '09382017165', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10085', 'Le Phuong Bich', 'NU', TO_DATE('09/04/2005', 'DD/MM/YYYY'), '1U duong Quan 12, phuong Hung Thanh, quan Cai Rang, Thanh pho Bac Kan, Tinh Bac Kan', '09513612446', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20086', 'Truong Thanh Nhan', 'NAM', TO_DATE('22/07/2005', 'DD/MM/YYYY'), '27/46 duong Phu Nhuan, phuong Hung Loi, quan Hai Ba Trung, Thanh pho Ninh Binh, Tinh Ninh Binh', '09944592933', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20087', 'Vu Ngoc Diep', 'NU', TO_DATE('16/11/2003', 'DD/MM/YYYY'), '158/17I duong Binh Thuy, phuong Phuc La, Thanh pho Buon Ma Thuot, Tinh Dak Lak', '09377720142', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20088', 'Dang Duc Quang', 'NAM', TO_DATE('27/11/2000', 'DD/MM/YYYY'), '329/9H duong Tan Phu, phuong Tan Thanh, Quan 3, Thanh pho Tam Ky, Tinh Quang Nam', '09539143935', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20089', 'Tran Viet Cuong', 'NAM', TO_DATE('04/03/2004', 'DD/MM/YYYY'), '310 duong Cau Giay, phuong Binh Hung Hoa A, Thanh pho Tay Ninh, Tinh Tay Ninh', '09194959785', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20090', 'Phan Ham Y', 'NU', TO_DATE('06/08/2001', 'DD/MM/YYYY'), '88/34 duong Ngo Quyen, phuong Lam Ha, quan Duong Kinh, Thanh pho Vinh, Tinh Nghe An', '09885520208', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30091', 'Hoang Minh Quang', 'NAM', TO_DATE('12/12/2004', 'DD/MM/YYYY'), '25V duong Go Vap, phuong Phu Lien, quan Hai Ba Trung, Thanh pho Hoa Binh, Tinh Hoa Binh', '09048865482', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30092', 'Nguyen Nhat Quang', 'NAM', TO_DATE('03/03/2005', 'DD/MM/YYYY'), '244/30F duong Tan Binh, phuong Thuong Dinh, Thanh pho Yen Bai, Tinh Yen Bai', '09906132024', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30093', 'Bui Phuong Lien', 'NU', TO_DATE('07/04/2004', 'DD/MM/YYYY'), '248/49 duong Hoang Mai, phuong Long Hung, Thanh pho Buon Ma Thuot, Tinh Dak Lak', '09089051329', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30094', 'Tran Hoang Mien', 'NU', TO_DATE('16/05/2000', 'DD/MM/YYYY'), '297A duong Quan 1, phuong Kim Lien, quan Hai Ba Trung, Thanh pho Vinh, Tinh Nghe An', '09121365995', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30095', 'Vo Cong Son', 'NAM', TO_DATE('29/12/2005', 'DD/MM/YYYY'), '112/39 duong Binh Thanh, phuong Thoi Hoa, quan Lien Chieu, Thanh pho Long Xuyen, Tinh An Giang', '09037809369', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40096', 'Vo Thuy Du', 'NU', TO_DATE('14/05/2002', 'DD/MM/YYYY'), '80/47 duong Quan 6, phuong An Hai Bac, Thanh pho Vinh, Tinh Nghe An', '09126823934', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40097', 'Truong Minh Ly', 'NAM', TO_DATE('02/12/2005', 'DD/MM/YYYY'), '292/22F duong Cau Giay, phuong Gia Thuy, Thanh pho Thai Binh, Tinh Thai Binh', '09236189183', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40098', 'Dinh Thao Hong', 'NU', TO_DATE('06/10/2000', 'DD/MM/YYYY'), '53/14S duong Tan Binh, phuong Cat Bi, Quan 1, Thanh pho Phan Rang - Thap Cham, Tinh Ninh Thuan', '09089025497', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40099', 'Huynh Tieu My', 'NU', TO_DATE('19/11/2004', 'DD/MM/YYYY'), '259/49 duong O Mon, phuong Nguyen Trai, Thanh pho Ha Noi', '09995989582', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40100', 'Dang Lien Tran', 'NU', TO_DATE('29/10/2002', 'DD/MM/YYYY'), '301 duong Binh Tan, phuong Tan Thoi Nhat, Thanh pho Lai Chau, Tinh Lai Chau', '09267964509', 'VP', 'TGMT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 6. SINH VIEN MMT
--	1. CQ
	SELECT 'S10101', 'Vu Bich Thu', 'NU', TO_DATE('12/07/2000', 'DD/MM/YYYY'), '113 duong Hai Ba Trung, phuong Hoa Thuan Dong, Thanh pho Long Xuyen, Tinh An Giang', '09474510822', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10102', 'Nguyen Hanh Linh', 'NU', TO_DATE('06/02/2000', 'DD/MM/YYYY'), '349D duong Do Son, Phuong 24, Quan 3, Thanh pho Buon Ma Thuot, Tinh Dak Lak', '09764619344', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10103', 'Ly Minh Huy', 'NAM', TO_DATE('06/01/2005', 'DD/MM/YYYY'), '28/30 duong Quan 11, phuong Truong Dinh, quan Nam Tu Liem, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09269554150', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10104', 'Vu Nhu Khang', 'NAM', TO_DATE('04/04/2001', 'DD/MM/YYYY'), '185 duong Quan 7, phuong Thanh Xuan Trung, quan Ha Dong, Thanh pho Ben Tre, Tinh Ben Tre', '09388098498', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S10105', 'Nguyen Loc Uyen', 'NU', TO_DATE('22/01/2005', 'DD/MM/YYYY'), '360 duong Long Bien, phuong Dong Nhan, Thanh pho Dong Xoai, Tinh Binh Phuoc', '09345951090', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'S20106', 'Truong Phi Hai', 'NAM', TO_DATE('16/12/2000', 'DD/MM/YYYY'), '254/7 duong Son Tra, phuong Dong Mac, Quan 8, Thanh pho Kon Tum, Tinh Kon Tum', '09547187903', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20107', 'Duong Duc Tue', 'NAM', TO_DATE('13/11/2005', 'DD/MM/YYYY'), '36 duong Binh Tan, phuong Lach Tray, Thanh pho Tuy Hoa, Tinh Phu Yen', '09049921906', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20108', 'Truong Duy Thanh', 'NAM', TO_DATE('04/02/2000', 'DD/MM/YYYY'), '150/31T duong Lien Chieu, phuong Van Mieu, quan Tan Phu, Thanh pho Thanh Hoa, Tinh Thanh Hoa', '09061426542', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20109', 'Huynh Chien Thang', 'NAM', TO_DATE('08/12/2003', 'DD/MM/YYYY'), '136 duong Ha Dong, phuong Trung Hoa, quan Ngo Quyen, Thanh pho Dong Xoai, Tinh Binh Phuoc', '09406014245', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S20110', 'Hoang Van Thang', 'NAM', TO_DATE('04/12/2005', 'DD/MM/YYYY'), '13/2K duong Tan Phu, phuong Tay Mo, quan Hoan Kiem, Thanh pho Nam Dinh, Tinh Nam Dinh', '09367370468', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'S30111', 'Le Viet Khang', 'NAM', TO_DATE('10/06/2001', 'DD/MM/YYYY'), '110/33J duong Tan Binh, phuong Tan Phu, Thanh pho Son La, Tinh Son La', '09830343697', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30112', 'Nguyen Thai Duong', 'NAM', TO_DATE('11/07/2002', 'DD/MM/YYYY'), '4 duong Tay Ho, Phuong 8, Quan 1, Thanh pho Phu Ly, Tinh Ha Nam', '09488448110', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30113', 'Phan Nhat Thinh', 'NAM', TO_DATE('29/03/2005', 'DD/MM/YYYY'), '178F duong Quan 1, phuong Bach Khoa, Thanh pho Ha Long, Tinh Quang Ninh', '09024323328', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30114', 'Pham Gia Phuoc', 'NAM', TO_DATE('21/05/2000', 'DD/MM/YYYY'), '88/41 duong Binh Thuy, phuong Phan Boi Chau, quan Ngu Hanh Son, Thanh pho Da Lat, Tinh Lam Dong', '09214304807', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S30115', 'Dinh Hai Vy', 'NU', TO_DATE('14/05/2001', 'DD/MM/YYYY'), '161/27F duong Hai An, phuong Hoa Thuan Dong, Thanh pho Lai Chau, Tinh Lai Chau', '09975597818', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'S40116', 'Phan Manh Quynh', 'NAM', TO_DATE('01/04/2002', 'DD/MM/YYYY'), '174P duong Bac Tu Liem, phuong An Lac, Thanh pho Ha Long, Tinh Quang Ninh', '09953789284', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40117', 'Pham Thuc Tam', 'NU', TO_DATE('15/05/2000', 'DD/MM/YYYY'), '192 duong Thanh Xuan, Phuong 4, quan Hoan Kiem, Thanh pho Son La, Tinh Son La', '09506492978', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40118', 'Le Thuy Tram', 'NU', TO_DATE('26/05/2002', 'DD/MM/YYYY'), '153B duong Do Son, phuong Hung Phu, Thanh pho Phan Rang - Thap Cham, Tinh Ninh Thuan', '09362853790', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40119', 'Ly Quang Minh', 'NAM', TO_DATE('12/06/2001', 'DD/MM/YYYY'), '256/33U duong Ngu Hanh Son, phuong Nguyen Thai Binh, Thanh pho Thanh Hoa, Tinh Thanh Hoa', '09406997346', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'S40120', 'Hoang Mai Thy', 'NU', TO_DATE('22/06/2003', 'DD/MM/YYYY'), '253/20V duong Duong Kinh, phuong An Duong, quan Hoan Kiem, Thanh pho Cao Bang, Tinh Cao Bang', '09056274293', 'VP', 'MMT', 0, 0 FROM DUAL;

/* HOCPHAN
 */
INSERT INTO HOCPHAN
-- 1. VAN PHONG KHOA
--	BAT BUOC
	SELECT '110001', 'Triet hoc Mac - Lenin', 3, 45, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110002', 'Kinh te chinh tri Mac - Lenin', 2, 30, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110003', 'Chu nghia xa hoi khoa hoc', 2, 30, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110004', 'Lich su Dang Cong san Viet Nam', 2, 30, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110005', 'Tu tuong Ho Chi Minh', 2, 30, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110006', 'Nhap mon lap trinh', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110007', 'Ky thuat lap trinh', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110008', 'Phuong phap lap trinh huong doi tuong', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110009', 'Cau truc du lieu va giai thuat', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110010', 'Co so du lieu', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110011', 'He dieu hanh', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110012', 'Mang may tinh', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110013', 'He thong may tinh', 2, 30, 0, 100, 1 FROM DUAL UNION ALL
	SELECT '110014', 'Nhap mon cong nghe phan mem', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '110015', 'Co so tri tue nhan tao', 4, 45, 30, 100, 1 FROM DUAL UNION ALL
--	TU CHON
	SELECT '120001', 'Ky nang mem', 3, 30, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '120002', 'Kien tap nghe nghiep', 2, 15, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '120003', 'Khoi nghiep', 3, 30, 30, 100, 1 FROM DUAL UNION ALL
	SELECT '120004', 'Thuc tap thuc te', 4, 30, 60, 100, 1 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '130001', 'Khoa luan tot nghiep', 10, 0, 300, 100, 1 FROM DUAL UNION ALL
	SELECT '130002', 'Thuc tap tot nghiep', 10, 0, 300, 100, 1 FROM DUAL UNION ALL
	SELECT '130003', 'Thuc tap du an tot nghiep', 6, 0, 180, 100, 1 FROM DUAL;
INSERT INTO HOCPHAN
-- 2. BO MON HTTT
--	BAT BUOC
	SELECT '210001', 'An toan va bao mat du lieu trong he thong thong tin', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '210002', 'Co so du lieu nang cao', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '210003', 'He quan tri co so du lieu', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '210004', 'Phan tich thiet ke he thong thong tin', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '210005', 'Phat trien ung dung he thong thong tin hien dai', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
--	TU CHON
	SELECT '220001', 'Chuyen de chon loc trong He thong thong tin', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220002', 'Chuyen de He quan tri co so du lieu nang cao', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220003', 'Thuong mai dien tu', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220004', 'Tuong tac nguoi - may', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220005', 'He thong thong tin doanh nghiep', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220006', 'Phan tich du lieu ung dung', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '220007', 'Truc quan hoa du lieu', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '230001', 'He thong thong tin phuc vu tri tue kinh doanh', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '230002', 'Ung dung phan tan', 4, 45, 30, 100, 2 FROM DUAL UNION ALL
	SELECT '230003', 'Quan tri co so du lieu hien dai', 4, 45, 30, 100, 2 FROM DUAL;
INSERT INTO HOCPHAN
-- 3. BO MON CNPM
--	BAT BUOC
	SELECT '310001', 'Kiem thu phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310002', 'Phan tich va quan ly yeu cau phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310003', 'Quan ly du an phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310004', 'Phat trien game', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310005', 'Phat trien ung dung web', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310006', 'Phat trien phan mem cho thiet bi di dong', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310007', 'Thiet ke phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310008', 'Kien truc phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '310009', 'Thiet ke giao dien', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
--	TU CHON
	SELECT '320001', 'Lap trinh Windows', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320002', 'Cac chu de nang cao trong Cong nghe phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320003', 'Lap trinh ung dung Java', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320004', 'Cong nghe Java cho he thong phan tan', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320005', 'Mau thiet ke huong doi tuong va ung dung', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320006', 'Mo hinh hoa phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '320007', 'Nhap mon lap trinh dieu khien thiet bi thong minh', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '330001', 'Phat trien ung dung web nang cao', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '330002', 'Cac cong nghe moi trong phat trien phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '330003', 'Do an Cong nghe phan mem', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '330004', 'Phat trien game nang cao', 4, 45, 30, 100, 3 FROM DUAL UNION ALL
	SELECT '330005', 'Phat trien ung dung cho thiet bi di dong nang cao', 4, 45, 30, 100, 3 FROM DUAL;
INSERT INTO HOCPHAN
-- 4. BO MON KHMT
--	BAT BUOC
	SELECT '410001', 'Automata va ngon ngu hinh thuc', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410002', 'Cac he co so tri thuc', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410003', 'Khai thac du lieu va ung dung', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410004', 'Nhap mon hoc may', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410005', 'Nhan dang', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410006', 'An du lieu va chia se thong tin', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410007', 'Nhap mon thiet ke va phan tich giai thuat', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410008', 'Lap trinh song song', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410009', 'Tri tue nhan tao cho an ninh thong tin', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410010', 'Phuong phap toan cho toi uu', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410011', 'Tri tue bay dan', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '410012', 'Nhap mon he thong da tac nhan', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
--	TU CHON
	SELECT '420001', 'Phuong phap nghien cuu khoa hoc', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420002', 'Khoa hoc ve web', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420003', 'Logic mo va ung dung', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420004', 'Sinh trac hoc', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420005', 'Trinh bien dich', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420006', 'Nhap mon du lieu lon', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420007', 'Nhap mon khoa hoc du lieu', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420008', 'Phan tich du lieu thong minh', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420009', 'Khai thac du lieu do thi', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420010', 'Nhap mon hoc sau', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '420011', 'Quy hoach tuyen tinh', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '430001', 'Ung dung du lieu lon', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '430002', 'Khoa hoc du lieu ung dung', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '430003', 'Lap trinh song song ung dung', 4, 45, 30, 100, 4 FROM DUAL UNION ALL
	SELECT '430004', 'Tri tue nhan tao ung dung', 4, 45, 30, 100, 4 FROM DUAL;
INSERT INTO HOCPHAN
-- 5. BO MON CNTT
--	BAT BUOC
	SELECT '510001', 'Nhap mon phan tich do phuc tap thuat toan', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510002', 'Bao mat co so du lieu', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510003', 'Ma hoa ung dung', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510004', 'Hoc thong ke', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510005', 'Nhap mon xu ly ngon ngu tu nhien', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510006', 'Thong ke may tinh va ung dung', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510007', 'Xu ly ngon ngu tu nhien ung dung', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510008', 'Xu ly tin hieu so', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '510009', 'Nhap mon ngon ngu hoc thong ke va ung dung', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
--	TU CHON
	SELECT '520001', 'Phan tich mang xa hoi', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '520002', 'Tinh toan tai chinh', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '520003', 'Phan tich du lieu bao toan tinh rieng tu', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '520004', 'Nhap mon tu duy thuat toan', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '520005', 'Thuat toan to hop va ung dụng', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '530001', 'Do an Ma hoa ung dung va an ninh thong tin', 6, 0, 180, 100, 5 FROM DUAL UNION ALL
	SELECT '530002', 'Do an Ngon ngu hoc tinh toan', 6, 0, 180, 100, 5 FROM DUAL UNION ALL
	SELECT '530003', 'An toan va phuc hoi du lieu', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '530004', 'Khai thac du lieu van ban va ung dung', 4, 45, 30, 100, 5 FROM DUAL UNION ALL
	SELECT '530005', 'Seminar Cong nghe tri thuc', 4, 45, 30, 100, 5 FROM DUAL;
INSERT INTO HOCPHAN
-- 6. BO MON TGMT
--	BAT BUOC
	SELECT '610001', 'Do hoa may tinh', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '610002', 'Phuong phap toan trong phan tich du lieu thi giac', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '610003', 'Phan tich thong ke du lieu nhieu bien', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '610004', 'Thi giac may tinh', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '610005', 'Xu ly anh so va video so', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
--	TU CHON
	SELECT '620001', 'Do hoa ung dung', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '620002', 'Ky thuat lap trinh xu ly anh so va video so', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '620003', 'Thi giac robot', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '620004', 'Truy van thong tin thi giac', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '620005', 'Ung dung thi giac may tinh', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '620006', 'Ung dung xu ly anh so va video so', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '630001', 'Chuyen de Do hoa may tinh', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '630002', 'Chuyen de Thi giac may tinh', 4, 45, 30, 100, 6 FROM DUAL UNION ALL
	SELECT '630003', 'Chuyen de Xu ly anh so va video so', 4, 45, 30, 100, 6 FROM DUAL;
INSERT INTO HOCPHAN
-- 7. BO MON MMT VA VIEN THONG
--	BAT BUOC
	SELECT '710001', 'He thong vien thong', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710002', 'Lap trinh mang', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710003', 'Mang may tinh nang cao', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710004', 'Thuc tap mang may tinh', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710005', 'An ninh mang', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710006', 'An ninh may tinh', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '710007', 'Nhap mon ma hoa - mat ma', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
--	TU CHON
	SELECT '720001', 'Thiet ke mang', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '720002', 'Truyen thong khong day', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '720003', 'Truyen thong ky thuat so', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '720004', 'Quan tri dich vu mang', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
--	TOT NGHIEP
	SELECT '730001', 'Chuyen de tot nghiep Mang may tinh', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '730002', 'Chuyen de He thong phan tan', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '730003', 'Nhap mon lap trinh ket noi van vat', 4, 45, 30, 100, 7 FROM DUAL UNION ALL
	SELECT '730004', 'Blockchain va ung dung', 4, 45, 30, 100, 7 FROM DUAL;

/* KHMO
 */
INSERT INTO KHMO
-- 1. VAN PHONG KHOA
--	2023 - HOC KY 1
	SELECT '110005', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '110014', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '110007', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '110009', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '110004', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '110001', '1', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '110012', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '110011', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '120004', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '130001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '110008', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '130003', '2', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '110010', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '120001', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '110006', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '120002', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '110013', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '120003', '3', 2023, 'VP' FROM DUAL;
INSERT INTO KHMO
-- 2. BO MON HTTT
--	2023 - HOC KY 1
	SELECT '230002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '220002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '230003', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '210002', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '220003', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '210001', '1', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '220001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '230001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '210003', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '220004', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '220006', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '220007', '2', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '220005', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '210004', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '210005', '3', 2023, 'VP' FROM DUAL;
INSERT INTO KHMO
-- 3. BO MON CNPM
--	2023 - HOC KY 1
	SELECT '330005', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '320003', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '330004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '320002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '320004', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '330002', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '330001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '320006', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '320007', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '310002', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '320001', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '310005', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '310001', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '310004', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '320005', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '310008', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '310007', '3', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '310009', '3', 2023, 'CQ' FROM DUAL;
INSERT INTO KHMO
-- 4. BO MON KHMT
--	2023 - HOC KY 1
	SELECT '430003', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '430004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '410001', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '430002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '420011', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '430001', '1', 2023, 'CLC' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '420002', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '420007', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '410004', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '420009', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '420010', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '410007', '2', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '410002', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '410003', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '420003', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '420008', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '410005', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '410011', '3', 2023, 'CTTT' FROM DUAL;
INSERT INTO KHMO
-- 5. BO MON CNTT
--	2023 - HOC KY 1
	SELECT '520002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '530005', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '510002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '510005', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '530004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '520001', '1', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '510006', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '520005', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '510009', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '510007', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '530001', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '510004', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '530002', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '520003', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '530003', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '510008', '3', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '520004', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '510001', '3', 2023, 'VP' FROM DUAL;
INSERT INTO KHMO
-- 6. BO MON TGMT
--	2023 - HOC KY 1
	SELECT '610003', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '610002', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '610004', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '620001', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '620006', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '620002', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '630003', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '620003', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '620005', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '630001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '610001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '620004', '2', 2023, 'CLC' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '610005', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '630002', '3', 2023, 'CTTT' FROM DUAL;
INSERT INTO KHMO
-- 7. BO MON MMT VA VIEN THONG
--	2023 - HOC KY 1
	SELECT '730002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '710007', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '710004', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '710002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '720002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '730003', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT '710005', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '720003', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT '730001', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '720001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT '730004', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT '720004', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT '710006', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '710001', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT '710003', '3', 2023, 'CTTT' FROM DUAL;

/* PHANCONG
 */
INSERT INTO PHANCONG
--1. VAN PHONG KHOA
--	2023 - HOC KY 1
	SELECT 'V40024', '110005', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V50035', '110014', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40026', '110007', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V20064', '110009', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V70055', '110004', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V20065', '110001', '1', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V20062', '110012', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V70059', '110011', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V40028', '120004', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V50078', '130001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V60044', '110008', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V60042', '130003', '2', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V50035', '110010', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V70060', '120001', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V30070', '110006', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V60050', '120002', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V50031', '110013', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V50037', '120003', '3', 2023, 'VP' FROM DUAL;
INSERT INTO PHANCONG
--2. BO MON HTTT
--	2023 - HOC KY 1
	SELECT 'V20065', '230002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V20062', '220002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V20064', '230003', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V20003', '210002', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V20002', '220003', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V20062', '210001', '1', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V20008', '220001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V20007', '230001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V20001', '210003', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V20063', '220004', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V20065', '220006', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V20062', '220007', '2', 2023, 'CTTT' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V20009', '220005', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V20061', '210004', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V20004', '210005', '3', 2023, 'VP' FROM DUAL;
INSERT INTO PHANCONG
--3. BO MON CNPM
--	2023 - HOC KY 1
	SELECT 'V30019', '330005', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V30066', '320003', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V30014', '330004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V30015', '320002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V30016', '320004', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V30018', '330002', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V30066', '330001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V30068', '320006', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V30068', '320007', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V30020', '310002', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V30018', '320001', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V30067', '310005', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V30019', '310001', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V30067', '310004', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V30015', '320005', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V30020', '310008', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V30011', '310007', '3', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V30067', '310009', '3', 2023, 'CQ' FROM DUAL;
INSERT INTO PHANCONG
--4. BO MON KHMT
--	2023 - HOC KY 1
	SELECT 'V40030', '430003', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V40026', '430004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V40028', '410001', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V40021', '430002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V40075', '420011', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V40022', '430001', '1', 2023, 'CLC' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V40023', '420002', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40026', '420007', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V40027', '410004', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40074', '420009', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40075', '420010', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V40021', '410007', '2', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V40029', '410002', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V40072', '410003', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V40023', '420003', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40025', '420008', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V40024', '410005', '3', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V40021', '410011', '3', 2023, 'CTTT' FROM DUAL;
INSERT INTO PHANCONG
--5. BO MON CNTT
--	2023 - HOC KY 1
	SELECT 'V50078', '520002', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V50077', '530005', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V50080', '510002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50076', '510005', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50033', '530004', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V50078', '520001', '1', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V50034', '510006', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V50039', '520005', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V50038', '510009', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50040', '510007', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V50032', '530001', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50039', '510004', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V50080', '530002', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50031', '520003', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V50080', '530003', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50034', '510008', '3', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V50080', '520004', '3', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V50037', '510001', '3', 2023, 'VP' FROM DUAL;
INSERT INTO PHANCONG
--6. BO MON TGMT
--	2023 - HOC KY 1
	SELECT 'V60045', '610003', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V60044', '610002', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V60046', '610004', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V60044', '620001', '1', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V60049', '620006', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V60042', '620002', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V60048', '630003', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V60049', '620003', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V60042', '620005', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V60044', '630001', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V60050', '610001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V60049', '620004', '2', 2023, 'CLC' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V60041', '610005', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V60045', '630002', '3', 2023, 'CTTT' FROM DUAL;
INSERT INTO PHANCONG
--7. BO MON MMT VA VIEN THONG
--	2023 - HOC KY 1
	SELECT 'V70052', '730002', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V70055', '710007', '1', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V70053', '710004', '1', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V70055', '710002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70052', '720002', '1', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70051', '730003', '1', 2023, 'CQ' FROM DUAL UNION ALL
--	2023 - HOC KY 2
	SELECT 'V70057', '710005', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70055', '720003', '2', 2023, 'CQ' FROM DUAL UNION ALL
	SELECT 'V70059', '730001', '2', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70053', '720001', '2', 2023, 'CTTT' FROM DUAL UNION ALL
	SELECT 'V70051', '730004', '2', 2023, 'CLC' FROM DUAL UNION ALL
	SELECT 'V70054', '720004', '2', 2023, 'VP' FROM DUAL UNION ALL
--	2023 - HOC KY 3
	SELECT 'V70054', '710006', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70051', '710001', '3', 2023, 'VP' FROM DUAL UNION ALL
	SELECT 'V70055', '710003', '3', 2023, 'CTTT' FROM DUAL;

/* DANGKY
 */
INSERT INTO DANGKY
--1. VAN PHONG KHOA
--	2023 - HOC KY 1
	SELECT 'S30013', 'V40024', '110005', '1', 2023, 'CTTT', 6.54, 6.66, 5.72, 6.15 FROM DUAL UNION ALL
	SELECT 'S30015', 'V40024', '110005', '1', 2023, 'CTTT', 9.71, 5.56, 7.28, 7.67 FROM DUAL UNION ALL
	SELECT 'S30095', 'V40024', '110005', '1', 2023, 'CTTT', 5.87, 5.77, 7.34, 6.58 FROM DUAL UNION ALL
	SELECT 'S30034', 'V40024', '110005', '1', 2023, 'CTTT', 5.09, 7.03, 9.55, 7.71 FROM DUAL UNION ALL
	SELECT 'S30113', 'V40024', '110005', '1', 2023, 'CTTT', 7.68, 9.06, 4.02, 6.13 FROM DUAL UNION ALL
	SELECT 'S30052', 'V40024', '110005', '1', 2023, 'CTTT', 9.54, 5.2, 9.88, 8.84 FROM DUAL UNION ALL
	SELECT 'S30074', 'V40024', '110005', '1', 2023, 'CTTT', 8.05, 5.51, 5.82, 6.43 FROM DUAL UNION ALL
	SELECT 'S30012', 'V40024', '110005', '1', 2023, 'CTTT', 8.6, 8.01, 4.8, 6.58 FROM DUAL UNION ALL
	SELECT 'S30055', 'V40024', '110005', '1', 2023, 'CTTT', 6.15, 7.57, 6.05, 6.38 FROM DUAL UNION ALL
	SELECT 'S30071', 'V40024', '110005', '1', 2023, 'CTTT', 8.21, 5.64, 8.07, 7.63 FROM DUAL UNION ALL
	SELECT 'S30093', 'V40024', '110005', '1', 2023, 'CTTT', 4.73, 7.72, 5.29, 5.61 FROM DUAL UNION ALL
	SELECT 'S30114', 'V40024', '110005', '1', 2023, 'CTTT', 8.24, 4.28, 6.24, 6.45 FROM DUAL UNION ALL
	SELECT 'S30032', 'V40024', '110005', '1', 2023, 'CTTT', 7.06, 6.78, 6.73, 6.84 FROM DUAL UNION ALL
	SELECT 'S30033', 'V40024', '110005', '1', 2023, 'CTTT', 8.73, 7.39, 6.1, 7.15 FROM DUAL UNION ALL
	SELECT 'S30073', 'V40024', '110005', '1', 2023, 'CTTT', 7.92, 6.95, 5.51, 6.52 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50035', '110014', '1', 2023, 'VP', 5.37, 9.29, 6.57, 6.75 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50035', '110014', '1', 2023, 'VP', 4.18, 5.27, 5.73, 5.17 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50035', '110014', '1', 2023, 'VP', 5.76, 7.61, 9.78, 8.14 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50035', '110014', '1', 2023, 'VP', 5.46, 7.38, 9.02, 7.62 FROM DUAL UNION ALL
	SELECT 'S40099', 'V50035', '110014', '1', 2023, 'VP', 9.39, 5.73, 5.7, 6.81 FROM DUAL UNION ALL
	SELECT 'S40059', 'V50035', '110014', '1', 2023, 'VP', 7.7, 4.98, 6.53, 6.57 FROM DUAL UNION ALL
	SELECT 'S40080', 'V40026', '110007', '1', 2023, 'VP', 9.88, 8.25, 9.5, 9.36 FROM DUAL UNION ALL
	SELECT 'S40097', 'V40026', '110007', '1', 2023, 'VP', 4.99, 5.18, 6.75, 5.91 FROM DUAL UNION ALL
	SELECT 'S40077', 'V40026', '110007', '1', 2023, 'VP', 5.55, 8.29, 6.0, 6.32 FROM DUAL UNION ALL
	SELECT 'S40117', 'V40026', '110007', '1', 2023, 'VP', 4.46, 8.17, 7.5, 6.72 FROM DUAL UNION ALL
	SELECT 'S40118', 'V40026', '110007', '1', 2023, 'VP', 9.95, 5.57, 6.03, 7.11 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40026', '110007', '1', 2023, 'VP', 6.7, 7.18, 4.23, 5.56 FROM DUAL UNION ALL
	SELECT 'S40016', 'V40026', '110007', '1', 2023, 'VP', 7.41, 6.1, 8.29, 7.59 FROM DUAL UNION ALL
	SELECT 'S40100', 'V40026', '110007', '1', 2023, 'VP', 5.1, 9.93, 6.85, 6.94 FROM DUAL UNION ALL
	SELECT 'S40079', 'V40026', '110007', '1', 2023, 'VP', 9.97, 9.21, 7.12, 8.39 FROM DUAL UNION ALL
	SELECT 'S40037', 'V40026', '110007', '1', 2023, 'VP', 9.92, 4.08, 8.88, 8.23 FROM DUAL UNION ALL
	SELECT 'S40078', 'V40026', '110007', '1', 2023, 'VP', 6.8, 6.22, 9.44, 8.0 FROM DUAL UNION ALL
	SELECT 'S40036', 'V40026', '110007', '1', 2023, 'VP', 4.94, 9.1, 4.12, 5.36 FROM DUAL UNION ALL
	SELECT 'S40038', 'V40026', '110007', '1', 2023, 'VP', 5.39, 5.3, 8.8, 7.08 FROM DUAL UNION ALL
	SELECT 'S40098', 'V40026', '110007', '1', 2023, 'VP', 9.39, 8.33, 9.64, 9.3 FROM DUAL UNION ALL
	SELECT 'S40096', 'V40026', '110007', '1', 2023, 'VP', 6.24, 5.87, 6.0, 6.05 FROM DUAL UNION ALL
	SELECT 'S40060', 'V40026', '110007', '1', 2023, 'VP', 6.7, 4.72, 5.24, 5.57 FROM DUAL UNION ALL
	SELECT 'S40057', 'V40026', '110007', '1', 2023, 'VP', 7.19, 9.15, 8.37, 8.17 FROM DUAL UNION ALL
	SELECT 'S40059', 'V40026', '110007', '1', 2023, 'VP', 7.01, 6.38, 8.24, 7.5 FROM DUAL UNION ALL
	SELECT 'S40076', 'V40026', '110007', '1', 2023, 'VP', 6.66, 6.97, 7.51, 7.15 FROM DUAL UNION ALL
	SELECT 'S40058', 'V40026', '110007', '1', 2023, 'VP', 9.24, 5.92, 8.05, 7.98 FROM DUAL UNION ALL
	SELECT 'S40099', 'V40026', '110007', '1', 2023, 'VP', 9.16, 4.0, 7.62, 7.36 FROM DUAL UNION ALL
	SELECT 'S40040', 'V40026', '110007', '1', 2023, 'VP', 4.93, 5.85, 6.6, 5.95 FROM DUAL UNION ALL
	SELECT 'S40120', 'V40026', '110007', '1', 2023, 'VP', 6.1, 8.79, 6.92, 7.05 FROM DUAL UNION ALL
	SELECT 'S40056', 'V40026', '110007', '1', 2023, 'VP', 7.28, 4.4, 4.87, 5.5 FROM DUAL UNION ALL
	SELECT 'S40119', 'V40026', '110007', '1', 2023, 'VP', 7.9, 9.66, 6.52, 7.56 FROM DUAL UNION ALL
	SELECT 'S40019', 'V40026', '110007', '1', 2023, 'VP', 4.98, 6.26, 7.71, 6.6 FROM DUAL UNION ALL
	SELECT 'S40116', 'V40026', '110007', '1', 2023, 'VP', 4.68, 8.01, 5.21, 5.61 FROM DUAL UNION ALL
	SELECT 'S40018', 'V40026', '110007', '1', 2023, 'VP', 8.35, 8.56, 4.91, 6.67 FROM DUAL UNION ALL
	SELECT 'S10002', 'V20064', '110009', '1', 2023, 'CQ', 7.91, 6.38, 7.27, 7.28 FROM DUAL UNION ALL
	SELECT 'S10065', 'V20064', '110009', '1', 2023, 'CQ', 6.31, 4.27, 8.6, 7.05 FROM DUAL UNION ALL
	SELECT 'S10081', 'V20064', '110009', '1', 2023, 'CQ', 8.13, 8.64, 4.61, 6.47 FROM DUAL UNION ALL
	SELECT 'S10085', 'V20064', '110009', '1', 2023, 'CQ', 4.73, 5.41, 7.81, 6.41 FROM DUAL UNION ALL
	SELECT 'S10083', 'V20064', '110009', '1', 2023, 'CQ', 6.36, 9.77, 5.07, 6.4 FROM DUAL UNION ALL
	SELECT 'S10023', 'V20064', '110009', '1', 2023, 'CQ', 4.02, 6.66, 7.39, 6.23 FROM DUAL UNION ALL
	SELECT 'S10103', 'V20064', '110009', '1', 2023, 'CQ', 5.23, 6.74, 7.65, 6.74 FROM DUAL UNION ALL
	SELECT 'S10004', 'V20064', '110009', '1', 2023, 'CQ', 4.68, 8.7, 7.75, 7.02 FROM DUAL UNION ALL
	SELECT 'S10003', 'V20064', '110009', '1', 2023, 'CQ', 7.55, 7.49, 6.33, 6.93 FROM DUAL UNION ALL
	SELECT 'S10005', 'V20064', '110009', '1', 2023, 'CQ', 6.49, 8.62, 8.53, 7.94 FROM DUAL UNION ALL
	SELECT 'S10102', 'V20064', '110009', '1', 2023, 'CQ', 6.55, 7.1, 8.49, 7.63 FROM DUAL UNION ALL
	SELECT 'S10084', 'V20064', '110009', '1', 2023, 'CQ', 8.46, 4.49, 7.75, 7.31 FROM DUAL UNION ALL
	SELECT 'S10062', 'V20064', '110009', '1', 2023, 'CQ', 9.61, 9.41, 7.36, 8.45 FROM DUAL UNION ALL
	SELECT 'S10064', 'V20064', '110009', '1', 2023, 'CQ', 6.2, 8.7, 4.9, 6.05 FROM DUAL UNION ALL
	SELECT 'S10101', 'V20064', '110009', '1', 2023, 'CQ', 9.14, 4.97, 9.66, 8.57 FROM DUAL UNION ALL
	SELECT 'S10061', 'V20064', '110009', '1', 2023, 'CQ', 5.07, 9.92, 5.54, 6.28 FROM DUAL UNION ALL
	SELECT 'S10025', 'V20064', '110009', '1', 2023, 'CQ', 8.93, 5.55, 4.78, 6.18 FROM DUAL UNION ALL
	SELECT 'S10041', 'V20064', '110009', '1', 2023, 'CQ', 7.9, 9.52, 5.77, 7.16 FROM DUAL UNION ALL
	SELECT 'S10104', 'V20064', '110009', '1', 2023, 'CQ', 4.96, 5.22, 4.56, 4.81 FROM DUAL UNION ALL
	SELECT 'S10024', 'V20064', '110009', '1', 2023, 'CQ', 6.54, 8.65, 8.62, 8.0 FROM DUAL UNION ALL
	SELECT 'S10044', 'V20064', '110009', '1', 2023, 'CQ', 4.81, 8.53, 4.83, 5.56 FROM DUAL UNION ALL
	SELECT 'S10105', 'V20064', '110009', '1', 2023, 'CQ', 9.66, 6.99, 6.16, 7.38 FROM DUAL UNION ALL
	SELECT 'S10042', 'V20064', '110009', '1', 2023, 'CQ', 5.84, 9.45, 8.6, 7.94 FROM DUAL UNION ALL
	SELECT 'S10043', 'V20064', '110009', '1', 2023, 'CQ', 9.43, 9.91, 6.77, 8.2 FROM DUAL UNION ALL
	SELECT 'S10045', 'V20064', '110009', '1', 2023, 'CQ', 9.68, 5.98, 8.2, 8.2 FROM DUAL UNION ALL
	SELECT 'S40038', 'V70055', '110004', '1', 2023, 'VP', 5.32, 6.01, 5.92, 5.76 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70055', '110004', '1', 2023, 'VP', 8.52, 6.09, 9.91, 8.73 FROM DUAL UNION ALL
	SELECT 'S40017', 'V70055', '110004', '1', 2023, 'VP', 5.95, 5.98, 4.06, 5.01 FROM DUAL UNION ALL
	SELECT 'S40098', 'V70055', '110004', '1', 2023, 'VP', 4.91, 8.18, 4.97, 5.59 FROM DUAL UNION ALL
	SELECT 'S40100', 'V70055', '110004', '1', 2023, 'VP', 6.35, 8.91, 6.0, 6.69 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70055', '110004', '1', 2023, 'VP', 9.36, 6.68, 6.52, 7.4 FROM DUAL UNION ALL
	SELECT 'S40097', 'V70055', '110004', '1', 2023, 'VP', 4.99, 9.39, 6.16, 6.46 FROM DUAL UNION ALL
	SELECT 'S40096', 'V70055', '110004', '1', 2023, 'VP', 4.85, 4.56, 5.93, 5.33 FROM DUAL UNION ALL
	SELECT 'S40118', 'V70055', '110004', '1', 2023, 'VP', 8.47, 8.26, 4.25, 6.32 FROM DUAL UNION ALL
	SELECT 'S40116', 'V70055', '110004', '1', 2023, 'VP', 5.56, 8.4, 4.91, 5.8 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70055', '110004', '1', 2023, 'VP', 4.26, 4.91, 7.49, 6.0 FROM DUAL UNION ALL
	SELECT 'S40117', 'V70055', '110004', '1', 2023, 'VP', 4.39, 4.35, 7.94, 6.16 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70055', '110004', '1', 2023, 'VP', 9.06, 9.0, 7.0, 8.02 FROM DUAL UNION ALL
	SELECT 'S40039', 'V70055', '110004', '1', 2023, 'VP', 6.87, 7.17, 6.53, 6.76 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70055', '110004', '1', 2023, 'VP', 5.37, 7.48, 6.84, 6.53 FROM DUAL UNION ALL
	SELECT 'S40119', 'V70055', '110004', '1', 2023, 'VP', 9.88, 4.66, 4.9, 6.35 FROM DUAL UNION ALL
	SELECT 'S40020', 'V70055', '110004', '1', 2023, 'VP', 5.63, 7.05, 9.17, 7.68 FROM DUAL UNION ALL
	SELECT 'S40078', 'V70055', '110004', '1', 2023, 'VP', 8.89, 4.75, 9.54, 8.39 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20065', '110001', '1', 2023, 'CTTT', 6.55, 9.93, 5.48, 6.69 FROM DUAL UNION ALL
	SELECT 'S30055', 'V20065', '110001', '1', 2023, 'CTTT', 9.86, 7.56, 8.85, 8.89 FROM DUAL UNION ALL
	SELECT 'S30033', 'V20065', '110001', '1', 2023, 'CTTT', 5.23, 7.27, 4.39, 5.22 FROM DUAL UNION ALL
	SELECT 'S30112', 'V20065', '110001', '1', 2023, 'CTTT', 7.67, 6.25, 6.76, 6.93 FROM DUAL UNION ALL
	SELECT 'S30113', 'V20065', '110001', '1', 2023, 'CTTT', 6.21, 9.53, 5.26, 6.4 FROM DUAL UNION ALL
	SELECT 'S30052', 'V20065', '110001', '1', 2023, 'CTTT', 8.8, 7.43, 8.34, 8.3 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S10081', 'V20062', '110012', '2', 2023, 'CQ', 6.95, 8.84, 4.3, 6.0 FROM DUAL UNION ALL
	SELECT 'S10083', 'V20062', '110012', '2', 2023, 'CQ', 4.19, 6.36, 4.92, 4.99 FROM DUAL UNION ALL
	SELECT 'S10102', 'V20062', '110012', '2', 2023, 'CQ', 6.44, 8.92, 9.43, 8.43 FROM DUAL UNION ALL
	SELECT 'S10104', 'V20062', '110012', '2', 2023, 'CQ', 8.53, 8.08, 6.28, 7.31 FROM DUAL UNION ALL
	SELECT 'S10002', 'V20062', '110012', '2', 2023, 'CQ', 8.55, 9.75, 8.39, 8.71 FROM DUAL UNION ALL
	SELECT 'S10063', 'V20062', '110012', '2', 2023, 'CQ', 4.61, 4.54, 9.74, 7.16 FROM DUAL UNION ALL
	SELECT 'S10103', 'V20062', '110012', '2', 2023, 'CQ', 7.06, 9.09, 8.19, 8.03 FROM DUAL UNION ALL
	SELECT 'S10004', 'V20062', '110012', '2', 2023, 'CQ', 4.27, 4.0, 8.08, 6.12 FROM DUAL UNION ALL
	SELECT 'S10085', 'V20062', '110012', '2', 2023, 'CQ', 4.49, 5.87, 9.56, 7.3 FROM DUAL UNION ALL
	SELECT 'S10005', 'V20062', '110012', '2', 2023, 'CQ', 5.03, 4.2, 5.41, 5.05 FROM DUAL UNION ALL
	SELECT 'S10023', 'V20062', '110012', '2', 2023, 'CQ', 4.65, 9.73, 4.29, 5.49 FROM DUAL UNION ALL
	SELECT 'S10105', 'V20062', '110012', '2', 2023, 'CQ', 6.19, 8.92, 8.64, 7.96 FROM DUAL UNION ALL
	SELECT 'S10064', 'V20062', '110012', '2', 2023, 'CQ', 9.48, 6.54, 6.38, 7.34 FROM DUAL UNION ALL
	SELECT 'S10025', 'V20062', '110012', '2', 2023, 'CQ', 5.7, 5.88, 6.7, 6.24 FROM DUAL UNION ALL
	SELECT 'S10043', 'V20062', '110012', '2', 2023, 'CQ', 7.64, 9.8, 9.45, 8.98 FROM DUAL UNION ALL
	SELECT 'S10101', 'V20062', '110012', '2', 2023, 'CQ', 9.93, 4.74, 5.52, 6.69 FROM DUAL UNION ALL
	SELECT 'S10082', 'V20062', '110012', '2', 2023, 'CQ', 7.02, 4.36, 7.78, 6.87 FROM DUAL UNION ALL
	SELECT 'S10022', 'V20062', '110012', '2', 2023, 'CQ', 4.22, 6.47, 6.91, 6.01 FROM DUAL UNION ALL
	SELECT 'S20110', 'V70059', '110011', '2', 2023, 'CLC', 7.66, 4.49, 5.85, 6.12 FROM DUAL UNION ALL
	SELECT 'S20046', 'V70059', '110011', '2', 2023, 'CLC', 4.58, 9.24, 8.95, 7.7 FROM DUAL UNION ALL
	SELECT 'S20088', 'V70059', '110011', '2', 2023, 'CLC', 5.79, 6.03, 4.38, 5.13 FROM DUAL UNION ALL
	SELECT 'S20086', 'V70059', '110011', '2', 2023, 'CLC', 5.52, 6.82, 6.29, 6.17 FROM DUAL UNION ALL
	SELECT 'S20006', 'V70059', '110011', '2', 2023, 'CLC', 8.88, 8.94, 5.96, 7.43 FROM DUAL UNION ALL
	SELECT 'S20027', 'V70059', '110011', '2', 2023, 'CLC', 5.65, 5.79, 9.18, 7.44 FROM DUAL UNION ALL
	SELECT 'S20029', 'V70059', '110011', '2', 2023, 'CLC', 8.83, 6.77, 5.78, 6.89 FROM DUAL UNION ALL
	SELECT 'S20106', 'V70059', '110011', '2', 2023, 'CLC', 8.2, 8.21, 8.67, 8.44 FROM DUAL UNION ALL
	SELECT 'S20107', 'V70059', '110011', '2', 2023, 'CLC', 6.23, 4.81, 4.54, 5.1 FROM DUAL UNION ALL
	SELECT 'S40019', 'V40028', '120004', '2', 2023, 'VP', 4.83, 9.01, 7.2, 6.85 FROM DUAL UNION ALL
	SELECT 'S40077', 'V40028', '120004', '2', 2023, 'VP', 7.92, 4.55, 5.95, 6.26 FROM DUAL UNION ALL
	SELECT 'S40078', 'V40028', '120004', '2', 2023, 'VP', 4.92, 8.03, 4.25, 5.21 FROM DUAL UNION ALL
	SELECT 'S40056', 'V40028', '120004', '2', 2023, 'VP', 5.06, 4.26, 5.89, 5.31 FROM DUAL UNION ALL
	SELECT 'S40096', 'V40028', '120004', '2', 2023, 'VP', 9.16, 7.77, 8.65, 8.63 FROM DUAL UNION ALL
	SELECT 'S40037', 'V40028', '120004', '2', 2023, 'VP', 9.77, 4.95, 5.39, 6.62 FROM DUAL UNION ALL
	SELECT 'S40117', 'V40028', '120004', '2', 2023, 'VP', 4.9, 9.63, 7.96, 7.38 FROM DUAL UNION ALL
	SELECT 'S40118', 'V40028', '120004', '2', 2023, 'VP', 8.94, 8.73, 9.66, 9.26 FROM DUAL UNION ALL
	SELECT 'S40120', 'V40028', '120004', '2', 2023, 'VP', 6.0, 6.69, 7.59, 6.93 FROM DUAL UNION ALL
	SELECT 'S40057', 'V40028', '120004', '2', 2023, 'VP', 5.97, 4.3, 4.55, 4.93 FROM DUAL UNION ALL
	SELECT 'S40059', 'V40028', '120004', '2', 2023, 'VP', 6.93, 8.46, 6.37, 6.96 FROM DUAL UNION ALL
	SELECT 'S40038', 'V40028', '120004', '2', 2023, 'VP', 8.81, 9.07, 6.9, 7.91 FROM DUAL UNION ALL
	SELECT 'S40058', 'V40028', '120004', '2', 2023, 'VP', 4.48, 8.36, 7.08, 6.56 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40028', '120004', '2', 2023, 'VP', 4.47, 7.28, 4.43, 5.01 FROM DUAL UNION ALL
	SELECT 'S40039', 'V40028', '120004', '2', 2023, 'VP', 4.14, 9.83, 6.65, 6.53 FROM DUAL UNION ALL
	SELECT 'S40080', 'V40028', '120004', '2', 2023, 'VP', 6.08, 8.04, 8.28, 7.57 FROM DUAL UNION ALL
	SELECT 'S40076', 'V40028', '120004', '2', 2023, 'VP', 8.0, 5.58, 7.72, 7.38 FROM DUAL UNION ALL
	SELECT 'S40040', 'V40028', '120004', '2', 2023, 'VP', 5.44, 6.08, 6.3, 6.0 FROM DUAL UNION ALL
	SELECT 'S40099', 'V40028', '120004', '2', 2023, 'VP', 7.58, 5.81, 4.24, 5.56 FROM DUAL UNION ALL
	SELECT 'S40018', 'V40028', '120004', '2', 2023, 'VP', 5.49, 6.2, 5.14, 5.46 FROM DUAL UNION ALL
	SELECT 'S40017', 'V40028', '120004', '2', 2023, 'VP', 4.98, 5.43, 7.76, 6.46 FROM DUAL UNION ALL
	SELECT 'S10024', 'V50078', '130001', '2', 2023, 'CQ', 7.63, 5.96, 5.67, 6.32 FROM DUAL UNION ALL
	SELECT 'S10103', 'V50078', '130001', '2', 2023, 'CQ', 7.77, 9.6, 6.52, 7.51 FROM DUAL UNION ALL
	SELECT 'S10083', 'V50078', '130001', '2', 2023, 'CQ', 9.79, 8.68, 7.51, 8.43 FROM DUAL UNION ALL
	SELECT 'S10003', 'V50078', '130001', '2', 2023, 'CQ', 4.09, 7.05, 5.35, 5.31 FROM DUAL UNION ALL
	SELECT 'S10005', 'V50078', '130001', '2', 2023, 'CQ', 5.36, 6.79, 4.77, 5.35 FROM DUAL UNION ALL
	SELECT 'S10062', 'V50078', '130001', '2', 2023, 'CQ', 5.05, 9.12, 7.64, 7.16 FROM DUAL UNION ALL
	SELECT 'S10105', 'V50078', '130001', '2', 2023, 'CQ', 7.63, 5.78, 7.28, 7.08 FROM DUAL UNION ALL
	SELECT 'S10065', 'V50078', '130001', '2', 2023, 'CQ', 4.55, 8.63, 4.03, 5.11 FROM DUAL UNION ALL
	SELECT 'S10043', 'V50078', '130001', '2', 2023, 'CQ', 8.63, 4.95, 5.7, 6.43 FROM DUAL UNION ALL
	SELECT 'S10022', 'V50078', '130001', '2', 2023, 'CQ', 7.62, 5.46, 8.94, 7.85 FROM DUAL UNION ALL
	SELECT 'S10042', 'V50078', '130001', '2', 2023, 'CQ', 4.04, 9.18, 6.49, 6.29 FROM DUAL UNION ALL
	SELECT 'S10025', 'V50078', '130001', '2', 2023, 'CQ', 6.79, 4.16, 9.72, 7.73 FROM DUAL UNION ALL
	SELECT 'S10021', 'V50078', '130001', '2', 2023, 'CQ', 6.91, 6.72, 5.64, 6.24 FROM DUAL UNION ALL
	SELECT 'S10023', 'V50078', '130001', '2', 2023, 'CQ', 5.67, 5.95, 4.36, 5.07 FROM DUAL UNION ALL
	SELECT 'S10085', 'V50078', '130001', '2', 2023, 'CQ', 5.49, 9.2, 5.32, 6.15 FROM DUAL UNION ALL
	SELECT 'S10082', 'V50078', '130001', '2', 2023, 'CQ', 7.1, 9.5, 8.41, 8.23 FROM DUAL UNION ALL
	SELECT 'S10061', 'V50078', '130001', '2', 2023, 'CQ', 7.19, 8.48, 4.81, 6.26 FROM DUAL UNION ALL
	SELECT 'S10063', 'V50078', '130001', '2', 2023, 'CQ', 8.37, 6.64, 5.8, 6.74 FROM DUAL UNION ALL
	SELECT 'S10002', 'V50078', '130001', '2', 2023, 'CQ', 7.54, 6.56, 6.31, 6.73 FROM DUAL UNION ALL
	SELECT 'S10084', 'V50078', '130001', '2', 2023, 'CQ', 6.6, 6.23, 9.95, 8.2 FROM DUAL UNION ALL
	SELECT 'S10101', 'V50078', '130001', '2', 2023, 'CQ', 9.43, 8.76, 4.81, 6.99 FROM DUAL UNION ALL
	SELECT 'S10045', 'V50078', '130001', '2', 2023, 'CQ', 5.64, 4.49, 8.63, 6.91 FROM DUAL UNION ALL
	SELECT 'S10102', 'V50078', '130001', '2', 2023, 'CQ', 7.5, 7.72, 7.78, 7.68 FROM DUAL UNION ALL
	SELECT 'S40080', 'V60044', '110008', '2', 2023, 'VP', 5.18, 4.8, 6.64, 5.83 FROM DUAL UNION ALL
	SELECT 'S40078', 'V60044', '110008', '2', 2023, 'VP', 5.24, 6.95, 8.96, 7.44 FROM DUAL UNION ALL
	SELECT 'S40116', 'V60044', '110008', '2', 2023, 'VP', 8.83, 7.13, 9.9, 9.03 FROM DUAL UNION ALL
	SELECT 'S40100', 'V60044', '110008', '2', 2023, 'VP', 4.91, 7.69, 7.21, 6.62 FROM DUAL UNION ALL
	SELECT 'S40118', 'V60044', '110008', '2', 2023, 'VP', 9.57, 7.2, 8.11, 8.37 FROM DUAL UNION ALL
	SELECT 'S40039', 'V60044', '110008', '2', 2023, 'VP', 7.78, 9.28, 7.25, 7.81 FROM DUAL UNION ALL
	SELECT 'S40016', 'V60044', '110008', '2', 2023, 'VP', 6.92, 6.98, 7.64, 7.29 FROM DUAL UNION ALL
	SELECT 'S40018', 'V60044', '110008', '2', 2023, 'VP', 8.34, 8.15, 7.29, 7.78 FROM DUAL UNION ALL
	SELECT 'S40077', 'V60044', '110008', '2', 2023, 'VP', 8.86, 8.06, 4.71, 6.62 FROM DUAL UNION ALL
	SELECT 'S40098', 'V60044', '110008', '2', 2023, 'VP', 9.2, 6.26, 9.12, 8.57 FROM DUAL UNION ALL
	SELECT 'S40076', 'V60044', '110008', '2', 2023, 'VP', 7.7, 5.52, 8.95, 7.89 FROM DUAL UNION ALL
	SELECT 'S40056', 'V60044', '110008', '2', 2023, 'VP', 5.35, 8.19, 8.07, 7.28 FROM DUAL UNION ALL
	SELECT 'S40040', 'V60044', '110008', '2', 2023, 'VP', 9.9, 8.41, 9.43, 9.37 FROM DUAL UNION ALL
	SELECT 'S40019', 'V60044', '110008', '2', 2023, 'VP', 9.55, 7.9, 6.79, 7.84 FROM DUAL UNION ALL
	SELECT 'S40099', 'V60044', '110008', '2', 2023, 'VP', 9.2, 9.85, 5.06, 7.26 FROM DUAL UNION ALL
	SELECT 'S40079', 'V60044', '110008', '2', 2023, 'VP', 6.2, 5.82, 6.9, 6.47 FROM DUAL UNION ALL
	SELECT 'S40117', 'V60044', '110008', '2', 2023, 'VP', 6.05, 5.6, 8.3, 7.08 FROM DUAL UNION ALL
	SELECT 'S40119', 'V60044', '110008', '2', 2023, 'VP', 5.2, 7.39, 8.59, 7.33 FROM DUAL UNION ALL
	SELECT 'S40059', 'V60044', '110008', '2', 2023, 'VP', 6.27, 5.93, 4.72, 5.43 FROM DUAL UNION ALL
	SELECT 'S40097', 'V60044', '110008', '2', 2023, 'VP', 6.84, 4.94, 6.03, 6.05 FROM DUAL UNION ALL
	SELECT 'S40017', 'V60044', '110008', '2', 2023, 'VP', 8.08, 8.21, 9.56, 8.85 FROM DUAL UNION ALL
	SELECT 'S40060', 'V60044', '110008', '2', 2023, 'VP', 7.21, 8.93, 7.36, 7.63 FROM DUAL UNION ALL
	SELECT 'S40020', 'V60044', '110008', '2', 2023, 'VP', 9.16, 5.03, 8.08, 7.79 FROM DUAL UNION ALL
	SELECT 'S40058', 'V60044', '110008', '2', 2023, 'VP', 6.0, 8.34, 8.62, 7.78 FROM DUAL UNION ALL
	SELECT 'S40037', 'V60044', '110008', '2', 2023, 'VP', 8.8, 9.04, 5.8, 7.35 FROM DUAL UNION ALL
	SELECT 'S40096', 'V60044', '110008', '2', 2023, 'VP', 8.66, 8.77, 4.73, 6.72 FROM DUAL UNION ALL
	SELECT 'S40120', 'V60044', '110008', '2', 2023, 'VP', 9.92, 9.82, 9.6, 9.74 FROM DUAL UNION ALL
	SELECT 'S40057', 'V60044', '110008', '2', 2023, 'VP', 8.3, 6.99, 6.42, 7.1 FROM DUAL UNION ALL
	SELECT 'S30032', 'V60042', '130003', '2', 2023, 'CTTT', 6.13, 4.76, 9.3, 7.44 FROM DUAL UNION ALL
	SELECT 'S30055', 'V60042', '130003', '2', 2023, 'CTTT', 5.85, 6.18, 5.69, 5.84 FROM DUAL UNION ALL
	SELECT 'S30071', 'V60042', '130003', '2', 2023, 'CTTT', 7.29, 8.15, 6.8, 7.22 FROM DUAL UNION ALL
	SELECT 'S30091', 'V60042', '130003', '2', 2023, 'CTTT', 5.42, 5.3, 6.31, 5.84 FROM DUAL UNION ALL
	SELECT 'S30033', 'V60042', '130003', '2', 2023, 'CTTT', 4.64, 9.48, 9.24, 7.91 FROM DUAL UNION ALL
	SELECT 'S30093', 'V60042', '130003', '2', 2023, 'CTTT', 4.29, 4.43, 9.79, 7.07 FROM DUAL UNION ALL
	SELECT 'S30092', 'V60042', '130003', '2', 2023, 'CTTT', 7.6, 7.68, 7.32, 7.48 FROM DUAL UNION ALL
	SELECT 'S30011', 'V60042', '130003', '2', 2023, 'CTTT', 7.18, 8.41, 4.59, 6.13 FROM DUAL UNION ALL
	SELECT 'S30013', 'V60042', '130003', '2', 2023, 'CTTT', 6.04, 5.66, 4.53, 5.21 FROM DUAL UNION ALL
	SELECT 'S30094', 'V60042', '130003', '2', 2023, 'CTTT', 7.08, 5.04, 6.52, 6.39 FROM DUAL UNION ALL
	SELECT 'S30075', 'V60042', '130003', '2', 2023, 'CTTT', 4.77, 5.19, 5.56, 5.25 FROM DUAL UNION ALL
	SELECT 'S30051', 'V60042', '130003', '2', 2023, 'CTTT', 9.89, 9.6, 6.73, 8.25 FROM DUAL UNION ALL
	SELECT 'S30072', 'V60042', '130003', '2', 2023, 'CTTT', 5.89, 7.39, 7.84, 7.17 FROM DUAL UNION ALL
	SELECT 'S30112', 'V60042', '130003', '2', 2023, 'CTTT', 4.93, 5.57, 7.07, 6.13 FROM DUAL UNION ALL
	SELECT 'S30114', 'V60042', '130003', '2', 2023, 'CTTT', 5.12, 4.79, 8.8, 6.89 FROM DUAL UNION ALL
	SELECT 'S30012', 'V60042', '130003', '2', 2023, 'CTTT', 7.89, 9.77, 7.24, 7.94 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S30033', 'V50035', '110010', '3', 2023, 'CTTT', 5.53, 8.86, 6.03, 6.45 FROM DUAL UNION ALL
	SELECT 'S30091', 'V50035', '110010', '3', 2023, 'CTTT', 8.39, 7.66, 9.39, 8.74 FROM DUAL UNION ALL
	SELECT 'S30072', 'V50035', '110010', '3', 2023, 'CTTT', 8.49, 4.12, 8.08, 7.41 FROM DUAL UNION ALL
	SELECT 'S30013', 'V50035', '110010', '3', 2023, 'CTTT', 7.71, 10.0, 4.51, 6.57 FROM DUAL UNION ALL
	SELECT 'S30114', 'V50035', '110010', '3', 2023, 'CTTT', 8.24, 6.69, 7.17, 7.39 FROM DUAL UNION ALL
	SELECT 'S30115', 'V50035', '110010', '3', 2023, 'CTTT', 6.22, 9.41, 9.49, 8.49 FROM DUAL UNION ALL
	SELECT 'S30094', 'V50035', '110010', '3', 2023, 'CTTT', 9.78, 7.73, 8.63, 8.8 FROM DUAL UNION ALL
	SELECT 'S30073', 'V50035', '110010', '3', 2023, 'CTTT', 7.65, 5.47, 5.6, 6.19 FROM DUAL UNION ALL
	SELECT 'S30071', 'V50035', '110010', '3', 2023, 'CTTT', 7.02, 8.54, 6.15, 6.89 FROM DUAL UNION ALL
	SELECT 'S30014', 'V50035', '110010', '3', 2023, 'CTTT', 4.94, 8.86, 4.6, 5.55 FROM DUAL UNION ALL
	SELECT 'S30074', 'V70060', '120001', '3', 2023, 'CTTT', 6.12, 9.28, 6.25, 6.82 FROM DUAL UNION ALL
	SELECT 'S30055', 'V70060', '120001', '3', 2023, 'CTTT', 6.67, 4.82, 9.4, 7.67 FROM DUAL UNION ALL
	SELECT 'S30054', 'V70060', '120001', '3', 2023, 'CTTT', 9.27, 7.47, 4.15, 6.35 FROM DUAL UNION ALL
	SELECT 'S30013', 'V70060', '120001', '3', 2023, 'CTTT', 4.95, 9.51, 6.87, 6.82 FROM DUAL UNION ALL
	SELECT 'S30052', 'V70060', '120001', '3', 2023, 'CTTT', 6.53, 9.08, 6.08, 6.82 FROM DUAL UNION ALL
	SELECT 'S30032', 'V70060', '120001', '3', 2023, 'CTTT', 7.94, 7.61, 4.38, 6.09 FROM DUAL UNION ALL
	SELECT 'S30113', 'V70060', '120001', '3', 2023, 'CTTT', 8.37, 4.01, 6.37, 6.5 FROM DUAL UNION ALL
	SELECT 'S30095', 'V70060', '120001', '3', 2023, 'CTTT', 7.88, 6.19, 4.64, 5.92 FROM DUAL UNION ALL
	SELECT 'S30115', 'V70060', '120001', '3', 2023, 'CTTT', 9.27, 6.99, 7.86, 8.11 FROM DUAL UNION ALL
	SELECT 'S30051', 'V70060', '120001', '3', 2023, 'CTTT', 4.36, 7.39, 6.12, 5.85 FROM DUAL UNION ALL
	SELECT 'S30053', 'V70060', '120001', '3', 2023, 'CTTT', 4.97, 8.56, 7.33, 6.87 FROM DUAL UNION ALL
	SELECT 'S30012', 'V70060', '120001', '3', 2023, 'CTTT', 4.44, 7.87, 8.03, 6.92 FROM DUAL UNION ALL
	SELECT 'S20108', 'V30070', '110006', '3', 2023, 'CLC', 5.73, 9.56, 9.01, 8.14 FROM DUAL UNION ALL
	SELECT 'S20106', 'V30070', '110006', '3', 2023, 'CLC', 9.84, 5.55, 5.2, 6.66 FROM DUAL UNION ALL
	SELECT 'S20008', 'V30070', '110006', '3', 2023, 'CLC', 6.2, 5.03, 7.1, 6.42 FROM DUAL UNION ALL
	SELECT 'S20088', 'V30070', '110006', '3', 2023, 'CLC', 7.34, 8.05, 6.6, 7.11 FROM DUAL UNION ALL
	SELECT 'S20048', 'V30070', '110006', '3', 2023, 'CLC', 4.11, 9.12, 9.82, 7.97 FROM DUAL UNION ALL
	SELECT 'S20047', 'V30070', '110006', '3', 2023, 'CLC', 4.37, 8.37, 9.45, 7.71 FROM DUAL UNION ALL
	SELECT 'S20006', 'V30070', '110006', '3', 2023, 'CLC', 5.53, 9.48, 6.75, 6.93 FROM DUAL UNION ALL
	SELECT 'S20050', 'V30070', '110006', '3', 2023, 'CLC', 8.47, 9.55, 8.36, 8.63 FROM DUAL UNION ALL
	SELECT 'S20028', 'V30070', '110006', '3', 2023, 'CLC', 7.71, 4.68, 8.35, 7.42 FROM DUAL UNION ALL
	SELECT 'S20066', 'V30070', '110006', '3', 2023, 'CLC', 7.94, 4.15, 8.5, 7.46 FROM DUAL UNION ALL
	SELECT 'S20089', 'V30070', '110006', '3', 2023, 'CLC', 6.32, 9.75, 8.97, 8.33 FROM DUAL UNION ALL
	SELECT 'S20067', 'V30070', '110006', '3', 2023, 'CLC', 8.28, 5.11, 9.01, 8.01 FROM DUAL UNION ALL
	SELECT 'S20070', 'V30070', '110006', '3', 2023, 'CLC', 9.08, 8.32, 6.78, 7.78 FROM DUAL UNION ALL
	SELECT 'S30115', 'V60050', '120002', '3', 2023, 'CTTT', 7.34, 6.02, 8.95, 7.88 FROM DUAL UNION ALL
	SELECT 'S30031', 'V60050', '120002', '3', 2023, 'CTTT', 7.69, 4.46, 8.43, 7.41 FROM DUAL UNION ALL
	SELECT 'S30034', 'V60050', '120002', '3', 2023, 'CTTT', 4.41, 6.84, 5.3, 5.34 FROM DUAL UNION ALL
	SELECT 'S30091', 'V60050', '120002', '3', 2023, 'CTTT', 4.56, 5.09, 7.57, 6.17 FROM DUAL UNION ALL
	SELECT 'S30072', 'V60050', '120002', '3', 2023, 'CTTT', 5.52, 9.96, 5.09, 6.19 FROM DUAL UNION ALL
	SELECT 'S30012', 'V60050', '120002', '3', 2023, 'CTTT', 4.49, 6.61, 8.43, 6.88 FROM DUAL UNION ALL
	SELECT 'S30052', 'V60050', '120002', '3', 2023, 'CTTT', 8.22, 5.86, 4.01, 5.64 FROM DUAL UNION ALL
	SELECT 'S30013', 'V60050', '120002', '3', 2023, 'CTTT', 7.66, 9.28, 6.13, 7.22 FROM DUAL UNION ALL
	SELECT 'S30112', 'V60050', '120002', '3', 2023, 'CTTT', 4.34, 9.66, 5.47, 5.97 FROM DUAL UNION ALL
	SELECT 'S30114', 'V60050', '120002', '3', 2023, 'CTTT', 4.83, 7.25, 8.86, 7.33 FROM DUAL UNION ALL
	SELECT 'S30074', 'V60050', '120002', '3', 2023, 'CTTT', 6.28, 8.88, 7.99, 7.66 FROM DUAL UNION ALL
	SELECT 'S30015', 'V60050', '120002', '3', 2023, 'CTTT', 4.38, 9.34, 7.33, 6.85 FROM DUAL UNION ALL
	SELECT 'S30033', 'V60050', '120002', '3', 2023, 'CTTT', 9.81, 6.09, 9.77, 9.05 FROM DUAL UNION ALL
	SELECT 'S30111', 'V60050', '120002', '3', 2023, 'CTTT', 4.21, 7.87, 7.61, 6.64 FROM DUAL UNION ALL
	SELECT 'S30032', 'V60050', '120002', '3', 2023, 'CTTT', 4.21, 6.02, 9.96, 7.45 FROM DUAL UNION ALL
	SELECT 'S30051', 'V60050', '120002', '3', 2023, 'CTTT', 6.6, 8.72, 4.73, 6.09 FROM DUAL UNION ALL
	SELECT 'S30055', 'V60050', '120002', '3', 2023, 'CTTT', 8.54, 7.19, 6.77, 7.38 FROM DUAL UNION ALL
	SELECT 'S30095', 'V60050', '120002', '3', 2023, 'CTTT', 5.78, 5.51, 7.73, 6.7 FROM DUAL UNION ALL
	SELECT 'S30035', 'V60050', '120002', '3', 2023, 'CTTT', 9.5, 6.24, 5.99, 7.09 FROM DUAL UNION ALL
	SELECT 'S30071', 'V60050', '120002', '3', 2023, 'CTTT', 7.21, 9.52, 9.58, 8.86 FROM DUAL UNION ALL
	SELECT 'S30075', 'V60050', '120002', '3', 2023, 'CTTT', 6.59, 6.73, 6.44, 6.54 FROM DUAL UNION ALL
	SELECT 'S30092', 'V60050', '120002', '3', 2023, 'CTTT', 8.2, 7.91, 8.41, 8.25 FROM DUAL UNION ALL
	SELECT 'S30073', 'V60050', '120002', '3', 2023, 'CTTT', 7.48, 6.14, 5.57, 6.26 FROM DUAL UNION ALL
	SELECT 'S30014', 'V60050', '120002', '3', 2023, 'CTTT', 6.57, 4.33, 6.46, 6.07 FROM DUAL UNION ALL
	SELECT 'S30094', 'V60050', '120002', '3', 2023, 'CTTT', 6.52, 4.87, 4.28, 5.07 FROM DUAL UNION ALL
	SELECT 'S30011', 'V60050', '120002', '3', 2023, 'CTTT', 5.08, 5.87, 4.83, 5.11 FROM DUAL UNION ALL
	SELECT 'S30113', 'V60050', '120002', '3', 2023, 'CTTT', 7.41, 9.91, 5.82, 7.12 FROM DUAL UNION ALL
	SELECT 'S30093', 'V60050', '120002', '3', 2023, 'CTTT', 8.06, 4.27, 6.77, 6.66 FROM DUAL UNION ALL
	SELECT 'S30054', 'V60050', '120002', '3', 2023, 'CTTT', 9.78, 4.26, 8.88, 8.23 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50031', '110013', '3', 2023, 'VP', 9.01, 7.72, 9.46, 8.98 FROM DUAL UNION ALL
	SELECT 'S40036', 'V50031', '110013', '3', 2023, 'VP', 7.82, 5.59, 5.64, 6.28 FROM DUAL UNION ALL
	SELECT 'S40017', 'V50031', '110013', '3', 2023, 'VP', 8.43, 5.68, 6.31, 6.82 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50031', '110013', '3', 2023, 'VP', 7.46, 8.05, 6.56, 7.13 FROM DUAL UNION ALL
	SELECT 'S40019', 'V50031', '110013', '3', 2023, 'VP', 8.32, 5.74, 4.87, 6.08 FROM DUAL UNION ALL
	SELECT 'S40076', 'V50031', '110013', '3', 2023, 'VP', 7.52, 8.53, 8.86, 8.39 FROM DUAL UNION ALL
	SELECT 'S40016', 'V50031', '110013', '3', 2023, 'VP', 4.96, 4.99, 5.74, 5.36 FROM DUAL UNION ALL
	SELECT 'S40038', 'V50031', '110013', '3', 2023, 'VP', 9.34, 8.52, 4.29, 6.65 FROM DUAL UNION ALL
	SELECT 'S40120', 'V50031', '110013', '3', 2023, 'VP', 5.45, 9.47, 6.93, 6.99 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50031', '110013', '3', 2023, 'VP', 5.32, 8.08, 7.21, 6.82 FROM DUAL UNION ALL
	SELECT 'S40077', 'V50031', '110013', '3', 2023, 'VP', 4.92, 4.68, 7.42, 6.12 FROM DUAL UNION ALL
	SELECT 'S40059', 'V50031', '110013', '3', 2023, 'VP', 9.22, 5.16, 6.54, 7.07 FROM DUAL UNION ALL
	SELECT 'S40057', 'V50031', '110013', '3', 2023, 'VP', 7.13, 4.67, 9.56, 7.85 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50031', '110013', '3', 2023, 'VP', 4.78, 9.89, 9.38, 8.1 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50031', '110013', '3', 2023, 'VP', 7.6, 8.81, 8.46, 8.27 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50031', '110013', '3', 2023, 'VP', 8.14, 4.91, 4.37, 5.61 FROM DUAL UNION ALL
	SELECT 'S40098', 'V50031', '110013', '3', 2023, 'VP', 8.55, 5.45, 7.73, 7.52 FROM DUAL UNION ALL
	SELECT 'S40119', 'V50031', '110013', '3', 2023, 'VP', 8.89, 5.15, 8.73, 8.06 FROM DUAL UNION ALL
	SELECT 'S40020', 'V50031', '110013', '3', 2023, 'VP', 9.76, 4.72, 9.68, 8.71 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50031', '110013', '3', 2023, 'VP', 4.84, 10.0, 4.81, 5.86 FROM DUAL UNION ALL
	SELECT 'S40039', 'V50031', '110013', '3', 2023, 'VP', 4.67, 7.84, 8.19, 7.06 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50031', '110013', '3', 2023, 'VP', 6.56, 5.1, 4.59, 5.28 FROM DUAL UNION ALL
	SELECT 'S40080', 'V50031', '110013', '3', 2023, 'VP', 6.87, 4.6, 6.81, 6.39 FROM DUAL UNION ALL
	SELECT 'S40100', 'V50031', '110013', '3', 2023, 'VP', 4.7, 6.24, 4.51, 4.91 FROM DUAL UNION ALL
	SELECT 'S40037', 'V50031', '110013', '3', 2023, 'VP', 7.34, 5.69, 9.45, 8.06 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50031', '110013', '3', 2023, 'VP', 4.4, 7.08, 7.73, 6.6 FROM DUAL UNION ALL
	SELECT 'S40060', 'V50031', '110013', '3', 2023, 'VP', 6.29, 6.41, 5.57, 5.95 FROM DUAL UNION ALL
	SELECT 'S40099', 'V50031', '110013', '3', 2023, 'VP', 9.07, 10.0, 5.29, 7.37 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50031', '110013', '3', 2023, 'VP', 4.05, 9.98, 9.65, 8.04 FROM DUAL UNION ALL
	SELECT 'S40077', 'V50037', '120003', '3', 2023, 'VP', 8.5, 4.87, 8.03, 7.54 FROM DUAL UNION ALL
	SELECT 'S40038', 'V50037', '120003', '3', 2023, 'VP', 5.61, 8.87, 7.0, 6.96 FROM DUAL UNION ALL
	SELECT 'S40080', 'V50037', '120003', '3', 2023, 'VP', 9.28, 4.41, 5.98, 6.66 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50037', '120003', '3', 2023, 'VP', 6.34, 9.87, 4.51, 6.13 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50037', '120003', '3', 2023, 'VP', 5.53, 9.22, 4.35, 5.68 FROM DUAL UNION ALL
	SELECT 'S40120', 'V50037', '120003', '3', 2023, 'VP', 5.22, 7.07, 6.04, 6.0 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50037', '120003', '3', 2023, 'VP', 4.09, 8.89, 6.08, 6.04 FROM DUAL UNION ALL
	SELECT 'S40059', 'V50037', '120003', '3', 2023, 'VP', 5.53, 8.39, 5.35, 6.01 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50037', '120003', '3', 2023, 'VP', 9.23, 5.06, 7.71, 7.64 FROM DUAL UNION ALL
	SELECT 'S40039', 'V50037', '120003', '3', 2023, 'VP', 5.74, 6.17, 6.78, 6.35 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50037', '120003', '3', 2023, 'VP', 7.33, 4.2, 8.86, 7.47 FROM DUAL UNION ALL
	SELECT 'S40116', 'V50037', '120003', '3', 2023, 'VP', 9.83, 7.86, 9.18, 9.11 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50037', '120003', '3', 2023, 'VP', 4.86, 5.81, 5.8, 5.52 FROM DUAL UNION ALL
	SELECT 'S40057', 'V50037', '120003', '3', 2023, 'VP', 7.04, 8.28, 7.65, 7.59 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50037', '120003', '3', 2023, 'VP', 6.46, 9.26, 5.78, 6.68 FROM DUAL;
INSERT INTO DANGKY
--2. BO MON HTTT
--	2023 - HOC KY 1
	SELECT 'S20029', 'V20065', '230002', '1', 2023, 'CLC', 6.67, 5.24, 7.57, 6.83 FROM DUAL UNION ALL
	SELECT 'S20068', 'V20065', '230002', '1', 2023, 'CLC', 8.16, 5.65, 7.03, 7.09 FROM DUAL UNION ALL
	SELECT 'S20010', 'V20065', '230002', '1', 2023, 'CLC', 7.17, 6.53, 9.31, 8.11 FROM DUAL UNION ALL
	SELECT 'S20048', 'V20065', '230002', '1', 2023, 'CLC', 9.2, 8.22, 7.42, 8.11 FROM DUAL UNION ALL
	SELECT 'S20106', 'V20065', '230002', '1', 2023, 'CLC', 7.59, 7.4, 5.9, 6.71 FROM DUAL UNION ALL
	SELECT 'S20069', 'V20065', '230002', '1', 2023, 'CLC', 9.05, 7.71, 6.79, 7.65 FROM DUAL UNION ALL
	SELECT 'S20026', 'V20065', '230002', '1', 2023, 'CLC', 4.29, 5.45, 5.4, 5.08 FROM DUAL UNION ALL
	SELECT 'S20050', 'V20065', '230002', '1', 2023, 'CLC', 4.69, 9.51, 4.17, 5.39 FROM DUAL UNION ALL
	SELECT 'S10105', 'V20062', '220002', '1', 2023, 'CQ', 6.39, 6.37, 7.91, 7.15 FROM DUAL UNION ALL
	SELECT 'S10024', 'V20062', '220002', '1', 2023, 'CQ', 8.82, 9.23, 4.8, 6.89 FROM DUAL UNION ALL
	SELECT 'S10065', 'V20062', '220002', '1', 2023, 'CQ', 7.47, 4.47, 8.45, 7.36 FROM DUAL UNION ALL
	SELECT 'S10005', 'V20062', '220002', '1', 2023, 'CQ', 6.08, 7.8, 8.31, 7.54 FROM DUAL UNION ALL
	SELECT 'S10102', 'V20062', '220002', '1', 2023, 'CQ', 4.2, 4.75, 4.21, 4.31 FROM DUAL UNION ALL
	SELECT 'S10002', 'V20062', '220002', '1', 2023, 'CQ', 5.41, 5.02, 6.5, 5.88 FROM DUAL UNION ALL
	SELECT 'S10042', 'V20062', '220002', '1', 2023, 'CQ', 8.01, 9.44, 6.4, 7.49 FROM DUAL UNION ALL
	SELECT 'S10081', 'V20062', '220002', '1', 2023, 'CQ', 9.99, 5.99, 6.91, 7.65 FROM DUAL UNION ALL
	SELECT 'S10063', 'V20062', '220002', '1', 2023, 'CQ', 7.65, 4.87, 7.36, 6.95 FROM DUAL UNION ALL
	SELECT 'S10064', 'V20062', '220002', '1', 2023, 'CQ', 5.58, 6.76, 8.43, 7.24 FROM DUAL UNION ALL
	SELECT 'S10003', 'V20062', '220002', '1', 2023, 'CQ', 5.51, 8.42, 6.89, 6.78 FROM DUAL UNION ALL
	SELECT 'S10001', 'V20062', '220002', '1', 2023, 'CQ', 6.52, 6.16, 4.34, 5.36 FROM DUAL UNION ALL
	SELECT 'S10022', 'V20062', '220002', '1', 2023, 'CQ', 9.75, 9.49, 9.51, 9.58 FROM DUAL UNION ALL
	SELECT 'S10025', 'V20062', '220002', '1', 2023, 'CQ', 6.09, 9.91, 4.91, 6.26 FROM DUAL UNION ALL
	SELECT 'S10045', 'V20062', '220002', '1', 2023, 'CQ', 8.41, 6.51, 4.58, 6.12 FROM DUAL UNION ALL
	SELECT 'S10104', 'V20062', '220002', '1', 2023, 'CQ', 7.34, 7.21, 6.0, 6.64 FROM DUAL UNION ALL
	SELECT 'S20008', 'V20064', '230003', '1', 2023, 'CLC', 5.57, 9.31, 8.09, 7.58 FROM DUAL UNION ALL
	SELECT 'S20030', 'V20064', '230003', '1', 2023, 'CLC', 8.97, 5.17, 9.63, 8.54 FROM DUAL UNION ALL
	SELECT 'S20068', 'V20064', '230003', '1', 2023, 'CLC', 6.84, 5.63, 5.23, 5.79 FROM DUAL UNION ALL
	SELECT 'S20007', 'V20064', '230003', '1', 2023, 'CLC', 6.5, 9.47, 8.44, 8.06 FROM DUAL UNION ALL
	SELECT 'S20109', 'V20064', '230003', '1', 2023, 'CLC', 10.0, 6.28, 8.68, 8.6 FROM DUAL UNION ALL
	SELECT 'S20028', 'V20064', '230003', '1', 2023, 'CLC', 7.46, 9.05, 6.04, 7.07 FROM DUAL UNION ALL
	SELECT 'S20027', 'V20064', '230003', '1', 2023, 'CLC', 4.03, 7.85, 8.38, 6.97 FROM DUAL UNION ALL
	SELECT 'S20106', 'V20064', '230003', '1', 2023, 'CLC', 7.29, 8.89, 7.11, 7.52 FROM DUAL UNION ALL
	SELECT 'S20110', 'V20064', '230003', '1', 2023, 'CLC', 7.75, 9.1, 5.51, 6.9 FROM DUAL UNION ALL
	SELECT 'S20046', 'V20064', '230003', '1', 2023, 'CLC', 6.98, 7.1, 4.5, 5.76 FROM DUAL UNION ALL
	SELECT 'S20047', 'V20064', '230003', '1', 2023, 'CLC', 7.07, 4.68, 9.92, 8.02 FROM DUAL UNION ALL
	SELECT 'S20090', 'V20064', '230003', '1', 2023, 'CLC', 8.83, 7.02, 9.73, 8.92 FROM DUAL UNION ALL
	SELECT 'S20107', 'V20064', '230003', '1', 2023, 'CLC', 6.18, 7.16, 9.85, 8.21 FROM DUAL UNION ALL
	SELECT 'S20048', 'V20064', '230003', '1', 2023, 'CLC', 6.89, 7.92, 4.28, 5.79 FROM DUAL UNION ALL
	SELECT 'S20066', 'V20064', '230003', '1', 2023, 'CLC', 9.58, 4.08, 4.88, 6.13 FROM DUAL UNION ALL
	SELECT 'S20006', 'V20064', '230003', '1', 2023, 'CLC', 7.59, 6.19, 4.7, 5.87 FROM DUAL UNION ALL
	SELECT 'S20010', 'V20064', '230003', '1', 2023, 'CLC', 6.41, 5.76, 5.56, 5.86 FROM DUAL UNION ALL
	SELECT 'S20067', 'V20064', '230003', '1', 2023, 'CLC', 6.68, 7.44, 9.2, 8.09 FROM DUAL UNION ALL
	SELECT 'S20026', 'V20064', '230003', '1', 2023, 'CLC', 6.87, 5.73, 5.03, 5.72 FROM DUAL UNION ALL
	SELECT 'S20089', 'V20064', '230003', '1', 2023, 'CLC', 5.25, 8.5, 7.06, 6.8 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20003', '210002', '1', 2023, 'CTTT', 5.5, 5.1, 4.08, 4.71 FROM DUAL UNION ALL
	SELECT 'S30034', 'V20003', '210002', '1', 2023, 'CTTT', 5.48, 5.53, 6.14, 5.82 FROM DUAL UNION ALL
	SELECT 'S30035', 'V20003', '210002', '1', 2023, 'CTTT', 6.3, 6.49, 5.42, 5.9 FROM DUAL UNION ALL
	SELECT 'S30053', 'V20003', '210002', '1', 2023, 'CTTT', 4.16, 9.98, 5.1, 5.79 FROM DUAL UNION ALL
	SELECT 'S30015', 'V20003', '210002', '1', 2023, 'CTTT', 7.34, 9.96, 5.31, 6.85 FROM DUAL UNION ALL
	SELECT 'S30094', 'V20003', '210002', '1', 2023, 'CTTT', 6.47, 4.11, 8.92, 7.22 FROM DUAL UNION ALL
	SELECT 'S30114', 'V20003', '210002', '1', 2023, 'CTTT', 6.46, 4.57, 9.71, 7.71 FROM DUAL UNION ALL
	SELECT 'S30011', 'V20003', '210002', '1', 2023, 'CTTT', 6.44, 8.62, 8.93, 8.12 FROM DUAL UNION ALL
	SELECT 'S30093', 'V20003', '210002', '1', 2023, 'CTTT', 5.73, 8.24, 7.75, 7.24 FROM DUAL UNION ALL
	SELECT 'S30032', 'V20003', '210002', '1', 2023, 'CTTT', 6.28, 7.53, 7.25, 7.02 FROM DUAL UNION ALL
	SELECT 'S30115', 'V20003', '210002', '1', 2023, 'CTTT', 5.56, 7.56, 4.93, 5.64 FROM DUAL UNION ALL
	SELECT 'S30052', 'V20003', '210002', '1', 2023, 'CTTT', 4.44, 5.53, 9.06, 6.97 FROM DUAL UNION ALL
	SELECT 'S30051', 'V20003', '210002', '1', 2023, 'CTTT', 5.67, 8.75, 6.43, 6.67 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20003', '210002', '1', 2023, 'CTTT', 8.17, 5.29, 8.59, 7.8 FROM DUAL UNION ALL
	SELECT 'S30073', 'V20003', '210002', '1', 2023, 'CTTT', 4.93, 4.88, 7.26, 6.08 FROM DUAL UNION ALL
	SELECT 'S30071', 'V20003', '210002', '1', 2023, 'CTTT', 9.42, 8.78, 5.3, 7.23 FROM DUAL UNION ALL
	SELECT 'S30113', 'V20003', '210002', '1', 2023, 'CTTT', 7.09, 4.21, 5.93, 5.93 FROM DUAL UNION ALL
	SELECT 'S30072', 'V20003', '210002', '1', 2023, 'CTTT', 8.16, 5.3, 6.97, 6.99 FROM DUAL UNION ALL
	SELECT 'S30013', 'V20003', '210002', '1', 2023, 'CTTT', 8.65, 6.51, 9.26, 8.53 FROM DUAL UNION ALL
	SELECT 'S30091', 'V20003', '210002', '1', 2023, 'CTTT', 7.55, 6.54, 9.16, 8.15 FROM DUAL UNION ALL
	SELECT 'S30111', 'V20003', '210002', '1', 2023, 'CTTT', 6.41, 9.08, 6.8, 7.14 FROM DUAL UNION ALL
	SELECT 'S30054', 'V20003', '210002', '1', 2023, 'CTTT', 8.34, 9.6, 8.59, 8.72 FROM DUAL UNION ALL
	SELECT 'S30095', 'V20003', '210002', '1', 2023, 'CTTT', 7.86, 6.45, 8.76, 8.03 FROM DUAL UNION ALL
	SELECT 'S30033', 'V20003', '210002', '1', 2023, 'CTTT', 7.75, 9.06, 6.78, 7.53 FROM DUAL UNION ALL
	SELECT 'S10085', 'V20002', '220003', '1', 2023, 'CQ', 9.88, 8.9, 4.43, 6.96 FROM DUAL UNION ALL
	SELECT 'S10101', 'V20002', '220003', '1', 2023, 'CQ', 5.17, 4.75, 7.93, 6.47 FROM DUAL UNION ALL
	SELECT 'S10025', 'V20002', '220003', '1', 2023, 'CQ', 4.14, 6.39, 5.63, 5.33 FROM DUAL UNION ALL
	SELECT 'S10084', 'V20002', '220003', '1', 2023, 'CQ', 7.28, 8.07, 7.8, 7.7 FROM DUAL UNION ALL
	SELECT 'S10045', 'V20002', '220003', '1', 2023, 'CQ', 7.22, 7.9, 9.39, 8.44 FROM DUAL UNION ALL
	SELECT 'S10002', 'V20002', '220003', '1', 2023, 'CQ', 6.35, 4.93, 5.34, 5.56 FROM DUAL UNION ALL
	SELECT 'S10022', 'V20002', '220003', '1', 2023, 'CQ', 9.25, 6.37, 6.72, 7.41 FROM DUAL UNION ALL
	SELECT 'S10021', 'V20002', '220003', '1', 2023, 'CQ', 4.47, 5.5, 5.37, 5.13 FROM DUAL UNION ALL
	SELECT 'S10083', 'V20002', '220003', '1', 2023, 'CQ', 8.91, 7.27, 8.15, 8.2 FROM DUAL UNION ALL
	SELECT 'S10023', 'V20002', '220003', '1', 2023, 'CQ', 7.96, 9.46, 9.0, 8.78 FROM DUAL UNION ALL
	SELECT 'S10003', 'V20002', '220003', '1', 2023, 'CQ', 4.77, 8.47, 4.95, 5.6 FROM DUAL UNION ALL
	SELECT 'S10065', 'V20002', '220003', '1', 2023, 'CQ', 6.39, 9.96, 4.3, 6.06 FROM DUAL UNION ALL
	SELECT 'S10081', 'V20002', '220003', '1', 2023, 'CQ', 6.19, 5.83, 8.68, 7.36 FROM DUAL UNION ALL
	SELECT 'S10024', 'V20002', '220003', '1', 2023, 'CQ', 8.7, 5.63, 8.62, 8.05 FROM DUAL UNION ALL
	SELECT 'S10041', 'V20002', '220003', '1', 2023, 'CQ', 5.25, 4.56, 9.7, 7.34 FROM DUAL UNION ALL
	SELECT 'S40060', 'V20062', '210001', '1', 2023, 'VP', 4.14, 8.34, 6.75, 6.29 FROM DUAL UNION ALL
	SELECT 'S40100', 'V20062', '210001', '1', 2023, 'VP', 9.64, 6.36, 9.72, 9.02 FROM DUAL UNION ALL
	SELECT 'S40018', 'V20062', '210001', '1', 2023, 'VP', 8.02, 9.39, 9.45, 9.01 FROM DUAL UNION ALL
	SELECT 'S40119', 'V20062', '210001', '1', 2023, 'VP', 4.77, 4.78, 8.13, 6.45 FROM DUAL UNION ALL
	SELECT 'S40120', 'V20062', '210001', '1', 2023, 'VP', 7.84, 8.68, 8.74, 8.46 FROM DUAL UNION ALL
	SELECT 'S40117', 'V20062', '210001', '1', 2023, 'VP', 9.29, 5.6, 4.71, 6.26 FROM DUAL UNION ALL
	SELECT 'S40056', 'V20062', '210001', '1', 2023, 'VP', 6.4, 9.38, 5.62, 6.61 FROM DUAL UNION ALL
	SELECT 'S40016', 'V20062', '210001', '1', 2023, 'VP', 8.44, 9.87, 4.79, 6.9 FROM DUAL UNION ALL
	SELECT 'S40077', 'V20062', '210001', '1', 2023, 'VP', 9.86, 4.77, 5.08, 6.45 FROM DUAL UNION ALL
	SELECT 'S40080', 'V20062', '210001', '1', 2023, 'VP', 6.29, 7.22, 4.81, 5.74 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S30094', 'V20008', '220001', '2', 2023, 'CTTT', 8.24, 6.02, 5.52, 6.44 FROM DUAL UNION ALL
	SELECT 'S30095', 'V20008', '220001', '2', 2023, 'CTTT', 9.31, 7.83, 5.49, 7.1 FROM DUAL UNION ALL
	SELECT 'S30091', 'V20008', '220001', '2', 2023, 'CTTT', 6.87, 7.63, 6.88, 7.03 FROM DUAL UNION ALL
	SELECT 'S30051', 'V20008', '220001', '2', 2023, 'CTTT', 4.7, 6.82, 8.77, 7.16 FROM DUAL UNION ALL
	SELECT 'S30054', 'V20008', '220001', '2', 2023, 'CTTT', 8.01, 8.93, 4.05, 6.21 FROM DUAL UNION ALL
	SELECT 'S30112', 'V20008', '220001', '2', 2023, 'CTTT', 5.7, 7.51, 6.75, 6.59 FROM DUAL UNION ALL
	SELECT 'S30115', 'V20008', '220001', '2', 2023, 'CTTT', 7.59, 4.69, 6.46, 6.45 FROM DUAL UNION ALL
	SELECT 'S30015', 'V20008', '220001', '2', 2023, 'CTTT', 7.37, 7.89, 8.44, 8.01 FROM DUAL UNION ALL
	SELECT 'S30011', 'V20008', '220001', '2', 2023, 'CTTT', 5.48, 7.11, 8.84, 7.49 FROM DUAL UNION ALL
	SELECT 'S30111', 'V20008', '220001', '2', 2023, 'CTTT', 6.07, 4.57, 6.85, 6.16 FROM DUAL UNION ALL
	SELECT 'S30035', 'V20008', '220001', '2', 2023, 'CTTT', 8.14, 6.88, 8.0, 7.82 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20008', '220001', '2', 2023, 'CTTT', 6.55, 8.96, 9.82, 8.67 FROM DUAL UNION ALL
	SELECT 'S30073', 'V20008', '220001', '2', 2023, 'CTTT', 9.05, 8.64, 4.02, 6.45 FROM DUAL UNION ALL
	SELECT 'S30075', 'V20008', '220001', '2', 2023, 'CTTT', 5.91, 8.44, 7.52, 7.22 FROM DUAL UNION ALL
	SELECT 'S30033', 'V20008', '220001', '2', 2023, 'CTTT', 9.44, 6.35, 9.98, 9.09 FROM DUAL UNION ALL
	SELECT 'S30012', 'V20008', '220001', '2', 2023, 'CTTT', 9.91, 6.66, 8.87, 8.74 FROM DUAL UNION ALL
	SELECT 'S30093', 'V20008', '220001', '2', 2023, 'CTTT', 7.26, 6.42, 8.3, 7.61 FROM DUAL UNION ALL
	SELECT 'S30071', 'V20008', '220001', '2', 2023, 'CTTT', 7.7, 5.04, 7.9, 7.27 FROM DUAL UNION ALL
	SELECT 'S30034', 'V20008', '220001', '2', 2023, 'CTTT', 4.14, 9.89, 9.09, 7.76 FROM DUAL UNION ALL
	SELECT 'S30072', 'V20008', '220001', '2', 2023, 'CTTT', 8.59, 6.41, 9.49, 8.6 FROM DUAL UNION ALL
	SELECT 'S10043', 'V20007', '230001', '2', 2023, 'CQ', 7.81, 4.22, 9.49, 7.93 FROM DUAL UNION ALL
	SELECT 'S10105', 'V20007', '230001', '2', 2023, 'CQ', 9.9, 8.02, 8.93, 9.04 FROM DUAL UNION ALL
	SELECT 'S10021', 'V20007', '230001', '2', 2023, 'CQ', 7.49, 6.5, 4.53, 5.81 FROM DUAL UNION ALL
	SELECT 'S10042', 'V20007', '230001', '2', 2023, 'CQ', 8.84, 6.13, 4.36, 6.06 FROM DUAL UNION ALL
	SELECT 'S10063', 'V20007', '230001', '2', 2023, 'CQ', 8.27, 5.08, 6.11, 6.55 FROM DUAL UNION ALL
	SELECT 'S10044', 'V20007', '230001', '2', 2023, 'CQ', 7.29, 5.6, 7.35, 6.98 FROM DUAL UNION ALL
	SELECT 'S10025', 'V20007', '230001', '2', 2023, 'CQ', 6.91, 6.24, 6.93, 6.79 FROM DUAL UNION ALL
	SELECT 'S10103', 'V20007', '230001', '2', 2023, 'CQ', 8.56, 6.89, 7.28, 7.59 FROM DUAL UNION ALL
	SELECT 'S10085', 'V20007', '230001', '2', 2023, 'CQ', 7.22, 7.43, 9.91, 8.61 FROM DUAL UNION ALL
	SELECT 'S10102', 'V20007', '230001', '2', 2023, 'CQ', 6.24, 8.56, 5.33, 6.25 FROM DUAL UNION ALL
	SELECT 'S10064', 'V20007', '230001', '2', 2023, 'CQ', 5.83, 8.97, 6.21, 6.65 FROM DUAL UNION ALL
	SELECT 'S10001', 'V20007', '230001', '2', 2023, 'CQ', 7.17, 8.79, 8.33, 8.07 FROM DUAL UNION ALL
	SELECT 'S10041', 'V20007', '230001', '2', 2023, 'CQ', 8.78, 9.54, 4.73, 6.91 FROM DUAL UNION ALL
	SELECT 'S10062', 'V20007', '230001', '2', 2023, 'CQ', 6.76, 4.78, 5.2, 5.58 FROM DUAL UNION ALL
	SELECT 'S10024', 'V20007', '230001', '2', 2023, 'CQ', 4.88, 8.09, 5.16, 5.66 FROM DUAL UNION ALL
	SELECT 'S10002', 'V20007', '230001', '2', 2023, 'CQ', 7.56, 9.1, 5.31, 6.74 FROM DUAL UNION ALL
	SELECT 'S10101', 'V20007', '230001', '2', 2023, 'CQ', 9.86, 9.12, 6.64, 8.1 FROM DUAL UNION ALL
	SELECT 'S10084', 'V20007', '230001', '2', 2023, 'CQ', 6.52, 9.63, 6.15, 6.96 FROM DUAL UNION ALL
	SELECT 'S10065', 'V20007', '230001', '2', 2023, 'CQ', 5.91, 5.57, 8.84, 7.31 FROM DUAL UNION ALL
	SELECT 'S40076', 'V20001', '210003', '2', 2023, 'VP', 9.5, 4.3, 4.34, 5.88 FROM DUAL UNION ALL
	SELECT 'S40078', 'V20001', '210003', '2', 2023, 'VP', 4.06, 8.31, 8.55, 7.16 FROM DUAL UNION ALL
	SELECT 'S40059', 'V20001', '210003', '2', 2023, 'VP', 6.26, 8.86, 9.61, 8.46 FROM DUAL UNION ALL
	SELECT 'S40060', 'V20001', '210003', '2', 2023, 'VP', 6.09, 6.21, 6.31, 6.22 FROM DUAL UNION ALL
	SELECT 'S40019', 'V20001', '210003', '2', 2023, 'VP', 4.9, 9.72, 9.93, 8.38 FROM DUAL UNION ALL
	SELECT 'S40017', 'V20001', '210003', '2', 2023, 'VP', 4.09, 4.46, 6.77, 5.5 FROM DUAL UNION ALL
	SELECT 'S40117', 'V20001', '210003', '2', 2023, 'VP', 5.68, 7.65, 5.73, 6.1 FROM DUAL UNION ALL
	SELECT 'S40096', 'V20001', '210003', '2', 2023, 'VP', 6.62, 8.6, 8.42, 7.92 FROM DUAL UNION ALL
	SELECT 'S40099', 'V20001', '210003', '2', 2023, 'VP', 9.19, 4.07, 5.51, 6.33 FROM DUAL UNION ALL
	SELECT 'S40116', 'V20001', '210003', '2', 2023, 'VP', 5.21, 7.25, 7.23, 6.63 FROM DUAL UNION ALL
	SELECT 'S40057', 'V20001', '210003', '2', 2023, 'VP', 8.42, 8.99, 7.68, 8.16 FROM DUAL UNION ALL
	SELECT 'S40036', 'V20001', '210003', '2', 2023, 'VP', 5.03, 6.43, 9.7, 7.64 FROM DUAL UNION ALL
	SELECT 'S40118', 'V20001', '210003', '2', 2023, 'VP', 5.05, 6.75, 5.07, 5.4 FROM DUAL UNION ALL
	SELECT 'S40016', 'V20001', '210003', '2', 2023, 'VP', 8.78, 9.87, 7.23, 8.22 FROM DUAL UNION ALL
	SELECT 'S40040', 'V20001', '210003', '2', 2023, 'VP', 7.03, 6.94, 4.26, 5.63 FROM DUAL UNION ALL
	SELECT 'S10045', 'V20063', '220004', '2', 2023, 'CQ', 4.01, 9.39, 5.46, 5.81 FROM DUAL UNION ALL
	SELECT 'S10041', 'V20063', '220004', '2', 2023, 'CQ', 4.07, 5.96, 7.85, 6.34 FROM DUAL UNION ALL
	SELECT 'S10102', 'V20063', '220004', '2', 2023, 'CQ', 5.36, 4.25, 4.73, 4.82 FROM DUAL UNION ALL
	SELECT 'S10063', 'V20063', '220004', '2', 2023, 'CQ', 5.8, 8.71, 8.62, 7.79 FROM DUAL UNION ALL
	SELECT 'S10021', 'V20063', '220004', '2', 2023, 'CQ', 5.04, 6.26, 7.4, 6.46 FROM DUAL UNION ALL
	SELECT 'S10044', 'V20063', '220004', '2', 2023, 'CQ', 6.13, 6.58, 5.46, 5.88 FROM DUAL UNION ALL
	SELECT 'S10024', 'V20063', '220004', '2', 2023, 'CQ', 7.42, 4.97, 5.19, 5.81 FROM DUAL UNION ALL
	SELECT 'S10023', 'V20063', '220004', '2', 2023, 'CQ', 4.29, 4.68, 7.17, 5.81 FROM DUAL UNION ALL
	SELECT 'S30074', 'V20065', '220006', '2', 2023, 'CTTT', 5.81, 5.27, 9.4, 7.5 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20065', '220006', '2', 2023, 'CTTT', 9.07, 4.4, 8.51, 7.86 FROM DUAL UNION ALL
	SELECT 'S30093', 'V20065', '220006', '2', 2023, 'CTTT', 6.34, 4.18, 5.39, 5.43 FROM DUAL UNION ALL
	SELECT 'S30072', 'V20065', '220006', '2', 2023, 'CTTT', 7.57, 5.94, 4.4, 5.66 FROM DUAL UNION ALL
	SELECT 'S30011', 'V20065', '220006', '2', 2023, 'CTTT', 9.47, 8.92, 9.58, 9.41 FROM DUAL UNION ALL
	SELECT 'S30054', 'V20065', '220006', '2', 2023, 'CTTT', 7.09, 5.8, 8.05, 7.31 FROM DUAL UNION ALL
	SELECT 'S30075', 'V20065', '220006', '2', 2023, 'CTTT', 5.39, 9.77, 5.25, 6.2 FROM DUAL UNION ALL
	SELECT 'S30051', 'V20065', '220006', '2', 2023, 'CTTT', 8.64, 8.25, 9.74, 9.11 FROM DUAL UNION ALL
	SELECT 'S30013', 'V20065', '220006', '2', 2023, 'CTTT', 7.22, 8.67, 8.94, 8.37 FROM DUAL UNION ALL
	SELECT 'S30052', 'V20065', '220006', '2', 2023, 'CTTT', 5.69, 4.53, 5.5, 5.36 FROM DUAL UNION ALL
	SELECT 'S30032', 'V20065', '220006', '2', 2023, 'CTTT', 5.13, 5.08, 7.7, 6.4 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20065', '220006', '2', 2023, 'CTTT', 4.16, 4.54, 6.45, 5.38 FROM DUAL UNION ALL
	SELECT 'S30012', 'V20065', '220006', '2', 2023, 'CTTT', 5.05, 8.79, 6.64, 6.59 FROM DUAL UNION ALL
	SELECT 'S30111', 'V20065', '220006', '2', 2023, 'CTTT', 8.14, 6.91, 8.46, 8.05 FROM DUAL UNION ALL
	SELECT 'S30073', 'V20062', '220007', '2', 2023, 'CTTT', 6.54, 7.67, 4.2, 5.6 FROM DUAL UNION ALL
	SELECT 'S30095', 'V20062', '220007', '2', 2023, 'CTTT', 4.77, 8.33, 9.75, 7.97 FROM DUAL UNION ALL
	SELECT 'S30055', 'V20062', '220007', '2', 2023, 'CTTT', 7.38, 8.71, 5.76, 6.84 FROM DUAL UNION ALL
	SELECT 'S30071', 'V20062', '220007', '2', 2023, 'CTTT', 9.14, 5.67, 9.7, 8.73 FROM DUAL UNION ALL
	SELECT 'S30092', 'V20062', '220007', '2', 2023, 'CTTT', 5.31, 9.56, 7.55, 7.28 FROM DUAL UNION ALL
	SELECT 'S30113', 'V20062', '220007', '2', 2023, 'CTTT', 5.09, 7.48, 6.09, 6.07 FROM DUAL UNION ALL
	SELECT 'S30032', 'V20062', '220007', '2', 2023, 'CTTT', 7.87, 9.93, 4.71, 6.7 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20062', '220007', '2', 2023, 'CTTT', 6.86, 5.22, 9.92, 8.06 FROM DUAL UNION ALL
	SELECT 'S30051', 'V20062', '220007', '2', 2023, 'CTTT', 7.32, 8.67, 6.1, 6.98 FROM DUAL UNION ALL
	SELECT 'S30011', 'V20062', '220007', '2', 2023, 'CTTT', 4.63, 6.57, 8.18, 6.79 FROM DUAL UNION ALL
	SELECT 'S30033', 'V20062', '220007', '2', 2023, 'CTTT', 5.12, 6.3, 6.94, 6.27 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20062', '220007', '2', 2023, 'CTTT', 9.56, 6.78, 6.58, 7.51 FROM DUAL UNION ALL
	SELECT 'S30091', 'V20062', '220007', '2', 2023, 'CTTT', 4.46, 9.12, 4.94, 5.63 FROM DUAL UNION ALL
	SELECT 'S30112', 'V20062', '220007', '2', 2023, 'CTTT', 6.93, 9.7, 8.84, 8.44 FROM DUAL UNION ALL
	SELECT 'S30052', 'V20062', '220007', '2', 2023, 'CTTT', 8.64, 9.11, 7.29, 8.06 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S30015', 'V20009', '220005', '3', 2023, 'CTTT', 5.83, 6.52, 5.23, 5.67 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20009', '220005', '3', 2023, 'CTTT', 5.75, 7.85, 6.13, 6.36 FROM DUAL UNION ALL
	SELECT 'S30055', 'V20009', '220005', '3', 2023, 'CTTT', 5.26, 7.74, 4.29, 5.27 FROM DUAL UNION ALL
	SELECT 'S30054', 'V20009', '220005', '3', 2023, 'CTTT', 7.44, 4.21, 6.21, 6.18 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20009', '220005', '3', 2023, 'CTTT', 7.64, 7.11, 4.31, 5.87 FROM DUAL UNION ALL
	SELECT 'S30112', 'V20009', '220005', '3', 2023, 'CTTT', 9.57, 6.56, 7.54, 7.95 FROM DUAL UNION ALL
	SELECT 'S30074', 'V20009', '220005', '3', 2023, 'CTTT', 6.24, 8.87, 9.37, 8.33 FROM DUAL UNION ALL
	SELECT 'S30095', 'V20009', '220005', '3', 2023, 'CTTT', 5.42, 7.19, 4.63, 5.38 FROM DUAL UNION ALL
	SELECT 'S30013', 'V20061', '210004', '3', 2023, 'CTTT', 9.41, 5.07, 5.52, 6.6 FROM DUAL UNION ALL
	SELECT 'S30071', 'V20061', '210004', '3', 2023, 'CTTT', 5.92, 7.27, 7.62, 7.04 FROM DUAL UNION ALL
	SELECT 'S30054', 'V20061', '210004', '3', 2023, 'CTTT', 4.12, 9.92, 7.28, 6.86 FROM DUAL UNION ALL
	SELECT 'S30092', 'V20061', '210004', '3', 2023, 'CTTT', 6.73, 9.32, 9.35, 8.56 FROM DUAL UNION ALL
	SELECT 'S30115', 'V20061', '210004', '3', 2023, 'CTTT', 5.23, 6.68, 5.75, 5.78 FROM DUAL UNION ALL
	SELECT 'S30051', 'V20061', '210004', '3', 2023, 'CTTT', 7.11, 9.47, 6.39, 7.22 FROM DUAL UNION ALL
	SELECT 'S30053', 'V20061', '210004', '3', 2023, 'CTTT', 8.34, 4.06, 9.78, 8.2 FROM DUAL UNION ALL
	SELECT 'S30095', 'V20061', '210004', '3', 2023, 'CTTT', 4.34, 5.77, 8.75, 6.83 FROM DUAL UNION ALL
	SELECT 'S30032', 'V20061', '210004', '3', 2023, 'CTTT', 4.62, 5.44, 8.31, 6.63 FROM DUAL UNION ALL
	SELECT 'S30034', 'V20061', '210004', '3', 2023, 'CTTT', 6.18, 6.54, 9.05, 7.69 FROM DUAL UNION ALL
	SELECT 'S30035', 'V20061', '210004', '3', 2023, 'CTTT', 7.56, 9.58, 8.74, 8.55 FROM DUAL UNION ALL
	SELECT 'S30094', 'V20061', '210004', '3', 2023, 'CTTT', 9.85, 7.26, 6.82, 7.82 FROM DUAL UNION ALL
	SELECT 'S30113', 'V20061', '210004', '3', 2023, 'CTTT', 7.5, 7.27, 5.59, 6.5 FROM DUAL UNION ALL
	SELECT 'S30074', 'V20061', '210004', '3', 2023, 'CTTT', 9.21, 8.92, 9.84, 9.47 FROM DUAL UNION ALL
	SELECT 'S30073', 'V20061', '210004', '3', 2023, 'CTTT', 4.91, 6.02, 4.24, 4.8 FROM DUAL UNION ALL
	SELECT 'S30014', 'V20061', '210004', '3', 2023, 'CTTT', 8.67, 4.68, 8.84, 7.96 FROM DUAL UNION ALL
	SELECT 'S30031', 'V20061', '210004', '3', 2023, 'CTTT', 8.39, 5.83, 6.33, 6.85 FROM DUAL UNION ALL
	SELECT 'S30111', 'V20061', '210004', '3', 2023, 'CTTT', 5.92, 8.58, 4.38, 5.68 FROM DUAL UNION ALL
	SELECT 'S30091', 'V20061', '210004', '3', 2023, 'CTTT', 8.56, 4.18, 5.65, 6.23 FROM DUAL UNION ALL
	SELECT 'S30093', 'V20061', '210004', '3', 2023, 'CTTT', 9.31, 4.1, 6.38, 6.8 FROM DUAL UNION ALL
	SELECT 'S30112', 'V20061', '210004', '3', 2023, 'CTTT', 9.65, 9.24, 9.61, 9.55 FROM DUAL UNION ALL
	SELECT 'S30011', 'V20061', '210004', '3', 2023, 'CTTT', 8.92, 5.03, 9.85, 8.61 FROM DUAL UNION ALL
	SELECT 'S30055', 'V20061', '210004', '3', 2023, 'CTTT', 9.76, 9.06, 8.55, 9.02 FROM DUAL UNION ALL
	SELECT 'S30012', 'V20061', '210004', '3', 2023, 'CTTT', 9.44, 9.89, 7.13, 8.38 FROM DUAL UNION ALL
	SELECT 'S30052', 'V20061', '210004', '3', 2023, 'CTTT', 7.76, 8.92, 7.95, 8.09 FROM DUAL UNION ALL
	SELECT 'S40100', 'V20004', '210005', '3', 2023, 'VP', 7.66, 5.49, 8.32, 7.56 FROM DUAL UNION ALL
	SELECT 'S40079', 'V20004', '210005', '3', 2023, 'VP', 6.83, 4.91, 4.09, 5.08 FROM DUAL UNION ALL
	SELECT 'S40036', 'V20004', '210005', '3', 2023, 'VP', 9.21, 8.14, 8.82, 8.8 FROM DUAL UNION ALL
	SELECT 'S40059', 'V20004', '210005', '3', 2023, 'VP', 4.04, 8.49, 8.19, 7.0 FROM DUAL UNION ALL
	SELECT 'S40056', 'V20004', '210005', '3', 2023, 'VP', 7.32, 7.49, 5.85, 6.62 FROM DUAL UNION ALL
	SELECT 'S40116', 'V20004', '210005', '3', 2023, 'VP', 8.36, 5.34, 5.65, 6.4 FROM DUAL UNION ALL
	SELECT 'S40016', 'V20004', '210005', '3', 2023, 'VP', 5.17, 5.97, 7.14, 6.31 FROM DUAL UNION ALL
	SELECT 'S40057', 'V20004', '210005', '3', 2023, 'VP', 4.32, 8.73, 5.72, 5.9 FROM DUAL UNION ALL
	SELECT 'S40119', 'V20004', '210005', '3', 2023, 'VP', 8.96, 8.79, 5.22, 7.06 FROM DUAL UNION ALL
	SELECT 'S40040', 'V20004', '210005', '3', 2023, 'VP', 9.84, 6.48, 9.05, 8.77 FROM DUAL UNION ALL
	SELECT 'S40037', 'V20004', '210005', '3', 2023, 'VP', 4.48, 4.67, 7.7, 6.13 FROM DUAL UNION ALL
	SELECT 'S40076', 'V20004', '210005', '3', 2023, 'VP', 9.22, 7.78, 4.68, 6.66 FROM DUAL UNION ALL
	SELECT 'S40080', 'V20004', '210005', '3', 2023, 'VP', 8.75, 9.91, 5.05, 7.13 FROM DUAL UNION ALL
	SELECT 'S40039', 'V20004', '210005', '3', 2023, 'VP', 9.01, 4.47, 8.04, 7.62 FROM DUAL;
INSERT INTO DANGKY
--3. BO MON CNPM
--	2023 - HOC KY 1
	SELECT 'S40116', 'V30019', '330005', '1', 2023, 'VP', 6.48, 9.42, 7.98, 7.82 FROM DUAL UNION ALL
	SELECT 'S40098', 'V30019', '330005', '1', 2023, 'VP', 5.14, 8.12, 8.26, 7.3 FROM DUAL UNION ALL
	SELECT 'S40018', 'V30019', '330005', '1', 2023, 'VP', 7.68, 5.93, 4.38, 5.68 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30019', '330005', '1', 2023, 'VP', 6.73, 4.36, 5.51, 5.65 FROM DUAL UNION ALL
	SELECT 'S40057', 'V30019', '330005', '1', 2023, 'VP', 5.63, 7.09, 6.74, 6.48 FROM DUAL UNION ALL
	SELECT 'S40060', 'V30019', '330005', '1', 2023, 'VP', 5.99, 7.94, 8.57, 7.67 FROM DUAL UNION ALL
	SELECT 'S40039', 'V30019', '330005', '1', 2023, 'VP', 5.51, 7.86, 9.76, 8.11 FROM DUAL UNION ALL
	SELECT 'S40080', 'V30019', '330005', '1', 2023, 'VP', 6.64, 9.43, 5.81, 6.78 FROM DUAL UNION ALL
	SELECT 'S40119', 'V30019', '330005', '1', 2023, 'VP', 4.83, 5.49, 7.53, 6.31 FROM DUAL UNION ALL
	SELECT 'S40036', 'V30019', '330005', '1', 2023, 'VP', 9.25, 5.42, 8.59, 8.15 FROM DUAL UNION ALL
	SELECT 'S40117', 'V30019', '330005', '1', 2023, 'VP', 5.83, 6.21, 8.43, 7.21 FROM DUAL UNION ALL
	SELECT 'S40038', 'V30066', '320003', '1', 2023, 'VP', 4.2, 4.15, 9.83, 7.0 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30066', '320003', '1', 2023, 'VP', 9.11, 8.15, 7.53, 8.13 FROM DUAL UNION ALL
	SELECT 'S40039', 'V30066', '320003', '1', 2023, 'VP', 7.9, 5.0, 5.8, 6.27 FROM DUAL UNION ALL
	SELECT 'S40076', 'V30066', '320003', '1', 2023, 'VP', 6.89, 4.25, 9.05, 7.44 FROM DUAL UNION ALL
	SELECT 'S40097', 'V30066', '320003', '1', 2023, 'VP', 7.69, 7.22, 8.23, 7.87 FROM DUAL UNION ALL
	SELECT 'S40019', 'V30066', '320003', '1', 2023, 'VP', 4.22, 5.65, 9.78, 7.29 FROM DUAL UNION ALL
	SELECT 'S40080', 'V30066', '320003', '1', 2023, 'VP', 7.87, 7.42, 6.62, 7.15 FROM DUAL UNION ALL
	SELECT 'S40096', 'V30066', '320003', '1', 2023, 'VP', 9.4, 4.37, 5.2, 6.29 FROM DUAL UNION ALL
	SELECT 'S40078', 'V30066', '320003', '1', 2023, 'VP', 8.09, 5.2, 6.0, 6.47 FROM DUAL UNION ALL
	SELECT 'S40077', 'V30066', '320003', '1', 2023, 'VP', 4.63, 9.92, 4.06, 5.4 FROM DUAL UNION ALL
	SELECT 'S40099', 'V30066', '320003', '1', 2023, 'VP', 9.82, 4.49, 5.48, 6.58 FROM DUAL UNION ALL
	SELECT 'S40120', 'V30066', '320003', '1', 2023, 'VP', 4.54, 4.0, 4.64, 4.48 FROM DUAL UNION ALL
	SELECT 'S40020', 'V30066', '320003', '1', 2023, 'VP', 4.08, 7.79, 4.55, 5.06 FROM DUAL UNION ALL
	SELECT 'S40060', 'V30066', '320003', '1', 2023, 'VP', 6.55, 9.3, 9.49, 8.57 FROM DUAL UNION ALL
	SELECT 'S40116', 'V30066', '320003', '1', 2023, 'VP', 6.2, 4.69, 6.41, 6.0 FROM DUAL UNION ALL
	SELECT 'S40016', 'V30066', '320003', '1', 2023, 'VP', 4.45, 7.27, 7.33, 6.45 FROM DUAL UNION ALL
	SELECT 'S40018', 'V30066', '320003', '1', 2023, 'VP', 8.66, 6.57, 4.21, 6.02 FROM DUAL UNION ALL
	SELECT 'S40100', 'V30066', '320003', '1', 2023, 'VP', 5.44, 7.39, 4.75, 5.49 FROM DUAL UNION ALL
	SELECT 'S40040', 'V30066', '320003', '1', 2023, 'VP', 4.77, 5.65, 4.17, 4.65 FROM DUAL UNION ALL
	SELECT 'S40079', 'V30066', '320003', '1', 2023, 'VP', 4.97, 7.85, 4.88, 5.5 FROM DUAL UNION ALL
	SELECT 'S40119', 'V30066', '320003', '1', 2023, 'VP', 9.6, 6.5, 5.66, 7.01 FROM DUAL UNION ALL
	SELECT 'S40017', 'V30066', '320003', '1', 2023, 'VP', 5.28, 8.26, 7.12, 6.8 FROM DUAL UNION ALL
	SELECT 'S40117', 'V30066', '320003', '1', 2023, 'VP', 5.78, 7.11, 7.27, 6.79 FROM DUAL UNION ALL
	SELECT 'S40036', 'V30066', '320003', '1', 2023, 'VP', 5.0, 9.67, 7.64, 7.25 FROM DUAL UNION ALL
	SELECT 'S40098', 'V30066', '320003', '1', 2023, 'VP', 8.48, 5.55, 9.98, 8.64 FROM DUAL UNION ALL
	SELECT 'S40118', 'V30066', '320003', '1', 2023, 'VP', 8.58, 4.96, 7.05, 7.09 FROM DUAL UNION ALL
	SELECT 'S40059', 'V30066', '320003', '1', 2023, 'VP', 8.45, 4.89, 5.07, 6.05 FROM DUAL UNION ALL
	SELECT 'S40057', 'V30066', '320003', '1', 2023, 'VP', 9.49, 4.34, 7.83, 7.63 FROM DUAL UNION ALL
	SELECT 'S40056', 'V30066', '320003', '1', 2023, 'VP', 6.43, 7.94, 5.79, 6.41 FROM DUAL UNION ALL
	SELECT 'S30051', 'V30014', '330004', '1', 2023, 'CTTT', 6.22, 7.24, 9.31, 7.97 FROM DUAL UNION ALL
	SELECT 'S30011', 'V30014', '330004', '1', 2023, 'CTTT', 9.74, 5.8, 4.28, 6.22 FROM DUAL UNION ALL
	SELECT 'S30095', 'V30014', '330004', '1', 2023, 'CTTT', 5.81, 8.08, 4.11, 5.41 FROM DUAL UNION ALL
	SELECT 'S30071', 'V30014', '330004', '1', 2023, 'CTTT', 5.2, 8.83, 4.61, 5.63 FROM DUAL UNION ALL
	SELECT 'S30014', 'V30014', '330004', '1', 2023, 'CTTT', 9.59, 5.48, 8.58, 8.26 FROM DUAL UNION ALL
	SELECT 'S30093', 'V30014', '330004', '1', 2023, 'CTTT', 8.09, 8.48, 8.12, 8.18 FROM DUAL UNION ALL
	SELECT 'S40056', 'V30015', '320002', '1', 2023, 'VP', 6.31, 7.13, 4.69, 5.66 FROM DUAL UNION ALL
	SELECT 'S40038', 'V30015', '320002', '1', 2023, 'VP', 8.15, 7.96, 4.15, 6.11 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30015', '320002', '1', 2023, 'VP', 5.2, 9.61, 8.09, 7.53 FROM DUAL UNION ALL
	SELECT 'S40078', 'V30015', '320002', '1', 2023, 'VP', 5.77, 4.44, 5.8, 5.52 FROM DUAL UNION ALL
	SELECT 'S40096', 'V30015', '320002', '1', 2023, 'VP', 7.74, 4.68, 7.7, 7.11 FROM DUAL UNION ALL
	SELECT 'S40059', 'V30015', '320002', '1', 2023, 'VP', 4.55, 4.61, 5.07, 4.82 FROM DUAL UNION ALL
	SELECT 'S40020', 'V30015', '320002', '1', 2023, 'VP', 5.06, 7.81, 7.59, 6.88 FROM DUAL UNION ALL
	SELECT 'S40017', 'V30015', '320002', '1', 2023, 'VP', 5.29, 4.4, 9.2, 7.07 FROM DUAL UNION ALL
	SELECT 'S40039', 'V30015', '320002', '1', 2023, 'VP', 9.45, 7.48, 4.89, 6.78 FROM DUAL UNION ALL
	SELECT 'S40079', 'V30015', '320002', '1', 2023, 'VP', 5.34, 5.71, 5.1, 5.29 FROM DUAL UNION ALL
	SELECT 'S40076', 'V30015', '320002', '1', 2023, 'VP', 6.94, 8.37, 5.56, 6.54 FROM DUAL UNION ALL
	SELECT 'S40098', 'V30015', '320002', '1', 2023, 'VP', 7.55, 6.77, 9.35, 8.29 FROM DUAL UNION ALL
	SELECT 'S40019', 'V30015', '320002', '1', 2023, 'VP', 5.33, 8.5, 9.32, 7.96 FROM DUAL UNION ALL
	SELECT 'S40036', 'V30015', '320002', '1', 2023, 'VP', 4.23, 9.76, 5.65, 6.05 FROM DUAL UNION ALL
	SELECT 'S40040', 'V30015', '320002', '1', 2023, 'VP', 9.32, 5.31, 4.22, 5.97 FROM DUAL UNION ALL
	SELECT 'S10042', 'V30016', '320004', '1', 2023, 'CQ', 7.2, 8.05, 5.33, 6.44 FROM DUAL UNION ALL
	SELECT 'S10101', 'V30016', '320004', '1', 2023, 'CQ', 8.14, 6.58, 5.83, 6.67 FROM DUAL UNION ALL
	SELECT 'S10085', 'V30016', '320004', '1', 2023, 'CQ', 5.48, 5.15, 5.89, 5.62 FROM DUAL UNION ALL
	SELECT 'S10002', 'V30016', '320004', '1', 2023, 'CQ', 7.04, 7.32, 9.34, 8.25 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30016', '320004', '1', 2023, 'CQ', 7.66, 8.2, 4.81, 6.34 FROM DUAL UNION ALL
	SELECT 'S10021', 'V30016', '320004', '1', 2023, 'CQ', 9.08, 6.83, 5.44, 6.81 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30016', '320004', '1', 2023, 'CQ', 5.33, 6.34, 5.68, 5.71 FROM DUAL UNION ALL
	SELECT 'S10003', 'V30016', '320004', '1', 2023, 'CQ', 4.54, 5.86, 7.41, 6.24 FROM DUAL UNION ALL
	SELECT 'S10084', 'V30016', '320004', '1', 2023, 'CQ', 7.94, 6.82, 5.72, 6.61 FROM DUAL UNION ALL
	SELECT 'S10082', 'V30016', '320004', '1', 2023, 'CQ', 6.03, 9.05, 7.51, 7.37 FROM DUAL UNION ALL
	SELECT 'S10061', 'V30016', '320004', '1', 2023, 'CQ', 9.75, 7.58, 8.79, 8.84 FROM DUAL UNION ALL
	SELECT 'S10025', 'V30016', '320004', '1', 2023, 'CQ', 6.94, 4.97, 7.84, 7.0 FROM DUAL UNION ALL
	SELECT 'S10044', 'V30016', '320004', '1', 2023, 'CQ', 7.64, 8.21, 5.48, 6.67 FROM DUAL UNION ALL
	SELECT 'S10063', 'V30018', '330002', '1', 2023, 'CQ', 8.01, 4.11, 9.12, 7.79 FROM DUAL UNION ALL
	SELECT 'S10023', 'V30018', '330002', '1', 2023, 'CQ', 8.06, 4.42, 8.57, 7.59 FROM DUAL UNION ALL
	SELECT 'S10065', 'V30018', '330002', '1', 2023, 'CQ', 4.07, 6.04, 7.87, 6.36 FROM DUAL UNION ALL
	SELECT 'S10001', 'V30018', '330002', '1', 2023, 'CQ', 8.42, 7.19, 7.18, 7.55 FROM DUAL UNION ALL
	SELECT 'S10082', 'V30018', '330002', '1', 2023, 'CQ', 8.18, 4.25, 7.91, 7.26 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30018', '330002', '1', 2023, 'CQ', 4.65, 4.57, 4.95, 4.78 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30018', '330002', '1', 2023, 'CQ', 9.63, 9.17, 6.47, 7.96 FROM DUAL UNION ALL
	SELECT 'S10105', 'V30018', '330002', '1', 2023, 'CQ', 4.07, 5.59, 5.86, 5.27 FROM DUAL UNION ALL
	SELECT 'S10024', 'V30018', '330002', '1', 2023, 'CQ', 7.96, 8.45, 5.54, 6.85 FROM DUAL UNION ALL
	SELECT 'S10085', 'V30018', '330002', '1', 2023, 'CQ', 4.78, 7.23, 7.07, 6.42 FROM DUAL UNION ALL
	SELECT 'S10062', 'V30018', '330002', '1', 2023, 'CQ', 6.36, 8.87, 6.12, 6.74 FROM DUAL UNION ALL
	SELECT 'S10104', 'V30018', '330002', '1', 2023, 'CQ', 6.97, 8.06, 8.87, 8.14 FROM DUAL UNION ALL
	SELECT 'S10041', 'V30018', '330002', '1', 2023, 'CQ', 9.91, 6.01, 5.71, 7.03 FROM DUAL UNION ALL
	SELECT 'S10005', 'V30018', '330002', '1', 2023, 'CQ', 8.45, 7.58, 4.19, 6.15 FROM DUAL UNION ALL
	SELECT 'S10102', 'V30018', '330002', '1', 2023, 'CQ', 5.97, 7.86, 6.06, 6.39 FROM DUAL UNION ALL
	SELECT 'S10043', 'V30018', '330002', '1', 2023, 'CQ', 4.17, 4.01, 9.57, 6.84 FROM DUAL UNION ALL
	SELECT 'S10044', 'V30018', '330002', '1', 2023, 'CQ', 4.42, 7.03, 5.59, 5.53 FROM DUAL UNION ALL
	SELECT 'S10084', 'V30018', '330002', '1', 2023, 'CQ', 7.0, 9.11, 4.82, 6.33 FROM DUAL UNION ALL
	SELECT 'S10061', 'V30018', '330002', '1', 2023, 'CQ', 8.7, 8.8, 5.25, 7.0 FROM DUAL UNION ALL
	SELECT 'S10025', 'V30018', '330002', '1', 2023, 'CQ', 8.1, 6.64, 7.78, 7.65 FROM DUAL UNION ALL
	SELECT 'S10042', 'V30018', '330002', '1', 2023, 'CQ', 6.93, 8.31, 8.63, 8.06 FROM DUAL UNION ALL
	SELECT 'S10022', 'V30018', '330002', '1', 2023, 'CQ', 5.49, 4.91, 8.31, 6.78 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S10045', 'V30066', '330001', '2', 2023, 'CQ', 6.39, 8.89, 5.61, 6.5 FROM DUAL UNION ALL
	SELECT 'S10061', 'V30066', '330001', '2', 2023, 'CQ', 9.98, 7.14, 4.06, 6.45 FROM DUAL UNION ALL
	SELECT 'S10024', 'V30066', '330001', '2', 2023, 'CQ', 9.5, 8.76, 7.76, 8.48 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30066', '330001', '2', 2023, 'CQ', 5.2, 5.42, 6.17, 5.73 FROM DUAL UNION ALL
	SELECT 'S10001', 'V30066', '330001', '2', 2023, 'CQ', 8.73, 7.6, 7.59, 7.93 FROM DUAL UNION ALL
	SELECT 'S10005', 'V30066', '330001', '2', 2023, 'CQ', 7.16, 4.97, 5.65, 5.97 FROM DUAL UNION ALL
	SELECT 'S10043', 'V30066', '330001', '2', 2023, 'CQ', 9.78, 4.59, 4.35, 6.03 FROM DUAL UNION ALL
	SELECT 'S10085', 'V30066', '330001', '2', 2023, 'CQ', 9.89, 4.12, 5.58, 6.58 FROM DUAL UNION ALL
	SELECT 'S10062', 'V30066', '330001', '2', 2023, 'CQ', 8.3, 8.39, 7.38, 7.86 FROM DUAL UNION ALL
	SELECT 'S10103', 'V30066', '330001', '2', 2023, 'CQ', 6.12, 9.81, 4.7, 6.15 FROM DUAL UNION ALL
	SELECT 'S10064', 'V30066', '330001', '2', 2023, 'CQ', 9.63, 7.97, 4.25, 6.61 FROM DUAL UNION ALL
	SELECT 'S10101', 'V30066', '330001', '2', 2023, 'CQ', 5.51, 5.61, 4.37, 4.96 FROM DUAL UNION ALL
	SELECT 'S10004', 'V30066', '330001', '2', 2023, 'CQ', 8.92, 6.1, 8.66, 8.23 FROM DUAL UNION ALL
	SELECT 'S10102', 'V30066', '330001', '2', 2023, 'CQ', 9.7, 9.11, 6.86, 8.16 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30066', '330001', '2', 2023, 'CQ', 7.24, 8.21, 9.86, 8.74 FROM DUAL UNION ALL
	SELECT 'S40118', 'V30068', '320006', '2', 2023, 'VP', 5.76, 6.59, 6.76, 6.43 FROM DUAL UNION ALL
	SELECT 'S40057', 'V30068', '320006', '2', 2023, 'VP', 8.64, 6.52, 8.99, 8.39 FROM DUAL UNION ALL
	SELECT 'S40016', 'V30068', '320006', '2', 2023, 'VP', 7.09, 8.6, 9.81, 8.75 FROM DUAL UNION ALL
	SELECT 'S40080', 'V30068', '320006', '2', 2023, 'VP', 8.67, 6.75, 8.32, 8.11 FROM DUAL UNION ALL
	SELECT 'S40018', 'V30068', '320006', '2', 2023, 'VP', 7.08, 9.31, 9.48, 8.73 FROM DUAL UNION ALL
	SELECT 'S40119', 'V30068', '320006', '2', 2023, 'VP', 7.8, 6.56, 4.83, 6.07 FROM DUAL UNION ALL
	SELECT 'S40098', 'V30068', '320006', '2', 2023, 'VP', 4.61, 7.52, 6.49, 6.13 FROM DUAL UNION ALL
	SELECT 'S40079', 'V30068', '320006', '2', 2023, 'VP', 7.17, 4.18, 6.43, 6.2 FROM DUAL UNION ALL
	SELECT 'S40038', 'V30068', '320006', '2', 2023, 'VP', 4.09, 7.6, 8.43, 6.96 FROM DUAL UNION ALL
	SELECT 'S40017', 'V30068', '320006', '2', 2023, 'VP', 5.77, 9.67, 6.77, 7.05 FROM DUAL UNION ALL
	SELECT 'S40099', 'V30068', '320006', '2', 2023, 'VP', 5.14, 6.4, 4.6, 5.12 FROM DUAL UNION ALL
	SELECT 'S40120', 'V30068', '320006', '2', 2023, 'VP', 9.0, 4.28, 6.14, 6.63 FROM DUAL UNION ALL
	SELECT 'S40117', 'V30068', '320006', '2', 2023, 'VP', 6.68, 9.89, 4.46, 6.21 FROM DUAL UNION ALL
	SELECT 'S40096', 'V30068', '320006', '2', 2023, 'VP', 4.1, 8.5, 6.72, 6.29 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30068', '320006', '2', 2023, 'VP', 4.41, 4.04, 6.21, 5.24 FROM DUAL UNION ALL
	SELECT 'S40100', 'V30068', '320006', '2', 2023, 'VP', 4.05, 6.49, 8.49, 6.76 FROM DUAL UNION ALL
	SELECT 'S40056', 'V30068', '320006', '2', 2023, 'VP', 7.26, 8.75, 5.02, 6.44 FROM DUAL UNION ALL
	SELECT 'S40059', 'V30068', '320006', '2', 2023, 'VP', 7.75, 6.0, 5.36, 6.21 FROM DUAL UNION ALL
	SELECT 'S40060', 'V30068', '320006', '2', 2023, 'VP', 9.48, 7.16, 6.27, 7.41 FROM DUAL UNION ALL
	SELECT 'S40037', 'V30068', '320006', '2', 2023, 'VP', 4.19, 7.15, 5.82, 5.6 FROM DUAL UNION ALL
	SELECT 'S40040', 'V30068', '320006', '2', 2023, 'VP', 4.51, 8.94, 5.19, 5.74 FROM DUAL UNION ALL
	SELECT 'S40097', 'V30068', '320006', '2', 2023, 'VP', 9.69, 5.96, 8.0, 8.1 FROM DUAL UNION ALL
	SELECT 'S40077', 'V30068', '320006', '2', 2023, 'VP', 5.77, 9.62, 9.64, 8.47 FROM DUAL UNION ALL
	SELECT 'S40019', 'V30068', '320006', '2', 2023, 'VP', 8.89, 6.71, 9.39, 8.7 FROM DUAL UNION ALL
	SELECT 'S40036', 'V30068', '320006', '2', 2023, 'VP', 4.92, 4.61, 4.83, 4.81 FROM DUAL UNION ALL
	SELECT 'S40078', 'V30068', '320006', '2', 2023, 'VP', 8.88, 9.08, 9.88, 9.42 FROM DUAL UNION ALL
	SELECT 'S40076', 'V30068', '320006', '2', 2023, 'VP', 4.91, 6.61, 5.5, 5.54 FROM DUAL UNION ALL
	SELECT 'S40039', 'V30068', '320006', '2', 2023, 'VP', 9.89, 5.35, 9.86, 8.97 FROM DUAL UNION ALL
	SELECT 'S40116', 'V30068', '320006', '2', 2023, 'VP', 8.75, 8.67, 4.38, 6.55 FROM DUAL UNION ALL
	SELECT 'S40037', 'V30068', '320007', '2', 2023, 'VP', 5.24, 9.05, 7.24, 7.0 FROM DUAL UNION ALL
	SELECT 'S40018', 'V30068', '320007', '2', 2023, 'VP', 7.94, 6.7, 6.36, 6.9 FROM DUAL UNION ALL
	SELECT 'S40077', 'V30068', '320007', '2', 2023, 'VP', 6.02, 8.8, 4.17, 5.65 FROM DUAL UNION ALL
	SELECT 'S40057', 'V30068', '320007', '2', 2023, 'VP', 6.59, 8.82, 5.94, 6.71 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30068', '320007', '2', 2023, 'VP', 8.09, 9.13, 7.95, 8.23 FROM DUAL UNION ALL
	SELECT 'S40076', 'V30068', '320007', '2', 2023, 'VP', 4.42, 9.97, 7.24, 6.94 FROM DUAL UNION ALL
	SELECT 'S10002', 'V30020', '310002', '2', 2023, 'CQ', 7.9, 8.44, 4.24, 6.18 FROM DUAL UNION ALL
	SELECT 'S10101', 'V30020', '310002', '2', 2023, 'CQ', 9.88, 5.55, 6.15, 7.15 FROM DUAL UNION ALL
	SELECT 'S10104', 'V30020', '310002', '2', 2023, 'CQ', 6.36, 8.81, 8.01, 7.67 FROM DUAL UNION ALL
	SELECT 'S10005', 'V30020', '310002', '2', 2023, 'CQ', 7.75, 8.4, 9.62, 8.81 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30020', '310002', '2', 2023, 'CQ', 6.52, 6.63, 8.55, 7.56 FROM DUAL UNION ALL
	SELECT 'S10024', 'V30020', '310002', '2', 2023, 'CQ', 4.61, 7.13, 7.79, 6.7 FROM DUAL UNION ALL
	SELECT 'S10105', 'V30020', '310002', '2', 2023, 'CQ', 6.62, 8.55, 5.48, 6.44 FROM DUAL UNION ALL
	SELECT 'S10043', 'V30020', '310002', '2', 2023, 'CQ', 9.77, 6.72, 4.67, 6.61 FROM DUAL UNION ALL
	SELECT 'S10004', 'V30020', '310002', '2', 2023, 'CQ', 7.99, 9.94, 6.48, 7.62 FROM DUAL UNION ALL
	SELECT 'S10103', 'V30020', '310002', '2', 2023, 'CQ', 9.06, 9.71, 4.56, 6.94 FROM DUAL UNION ALL
	SELECT 'S10044', 'V30020', '310002', '2', 2023, 'CQ', 8.46, 6.92, 9.11, 8.48 FROM DUAL UNION ALL
	SELECT 'S10065', 'V30020', '310002', '2', 2023, 'CQ', 8.49, 6.88, 6.23, 7.04 FROM DUAL UNION ALL
	SELECT 'S10082', 'V30020', '310002', '2', 2023, 'CQ', 9.56, 5.25, 9.77, 8.8 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30020', '310002', '2', 2023, 'CQ', 5.18, 7.75, 5.8, 6.0 FROM DUAL UNION ALL
	SELECT 'S10021', 'V30020', '310002', '2', 2023, 'CQ', 7.82, 6.02, 4.13, 5.62 FROM DUAL UNION ALL
	SELECT 'S10023', 'V30020', '310002', '2', 2023, 'CQ', 8.58, 8.97, 7.17, 7.95 FROM DUAL UNION ALL
	SELECT 'S10025', 'V30020', '310002', '2', 2023, 'CQ', 6.79, 9.26, 9.19, 8.48 FROM DUAL UNION ALL
	SELECT 'S10001', 'V30020', '310002', '2', 2023, 'CQ', 7.36, 9.54, 4.8, 6.52 FROM DUAL UNION ALL
	SELECT 'S10063', 'V30020', '310002', '2', 2023, 'CQ', 5.69, 4.42, 6.69, 5.94 FROM DUAL UNION ALL
	SELECT 'S10062', 'V30020', '310002', '2', 2023, 'CQ', 9.29, 6.87, 5.41, 6.87 FROM DUAL UNION ALL
	SELECT 'S10061', 'V30020', '310002', '2', 2023, 'CQ', 6.46, 5.18, 8.8, 7.37 FROM DUAL UNION ALL
	SELECT 'S10022', 'V30020', '310002', '2', 2023, 'CQ', 4.6, 5.24, 4.88, 4.87 FROM DUAL UNION ALL
	SELECT 'S10084', 'V30020', '310002', '2', 2023, 'CQ', 4.59, 5.86, 5.32, 5.21 FROM DUAL UNION ALL
	SELECT 'S20070', 'V30018', '320001', '2', 2023, 'CLC', 5.7, 9.21, 6.98, 7.04 FROM DUAL UNION ALL
	SELECT 'S20107', 'V30018', '320001', '2', 2023, 'CLC', 6.9, 9.29, 7.13, 7.49 FROM DUAL UNION ALL
	SELECT 'S20067', 'V30018', '320001', '2', 2023, 'CLC', 8.83, 7.69, 8.99, 8.68 FROM DUAL UNION ALL
	SELECT 'S20026', 'V30018', '320001', '2', 2023, 'CLC', 4.99, 9.27, 9.54, 8.12 FROM DUAL UNION ALL
	SELECT 'S20088', 'V30018', '320001', '2', 2023, 'CLC', 7.0, 6.46, 4.13, 5.46 FROM DUAL UNION ALL
	SELECT 'S20048', 'V30018', '320001', '2', 2023, 'CLC', 7.66, 6.11, 7.46, 7.25 FROM DUAL UNION ALL
	SELECT 'S20090', 'V30018', '320001', '2', 2023, 'CLC', 8.62, 8.58, 8.68, 8.64 FROM DUAL UNION ALL
	SELECT 'S20109', 'V30018', '320001', '2', 2023, 'CLC', 9.99, 8.86, 4.86, 7.2 FROM DUAL UNION ALL
	SELECT 'S20049', 'V30018', '320001', '2', 2023, 'CLC', 6.63, 4.61, 6.86, 6.34 FROM DUAL UNION ALL
	SELECT 'S20010', 'V30018', '320001', '2', 2023, 'CLC', 6.46, 5.76, 7.55, 6.87 FROM DUAL UNION ALL
	SELECT 'S40020', 'V30067', '310005', '2', 2023, 'VP', 8.94, 5.27, 4.83, 6.15 FROM DUAL UNION ALL
	SELECT 'S40058', 'V30067', '310005', '2', 2023, 'VP', 5.27, 6.47, 6.41, 6.08 FROM DUAL UNION ALL
	SELECT 'S40036', 'V30067', '310005', '2', 2023, 'VP', 4.96, 9.19, 6.62, 6.64 FROM DUAL UNION ALL
	SELECT 'S40116', 'V30067', '310005', '2', 2023, 'VP', 4.39, 6.18, 8.08, 6.59 FROM DUAL UNION ALL
	SELECT 'S40037', 'V30067', '310005', '2', 2023, 'VP', 5.39, 8.98, 6.19, 6.51 FROM DUAL UNION ALL
	SELECT 'S40077', 'V30067', '310005', '2', 2023, 'VP', 9.74, 8.06, 8.19, 8.63 FROM DUAL UNION ALL
	SELECT 'S40040', 'V30067', '310005', '2', 2023, 'VP', 7.76, 5.43, 7.99, 7.41 FROM DUAL UNION ALL
	SELECT 'S40100', 'V30067', '310005', '2', 2023, 'VP', 7.27, 7.14, 9.14, 8.18 FROM DUAL UNION ALL
	SELECT 'S40076', 'V30067', '310005', '2', 2023, 'VP', 5.68, 7.94, 4.32, 5.45 FROM DUAL UNION ALL
	SELECT 'S40019', 'V30067', '310005', '2', 2023, 'VP', 8.73, 8.83, 7.37, 8.07 FROM DUAL UNION ALL
	SELECT 'S40039', 'V30067', '310005', '2', 2023, 'VP', 4.78, 5.69, 6.04, 5.59 FROM DUAL UNION ALL
	SELECT 'S40016', 'V30067', '310005', '2', 2023, 'VP', 6.46, 5.4, 5.93, 5.98 FROM DUAL UNION ALL
	SELECT 'S40060', 'V30067', '310005', '2', 2023, 'VP', 5.46, 9.19, 4.66, 5.81 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S20109', 'V30019', '310001', '3', 2023, 'CLC', 5.97, 8.59, 6.47, 6.74 FROM DUAL UNION ALL
	SELECT 'S20070', 'V30019', '310001', '3', 2023, 'CLC', 7.39, 4.59, 4.86, 5.56 FROM DUAL UNION ALL
	SELECT 'S20006', 'V30019', '310001', '3', 2023, 'CLC', 4.82, 6.23, 7.67, 6.53 FROM DUAL UNION ALL
	SELECT 'S20068', 'V30019', '310001', '3', 2023, 'CLC', 6.31, 9.35, 5.61, 6.57 FROM DUAL UNION ALL
	SELECT 'S20066', 'V30019', '310001', '3', 2023, 'CLC', 7.04, 5.24, 5.17, 5.75 FROM DUAL UNION ALL
	SELECT 'S20028', 'V30019', '310001', '3', 2023, 'CLC', 8.65, 8.17, 4.0, 6.23 FROM DUAL UNION ALL
	SELECT 'S20027', 'V30019', '310001', '3', 2023, 'CLC', 5.37, 5.1, 7.41, 6.34 FROM DUAL UNION ALL
	SELECT 'S20046', 'V30019', '310001', '3', 2023, 'CLC', 6.99, 8.61, 4.34, 5.99 FROM DUAL UNION ALL
	SELECT 'S20106', 'V30019', '310001', '3', 2023, 'CLC', 7.98, 7.37, 4.7, 6.22 FROM DUAL UNION ALL
	SELECT 'S20069', 'V30019', '310001', '3', 2023, 'CLC', 8.3, 7.98, 4.42, 6.3 FROM DUAL UNION ALL
	SELECT 'S20010', 'V30019', '310001', '3', 2023, 'CLC', 8.68, 4.61, 4.09, 5.57 FROM DUAL UNION ALL
	SELECT 'S20026', 'V30019', '310001', '3', 2023, 'CLC', 6.42, 8.69, 7.19, 7.26 FROM DUAL UNION ALL
	SELECT 'S20088', 'V30019', '310001', '3', 2023, 'CLC', 9.18, 6.16, 5.68, 6.83 FROM DUAL UNION ALL
	SELECT 'S20050', 'V30019', '310001', '3', 2023, 'CLC', 7.22, 4.78, 9.55, 7.9 FROM DUAL UNION ALL
	SELECT 'S20090', 'V30019', '310001', '3', 2023, 'CLC', 8.0, 5.02, 7.68, 7.24 FROM DUAL UNION ALL
	SELECT 'S20048', 'V30067', '310004', '3', 2023, 'CLC', 8.84, 9.59, 8.7, 8.92 FROM DUAL UNION ALL
	SELECT 'S20107', 'V30067', '310004', '3', 2023, 'CLC', 7.08, 6.33, 5.4, 6.09 FROM DUAL UNION ALL
	SELECT 'S20108', 'V30067', '310004', '3', 2023, 'CLC', 4.5, 9.56, 4.28, 5.4 FROM DUAL UNION ALL
	SELECT 'S20088', 'V30067', '310004', '3', 2023, 'CLC', 7.68, 9.59, 9.4, 8.92 FROM DUAL UNION ALL
	SELECT 'S20028', 'V30067', '310004', '3', 2023, 'CLC', 4.97, 6.29, 9.99, 7.74 FROM DUAL UNION ALL
	SELECT 'S20009', 'V30067', '310004', '3', 2023, 'CLC', 4.5, 8.1, 6.76, 6.35 FROM DUAL UNION ALL
	SELECT 'S20029', 'V30067', '310004', '3', 2023, 'CLC', 6.66, 4.59, 6.11, 5.97 FROM DUAL UNION ALL
	SELECT 'S20027', 'V30067', '310004', '3', 2023, 'CLC', 9.33, 5.99, 8.15, 8.07 FROM DUAL UNION ALL
	SELECT 'S20006', 'V30067', '310004', '3', 2023, 'CLC', 5.36, 9.12, 6.84, 6.85 FROM DUAL UNION ALL
	SELECT 'S20049', 'V30067', '310004', '3', 2023, 'CLC', 8.39, 9.37, 4.47, 6.63 FROM DUAL UNION ALL
	SELECT 'S20087', 'V30067', '310004', '3', 2023, 'CLC', 5.43, 5.42, 4.91, 5.17 FROM DUAL UNION ALL
	SELECT 'S20067', 'V30067', '310004', '3', 2023, 'CLC', 8.94, 4.49, 5.24, 6.2 FROM DUAL UNION ALL
	SELECT 'S20046', 'V30067', '310004', '3', 2023, 'CLC', 8.06, 4.2, 8.27, 7.39 FROM DUAL UNION ALL
	SELECT 'S20068', 'V30067', '310004', '3', 2023, 'CLC', 5.76, 6.16, 8.83, 7.38 FROM DUAL UNION ALL
	SELECT 'S20106', 'V30067', '310004', '3', 2023, 'CLC', 5.02, 4.42, 7.11, 5.95 FROM DUAL UNION ALL
	SELECT 'S20087', 'V30015', '320005', '3', 2023, 'CLC', 9.14, 7.38, 5.36, 6.9 FROM DUAL UNION ALL
	SELECT 'S20109', 'V30015', '320005', '3', 2023, 'CLC', 4.55, 8.86, 6.51, 6.39 FROM DUAL UNION ALL
	SELECT 'S20086', 'V30015', '320005', '3', 2023, 'CLC', 6.45, 8.55, 8.76, 8.03 FROM DUAL UNION ALL
	SELECT 'S20067', 'V30015', '320005', '3', 2023, 'CLC', 9.16, 6.55, 7.24, 7.68 FROM DUAL UNION ALL
	SELECT 'S20007', 'V30015', '320005', '3', 2023, 'CLC', 8.8, 6.29, 7.91, 7.85 FROM DUAL UNION ALL
	SELECT 'S20068', 'V30015', '320005', '3', 2023, 'CLC', 9.4, 6.12, 7.49, 7.79 FROM DUAL UNION ALL
	SELECT 'S20108', 'V30015', '320005', '3', 2023, 'CLC', 8.19, 7.43, 5.83, 6.86 FROM DUAL UNION ALL
	SELECT 'S20028', 'V30015', '320005', '3', 2023, 'CLC', 7.82, 6.06, 4.21, 5.66 FROM DUAL UNION ALL
	SELECT 'S20010', 'V30015', '320005', '3', 2023, 'CLC', 5.45, 7.77, 7.39, 6.88 FROM DUAL UNION ALL
	SELECT 'S20089', 'V30015', '320005', '3', 2023, 'CLC', 5.93, 8.36, 5.15, 6.03 FROM DUAL UNION ALL
	SELECT 'S20088', 'V30015', '320005', '3', 2023, 'CLC', 8.23, 7.28, 6.16, 7.0 FROM DUAL UNION ALL
	SELECT 'S20030', 'V30015', '320005', '3', 2023, 'CLC', 7.45, 5.82, 8.38, 7.59 FROM DUAL UNION ALL
	SELECT 'S20107', 'V30015', '320005', '3', 2023, 'CLC', 6.96, 4.32, 9.3, 7.6 FROM DUAL UNION ALL
	SELECT 'S20049', 'V30015', '320005', '3', 2023, 'CLC', 9.28, 8.59, 8.7, 8.85 FROM DUAL UNION ALL
	SELECT 'S20046', 'V30015', '320005', '3', 2023, 'CLC', 9.91, 7.9, 4.18, 6.64 FROM DUAL UNION ALL
	SELECT 'S20006', 'V30015', '320005', '3', 2023, 'CLC', 6.05, 9.13, 8.29, 7.79 FROM DUAL UNION ALL
	SELECT 'S20026', 'V30015', '320005', '3', 2023, 'CLC', 6.94, 9.11, 4.38, 6.09 FROM DUAL UNION ALL
	SELECT 'S20008', 'V30015', '320005', '3', 2023, 'CLC', 4.44, 4.54, 5.06, 4.77 FROM DUAL UNION ALL
	SELECT 'S20047', 'V30015', '320005', '3', 2023, 'CLC', 8.16, 7.7, 8.48, 8.23 FROM DUAL UNION ALL
	SELECT 'S20069', 'V30015', '320005', '3', 2023, 'CLC', 6.53, 9.66, 8.12, 7.95 FROM DUAL UNION ALL
	SELECT 'S20066', 'V30015', '320005', '3', 2023, 'CLC', 6.38, 6.79, 8.94, 7.74 FROM DUAL UNION ALL
	SELECT 'S20110', 'V30015', '320005', '3', 2023, 'CLC', 9.87, 6.7, 5.99, 7.3 FROM DUAL UNION ALL
	SELECT 'S20027', 'V30015', '320005', '3', 2023, 'CLC', 8.06, 4.35, 7.39, 6.98 FROM DUAL UNION ALL
	SELECT 'S20106', 'V30015', '320005', '3', 2023, 'CLC', 6.98, 8.85, 5.77, 6.75 FROM DUAL UNION ALL
	SELECT 'S20009', 'V30015', '320005', '3', 2023, 'CLC', 7.46, 8.02, 7.91, 7.8 FROM DUAL UNION ALL
	SELECT 'S20029', 'V30015', '320005', '3', 2023, 'CLC', 9.53, 8.29, 9.66, 9.35 FROM DUAL UNION ALL
	SELECT 'S30015', 'V30020', '310008', '3', 2023, 'CTTT', 9.74, 8.82, 5.2, 7.29 FROM DUAL UNION ALL
	SELECT 'S30033', 'V30020', '310008', '3', 2023, 'CTTT', 8.58, 7.46, 8.9, 8.52 FROM DUAL UNION ALL
	SELECT 'S30072', 'V30020', '310008', '3', 2023, 'CTTT', 4.35, 6.41, 4.07, 4.62 FROM DUAL UNION ALL
	SELECT 'S30013', 'V30020', '310008', '3', 2023, 'CTTT', 4.23, 6.83, 9.1, 7.19 FROM DUAL UNION ALL
	SELECT 'S30092', 'V30020', '310008', '3', 2023, 'CTTT', 9.78, 4.43, 5.0, 6.32 FROM DUAL UNION ALL
	SELECT 'S30093', 'V30020', '310008', '3', 2023, 'CTTT', 5.79, 8.16, 5.69, 6.21 FROM DUAL UNION ALL
	SELECT 'S30073', 'V30020', '310008', '3', 2023, 'CTTT', 4.01, 9.77, 7.74, 7.03 FROM DUAL UNION ALL
	SELECT 'S30014', 'V30020', '310008', '3', 2023, 'CTTT', 4.55, 5.66, 8.97, 6.98 FROM DUAL UNION ALL
	SELECT 'S30051', 'V30020', '310008', '3', 2023, 'CTTT', 4.89, 6.61, 6.37, 5.97 FROM DUAL UNION ALL
	SELECT 'S30075', 'V30020', '310008', '3', 2023, 'CTTT', 4.44, 6.64, 4.09, 4.71 FROM DUAL UNION ALL
	SELECT 'S30053', 'V30020', '310008', '3', 2023, 'CTTT', 8.7, 5.03, 9.91, 8.57 FROM DUAL UNION ALL
	SELECT 'S30052', 'V30020', '310008', '3', 2023, 'CTTT', 7.01, 9.6, 8.79, 8.42 FROM DUAL UNION ALL
	SELECT 'S30034', 'V30020', '310008', '3', 2023, 'CTTT', 5.5, 7.01, 5.3, 5.7 FROM DUAL UNION ALL
	SELECT 'S30054', 'V30020', '310008', '3', 2023, 'CTTT', 6.06, 5.01, 5.22, 5.43 FROM DUAL UNION ALL
	SELECT 'S30012', 'V30020', '310008', '3', 2023, 'CTTT', 5.53, 8.49, 5.03, 5.87 FROM DUAL UNION ALL
	SELECT 'S30111', 'V30020', '310008', '3', 2023, 'CTTT', 4.29, 6.65, 6.46, 5.85 FROM DUAL UNION ALL
	SELECT 'S30032', 'V30020', '310008', '3', 2023, 'CTTT', 6.48, 5.0, 6.14, 6.01 FROM DUAL UNION ALL
	SELECT 'S10085', 'V30011', '310007', '3', 2023, 'CQ', 6.27, 9.37, 4.87, 6.19 FROM DUAL UNION ALL
	SELECT 'S10023', 'V30011', '310007', '3', 2023, 'CQ', 6.83, 6.73, 7.63, 7.21 FROM DUAL UNION ALL
	SELECT 'S10104', 'V30011', '310007', '3', 2023, 'CQ', 4.61, 6.71, 6.16, 5.8 FROM DUAL UNION ALL
	SELECT 'S10105', 'V30011', '310007', '3', 2023, 'CQ', 9.17, 9.52, 8.64, 8.97 FROM DUAL UNION ALL
	SELECT 'S10064', 'V30011', '310007', '3', 2023, 'CQ', 4.73, 9.51, 7.0, 6.82 FROM DUAL UNION ALL
	SELECT 'S10102', 'V30011', '310007', '3', 2023, 'CQ', 8.32, 6.71, 9.21, 8.44 FROM DUAL UNION ALL
	SELECT 'S10022', 'V30011', '310007', '3', 2023, 'CQ', 6.12, 6.86, 8.22, 7.32 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30011', '310007', '3', 2023, 'CQ', 6.59, 6.78, 4.46, 5.56 FROM DUAL UNION ALL
	SELECT 'S10045', 'V30011', '310007', '3', 2023, 'CQ', 7.83, 8.76, 9.9, 9.05 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30011', '310007', '3', 2023, 'CQ', 5.13, 5.74, 7.07, 6.22 FROM DUAL UNION ALL
	SELECT 'S10002', 'V30011', '310007', '3', 2023, 'CQ', 8.1, 6.99, 6.76, 7.21 FROM DUAL UNION ALL
	SELECT 'S10061', 'V30011', '310007', '3', 2023, 'CQ', 7.66, 7.94, 7.75, 7.76 FROM DUAL UNION ALL
	SELECT 'S10063', 'V30011', '310007', '3', 2023, 'CQ', 7.16, 5.35, 5.34, 5.89 FROM DUAL UNION ALL
	SELECT 'S10024', 'V30011', '310007', '3', 2023, 'CQ', 6.54, 5.52, 9.2, 7.67 FROM DUAL UNION ALL
	SELECT 'S10003', 'V30011', '310007', '3', 2023, 'CQ', 4.5, 6.09, 6.01, 5.57 FROM DUAL UNION ALL
	SELECT 'S10084', 'V30011', '310007', '3', 2023, 'CQ', 9.6, 4.32, 5.97, 6.73 FROM DUAL UNION ALL
	SELECT 'S10082', 'V30011', '310007', '3', 2023, 'CQ', 8.61, 8.87, 5.68, 7.2 FROM DUAL UNION ALL
	SELECT 'S10043', 'V30011', '310007', '3', 2023, 'CQ', 6.59, 5.79, 5.23, 5.75 FROM DUAL UNION ALL
	SELECT 'S10005', 'V30011', '310007', '3', 2023, 'CQ', 6.71, 7.38, 4.54, 5.76 FROM DUAL UNION ALL
	SELECT 'S10004', 'V30011', '310007', '3', 2023, 'CQ', 8.6, 4.17, 7.65, 7.24 FROM DUAL UNION ALL
	SELECT 'S10041', 'V30011', '310007', '3', 2023, 'CQ', 5.98, 6.43, 6.19, 6.18 FROM DUAL UNION ALL
	SELECT 'S10042', 'V30011', '310007', '3', 2023, 'CQ', 7.39, 4.73, 7.44, 6.88 FROM DUAL UNION ALL
	SELECT 'S10024', 'V30067', '310009', '3', 2023, 'CQ', 9.2, 4.03, 5.82, 6.48 FROM DUAL UNION ALL
	SELECT 'S10005', 'V30067', '310009', '3', 2023, 'CQ', 5.96, 4.1, 7.62, 6.42 FROM DUAL UNION ALL
	SELECT 'S10083', 'V30067', '310009', '3', 2023, 'CQ', 8.51, 8.03, 6.25, 7.28 FROM DUAL UNION ALL
	SELECT 'S10105', 'V30067', '310009', '3', 2023, 'CQ', 8.18, 9.7, 9.63, 9.21 FROM DUAL UNION ALL
	SELECT 'S10045', 'V30067', '310009', '3', 2023, 'CQ', 5.71, 6.15, 5.7, 5.79 FROM DUAL UNION ALL
	SELECT 'S10043', 'V30067', '310009', '3', 2023, 'CQ', 6.98, 8.71, 6.75, 7.21 FROM DUAL UNION ALL
	SELECT 'S10084', 'V30067', '310009', '3', 2023, 'CQ', 9.75, 4.84, 6.77, 7.28 FROM DUAL UNION ALL
	SELECT 'S10103', 'V30067', '310009', '3', 2023, 'CQ', 4.38, 4.98, 7.53, 6.08 FROM DUAL UNION ALL
	SELECT 'S10102', 'V30067', '310009', '3', 2023, 'CQ', 5.95, 9.76, 5.75, 6.61 FROM DUAL UNION ALL
	SELECT 'S10022', 'V30067', '310009', '3', 2023, 'CQ', 6.44, 8.8, 8.8, 8.09 FROM DUAL UNION ALL
	SELECT 'S10064', 'V30067', '310009', '3', 2023, 'CQ', 6.45, 7.88, 5.75, 6.39 FROM DUAL UNION ALL
	SELECT 'S10042', 'V30067', '310009', '3', 2023, 'CQ', 6.43, 6.43, 9.13, 7.78 FROM DUAL UNION ALL
	SELECT 'S10081', 'V30067', '310009', '3', 2023, 'CQ', 5.0, 9.39, 9.3, 8.03 FROM DUAL UNION ALL
	SELECT 'S10063', 'V30067', '310009', '3', 2023, 'CQ', 7.15, 7.5, 9.92, 8.61 FROM DUAL UNION ALL
	SELECT 'S10003', 'V30067', '310009', '3', 2023, 'CQ', 4.84, 6.28, 8.62, 7.02 FROM DUAL UNION ALL
	SELECT 'S10101', 'V30067', '310009', '3', 2023, 'CQ', 8.32, 7.93, 7.18, 7.67 FROM DUAL UNION ALL
	SELECT 'S10085', 'V30067', '310009', '3', 2023, 'CQ', 5.2, 8.32, 6.72, 6.58 FROM DUAL UNION ALL
	SELECT 'S10025', 'V30067', '310009', '3', 2023, 'CQ', 9.9, 7.42, 9.15, 9.03 FROM DUAL UNION ALL
	SELECT 'S10044', 'V30067', '310009', '3', 2023, 'CQ', 5.96, 8.99, 8.47, 7.82 FROM DUAL UNION ALL
	SELECT 'S10041', 'V30067', '310009', '3', 2023, 'CQ', 6.95, 4.11, 7.39, 6.6 FROM DUAL UNION ALL
	SELECT 'S10002', 'V30067', '310009', '3', 2023, 'CQ', 7.06, 7.71, 5.71, 6.52 FROM DUAL UNION ALL
	SELECT 'S10104', 'V30067', '310009', '3', 2023, 'CQ', 6.54, 9.47, 6.64, 7.18 FROM DUAL UNION ALL
	SELECT 'S10021', 'V30067', '310009', '3', 2023, 'CQ', 8.3, 4.73, 9.67, 8.27 FROM DUAL UNION ALL
	SELECT 'S10004', 'V30067', '310009', '3', 2023, 'CQ', 8.48, 4.06, 9.9, 8.31 FROM DUAL;
INSERT INTO DANGKY
--4. BO MON KHMT
--	2023 - HOC KY 1
	SELECT 'S10082', 'V40030', '430003', '1', 2023, 'CQ', 9.03, 6.74, 8.94, 8.53 FROM DUAL UNION ALL
	SELECT 'S10044', 'V40030', '430003', '1', 2023, 'CQ', 4.16, 9.26, 6.87, 6.54 FROM DUAL UNION ALL
	SELECT 'S10025', 'V40030', '430003', '1', 2023, 'CQ', 5.37, 7.97, 6.16, 6.29 FROM DUAL UNION ALL
	SELECT 'S10003', 'V40030', '430003', '1', 2023, 'CQ', 9.49, 9.85, 4.62, 7.13 FROM DUAL UNION ALL
	SELECT 'S10065', 'V40030', '430003', '1', 2023, 'CQ', 8.21, 7.99, 5.72, 6.92 FROM DUAL UNION ALL
	SELECT 'S10081', 'V40030', '430003', '1', 2023, 'CQ', 6.49, 5.16, 6.63, 6.29 FROM DUAL UNION ALL
	SELECT 'S10041', 'V40030', '430003', '1', 2023, 'CQ', 9.4, 9.01, 8.8, 9.02 FROM DUAL UNION ALL
	SELECT 'S10104', 'V40030', '430003', '1', 2023, 'CQ', 5.08, 9.01, 6.61, 6.63 FROM DUAL UNION ALL
	SELECT 'S10001', 'V40030', '430003', '1', 2023, 'CQ', 7.66, 9.67, 7.03, 7.75 FROM DUAL UNION ALL
	SELECT 'S10042', 'V40030', '430003', '1', 2023, 'CQ', 8.86, 4.37, 4.37, 5.72 FROM DUAL UNION ALL
	SELECT 'S10084', 'V40030', '430003', '1', 2023, 'CQ', 7.38, 9.69, 6.49, 7.4 FROM DUAL UNION ALL
	SELECT 'S10043', 'V40030', '430003', '1', 2023, 'CQ', 9.17, 5.6, 7.15, 7.45 FROM DUAL UNION ALL
	SELECT 'S10022', 'V40030', '430003', '1', 2023, 'CQ', 6.44, 4.31, 8.93, 7.26 FROM DUAL UNION ALL
	SELECT 'S10024', 'V40030', '430003', '1', 2023, 'CQ', 4.14, 10.0, 9.13, 7.81 FROM DUAL UNION ALL
	SELECT 'S10005', 'V40030', '430003', '1', 2023, 'CQ', 9.74, 4.34, 8.75, 8.16 FROM DUAL UNION ALL
	SELECT 'S10002', 'V40030', '430003', '1', 2023, 'CQ', 6.57, 5.19, 7.99, 7.0 FROM DUAL UNION ALL
	SELECT 'S10004', 'V40030', '430003', '1', 2023, 'CQ', 4.84, 8.8, 9.83, 8.13 FROM DUAL UNION ALL
	SELECT 'S10021', 'V40030', '430003', '1', 2023, 'CQ', 4.2, 6.42, 4.29, 4.69 FROM DUAL UNION ALL
	SELECT 'S30015', 'V40026', '430004', '1', 2023, 'CTTT', 7.17, 5.55, 4.91, 5.72 FROM DUAL UNION ALL
	SELECT 'S30035', 'V40026', '430004', '1', 2023, 'CTTT', 9.4, 6.33, 7.32, 7.75 FROM DUAL UNION ALL
	SELECT 'S30093', 'V40026', '430004', '1', 2023, 'CTTT', 9.16, 5.43, 8.51, 8.09 FROM DUAL UNION ALL
	SELECT 'S30094', 'V40026', '430004', '1', 2023, 'CTTT', 8.94, 4.98, 8.97, 8.16 FROM DUAL UNION ALL
	SELECT 'S30115', 'V40026', '430004', '1', 2023, 'CTTT', 5.22, 9.86, 8.39, 7.73 FROM DUAL UNION ALL
	SELECT 'S30013', 'V40026', '430004', '1', 2023, 'CTTT', 6.91, 7.87, 7.45, 7.37 FROM DUAL UNION ALL
	SELECT 'S30051', 'V40026', '430004', '1', 2023, 'CTTT', 5.82, 5.46, 9.06, 7.37 FROM DUAL UNION ALL
	SELECT 'S30075', 'V40026', '430004', '1', 2023, 'CTTT', 8.02, 8.31, 6.12, 7.13 FROM DUAL UNION ALL
	SELECT 'S30111', 'V40026', '430004', '1', 2023, 'CTTT', 5.26, 6.54, 8.58, 7.18 FROM DUAL UNION ALL
	SELECT 'S30032', 'V40026', '430004', '1', 2023, 'CTTT', 7.32, 9.19, 7.41, 7.74 FROM DUAL UNION ALL
	SELECT 'S30114', 'V40026', '430004', '1', 2023, 'CTTT', 4.46, 7.81, 7.51, 6.65 FROM DUAL UNION ALL
	SELECT 'S30092', 'V40026', '430004', '1', 2023, 'CTTT', 4.33, 5.73, 7.7, 6.29 FROM DUAL UNION ALL
	SELECT 'S30074', 'V40026', '430004', '1', 2023, 'CTTT', 6.75, 8.35, 5.2, 6.29 FROM DUAL UNION ALL
	SELECT 'S30055', 'V40026', '430004', '1', 2023, 'CTTT', 7.23, 6.96, 4.81, 5.97 FROM DUAL UNION ALL
	SELECT 'S30033', 'V40026', '430004', '1', 2023, 'CTTT', 8.64, 4.67, 5.7, 6.38 FROM DUAL UNION ALL
	SELECT 'S30052', 'V40026', '430004', '1', 2023, 'CTTT', 9.94, 6.43, 4.28, 6.41 FROM DUAL UNION ALL
	SELECT 'S10021', 'V40028', '410001', '1', 2023, 'CQ', 8.2, 8.46, 9.41, 8.86 FROM DUAL UNION ALL
	SELECT 'S10001', 'V40028', '410001', '1', 2023, 'CQ', 5.15, 7.08, 5.35, 5.64 FROM DUAL UNION ALL
	SELECT 'S10023', 'V40028', '410001', '1', 2023, 'CQ', 9.46, 7.66, 6.11, 7.43 FROM DUAL UNION ALL
	SELECT 'S10045', 'V40028', '410001', '1', 2023, 'CQ', 4.63, 6.14, 9.14, 7.19 FROM DUAL UNION ALL
	SELECT 'S10002', 'V40028', '410001', '1', 2023, 'CQ', 4.14, 6.54, 4.0, 4.55 FROM DUAL UNION ALL
	SELECT 'S10004', 'V40021', '430002', '1', 2023, 'CQ', 5.39, 7.28, 8.92, 7.53 FROM DUAL UNION ALL
	SELECT 'S10022', 'V40021', '430002', '1', 2023, 'CQ', 8.74, 5.17, 4.45, 5.88 FROM DUAL UNION ALL
	SELECT 'S10023', 'V40021', '430002', '1', 2023, 'CQ', 5.63, 6.04, 5.57, 5.68 FROM DUAL UNION ALL
	SELECT 'S10103', 'V40021', '430002', '1', 2023, 'CQ', 4.31, 6.14, 9.83, 7.44 FROM DUAL UNION ALL
	SELECT 'S10062', 'V40021', '430002', '1', 2023, 'CQ', 9.36, 7.39, 7.7, 8.14 FROM DUAL UNION ALL
	SELECT 'S10043', 'V40021', '430002', '1', 2023, 'CQ', 7.21, 9.21, 4.55, 6.28 FROM DUAL UNION ALL
	SELECT 'S10083', 'V40021', '430002', '1', 2023, 'CQ', 6.98, 7.0, 6.85, 6.92 FROM DUAL UNION ALL
	SELECT 'S10061', 'V40021', '430002', '1', 2023, 'CQ', 5.37, 8.79, 4.74, 5.74 FROM DUAL UNION ALL
	SELECT 'S10081', 'V40021', '430002', '1', 2023, 'CQ', 9.39, 8.59, 7.55, 8.31 FROM DUAL UNION ALL
	SELECT 'S10102', 'V40021', '430002', '1', 2023, 'CQ', 4.05, 6.73, 6.2, 5.66 FROM DUAL UNION ALL
	SELECT 'S10001', 'V40021', '430002', '1', 2023, 'CQ', 7.63, 7.85, 7.15, 7.43 FROM DUAL UNION ALL
	SELECT 'S10044', 'V40021', '430002', '1', 2023, 'CQ', 6.64, 6.14, 4.65, 5.54 FROM DUAL UNION ALL
	SELECT 'S10003', 'V40021', '430002', '1', 2023, 'CQ', 5.74, 9.75, 4.17, 5.76 FROM DUAL UNION ALL
	SELECT 'S10045', 'V40075', '420011', '1', 2023, 'CQ', 9.97, 7.38, 7.8, 8.37 FROM DUAL UNION ALL
	SELECT 'S10003', 'V40075', '420011', '1', 2023, 'CQ', 8.34, 8.0, 5.85, 7.03 FROM DUAL UNION ALL
	SELECT 'S10001', 'V40075', '420011', '1', 2023, 'CQ', 5.86, 7.77, 4.05, 5.34 FROM DUAL UNION ALL
	SELECT 'S10041', 'V40075', '420011', '1', 2023, 'CQ', 7.51, 4.6, 8.53, 7.44 FROM DUAL UNION ALL
	SELECT 'S10005', 'V40075', '420011', '1', 2023, 'CQ', 8.95, 6.35, 4.47, 6.19 FROM DUAL UNION ALL
	SELECT 'S10025', 'V40075', '420011', '1', 2023, 'CQ', 9.68, 8.94, 8.95, 9.17 FROM DUAL UNION ALL
	SELECT 'S10021', 'V40075', '420011', '1', 2023, 'CQ', 7.16, 6.5, 9.21, 8.05 FROM DUAL UNION ALL
	SELECT 'S10082', 'V40075', '420011', '1', 2023, 'CQ', 7.09, 7.3, 8.84, 8.01 FROM DUAL UNION ALL
	SELECT 'S10105', 'V40075', '420011', '1', 2023, 'CQ', 7.24, 5.27, 8.66, 7.56 FROM DUAL UNION ALL
	SELECT 'S10043', 'V40075', '420011', '1', 2023, 'CQ', 7.94, 7.52, 4.34, 6.06 FROM DUAL UNION ALL
	SELECT 'S10102', 'V40075', '420011', '1', 2023, 'CQ', 4.5, 5.51, 5.8, 5.35 FROM DUAL UNION ALL
	SELECT 'S10081', 'V40075', '420011', '1', 2023, 'CQ', 6.82, 6.01, 8.18, 7.34 FROM DUAL UNION ALL
	SELECT 'S10104', 'V40075', '420011', '1', 2023, 'CQ', 4.89, 8.84, 6.31, 6.39 FROM DUAL UNION ALL
	SELECT 'S10024', 'V40075', '420011', '1', 2023, 'CQ', 9.03, 7.89, 5.67, 7.12 FROM DUAL UNION ALL
	SELECT 'S10063', 'V40075', '420011', '1', 2023, 'CQ', 8.51, 9.06, 7.36, 8.04 FROM DUAL UNION ALL
	SELECT 'S10042', 'V40075', '420011', '1', 2023, 'CQ', 6.55, 4.53, 9.48, 7.61 FROM DUAL UNION ALL
	SELECT 'S10083', 'V40075', '420011', '1', 2023, 'CQ', 6.65, 4.05, 8.04, 6.82 FROM DUAL UNION ALL
	SELECT 'S10023', 'V40075', '420011', '1', 2023, 'CQ', 4.39, 7.16, 7.62, 6.56 FROM DUAL UNION ALL
	SELECT 'S20007', 'V40022', '430001', '1', 2023, 'CLC', 8.04, 7.05, 6.46, 7.05 FROM DUAL UNION ALL
	SELECT 'S20008', 'V40022', '430001', '1', 2023, 'CLC', 4.24, 9.4, 4.36, 5.33 FROM DUAL UNION ALL
	SELECT 'S20069', 'V40022', '430001', '1', 2023, 'CLC', 8.24, 9.35, 7.42, 8.05 FROM DUAL UNION ALL
	SELECT 'S20086', 'V40022', '430001', '1', 2023, 'CLC', 7.88, 5.59, 6.51, 6.74 FROM DUAL UNION ALL
	SELECT 'S20048', 'V40022', '430001', '1', 2023, 'CLC', 8.25, 4.29, 8.92, 7.79 FROM DUAL UNION ALL
	SELECT 'S20046', 'V40022', '430001', '1', 2023, 'CLC', 7.89, 8.14, 8.15, 8.07 FROM DUAL UNION ALL
	SELECT 'S20049', 'V40022', '430001', '1', 2023, 'CLC', 5.74, 4.08, 4.83, 4.95 FROM DUAL UNION ALL
	SELECT 'S20068', 'V40022', '430001', '1', 2023, 'CLC', 5.36, 5.55, 4.56, 5.0 FROM DUAL UNION ALL
	SELECT 'S20089', 'V40022', '430001', '1', 2023, 'CLC', 7.55, 6.29, 7.65, 7.35 FROM DUAL UNION ALL
	SELECT 'S20107', 'V40022', '430001', '1', 2023, 'CLC', 9.09, 8.49, 5.19, 7.02 FROM DUAL UNION ALL
	SELECT 'S20109', 'V40022', '430001', '1', 2023, 'CLC', 9.17, 4.89, 4.56, 6.01 FROM DUAL UNION ALL
	SELECT 'S20027', 'V40022', '430001', '1', 2023, 'CLC', 5.78, 8.04, 5.93, 6.31 FROM DUAL UNION ALL
	SELECT 'S20070', 'V40022', '430001', '1', 2023, 'CLC', 8.42, 4.75, 4.6, 5.78 FROM DUAL UNION ALL
	SELECT 'S20026', 'V40022', '430001', '1', 2023, 'CLC', 8.51, 4.71, 6.67, 6.83 FROM DUAL UNION ALL
	SELECT 'S20108', 'V40022', '430001', '1', 2023, 'CLC', 4.74, 4.94, 9.44, 7.13 FROM DUAL UNION ALL
	SELECT 'S20047', 'V40022', '430001', '1', 2023, 'CLC', 4.72, 5.72, 5.25, 5.18 FROM DUAL UNION ALL
	SELECT 'S20010', 'V40022', '430001', '1', 2023, 'CLC', 6.06, 6.51, 4.43, 5.33 FROM DUAL UNION ALL
	SELECT 'S20009', 'V40022', '430001', '1', 2023, 'CLC', 4.56, 8.87, 7.3, 6.79 FROM DUAL UNION ALL
	SELECT 'S20088', 'V40022', '430001', '1', 2023, 'CLC', 4.67, 9.19, 8.77, 7.62 FROM DUAL UNION ALL
	SELECT 'S20006', 'V40022', '430001', '1', 2023, 'CLC', 4.55, 4.82, 9.65, 7.15 FROM DUAL UNION ALL
	SELECT 'S20106', 'V40022', '430001', '1', 2023, 'CLC', 4.7, 9.24, 8.53, 7.52 FROM DUAL UNION ALL
	SELECT 'S20090', 'V40022', '430001', '1', 2023, 'CLC', 9.04, 6.14, 5.66, 6.77 FROM DUAL UNION ALL
	SELECT 'S20067', 'V40022', '430001', '1', 2023, 'CLC', 5.71, 9.03, 7.13, 7.08 FROM DUAL UNION ALL
	SELECT 'S20110', 'V40022', '430001', '1', 2023, 'CLC', 9.26, 9.2, 6.07, 7.65 FROM DUAL UNION ALL
	SELECT 'S20066', 'V40022', '430001', '1', 2023, 'CLC', 9.37, 6.14, 5.86, 6.97 FROM DUAL UNION ALL
	SELECT 'S20087', 'V40022', '430001', '1', 2023, 'CLC', 5.63, 9.76, 5.1, 6.19 FROM DUAL UNION ALL
	SELECT 'S20030', 'V40022', '430001', '1', 2023, 'CLC', 9.6, 4.0, 4.57, 5.96 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S40039', 'V40023', '420002', '2', 2023, 'VP', 7.2, 8.43, 7.2, 7.45 FROM DUAL UNION ALL
	SELECT 'S40097', 'V40023', '420002', '2', 2023, 'VP', 4.99, 9.61, 9.49, 8.16 FROM DUAL UNION ALL
	SELECT 'S40099', 'V40023', '420002', '2', 2023, 'VP', 5.92, 5.68, 4.25, 5.04 FROM DUAL UNION ALL
	SELECT 'S40120', 'V40023', '420002', '2', 2023, 'VP', 9.23, 5.48, 9.97, 8.85 FROM DUAL UNION ALL
	SELECT 'S40018', 'V40023', '420002', '2', 2023, 'VP', 4.39, 4.73, 4.18, 4.35 FROM DUAL UNION ALL
	SELECT 'S40017', 'V40023', '420002', '2', 2023, 'VP', 4.19, 5.84, 9.89, 7.37 FROM DUAL UNION ALL
	SELECT 'S40119', 'V40023', '420002', '2', 2023, 'VP', 5.41, 7.26, 4.02, 5.08 FROM DUAL UNION ALL
	SELECT 'S40100', 'V40023', '420002', '2', 2023, 'VP', 8.71, 4.01, 7.73, 7.28 FROM DUAL UNION ALL
	SELECT 'S40037', 'V40023', '420002', '2', 2023, 'VP', 6.05, 6.39, 5.45, 5.82 FROM DUAL UNION ALL
	SELECT 'S40040', 'V40023', '420002', '2', 2023, 'VP', 6.25, 4.62, 9.87, 7.73 FROM DUAL UNION ALL
	SELECT 'S40019', 'V40023', '420002', '2', 2023, 'VP', 4.37, 6.03, 8.63, 6.83 FROM DUAL UNION ALL
	SELECT 'S40060', 'V40023', '420002', '2', 2023, 'VP', 7.59, 5.13, 9.62, 8.11 FROM DUAL UNION ALL
	SELECT 'S40076', 'V40023', '420002', '2', 2023, 'VP', 8.08, 8.07, 4.5, 6.29 FROM DUAL UNION ALL
	SELECT 'S40059', 'V40023', '420002', '2', 2023, 'VP', 5.02, 4.88, 4.03, 4.5 FROM DUAL UNION ALL
	SELECT 'S10042', 'V40026', '420007', '2', 2023, 'CQ', 8.84, 8.6, 6.76, 7.75 FROM DUAL UNION ALL
	SELECT 'S10065', 'V40026', '420007', '2', 2023, 'CQ', 8.74, 9.15, 6.79, 7.85 FROM DUAL UNION ALL
	SELECT 'S10101', 'V40026', '420007', '2', 2023, 'CQ', 6.99, 9.61, 6.63, 7.33 FROM DUAL UNION ALL
	SELECT 'S10083', 'V40026', '420007', '2', 2023, 'CQ', 5.88, 7.4, 6.62, 6.55 FROM DUAL UNION ALL
	SELECT 'S10103', 'V40026', '420007', '2', 2023, 'CQ', 7.48, 5.06, 8.97, 7.74 FROM DUAL UNION ALL
	SELECT 'S10061', 'V40026', '420007', '2', 2023, 'CQ', 8.58, 5.36, 5.59, 6.44 FROM DUAL UNION ALL
	SELECT 'S10082', 'V40026', '420007', '2', 2023, 'CQ', 7.78, 4.37, 8.96, 7.69 FROM DUAL UNION ALL
	SELECT 'S10022', 'V40026', '420007', '2', 2023, 'CQ', 4.69, 6.07, 5.22, 5.23 FROM DUAL UNION ALL
	SELECT 'S10024', 'V40026', '420007', '2', 2023, 'CQ', 6.72, 9.42, 9.07, 8.44 FROM DUAL UNION ALL
	SELECT 'S10081', 'V40026', '420007', '2', 2023, 'CQ', 9.44, 7.79, 5.45, 7.12 FROM DUAL UNION ALL
	SELECT 'S10105', 'V40026', '420007', '2', 2023, 'CQ', 5.72, 9.89, 8.79, 8.09 FROM DUAL UNION ALL
	SELECT 'S10004', 'V40026', '420007', '2', 2023, 'CQ', 7.64, 4.82, 6.08, 6.3 FROM DUAL UNION ALL
	SELECT 'S10041', 'V40026', '420007', '2', 2023, 'CQ', 9.26, 8.65, 6.23, 7.62 FROM DUAL UNION ALL
	SELECT 'S10084', 'V40026', '420007', '2', 2023, 'CQ', 5.13, 9.62, 9.11, 8.02 FROM DUAL UNION ALL
	SELECT 'S10085', 'V40026', '420007', '2', 2023, 'CQ', 8.3, 7.0, 4.83, 6.31 FROM DUAL UNION ALL
	SELECT 'S40079', 'V40027', '410004', '2', 2023, 'VP', 6.97, 9.88, 9.87, 9.0 FROM DUAL UNION ALL
	SELECT 'S40056', 'V40027', '410004', '2', 2023, 'VP', 6.3, 6.5, 4.68, 5.53 FROM DUAL UNION ALL
	SELECT 'S40038', 'V40027', '410004', '2', 2023, 'VP', 4.28, 5.41, 9.01, 6.87 FROM DUAL UNION ALL
	SELECT 'S40078', 'V40027', '410004', '2', 2023, 'VP', 4.14, 6.22, 6.71, 5.84 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40027', '410004', '2', 2023, 'VP', 6.64, 8.68, 8.34, 7.9 FROM DUAL UNION ALL
	SELECT 'S40037', 'V40074', '420009', '2', 2023, 'VP', 9.3, 9.27, 5.12, 7.2 FROM DUAL UNION ALL
	SELECT 'S40018', 'V40074', '420009', '2', 2023, 'VP', 5.39, 8.04, 7.15, 6.8 FROM DUAL UNION ALL
	SELECT 'S40038', 'V40074', '420009', '2', 2023, 'VP', 4.87, 8.47, 8.18, 7.25 FROM DUAL UNION ALL
	SELECT 'S40119', 'V40074', '420009', '2', 2023, 'VP', 8.16, 7.05, 6.56, 7.14 FROM DUAL UNION ALL
	SELECT 'S40059', 'V40074', '420009', '2', 2023, 'VP', 8.91, 6.27, 8.1, 7.98 FROM DUAL UNION ALL
	SELECT 'S40036', 'V40074', '420009', '2', 2023, 'VP', 6.99, 7.34, 5.95, 6.54 FROM DUAL UNION ALL
	SELECT 'S40056', 'V40074', '420009', '2', 2023, 'VP', 7.47, 9.07, 7.4, 7.75 FROM DUAL UNION ALL
	SELECT 'S40039', 'V40074', '420009', '2', 2023, 'VP', 4.4, 6.04, 9.53, 7.29 FROM DUAL UNION ALL
	SELECT 'S40099', 'V40074', '420009', '2', 2023, 'VP', 4.87, 9.94, 9.17, 8.03 FROM DUAL UNION ALL
	SELECT 'S40077', 'V40074', '420009', '2', 2023, 'VP', 4.71, 4.91, 5.13, 4.96 FROM DUAL UNION ALL
	SELECT 'S40076', 'V40074', '420009', '2', 2023, 'VP', 5.57, 5.95, 5.49, 5.61 FROM DUAL UNION ALL
	SELECT 'S40116', 'V40074', '420009', '2', 2023, 'VP', 5.88, 4.48, 4.44, 4.88 FROM DUAL UNION ALL
	SELECT 'S40120', 'V40074', '420009', '2', 2023, 'VP', 6.4, 8.21, 7.39, 7.26 FROM DUAL UNION ALL
	SELECT 'S40080', 'V40074', '420009', '2', 2023, 'VP', 6.85, 8.95, 7.64, 7.66 FROM DUAL UNION ALL
	SELECT 'S40058', 'V40074', '420009', '2', 2023, 'VP', 7.77, 7.07, 5.42, 6.46 FROM DUAL UNION ALL
	SELECT 'S40060', 'V40074', '420009', '2', 2023, 'VP', 5.52, 9.18, 8.09, 7.54 FROM DUAL UNION ALL
	SELECT 'S40016', 'V40074', '420009', '2', 2023, 'VP', 5.06, 9.14, 9.1, 7.9 FROM DUAL UNION ALL
	SELECT 'S40096', 'V40074', '420009', '2', 2023, 'VP', 9.65, 7.09, 6.99, 7.81 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40074', '420009', '2', 2023, 'VP', 9.3, 9.09, 5.77, 7.49 FROM DUAL UNION ALL
	SELECT 'S40017', 'V40074', '420009', '2', 2023, 'VP', 4.93, 5.59, 8.07, 6.63 FROM DUAL UNION ALL
	SELECT 'S40117', 'V40074', '420009', '2', 2023, 'VP', 9.81, 7.63, 6.53, 7.73 FROM DUAL UNION ALL
	SELECT 'S30055', 'V40075', '420010', '2', 2023, 'CTTT', 5.72, 8.86, 5.08, 6.03 FROM DUAL UNION ALL
	SELECT 'S30033', 'V40075', '420010', '2', 2023, 'CTTT', 5.45, 6.62, 9.17, 7.54 FROM DUAL UNION ALL
	SELECT 'S30011', 'V40075', '420010', '2', 2023, 'CTTT', 8.27, 4.2, 4.18, 5.41 FROM DUAL UNION ALL
	SELECT 'S30091', 'V40075', '420010', '2', 2023, 'CTTT', 7.71, 9.13, 8.58, 8.43 FROM DUAL UNION ALL
	SELECT 'S30115', 'V40075', '420010', '2', 2023, 'CTTT', 9.22, 9.99, 6.33, 7.93 FROM DUAL UNION ALL
	SELECT 'S30013', 'V40075', '420010', '2', 2023, 'CTTT', 8.68, 6.48, 4.74, 6.27 FROM DUAL UNION ALL
	SELECT 'S30094', 'V40075', '420010', '2', 2023, 'CTTT', 5.06, 6.74, 5.24, 5.49 FROM DUAL UNION ALL
	SELECT 'S30035', 'V40075', '420010', '2', 2023, 'CTTT', 5.48, 4.64, 4.48, 4.81 FROM DUAL UNION ALL
	SELECT 'S30053', 'V40075', '420010', '2', 2023, 'CTTT', 7.65, 6.96, 8.63, 8.0 FROM DUAL UNION ALL
	SELECT 'S30031', 'V40075', '420010', '2', 2023, 'CTTT', 8.43, 4.67, 8.64, 7.78 FROM DUAL UNION ALL
	SELECT 'S10024', 'V40021', '410007', '2', 2023, 'CQ', 6.74, 5.62, 7.1, 6.7 FROM DUAL UNION ALL
	SELECT 'S10083', 'V40021', '410007', '2', 2023, 'CQ', 8.86, 4.56, 4.24, 5.69 FROM DUAL UNION ALL
	SELECT 'S10005', 'V40021', '410007', '2', 2023, 'CQ', 6.09, 6.11, 5.68, 5.89 FROM DUAL UNION ALL
	SELECT 'S10045', 'V40021', '410007', '2', 2023, 'CQ', 6.96, 8.37, 5.9, 6.71 FROM DUAL UNION ALL
	SELECT 'S10003', 'V40021', '410007', '2', 2023, 'CQ', 9.62, 9.47, 9.24, 9.4 FROM DUAL UNION ALL
	SELECT 'S10102', 'V40021', '410007', '2', 2023, 'CQ', 4.83, 4.1, 7.97, 6.25 FROM DUAL UNION ALL
	SELECT 'S10041', 'V40021', '410007', '2', 2023, 'CQ', 7.76, 4.03, 7.36, 6.81 FROM DUAL UNION ALL
	SELECT 'S10082', 'V40021', '410007', '2', 2023, 'CQ', 5.37, 4.67, 7.96, 6.53 FROM DUAL UNION ALL
	SELECT 'S10025', 'V40021', '410007', '2', 2023, 'CQ', 8.01, 6.69, 5.6, 6.54 FROM DUAL UNION ALL
	SELECT 'S10042', 'V40021', '410007', '2', 2023, 'CQ', 5.86, 7.34, 9.05, 7.75 FROM DUAL UNION ALL
	SELECT 'S10105', 'V40021', '410007', '2', 2023, 'CQ', 5.46, 4.86, 5.39, 5.3 FROM DUAL UNION ALL
	SELECT 'S10044', 'V40021', '410007', '2', 2023, 'CQ', 5.47, 4.44, 8.16, 6.61 FROM DUAL UNION ALL
	SELECT 'S10104', 'V40021', '410007', '2', 2023, 'CQ', 4.5, 6.09, 8.55, 6.84 FROM DUAL UNION ALL
	SELECT 'S10103', 'V40021', '410007', '2', 2023, 'CQ', 5.09, 8.22, 8.1, 7.22 FROM DUAL UNION ALL
	SELECT 'S10004', 'V40021', '410007', '2', 2023, 'CQ', 6.93, 4.97, 9.56, 7.85 FROM DUAL UNION ALL
	SELECT 'S10022', 'V40021', '410007', '2', 2023, 'CQ', 6.67, 5.89, 7.63, 6.99 FROM DUAL UNION ALL
	SELECT 'S10084', 'V40021', '410007', '2', 2023, 'CQ', 9.59, 6.62, 5.24, 6.82 FROM DUAL UNION ALL
	SELECT 'S10063', 'V40021', '410007', '2', 2023, 'CQ', 7.06, 7.42, 9.99, 8.6 FROM DUAL UNION ALL
	SELECT 'S10081', 'V40021', '410007', '2', 2023, 'CQ', 7.5, 4.14, 5.79, 5.97 FROM DUAL UNION ALL
	SELECT 'S10002', 'V40021', '410007', '2', 2023, 'CQ', 4.25, 8.06, 4.12, 4.95 FROM DUAL UNION ALL
	SELECT 'S10043', 'V40021', '410007', '2', 2023, 'CQ', 6.81, 9.87, 6.72, 7.38 FROM DUAL UNION ALL
	SELECT 'S10101', 'V40021', '410007', '2', 2023, 'CQ', 6.79, 7.32, 5.54, 6.27 FROM DUAL UNION ALL
	SELECT 'S10001', 'V40021', '410007', '2', 2023, 'CQ', 7.46, 6.58, 6.74, 6.92 FROM DUAL UNION ALL
	SELECT 'S10085', 'V40021', '410007', '2', 2023, 'CQ', 6.31, 8.06, 4.54, 5.78 FROM DUAL UNION ALL
	SELECT 'S10065', 'V40021', '410007', '2', 2023, 'CQ', 6.21, 5.19, 8.85, 7.33 FROM DUAL UNION ALL
	SELECT 'S10061', 'V40021', '410007', '2', 2023, 'CQ', 8.48, 9.99, 4.78, 6.93 FROM DUAL UNION ALL
	SELECT 'S10064', 'V40021', '410007', '2', 2023, 'CQ', 6.6, 6.87, 6.74, 6.72 FROM DUAL UNION ALL
	SELECT 'S10023', 'V40021', '410007', '2', 2023, 'CQ', 9.3, 9.09, 8.13, 8.67 FROM DUAL UNION ALL
	SELECT 'S10062', 'V40021', '410007', '2', 2023, 'CQ', 7.98, 7.73, 7.96, 7.92 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S30091', 'V40029', '410002', '3', 2023, 'CTTT', 9.8, 5.83, 5.7, 6.96 FROM DUAL UNION ALL
	SELECT 'S30011', 'V40029', '410002', '3', 2023, 'CTTT', 6.2, 5.29, 7.79, 6.81 FROM DUAL UNION ALL
	SELECT 'S30114', 'V40029', '410002', '3', 2023, 'CTTT', 7.71, 9.21, 5.36, 6.84 FROM DUAL UNION ALL
	SELECT 'S30052', 'V40029', '410002', '3', 2023, 'CTTT', 9.84, 6.58, 6.75, 7.64 FROM DUAL UNION ALL
	SELECT 'S30075', 'V40029', '410002', '3', 2023, 'CTTT', 8.66, 7.1, 4.21, 6.12 FROM DUAL UNION ALL
	SELECT 'S30111', 'V40029', '410002', '3', 2023, 'CTTT', 8.95, 8.77, 9.69, 9.28 FROM DUAL UNION ALL
	SELECT 'S30051', 'V40029', '410002', '3', 2023, 'CTTT', 7.62, 8.16, 4.74, 6.29 FROM DUAL UNION ALL
	SELECT 'S30032', 'V40029', '410002', '3', 2023, 'CTTT', 5.41, 6.84, 6.33, 6.16 FROM DUAL UNION ALL
	SELECT 'S30074', 'V40029', '410002', '3', 2023, 'CTTT', 6.39, 9.86, 5.36, 6.57 FROM DUAL UNION ALL
	SELECT 'S30034', 'V40029', '410002', '3', 2023, 'CTTT', 6.42, 8.82, 5.53, 6.46 FROM DUAL UNION ALL
	SELECT 'S30055', 'V40029', '410002', '3', 2023, 'CTTT', 7.68, 8.61, 5.95, 7.0 FROM DUAL UNION ALL
	SELECT 'S30033', 'V40029', '410002', '3', 2023, 'CTTT', 9.33, 8.13, 7.19, 8.02 FROM DUAL UNION ALL
	SELECT 'S30093', 'V40029', '410002', '3', 2023, 'CTTT', 6.94, 9.04, 4.01, 5.89 FROM DUAL UNION ALL
	SELECT 'S30013', 'V40029', '410002', '3', 2023, 'CTTT', 9.73, 4.68, 6.91, 7.31 FROM DUAL UNION ALL
	SELECT 'S30072', 'V40029', '410002', '3', 2023, 'CTTT', 8.11, 4.74, 7.53, 7.15 FROM DUAL UNION ALL
	SELECT 'S30031', 'V40029', '410002', '3', 2023, 'CTTT', 9.9, 7.38, 6.23, 7.56 FROM DUAL UNION ALL
	SELECT 'S30014', 'V40029', '410002', '3', 2023, 'CTTT', 5.63, 9.04, 4.67, 5.83 FROM DUAL UNION ALL
	SELECT 'S30112', 'V40029', '410002', '3', 2023, 'CTTT', 7.82, 5.2, 4.13, 5.45 FROM DUAL UNION ALL
	SELECT 'S30053', 'V40029', '410002', '3', 2023, 'CTTT', 5.56, 8.28, 4.62, 5.63 FROM DUAL UNION ALL
	SELECT 'S30113', 'V40029', '410002', '3', 2023, 'CTTT', 5.85, 7.27, 8.33, 7.37 FROM DUAL UNION ALL
	SELECT 'S30073', 'V40029', '410002', '3', 2023, 'CTTT', 7.1, 6.76, 9.11, 8.04 FROM DUAL UNION ALL
	SELECT 'S30054', 'V40029', '410002', '3', 2023, 'CTTT', 4.56, 9.92, 5.92, 6.31 FROM DUAL UNION ALL
	SELECT 'S20026', 'V40072', '410003', '3', 2023, 'CLC', 9.61, 9.26, 8.13, 8.8 FROM DUAL UNION ALL
	SELECT 'S20027', 'V40072', '410003', '3', 2023, 'CLC', 5.9, 9.79, 9.1, 8.28 FROM DUAL UNION ALL
	SELECT 'S20067', 'V40072', '410003', '3', 2023, 'CLC', 5.73, 9.33, 5.48, 6.33 FROM DUAL UNION ALL
	SELECT 'S20029', 'V40072', '410003', '3', 2023, 'CLC', 9.72, 4.7, 9.66, 8.69 FROM DUAL UNION ALL
	SELECT 'S20008', 'V40072', '410003', '3', 2023, 'CLC', 9.87, 8.09, 9.0, 9.08 FROM DUAL UNION ALL
	SELECT 'S20010', 'V40072', '410003', '3', 2023, 'CLC', 9.66, 9.63, 5.99, 7.82 FROM DUAL UNION ALL
	SELECT 'S20090', 'V40072', '410003', '3', 2023, 'CLC', 7.94, 4.42, 4.51, 5.52 FROM DUAL UNION ALL
	SELECT 'S40096', 'V40023', '420003', '3', 2023, 'VP', 7.4, 5.7, 8.76, 7.74 FROM DUAL UNION ALL
	SELECT 'S40117', 'V40023', '420003', '3', 2023, 'VP', 5.39, 5.26, 4.41, 4.87 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40023', '420003', '3', 2023, 'VP', 9.35, 4.78, 6.49, 7.01 FROM DUAL UNION ALL
	SELECT 'S40060', 'V40023', '420003', '3', 2023, 'VP', 7.56, 8.93, 8.78, 8.44 FROM DUAL UNION ALL
	SELECT 'S40036', 'V40023', '420003', '3', 2023, 'VP', 9.38, 9.0, 6.14, 7.68 FROM DUAL UNION ALL
	SELECT 'S40019', 'V40025', '420008', '3', 2023, 'VP', 9.03, 8.14, 4.69, 6.68 FROM DUAL UNION ALL
	SELECT 'S40100', 'V40025', '420008', '3', 2023, 'VP', 5.57, 7.82, 5.47, 5.97 FROM DUAL UNION ALL
	SELECT 'S40039', 'V40025', '420008', '3', 2023, 'VP', 6.28, 9.5, 4.47, 6.02 FROM DUAL UNION ALL
	SELECT 'S40018', 'V40025', '420008', '3', 2023, 'VP', 4.03, 9.26, 6.65, 6.39 FROM DUAL UNION ALL
	SELECT 'S40058', 'V40025', '420008', '3', 2023, 'VP', 4.09, 8.49, 6.71, 6.28 FROM DUAL UNION ALL
	SELECT 'S40080', 'V40025', '420008', '3', 2023, 'VP', 6.13, 7.87, 7.57, 7.2 FROM DUAL UNION ALL
	SELECT 'S40117', 'V40025', '420008', '3', 2023, 'VP', 4.04, 6.78, 8.3, 6.72 FROM DUAL UNION ALL
	SELECT 'S40036', 'V40025', '420008', '3', 2023, 'VP', 4.98, 8.4, 5.59, 5.97 FROM DUAL UNION ALL
	SELECT 'S40040', 'V40025', '420008', '3', 2023, 'VP', 9.4, 7.54, 6.41, 7.53 FROM DUAL UNION ALL
	SELECT 'S40078', 'V40025', '420008', '3', 2023, 'VP', 5.38, 8.38, 5.76, 6.17 FROM DUAL UNION ALL
	SELECT 'S40037', 'V40025', '420008', '3', 2023, 'VP', 4.83, 4.85, 4.35, 4.59 FROM DUAL UNION ALL
	SELECT 'S40038', 'V40025', '420008', '3', 2023, 'VP', 7.38, 7.84, 8.02, 7.79 FROM DUAL UNION ALL
	SELECT 'S40076', 'V40025', '420008', '3', 2023, 'VP', 6.62, 8.97, 8.85, 8.21 FROM DUAL UNION ALL
	SELECT 'S40077', 'V40025', '420008', '3', 2023, 'VP', 9.98, 7.63, 9.47, 9.26 FROM DUAL UNION ALL
	SELECT 'S40120', 'V40025', '420008', '3', 2023, 'VP', 7.92, 6.93, 6.43, 6.98 FROM DUAL UNION ALL
	SELECT 'S40016', 'V40025', '420008', '3', 2023, 'VP', 7.75, 6.69, 9.57, 8.45 FROM DUAL UNION ALL
	SELECT 'S40017', 'V40025', '420008', '3', 2023, 'VP', 7.05, 6.98, 8.11, 7.57 FROM DUAL UNION ALL
	SELECT 'S40060', 'V40025', '420008', '3', 2023, 'VP', 6.88, 5.68, 7.0, 6.7 FROM DUAL UNION ALL
	SELECT 'S40020', 'V40025', '420008', '3', 2023, 'VP', 7.4, 6.32, 9.99, 8.48 FROM DUAL UNION ALL
	SELECT 'S40059', 'V40025', '420008', '3', 2023, 'VP', 7.25, 5.16, 9.49, 7.95 FROM DUAL UNION ALL
	SELECT 'S40056', 'V40025', '420008', '3', 2023, 'VP', 6.39, 9.38, 4.17, 5.88 FROM DUAL UNION ALL
	SELECT 'S40079', 'V40025', '420008', '3', 2023, 'VP', 4.45, 6.12, 6.19, 5.65 FROM DUAL UNION ALL
	SELECT 'S40097', 'V40025', '420008', '3', 2023, 'VP', 5.83, 7.7, 5.4, 5.99 FROM DUAL UNION ALL
	SELECT 'S40057', 'V40025', '420008', '3', 2023, 'VP', 9.74, 4.79, 6.47, 7.12 FROM DUAL UNION ALL
	SELECT 'S40116', 'V40025', '420008', '3', 2023, 'VP', 8.48, 8.62, 8.32, 8.43 FROM DUAL UNION ALL
	SELECT 'S40118', 'V40025', '420008', '3', 2023, 'VP', 8.28, 9.24, 6.25, 7.46 FROM DUAL UNION ALL
	SELECT 'S40096', 'V40025', '420008', '3', 2023, 'VP', 8.61, 6.53, 8.3, 8.04 FROM DUAL UNION ALL
	SELECT 'S40119', 'V40025', '420008', '3', 2023, 'VP', 4.59, 4.59, 5.62, 5.11 FROM DUAL UNION ALL
	SELECT 'S30053', 'V40024', '410005', '3', 2023, 'CTTT', 5.54, 6.4, 5.29, 5.59 FROM DUAL UNION ALL
	SELECT 'S30054', 'V40024', '410005', '3', 2023, 'CTTT', 4.5, 5.61, 7.22, 6.08 FROM DUAL UNION ALL
	SELECT 'S30114', 'V40024', '410005', '3', 2023, 'CTTT', 4.17, 9.71, 5.06, 5.72 FROM DUAL UNION ALL
	SELECT 'S30015', 'V40024', '410005', '3', 2023, 'CTTT', 9.53, 9.76, 9.76, 9.69 FROM DUAL UNION ALL
	SELECT 'S30074', 'V40024', '410005', '3', 2023, 'CTTT', 6.09, 6.37, 4.73, 5.47 FROM DUAL UNION ALL
	SELECT 'S30091', 'V40024', '410005', '3', 2023, 'CTTT', 8.84, 6.88, 7.57, 7.81 FROM DUAL UNION ALL
	SELECT 'S30071', 'V40024', '410005', '3', 2023, 'CTTT', 9.29, 9.87, 7.28, 8.4 FROM DUAL UNION ALL
	SELECT 'S30032', 'V40024', '410005', '3', 2023, 'CTTT', 4.54, 7.18, 5.78, 5.69 FROM DUAL UNION ALL
	SELECT 'S30094', 'V40024', '410005', '3', 2023, 'CTTT', 7.08, 8.55, 6.16, 6.91 FROM DUAL UNION ALL
	SELECT 'S30012', 'V40024', '410005', '3', 2023, 'CTTT', 6.26, 7.42, 7.6, 7.16 FROM DUAL UNION ALL
	SELECT 'S30073', 'V40024', '410005', '3', 2023, 'CTTT', 5.2, 5.58, 4.93, 5.14 FROM DUAL UNION ALL
	SELECT 'S30112', 'V40024', '410005', '3', 2023, 'CTTT', 4.89, 7.67, 7.84, 6.92 FROM DUAL UNION ALL
	SELECT 'S30115', 'V40024', '410005', '3', 2023, 'CTTT', 7.04, 5.01, 9.37, 7.8 FROM DUAL UNION ALL
	SELECT 'S30013', 'V40024', '410005', '3', 2023, 'CTTT', 7.63, 6.24, 5.49, 6.28 FROM DUAL UNION ALL
	SELECT 'S30095', 'V40024', '410005', '3', 2023, 'CTTT', 5.77, 7.78, 4.5, 5.54 FROM DUAL UNION ALL
	SELECT 'S30034', 'V40024', '410005', '3', 2023, 'CTTT', 4.54, 5.77, 6.47, 5.75 FROM DUAL UNION ALL
	SELECT 'S30035', 'V40024', '410005', '3', 2023, 'CTTT', 4.44, 9.4, 4.72, 5.57 FROM DUAL UNION ALL
	SELECT 'S30072', 'V40024', '410005', '3', 2023, 'CTTT', 8.51, 9.87, 6.85, 7.95 FROM DUAL UNION ALL
	SELECT 'S30093', 'V40024', '410005', '3', 2023, 'CTTT', 5.17, 8.46, 8.64, 7.56 FROM DUAL UNION ALL
	SELECT 'S30031', 'V40024', '410005', '3', 2023, 'CTTT', 4.02, 7.18, 8.52, 6.9 FROM DUAL UNION ALL
	SELECT 'S30113', 'V40024', '410005', '3', 2023, 'CTTT', 5.85, 8.5, 5.29, 6.1 FROM DUAL UNION ALL
	SELECT 'S30092', 'V40021', '410011', '3', 2023, 'CTTT', 5.06, 8.76, 8.52, 7.53 FROM DUAL UNION ALL
	SELECT 'S30034', 'V40021', '410011', '3', 2023, 'CTTT', 8.98, 7.42, 8.53, 8.44 FROM DUAL UNION ALL
	SELECT 'S30032', 'V40021', '410011', '3', 2023, 'CTTT', 4.14, 9.81, 7.93, 7.17 FROM DUAL UNION ALL
	SELECT 'S30013', 'V40021', '410011', '3', 2023, 'CTTT', 5.36, 9.59, 6.11, 6.58 FROM DUAL UNION ALL
	SELECT 'S30052', 'V40021', '410011', '3', 2023, 'CTTT', 6.31, 6.88, 7.6, 7.07 FROM DUAL UNION ALL
	SELECT 'S30053', 'V40021', '410011', '3', 2023, 'CTTT', 7.53, 4.77, 6.42, 6.42 FROM DUAL UNION ALL
	SELECT 'S30011', 'V40021', '410011', '3', 2023, 'CTTT', 9.33, 5.25, 7.97, 7.83 FROM DUAL UNION ALL
	SELECT 'S30095', 'V40021', '410011', '3', 2023, 'CTTT', 5.69, 7.41, 7.64, 7.01 FROM DUAL UNION ALL
	SELECT 'S30073', 'V40021', '410011', '3', 2023, 'CTTT', 5.85, 9.73, 5.6, 6.5 FROM DUAL UNION ALL
	SELECT 'S30035', 'V40021', '410011', '3', 2023, 'CTTT', 8.63, 5.11, 4.78, 6.0 FROM DUAL UNION ALL
	SELECT 'S30031', 'V40021', '410011', '3', 2023, 'CTTT', 7.48, 8.73, 9.03, 8.5 FROM DUAL UNION ALL
	SELECT 'S30055', 'V40021', '410011', '3', 2023, 'CTTT', 4.56, 4.27, 4.5, 4.47 FROM DUAL UNION ALL
	SELECT 'S30054', 'V40021', '410011', '3', 2023, 'CTTT', 7.12, 6.7, 9.42, 8.19 FROM DUAL UNION ALL
	SELECT 'S30014', 'V40021', '410011', '3', 2023, 'CTTT', 4.77, 4.63, 4.19, 4.45 FROM DUAL UNION ALL
	SELECT 'S30033', 'V40021', '410011', '3', 2023, 'CTTT', 4.57, 8.72, 8.72, 7.48 FROM DUAL UNION ALL
	SELECT 'S30113', 'V40021', '410011', '3', 2023, 'CTTT', 4.69, 9.28, 8.18, 7.35 FROM DUAL UNION ALL
	SELECT 'S30074', 'V40021', '410011', '3', 2023, 'CTTT', 4.78, 4.64, 7.75, 6.24 FROM DUAL UNION ALL
	SELECT 'S30094', 'V40021', '410011', '3', 2023, 'CTTT', 7.22, 7.12, 5.79, 6.48 FROM DUAL UNION ALL
	SELECT 'S30071', 'V40021', '410011', '3', 2023, 'CTTT', 6.94, 4.02, 8.22, 7.0 FROM DUAL UNION ALL
	SELECT 'S30015', 'V40021', '410011', '3', 2023, 'CTTT', 9.76, 6.58, 6.02, 7.25 FROM DUAL;
INSERT INTO DANGKY
--5. BO MON CNTT
--	2023 - HOC KY 1
	SELECT 'S10085', 'V50078', '520002', '1', 2023, 'CQ', 9.18, 9.6, 8.86, 9.1 FROM DUAL UNION ALL
	SELECT 'S10003', 'V50078', '520002', '1', 2023, 'CQ', 8.14, 5.19, 6.15, 6.56 FROM DUAL UNION ALL
	SELECT 'S10084', 'V50078', '520002', '1', 2023, 'CQ', 4.31, 4.94, 6.05, 5.31 FROM DUAL UNION ALL
	SELECT 'S10004', 'V50078', '520002', '1', 2023, 'CQ', 7.07, 4.49, 4.0, 5.02 FROM DUAL UNION ALL
	SELECT 'S10103', 'V50078', '520002', '1', 2023, 'CQ', 8.42, 8.19, 6.6, 7.46 FROM DUAL UNION ALL
	SELECT 'S10104', 'V50078', '520002', '1', 2023, 'CQ', 4.17, 4.04, 7.47, 5.79 FROM DUAL UNION ALL
	SELECT 'S10024', 'V50078', '520002', '1', 2023, 'CQ', 8.66, 9.41, 4.16, 6.56 FROM DUAL UNION ALL
	SELECT 'S10064', 'V50078', '520002', '1', 2023, 'CQ', 5.84, 9.89, 7.28, 7.37 FROM DUAL UNION ALL
	SELECT 'S10044', 'V50078', '520002', '1', 2023, 'CQ', 4.16, 6.95, 4.24, 4.76 FROM DUAL UNION ALL
	SELECT 'S10002', 'V50078', '520002', '1', 2023, 'CQ', 9.74, 5.54, 7.89, 7.97 FROM DUAL UNION ALL
	SELECT 'S10101', 'V50078', '520002', '1', 2023, 'CQ', 9.72, 6.56, 8.95, 8.7 FROM DUAL UNION ALL
	SELECT 'S10102', 'V50078', '520002', '1', 2023, 'CQ', 5.87, 7.51, 8.29, 7.41 FROM DUAL UNION ALL
	SELECT 'S10081', 'V50078', '520002', '1', 2023, 'CQ', 7.5, 9.79, 9.25, 8.83 FROM DUAL UNION ALL
	SELECT 'S10083', 'V50078', '520002', '1', 2023, 'CQ', 5.37, 6.31, 9.84, 7.79 FROM DUAL UNION ALL
	SELECT 'S10105', 'V50078', '520002', '1', 2023, 'CQ', 7.59, 9.06, 6.62, 7.4 FROM DUAL UNION ALL
	SELECT 'S10041', 'V50078', '520002', '1', 2023, 'CQ', 4.85, 7.08, 9.8, 7.77 FROM DUAL UNION ALL
	SELECT 'S10063', 'V50078', '520002', '1', 2023, 'CQ', 4.09, 7.3, 5.29, 5.33 FROM DUAL UNION ALL
	SELECT 'S10043', 'V50078', '520002', '1', 2023, 'CQ', 6.99, 5.15, 4.42, 5.34 FROM DUAL UNION ALL
	SELECT 'S10023', 'V50078', '520002', '1', 2023, 'CQ', 6.6, 5.97, 9.3, 7.82 FROM DUAL UNION ALL
	SELECT 'S10065', 'V50078', '520002', '1', 2023, 'CQ', 4.25, 6.01, 6.69, 5.82 FROM DUAL UNION ALL
	SELECT 'S10021', 'V50078', '520002', '1', 2023, 'CQ', 7.96, 9.39, 6.87, 7.7 FROM DUAL UNION ALL
	SELECT 'S10083', 'V50077', '530005', '1', 2023, 'CQ', 5.12, 5.01, 7.47, 6.27 FROM DUAL UNION ALL
	SELECT 'S10105', 'V50077', '530005', '1', 2023, 'CQ', 7.78, 8.11, 9.26, 8.59 FROM DUAL UNION ALL
	SELECT 'S10041', 'V50077', '530005', '1', 2023, 'CQ', 8.17, 7.76, 4.56, 6.28 FROM DUAL UNION ALL
	SELECT 'S10103', 'V50077', '530005', '1', 2023, 'CQ', 8.39, 5.03, 4.93, 5.99 FROM DUAL UNION ALL
	SELECT 'S10004', 'V50077', '530005', '1', 2023, 'CQ', 4.06, 6.63, 6.93, 6.01 FROM DUAL UNION ALL
	SELECT 'S10085', 'V50077', '530005', '1', 2023, 'CQ', 5.43, 4.92, 9.44, 7.33 FROM DUAL UNION ALL
	SELECT 'S10023', 'V50077', '530005', '1', 2023, 'CQ', 9.3, 9.24, 4.5, 6.89 FROM DUAL UNION ALL
	SELECT 'S10061', 'V50077', '530005', '1', 2023, 'CQ', 6.53, 9.17, 9.39, 8.49 FROM DUAL UNION ALL
	SELECT 'S10042', 'V50077', '530005', '1', 2023, 'CQ', 9.83, 8.48, 6.53, 7.91 FROM DUAL UNION ALL
	SELECT 'S10001', 'V50077', '530005', '1', 2023, 'CQ', 5.04, 8.87, 6.57, 6.57 FROM DUAL UNION ALL
	SELECT 'S10003', 'V50077', '530005', '1', 2023, 'CQ', 5.28, 9.19, 5.01, 5.93 FROM DUAL UNION ALL
	SELECT 'S10043', 'V50077', '530005', '1', 2023, 'CQ', 5.02, 4.9, 4.25, 4.61 FROM DUAL UNION ALL
	SELECT 'S10104', 'V50077', '530005', '1', 2023, 'CQ', 9.85, 6.21, 9.42, 8.91 FROM DUAL UNION ALL
	SELECT 'S10045', 'V50077', '530005', '1', 2023, 'CQ', 6.38, 9.8, 6.03, 6.89 FROM DUAL UNION ALL
	SELECT 'S10065', 'V50077', '530005', '1', 2023, 'CQ', 6.52, 5.3, 4.16, 5.1 FROM DUAL UNION ALL
	SELECT 'S10082', 'V50077', '530005', '1', 2023, 'CQ', 5.19, 8.34, 9.65, 8.05 FROM DUAL UNION ALL
	SELECT 'S10084', 'V50077', '530005', '1', 2023, 'CQ', 9.61, 9.77, 5.0, 7.34 FROM DUAL UNION ALL
	SELECT 'S10022', 'V50077', '530005', '1', 2023, 'CQ', 7.45, 9.18, 6.26, 7.2 FROM DUAL UNION ALL
	SELECT 'S10101', 'V50077', '530005', '1', 2023, 'CQ', 8.28, 6.96, 7.68, 7.72 FROM DUAL UNION ALL
	SELECT 'S10062', 'V50077', '530005', '1', 2023, 'CQ', 4.93, 5.05, 9.5, 7.24 FROM DUAL UNION ALL
	SELECT 'S10064', 'V50077', '530005', '1', 2023, 'CQ', 4.28, 6.07, 8.78, 6.89 FROM DUAL UNION ALL
	SELECT 'S10005', 'V50077', '530005', '1', 2023, 'CQ', 9.79, 5.24, 5.17, 6.57 FROM DUAL UNION ALL
	SELECT 'S10025', 'V50077', '530005', '1', 2023, 'CQ', 9.85, 5.61, 4.46, 6.31 FROM DUAL UNION ALL
	SELECT 'S10081', 'V50077', '530005', '1', 2023, 'CQ', 8.64, 9.08, 5.49, 7.15 FROM DUAL UNION ALL
	SELECT 'S10063', 'V50077', '530005', '1', 2023, 'CQ', 7.69, 7.47, 6.96, 7.28 FROM DUAL UNION ALL
	SELECT 'S10102', 'V50077', '530005', '1', 2023, 'CQ', 4.92, 5.0, 9.0, 6.98 FROM DUAL UNION ALL
	SELECT 'S20086', 'V50080', '510002', '1', 2023, 'CLC', 9.05, 9.58, 6.66, 7.96 FROM DUAL UNION ALL
	SELECT 'S20108', 'V50080', '510002', '1', 2023, 'CLC', 9.59, 5.75, 5.32, 6.69 FROM DUAL UNION ALL
	SELECT 'S20029', 'V50080', '510002', '1', 2023, 'CLC', 6.21, 9.51, 5.53, 6.53 FROM DUAL UNION ALL
	SELECT 'S20087', 'V50080', '510002', '1', 2023, 'CLC', 7.75, 5.67, 9.86, 8.39 FROM DUAL UNION ALL
	SELECT 'S20106', 'V50080', '510002', '1', 2023, 'CLC', 7.77, 7.37, 6.48, 7.04 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50080', '510002', '1', 2023, 'CLC', 4.77, 8.57, 4.05, 5.17 FROM DUAL UNION ALL
	SELECT 'S20049', 'V50080', '510002', '1', 2023, 'CLC', 9.27, 6.56, 9.06, 8.62 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50080', '510002', '1', 2023, 'CLC', 7.44, 4.03, 9.06, 7.57 FROM DUAL UNION ALL
	SELECT 'S20027', 'V50080', '510002', '1', 2023, 'CLC', 6.18, 9.35, 5.47, 6.46 FROM DUAL UNION ALL
	SELECT 'S20009', 'V50080', '510002', '1', 2023, 'CLC', 9.84, 6.01, 8.75, 8.53 FROM DUAL UNION ALL
	SELECT 'S20006', 'V50080', '510002', '1', 2023, 'CLC', 8.29, 4.82, 8.59, 7.75 FROM DUAL UNION ALL
	SELECT 'S20068', 'V50080', '510002', '1', 2023, 'CLC', 4.39, 9.83, 9.16, 7.86 FROM DUAL UNION ALL
	SELECT 'S20107', 'V50076', '510005', '1', 2023, 'CLC', 8.82, 6.65, 6.06, 7.01 FROM DUAL UNION ALL
	SELECT 'S20049', 'V50076', '510005', '1', 2023, 'CLC', 9.59, 9.63, 6.79, 8.2 FROM DUAL UNION ALL
	SELECT 'S20068', 'V50076', '510005', '1', 2023, 'CLC', 9.94, 8.96, 9.36, 9.45 FROM DUAL UNION ALL
	SELECT 'S20029', 'V50076', '510005', '1', 2023, 'CLC', 4.06, 9.76, 9.01, 7.67 FROM DUAL UNION ALL
	SELECT 'S20090', 'V50076', '510005', '1', 2023, 'CLC', 9.6, 9.57, 8.14, 8.86 FROM DUAL UNION ALL
	SELECT 'S20006', 'V50076', '510005', '1', 2023, 'CLC', 7.2, 6.44, 8.83, 7.86 FROM DUAL UNION ALL
	SELECT 'S20067', 'V50076', '510005', '1', 2023, 'CLC', 9.35, 5.02, 4.63, 6.12 FROM DUAL UNION ALL
	SELECT 'S20088', 'V50076', '510005', '1', 2023, 'CLC', 7.49, 8.81, 5.13, 6.57 FROM DUAL UNION ALL
	SELECT 'S20007', 'V50076', '510005', '1', 2023, 'CLC', 4.46, 5.68, 7.17, 6.06 FROM DUAL UNION ALL
	SELECT 'S20106', 'V50076', '510005', '1', 2023, 'CLC', 9.69, 4.98, 6.84, 7.32 FROM DUAL UNION ALL
	SELECT 'S20070', 'V50076', '510005', '1', 2023, 'CLC', 4.31, 7.56, 8.61, 7.11 FROM DUAL UNION ALL
	SELECT 'S20009', 'V50076', '510005', '1', 2023, 'CLC', 8.31, 4.46, 8.98, 7.88 FROM DUAL UNION ALL
	SELECT 'S20066', 'V50076', '510005', '1', 2023, 'CLC', 9.99, 9.68, 6.54, 8.2 FROM DUAL UNION ALL
	SELECT 'S20089', 'V50076', '510005', '1', 2023, 'CLC', 6.68, 4.53, 7.95, 6.88 FROM DUAL UNION ALL
	SELECT 'S20087', 'V50076', '510005', '1', 2023, 'CLC', 5.67, 9.0, 7.04, 7.02 FROM DUAL UNION ALL
	SELECT 'S20109', 'V50076', '510005', '1', 2023, 'CLC', 5.12, 8.53, 6.15, 6.32 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50076', '510005', '1', 2023, 'CLC', 5.93, 4.64, 9.99, 7.7 FROM DUAL UNION ALL
	SELECT 'S20030', 'V50076', '510005', '1', 2023, 'CLC', 6.61, 6.45, 6.63, 6.59 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50076', '510005', '1', 2023, 'CLC', 4.53, 6.1, 6.07, 5.61 FROM DUAL UNION ALL
	SELECT 'S20108', 'V50076', '510005', '1', 2023, 'CLC', 6.61, 4.9, 4.98, 5.45 FROM DUAL UNION ALL
	SELECT 'S20026', 'V50076', '510005', '1', 2023, 'CLC', 9.5, 8.19, 8.95, 8.96 FROM DUAL UNION ALL
	SELECT 'S20050', 'V50076', '510005', '1', 2023, 'CLC', 6.29, 6.6, 7.15, 6.78 FROM DUAL UNION ALL
	SELECT 'S20046', 'V50076', '510005', '1', 2023, 'CLC', 8.2, 8.44, 9.18, 8.74 FROM DUAL UNION ALL
	SELECT 'S20086', 'V50076', '510005', '1', 2023, 'CLC', 6.7, 4.5, 4.18, 5.0 FROM DUAL UNION ALL
	SELECT 'S20110', 'V50076', '510005', '1', 2023, 'CLC', 4.68, 4.03, 9.29, 6.85 FROM DUAL UNION ALL
	SELECT 'S30095', 'V50033', '530004', '1', 2023, 'CTTT', 4.78, 7.87, 6.29, 6.15 FROM DUAL UNION ALL
	SELECT 'S30011', 'V50033', '530004', '1', 2023, 'CTTT', 7.84, 8.31, 9.36, 8.69 FROM DUAL UNION ALL
	SELECT 'S30055', 'V50033', '530004', '1', 2023, 'CTTT', 4.62, 5.09, 9.51, 7.16 FROM DUAL UNION ALL
	SELECT 'S30053', 'V50033', '530004', '1', 2023, 'CTTT', 4.08, 4.74, 9.04, 6.69 FROM DUAL UNION ALL
	SELECT 'S30111', 'V50033', '530004', '1', 2023, 'CTTT', 9.47, 4.53, 6.94, 7.22 FROM DUAL UNION ALL
	SELECT 'S30072', 'V50033', '530004', '1', 2023, 'CTTT', 9.46, 6.08, 5.07, 6.59 FROM DUAL UNION ALL
	SELECT 'S30031', 'V50033', '530004', '1', 2023, 'CTTT', 5.27, 7.95, 8.83, 7.59 FROM DUAL UNION ALL
	SELECT 'S30093', 'V50033', '530004', '1', 2023, 'CTTT', 8.46, 5.33, 5.78, 6.49 FROM DUAL UNION ALL
	SELECT 'S30074', 'V50033', '530004', '1', 2023, 'CTTT', 9.41, 7.41, 8.97, 8.79 FROM DUAL UNION ALL
	SELECT 'S30071', 'V50033', '530004', '1', 2023, 'CTTT', 7.33, 5.57, 7.44, 7.03 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50078', '520001', '1', 2023, 'VP', 4.74, 4.38, 6.04, 5.32 FROM DUAL UNION ALL
	SELECT 'S40100', 'V50078', '520001', '1', 2023, 'VP', 6.91, 8.49, 7.11, 7.33 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50078', '520001', '1', 2023, 'VP', 9.36, 6.43, 8.33, 8.26 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50078', '520001', '1', 2023, 'VP', 7.82, 7.79, 5.51, 6.66 FROM DUAL UNION ALL
	SELECT 'S40076', 'V50078', '520001', '1', 2023, 'VP', 9.9, 8.14, 5.22, 7.21 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50078', '520001', '1', 2023, 'VP', 6.4, 9.13, 8.39, 7.94 FROM DUAL UNION ALL
	SELECT 'S40019', 'V50078', '520001', '1', 2023, 'VP', 8.87, 7.09, 7.78, 7.97 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50078', '520001', '1', 2023, 'VP', 7.67, 7.41, 4.87, 6.22 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50078', '520001', '1', 2023, 'VP', 6.72, 9.44, 7.3, 7.55 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S40120', 'V50034', '510006', '2', 2023, 'VP', 9.68, 7.74, 8.39, 8.65 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50034', '510006', '2', 2023, 'VP', 8.56, 6.9, 4.59, 6.24 FROM DUAL UNION ALL
	SELECT 'S40020', 'V50034', '510006', '2', 2023, 'VP', 4.92, 7.49, 7.82, 6.88 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50034', '510006', '2', 2023, 'VP', 8.04, 5.4, 7.66, 7.32 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50034', '510006', '2', 2023, 'VP', 7.48, 4.94, 9.35, 7.91 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50034', '510006', '2', 2023, 'VP', 9.03, 4.37, 6.5, 6.83 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50034', '510006', '2', 2023, 'VP', 6.69, 7.71, 4.23, 5.66 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50034', '510006', '2', 2023, 'VP', 6.49, 5.71, 8.18, 7.18 FROM DUAL UNION ALL
	SELECT 'S40099', 'V50034', '510006', '2', 2023, 'VP', 9.37, 6.54, 6.05, 7.14 FROM DUAL UNION ALL
	SELECT 'S40019', 'V50034', '510006', '2', 2023, 'VP', 7.32, 7.85, 8.05, 7.79 FROM DUAL UNION ALL
	SELECT 'S40038', 'V50034', '510006', '2', 2023, 'VP', 7.72, 4.32, 7.99, 7.17 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50034', '510006', '2', 2023, 'VP', 9.13, 9.29, 6.41, 7.8 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50034', '510006', '2', 2023, 'VP', 5.16, 6.61, 8.76, 7.25 FROM DUAL UNION ALL
	SELECT 'S40017', 'V50039', '520005', '2', 2023, 'VP', 7.24, 6.5, 5.55, 6.25 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50039', '520005', '2', 2023, 'VP', 4.86, 7.23, 4.38, 5.09 FROM DUAL UNION ALL
	SELECT 'S40060', 'V50039', '520005', '2', 2023, 'VP', 6.32, 5.62, 4.96, 5.5 FROM DUAL UNION ALL
	SELECT 'S40016', 'V50039', '520005', '2', 2023, 'VP', 4.7, 5.35, 8.77, 6.87 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50039', '520005', '2', 2023, 'VP', 4.1, 5.95, 9.49, 7.17 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50039', '520005', '2', 2023, 'VP', 5.97, 5.86, 7.67, 6.8 FROM DUAL UNION ALL
	SELECT 'S20008', 'V50038', '510009', '2', 2023, 'CLC', 9.11, 6.21, 8.45, 8.2 FROM DUAL UNION ALL
	SELECT 'S20087', 'V50038', '510009', '2', 2023, 'CLC', 8.82, 6.27, 5.47, 6.63 FROM DUAL UNION ALL
	SELECT 'S20090', 'V50038', '510009', '2', 2023, 'CLC', 5.69, 7.25, 7.21, 6.76 FROM DUAL UNION ALL
	SELECT 'S20026', 'V50038', '510009', '2', 2023, 'CLC', 6.97, 7.5, 6.95, 7.07 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50038', '510009', '2', 2023, 'CLC', 8.68, 7.23, 7.16, 7.63 FROM DUAL UNION ALL
	SELECT 'S10063', 'V50040', '510007', '2', 2023, 'CQ', 7.4, 7.38, 4.77, 6.08 FROM DUAL UNION ALL
	SELECT 'S10022', 'V50040', '510007', '2', 2023, 'CQ', 4.04, 5.89, 6.33, 5.55 FROM DUAL UNION ALL
	SELECT 'S10005', 'V50040', '510007', '2', 2023, 'CQ', 7.25, 9.83, 7.49, 7.89 FROM DUAL UNION ALL
	SELECT 'S10042', 'V50040', '510007', '2', 2023, 'CQ', 6.45, 4.28, 4.96, 5.27 FROM DUAL UNION ALL
	SELECT 'S10102', 'V50040', '510007', '2', 2023, 'CQ', 9.68, 6.79, 4.55, 6.54 FROM DUAL UNION ALL
	SELECT 'S10103', 'V50040', '510007', '2', 2023, 'CQ', 8.14, 7.72, 6.31, 7.14 FROM DUAL UNION ALL
	SELECT 'S10101', 'V50040', '510007', '2', 2023, 'CQ', 8.05, 4.14, 5.58, 6.03 FROM DUAL UNION ALL
	SELECT 'S10041', 'V50040', '510007', '2', 2023, 'CQ', 5.82, 4.65, 5.75, 5.55 FROM DUAL UNION ALL
	SELECT 'S20007', 'V50032', '530001', '2', 2023, 'CLC', 4.81, 9.34, 8.74, 7.68 FROM DUAL UNION ALL
	SELECT 'S20066', 'V50032', '530001', '2', 2023, 'CLC', 4.12, 8.84, 9.09, 7.55 FROM DUAL UNION ALL
	SELECT 'S20048', 'V50032', '530001', '2', 2023, 'CLC', 4.42, 4.68, 7.2, 5.86 FROM DUAL UNION ALL
	SELECT 'S20029', 'V50032', '530001', '2', 2023, 'CLC', 8.82, 4.63, 7.85, 7.5 FROM DUAL UNION ALL
	SELECT 'S20027', 'V50032', '530001', '2', 2023, 'CLC', 8.76, 7.15, 6.63, 7.37 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50032', '530001', '2', 2023, 'CLC', 6.41, 5.63, 5.71, 5.9 FROM DUAL UNION ALL
	SELECT 'S20106', 'V50032', '530001', '2', 2023, 'CLC', 7.42, 5.18, 5.27, 5.9 FROM DUAL UNION ALL
	SELECT 'S20109', 'V50032', '530001', '2', 2023, 'CLC', 5.4, 7.95, 7.05, 6.73 FROM DUAL UNION ALL
	SELECT 'S20090', 'V50032', '530001', '2', 2023, 'CLC', 5.6, 6.8, 6.08, 6.08 FROM DUAL UNION ALL
	SELECT 'S20049', 'V50032', '530001', '2', 2023, 'CLC', 9.59, 5.55, 5.08, 6.53 FROM DUAL UNION ALL
	SELECT 'S20107', 'V50032', '530001', '2', 2023, 'CLC', 6.94, 5.61, 6.53, 6.47 FROM DUAL UNION ALL
	SELECT 'S20050', 'V50032', '530001', '2', 2023, 'CLC', 9.21, 6.6, 6.43, 7.3 FROM DUAL UNION ALL
	SELECT 'S20067', 'V50032', '530001', '2', 2023, 'CLC', 4.3, 5.86, 9.31, 7.12 FROM DUAL UNION ALL
	SELECT 'S20108', 'V50032', '530001', '2', 2023, 'CLC', 4.77, 7.55, 5.13, 5.51 FROM DUAL UNION ALL
	SELECT 'S20030', 'V50032', '530001', '2', 2023, 'CLC', 7.59, 7.5, 9.71, 8.63 FROM DUAL UNION ALL
	SELECT 'S20070', 'V50032', '530001', '2', 2023, 'CLC', 4.9, 7.76, 6.3, 6.17 FROM DUAL UNION ALL
	SELECT 'S20086', 'V50032', '530001', '2', 2023, 'CLC', 4.96, 4.1, 6.62, 5.62 FROM DUAL UNION ALL
	SELECT 'S20068', 'V50032', '530001', '2', 2023, 'CLC', 9.25, 5.62, 8.71, 8.25 FROM DUAL UNION ALL
	SELECT 'S20010', 'V50032', '530001', '2', 2023, 'CLC', 8.9, 6.73, 5.62, 6.83 FROM DUAL UNION ALL
	SELECT 'S20008', 'V50032', '530001', '2', 2023, 'CLC', 8.5, 8.31, 5.66, 7.04 FROM DUAL UNION ALL
	SELECT 'S20087', 'V50032', '530001', '2', 2023, 'CLC', 7.36, 7.53, 7.17, 7.3 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50032', '530001', '2', 2023, 'CLC', 7.06, 8.68, 9.44, 8.57 FROM DUAL UNION ALL
	SELECT 'S40020', 'V50039', '510004', '2', 2023, 'VP', 4.7, 4.57, 9.82, 7.23 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50039', '510004', '2', 2023, 'VP', 9.82, 7.09, 8.44, 8.58 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50039', '510004', '2', 2023, 'VP', 6.26, 5.09, 9.95, 7.87 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50039', '510004', '2', 2023, 'VP', 4.34, 5.38, 4.12, 4.44 FROM DUAL UNION ALL
	SELECT 'S40016', 'V50039', '510004', '2', 2023, 'VP', 4.22, 9.42, 6.84, 6.57 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50039', '510004', '2', 2023, 'VP', 6.58, 9.28, 7.99, 7.83 FROM DUAL UNION ALL
	SELECT 'S40057', 'V50039', '510004', '2', 2023, 'VP', 9.72, 9.05, 7.01, 8.23 FROM DUAL UNION ALL
	SELECT 'S40060', 'V50039', '510004', '2', 2023, 'VP', 6.19, 9.42, 8.79, 8.14 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50039', '510004', '2', 2023, 'VP', 4.04, 4.63, 4.54, 4.41 FROM DUAL UNION ALL
	SELECT 'S40120', 'V50039', '510004', '2', 2023, 'VP', 8.9, 7.62, 8.95, 8.67 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50039', '510004', '2', 2023, 'VP', 8.05, 5.86, 7.43, 7.3 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50039', '510004', '2', 2023, 'VP', 4.51, 5.86, 4.9, 4.98 FROM DUAL UNION ALL
	SELECT 'S40076', 'V50039', '510004', '2', 2023, 'VP', 5.0, 9.53, 8.58, 7.7 FROM DUAL UNION ALL
	SELECT 'S40059', 'V50039', '510004', '2', 2023, 'VP', 7.65, 8.98, 4.57, 6.38 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50039', '510004', '2', 2023, 'VP', 9.52, 4.42, 7.49, 7.48 FROM DUAL UNION ALL
	SELECT 'S40039', 'V50039', '510004', '2', 2023, 'VP', 6.9, 7.93, 7.4, 7.36 FROM DUAL UNION ALL
	SELECT 'S40080', 'V50039', '510004', '2', 2023, 'VP', 8.07, 4.64, 7.96, 7.33 FROM DUAL UNION ALL
	SELECT 'S40099', 'V50039', '510004', '2', 2023, 'VP', 9.32, 4.52, 9.02, 8.21 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50039', '510004', '2', 2023, 'VP', 5.71, 5.99, 5.08, 5.45 FROM DUAL UNION ALL
	SELECT 'S40077', 'V50039', '510004', '2', 2023, 'VP', 4.2, 8.51, 9.97, 7.95 FROM DUAL UNION ALL
	SELECT 'S40036', 'V50039', '510004', '2', 2023, 'VP', 7.15, 5.98, 9.19, 7.94 FROM DUAL UNION ALL
	SELECT 'S40116', 'V50039', '510004', '2', 2023, 'VP', 8.33, 5.15, 6.77, 6.91 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S20029', 'V50080', '530002', '3', 2023, 'CLC', 5.37, 7.24, 7.96, 7.04 FROM DUAL UNION ALL
	SELECT 'S20067', 'V50080', '530002', '3', 2023, 'CLC', 8.41, 5.81, 9.49, 8.43 FROM DUAL UNION ALL
	SELECT 'S20088', 'V50080', '530002', '3', 2023, 'CLC', 5.98, 6.84, 4.47, 5.4 FROM DUAL UNION ALL
	SELECT 'S20090', 'V50080', '530002', '3', 2023, 'CLC', 9.66, 8.53, 5.72, 7.46 FROM DUAL UNION ALL
	SELECT 'S20068', 'V50080', '530002', '3', 2023, 'CLC', 9.1, 5.94, 4.16, 6.0 FROM DUAL UNION ALL
	SELECT 'S20106', 'V50080', '530002', '3', 2023, 'CLC', 4.42, 7.2, 5.54, 5.54 FROM DUAL UNION ALL
	SELECT 'S20006', 'V50080', '530002', '3', 2023, 'CLC', 9.42, 8.34, 8.39, 8.69 FROM DUAL UNION ALL
	SELECT 'S20107', 'V50080', '530002', '3', 2023, 'CLC', 6.73, 8.59, 7.95, 7.71 FROM DUAL UNION ALL
	SELECT 'S20008', 'V50080', '530002', '3', 2023, 'CLC', 9.23, 5.85, 6.37, 7.12 FROM DUAL UNION ALL
	SELECT 'S20086', 'V50080', '530002', '3', 2023, 'CLC', 9.89, 4.36, 6.83, 7.25 FROM DUAL UNION ALL
	SELECT 'S20066', 'V50080', '530002', '3', 2023, 'CLC', 6.89, 9.1, 9.31, 8.54 FROM DUAL UNION ALL
	SELECT 'S20010', 'V50080', '530002', '3', 2023, 'CLC', 9.55, 6.6, 9.69, 9.03 FROM DUAL UNION ALL
	SELECT 'S20110', 'V50080', '530002', '3', 2023, 'CLC', 8.04, 9.71, 8.94, 8.82 FROM DUAL UNION ALL
	SELECT 'S20009', 'V50080', '530002', '3', 2023, 'CLC', 5.46, 5.2, 5.34, 5.35 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50080', '530002', '3', 2023, 'CLC', 9.7, 9.04, 8.12, 8.78 FROM DUAL UNION ALL
	SELECT 'S40076', 'V50031', '520003', '3', 2023, 'VP', 5.05, 5.84, 9.07, 7.22 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50031', '520003', '3', 2023, 'VP', 9.21, 6.72, 5.67, 6.94 FROM DUAL UNION ALL
	SELECT 'S40016', 'V50031', '520003', '3', 2023, 'VP', 7.19, 7.19, 7.74, 7.46 FROM DUAL UNION ALL
	SELECT 'S40036', 'V50031', '520003', '3', 2023, 'VP', 7.71, 8.63, 9.93, 9.0 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50031', '520003', '3', 2023, 'VP', 4.09, 5.34, 9.94, 7.26 FROM DUAL UNION ALL
	SELECT 'S40037', 'V50031', '520003', '3', 2023, 'VP', 9.44, 5.72, 7.66, 7.81 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50031', '520003', '3', 2023, 'VP', 4.98, 8.28, 7.23, 6.77 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50031', '520003', '3', 2023, 'VP', 7.13, 9.48, 7.61, 7.84 FROM DUAL UNION ALL
	SELECT 'S40077', 'V50031', '520003', '3', 2023, 'VP', 6.95, 4.09, 6.12, 5.96 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50031', '520003', '3', 2023, 'VP', 7.17, 4.49, 7.01, 6.55 FROM DUAL UNION ALL
	SELECT 'S40059', 'V50031', '520003', '3', 2023, 'VP', 5.12, 9.77, 5.68, 6.33 FROM DUAL UNION ALL
	SELECT 'S40098', 'V50031', '520003', '3', 2023, 'VP', 7.68, 7.85, 8.35, 8.05 FROM DUAL UNION ALL
	SELECT 'S40060', 'V50031', '520003', '3', 2023, 'VP', 5.51, 4.57, 7.95, 6.54 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50031', '520003', '3', 2023, 'VP', 5.36, 9.42, 5.15, 6.07 FROM DUAL UNION ALL
	SELECT 'S40019', 'V50031', '520003', '3', 2023, 'VP', 8.27, 7.77, 6.71, 7.39 FROM DUAL UNION ALL
	SELECT 'S40057', 'V50031', '520003', '3', 2023, 'VP', 8.76, 5.71, 9.9, 8.72 FROM DUAL UNION ALL
	SELECT 'S40020', 'V50031', '520003', '3', 2023, 'VP', 5.51, 5.42, 7.14, 6.31 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50031', '520003', '3', 2023, 'VP', 9.56, 9.94, 8.56, 9.14 FROM DUAL UNION ALL
	SELECT 'S20009', 'V50080', '530003', '3', 2023, 'CLC', 7.39, 9.65, 6.94, 7.62 FROM DUAL UNION ALL
	SELECT 'S20007', 'V50080', '530003', '3', 2023, 'CLC', 5.54, 5.14, 5.86, 5.62 FROM DUAL UNION ALL
	SELECT 'S20028', 'V50080', '530003', '3', 2023, 'CLC', 4.26, 9.26, 6.06, 6.16 FROM DUAL UNION ALL
	SELECT 'S20049', 'V50080', '530003', '3', 2023, 'CLC', 7.35, 4.07, 8.93, 7.48 FROM DUAL UNION ALL
	SELECT 'S20089', 'V50080', '530003', '3', 2023, 'CLC', 4.9, 9.89, 6.33, 6.61 FROM DUAL UNION ALL
	SELECT 'S20070', 'V50080', '530003', '3', 2023, 'CLC', 8.49, 6.95, 9.94, 8.91 FROM DUAL UNION ALL
	SELECT 'S20110', 'V50080', '530003', '3', 2023, 'CLC', 4.32, 4.33, 7.47, 5.9 FROM DUAL UNION ALL
	SELECT 'S20109', 'V50080', '530003', '3', 2023, 'CLC', 6.05, 8.8, 5.47, 6.31 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50080', '530003', '3', 2023, 'CLC', 4.0, 7.66, 8.14, 6.8 FROM DUAL UNION ALL
	SELECT 'S20106', 'V50080', '530003', '3', 2023, 'CLC', 7.89, 7.24, 9.13, 8.38 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50080', '530003', '3', 2023, 'CLC', 9.82, 7.71, 8.81, 8.89 FROM DUAL UNION ALL
	SELECT 'S20026', 'V50080', '530003', '3', 2023, 'CLC', 6.87, 5.25, 4.34, 5.28 FROM DUAL UNION ALL
	SELECT 'S20046', 'V50080', '530003', '3', 2023, 'CLC', 4.45, 9.42, 4.43, 5.43 FROM DUAL UNION ALL
	SELECT 'S20108', 'V50080', '530003', '3', 2023, 'CLC', 4.8, 9.32, 8.19, 7.4 FROM DUAL UNION ALL
	SELECT 'S20029', 'V50080', '530003', '3', 2023, 'CLC', 7.09, 7.46, 9.01, 8.12 FROM DUAL UNION ALL
	SELECT 'S20027', 'V50080', '530003', '3', 2023, 'CLC', 7.38, 8.79, 5.46, 6.7 FROM DUAL UNION ALL
	SELECT 'S20050', 'V50080', '530003', '3', 2023, 'CLC', 5.8, 9.44, 9.48, 8.37 FROM DUAL UNION ALL
	SELECT 'S20107', 'V50080', '530003', '3', 2023, 'CLC', 6.2, 5.03, 8.2, 6.97 FROM DUAL UNION ALL
	SELECT 'S20008', 'V50080', '530003', '3', 2023, 'CLC', 9.39, 6.97, 7.41, 7.92 FROM DUAL UNION ALL
	SELECT 'S20048', 'V50080', '530003', '3', 2023, 'CLC', 5.7, 5.73, 6.17, 5.94 FROM DUAL UNION ALL
	SELECT 'S20088', 'V50080', '530003', '3', 2023, 'CLC', 5.24, 5.99, 4.84, 5.19 FROM DUAL UNION ALL
	SELECT 'S20067', 'V50080', '530003', '3', 2023, 'CLC', 4.97, 6.03, 8.89, 7.14 FROM DUAL UNION ALL
	SELECT 'S20006', 'V50080', '530003', '3', 2023, 'CLC', 5.91, 6.43, 9.66, 7.89 FROM DUAL UNION ALL
	SELECT 'S20010', 'V50080', '530003', '3', 2023, 'CLC', 4.6, 5.71, 7.27, 6.16 FROM DUAL UNION ALL
	SELECT 'S20087', 'V50080', '530003', '3', 2023, 'CLC', 4.72, 6.92, 7.98, 6.79 FROM DUAL UNION ALL
	SELECT 'S20086', 'V50080', '530003', '3', 2023, 'CLC', 7.33, 8.33, 7.83, 7.78 FROM DUAL UNION ALL
	SELECT 'S20066', 'V50080', '530003', '3', 2023, 'CLC', 5.36, 6.55, 5.72, 5.78 FROM DUAL UNION ALL
	SELECT 'S10041', 'V50034', '510008', '3', 2023, 'CQ', 9.71, 9.33, 9.7, 9.63 FROM DUAL UNION ALL
	SELECT 'S10101', 'V50034', '510008', '3', 2023, 'CQ', 6.64, 8.51, 8.75, 8.07 FROM DUAL UNION ALL
	SELECT 'S10003', 'V50034', '510008', '3', 2023, 'CQ', 7.08, 4.83, 5.02, 5.6 FROM DUAL UNION ALL
	SELECT 'S10025', 'V50034', '510008', '3', 2023, 'CQ', 4.36, 9.6, 5.78, 6.12 FROM DUAL UNION ALL
	SELECT 'S10045', 'V50034', '510008', '3', 2023, 'CQ', 9.42, 4.02, 6.39, 6.82 FROM DUAL UNION ALL
	SELECT 'S10065', 'V50034', '510008', '3', 2023, 'CQ', 5.42, 6.83, 5.97, 5.98 FROM DUAL UNION ALL
	SELECT 'S20008', 'V50080', '520004', '3', 2023, 'CLC', 7.27, 7.22, 9.28, 8.26 FROM DUAL UNION ALL
	SELECT 'S20028', 'V50080', '520004', '3', 2023, 'CLC', 6.45, 5.01, 7.56, 6.72 FROM DUAL UNION ALL
	SELECT 'S20010', 'V50080', '520004', '3', 2023, 'CLC', 5.79, 6.27, 4.38, 5.18 FROM DUAL UNION ALL
	SELECT 'S20067', 'V50080', '520004', '3', 2023, 'CLC', 5.99, 8.47, 6.99, 6.99 FROM DUAL UNION ALL
	SELECT 'S20069', 'V50080', '520004', '3', 2023, 'CLC', 7.86, 4.96, 9.26, 7.98 FROM DUAL UNION ALL
	SELECT 'S20047', 'V50080', '520004', '3', 2023, 'CLC', 4.1, 5.7, 6.57, 5.66 FROM DUAL UNION ALL
	SELECT 'S20009', 'V50080', '520004', '3', 2023, 'CLC', 8.91, 9.56, 4.59, 6.88 FROM DUAL UNION ALL
	SELECT 'S20109', 'V50080', '520004', '3', 2023, 'CLC', 4.08, 8.28, 6.53, 6.14 FROM DUAL UNION ALL
	SELECT 'S20089', 'V50080', '520004', '3', 2023, 'CLC', 4.81, 4.48, 7.42, 6.05 FROM DUAL UNION ALL
	SELECT 'S20070', 'V50080', '520004', '3', 2023, 'CLC', 7.79, 9.44, 4.56, 6.5 FROM DUAL UNION ALL
	SELECT 'S20088', 'V50080', '520004', '3', 2023, 'CLC', 4.48, 9.67, 5.12, 5.84 FROM DUAL UNION ALL
	SELECT 'S20030', 'V50080', '520004', '3', 2023, 'CLC', 7.91, 5.63, 8.99, 7.99 FROM DUAL UNION ALL
	SELECT 'S20048', 'V50080', '520004', '3', 2023, 'CLC', 7.89, 7.33, 8.1, 7.88 FROM DUAL UNION ALL
	SELECT 'S20006', 'V50080', '520004', '3', 2023, 'CLC', 8.8, 7.87, 6.38, 7.4 FROM DUAL UNION ALL
	SELECT 'S20007', 'V50080', '520004', '3', 2023, 'CLC', 9.15, 8.97, 6.18, 7.63 FROM DUAL UNION ALL
	SELECT 'S20029', 'V50080', '520004', '3', 2023, 'CLC', 5.07, 9.55, 9.81, 8.34 FROM DUAL UNION ALL
	SELECT 'S40056', 'V50037', '510001', '3', 2023, 'VP', 9.83, 7.39, 8.34, 8.6 FROM DUAL UNION ALL
	SELECT 'S40117', 'V50037', '510001', '3', 2023, 'VP', 9.83, 9.87, 8.94, 9.39 FROM DUAL UNION ALL
	SELECT 'S40040', 'V50037', '510001', '3', 2023, 'VP', 5.88, 7.07, 7.31, 6.83 FROM DUAL UNION ALL
	SELECT 'S40038', 'V50037', '510001', '3', 2023, 'VP', 4.94, 5.26, 9.23, 7.15 FROM DUAL UNION ALL
	SELECT 'S40017', 'V50037', '510001', '3', 2023, 'VP', 9.19, 9.69, 4.27, 6.83 FROM DUAL UNION ALL
	SELECT 'S40100', 'V50037', '510001', '3', 2023, 'VP', 7.94, 9.83, 5.0, 6.85 FROM DUAL UNION ALL
	SELECT 'S40079', 'V50037', '510001', '3', 2023, 'VP', 6.22, 6.73, 5.75, 6.09 FROM DUAL UNION ALL
	SELECT 'S40096', 'V50037', '510001', '3', 2023, 'VP', 8.58, 8.12, 9.57, 8.98 FROM DUAL UNION ALL
	SELECT 'S40116', 'V50037', '510001', '3', 2023, 'VP', 6.3, 7.72, 8.48, 7.67 FROM DUAL UNION ALL
	SELECT 'S40076', 'V50037', '510001', '3', 2023, 'VP', 7.68, 9.3, 6.2, 7.26 FROM DUAL UNION ALL
	SELECT 'S40097', 'V50037', '510001', '3', 2023, 'VP', 4.95, 7.47, 5.89, 5.92 FROM DUAL UNION ALL
	SELECT 'S40039', 'V50037', '510001', '3', 2023, 'VP', 6.31, 6.5, 9.99, 8.19 FROM DUAL UNION ALL
	SELECT 'S40099', 'V50037', '510001', '3', 2023, 'VP', 4.23, 8.72, 9.38, 7.7 FROM DUAL UNION ALL
	SELECT 'S40120', 'V50037', '510001', '3', 2023, 'VP', 4.96, 7.84, 4.51, 5.31 FROM DUAL UNION ALL
	SELECT 'S40036', 'V50037', '510001', '3', 2023, 'VP', 7.9, 4.5, 4.08, 5.31 FROM DUAL UNION ALL
	SELECT 'S40016', 'V50037', '510001', '3', 2023, 'VP', 4.81, 4.76, 5.27, 5.03 FROM DUAL UNION ALL
	SELECT 'S40060', 'V50037', '510001', '3', 2023, 'VP', 6.02, 7.89, 9.55, 8.16 FROM DUAL UNION ALL
	SELECT 'S40058', 'V50037', '510001', '3', 2023, 'VP', 5.02, 9.57, 7.22, 7.03 FROM DUAL UNION ALL
	SELECT 'S40018', 'V50037', '510001', '3', 2023, 'VP', 4.2, 7.15, 9.93, 7.66 FROM DUAL UNION ALL
	SELECT 'S40037', 'V50037', '510001', '3', 2023, 'VP', 4.53, 5.55, 5.88, 5.41 FROM DUAL UNION ALL
	SELECT 'S40118', 'V50037', '510001', '3', 2023, 'VP', 7.68, 4.93, 8.4, 7.49 FROM DUAL UNION ALL
	SELECT 'S40078', 'V50037', '510001', '3', 2023, 'VP', 8.0, 7.52, 6.71, 7.26 FROM DUAL UNION ALL
	SELECT 'S40119', 'V50037', '510001', '3', 2023, 'VP', 6.56, 5.22, 8.05, 7.04 FROM DUAL UNION ALL
	SELECT 'S40098', 'V50037', '510001', '3', 2023, 'VP', 7.28, 8.21, 5.17, 6.41 FROM DUAL UNION ALL
	SELECT 'S40020', 'V50037', '510001', '3', 2023, 'VP', 9.1, 8.78, 5.9, 7.44 FROM DUAL UNION ALL
	SELECT 'S40057', 'V50037', '510001', '3', 2023, 'VP', 4.58, 9.27, 5.51, 5.98 FROM DUAL;
INSERT INTO DANGKY
--6. BO MON TGMT
--	2023 - HOC KY 1
	SELECT 'S20087', 'V60045', '610003', '1', 2023, 'CLC', 7.28, 5.14, 4.47, 5.45 FROM DUAL UNION ALL
	SELECT 'S20046', 'V60045', '610003', '1', 2023, 'CLC', 4.31, 9.75, 9.65, 8.07 FROM DUAL UNION ALL
	SELECT 'S20086', 'V60045', '610003', '1', 2023, 'CLC', 8.6, 4.94, 5.68, 6.41 FROM DUAL UNION ALL
	SELECT 'S20068', 'V60045', '610003', '1', 2023, 'CLC', 7.03, 8.53, 5.5, 6.56 FROM DUAL UNION ALL
	SELECT 'S20026', 'V60045', '610003', '1', 2023, 'CLC', 6.85, 5.46, 4.14, 5.22 FROM DUAL UNION ALL
	SELECT 'S20006', 'V60045', '610003', '1', 2023, 'CLC', 5.32, 5.52, 4.16, 4.78 FROM DUAL UNION ALL
	SELECT 'S20030', 'V60045', '610003', '1', 2023, 'CLC', 8.86, 7.36, 8.0, 8.13 FROM DUAL UNION ALL
	SELECT 'S20028', 'V60045', '610003', '1', 2023, 'CLC', 4.77, 5.41, 6.12, 5.57 FROM DUAL UNION ALL
	SELECT 'S20007', 'V60045', '610003', '1', 2023, 'CLC', 6.95, 8.59, 5.29, 6.45 FROM DUAL UNION ALL
	SELECT 'S20050', 'V60045', '610003', '1', 2023, 'CLC', 9.56, 8.6, 9.2, 9.19 FROM DUAL UNION ALL
	SELECT 'S20070', 'V60045', '610003', '1', 2023, 'CLC', 7.91, 9.61, 5.55, 7.07 FROM DUAL UNION ALL
	SELECT 'S20108', 'V60045', '610003', '1', 2023, 'CLC', 7.18, 9.65, 4.16, 6.16 FROM DUAL UNION ALL
	SELECT 'S20109', 'V60045', '610003', '1', 2023, 'CLC', 5.01, 4.77, 5.11, 5.01 FROM DUAL UNION ALL
	SELECT 'S20107', 'V60045', '610003', '1', 2023, 'CLC', 4.33, 8.25, 7.86, 6.88 FROM DUAL UNION ALL
	SELECT 'S20048', 'V60045', '610003', '1', 2023, 'CLC', 5.76, 7.94, 8.43, 7.53 FROM DUAL UNION ALL
	SELECT 'S20049', 'V60045', '610003', '1', 2023, 'CLC', 9.56, 7.34, 9.63, 9.15 FROM DUAL UNION ALL
	SELECT 'S20090', 'V60045', '610003', '1', 2023, 'CLC', 7.45, 5.04, 9.54, 8.01 FROM DUAL UNION ALL
	SELECT 'S20066', 'V60045', '610003', '1', 2023, 'CLC', 7.08, 8.03, 9.49, 8.47 FROM DUAL UNION ALL
	SELECT 'S20009', 'V60045', '610003', '1', 2023, 'CLC', 8.5, 5.41, 4.61, 5.94 FROM DUAL UNION ALL
	SELECT 'S20010', 'V60045', '610003', '1', 2023, 'CLC', 6.2, 9.67, 6.33, 6.96 FROM DUAL UNION ALL
	SELECT 'S20029', 'V60045', '610003', '1', 2023, 'CLC', 7.46, 9.06, 5.41, 6.76 FROM DUAL UNION ALL
	SELECT 'S20089', 'V60045', '610003', '1', 2023, 'CLC', 7.92, 4.59, 8.8, 7.69 FROM DUAL UNION ALL
	SELECT 'S20008', 'V60045', '610003', '1', 2023, 'CLC', 7.0, 8.7, 4.29, 5.98 FROM DUAL UNION ALL
	SELECT 'S20067', 'V60045', '610003', '1', 2023, 'CLC', 4.53, 8.73, 7.16, 6.69 FROM DUAL UNION ALL
	SELECT 'S20106', 'V60045', '610003', '1', 2023, 'CLC', 6.8, 9.6, 9.21, 8.57 FROM DUAL UNION ALL
	SELECT 'S30012', 'V60044', '610002', '1', 2023, 'CTTT', 7.75, 7.19, 6.28, 6.9 FROM DUAL UNION ALL
	SELECT 'S30113', 'V60044', '610002', '1', 2023, 'CTTT', 7.26, 7.82, 7.84, 7.66 FROM DUAL UNION ALL
	SELECT 'S30075', 'V60044', '610002', '1', 2023, 'CTTT', 9.01, 4.12, 6.75, 6.9 FROM DUAL UNION ALL
	SELECT 'S30095', 'V60044', '610002', '1', 2023, 'CTTT', 4.36, 6.13, 4.45, 4.76 FROM DUAL UNION ALL
	SELECT 'S30031', 'V60044', '610002', '1', 2023, 'CTTT', 5.49, 9.85, 5.69, 6.46 FROM DUAL UNION ALL
	SELECT 'S10081', 'V60046', '610004', '1', 2023, 'CQ', 7.71, 9.66, 5.24, 6.87 FROM DUAL UNION ALL
	SELECT 'S10042', 'V60046', '610004', '1', 2023, 'CQ', 7.65, 7.1, 6.76, 7.09 FROM DUAL UNION ALL
	SELECT 'S10023', 'V60046', '610004', '1', 2023, 'CQ', 5.95, 6.32, 9.68, 7.89 FROM DUAL UNION ALL
	SELECT 'S10025', 'V60046', '610004', '1', 2023, 'CQ', 8.72, 5.08, 7.26, 7.26 FROM DUAL UNION ALL
	SELECT 'S10003', 'V60046', '610004', '1', 2023, 'CQ', 5.96, 6.11, 4.64, 5.33 FROM DUAL UNION ALL
	SELECT 'S10084', 'V60046', '610004', '1', 2023, 'CQ', 6.02, 4.67, 8.5, 6.99 FROM DUAL UNION ALL
	SELECT 'S10025', 'V60044', '620001', '1', 2023, 'CQ', 4.45, 6.19, 4.43, 4.79 FROM DUAL UNION ALL
	SELECT 'S10062', 'V60044', '620001', '1', 2023, 'CQ', 5.7, 9.15, 8.77, 7.92 FROM DUAL UNION ALL
	SELECT 'S10022', 'V60044', '620001', '1', 2023, 'CQ', 8.36, 7.96, 4.75, 6.47 FROM DUAL UNION ALL
	SELECT 'S10105', 'V60044', '620001', '1', 2023, 'CQ', 6.54, 4.71, 4.73, 5.27 FROM DUAL UNION ALL
	SELECT 'S10065', 'V60044', '620001', '1', 2023, 'CQ', 6.94, 4.39, 9.29, 7.6 FROM DUAL UNION ALL
	SELECT 'S10042', 'V60044', '620001', '1', 2023, 'CQ', 8.21, 7.5, 4.15, 6.04 FROM DUAL UNION ALL
	SELECT 'S10045', 'V60044', '620001', '1', 2023, 'CQ', 9.43, 7.83, 4.14, 6.46 FROM DUAL UNION ALL
	SELECT 'S10004', 'V60044', '620001', '1', 2023, 'CQ', 9.18, 7.38, 6.32, 7.39 FROM DUAL UNION ALL
	SELECT 'S10002', 'V60044', '620001', '1', 2023, 'CQ', 5.75, 8.11, 7.06, 6.88 FROM DUAL UNION ALL
	SELECT 'S10003', 'V60044', '620001', '1', 2023, 'CQ', 7.84, 4.87, 6.42, 6.54 FROM DUAL UNION ALL
	SELECT 'S10041', 'V60044', '620001', '1', 2023, 'CQ', 5.49, 7.68, 6.99, 6.68 FROM DUAL UNION ALL
	SELECT 'S10005', 'V60044', '620001', '1', 2023, 'CQ', 4.32, 4.15, 5.25, 4.75 FROM DUAL UNION ALL
	SELECT 'S10103', 'V60044', '620001', '1', 2023, 'CQ', 4.31, 7.43, 4.7, 5.13 FROM DUAL UNION ALL
	SELECT 'S10044', 'V60044', '620001', '1', 2023, 'CQ', 7.81, 7.71, 5.13, 6.45 FROM DUAL UNION ALL
	SELECT 'S10104', 'V60044', '620001', '1', 2023, 'CQ', 5.68, 5.34, 7.36, 6.45 FROM DUAL UNION ALL
	SELECT 'S10063', 'V60044', '620001', '1', 2023, 'CQ', 5.89, 4.94, 5.37, 5.44 FROM DUAL UNION ALL
	SELECT 'S10102', 'V60044', '620001', '1', 2023, 'CQ', 8.88, 9.55, 9.18, 9.16 FROM DUAL UNION ALL
	SELECT 'S10021', 'V60044', '620001', '1', 2023, 'CQ', 5.66, 7.54, 7.69, 7.05 FROM DUAL UNION ALL
	SELECT 'S10085', 'V60044', '620001', '1', 2023, 'CQ', 6.21, 4.74, 7.3, 6.46 FROM DUAL UNION ALL
	SELECT 'S10001', 'V60044', '620001', '1', 2023, 'CQ', 5.05, 8.69, 7.45, 6.98 FROM DUAL UNION ALL
	SELECT 'S10043', 'V60044', '620001', '1', 2023, 'CQ', 8.89, 4.03, 5.06, 6.0 FROM DUAL UNION ALL
	SELECT 'S40077', 'V60049', '620006', '1', 2023, 'VP', 9.8, 5.53, 6.32, 7.21 FROM DUAL UNION ALL
	SELECT 'S40078', 'V60049', '620006', '1', 2023, 'VP', 8.85, 6.1, 7.07, 7.41 FROM DUAL UNION ALL
	SELECT 'S40036', 'V60049', '620006', '1', 2023, 'VP', 8.65, 6.16, 6.15, 6.9 FROM DUAL UNION ALL
	SELECT 'S40118', 'V60049', '620006', '1', 2023, 'VP', 8.49, 8.86, 4.28, 6.46 FROM DUAL UNION ALL
	SELECT 'S40020', 'V60049', '620006', '1', 2023, 'VP', 9.46, 5.54, 6.16, 7.03 FROM DUAL UNION ALL
	SELECT 'S40100', 'V60049', '620006', '1', 2023, 'VP', 7.07, 5.16, 5.2, 5.75 FROM DUAL UNION ALL
	SELECT 'S40057', 'V60049', '620006', '1', 2023, 'VP', 7.31, 6.21, 5.91, 6.39 FROM DUAL UNION ALL
	SELECT 'S40117', 'V60049', '620006', '1', 2023, 'VP', 9.34, 9.25, 5.2, 7.25 FROM DUAL UNION ALL
	SELECT 'S40038', 'V60049', '620006', '1', 2023, 'VP', 5.92, 8.69, 5.03, 6.03 FROM DUAL UNION ALL
	SELECT 'S40059', 'V60049', '620006', '1', 2023, 'VP', 9.82, 9.75, 8.2, 9.0 FROM DUAL UNION ALL
	SELECT 'S40119', 'V60049', '620006', '1', 2023, 'VP', 6.69, 8.88, 5.65, 6.61 FROM DUAL UNION ALL
	SELECT 'S40080', 'V60049', '620006', '1', 2023, 'VP', 8.59, 5.98, 6.11, 6.83 FROM DUAL UNION ALL
	SELECT 'S40120', 'V60049', '620006', '1', 2023, 'VP', 8.67, 4.32, 6.66, 6.79 FROM DUAL UNION ALL
	SELECT 'S40099', 'V60049', '620006', '1', 2023, 'VP', 7.83, 5.56, 9.76, 8.34 FROM DUAL UNION ALL
	SELECT 'S40116', 'V60049', '620006', '1', 2023, 'VP', 9.15, 7.52, 7.69, 8.09 FROM DUAL UNION ALL
	SELECT 'S40017', 'V60049', '620006', '1', 2023, 'VP', 6.99, 8.64, 8.54, 8.09 FROM DUAL UNION ALL
	SELECT 'S40019', 'V60049', '620006', '1', 2023, 'VP', 7.32, 7.32, 5.68, 6.5 FROM DUAL UNION ALL
	SELECT 'S40037', 'V60049', '620006', '1', 2023, 'VP', 4.4, 8.49, 8.54, 7.29 FROM DUAL UNION ALL
	SELECT 'S10002', 'V60042', '620002', '1', 2023, 'CQ', 8.77, 6.59, 5.15, 6.52 FROM DUAL UNION ALL
	SELECT 'S10081', 'V60042', '620002', '1', 2023, 'CQ', 4.01, 9.93, 8.96, 7.67 FROM DUAL UNION ALL
	SELECT 'S10024', 'V60042', '620002', '1', 2023, 'CQ', 9.73, 6.69, 7.53, 8.02 FROM DUAL UNION ALL
	SELECT 'S10065', 'V60042', '620002', '1', 2023, 'CQ', 4.09, 7.47, 7.15, 6.3 FROM DUAL UNION ALL
	SELECT 'S10085', 'V60042', '620002', '1', 2023, 'CQ', 4.28, 9.41, 8.19, 7.26 FROM DUAL UNION ALL
	SELECT 'S10001', 'V60042', '620002', '1', 2023, 'CQ', 4.07, 7.02, 8.29, 6.77 FROM DUAL UNION ALL
	SELECT 'S10083', 'V60042', '620002', '1', 2023, 'CQ', 5.38, 8.2, 5.53, 6.02 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S40096', 'V60048', '630003', '2', 2023, 'VP', 6.49, 9.45, 9.56, 8.62 FROM DUAL UNION ALL
	SELECT 'S40098', 'V60048', '630003', '2', 2023, 'VP', 9.64, 5.84, 9.12, 8.62 FROM DUAL UNION ALL
	SELECT 'S40056', 'V60048', '630003', '2', 2023, 'VP', 9.63, 7.54, 5.17, 6.98 FROM DUAL UNION ALL
	SELECT 'S40118', 'V60048', '630003', '2', 2023, 'VP', 8.91, 7.26, 9.57, 8.91 FROM DUAL UNION ALL
	SELECT 'S40040', 'V60048', '630003', '2', 2023, 'VP', 6.3, 4.33, 5.95, 5.73 FROM DUAL UNION ALL
	SELECT 'S40018', 'V60048', '630003', '2', 2023, 'VP', 8.64, 7.24, 4.99, 6.54 FROM DUAL UNION ALL
	SELECT 'S40037', 'V60048', '630003', '2', 2023, 'VP', 7.35, 9.45, 4.86, 6.53 FROM DUAL UNION ALL
	SELECT 'S30091', 'V60049', '620003', '2', 2023, 'CTTT', 5.28, 9.28, 6.22, 6.55 FROM DUAL UNION ALL
	SELECT 'S30012', 'V60049', '620003', '2', 2023, 'CTTT', 7.15, 5.99, 4.86, 5.77 FROM DUAL UNION ALL
	SELECT 'S30092', 'V60049', '620003', '2', 2023, 'CTTT', 4.48, 5.05, 9.82, 7.26 FROM DUAL UNION ALL
	SELECT 'S30094', 'V60049', '620003', '2', 2023, 'CTTT', 4.18, 7.61, 4.38, 4.97 FROM DUAL UNION ALL
	SELECT 'S30031', 'V60049', '620003', '2', 2023, 'CTTT', 8.37, 7.22, 6.76, 7.33 FROM DUAL UNION ALL
	SELECT 'S30093', 'V60049', '620003', '2', 2023, 'CTTT', 9.81, 4.51, 6.46, 7.08 FROM DUAL UNION ALL
	SELECT 'S30053', 'V60049', '620003', '2', 2023, 'CTTT', 5.72, 9.1, 5.78, 6.43 FROM DUAL UNION ALL
	SELECT 'S30072', 'V60049', '620003', '2', 2023, 'CTTT', 6.31, 6.89, 9.89, 8.22 FROM DUAL UNION ALL
	SELECT 'S30011', 'V60049', '620003', '2', 2023, 'CTTT', 4.32, 9.96, 4.43, 5.5 FROM DUAL UNION ALL
	SELECT 'S30055', 'V60049', '620003', '2', 2023, 'CTTT', 5.48, 8.22, 9.12, 7.85 FROM DUAL UNION ALL
	SELECT 'S30071', 'V60049', '620003', '2', 2023, 'CTTT', 4.62, 6.62, 4.98, 5.2 FROM DUAL UNION ALL
	SELECT 'S30115', 'V60049', '620003', '2', 2023, 'CTTT', 4.52, 7.3, 9.77, 7.7 FROM DUAL UNION ALL
	SELECT 'S30051', 'V60049', '620003', '2', 2023, 'CTTT', 8.55, 4.65, 5.71, 6.35 FROM DUAL UNION ALL
	SELECT 'S30114', 'V60049', '620003', '2', 2023, 'CTTT', 4.88, 7.9, 4.6, 5.34 FROM DUAL UNION ALL
	SELECT 'S30113', 'V60049', '620003', '2', 2023, 'CTTT', 5.57, 5.32, 5.44, 5.46 FROM DUAL UNION ALL
	SELECT 'S30074', 'V60049', '620003', '2', 2023, 'CTTT', 4.53, 8.73, 9.49, 7.85 FROM DUAL UNION ALL
	SELECT 'S30014', 'V60049', '620003', '2', 2023, 'CTTT', 6.52, 5.06, 8.5, 7.22 FROM DUAL UNION ALL
	SELECT 'S30075', 'V60049', '620003', '2', 2023, 'CTTT', 9.51, 5.97, 8.1, 8.1 FROM DUAL UNION ALL
	SELECT 'S30013', 'V60049', '620003', '2', 2023, 'CTTT', 6.46, 9.16, 8.35, 7.95 FROM DUAL UNION ALL
	SELECT 'S30033', 'V60049', '620003', '2', 2023, 'CTTT', 7.3, 4.25, 8.94, 7.51 FROM DUAL UNION ALL
	SELECT 'S30032', 'V60049', '620003', '2', 2023, 'CTTT', 6.7, 9.08, 6.68, 7.17 FROM DUAL UNION ALL
	SELECT 'S30034', 'V60049', '620003', '2', 2023, 'CTTT', 6.04, 4.58, 7.42, 6.44 FROM DUAL UNION ALL
	SELECT 'S30111', 'V60049', '620003', '2', 2023, 'CTTT', 4.74, 9.58, 4.65, 5.66 FROM DUAL UNION ALL
	SELECT 'S10023', 'V60042', '620005', '2', 2023, 'CQ', 8.28, 9.27, 8.88, 8.78 FROM DUAL UNION ALL
	SELECT 'S10105', 'V60042', '620005', '2', 2023, 'CQ', 9.7, 5.43, 7.07, 7.53 FROM DUAL UNION ALL
	SELECT 'S10003', 'V60042', '620005', '2', 2023, 'CQ', 4.0, 5.85, 4.94, 4.84 FROM DUAL UNION ALL
	SELECT 'S10084', 'V60042', '620005', '2', 2023, 'CQ', 4.62, 6.67, 9.94, 7.69 FROM DUAL UNION ALL
	SELECT 'S10025', 'V60042', '620005', '2', 2023, 'CQ', 9.22, 5.68, 4.72, 6.26 FROM DUAL UNION ALL
	SELECT 'S10042', 'V60042', '620005', '2', 2023, 'CQ', 5.37, 7.57, 9.17, 7.71 FROM DUAL UNION ALL
	SELECT 'S10004', 'V60042', '620005', '2', 2023, 'CQ', 7.28, 6.13, 4.82, 5.82 FROM DUAL UNION ALL
	SELECT 'S10063', 'V60042', '620005', '2', 2023, 'CQ', 5.26, 4.71, 8.9, 6.97 FROM DUAL UNION ALL
	SELECT 'S10044', 'V60042', '620005', '2', 2023, 'CQ', 6.01, 7.92, 6.31, 6.54 FROM DUAL UNION ALL
	SELECT 'S10045', 'V60042', '620005', '2', 2023, 'CQ', 7.35, 4.52, 5.38, 5.8 FROM DUAL UNION ALL
	SELECT 'S10103', 'V60042', '620005', '2', 2023, 'CQ', 4.19, 5.43, 6.27, 5.48 FROM DUAL UNION ALL
	SELECT 'S10005', 'V60042', '620005', '2', 2023, 'CQ', 4.08, 4.03, 9.89, 6.98 FROM DUAL UNION ALL
	SELECT 'S10062', 'V60042', '620005', '2', 2023, 'CQ', 6.46, 9.88, 7.49, 7.66 FROM DUAL UNION ALL
	SELECT 'S10085', 'V60042', '620005', '2', 2023, 'CQ', 6.02, 7.83, 8.07, 7.41 FROM DUAL UNION ALL
	SELECT 'S10083', 'V60042', '620005', '2', 2023, 'CQ', 8.47, 6.0, 4.26, 5.87 FROM DUAL UNION ALL
	SELECT 'S10064', 'V60042', '620005', '2', 2023, 'CQ', 7.42, 8.18, 4.76, 6.24 FROM DUAL UNION ALL
	SELECT 'S10043', 'V60042', '620005', '2', 2023, 'CQ', 9.74, 9.61, 5.08, 7.38 FROM DUAL UNION ALL
	SELECT 'S10022', 'V60042', '620005', '2', 2023, 'CQ', 9.5, 6.16, 7.7, 7.93 FROM DUAL UNION ALL
	SELECT 'S10024', 'V60042', '620005', '2', 2023, 'CQ', 9.01, 7.26, 7.38, 7.84 FROM DUAL UNION ALL
	SELECT 'S10082', 'V60042', '620005', '2', 2023, 'CQ', 4.74, 9.56, 7.65, 7.16 FROM DUAL UNION ALL
	SELECT 'S10102', 'V60042', '620005', '2', 2023, 'CQ', 6.35, 6.49, 8.55, 7.48 FROM DUAL UNION ALL
	SELECT 'S10041', 'V60042', '620005', '2', 2023, 'CQ', 7.5, 8.45, 4.23, 6.05 FROM DUAL UNION ALL
	SELECT 'S10002', 'V60042', '620005', '2', 2023, 'CQ', 6.16, 9.63, 9.23, 8.39 FROM DUAL UNION ALL
	SELECT 'S10061', 'V60042', '620005', '2', 2023, 'CQ', 8.39, 8.88, 7.62, 8.1 FROM DUAL UNION ALL
	SELECT 'S10001', 'V60042', '620005', '2', 2023, 'CQ', 8.76, 4.46, 6.36, 6.7 FROM DUAL UNION ALL
	SELECT 'S10065', 'V60042', '620005', '2', 2023, 'CQ', 7.92, 5.66, 6.72, 6.87 FROM DUAL UNION ALL
	SELECT 'S10101', 'V60042', '620005', '2', 2023, 'CQ', 4.52, 8.83, 5.53, 5.89 FROM DUAL UNION ALL
	SELECT 'S10025', 'V60044', '630001', '2', 2023, 'CQ', 6.58, 6.26, 4.2, 5.33 FROM DUAL UNION ALL
	SELECT 'S10064', 'V60044', '630001', '2', 2023, 'CQ', 5.15, 4.33, 7.15, 5.99 FROM DUAL UNION ALL
	SELECT 'S10042', 'V60044', '630001', '2', 2023, 'CQ', 7.32, 9.66, 4.68, 6.47 FROM DUAL UNION ALL
	SELECT 'S10044', 'V60044', '630001', '2', 2023, 'CQ', 7.44, 7.12, 5.19, 6.25 FROM DUAL UNION ALL
	SELECT 'S10022', 'V60044', '630001', '2', 2023, 'CQ', 6.68, 4.84, 6.08, 6.01 FROM DUAL UNION ALL
	SELECT 'S10003', 'V60044', '630001', '2', 2023, 'CQ', 5.48, 6.52, 6.38, 6.14 FROM DUAL UNION ALL
	SELECT 'S10083', 'V60044', '630001', '2', 2023, 'CQ', 7.86, 8.37, 7.55, 7.81 FROM DUAL UNION ALL
	SELECT 'S10024', 'V60044', '630001', '2', 2023, 'CQ', 6.78, 5.98, 7.14, 6.8 FROM DUAL UNION ALL
	SELECT 'S10001', 'V60044', '630001', '2', 2023, 'CQ', 9.41, 6.47, 4.37, 6.3 FROM DUAL UNION ALL
	SELECT 'S10005', 'V60044', '630001', '2', 2023, 'CQ', 8.15, 4.68, 4.94, 5.85 FROM DUAL UNION ALL
	SELECT 'S10023', 'V60044', '630001', '2', 2023, 'CQ', 7.05, 6.33, 4.23, 5.5 FROM DUAL UNION ALL
	SELECT 'S10041', 'V60044', '630001', '2', 2023, 'CQ', 4.04, 9.72, 4.08, 5.2 FROM DUAL UNION ALL
	SELECT 'S10085', 'V60044', '630001', '2', 2023, 'CQ', 5.14, 4.78, 6.32, 5.66 FROM DUAL UNION ALL
	SELECT 'S10004', 'V60044', '630001', '2', 2023, 'CQ', 4.89, 8.73, 5.57, 6.0 FROM DUAL UNION ALL
	SELECT 'S10101', 'V60044', '630001', '2', 2023, 'CQ', 9.98, 9.41, 5.91, 7.83 FROM DUAL UNION ALL
	SELECT 'S10082', 'V60044', '630001', '2', 2023, 'CQ', 9.54, 6.3, 6.63, 7.44 FROM DUAL UNION ALL
	SELECT 'S10103', 'V60044', '630001', '2', 2023, 'CQ', 4.08, 5.93, 4.41, 4.62 FROM DUAL UNION ALL
	SELECT 'S10084', 'V60044', '630001', '2', 2023, 'CQ', 9.8, 9.58, 9.39, 9.55 FROM DUAL UNION ALL
	SELECT 'S10021', 'V60044', '630001', '2', 2023, 'CQ', 8.69, 6.81, 6.96, 7.45 FROM DUAL UNION ALL
	SELECT 'S10043', 'V60044', '630001', '2', 2023, 'CQ', 5.11, 8.4, 8.06, 7.24 FROM DUAL UNION ALL
	SELECT 'S10063', 'V60044', '630001', '2', 2023, 'CQ', 8.7, 5.37, 9.16, 8.26 FROM DUAL UNION ALL
	SELECT 'S10081', 'V60044', '630001', '2', 2023, 'CQ', 8.89, 8.85, 8.18, 8.53 FROM DUAL UNION ALL
	SELECT 'S10065', 'V60044', '630001', '2', 2023, 'CQ', 5.41, 6.16, 7.09, 6.4 FROM DUAL UNION ALL
	SELECT 'S10045', 'V60044', '630001', '2', 2023, 'CQ', 9.59, 5.71, 4.86, 6.45 FROM DUAL UNION ALL
	SELECT 'S10061', 'V60044', '630001', '2', 2023, 'CQ', 5.1, 8.85, 7.52, 7.06 FROM DUAL UNION ALL
	SELECT 'S30013', 'V60050', '610001', '2', 2023, 'CTTT', 8.17, 6.41, 5.81, 6.64 FROM DUAL UNION ALL
	SELECT 'S30033', 'V60050', '610001', '2', 2023, 'CTTT', 4.64, 8.74, 7.05, 6.67 FROM DUAL UNION ALL
	SELECT 'S30032', 'V60050', '610001', '2', 2023, 'CTTT', 5.5, 6.34, 6.48, 6.16 FROM DUAL UNION ALL
	SELECT 'S30095', 'V60050', '610001', '2', 2023, 'CTTT', 6.6, 8.15, 6.43, 6.82 FROM DUAL UNION ALL
	SELECT 'S30113', 'V60050', '610001', '2', 2023, 'CTTT', 4.08, 4.84, 5.59, 4.99 FROM DUAL UNION ALL
	SELECT 'S30053', 'V60050', '610001', '2', 2023, 'CTTT', 5.47, 4.25, 4.72, 4.85 FROM DUAL UNION ALL
	SELECT 'S30014', 'V60050', '610001', '2', 2023, 'CTTT', 8.98, 4.38, 4.73, 5.94 FROM DUAL UNION ALL
	SELECT 'S30093', 'V60050', '610001', '2', 2023, 'CTTT', 4.24, 9.21, 6.09, 6.16 FROM DUAL UNION ALL
	SELECT 'S30111', 'V60050', '610001', '2', 2023, 'CTTT', 7.89, 8.51, 4.91, 6.52 FROM DUAL UNION ALL
	SELECT 'S30072', 'V60050', '610001', '2', 2023, 'CTTT', 4.57, 7.69, 6.33, 6.07 FROM DUAL UNION ALL
	SELECT 'S30114', 'V60050', '610001', '2', 2023, 'CTTT', 6.69, 8.23, 5.96, 6.63 FROM DUAL UNION ALL
	SELECT 'S30012', 'V60050', '610001', '2', 2023, 'CTTT', 7.38, 9.01, 7.98, 8.01 FROM DUAL UNION ALL
	SELECT 'S30051', 'V60050', '610001', '2', 2023, 'CTTT', 4.42, 6.42, 9.67, 7.45 FROM DUAL UNION ALL
	SELECT 'S30031', 'V60050', '610001', '2', 2023, 'CTTT', 4.82, 4.31, 5.02, 4.82 FROM DUAL UNION ALL
	SELECT 'S30071', 'V60050', '610001', '2', 2023, 'CTTT', 6.99, 9.02, 8.64, 8.22 FROM DUAL UNION ALL
	SELECT 'S30055', 'V60050', '610001', '2', 2023, 'CTTT', 4.8, 7.09, 6.84, 6.28 FROM DUAL UNION ALL
	SELECT 'S30052', 'V60050', '610001', '2', 2023, 'CTTT', 8.32, 4.66, 7.38, 7.12 FROM DUAL UNION ALL
	SELECT 'S30015', 'V60050', '610001', '2', 2023, 'CTTT', 9.87, 7.0, 8.6, 8.66 FROM DUAL UNION ALL
	SELECT 'S20110', 'V60049', '620004', '2', 2023, 'CLC', 8.71, 6.09, 9.38, 8.52 FROM DUAL UNION ALL
	SELECT 'S20066', 'V60049', '620004', '2', 2023, 'CLC', 5.19, 4.14, 9.86, 7.31 FROM DUAL UNION ALL
	SELECT 'S20029', 'V60049', '620004', '2', 2023, 'CLC', 5.62, 9.5, 9.1, 8.14 FROM DUAL UNION ALL
	SELECT 'S20046', 'V60049', '620004', '2', 2023, 'CLC', 8.31, 4.46, 4.06, 5.41 FROM DUAL UNION ALL
	SELECT 'S20087', 'V60049', '620004', '2', 2023, 'CLC', 4.21, 9.09, 5.83, 6.0 FROM DUAL UNION ALL
	SELECT 'S20007', 'V60049', '620004', '2', 2023, 'CLC', 5.66, 9.02, 9.49, 8.25 FROM DUAL UNION ALL
	SELECT 'S20049', 'V60049', '620004', '2', 2023, 'CLC', 9.74, 8.81, 8.34, 8.85 FROM DUAL UNION ALL
	SELECT 'S20010', 'V60049', '620004', '2', 2023, 'CLC', 7.3, 8.82, 7.89, 7.9 FROM DUAL UNION ALL
	SELECT 'S20109', 'V60049', '620004', '2', 2023, 'CLC', 5.85, 5.27, 4.94, 5.28 FROM DUAL UNION ALL
	SELECT 'S20090', 'V60049', '620004', '2', 2023, 'CLC', 4.91, 9.33, 4.94, 5.81 FROM DUAL UNION ALL
	SELECT 'S20026', 'V60049', '620004', '2', 2023, 'CLC', 6.99, 4.34, 8.53, 7.23 FROM DUAL UNION ALL
	SELECT 'S20108', 'V60049', '620004', '2', 2023, 'CLC', 5.88, 7.37, 9.61, 8.04 FROM DUAL UNION ALL
	SELECT 'S20008', 'V60049', '620004', '2', 2023, 'CLC', 7.55, 9.74, 5.21, 6.82 FROM DUAL UNION ALL
	SELECT 'S20088', 'V60049', '620004', '2', 2023, 'CLC', 9.72, 4.83, 4.98, 6.37 FROM DUAL UNION ALL
	SELECT 'S20070', 'V60049', '620004', '2', 2023, 'CLC', 7.34, 9.32, 6.83, 7.48 FROM DUAL UNION ALL
	SELECT 'S20047', 'V60049', '620004', '2', 2023, 'CLC', 10.0, 6.81, 9.91, 9.32 FROM DUAL UNION ALL
	SELECT 'S20009', 'V60049', '620004', '2', 2023, 'CLC', 4.13, 8.9, 5.14, 5.59 FROM DUAL UNION ALL
	SELECT 'S20086', 'V60049', '620004', '2', 2023, 'CLC', 5.65, 5.48, 5.97, 5.78 FROM DUAL UNION ALL
	SELECT 'S20089', 'V60049', '620004', '2', 2023, 'CLC', 7.76, 8.11, 4.99, 6.45 FROM DUAL UNION ALL
	SELECT 'S20069', 'V60049', '620004', '2', 2023, 'CLC', 7.57, 4.55, 8.66, 7.51 FROM DUAL UNION ALL
	SELECT 'S20107', 'V60049', '620004', '2', 2023, 'CLC', 9.74, 7.17, 5.26, 6.99 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S40076', 'V60041', '610005', '3', 2023, 'VP', 6.36, 8.25, 4.08, 5.6 FROM DUAL UNION ALL
	SELECT 'S40077', 'V60041', '610005', '3', 2023, 'VP', 8.17, 5.3, 4.63, 5.83 FROM DUAL UNION ALL
	SELECT 'S40100', 'V60041', '610005', '3', 2023, 'VP', 4.7, 5.68, 9.92, 7.51 FROM DUAL UNION ALL
	SELECT 'S40019', 'V60041', '610005', '3', 2023, 'VP', 7.51, 9.54, 5.96, 7.14 FROM DUAL UNION ALL
	SELECT 'S40036', 'V60041', '610005', '3', 2023, 'VP', 7.62, 7.7, 5.14, 6.4 FROM DUAL UNION ALL
	SELECT 'S40096', 'V60041', '610005', '3', 2023, 'VP', 4.56, 9.39, 7.98, 7.24 FROM DUAL UNION ALL
	SELECT 'S40060', 'V60041', '610005', '3', 2023, 'VP', 5.45, 6.6, 8.1, 7.0 FROM DUAL UNION ALL
	SELECT 'S40099', 'V60041', '610005', '3', 2023, 'VP', 9.57, 5.21, 5.38, 6.6 FROM DUAL UNION ALL
	SELECT 'S40037', 'V60041', '610005', '3', 2023, 'VP', 6.45, 8.33, 6.53, 6.87 FROM DUAL UNION ALL
	SELECT 'S40117', 'V60041', '610005', '3', 2023, 'VP', 7.91, 9.47, 6.98, 7.76 FROM DUAL UNION ALL
	SELECT 'S40080', 'V60041', '610005', '3', 2023, 'VP', 5.14, 7.8, 8.07, 7.14 FROM DUAL UNION ALL
	SELECT 'S40018', 'V60041', '610005', '3', 2023, 'VP', 8.27, 9.68, 5.18, 7.01 FROM DUAL UNION ALL
	SELECT 'S40098', 'V60041', '610005', '3', 2023, 'VP', 8.14, 9.0, 7.81, 8.15 FROM DUAL UNION ALL
	SELECT 'S40097', 'V60041', '610005', '3', 2023, 'VP', 4.52, 5.76, 5.16, 5.09 FROM DUAL UNION ALL
	SELECT 'S40057', 'V60041', '610005', '3', 2023, 'VP', 9.67, 7.77, 4.0, 6.46 FROM DUAL UNION ALL
	SELECT 'S40020', 'V60041', '610005', '3', 2023, 'VP', 7.57, 5.82, 5.74, 6.3 FROM DUAL UNION ALL
	SELECT 'S40118', 'V60041', '610005', '3', 2023, 'VP', 8.89, 5.97, 8.87, 8.3 FROM DUAL UNION ALL
	SELECT 'S40116', 'V60041', '610005', '3', 2023, 'VP', 4.89, 6.41, 4.48, 4.99 FROM DUAL UNION ALL
	SELECT 'S40038', 'V60041', '610005', '3', 2023, 'VP', 9.81, 7.02, 7.15, 7.92 FROM DUAL UNION ALL
	SELECT 'S40059', 'V60041', '610005', '3', 2023, 'VP', 9.85, 5.96, 8.36, 8.33 FROM DUAL UNION ALL
	SELECT 'S40016', 'V60041', '610005', '3', 2023, 'VP', 5.01, 4.51, 7.42, 6.12 FROM DUAL UNION ALL
	SELECT 'S40040', 'V60041', '610005', '3', 2023, 'VP', 4.53, 5.6, 5.11, 5.03 FROM DUAL UNION ALL
	SELECT 'S40078', 'V60041', '610005', '3', 2023, 'VP', 6.06, 9.81, 4.84, 6.2 FROM DUAL UNION ALL
	SELECT 'S40039', 'V60041', '610005', '3', 2023, 'VP', 4.82, 7.07, 5.28, 5.5 FROM DUAL UNION ALL
	SELECT 'S40017', 'V60041', '610005', '3', 2023, 'VP', 4.24, 5.97, 9.45, 7.19 FROM DUAL UNION ALL
	SELECT 'S40079', 'V60041', '610005', '3', 2023, 'VP', 9.41, 9.27, 9.45, 9.4 FROM DUAL UNION ALL
	SELECT 'S30114', 'V60045', '630002', '3', 2023, 'CTTT', 6.62, 5.16, 6.05, 6.04 FROM DUAL UNION ALL
	SELECT 'S30032', 'V60045', '630002', '3', 2023, 'CTTT', 5.34, 4.45, 4.2, 4.59 FROM DUAL UNION ALL
	SELECT 'S30071', 'V60045', '630002', '3', 2023, 'CTTT', 5.59, 6.15, 6.98, 6.4 FROM DUAL UNION ALL
	SELECT 'S30011', 'V60045', '630002', '3', 2023, 'CTTT', 9.26, 7.19, 4.75, 6.59 FROM DUAL UNION ALL
	SELECT 'S30014', 'V60045', '630002', '3', 2023, 'CTTT', 7.05, 7.44, 8.54, 7.87 FROM DUAL UNION ALL
	SELECT 'S30013', 'V60045', '630002', '3', 2023, 'CTTT', 5.05, 9.97, 5.1, 6.06 FROM DUAL UNION ALL
	SELECT 'S30095', 'V60045', '630002', '3', 2023, 'CTTT', 7.57, 8.84, 5.15, 6.61 FROM DUAL UNION ALL
	SELECT 'S30075', 'V60045', '630002', '3', 2023, 'CTTT', 7.13, 7.44, 4.37, 5.81 FROM DUAL UNION ALL
	SELECT 'S30034', 'V60045', '630002', '3', 2023, 'CTTT', 9.59, 7.56, 8.23, 8.5 FROM DUAL UNION ALL
	SELECT 'S30035', 'V60045', '630002', '3', 2023, 'CTTT', 7.81, 6.44, 9.38, 8.32 FROM DUAL UNION ALL
	SELECT 'S30033', 'V60045', '630002', '3', 2023, 'CTTT', 5.27, 7.85, 4.1, 5.2 FROM DUAL UNION ALL
	SELECT 'S30115', 'V60045', '630002', '3', 2023, 'CTTT', 5.28, 5.65, 5.7, 5.56 FROM DUAL UNION ALL
	SELECT 'S30053', 'V60045', '630002', '3', 2023, 'CTTT', 4.39, 8.12, 6.88, 6.38 FROM DUAL UNION ALL
	SELECT 'S30074', 'V60045', '630002', '3', 2023, 'CTTT', 7.87, 6.13, 4.29, 5.73 FROM DUAL UNION ALL
	SELECT 'S30051', 'V60045', '630002', '3', 2023, 'CTTT', 4.82, 4.13, 5.82, 5.18 FROM DUAL;
INSERT INTO DANGKY
--7. BO MON MMT VA VIEN THONG
--	2023 - HOC KY 1
	SELECT 'S20007', 'V70052', '730002', '1', 2023, 'CLC', 5.0, 5.03, 6.78, 5.9 FROM DUAL UNION ALL
	SELECT 'S20107', 'V70052', '730002', '1', 2023, 'CLC', 5.39, 6.72, 9.33, 7.63 FROM DUAL UNION ALL
	SELECT 'S20028', 'V70052', '730002', '1', 2023, 'CLC', 4.63, 9.91, 7.02, 6.88 FROM DUAL UNION ALL
	SELECT 'S20106', 'V70052', '730002', '1', 2023, 'CLC', 4.02, 4.24, 5.94, 5.02 FROM DUAL UNION ALL
	SELECT 'S20047', 'V70052', '730002', '1', 2023, 'CLC', 8.04, 5.86, 4.59, 5.88 FROM DUAL UNION ALL
	SELECT 'S20109', 'V70052', '730002', '1', 2023, 'CLC', 6.97, 5.06, 4.1, 5.15 FROM DUAL UNION ALL
	SELECT 'S20006', 'V70052', '730002', '1', 2023, 'CLC', 7.56, 8.01, 4.26, 6.0 FROM DUAL UNION ALL
	SELECT 'S30071', 'V70055', '710007', '1', 2023, 'CTTT', 9.22, 4.45, 6.71, 7.01 FROM DUAL UNION ALL
	SELECT 'S30012', 'V70055', '710007', '1', 2023, 'CTTT', 6.22, 9.29, 7.88, 7.66 FROM DUAL UNION ALL
	SELECT 'S30011', 'V70055', '710007', '1', 2023, 'CTTT', 9.06, 4.1, 4.51, 5.79 FROM DUAL UNION ALL
	SELECT 'S30055', 'V70055', '710007', '1', 2023, 'CTTT', 7.12, 6.38, 4.94, 5.88 FROM DUAL UNION ALL
	SELECT 'S30054', 'V70055', '710007', '1', 2023, 'CTTT', 4.79, 8.23, 5.51, 5.84 FROM DUAL UNION ALL
	SELECT 'S30094', 'V70055', '710007', '1', 2023, 'CTTT', 9.73, 6.69, 4.08, 6.3 FROM DUAL UNION ALL
	SELECT 'S30091', 'V70055', '710007', '1', 2023, 'CTTT', 8.87, 7.08, 7.38, 7.77 FROM DUAL UNION ALL
	SELECT 'S30032', 'V70055', '710007', '1', 2023, 'CTTT', 5.8, 4.31, 7.77, 6.49 FROM DUAL UNION ALL
	SELECT 'S30014', 'V70055', '710007', '1', 2023, 'CTTT', 9.12, 5.34, 4.79, 6.2 FROM DUAL UNION ALL
	SELECT 'S30074', 'V70055', '710007', '1', 2023, 'CTTT', 9.15, 7.26, 7.7, 8.05 FROM DUAL UNION ALL
	SELECT 'S30073', 'V70055', '710007', '1', 2023, 'CTTT', 8.2, 4.0, 7.02, 6.77 FROM DUAL UNION ALL
	SELECT 'S30092', 'V70055', '710007', '1', 2023, 'CTTT', 6.9, 8.6, 9.12, 8.35 FROM DUAL UNION ALL
	SELECT 'S30033', 'V70055', '710007', '1', 2023, 'CTTT', 8.04, 8.35, 8.77, 8.47 FROM DUAL UNION ALL
	SELECT 'S30075', 'V70055', '710007', '1', 2023, 'CTTT', 5.75, 7.81, 9.52, 8.05 FROM DUAL UNION ALL
	SELECT 'S30034', 'V70055', '710007', '1', 2023, 'CTTT', 7.14, 7.94, 7.37, 7.42 FROM DUAL UNION ALL
	SELECT 'S30114', 'V70055', '710007', '1', 2023, 'CTTT', 9.38, 8.59, 4.79, 6.93 FROM DUAL UNION ALL
	SELECT 'S30052', 'V70055', '710007', '1', 2023, 'CTTT', 8.87, 5.32, 6.66, 7.05 FROM DUAL UNION ALL
	SELECT 'S30053', 'V70055', '710007', '1', 2023, 'CTTT', 4.12, 7.44, 4.73, 5.09 FROM DUAL UNION ALL
	SELECT 'S30093', 'V70055', '710007', '1', 2023, 'CTTT', 4.31, 8.55, 9.0, 7.5 FROM DUAL UNION ALL
	SELECT 'S30031', 'V70055', '710007', '1', 2023, 'CTTT', 7.94, 8.48, 6.6, 7.38 FROM DUAL UNION ALL
	SELECT 'S30113', 'V70055', '710007', '1', 2023, 'CTTT', 7.79, 5.83, 6.95, 6.98 FROM DUAL UNION ALL
	SELECT 'S30112', 'V70055', '710007', '1', 2023, 'CTTT', 5.38, 9.18, 4.88, 5.89 FROM DUAL UNION ALL
	SELECT 'S30072', 'V70055', '710007', '1', 2023, 'CTTT', 9.48, 4.22, 8.64, 8.01 FROM DUAL UNION ALL
	SELECT 'S30035', 'V70055', '710007', '1', 2023, 'CTTT', 4.61, 5.05, 8.71, 6.75 FROM DUAL UNION ALL
	SELECT 'S30013', 'V70055', '710007', '1', 2023, 'CTTT', 5.85, 5.35, 9.52, 7.58 FROM DUAL UNION ALL
	SELECT 'S30115', 'V70055', '710007', '1', 2023, 'CTTT', 8.53, 4.24, 7.84, 7.33 FROM DUAL UNION ALL
	SELECT 'S30095', 'V70055', '710007', '1', 2023, 'CTTT', 5.47, 6.77, 4.27, 5.13 FROM DUAL UNION ALL
	SELECT 'S30111', 'V70055', '710007', '1', 2023, 'CTTT', 5.26, 9.87, 5.06, 6.08 FROM DUAL UNION ALL
	SELECT 'S30051', 'V70055', '710007', '1', 2023, 'CTTT', 6.77, 8.61, 4.22, 5.86 FROM DUAL UNION ALL
	SELECT 'S20049', 'V70053', '710004', '1', 2023, 'CLC', 9.64, 4.43, 5.63, 6.59 FROM DUAL UNION ALL
	SELECT 'S20069', 'V70053', '710004', '1', 2023, 'CLC', 5.45, 4.04, 8.18, 6.53 FROM DUAL UNION ALL
	SELECT 'S20068', 'V70053', '710004', '1', 2023, 'CLC', 4.54, 5.82, 6.35, 5.7 FROM DUAL UNION ALL
	SELECT 'S20107', 'V70053', '710004', '1', 2023, 'CLC', 9.88, 8.04, 5.33, 7.24 FROM DUAL UNION ALL
	SELECT 'S20028', 'V70053', '710004', '1', 2023, 'CLC', 6.73, 7.09, 8.83, 7.85 FROM DUAL UNION ALL
	SELECT 'S20087', 'V70053', '710004', '1', 2023, 'CLC', 7.5, 6.02, 4.43, 5.67 FROM DUAL UNION ALL
	SELECT 'S20090', 'V70053', '710004', '1', 2023, 'CLC', 8.57, 5.44, 9.81, 8.56 FROM DUAL UNION ALL
	SELECT 'S20030', 'V70053', '710004', '1', 2023, 'CLC', 8.49, 5.07, 4.82, 5.97 FROM DUAL UNION ALL
	SELECT 'S20086', 'V70053', '710004', '1', 2023, 'CLC', 5.17, 6.47, 8.15, 6.92 FROM DUAL UNION ALL
	SELECT 'S20110', 'V70053', '710004', '1', 2023, 'CLC', 8.95, 4.57, 5.52, 6.36 FROM DUAL UNION ALL
	SELECT 'S20108', 'V70053', '710004', '1', 2023, 'CLC', 7.08, 7.93, 4.76, 6.09 FROM DUAL UNION ALL
	SELECT 'S20009', 'V70053', '710004', '1', 2023, 'CLC', 9.42, 4.83, 7.56, 7.57 FROM DUAL UNION ALL
	SELECT 'S20050', 'V70053', '710004', '1', 2023, 'CLC', 6.55, 9.34, 4.04, 5.85 FROM DUAL UNION ALL
	SELECT 'S20048', 'V70053', '710004', '1', 2023, 'CLC', 9.75, 9.26, 4.88, 7.22 FROM DUAL UNION ALL
	SELECT 'S20109', 'V70053', '710004', '1', 2023, 'CLC', 7.15, 7.97, 8.18, 7.83 FROM DUAL UNION ALL
	SELECT 'S20006', 'V70053', '710004', '1', 2023, 'CLC', 4.25, 5.51, 7.21, 5.98 FROM DUAL UNION ALL
	SELECT 'S20026', 'V70053', '710004', '1', 2023, 'CLC', 9.07, 4.13, 5.67, 6.38 FROM DUAL UNION ALL
	SELECT 'S20046', 'V70053', '710004', '1', 2023, 'CLC', 5.58, 5.56, 4.21, 4.89 FROM DUAL UNION ALL
	SELECT 'S20027', 'V70053', '710004', '1', 2023, 'CLC', 5.56, 4.9, 4.19, 4.74 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70055', '710002', '1', 2023, 'VP', 7.76, 7.24, 7.36, 7.46 FROM DUAL UNION ALL
	SELECT 'S40096', 'V70055', '710002', '1', 2023, 'VP', 6.24, 5.9, 8.64, 7.37 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70055', '710002', '1', 2023, 'VP', 8.79, 7.48, 9.59, 8.93 FROM DUAL UNION ALL
	SELECT 'S40020', 'V70055', '710002', '1', 2023, 'VP', 9.29, 8.7, 6.04, 7.55 FROM DUAL UNION ALL
	SELECT 'S40056', 'V70055', '710002', '1', 2023, 'VP', 9.93, 9.55, 8.92, 9.35 FROM DUAL UNION ALL
	SELECT 'S40076', 'V70055', '710002', '1', 2023, 'VP', 7.69, 8.01, 8.56, 8.19 FROM DUAL UNION ALL
	SELECT 'S40040', 'V70055', '710002', '1', 2023, 'VP', 6.46, 7.61, 9.14, 8.03 FROM DUAL UNION ALL
	SELECT 'S40016', 'V70055', '710002', '1', 2023, 'VP', 9.58, 8.46, 9.35, 9.24 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70055', '710002', '1', 2023, 'VP', 7.66, 9.93, 6.64, 7.6 FROM DUAL UNION ALL
	SELECT 'S40037', 'V70055', '710002', '1', 2023, 'VP', 7.33, 6.22, 5.69, 6.29 FROM DUAL UNION ALL
	SELECT 'S40077', 'V70055', '710002', '1', 2023, 'VP', 7.58, 5.46, 6.36, 6.55 FROM DUAL UNION ALL
	SELECT 'S40038', 'V70055', '710002', '1', 2023, 'VP', 9.69, 9.52, 4.56, 7.09 FROM DUAL UNION ALL
	SELECT 'S40119', 'V70055', '710002', '1', 2023, 'VP', 4.4, 5.81, 8.48, 6.72 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70055', '710002', '1', 2023, 'VP', 4.22, 4.14, 5.28, 4.73 FROM DUAL UNION ALL
	SELECT 'S40078', 'V70055', '710002', '1', 2023, 'VP', 4.61, 5.3, 6.86, 5.87 FROM DUAL UNION ALL
	SELECT 'S40060', 'V70055', '710002', '1', 2023, 'VP', 8.5, 7.66, 6.61, 7.39 FROM DUAL UNION ALL
	SELECT 'S40097', 'V70055', '710002', '1', 2023, 'VP', 4.59, 5.91, 8.11, 6.61 FROM DUAL UNION ALL
	SELECT 'S40098', 'V70055', '710002', '1', 2023, 'VP', 5.69, 5.14, 9.56, 7.52 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70055', '710002', '1', 2023, 'VP', 8.19, 5.7, 5.4, 6.3 FROM DUAL UNION ALL
	SELECT 'S40117', 'V70055', '710002', '1', 2023, 'VP', 5.36, 7.71, 5.93, 6.12 FROM DUAL UNION ALL
	SELECT 'S40057', 'V70055', '710002', '1', 2023, 'VP', 5.88, 5.49, 4.67, 5.2 FROM DUAL UNION ALL
	SELECT 'S40036', 'V70055', '710002', '1', 2023, 'VP', 6.97, 8.53, 7.23, 7.41 FROM DUAL UNION ALL
	SELECT 'S40018', 'V70055', '710002', '1', 2023, 'VP', 8.38, 8.19, 5.61, 6.96 FROM DUAL UNION ALL
	SELECT 'S40016', 'V70052', '720002', '1', 2023, 'VP', 4.34, 4.12, 6.18, 5.22 FROM DUAL UNION ALL
	SELECT 'S40118', 'V70052', '720002', '1', 2023, 'VP', 6.58, 8.22, 9.61, 8.42 FROM DUAL UNION ALL
	SELECT 'S40116', 'V70052', '720002', '1', 2023, 'VP', 7.12, 5.28, 5.83, 6.11 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70052', '720002', '1', 2023, 'VP', 7.43, 8.54, 6.27, 7.07 FROM DUAL UNION ALL
	SELECT 'S40060', 'V70052', '720002', '1', 2023, 'VP', 8.7, 6.95, 5.37, 6.69 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70052', '720002', '1', 2023, 'VP', 6.91, 6.05, 4.32, 5.44 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70052', '720002', '1', 2023, 'VP', 7.43, 9.57, 8.04, 8.16 FROM DUAL UNION ALL
	SELECT 'S40039', 'V70052', '720002', '1', 2023, 'VP', 8.95, 7.15, 9.95, 9.09 FROM DUAL UNION ALL
	SELECT 'S10065', 'V70051', '730003', '1', 2023, 'CQ', 9.04, 5.32, 8.35, 7.95 FROM DUAL UNION ALL
	SELECT 'S10004', 'V70051', '730003', '1', 2023, 'CQ', 9.55, 7.68, 4.31, 6.56 FROM DUAL UNION ALL
	SELECT 'S10085', 'V70051', '730003', '1', 2023, 'CQ', 6.4, 7.91, 4.6, 5.8 FROM DUAL UNION ALL
	SELECT 'S10021', 'V70051', '730003', '1', 2023, 'CQ', 9.62, 8.75, 4.55, 6.91 FROM DUAL UNION ALL
	SELECT 'S10024', 'V70051', '730003', '1', 2023, 'CQ', 7.65, 7.38, 8.22, 7.88 FROM DUAL UNION ALL
	SELECT 'S10042', 'V70051', '730003', '1', 2023, 'CQ', 5.26, 9.71, 9.73, 8.38 FROM DUAL UNION ALL
	SELECT 'S10083', 'V70051', '730003', '1', 2023, 'CQ', 5.93, 7.05, 7.98, 7.18 FROM DUAL UNION ALL
	SELECT 'S10063', 'V70051', '730003', '1', 2023, 'CQ', 7.81, 7.95, 6.11, 6.99 FROM DUAL UNION ALL
	SELECT 'S10105', 'V70051', '730003', '1', 2023, 'CQ', 6.91, 4.1, 8.61, 7.2 FROM DUAL UNION ALL
	SELECT 'S10045', 'V70051', '730003', '1', 2023, 'CQ', 8.41, 6.91, 7.63, 7.72 FROM DUAL UNION ALL
	SELECT 'S10103', 'V70051', '730003', '1', 2023, 'CQ', 6.21, 7.31, 9.5, 8.07 FROM DUAL UNION ALL
	SELECT 'S10005', 'V70051', '730003', '1', 2023, 'CQ', 6.93, 9.33, 8.25, 8.07 FROM DUAL UNION ALL
	SELECT 'S10002', 'V70051', '730003', '1', 2023, 'CQ', 4.79, 9.16, 5.71, 6.12 FROM DUAL UNION ALL
	SELECT 'S10001', 'V70051', '730003', '1', 2023, 'CQ', 7.79, 5.59, 7.43, 7.17 FROM DUAL UNION ALL
	SELECT 'S10082', 'V70051', '730003', '1', 2023, 'CQ', 7.55, 5.8, 5.27, 6.06 FROM DUAL UNION ALL
	SELECT 'S10023', 'V70051', '730003', '1', 2023, 'CQ', 5.26, 9.53, 9.3, 8.13 FROM DUAL UNION ALL
	SELECT 'S10044', 'V70051', '730003', '1', 2023, 'CQ', 5.37, 7.55, 6.45, 6.35 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 2
	SELECT 'S40016', 'V70057', '710005', '2', 2023, 'VP', 6.27, 6.28, 6.76, 6.52 FROM DUAL UNION ALL
	SELECT 'S40077', 'V70057', '710005', '2', 2023, 'VP', 7.91, 8.89, 8.08, 8.19 FROM DUAL UNION ALL
	SELECT 'S40020', 'V70057', '710005', '2', 2023, 'VP', 5.18, 7.78, 6.82, 6.52 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70057', '710005', '2', 2023, 'VP', 9.53, 5.7, 5.63, 6.81 FROM DUAL UNION ALL
	SELECT 'S40039', 'V70057', '710005', '2', 2023, 'VP', 5.59, 7.3, 7.56, 6.92 FROM DUAL UNION ALL
	SELECT 'S40059', 'V70057', '710005', '2', 2023, 'VP', 8.23, 6.8, 8.28, 7.97 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70057', '710005', '2', 2023, 'VP', 7.48, 5.35, 9.57, 8.1 FROM DUAL UNION ALL
	SELECT 'S40038', 'V70057', '710005', '2', 2023, 'VP', 5.61, 6.04, 5.23, 5.51 FROM DUAL UNION ALL
	SELECT 'S40019', 'V70057', '710005', '2', 2023, 'VP', 6.9, 4.5, 6.99, 6.46 FROM DUAL UNION ALL
	SELECT 'S40076', 'V70057', '710005', '2', 2023, 'VP', 7.93, 4.25, 8.33, 7.39 FROM DUAL UNION ALL
	SELECT 'S40098', 'V70057', '710005', '2', 2023, 'VP', 7.13, 7.23, 6.31, 6.74 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70057', '710005', '2', 2023, 'VP', 4.55, 8.45, 4.57, 5.34 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70057', '710005', '2', 2023, 'VP', 8.89, 4.18, 9.14, 8.07 FROM DUAL UNION ALL
	SELECT 'S40100', 'V70057', '710005', '2', 2023, 'VP', 4.97, 8.05, 4.56, 5.38 FROM DUAL UNION ALL
	SELECT 'S40037', 'V70057', '710005', '2', 2023, 'VP', 6.72, 6.84, 7.86, 7.31 FROM DUAL UNION ALL
	SELECT 'S40036', 'V70057', '710005', '2', 2023, 'VP', 4.39, 7.24, 6.22, 5.88 FROM DUAL UNION ALL
	SELECT 'S40060', 'V70057', '710005', '2', 2023, 'VP', 6.94, 8.67, 4.8, 6.22 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70057', '710005', '2', 2023, 'VP', 4.57, 7.26, 8.64, 7.14 FROM DUAL UNION ALL
	SELECT 'S10042', 'V70055', '720003', '2', 2023, 'CQ', 9.18, 5.0, 7.26, 7.38 FROM DUAL UNION ALL
	SELECT 'S10083', 'V70055', '720003', '2', 2023, 'CQ', 7.72, 7.88, 8.15, 7.97 FROM DUAL UNION ALL
	SELECT 'S10022', 'V70055', '720003', '2', 2023, 'CQ', 9.42, 4.47, 8.91, 8.18 FROM DUAL UNION ALL
	SELECT 'S10081', 'V70055', '720003', '2', 2023, 'CQ', 4.78, 6.33, 6.82, 6.11 FROM DUAL UNION ALL
	SELECT 'S10021', 'V70055', '720003', '2', 2023, 'CQ', 6.42, 5.2, 4.4, 5.17 FROM DUAL UNION ALL
	SELECT 'S10084', 'V70055', '720003', '2', 2023, 'CQ', 8.49, 8.61, 8.08, 8.31 FROM DUAL UNION ALL
	SELECT 'S10101', 'V70055', '720003', '2', 2023, 'CQ', 6.8, 7.72, 9.64, 8.4 FROM DUAL UNION ALL
	SELECT 'S10105', 'V70055', '720003', '2', 2023, 'CQ', 6.46, 9.93, 9.77, 8.81 FROM DUAL UNION ALL
	SELECT 'S10025', 'V70055', '720003', '2', 2023, 'CQ', 6.58, 9.75, 5.43, 6.64 FROM DUAL UNION ALL
	SELECT 'S10005', 'V70055', '720003', '2', 2023, 'CQ', 7.91, 6.69, 6.82, 7.12 FROM DUAL UNION ALL
	SELECT 'S10003', 'V70055', '720003', '2', 2023, 'CQ', 4.65, 8.82, 9.92, 8.12 FROM DUAL UNION ALL
	SELECT 'S10064', 'V70055', '720003', '2', 2023, 'CQ', 9.24, 7.09, 9.58, 8.98 FROM DUAL UNION ALL
	SELECT 'S10041', 'V70055', '720003', '2', 2023, 'CQ', 6.59, 6.28, 4.43, 5.45 FROM DUAL UNION ALL
	SELECT 'S10023', 'V70055', '720003', '2', 2023, 'CQ', 8.23, 7.77, 5.33, 6.69 FROM DUAL UNION ALL
	SELECT 'S10065', 'V70055', '720003', '2', 2023, 'CQ', 9.81, 7.37, 7.78, 8.31 FROM DUAL UNION ALL
	SELECT 'S10044', 'V70055', '720003', '2', 2023, 'CQ', 9.75, 7.11, 8.7, 8.7 FROM DUAL UNION ALL
	SELECT 'S10103', 'V70055', '720003', '2', 2023, 'CQ', 9.87, 4.36, 4.37, 6.02 FROM DUAL UNION ALL
	SELECT 'S10085', 'V70055', '720003', '2', 2023, 'CQ', 5.45, 8.58, 6.74, 6.72 FROM DUAL UNION ALL
	SELECT 'S10082', 'V70055', '720003', '2', 2023, 'CQ', 5.93, 9.79, 8.52, 8.0 FROM DUAL UNION ALL
	SELECT 'S10002', 'V70055', '720003', '2', 2023, 'CQ', 7.77, 5.02, 4.42, 5.54 FROM DUAL UNION ALL
	SELECT 'S10061', 'V70055', '720003', '2', 2023, 'CQ', 7.65, 5.89, 5.44, 6.19 FROM DUAL UNION ALL
	SELECT 'S10043', 'V70055', '720003', '2', 2023, 'CQ', 4.29, 5.91, 4.14, 4.54 FROM DUAL UNION ALL
	SELECT 'S10045', 'V70055', '720003', '2', 2023, 'CQ', 6.34, 5.58, 8.46, 7.25 FROM DUAL UNION ALL
	SELECT 'S10102', 'V70055', '720003', '2', 2023, 'CQ', 6.3, 5.43, 5.59, 5.77 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70059', '730001', '2', 2023, 'VP', 6.67, 5.36, 9.66, 7.9 FROM DUAL UNION ALL
	SELECT 'S40059', 'V70059', '730001', '2', 2023, 'VP', 7.78, 9.31, 7.33, 7.86 FROM DUAL UNION ALL
	SELECT 'S40117', 'V70059', '730001', '2', 2023, 'VP', 4.25, 5.64, 5.38, 5.09 FROM DUAL UNION ALL
	SELECT 'S40038', 'V70059', '730001', '2', 2023, 'VP', 7.39, 5.34, 5.43, 6.0 FROM DUAL UNION ALL
	SELECT 'S40037', 'V70059', '730001', '2', 2023, 'VP', 7.62, 4.02, 4.92, 5.55 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70059', '730001', '2', 2023, 'VP', 6.17, 6.35, 6.75, 6.5 FROM DUAL UNION ALL
	SELECT 'S40036', 'V70059', '730001', '2', 2023, 'VP', 4.15, 6.49, 4.46, 4.77 FROM DUAL UNION ALL
	SELECT 'S40119', 'V70059', '730001', '2', 2023, 'VP', 4.8, 6.84, 8.66, 7.14 FROM DUAL UNION ALL
	SELECT 'S40077', 'V70059', '730001', '2', 2023, 'VP', 7.52, 7.76, 5.08, 6.35 FROM DUAL UNION ALL
	SELECT 'S40078', 'V70059', '730001', '2', 2023, 'VP', 9.28, 6.4, 5.2, 6.66 FROM DUAL UNION ALL
	SELECT 'S40097', 'V70059', '730001', '2', 2023, 'VP', 7.41, 9.56, 5.84, 7.05 FROM DUAL UNION ALL
	SELECT 'S40040', 'V70059', '730001', '2', 2023, 'VP', 6.88, 7.51, 9.05, 8.09 FROM DUAL UNION ALL
	SELECT 'S40118', 'V70059', '730001', '2', 2023, 'VP', 6.61, 5.62, 6.0, 6.11 FROM DUAL UNION ALL
	SELECT 'S40020', 'V70059', '730001', '2', 2023, 'VP', 6.19, 6.64, 9.39, 7.88 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70059', '730001', '2', 2023, 'VP', 4.03, 6.27, 4.28, 4.6 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70059', '730001', '2', 2023, 'VP', 6.09, 6.14, 6.73, 6.42 FROM DUAL UNION ALL
	SELECT 'S40076', 'V70059', '730001', '2', 2023, 'VP', 9.65, 8.85, 4.19, 6.76 FROM DUAL UNION ALL
	SELECT 'S40100', 'V70059', '730001', '2', 2023, 'VP', 8.57, 5.34, 7.33, 7.3 FROM DUAL UNION ALL
	SELECT 'S40098', 'V70059', '730001', '2', 2023, 'VP', 7.58, 4.94, 4.64, 5.58 FROM DUAL UNION ALL
	SELECT 'S40096', 'V70059', '730001', '2', 2023, 'VP', 4.78, 4.56, 9.81, 7.25 FROM DUAL UNION ALL
	SELECT 'S40056', 'V70059', '730001', '2', 2023, 'VP', 7.08, 8.01, 6.06, 6.76 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70059', '730001', '2', 2023, 'VP', 5.58, 6.64, 8.54, 7.27 FROM DUAL UNION ALL
	SELECT 'S30011', 'V70053', '720001', '2', 2023, 'CTTT', 5.52, 8.7, 4.39, 5.59 FROM DUAL UNION ALL
	SELECT 'S30014', 'V70053', '720001', '2', 2023, 'CTTT', 7.09, 7.56, 8.37, 7.82 FROM DUAL UNION ALL
	SELECT 'S30095', 'V70053', '720001', '2', 2023, 'CTTT', 5.24, 5.98, 8.42, 6.98 FROM DUAL UNION ALL
	SELECT 'S30113', 'V70053', '720001', '2', 2023, 'CTTT', 5.56, 8.22, 7.12, 6.87 FROM DUAL UNION ALL
	SELECT 'S30092', 'V70053', '720001', '2', 2023, 'CTTT', 5.56, 7.32, 5.18, 5.72 FROM DUAL UNION ALL
	SELECT 'S30072', 'V70053', '720001', '2', 2023, 'CTTT', 6.02, 8.34, 9.11, 8.03 FROM DUAL UNION ALL
	SELECT 'S30031', 'V70053', '720001', '2', 2023, 'CTTT', 4.62, 9.75, 4.11, 5.39 FROM DUAL UNION ALL
	SELECT 'S30034', 'V70053', '720001', '2', 2023, 'CTTT', 4.89, 9.06, 9.32, 7.94 FROM DUAL UNION ALL
	SELECT 'S30013', 'V70053', '720001', '2', 2023, 'CTTT', 9.08, 4.86, 4.04, 5.72 FROM DUAL UNION ALL
	SELECT 'S30074', 'V70053', '720001', '2', 2023, 'CTTT', 6.08, 7.19, 7.1, 6.81 FROM DUAL UNION ALL
	SELECT 'S30033', 'V70053', '720001', '2', 2023, 'CTTT', 5.54, 6.46, 5.6, 5.75 FROM DUAL UNION ALL
	SELECT 'S30012', 'V70053', '720001', '2', 2023, 'CTTT', 8.67, 6.67, 6.91, 7.39 FROM DUAL UNION ALL
	SELECT 'S30035', 'V70053', '720001', '2', 2023, 'CTTT', 9.32, 9.35, 4.26, 6.8 FROM DUAL UNION ALL
	SELECT 'S30073', 'V70053', '720001', '2', 2023, 'CTTT', 8.27, 7.1, 5.02, 6.41 FROM DUAL UNION ALL
	SELECT 'S30115', 'V70053', '720001', '2', 2023, 'CTTT', 7.41, 7.65, 4.32, 5.91 FROM DUAL UNION ALL
	SELECT 'S30093', 'V70053', '720001', '2', 2023, 'CTTT', 8.82, 7.9, 9.97, 9.21 FROM DUAL UNION ALL
	SELECT 'S30032', 'V70053', '720001', '2', 2023, 'CTTT', 9.67, 9.73, 8.8, 9.25 FROM DUAL UNION ALL
	SELECT 'S30055', 'V70053', '720001', '2', 2023, 'CTTT', 9.21, 6.36, 6.12, 7.1 FROM DUAL UNION ALL
	SELECT 'S30091', 'V70053', '720001', '2', 2023, 'CTTT', 5.52, 4.57, 4.05, 4.6 FROM DUAL UNION ALL
	SELECT 'S30054', 'V70053', '720001', '2', 2023, 'CTTT', 7.04, 8.57, 6.21, 6.93 FROM DUAL UNION ALL
	SELECT 'S30051', 'V70053', '720001', '2', 2023, 'CTTT', 4.69, 4.77, 9.63, 7.18 FROM DUAL UNION ALL
	SELECT 'S30114', 'V70053', '720001', '2', 2023, 'CTTT', 5.36, 4.52, 8.3, 6.66 FROM DUAL UNION ALL
	SELECT 'S30071', 'V70053', '720001', '2', 2023, 'CTTT', 6.97, 6.96, 7.45, 7.21 FROM DUAL UNION ALL
	SELECT 'S30075', 'V70053', '720001', '2', 2023, 'CTTT', 5.36, 8.67, 7.72, 7.2 FROM DUAL UNION ALL
	SELECT 'S30094', 'V70053', '720001', '2', 2023, 'CTTT', 5.17, 6.05, 7.5, 6.51 FROM DUAL UNION ALL
	SELECT 'S30111', 'V70053', '720001', '2', 2023, 'CTTT', 5.62, 8.7, 7.25, 7.05 FROM DUAL UNION ALL
	SELECT 'S30112', 'V70053', '720001', '2', 2023, 'CTTT', 7.05, 7.59, 6.59, 6.93 FROM DUAL UNION ALL
	SELECT 'S20007', 'V70051', '730004', '2', 2023, 'CLC', 9.21, 4.33, 7.77, 7.51 FROM DUAL UNION ALL
	SELECT 'S20046', 'V70051', '730004', '2', 2023, 'CLC', 6.0, 9.03, 6.7, 6.96 FROM DUAL UNION ALL
	SELECT 'S20030', 'V70051', '730004', '2', 2023, 'CLC', 4.77, 6.88, 6.96, 6.29 FROM DUAL UNION ALL
	SELECT 'S20087', 'V70051', '730004', '2', 2023, 'CLC', 6.93, 6.53, 6.3, 6.54 FROM DUAL UNION ALL
	SELECT 'S20067', 'V70051', '730004', '2', 2023, 'CLC', 6.94, 6.44, 6.76, 6.75 FROM DUAL UNION ALL
	SELECT 'S20026', 'V70051', '730004', '2', 2023, 'CLC', 7.55, 6.0, 8.2, 7.56 FROM DUAL UNION ALL
	SELECT 'S20028', 'V70051', '730004', '2', 2023, 'CLC', 9.46, 5.5, 8.73, 8.3 FROM DUAL UNION ALL
	SELECT 'S20086', 'V70051', '730004', '2', 2023, 'CLC', 9.96, 7.85, 7.77, 8.44 FROM DUAL UNION ALL
	SELECT 'S20090', 'V70051', '730004', '2', 2023, 'CLC', 8.47, 4.78, 4.58, 5.79 FROM DUAL UNION ALL
	SELECT 'S20047', 'V70051', '730004', '2', 2023, 'CLC', 5.61, 8.15, 7.53, 7.08 FROM DUAL UNION ALL
	SELECT 'S20107', 'V70051', '730004', '2', 2023, 'CLC', 9.54, 6.03, 4.53, 6.33 FROM DUAL UNION ALL
	SELECT 'S20088', 'V70051', '730004', '2', 2023, 'CLC', 5.83, 7.71, 5.45, 6.02 FROM DUAL UNION ALL
	SELECT 'S20070', 'V70051', '730004', '2', 2023, 'CLC', 7.72, 6.65, 9.33, 8.31 FROM DUAL UNION ALL
	SELECT 'S20010', 'V70051', '730004', '2', 2023, 'CLC', 9.92, 4.13, 10.0, 8.8 FROM DUAL UNION ALL
	SELECT 'S20108', 'V70051', '730004', '2', 2023, 'CLC', 5.53, 6.25, 6.04, 5.93 FROM DUAL UNION ALL
	SELECT 'S20049', 'V70051', '730004', '2', 2023, 'CLC', 4.21, 5.01, 8.7, 6.61 FROM DUAL UNION ALL
	SELECT 'S20050', 'V70051', '730004', '2', 2023, 'CLC', 6.88, 7.52, 8.82, 7.98 FROM DUAL UNION ALL
	SELECT 'S20066', 'V70051', '730004', '2', 2023, 'CLC', 7.11, 9.44, 9.29, 8.67 FROM DUAL UNION ALL
	SELECT 'S20029', 'V70051', '730004', '2', 2023, 'CLC', 5.19, 5.91, 6.43, 5.95 FROM DUAL UNION ALL
	SELECT 'S20068', 'V70051', '730004', '2', 2023, 'CLC', 6.02, 4.48, 4.87, 5.14 FROM DUAL UNION ALL
	SELECT 'S20027', 'V70051', '730004', '2', 2023, 'CLC', 9.93, 7.68, 8.36, 8.7 FROM DUAL UNION ALL
	SELECT 'S20008', 'V70051', '730004', '2', 2023, 'CLC', 8.02, 4.47, 7.21, 6.9 FROM DUAL UNION ALL
	SELECT 'S20109', 'V70051', '730004', '2', 2023, 'CLC', 8.26, 7.77, 8.47, 8.27 FROM DUAL UNION ALL
	SELECT 'S40059', 'V70054', '720004', '2', 2023, 'VP', 8.87, 8.87, 8.32, 8.59 FROM DUAL UNION ALL
	SELECT 'S40057', 'V70054', '720004', '2', 2023, 'VP', 7.51, 8.42, 8.01, 7.94 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70054', '720004', '2', 2023, 'VP', 4.21, 7.75, 9.05, 7.34 FROM DUAL UNION ALL
	SELECT 'S40098', 'V70054', '720004', '2', 2023, 'VP', 4.74, 9.3, 6.18, 6.37 FROM DUAL UNION ALL
	SELECT 'S40018', 'V70054', '720004', '2', 2023, 'VP', 9.05, 4.4, 5.51, 6.35 FROM DUAL UNION ALL
	SELECT 'S40076', 'V70054', '720004', '2', 2023, 'VP', 5.23, 4.54, 4.46, 4.71 FROM DUAL UNION ALL
	SELECT 'S40039', 'V70054', '720004', '2', 2023, 'VP', 7.52, 6.33, 5.22, 6.13 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70054', '720004', '2', 2023, 'VP', 4.71, 7.93, 9.18, 7.59 FROM DUAL UNION ALL
	SELECT 'S40119', 'V70054', '720004', '2', 2023, 'VP', 4.91, 4.97, 8.59, 6.76 FROM DUAL UNION ALL
	SELECT 'S40078', 'V70054', '720004', '2', 2023, 'VP', 8.8, 8.6, 5.5, 7.11 FROM DUAL UNION ALL
	SELECT 'S40118', 'V70054', '720004', '2', 2023, 'VP', 4.75, 4.74, 6.08, 5.41 FROM DUAL UNION ALL
	SELECT 'S40060', 'V70054', '720004', '2', 2023, 'VP', 5.78, 8.04, 4.27, 5.48 FROM DUAL UNION ALL
	SELECT 'S40016', 'V70054', '720004', '2', 2023, 'VP', 9.3, 9.87, 9.28, 9.4 FROM DUAL UNION ALL
	SELECT 'S40116', 'V70054', '720004', '2', 2023, 'VP', 7.26, 7.45, 6.19, 6.76 FROM DUAL UNION ALL
	SELECT 'S40017', 'V70054', '720004', '2', 2023, 'VP', 8.98, 5.21, 4.98, 6.23 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70054', '720004', '2', 2023, 'VP', 4.9, 9.17, 9.51, 8.06 FROM DUAL UNION ALL
	SELECT 'S40097', 'V70054', '720004', '2', 2023, 'VP', 6.84, 5.45, 6.96, 6.62 FROM DUAL UNION ALL
	SELECT 'S40019', 'V70054', '720004', '2', 2023, 'VP', 4.75, 4.15, 4.39, 4.45 FROM DUAL UNION ALL
	SELECT 'S40036', 'V70054', '720004', '2', 2023, 'VP', 5.71, 9.54, 8.03, 7.64 FROM DUAL UNION ALL
	SELECT 'S40117', 'V70054', '720004', '2', 2023, 'VP', 8.58, 6.27, 6.33, 6.99 FROM DUAL;
INSERT INTO DANGKY
--	2023 - HOC KY 3
	SELECT 'S40060', 'V70054', '710006', '3', 2023, 'VP', 8.7, 6.59, 4.12, 5.99 FROM DUAL UNION ALL
	SELECT 'S40077', 'V70054', '710006', '3', 2023, 'VP', 7.31, 5.12, 5.86, 6.15 FROM DUAL UNION ALL
	SELECT 'S40018', 'V70054', '710006', '3', 2023, 'VP', 8.22, 8.1, 4.76, 6.47 FROM DUAL UNION ALL
	SELECT 'S40117', 'V70054', '710006', '3', 2023, 'VP', 7.59, 6.97, 7.04, 7.19 FROM DUAL UNION ALL
	SELECT 'S40037', 'V70054', '710006', '3', 2023, 'VP', 8.55, 7.88, 4.21, 6.25 FROM DUAL UNION ALL
	SELECT 'S40036', 'V70054', '710006', '3', 2023, 'VP', 5.82, 8.57, 6.0, 6.46 FROM DUAL UNION ALL
	SELECT 'S40120', 'V70054', '710006', '3', 2023, 'VP', 9.77, 6.98, 9.65, 9.15 FROM DUAL UNION ALL
	SELECT 'S40058', 'V70054', '710006', '3', 2023, 'VP', 9.75, 8.75, 6.89, 8.12 FROM DUAL UNION ALL
	SELECT 'S40057', 'V70054', '710006', '3', 2023, 'VP', 5.96, 6.63, 7.41, 6.82 FROM DUAL UNION ALL
	SELECT 'S40099', 'V70054', '710006', '3', 2023, 'VP', 8.0, 5.12, 4.9, 5.87 FROM DUAL UNION ALL
	SELECT 'S40056', 'V70054', '710006', '3', 2023, 'VP', 4.73, 5.5, 4.81, 4.92 FROM DUAL UNION ALL
	SELECT 'S40016', 'V70054', '710006', '3', 2023, 'VP', 4.53, 8.63, 8.1, 7.13 FROM DUAL UNION ALL
	SELECT 'S40017', 'V70054', '710006', '3', 2023, 'VP', 8.52, 5.55, 7.34, 7.34 FROM DUAL UNION ALL
	SELECT 'S40118', 'V70054', '710006', '3', 2023, 'VP', 7.64, 6.58, 7.15, 7.18 FROM DUAL UNION ALL
	SELECT 'S40019', 'V70054', '710006', '3', 2023, 'VP', 8.55, 6.28, 4.81, 6.23 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70054', '710006', '3', 2023, 'VP', 7.7, 7.06, 6.22, 6.83 FROM DUAL UNION ALL
	SELECT 'S40038', 'V70054', '710006', '3', 2023, 'VP', 7.07, 9.47, 8.74, 8.39 FROM DUAL UNION ALL
	SELECT 'S40040', 'V70054', '710006', '3', 2023, 'VP', 5.66, 6.51, 5.32, 5.66 FROM DUAL UNION ALL
	SELECT 'S40097', 'V70051', '710001', '3', 2023, 'VP', 7.87, 9.67, 9.25, 8.92 FROM DUAL UNION ALL
	SELECT 'S40057', 'V70051', '710001', '3', 2023, 'VP', 6.51, 7.64, 6.46, 6.71 FROM DUAL UNION ALL
	SELECT 'S40076', 'V70051', '710001', '3', 2023, 'VP', 7.4, 4.12, 9.73, 7.91 FROM DUAL UNION ALL
	SELECT 'S40079', 'V70051', '710001', '3', 2023, 'VP', 5.24, 9.92, 9.22, 8.17 FROM DUAL UNION ALL
	SELECT 'S40040', 'V70051', '710001', '3', 2023, 'VP', 7.61, 6.63, 9.3, 8.26 FROM DUAL UNION ALL
	SELECT 'S40080', 'V70051', '710001', '3', 2023, 'VP', 6.39, 6.04, 7.4, 6.83 FROM DUAL UNION ALL
	SELECT 'S40060', 'V70051', '710001', '3', 2023, 'VP', 4.05, 7.42, 6.72, 6.06 FROM DUAL UNION ALL
	SELECT 'S40100', 'V70051', '710001', '3', 2023, 'VP', 9.65, 8.58, 7.09, 8.16 FROM DUAL UNION ALL
	SELECT 'S40077', 'V70051', '710001', '3', 2023, 'VP', 8.87, 8.92, 7.28, 8.08 FROM DUAL UNION ALL
	SELECT 'S40096', 'V70051', '710001', '3', 2023, 'VP', 7.57, 9.4, 7.38, 7.84 FROM DUAL UNION ALL
	SELECT 'S30091', 'V70055', '710003', '3', 2023, 'CTTT', 8.75, 5.04, 6.71, 6.99 FROM DUAL UNION ALL
	SELECT 'S30094', 'V70055', '710003', '3', 2023, 'CTTT', 9.04, 5.19, 6.98, 7.24 FROM DUAL UNION ALL
	SELECT 'S30034', 'V70055', '710003', '3', 2023, 'CTTT', 7.42, 7.37, 5.46, 6.43 FROM DUAL UNION ALL
	SELECT 'S30052', 'V70055', '710003', '3', 2023, 'CTTT', 7.02, 9.25, 7.12, 7.52 FROM DUAL UNION ALL
	SELECT 'S30054', 'V70055', '710003', '3', 2023, 'CTTT', 6.58, 7.37, 9.69, 8.29 FROM DUAL UNION ALL
	SELECT 'S30051', 'V70055', '710003', '3', 2023, 'CTTT', 6.23, 9.48, 5.93, 6.73 FROM DUAL;

/* UPDATE SINHVIEN'S SOTCTL AND DTBTL
 */
UPDATE SINHVIEN SET SOTCTL = 73, DTBTL = 6.83 WHERE MASV = 'S30013';
UPDATE SINHVIEN SET SOTCTL = 36, DTBTL = 7.38 WHERE MASV = 'S30015';
UPDATE SINHVIEN SET SOTCTL = 63, DTBTL = 6.40 WHERE MASV = 'S30095';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 6.99 WHERE MASV = 'S30034';
UPDATE SINHVIEN SET SOTCTL = 54, DTBTL = 6.49 WHERE MASV = 'S30113';
UPDATE SINHVIEN SET SOTCTL = 54, DTBTL = 7.28 WHERE MASV = 'S30052';
UPDATE SINHVIEN SET SOTCTL = 55, DTBTL = 7.22 WHERE MASV = 'S30074';
UPDATE SINHVIEN SET SOTCTL = 53, DTBTL = 7.27 WHERE MASV = 'S30012';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.68 WHERE MASV = 'S30055';
UPDATE SINHVIEN SET SOTCTL = 66, DTBTL = 7.17 WHERE MASV = 'S30071';
UPDATE SINHVIEN SET SOTCTL = 66, DTBTL = 7.04 WHERE MASV = 'S30093';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 6.65 WHERE MASV = 'S30114';
UPDATE SINHVIEN SET SOTCTL = 69, DTBTL = 6.73 WHERE MASV = 'S30032';
UPDATE SINHVIEN SET SOTCTL = 69, DTBTL = 7.23 WHERE MASV = 'S30033';
UPDATE SINHVIEN SET SOTCTL = 48, DTBTL = 6.28 WHERE MASV = 'S30073';
UPDATE SINHVIEN SET SOTCTL = 89, DTBTL = 6.80 WHERE MASV = 'S40018';
UPDATE SINHVIEN SET SOTCTL = 79, DTBTL = 6.74 WHERE MASV = 'S40079';
UPDATE SINHVIEN SET SOTCTL = 84, DTBTL = 7.32 WHERE MASV = 'S40096';
UPDATE SINHVIEN SET SOTCTL = 96, DTBTL = 7.08 WHERE MASV = 'S40058';
UPDATE SINHVIEN SET SOTCTL = 84, DTBTL = 6.88 WHERE MASV = 'S40099';
UPDATE SINHVIEN SET SOTCTL = 81, DTBTL = 7.01 WHERE MASV = 'S40059';
UPDATE SINHVIEN SET SOTCTL = 79, DTBTL = 7.29 WHERE MASV = 'S40080';
UPDATE SINHVIEN SET SOTCTL = 71, DTBTL = 6.61 WHERE MASV = 'S40097';
UPDATE SINHVIEN SET SOTCTL = 81, DTBTL = 6.86 WHERE MASV = 'S40077';
UPDATE SINHVIEN SET SOTCTL = 91, DTBTL = 6.88 WHERE MASV = 'S40117';
UPDATE SINHVIEN SET SOTCTL = 79, DTBTL = 7.25 WHERE MASV = 'S40118';
UPDATE SINHVIEN SET SOTCTL = 80, DTBTL = 6.93 WHERE MASV = 'S40020';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 7.13 WHERE MASV = 'S40016';
UPDATE SINHVIEN SET SOTCTL = 68, DTBTL = 6.94 WHERE MASV = 'S40100';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 6.58 WHERE MASV = 'S40037';
UPDATE SINHVIEN SET SOTCTL = 79, DTBTL = 6.87 WHERE MASV = 'S40078';
UPDATE SINHVIEN SET SOTCTL = 86, DTBTL = 6.78 WHERE MASV = 'S40036';
UPDATE SINHVIEN SET SOTCTL = 71, DTBTL = 6.97 WHERE MASV = 'S40038';
UPDATE SINHVIEN SET SOTCTL = 60, DTBTL = 7.48 WHERE MASV = 'S40098';
UPDATE SINHVIEN SET SOTCTL = 94, DTBTL = 6.90 WHERE MASV = 'S40060';
UPDATE SINHVIEN SET SOTCTL = 81, DTBTL = 7.04 WHERE MASV = 'S40057';
UPDATE SINHVIEN SET SOTCTL = 94, DTBTL = 6.86 WHERE MASV = 'S40076';
UPDATE SINHVIEN SET SOTCTL = 90, DTBTL = 6.89 WHERE MASV = 'S40040';
UPDATE SINHVIEN SET SOTCTL = 79, DTBTL = 6.94 WHERE MASV = 'S40120';
UPDATE SINHVIEN SET SOTCTL = 85, DTBTL = 6.71 WHERE MASV = 'S40056';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.66 WHERE MASV = 'S40119';
UPDATE SINHVIEN SET SOTCTL = 74, DTBTL = 7.14 WHERE MASV = 'S40019';
UPDATE SINHVIEN SET SOTCTL = 69, DTBTL = 6.85 WHERE MASV = 'S40116';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.69 WHERE MASV = 'S10002';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.65 WHERE MASV = 'S10065';
UPDATE SINHVIEN SET SOTCTL = 84, DTBTL = 7.12 WHERE MASV = 'S10081';
UPDATE SINHVIEN SET SOTCTL = 86, DTBTL = 6.69 WHERE MASV = 'S10085';
UPDATE SINHVIEN SET SOTCTL = 90, DTBTL = 6.83 WHERE MASV = 'S10083';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.92 WHERE MASV = 'S10023';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 6.80 WHERE MASV = 'S10103';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.95 WHERE MASV = 'S10004';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.33 WHERE MASV = 'S10003';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.56 WHERE MASV = 'S10005';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.87 WHERE MASV = 'S10102';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 7.29 WHERE MASV = 'S10084';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 7.38 WHERE MASV = 'S10062';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 6.87 WHERE MASV = 'S10064';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 7.18 WHERE MASV = 'S10101';
UPDATE SINHVIEN SET SOTCTL = 62, DTBTL = 6.99 WHERE MASV = 'S10061';
UPDATE SINHVIEN SET SOTCTL = 86, DTBTL = 6.84 WHERE MASV = 'S10025';
UPDATE SINHVIEN SET SOTCTL = 76, DTBTL = 6.90 WHERE MASV = 'S10041';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 6.81 WHERE MASV = 'S10104';
UPDATE SINHVIEN SET SOTCTL = 86, DTBTL = 7.14 WHERE MASV = 'S10024';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.54 WHERE MASV = 'S10044';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 7.43 WHERE MASV = 'S10105';
UPDATE SINHVIEN SET SOTCTL = 86, DTBTL = 7.04 WHERE MASV = 'S10042';
UPDATE SINHVIEN SET SOTCTL = 82, DTBTL = 6.63 WHERE MASV = 'S10043';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 7.02 WHERE MASV = 'S10045';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.95 WHERE MASV = 'S40017';
UPDATE SINHVIEN SET SOTCTL = 75, DTBTL = 7.11 WHERE MASV = 'S40039';
UPDATE SINHVIEN SET SOTCTL = 65, DTBTL = 6.75 WHERE MASV = 'S30014';
UPDATE SINHVIEN SET SOTCTL = 43, DTBTL = 6.99 WHERE MASV = 'S30112';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 7.00 WHERE MASV = 'S10063';
UPDATE SINHVIEN SET SOTCTL = 66, DTBTL = 7.61 WHERE MASV = 'S10082';
UPDATE SINHVIEN SET SOTCTL = 78, DTBTL = 6.99 WHERE MASV = 'S10022';
UPDATE SINHVIEN SET SOTCTL = 38, DTBTL = 7.25 WHERE MASV = 'S20110';
UPDATE SINHVIEN SET SOTCTL = 48, DTBTL = 6.75 WHERE MASV = 'S20046';
UPDATE SINHVIEN SET SOTCTL = 54, DTBTL = 6.38 WHERE MASV = 'S20088';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 6.81 WHERE MASV = 'S20086';
UPDATE SINHVIEN SET SOTCTL = 62, DTBTL = 7.05 WHERE MASV = 'S20006';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 7.04 WHERE MASV = 'S20027';
UPDATE SINHVIEN SET SOTCTL = 60, DTBTL = 7.40 WHERE MASV = 'S20029';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.83 WHERE MASV = 'S20106';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.99 WHERE MASV = 'S20107';
UPDATE SINHVIEN SET SOTCTL = 66, DTBTL = 6.64 WHERE MASV = 'S10021';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 6.91 WHERE MASV = 'S30091';
UPDATE SINHVIEN SET SOTCTL = 40, DTBTL = 7.27 WHERE MASV = 'S30092';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.91 WHERE MASV = 'S30011';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 6.75 WHERE MASV = 'S30094';
UPDATE SINHVIEN SET SOTCTL = 48, DTBTL = 6.55 WHERE MASV = 'S30075';
UPDATE SINHVIEN SET SOTCTL = 71, DTBTL = 6.95 WHERE MASV = 'S30051';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 7.08 WHERE MASV = 'S30072';
UPDATE SINHVIEN SET SOTCTL = 49, DTBTL = 7.05 WHERE MASV = 'S30115';
UPDATE SINHVIEN SET SOTCTL = 53, DTBTL = 6.89 WHERE MASV = 'S30054';
UPDATE SINHVIEN SET SOTCTL = 51, DTBTL = 6.49 WHERE MASV = 'S30053';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 6.52 WHERE MASV = 'S20108';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 7.04 WHERE MASV = 'S20008';
UPDATE SINHVIEN SET SOTCTL = 46, DTBTL = 7.23 WHERE MASV = 'S20048';
UPDATE SINHVIEN SET SOTCTL = 54, DTBTL = 7.20 WHERE MASV = 'S20047';
UPDATE SINHVIEN SET SOTCTL = 38, DTBTL = 7.48 WHERE MASV = 'S20050';
UPDATE SINHVIEN SET SOTCTL = 44, DTBTL = 6.87 WHERE MASV = 'S20028';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 7.43 WHERE MASV = 'S20066';
UPDATE SINHVIEN SET SOTCTL = 36, DTBTL = 6.91 WHERE MASV = 'S20089';
UPDATE SINHVIEN SET SOTCTL = 60, DTBTL = 7.27 WHERE MASV = 'S20067';
UPDATE SINHVIEN SET SOTCTL = 46, DTBTL = 7.03 WHERE MASV = 'S20070';
UPDATE SINHVIEN SET SOTCTL = 66, DTBTL = 6.96 WHERE MASV = 'S30031';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 6.82 WHERE MASV = 'S30111';
UPDATE SINHVIEN SET SOTCTL = 42, DTBTL = 6.84 WHERE MASV = 'S30035';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 6.84 WHERE MASV = 'S20068';
UPDATE SINHVIEN SET SOTCTL = 60, DTBTL = 7.02 WHERE MASV = 'S20010';
UPDATE SINHVIEN SET SOTCTL = 52, DTBTL = 7.39 WHERE MASV = 'S20069';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 6.83 WHERE MASV = 'S20026';
UPDATE SINHVIEN SET SOTCTL = 64, DTBTL = 6.81 WHERE MASV = 'S10001';
UPDATE SINHVIEN SET SOTCTL = 38, DTBTL = 7.37 WHERE MASV = 'S20030';
UPDATE SINHVIEN SET SOTCTL = 46, DTBTL = 7.12 WHERE MASV = 'S20007';
UPDATE SINHVIEN SET SOTCTL = 58, DTBTL = 6.58 WHERE MASV = 'S20109';
UPDATE SINHVIEN SET SOTCTL = 56, DTBTL = 7.23 WHERE MASV = 'S20090';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 7.37 WHERE MASV = 'S20049';
UPDATE SINHVIEN SET SOTCTL = 46, DTBTL = 6.87 WHERE MASV = 'S20009';
UPDATE SINHVIEN SET SOTCTL = 50, DTBTL = 6.54 WHERE MASV = 'S20087';
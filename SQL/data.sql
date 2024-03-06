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
    SELECT 'GV0001', 'Duong Yen Trang', 'NU', TO_DATE('24/08/1982', 'DD/MM/YYYY'), 8554, '09561464695', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0002', 'Duong Kim Thao', 'NU', TO_DATE('05/02/1997', 'DD/MM/YYYY'), 8548, '09403850427', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0003', 'Dinh Thanh Hanh', 'NU', TO_DATE('10/07/1991', 'DD/MM/YYYY'), 9374, '09438731171', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0004', 'Bui Hieu Lam', 'NAM', TO_DATE('27/12/1986', 'DD/MM/YYYY'), 7385, '09383998067', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0005', 'Phan Thanh Son', 'NAM', TO_DATE('01/02/1976', 'DD/MM/YYYY'), 4970, '09482893902', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0006', 'Huynh Thuy Hien', 'NU', TO_DATE('25/10/1975', 'DD/MM/YYYY'), 5758, '09518356923', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0007', 'Vo Viet Phong', 'NAM', TO_DATE('09/11/1972', 'DD/MM/YYYY'), 4375, '09266472531', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0008', 'Ly Minh Thien', 'NAM', TO_DATE('09/10/1973', 'DD/MM/YYYY'), 2899, '09736576222', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0009', 'Vu An Khe', 'NU', TO_DATE('03/09/1980', 'DD/MM/YYYY'), 5260, '09659964719', 2, 1 FROM DUAL UNION ALL
    SELECT 'GV0010', 'Do Thao Hong', 'NU', TO_DATE('22/09/1980', 'DD/MM/YYYY'), 3955, '09737456988', 2, 1 FROM DUAL UNION ALL
-- 4. TRUONG DON VI - 2. HTTT, 3. CNPM, 4. KHMT, 5. CNTT, 6. TGMT, 7. MMT
    SELECT 'TD0001', 'Duong Bao Hue', 'NU', TO_DATE('04/07/1995', 'DD/MM/YYYY'), 9597, '09480787174', 3, 2 FROM DUAL UNION ALL
    SELECT 'TD0002', 'Do Chi Nam', 'NAM', TO_DATE('16/05/1982', 'DD/MM/YYYY'), 1729, '09372403011', 3, 3 FROM DUAL UNION ALL
    SELECT 'TD0003', 'Hoang Thuy Van', 'NU', TO_DATE('09/07/1972', 'DD/MM/YYYY'), 1930, '09550783443', 3, 4 FROM DUAL UNION ALL
    SELECT 'TD0004', 'Le Quang Vu', 'NAM', TO_DATE('27/07/1994', 'DD/MM/YYYY'), 9511, '09948400459', 3, 5 FROM DUAL UNION ALL
    SELECT 'TD0005', 'Huynh Thien Theu', 'NU', TO_DATE('04/08/1997', 'DD/MM/YYYY'), 2513, '09714491762', 3, 6 FROM DUAL UNION ALL
    SELECT 'TD0006', 'Dang My Ngoc', 'NU', TO_DATE('24/12/1996', 'DD/MM/YYYY'), 512, '09222394868', 3, 7 FROM DUAL UNION ALL
-- 5. TRUONG KHOA - 1. VAN PHONG KHOA
    SELECT 'TK0001', 'NGUYEN VAN A', 'NAM', TO_DATE('01/01/1980', 'DD/MM/YYYY'), 10000, '09123456789', 5, 1 FROM DUAL;
INSERT INTO NHANSU
-- 2.2. GIANG VIEN HTTT (10)
    SELECT 'GN0001', 'Pham Hien Nuong', 'NU', TO_DATE('22/09/1978', 'DD/MM/YYYY'), 1659, '09715954407', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0002', 'Nguyen Hoa Tranh', 'NU', TO_DATE('07/11/1999', 'DD/MM/YYYY'), 4466, '09252306143', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0003', 'Ho Thanh Y', 'NAM', TO_DATE('23/12/1984', 'DD/MM/YYYY'), 8347, '09314593386', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0004', 'Tran Gia Anh', 'NAM', TO_DATE('04/07/1979', 'DD/MM/YYYY'), 9774, '09185574394', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0005', 'Le Duc Tuong', 'NAM', TO_DATE('04/05/1990', 'DD/MM/YYYY'), 2588, '09627664202', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0006', 'Phan Bao Khanh', 'NAM', TO_DATE('15/02/1991', 'DD/MM/YYYY'), 2571, '09649566662', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0007', 'Phan Trung Anh', 'NU', TO_DATE('26/04/1997', 'DD/MM/YYYY'), 536, '09313180009', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0008', 'Dang Cat Tien', 'NU', TO_DATE('25/03/1972', 'DD/MM/YYYY'), 4263, '09968725357', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0009', 'Tran Thao Tien', 'NU', TO_DATE('07/08/1983', 'DD/MM/YYYY'), 5152, '09861998940', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0010', 'Bui Tan Thanh', 'NAM', TO_DATE('07/04/1987', 'DD/MM/YYYY'), 3785, '09192170795', 1, 2 FROM DUAL UNION ALL
-- 2.3. GIANG VIEN CNPM (10)
    SELECT 'GN0011', 'Vo Quynh Anh', 'NU', TO_DATE('04/09/1970', 'DD/MM/YYYY'), 4473, '09789463468', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0012', 'Phan Hong Tham', 'NU', TO_DATE('30/08/1971', 'DD/MM/YYYY'), 4926, '09261312844', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0013', 'Do Hong Thinh', 'NAM', TO_DATE('29/01/1986', 'DD/MM/YYYY'), 3867, '09180796749', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0014', 'Huynh Truc Quynh', 'NU', TO_DATE('26/11/1979', 'DD/MM/YYYY'), 1647, '09605012761', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0015', 'Hoang Hong Chau', 'NU', TO_DATE('29/09/1976', 'DD/MM/YYYY'), 5661, '09187273741', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0016', 'Hoang Gia Uy', 'NAM', TO_DATE('16/09/1987', 'DD/MM/YYYY'), 7580, '09107155153', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0017', 'Huynh Thuc Tam', 'NU', TO_DATE('30/04/1995', 'DD/MM/YYYY'), 6860, '09530072865', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0018', 'Phan Duy Khanh', 'NAM', TO_DATE('04/12/1999', 'DD/MM/YYYY'), 6959, '09141722090', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0019', 'Ly Huy Thanh', 'NAM', TO_DATE('02/08/1989', 'DD/MM/YYYY'), 8829, '09757275012', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0020', 'Do Nhat Linh', 'NU', TO_DATE('23/07/1997', 'DD/MM/YYYY'), 7059, '09233679938', 1, 3 FROM DUAL UNION ALL
-- 2.4. GIANG VIEN KHMT (10)
    SELECT 'GN0021', 'Pham Ngoc Tien', 'NAM', TO_DATE('02/08/1986', 'DD/MM/YYYY'), 7549, '09248529257', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0022', 'Duong Mau Xuan', 'NU', TO_DATE('04/02/1983', 'DD/MM/YYYY'), 1905, '09692491362', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0023', 'Bui Bao Huy', 'NAM', TO_DATE('11/05/1986', 'DD/MM/YYYY'), 1174, '09258362772', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0024', 'Do Ngoc Thien', 'NAM', TO_DATE('06/10/1985', 'DD/MM/YYYY'), 8764, '09349800413', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0025', 'Dang Chi Hieu', 'NAM', TO_DATE('28/09/1974', 'DD/MM/YYYY'), 1401, '09653309532', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0026', 'Ho Thuy Van', 'NU', TO_DATE('23/12/1976', 'DD/MM/YYYY'), 4840, '09275594109', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0027', 'Huynh Tuong Anh', 'NAM', TO_DATE('17/12/1996', 'DD/MM/YYYY'), 3353, '09430535090', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0028', 'Truong Phuc Khang', 'NAM', TO_DATE('14/01/1993', 'DD/MM/YYYY'), 7869, '09985192475', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0029', 'Huynh Truong Thanh', 'NAM', TO_DATE('06/10/1984', 'DD/MM/YYYY'), 1324, '09755525549', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0030', 'Truong Thien Di', 'NU', TO_DATE('10/12/1991', 'DD/MM/YYYY'), 6045, '09318615948', 1, 4 FROM DUAL;
INSERT INTO NHANSU
-- 2.5. GIANG VIEN CNTT (10)
    SELECT 'GN0031', 'Pham Thanh Thuan', 'NAM', TO_DATE('13/10/1979', 'DD/MM/YYYY'), 9428, '09115034166', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0032', 'Le Van Khanh', 'NU', TO_DATE('06/05/1989', 'DD/MM/YYYY'), 7546, '09243508656', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0033', 'Pham Thi Yen', 'NU', TO_DATE('23/09/1999', 'DD/MM/YYYY'), 5779, '09346886049', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0034', 'Hoang Hong Giang', 'NAM', TO_DATE('29/10/1990', 'DD/MM/YYYY'), 4919, '09458269067', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0035', 'Ho Dat Dung', 'NAM', TO_DATE('30/03/1985', 'DD/MM/YYYY'), 5483, '09769858172', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0036', 'Vo Van Trang', 'NU', TO_DATE('08/06/1980', 'DD/MM/YYYY'), 4880, '09944931418', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0037', 'Vu Dong Nghi', 'NU', TO_DATE('03/08/1985', 'DD/MM/YYYY'), 3578, '09739986858', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0038', 'Vo Dang Khoa', 'NAM', TO_DATE('07/07/1996', 'DD/MM/YYYY'), 4808, '09298572465', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0039', 'Vu Anh Nguyet', 'NU', TO_DATE('03/11/1971', 'DD/MM/YYYY'), 9895, '09585472080', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0040', 'Do Thien Dung', 'NAM', TO_DATE('13/04/1975', 'DD/MM/YYYY'), 4975, '09465242829', 1, 5 FROM DUAL UNION ALL
-- 2.6. GIANG VIEN TGMT (10)
    SELECT 'GN0041', 'Ly To Nhi', 'NU', TO_DATE('29/07/1988', 'DD/MM/YYYY'), 7969, '09452789321', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0042', 'Vu Thien Dung', 'NAM', TO_DATE('15/07/1994', 'DD/MM/YYYY'), 9814, '09444067839', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0043', 'Ngo Diem Quynh', 'NU', TO_DATE('28/12/1973', 'DD/MM/YYYY'), 6797, '09413122412', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0044', 'Pham Quoc Tuan', 'NAM', TO_DATE('13/04/1991', 'DD/MM/YYYY'), 9734, '09848498626', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0045', 'Do Ngan Ha', 'NU', TO_DATE('15/06/1970', 'DD/MM/YYYY'), 7860, '09371961992', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0046', 'Duong Le Giang', 'NU', TO_DATE('07/11/1997', 'DD/MM/YYYY'), 7438, '09609407144', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0047', 'Hoang Khanh Vy', 'NU', TO_DATE('09/04/1998', 'DD/MM/YYYY'), 8722, '09257749249', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0048', 'Phan Bich Nga', 'NU', TO_DATE('04/01/1998', 'DD/MM/YYYY'), 9294, '09685168286', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0049', 'Tran Quoc Hung', 'NAM', TO_DATE('19/03/1995', 'DD/MM/YYYY'), 8334, '09731214291', 1, 6 FROM DUAL UNION ALL
    SELECT 'GN0050', 'Huynh Bao Chau', 'NU', TO_DATE('17/02/1998', 'DD/MM/YYYY'), 9497, '09382339046', 1, 6 FROM DUAL UNION ALL
-- 2.7. GIANG VIEN MMT (10)
    SELECT 'GN0051', 'Dinh Dinh Phuc', 'NAM', TO_DATE('06/01/1985', 'DD/MM/YYYY'), 2269, '09804162584', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0052', 'Le An Ninh', 'NAM', TO_DATE('24/07/1982', 'DD/MM/YYYY'), 3799, '09692794176', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0053', 'Ly Cao Nghiep', 'NAM', TO_DATE('19/02/1988', 'DD/MM/YYYY'), 5553, '09191157955', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0054', 'Tran Suong Suong', 'NU', TO_DATE('31/07/1985', 'DD/MM/YYYY'), 4998, '09851455786', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0055', 'Vu Duc Tuong', 'NAM', TO_DATE('30/01/1994', 'DD/MM/YYYY'), 6580, '09826070523', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0056', 'Le Phuong Lan', 'NU', TO_DATE('03/09/1982', 'DD/MM/YYYY'), 716, '09683002077', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0057', 'Ngo Quang Dat', 'NAM', TO_DATE('12/11/1993', 'DD/MM/YYYY'), 2266, '09851132434', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0058', 'Phan Tung Anh', 'NAM', TO_DATE('29/11/1977', 'DD/MM/YYYY'), 9851, '09272604347', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0059', 'Ly Thuong Nga', 'NU', TO_DATE('23/07/1978', 'DD/MM/YYYY'), 7078, '09564507979', 1, 7 FROM DUAL UNION ALL
    SELECT 'GN0060', 'Le Tan Long', 'NAM', TO_DATE('25/05/1980', 'DD/MM/YYYY'), 9597, '09496557499', 1, 7 FROM DUAL;
INSERT INTO NHANSU
-- 2.2.1. GIANG VIEN HTTT (5)
    SELECT 'GN0061', 'Ngo Nhat Bao Long', 'NAM', TO_DATE('26/12/1980', 'DD/MM/YYYY'), 5547, '09115103113', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0062', 'Nguyen Huu Tuong', 'NAM', TO_DATE('28/07/1973', 'DD/MM/YYYY'), 9240, '09540315931', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0063', 'Vo My Phuong', 'NU', TO_DATE('20/10/1980', 'DD/MM/YYYY'), 2327, '09156109842', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0064', 'Ho Tue Nhi', 'NU', TO_DATE('26/10/1971', 'DD/MM/YYYY'), 5354, '09863734611', 1, 2 FROM DUAL UNION ALL
    SELECT 'GN0065', 'Bui Phi Hung', 'NAM', TO_DATE('06/01/1997', 'DD/MM/YYYY'), 3065, '09675267141', 1, 2 FROM DUAL UNION ALL
-- 2.3.1. GIANG VIEN CNPM (5)
    SELECT 'GN0066', 'Truong Hoang Lan', 'NU', TO_DATE('01/02/1992', 'DD/MM/YYYY'), 2907, '09860552511', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0067', 'Vu The Hung', 'NAM', TO_DATE('20/10/1980', 'DD/MM/YYYY'), 1851, '09743059777', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0068', 'Duong Thuy Lieu', 'NU', TO_DATE('26/07/1997', 'DD/MM/YYYY'), 2889, '09412918593', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0069', 'Hoang Ha Phuong', 'NU', TO_DATE('07/11/1987', 'DD/MM/YYYY'), 2143, '09400821593', 1, 3 FROM DUAL UNION ALL
    SELECT 'GN0070', 'Duong Kiet Trinh', 'NU', TO_DATE('02/12/1970', 'DD/MM/YYYY'), 5839, '09681357137', 1, 3 FROM DUAL UNION ALL
-- 2.4.1. GIANG VIEN KHMT (5)
    SELECT 'GN0071', 'Le Huu Long', 'NAM', TO_DATE('05/05/1985', 'DD/MM/YYYY'), 9625, '09660222558', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0072', 'Duong Nhat Khuong', 'NAM', TO_DATE('05/11/1982', 'DD/MM/YYYY'), 8055, '09114572323', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0073', 'Ho Kim Loan', 'NU', TO_DATE('03/02/1993', 'DD/MM/YYYY'), 3985, '09986934035', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0074', 'Ho Thong Dat', 'NAM', TO_DATE('16/06/1972', 'DD/MM/YYYY'), 4893, '09253856973', 1, 4 FROM DUAL UNION ALL
    SELECT 'GN0075', 'Vu Mong Nhi', 'NU', TO_DATE('09/04/1984', 'DD/MM/YYYY'), 4865, '09918451841', 1, 4 FROM DUAL UNION ALL
-- 2.5.1. GIANG VIEN CNTT (5)
    SELECT 'GN0076', 'Ly Hai Nam', 'NAM', TO_DATE('12/03/1975', 'DD/MM/YYYY'), 8096, '09680577872', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0077', 'Truong Phuong Mai', 'NU', TO_DATE('19/06/1970', 'DD/MM/YYYY'), 7237, '09502659372', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0078', 'Vu Anh Tai', 'NAM', TO_DATE('05/03/1970', 'DD/MM/YYYY'), 5935, '09954263020', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0079', 'Truong Tuong Lan', 'NAM', TO_DATE('19/11/1987', 'DD/MM/YYYY'), 4057, '09408521917', 1, 5 FROM DUAL UNION ALL
    SELECT 'GN0080', 'Pham Phuong Que', 'NU', TO_DATE('08/01/1972', 'DD/MM/YYYY'), 6162, '09694518426', 1, 5 FROM DUAL;

/* SINHVIEN
 */
INSERT INTO SINHVIEN
-- 1. SINH VIEN HTTT
--	1. CQ
	SELECT 'SV0001', 'Huynh Khanh An', 'NAM', TO_DATE('04/09/2004', 'DD/MM/YYYY'), '304 duong Quan 6, phuong Tan Chinh, Thanh pho Ben Tre, Tinh Ben Tre', '09277270525', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0002', 'Ho Thanh Tu', 'NAM', TO_DATE('07/06/2000', 'DD/MM/YYYY'), '344/10 duong Kien An, phuong Dich Vong Hau, quan Hai Ba Trung, Thanh pho Yen Bai, Tinh Yen Bai', '09222658205', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0003', 'Tran Thanh Chau', 'NAM', TO_DATE('24/09/2005', 'DD/MM/YYYY'), '268/23J duong Le Chan, phuong Cong Vi, quan Bac Tu Liem, Thanh pho Tay Ninh, Tinh Tay Ninh', '09564195820', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0004', 'Huynh Mai Ha', 'NU', TO_DATE('02/07/2004', 'DD/MM/YYYY'), '395/36 duong Tay Ho, phuong Long Hoa, Thanh pho Ha Giang, Tinh Ha Giang', '09099278192', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0005', 'Tran Anh Tho', 'NU', TO_DATE('08/12/2005', 'DD/MM/YYYY'), '102 duong Quan 1, phuong Phuoc Ninh, quan Cai Rang, Thanh pho Ho Chi Minh', '09648095476', 'CQ', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0006', 'Duong Bich Chieu', 'NU', TO_DATE('13/07/2004', 'DD/MM/YYYY'), '95/13 duong Le Chan, phuong Tan Mai, Thanh pho Long Xuyen, Tinh An Giang', '09272259761', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0007', 'Bui Dieu Hien', 'NU', TO_DATE('13/02/2005', 'DD/MM/YYYY'), '201O duong Quan 3, phuong Ben Nghe, quan Hoan Kiem, Thanh pho Ba Ria, Tinh Ba Ria - Vung Tau', '09398642190', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0008', 'Ho Uyen Thy', 'NU', TO_DATE('10/03/2005', 'DD/MM/YYYY'), '68Z duong Kien An, phuong Thoi Hoa, Thanh pho Dong Xoai, Tinh Binh Phuoc', '09944490278', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0009', 'Truong Minh Hue', 'NU', TO_DATE('17/02/2002', 'DD/MM/YYYY'), '203X duong Quan 6, phuong Phuc Loi, Thanh pho Tuy Hoa, Tinh Phu Yen', '09227527837', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0010', 'Ly Hanh Tuong', 'NAM', TO_DATE('28/12/2002', 'DD/MM/YYYY'), '279 duong Quan 10, phuong O Cho Dua, Thanh pho Gia Nghia, Tinh Dak Nong', '09948610767', 'CLC', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0011', 'Tran Hoai An', 'NU', TO_DATE('19/02/2001', 'DD/MM/YYYY'), '102/14Z duong Binh Thuy, phuong Binh Hung Hoa B, quan Thot Not, Thanh pho Hai Phong', '09968906739', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0012', 'Duong Tuong Vinh', 'NAM', TO_DATE('03/05/2004', 'DD/MM/YYYY'), '376 duong Hong Bang, phuong Dong Ngac, Thanh pho Bac Kan, Tinh Bac Kan', '09172266945', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0013', 'Ho Nhu Khang', 'NAM', TO_DATE('09/01/2004', 'DD/MM/YYYY'), '267/17B duong Quan 10, Phuong 2, quan Duong Kinh, Thanh pho Kon Tum, Tinh Kon Tum', '09234325032', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0014', 'Le Thuc Ðao', 'NU', TO_DATE('09/08/2005', 'DD/MM/YYYY'), '189F duong Quan 7, phuong Hoa Thuan Dong, quan Le Chan, Thanh pho Lai Chau, Tinh Lai Chau', '09056045944', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0015', 'Bui Duc Trung', 'NAM', TO_DATE('23/06/2005', 'DD/MM/YYYY'), '50/37 duong Thanh Xuan, Phuong 14, quan Kien An, Thanh pho Hue, Tinh Thua Thien Hue', '09293460544', 'CTTT', 'HTTT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0016', 'Nguyen Mong Lam', 'NAM', TO_DATE('08/04/2001', 'DD/MM/YYYY'), '175/17 duong Thanh Khe, phuong Xuan La, Thanh pho Da Lat, Tinh Lam Dong', '09779778206', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0017', 'Huynh Anh Quoc', 'NAM', TO_DATE('23/06/2005', 'DD/MM/YYYY'), '199 duong Bac Tu Liem, phuong Khuong Thuong, Thanh pho My Tho, Tinh Tien Giang', '09220024264', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0018', 'Ly Xuan Loan', 'NU', TO_DATE('17/03/2004', 'DD/MM/YYYY'), '324/31 duong Do Son, phuong Man Thai, quan Hoang Mai, Thanh pho Da Nang', '09828575087', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0019', 'Huynh Tam Nhi', 'NU', TO_DATE('25/07/2005', 'DD/MM/YYYY'), '23 duong Quan 6, phuong Minh Duc, quan Dong Da, Thanh pho Thanh Hoa, Tinh Thanh Hoa', '09409964351', 'VP', 'HTTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0020', 'Ngo Huu Vuong', 'NAM', TO_DATE('25/01/2005', 'DD/MM/YYYY'), '143/19N duong Hai Ba Trung, phuong Hang Ma, quan Hoang Mai, Thanh pho Phu Ly, Tinh Ha Nam', '09981796753', 'VP', 'HTTT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 2. SINH VIEN CNPM
--	1. CQ
	SELECT 'SV0021', 'Dinh Thanh Nga', 'NU', TO_DATE('31/08/2005', 'DD/MM/YYYY'), '33/34 duong Le Chan, phuong Thanh Tri, quan Do Son, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09311301127', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0022', 'Do Tuy Anh', 'NU', TO_DATE('24/11/2002', 'DD/MM/YYYY'), '276Q duong Cam Le, phuong Tan Kieng, quan Binh Thanh, Thanh pho Son La, Tinh Son La', '09538464291', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0023', 'Ho Hoa Mi', 'NU', TO_DATE('08/01/2001', 'DD/MM/YYYY'), '184T duong Cau Giay, phuong Dong Hai, quan Ba Dinh, Thanh pho Tra Vinh, Tinh Tra Vinh', '09558694096', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0024', 'Pham Xuan Cung', 'NAM', TO_DATE('20/03/2000', 'DD/MM/YYYY'), '130B duong Le Chan, phuong Hoa Minh, quan Dong Da, Thanh pho Dong Hoi, Tinh Quang Binh', '09597790347', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0025', 'Pham Thieu Ly', 'NU', TO_DATE('03/01/2005', 'DD/MM/YYYY'), '44/19 duong Quan 5, phuong Dong Hai 2, Thanh pho Bac Lieu, Tinh Bac Lieu', '09539008992', 'CQ', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0026', 'Bui Chan Hung', 'NAM', TO_DATE('10/11/2001', 'DD/MM/YYYY'), '314/37F duong Long Bien, Phuong 7, Quan 5, Thanh pho Vinh, Tinh Nghe An', '09589060791', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0027', 'Ho Tu Tam', 'NU', TO_DATE('24/03/2004', 'DD/MM/YYYY'), '106S duong Quan 8, phuong Cau Kho, quan Dong Da, Thanh pho Bac Lieu, Tinh Bac Lieu', '09743602035', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0028', 'Le Khanh Hoa', 'NAM', TO_DATE('28/11/2001', 'DD/MM/YYYY'), '158/48 duong Tan Binh, phuong Kham Thien, quan Binh Thuy, Thanh pho Bac Giang, Tinh Bac Giang', '09394004984', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0029', 'Hoang Thuan Toan', 'NAM', TO_DATE('11/07/2000', 'DD/MM/YYYY'), '292/9Z duong Binh Thuy, Phuong Canh, Quan 7, Thanh pho Vinh Long, Tinh Vinh Long', '09085521847', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0030', 'Phan Kim Thanh', 'NU', TO_DATE('14/02/2005', 'DD/MM/YYYY'), '371/28L duong Hoan Kiem, phuong Ngoc Thuy, Thanh pho Hai Phong', '09784727113', 'CLC', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0031', 'Ho Thu Phuong', 'NU', TO_DATE('23/11/2002', 'DD/MM/YYYY'), '136/41K duong Ha Dong, phuong Thanh Xuan, Quan 12, Thanh pho Tay Ninh, Tinh Tay Ninh', '09465388056', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0032', 'Hoang Thach Thao', 'NU', TO_DATE('01/11/2004', 'DD/MM/YYYY'), '7/15D duong Quan 10, phuong Quynh Loi, quan Go Vap, Thanh pho Rach Gia, Tinh Kien Giang', '09965177632', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0033', 'Nguyen Bich Chau', 'NU', TO_DATE('20/08/2003', 'DD/MM/YYYY'), '152 duong Cai Rang, phuong My An, quan Hoan Kiem, Thanh pho Vinh Long, Tinh Vinh Long', '09648988414', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0034', 'Dang Ngoc Lai', 'NAM', TO_DATE('28/08/2003', 'DD/MM/YYYY'), '259/16 duong Thanh Xuan, phuong Dong Hung Thuan, Quan 1, Thanh pho Bac Ninh, Tinh Bac Ninh', '09210593882', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0035', 'Le Trung Nhan', 'NAM', TO_DATE('02/05/2002', 'DD/MM/YYYY'), '352I duong Hoang Mai, phuong Thuan Hung, quan Go Vap, Thanh pho Ha Tinh, Tinh Ha Tinh', '09080583612', 'CTTT', 'CNPM', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0036', 'Do Hoa Mi', 'NU', TO_DATE('26/02/2003', 'DD/MM/YYYY'), '46 duong Hong Bang, phuong Dong Xuan, quan Long Bien, Thanh pho Da Lat, Tinh Lam Dong', '09918794845', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0037', 'Vu Quoc Hoa', 'NAM', TO_DATE('28/02/2001', 'DD/MM/YYYY'), '137/23H duong Tan Phu, phuong Co Nhue 2, quan Cau Giay, Thanh pho Bien Hoa, Tinh Dong Nai', '09067189402', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0038', 'Vu Thuy Kieu', 'NU', TO_DATE('04/06/2000', 'DD/MM/YYYY'), '133 duong Ngu Hanh Son, phuong Hoa Phat, Thanh pho Bac Kan, Tinh Bac Kan', '09138293532', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0039', 'Dinh Uyen Tram', 'NU', TO_DATE('24/04/2001', 'DD/MM/YYYY'), '342 duong Duong Kinh, phuong Le Loi, Quan 12, Thanh pho Yen Bai, Tinh Yen Bai', '09136216166', 'VP', 'CNPM', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0040', 'Do Hai Van', 'NU', TO_DATE('18/03/2004', 'DD/MM/YYYY'), '42/32E duong Duong Kinh, phuong Quan Thanh, Thanh pho Tam Ky, Tinh Quang Nam', '09689428364', 'VP', 'CNPM', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 3. SINH VIEN KHMT
--	1. CQ
	SELECT 'SV0041', 'Nguyen Dieu Thuy', 'NU', TO_DATE('27/11/2004', 'DD/MM/YYYY'), '177/42 duong Quan 12, phuong Phu Tho Hoa, quan Hoang Mai, Thanh pho Ha Giang, Tinh Ha Giang', '09979171974', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0042', 'Do Huu Hanh', 'NAM', TO_DATE('24/02/2005', 'DD/MM/YYYY'), '39 duong Long Bien, phuong Cau Dat, quan Son Tra, Thanh pho Ho Chi Minh', '09462812497', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0043', 'Phan Thu Thuan', 'NU', TO_DATE('30/11/2002', 'DD/MM/YYYY'), '130K duong Quan 8, phuong Dong Hai 1, Thanh pho Dong Hoi, Tinh Quang Binh', '09771816322', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0044', 'Pham Anh Thu', 'NU', TO_DATE('24/10/2002', 'DD/MM/YYYY'), '127/16 duong Quan 12, phuong Ngoc Ha, quan Hai Chau, Thanh pho Bac Kan, Tinh Bac Kan', '09625789676', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0045', 'Tran Thong Dat', 'NAM', TO_DATE('23/06/2002', 'DD/MM/YYYY'), '290B duong Phu Nhuan, phuong La Khe, quan Tay Ho, Thanh pho Buon Ma Thuot, Tinh Dak Lak', '09652717011', 'CQ', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0046', 'Duong Thai Minh', 'NAM', TO_DATE('27/06/2003', 'DD/MM/YYYY'), '66W duong Ba Dinh, phuong Tan Quy, Quan 4, Thanh pho Cao Bang, Tinh Cao Bang', '09387671321', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0047', 'Vu Quynh Nhu', 'NU', TO_DATE('21/07/2005', 'DD/MM/YYYY'), '303 duong Hoan Kiem, phuong O Cho Dua, quan Do Son, Thanh pho Vinh, Tinh Nghe An', '09029707821', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0048', 'Dang Thuy Tien', 'NU', TO_DATE('25/03/2004', 'DD/MM/YYYY'), '51/32 duong Do Son, phuong Nam Son, quan Binh Thanh, Thanh pho Ha Giang, Tinh Ha Giang', '09423586030', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0049', 'Nguyen Lap Nghiep', 'NAM', TO_DATE('01/12/2000', 'DD/MM/YYYY'), '342/30Z duong Dong Da, phuong Co Giang, Thanh pho Cao Lanh, Tinh Dong Thap', '09787473165', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0050', 'Ho Kiet Hong', 'NU', TO_DATE('10/12/2004', 'DD/MM/YYYY'), '94/22 duong O Mon, phuong Yet Kieu, Thanh pho Vi Thanh, Tinh Hau Giang', '09946261735', 'CLC', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0051', 'Vo Dieu Lan', 'NU', TO_DATE('27/11/2001', 'DD/MM/YYYY'), '397/1F duong Quan 6, phuong Ha Dinh, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09442496989', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0052', 'Huynh Huu Cuong', 'NAM', TO_DATE('16/11/2001', 'DD/MM/YYYY'), '150/27 duong Binh Tan, phuong Duc Giang, quan Cai Rang, Thanh pho Thu Dau Mot, Tinh Binh Duong', '09741325117', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0053', 'Nguyen Hoai Vy', 'NU', TO_DATE('11/01/2000', 'DD/MM/YYYY'), '3M duong Hai An, phuong Thanh Tri, Thanh pho Bac Giang, Tinh Bac Giang', '09647687959', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0054', 'Ngo Chi Son', 'NAM', TO_DATE('02/11/2005', 'DD/MM/YYYY'), '205 duong Ba Dinh, phuong Thanh Cong, Thanh pho Can Tho', '09856857888', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0055', 'Ngo Tinh Tam', 'NU', TO_DATE('26/10/2002', 'DD/MM/YYYY'), '385/10 duong Quan 12, phuong Da Kao, quan Tay Ho, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09787986771', 'CTTT', 'KHMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0056', 'Ho Hong Quy', 'NAM', TO_DATE('29/08/2005', 'DD/MM/YYYY'), '184A duong Quan 10, phuong Phuoc Thoi, quan Ninh Kieu, Thanh pho Quy Nhon, Tinh Binh Dinh', '09857024660', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0057', 'Nguyen Tuan Minh', 'NAM', TO_DATE('31/01/2004', 'DD/MM/YYYY'), '247 duong Ninh Kieu, phuong Phu My, Thanh pho Bac Giang, Tinh Bac Giang', '09259519607', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0058', 'Pham The Huan', 'NAM', TO_DATE('17/05/2005', 'DD/MM/YYYY'), '40K duong Phu Nhuan, phuong Ngoc Ha, quan Lien Chieu, Thanh pho Cao Bang, Tinh Cao Bang', '09947822710', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0059', 'Nguyen Tuan Hoang', 'NAM', TO_DATE('15/04/2001', 'DD/MM/YYYY'), '277/29 duong Hong Bang, phuong Thanh Khe Dong, quan Binh Thanh, Thanh pho Nam Dinh, Tinh Nam Dinh', '09063763000', 'VP', 'KHMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0060', 'Bui Hoa Lien', 'NU', TO_DATE('27/11/2004', 'DD/MM/YYYY'), '240/46 duong Hoan Kiem, Phuong 15, Thanh pho Cao Bang, Tinh Cao Bang', '09952541487', 'VP', 'KHMT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 4. SINH VIEN CNTT
--	1. CQ
	SELECT 'SV0061', 'Vo Van Thong', 'NAM', TO_DATE('15/01/2001', 'DD/MM/YYYY'), '228/37U duong Hoan Kiem, Phuong 3, Thanh pho Da Lat, Tinh Lam Dong', '09951443189', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0062', 'Dinh Diem Chau', 'NU', TO_DATE('11/01/2001', 'DD/MM/YYYY'), '367/49Y duong Binh Tan, phuong Nguyen Trai, quan Tay Ho, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09309614465', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0063', 'Vo Thu Phuong', 'NU', TO_DATE('07/12/2003', 'DD/MM/YYYY'), '365 duong Hoang Mai, phuong Thoi An Dong, quan Ha Dong, Thanh pho Da Nang', '09282250541', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0064', 'Do Mai Ly', 'NU', TO_DATE('24/12/2004', 'DD/MM/YYYY'), '110 duong Long Bien, phuong Le Dai Hanh, Thanh pho Ha Noi', '09025274402', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0065', 'Duong Viet Quoc', 'NAM', TO_DATE('15/08/2005', 'DD/MM/YYYY'), '396/4 duong Long Bien, phuong Cau Den, quan Hoan Kiem, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09498851741', 'CQ', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0066', 'Ho Thuy Huong', 'NU', TO_DATE('30/07/2003', 'DD/MM/YYYY'), '52/13C duong Quan 7, phuong Truong Dinh, Thanh pho Tuy Hoa, Tinh Phu Yen', '09315161078', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0067', 'Vo My Tram', 'NU', TO_DATE('22/08/2003', 'DD/MM/YYYY'), '319/48J duong Ba Dinh, phuong Phuc Dien, Thanh pho Nha Trang, Tinh Khanh Hoa', '09815956567', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0068', 'Phan Viet Nhi', 'NU', TO_DATE('20/07/2000', 'DD/MM/YYYY'), '122Y duong Thanh Khe, phuong Trung Kien, quan Thanh Xuan, Thanh pho Hung Yen, Tinh Hung Yen', '09275006510', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0069', 'Nguyen Nha Uyen', 'NU', TO_DATE('02/04/2001', 'DD/MM/YYYY'), '119/2 duong Binh Tan, phuong Long Hung, quan Duong Kinh, Thanh pho Hung Yen, Tinh Hung Yen', '09421289397', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0070', 'Tran Ha Lien', 'NU', TO_DATE('26/05/2003', 'DD/MM/YYYY'), '288 duong Do Son, phuong Bach Mai, quan Phu Nhuan, Thanh pho Lao Cai, Tinh Lao Cai', '09622180235', 'CLC', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0071', 'Dang Phi Phi', 'NU', TO_DATE('27/03/2002', 'DD/MM/YYYY'), '304/49G duong Tay Ho, phuong Duong Noi, Thanh pho My Tho, Tinh Tien Giang', '09950622799', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0072', 'Hoang Binh An', 'NAM', TO_DATE('20/02/2005', 'DD/MM/YYYY'), '247/5 duong Tan Phu, phuong Trung Hoa, quan Thanh Xuan, Thanh pho Cao Lanh, Tinh Dong Thap', '09133771112', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0073', 'Ho Ngoc Ðiep', 'NU', TO_DATE('19/06/2004', 'DD/MM/YYYY'), '96Y duong Tan Binh, phuong Hai Thanh, Quan 4, Thanh pho Bac Lieu, Tinh Bac Lieu', '09236078096', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0074', 'Hoang Huy Tuan', 'NAM', TO_DATE('25/02/2000', 'DD/MM/YYYY'), '374/9P duong Thot Not, phuong My An, quan Cai Rang, Thanh pho Bac Ninh, Tinh Bac Ninh', '09478580701', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0075', 'Vu Khanh Ha', 'NU', TO_DATE('07/06/2003', 'DD/MM/YYYY'), '157Y duong Ha Dong, Phuong 28, quan Hoan Kiem, Thanh pho Nam Dinh, Tinh Nam Dinh', '09890182447', 'CTTT', 'CNTT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0076', 'Truong Kim Duyen', 'NU', TO_DATE('14/11/2003', 'DD/MM/YYYY'), '49 duong Ha Dong, phuong Quoc Tu Giam, quan Kien An, Thanh pho Ha Noi', '09311680125', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0077', 'Duong Khanh Mai', 'NU', TO_DATE('13/05/2005', 'DD/MM/YYYY'), '173Q duong Quan 1, phuong Gia Vien, Quan 5, Thanh pho Vinh, Tinh Nghe An', '09096549921', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0078', 'Huynh Cong Lap', 'NAM', TO_DATE('16/03/2004', 'DD/MM/YYYY'), '392 duong Ha Dong, phuong Dong Ngac, quan Cai Rang, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09515308479', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0079', 'Ngo Minh Nguyet', 'NU', TO_DATE('19/07/2000', 'DD/MM/YYYY'), '11/14C duong Lien Chieu, phuong Hai Thanh, quan Lien Chieu, Thanh pho Ca Mau, Tinh Ca Mau', '09868949593', 'VP', 'CNTT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0080', 'Truong Cuong Nghi', 'NAM', TO_DATE('16/01/2003', 'DD/MM/YYYY'), '288K duong Quan 3, phuong Tan An, Thanh pho Tan An, Tinh Long An', '09426447909', 'VP', 'CNTT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 5. SINH VIEN TGMT
--	1. CQ
	SELECT 'SV0081', 'Nguyen Nghi Luc', 'NAM', TO_DATE('19/07/2002', 'DD/MM/YYYY'), '118 duong Quan 4, phuong Thuong Thanh, quan Binh Tan, Thanh pho Phan Rang - Thap Cham, Tinh Ninh Thuan', '09767300565', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0082', 'Nguyen Nguyen Giap', 'NAM', TO_DATE('01/06/2002', 'DD/MM/YYYY'), '40 duong Quan 4, phuong So Dau, Thanh pho Ha Long, Tinh Quang Ninh', '09427118719', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0083', 'Vo Quoc Hung', 'NAM', TO_DATE('06/04/2001', 'DD/MM/YYYY'), '80 duong Cai Rang, phuong Ha Cau, Quan 11, Thanh pho Thanh Hoa, Tinh Thanh Hoa', '09421819098', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0084', 'Huynh Thanh Mai', 'NU', TO_DATE('08/05/2003', 'DD/MM/YYYY'), '105K duong Go Vap, phuong Hang Kenh, quan Binh Tan, Thanh pho Hai Duong, Tinh Hai Duong', '09723725687', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0085', 'Ngo Tram Anh', 'NU', TO_DATE('26/05/2001', 'DD/MM/YYYY'), '86/41 duong O Mon, phuong Nam Duong, Thanh pho Long Xuyen, Tinh An Giang', '09745839986', 'CQ', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0086', 'Vo Duy Khiem', 'NAM', TO_DATE('09/11/2004', 'DD/MM/YYYY'), '215 duong Go Vap, phuong Nhan Chinh, Thanh pho Thai Nguyen, Tinh Thai Nguyen', '09545267907', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0087', 'Duong Bao Ha', 'NU', TO_DATE('23/09/2005', 'DD/MM/YYYY'), '202 duong Son Tra, phuong Mai Dich, quan Go Vap, Thanh pho Dong Xoai, Tinh Binh Phuoc', '09753695499', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0088', 'Truong Tam Nhi', 'NU', TO_DATE('22/10/2003', 'DD/MM/YYYY'), '294/47 duong Quan 3, phuong Phuoc Thoi, quan Long Bien, Thanh pho Hai Duong, Tinh Hai Duong', '09947473122', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0089', 'Le Kim Lien', 'NU', TO_DATE('17/11/2003', 'DD/MM/YYYY'), '69/42I duong Lien Chieu, phuong Son Ky, quan Cai Rang, Thanh pho Da Nang', '09081296313', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0090', 'Le Thuong Xuan', 'NU', TO_DATE('08/09/2004', 'DD/MM/YYYY'), '307/3A duong Tan Phu, phuong An Phu, Thanh pho My Tho, Tinh Tien Giang', '09942996827', 'CLC', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0091', 'Tran Xuan Lac', 'NAM', TO_DATE('12/09/2001', 'DD/MM/YYYY'), '249Z duong Phu Nhuan, phuong Nguyen Trai, Thanh pho Rach Gia, Tinh Kien Giang', '09447505686', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0092', 'Ly Thach Son', 'NAM', TO_DATE('16/12/2002', 'DD/MM/YYYY'), '148W duong Cam Le, phuong Dong Hai, quan Hong Bang, Thanh pho Bac Ninh, Tinh Bac Ninh', '09449008445', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0093', 'Vu Yen Hong', 'NU', TO_DATE('15/03/2004', 'DD/MM/YYYY'), '382/25 duong Thanh Khe, phuong Le Binh, Quan 5, Thanh pho Vi Thanh, Tinh Hau Giang', '09709413749', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0094', 'Hoang Que Linh', 'NU', TO_DATE('21/10/2004', 'DD/MM/YYYY'), '42/33 duong Hai Ba Trung, phuong Hung Vuong, Thanh pho Nha Trang, Tinh Khanh Hoa', '09844712169', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0095', 'Nguyen Le Chi', 'NU', TO_DATE('11/03/2000', 'DD/MM/YYYY'), '394V duong Hoang Mai, phuong Tra An, Thanh pho Ba Ria, Tinh Ba Ria - Vung Tau', '09597774007', 'CTTT', 'TGMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0096', 'Huynh Huu Tho', 'NAM', TO_DATE('05/06/2005', 'DD/MM/YYYY'), '169/38 duong Tan Phu, phuong Hang Ma, Thanh pho Gia Nghia, Tinh Dak Nong', '09503561372', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0097', 'Dang To Loan', 'NU', TO_DATE('10/02/2005', 'DD/MM/YYYY'), '183J duong Quan 7, phuong Thuong Dinh, quan Go Vap, Thanh pho Ha Noi', '09350359307', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0098', 'Tran Tu Tam', 'NU', TO_DATE('25/02/2005', 'DD/MM/YYYY'), '107 duong Quan 11, phuong Tan Quy, quan Son Tra, Thanh pho My Tho, Tinh Tien Giang', '09119307006', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0099', 'Truong Minh Tri', 'NAM', TO_DATE('24/04/2005', 'DD/MM/YYYY'), '368/32W duong Cai Rang, phuong Dong Xuan, quan O Mon, Thanh pho Vinh, Tinh Nghe An', '09624686653', 'VP', 'TGMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0100', 'Pham Hoan Chau', 'NU', TO_DATE('29/03/2004', 'DD/MM/YYYY'), '225/49U duong Long Bien, phuong Nam Duong, quan Binh Thuy, Thanh pho Ho Chi Minh', '09158670550', 'VP', 'TGMT', 0, 0 FROM DUAL;
INSERT INTO SINHVIEN
-- 6. SINH VIEN MMT
--	1. CQ
	SELECT 'SV0101', 'Duong Tri Hao', 'NAM', TO_DATE('05/08/2005', 'DD/MM/YYYY'), '251/13H duong Le Chan, Phuong 4, Thanh pho Cao Lanh, Tinh Dong Thap', '09195138281', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0102', 'Tran Hong Chau', 'NU', TO_DATE('02/01/2002', 'DD/MM/YYYY'), '81 duong Lien Chieu, phuong Giap Bat, Quan 4, Thanh pho Hai Phong', '09421928358', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0103', 'Truong Xuan Ham', 'NAM', TO_DATE('06/09/2004', 'DD/MM/YYYY'), '42/1 duong Ba Dinh, phuong Hai Thanh, Quan 8, Thanh pho My Tho, Tinh Tien Giang', '09389890079', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0104', 'Truong Viet Thai', 'NAM', TO_DATE('09/12/2005', 'DD/MM/YYYY'), '180 duong Thanh Khe, phuong Thanh Hoa, Thanh pho Lao Cai, Tinh Lao Cai', '09742897016', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0105', 'Ly Thanh Lam', 'NU', TO_DATE('30/08/2003', 'DD/MM/YYYY'), '199/44 duong Cam Le, phuong Binh Hung Hoa A, Quan 12, Thanh pho Nam Dinh, Tinh Nam Dinh', '09004547402', 'CQ', 'MMT', 0, 0 FROM DUAL UNION ALL
--	2. CLC
	SELECT 'SV0106', 'Vo Xuan Han', 'NAM', TO_DATE('02/04/2003', 'DD/MM/YYYY'), '393S duong Hong Bang, phuong Bui Huu Nghia, Thanh pho Ninh Binh, Tinh Ninh Binh', '09595484296', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0107', 'Nguyen Quang Tai', 'NAM', TO_DATE('08/08/2000', 'DD/MM/YYYY'), '185 duong Cai Rang, phuong Kenh Duong, quan Lien Chieu, Thanh pho Lao Cai, Tinh Lao Cai', '09088422821', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0108', 'Le Thien Duyen', 'NU', TO_DATE('13/09/2005', 'DD/MM/YYYY'), '148/7 duong Quan 8, phuong Long Tuyen, quan Kien An, Thanh pho Thanh Hoa, Tinh Thanh Hoa', '09848458067', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0109', 'Huynh Chi Khiem', 'NAM', TO_DATE('12/07/2004', 'DD/MM/YYYY'), '291/47U duong Quan 5, phuong Trung Nhut, quan Binh Tan, Thanh pho Nam Dinh, Tinh Nam Dinh', '09849506695', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0110', 'Vu Ha Hai', 'NAM', TO_DATE('11/09/2004', 'DD/MM/YYYY'), '290Z duong Cau Giay, Xuan Phuong, Thanh pho Viet Tri, Tinh Phu Tho', '09725850019', 'CLC', 'MMT', 0, 0 FROM DUAL UNION ALL
--	3. CTTT
	SELECT 'SV0111', 'Vu Diem Thuy', 'NU', TO_DATE('28/04/2005', 'DD/MM/YYYY'), '396/31J duong Ha Dong, phuong Yet Kieu, quan Thot Not, Thanh pho Pleiku, Tinh Gia Lai', '09781259175', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0112', 'Dang Thao Hong', 'NU', TO_DATE('07/08/2004', 'DD/MM/YYYY'), '52 duong Bac Tu Liem, phuong Phu Lien, Quan 1, Thanh pho Tra Vinh, Tinh Tra Vinh', '09271004824', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0113', 'Duong Van Trinh', 'NU', TO_DATE('27/12/2004', 'DD/MM/YYYY'), '315/2Y duong Quan 12, phuong Thanh Xuan, Thanh pho Lai Chau, Tinh Lai Chau', '09811424751', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0114', 'Ho Hai Thao', 'NU', TO_DATE('02/10/2000', 'DD/MM/YYYY'), '139/7 duong Phu Nhuan, phuong Cau Kho, quan Ba Dinh, Thanh pho Lai Chau, Tinh Lai Chau', '09438566980', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0115', 'Do Duy Kinh', 'NAM', TO_DATE('08/03/2000', 'DD/MM/YYYY'), '164 duong Kien An, phuong Thuan Phuoc, Thanh pho Ha Long, Tinh Quang Ninh', '09283957385', 'CTTT', 'MMT', 0, 0 FROM DUAL UNION ALL
--	4. VP
	SELECT 'SV0116', 'Tran Truong Hiep', 'NAM', TO_DATE('15/09/2000', 'DD/MM/YYYY'), '115/48 duong Quan 4, phuong Buoi, Thanh pho Ba Ria, Tinh Ba Ria - Vung Tau', '09323366365', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0117', 'Dinh Linh Trang', 'NU', TO_DATE('19/04/2000', 'DD/MM/YYYY'), '301/9 duong Phu Nhuan, phuong La Khe, quan Thanh Khe, Thanh pho Quang Ngai, Tinh Quang Ngai', '09792327848', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0118', 'Ho Huan Vo', 'NAM', TO_DATE('03/08/2001', 'DD/MM/YYYY'), '254/27X duong Le Chan, phuong Yen Hoa, Quan 6, Thanh pho Tuyen Quang, Tinh Tuyen Quang', '09089682408', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0119', 'Nguyen Dan Tam', 'NAM', TO_DATE('18/04/2003', 'DD/MM/YYYY'), '104 duong Thanh Khe, phuong Tan Dinh, Thanh pho Nam Dinh, Tinh Nam Dinh', '09792652106', 'VP', 'MMT', 0, 0 FROM DUAL UNION ALL
	SELECT 'SV0120', 'Hoang Hong Truc', 'NU', TO_DATE('01/04/2004', 'DD/MM/YYYY'), '76I duong Le Chan, phuong Tran Phu, quan Son Tra, Thanh pho Hai Duong, Tinh Hai Duong', '09161357147', 'VP', 'MMT', 0, 0 FROM DUAL;
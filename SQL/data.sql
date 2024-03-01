CL SCR;

ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;

TRUNCATE TABLE VAITRO CASCADE;
TRUNCATE TABLE DONVI CASCADE;
TRUNCATE TABLE CTDAOTAO CASCADE;
TRUNCATE TABLE NGANH CASCADE;

INSERT INTO VAITRO(TENVT)
    SELECT 'NHAN VIEN CO BAN' FROM DUAL UNION ALL
    SELECT 'GIANG VIEN' FROM DUAL UNION ALL
    SELECT 'GIAO VU' FROM DUAL UNION ALL
    SELECT 'TRUONG DON VI' FROM DUAL UNION ALL
    SELECT 'TRUONG KHOA' FROM DUAL;

INSERT INTO DONVI(TENDV)
    SELECT 'VAN PHONG KHOA' FROM DUAL UNION ALL
    SELECT 'BO MON HTTT' FROM DUAL UNION ALL
    SELECT 'BO MON CNPM' FROM DUAL UNION ALL
    SELECT 'BO MON KHMT' FROM DUAL UNION ALL
    SELECT 'BO MON CNTT' FROM DUAL UNION ALL
    SELECT 'BO MON TGMT' FROM DUAL UNION ALL
    SELECT 'BO MON MMT VA VIEN THONG' FROM DUAL;

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
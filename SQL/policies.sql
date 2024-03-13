CL SCR;
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
CREATE OR REPLACE PROCEDURE USP_ASSIGN_ROLE(
    RL CHAR(2), WHO CHAR(2), CAP INT
) AS IX INT := 1;
BEGIN
    CAP := CAP + 1;
    LOOP
        IX := IX + 1;
        EXIT WHEN IX = CAP;
        EXECUTE IMMEDIATE 'GRANT RL_A01_' || RL
            || ' TO ' || WHO || LPAD(IX, 4, '0');
    END LOOP;
END;
/

VAR CNT INT;

/* CS1: NHAN VIEN CO BAN
 */
CREATE ROLE RL_A01_NV;
EXEC USP_ASSIGN_ROLE('NV', 'NV', 10);

-- Xem dong du lieu cua chinh minh trong quan he NHANSU, co the chinh sua
--  so dien thoai (DT) cua chinh minh (neu so dien thoai co thay doi).
CREATE OR REPLACE VIEW V_NHANSU_NV
AS SELECT * FROM NHANSU
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
        AND VAITRO = 1
    WITH CHECK OPTION;

GRANT SELECT, UPDATE(DT) ON V_NHANSU_NV TO RL_A01_NV;

-- Xem thong tin cua tat ca SINHVIEN, DONVI, HOCPHAN, KHMO.
GRANT SELECT ON SINHVIEN TO RL_A01_NV;
GRANT SELECT ON DONVI TO RL_A01_NV;
GRANT SELECT ON HOCPHAN TO RL_A01_NV;
GRANT SELECT ON KHMO TO RL_A01_NV;

/* CS2: GIANG VIEN
 */
CREATE ROLE RL_A01_GN;
EXEC USP_ASSIGN_ROLE('GN', 'GN', 80);

-- Nhu mot nguoi dung co vai tro "Nhan vien co ban" (CS1).
EXEC USP_ASSIGN_ROLE('NV', 'GN', 80);

-- Xem du lieu phan cong giang day lien quan den ban than minh (PHANCONG).
CREATE OR REPLACE VIEW V_PHANCONG_GN
AS SELECT * FROM PHANCONG
    WHERE MAGV = (SELECT MANV FROM NHANSU
        WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
            AND VAITRO = 2);

GRANT SELECT ON V_PHANCONG_GN TO RL_A01_GN;

-- Xem du lieu tren quan he DANGKY lien quan den cac lop hoc phan ma giang
--  vien duoc phan cong giang day.

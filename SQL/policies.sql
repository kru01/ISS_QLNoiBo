CL SCR;
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
CREATE OR REPLACE PROCEDURE USP_ASSIGN_ROLE(
    RL VARCHAR2, WHO VARCHAR2, TAB VARCHAR2, COLN VARCHAR2
) AS
    CUR SYS_REFCURSOR;
    USR VARCHAR2(6);
BEGIN
    OPEN CUR FOR 'SELECT ' || COLN || ' FROM ' || TAB
        || ' WHERE ' || COLN || ' LIKE ''' || WHO || '%'' AND '
        || COLN || ' IN (SELECT USERNAME FROM ALL_USERS)';
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
        EXECUTE IMMEDIATE 'GRANT RL_A01_' || RL || ' TO ' || USR;
    END LOOP;
    CLOSE CUR;
END;
/

/* CS1: NHAN VIEN CO BAN - NV0001
 */
CREATE ROLE RL_A01_NV;
EXEC USP_ASSIGN_ROLE('NV', 'NV', 'NHANSU', 'MANV');

-- Xem dong du lieu cua chinh minh trong quan he NHANSU, co the chinh sua
--  so dien thoai (DT) cua chinh minh (neu so dien thoai co thay doi).
CREATE OR REPLACE VIEW V_NHANSU_NV
AS SELECT * FROM NHANSU
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    WITH CHECK OPTION;

GRANT SELECT, UPDATE(DT) ON V_NHANSU_NV TO RL_A01_NV;

-- Xem thong tin cua tat ca SINHVIEN, DONVI, HOCPHAN, KHMO.
GRANT SELECT ON SINHVIEN TO RL_A01_NV;
GRANT SELECT ON DONVI TO RL_A01_NV;
GRANT SELECT ON HOCPHAN TO RL_A01_NV;
GRANT SELECT ON KHMO TO RL_A01_NV;

/* CS2: GIANG VIEN - V20062
 */
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
CREATE ROLE RL_A01_V;
EXEC USP_ASSIGN_ROLE('V', 'V', 'NHANSU', 'MANV');

-- Nhu mot nguoi dung co vai tro "Nhan vien co ban" (CS1).
EXEC USP_ASSIGN_ROLE('NV', 'V', 'NHANSU', 'MANV');

-- Xem du lieu phan cong giang day lien quan den ban than minh (PHANCONG).
CREATE OR REPLACE FUNCTION PFN_PHANCONG_SEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 1) = 'V' THEN
        RETURN 'MAGV = ''' || USR || '''';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'POL_PHANCONG_SEL',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_PHANCONG_SEL',
    STATEMENT_TYPES  => 'SELECT'
); END;
/

GRANT SELECT ON PHANCONG TO RL_A01_V;

-- Xem du lieu tren quan he DANGKY lien quan den cac lop hoc phan ma giang
--  vien duoc phan cong giang day.
CREATE OR REPLACE VIEW V_DANGKY_V
AS SELECT * FROM DANGKY
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    WITH CHECK OPTION;

GRANT SELECT ON V_DANGKY_V TO RL_A01_V;

-- Cap nhat du lieu tai cac truong lien quan diem so (trong quan he DANGKY)
--  cua cac sinh vien co tham gia lop hoc phan ma giang vien do duoc phan
--  cong giang day.
-- Cac truong lien quan diem so bao gom: DIEMTH, DIEMQT, DIEMCK, DIEMTK.
GRANT UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON V_DANGKY_V TO RL_A01_V;

/* CS3: GIAO VU - GV0001
 */
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
CREATE ROLE RL_A01_GV;
EXEC USP_ASSIGN_ROLE('GV', 'GV', 'NHANSU', 'MANV');

-- Nhu mot nguoi dung co vai tro "Nhan vien co ban" (xem mo ta CS#1).
EXEC USP_ASSIGN_ROLE('NV', 'GV', 'NHANSU', 'MANV');

-- Xem, Them moi hoac Cap nhat du lieu tren cac quan he SINHVIEN, DONVI,
--  HOCPHAN, KHMO, theo yeu cau cua truong khoa.
GRANT SELECT, INSERT, UPDATE ON SINHVIEN TO RL_A01_GV;
GRANT SELECT, INSERT, UPDATE ON DONVI TO RL_A01_GV;
GRANT SELECT, INSERT, UPDATE ON HOCPHAN TO RL_A01_GV;
GRANT SELECT, INSERT, UPDATE ON KHMO TO RL_A01_GV;

-- Xem du lieu tren toan bo quan he PHANCONG. Tuy nhien, chi duoc sua tren
--  cac dong du lieu phan cong lien quan cac hoc phan do "Van phong khoa"
--  phu trach phan cong giang day, thua hanh nguoi truong don vi tuong ung
--  la truong khoa.
CREATE OR REPLACE FUNCTION PFN_PHANCONG_EDIT(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 2) = 'GV' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = 1)';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'POL_PHANCONG_EDIT',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_PHANCONG_EDIT',
    STATEMENT_TYPES  => 'UPDATE',
    UPDATE_CHECK => TRUE
); END;
/

GRANT SELECT, UPDATE ON PHANCONG TO RL_A01_GV;

-- Xoa hoac Them moi du lieu tren quan he DANGKY theo yeu cau cua sinh vien
--  trong khoang thoi gian con cho hieu chinh dang ky, xem dieu kien co the
--  hieu chinh dang ky hoc phan duoc mo ta ben duoi.
-- ++ Sinh vien co the hieu chinh dang ky hoc phan (them, xoa) neu ngay hien
--  tai khong vuot qua 14 ngay so voi ngay bat dau hoc ky (Moi nam hoc co
--  3 hoc ky bat dau tuong ung vao ngay dau tien cac thang 1, 5, 9) ma sinh
--  vien dang hieu chinh dang ky hoc phan.
CREATE OR REPLACE FUNCTION PFN_DANGKY_INS_DEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    DIFF FLOAT; HK CHAR(1);
    MO NUMBER(2) := TO_NUMBER(TO_CHAR(SYSDATE, 'MM'));
    YE NUMBER(4) := TO_NUMBER(TO_CHAR(SYSDATE, 'YYYY'));
BEGIN
    IF MO < 5 THEN HK := '1';
        DIFF :=  SYSDATE - TO_DATE('01/01' || YE, 'DD/MM/YYYY');
    ELSIF MO < 9 THEN HK := '2';
        DIFF :=  SYSDATE - TO_DATE('01/05' || YE, 'DD/MM/YYYY');
    ELSE HK := '3';
        DIFF :=  SYSDATE - TO_DATE('01/09' || YE, 'DD/MM/YYYY');
    END IF;

    RETURN 'HK = ' || HK || ' AND NAM = ' || YE
        || 'AND 0 < ' || DIFF || ' AND ' || DIFF || '<= 14';
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'DANGKY',
    POLICY_NAME  => 'POL_DANGKY_INS_DEL',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_DANGKY_INS_DEL',
    STATEMENT_TYPES  => 'INSERT, DELETE',
    UPDATE_CHECK => TRUE
); END;
/

-- -- Explanation on why SELECT is needed --
-- If the SQL92_SECURITY initialization parameter is set to TRUE and the
--  DELETE operation references table columns, such as the columns in a
--  where_clause, then you must also have the SELECT object privilege on
--  the object from which you want to delete rows.
-- https://asktom.oracle.com/ords/f?p=100:11:::::P11_QUESTION_ID:9540272000346577040
GRANT SELECT, INSERT, DELETE ON DANGKY TO RL_A01_GV;

/* CS4: TRUONG DON VI - TD0001
 */
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
CREATE ROLE RL_A01_TD;
EXEC USP_ASSIGN_ROLE('TD', 'TD', 'NHANSU', 'MANV');

-- Nhu mot nguoi dung co vai tro "Giang vien" (xem mo ta CS#2).
EXEC USP_ASSIGN_ROLE('V', 'TD', 'NHANSU', 'MANV');

-- Them, Xoa, Cap nhat du lieu tren quan he PHANCONG, doi voi cac hoc phan
--  duoc phu trach chuyen mon boi don vi ma minh lam truong.
CREATE OR REPLACE FUNCTION PFN_PHANCONG_EDIT(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := SUBSTR(USR, 1, 2);
BEGIN
    IF STR = 'GV' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = 1)';
    END IF;
    IF STR = 'TD' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN
            WHERE MADV = (SELECT MADV FROM NHANSU
                WHERE MANV = ''' || USR || '''))';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.DROP_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'POL_PHANCONG_EDIT'
); END;
/
BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'POL_PHANCONG_EDIT',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_PHANCONG_EDIT',
    STATEMENT_TYPES  => 'INSERT, DELETE, UPDATE',
    UPDATE_CHECK => TRUE
); END;
/

GRANT INSERT, DELETE, UPDATE ON PHANCONG TO RL_A01_TD;

-- Duoc xem du lieu phan cong giang day cua cac giang vien thuoc cac don vi
--  ma minh lam truong.
CREATE OR REPLACE FUNCTION PFN_PHANCONG_SEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 1) = 'V' THEN
        RETURN 'MAGV = ''' || USR || '''';
    END IF;
    IF SUBSTR(USR, 1, 2) = 'TD' THEN
        RETURN 'MAGV IN (SELECT MANV FROM NHANSU
            WHERE MADV = (SELECT MADV FROM NHANSU
                WHERE MANV = ''' || USR || '''))';
    END IF;
    RETURN NULL;
END;
/

GRANT SELECT ON PHANCONG TO RL_A01_TD;

/* CS5: TRUONG KHOA - TK0001
 */
-- Nhu mot nguoi dung co vai tro "Giang vien".
EXEC USP_ASSIGN_ROLE('V', 'TK', 'NHANSU', 'MANV');

-- Them, Xoa, Cap nhat du lieu tren quan he PHANCONG doi voi cac hoc phan
--  quan ly boi don vi "Van phong khoa".
CREATE OR REPLACE FUNCTION PFN_PHANCONG_EDIT(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := SUBSTR(USR, 1, 2);
BEGIN
    IF STR = 'GV' OR STR = 'TK' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = 1)';
    END IF;
    IF STR = 'TD' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN
            WHERE MADV = (SELECT MADV FROM NHANSU
                WHERE MANV = ''' || USR || '''))';
    END IF;
    RETURN NULL;
END;
/

GRANT SELECT, INSERT, DELETE, UPDATE ON PHANCONG TO TK0001;

-- Duoc quyen Xem, Them, Xoa, Cap nhat tren quan he NHANSU.
GRANT SELECT, INSERT, DELETE, UPDATE ON NHANSU TO TK0001;

-- Duoc quyen Xem (khong gioi han) du lieu tren toan bo luoc do CSDL.
BEGIN
    FOR TAB IN (SELECT OWNER, TABLE_NAME FROM ALL_TABLES
        WHERE OWNER='A01_QLNOIBO') LOOP
        EXECUTE IMMEDIATE 'GRANT SELECT ON '
            || TAB.OWNER || '.' || TAB.TABLE_NAME || ' TO TK0001';
    END LOOP;
END;
/

/* CS6: SINH VIEN - S40018
 */
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;
CREATE ROLE RL_A01_S;
EXEC USP_ASSIGN_ROLE('S', 'S', 'SINHVIEN', 'MASV');

-- Tren quan he SINHVIEN, sinh vien chi duoc xem thong tin cua chinh minh,
--  duoc Chinh sua thong tin dia chi (DCHI) va so dien thoai lien lac (DT)
--  cua chinh sinh vien.
CREATE OR REPLACE FUNCTION PFN_SINHVIEN(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 1) = 'S' THEN RETURN 'MASV = ''' || USR || '''';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'SINHVIEN',
    POLICY_NAME  => 'POL_SINHVIEN',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_SINHVIEN',
    STATEMENT_TYPES  => 'SELECT, UPDATE',
    UPDATE_CHECK => TRUE
); END;
/

-- Xem danh sach tat ca hoc phan (HOCPHAN), ke hoach mo mon (KHMO) cua
--  chuong trinh dao tao ma sinh vien dang theo hoc.
CREATE OR REPLACE FUNCTION PFN_KHMO(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 1) = 'S' THEN
        RETURN 'MACT = (SELECT MACT FROM SINHVIEN
            WHERE MASV = ''' || USR || ''')';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'KHMO',
    POLICY_NAME  => 'POL_KHMO',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_KHMO',
    STATEMENT_TYPES  => 'SELECT'
); END;
/

GRANT SELECT ON HOCPHAN TO RL_A01_S;
GRANT SELECT ON KHMO TO RL_A01_S;

-- Them, Xoa cac dong du lieu dang ky hoc phan (DANGKY) lien quan den chinh
--  sinh vien do trong hoc ky cua nam hoc hien tai (neu thoi diem hieu chinh
--  dang ky con hop le).
CREATE OR REPLACE FUNCTION PFN_DANGKY_INS_DEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := ''; DIFF FLOAT; HK CHAR(1);
    MO NUMBER(2) := TO_NUMBER(TO_CHAR(SYSDATE, 'MM'));
    YE NUMBER(4) := TO_NUMBER(TO_CHAR(SYSDATE, 'YYYY'));
BEGIN
    IF MO < 5 THEN HK := '1';
        DIFF :=  SYSDATE - TO_DATE('01/03' || YE, 'DD/MM/YYYY');
    ELSIF MO < 9 THEN HK := '2';
        DIFF :=  SYSDATE - TO_DATE('01/05' || YE, 'DD/MM/YYYY');
    ELSE HK := '3';
        DIFF :=  SYSDATE - TO_DATE('01/09' || YE, 'DD/MM/YYYY');
    END IF;

    IF SUBSTR(USR, 1, 1) = 'S' THEN
        STR := 'MASV = ''' || USR || ''' AND ';
    END IF;
    RETURN STR || 'HK = ' || HK || ' AND NAM = ' || YE
        || 'AND 0 < ' || DIFF || ' AND ' || DIFF || '<= 14';
END;
/

GRANT INSERT, DELETE ON DANGKY TO RL_A01_S;

-- Sinh vien khong duoc chinh sua tren cac truong lien quan den diem.
CREATE OR REPLACE FUNCTION PFN_DANGKY_INS_DEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := ''; DIFF FLOAT; HK CHAR(1);
    SCO VARCHAR2(100) := 'DIEMTH IS NULL AND DIEMQT IS NULL '
        || 'AND DIEMCK IS NULL AND DIEMTK IS NULL AND ';
    MO NUMBER(2) := TO_NUMBER(TO_CHAR(SYSDATE, 'MM'));
    YE NUMBER(4) := TO_NUMBER(TO_CHAR(SYSDATE, 'YYYY'));
BEGIN
    IF MO < 5 THEN HK := '1';
        DIFF :=  SYSDATE - TO_DATE('01/03' || YE, 'DD/MM/YYYY');
    ELSIF MO < 9 THEN HK := '2';
        DIFF :=  SYSDATE - TO_DATE('01/05' || YE, 'DD/MM/YYYY');
    ELSE HK := '3';
        DIFF :=  SYSDATE - TO_DATE('01/09' || YE, 'DD/MM/YYYY');
    END IF;

    IF SUBSTR(USR, 1, 1) = 'S' THEN
        STR := 'MASV = ''' || USR || ''' AND ';
    END IF;
    RETURN STR || SCO || 'HK = ' || HK || ' AND NAM = ' || YE
        || 'AND 0 < ' || DIFF || ' AND ' || DIFF || '<= 14';
END;
/

-- Sinh vien duoc Xem tat ca thong tin tren quan he DANGKY tai cac dong du
--  lieu lien quan den chinh sinh vien.
CREATE OR REPLACE FUNCTION PFN_DANGKY_SEL(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 1) = 'S' THEN
        RETURN 'MASV = ''' || USR || '''';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'DANGKY',
    POLICY_NAME  => 'POL_DANGKY_SEL',
    FUNCTION_SCHEMA  => 'A01_QLNOIBO',
    POLICY_FUNCTION  => 'PFN_DANGKY_SEL',
    STATEMENT_TYPES  => 'SELECT'
); END;
/

GRANT SELECT ON DANGKY TO RL_A01_S;
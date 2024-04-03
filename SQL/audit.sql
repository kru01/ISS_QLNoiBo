CL SCR;
CONN AD0001/123@LOCALHOST:1521/XEPDB1;

/* 1. Kich hoat viec ghi nhat ky he thong.
 */
/*      -- ENABLING UNIFIED AUDIT --
 * - https://docs.oracle.com/database/121/TDPSG/GUID-BF747771-01D1-4BFB-8489-08988E1181F6.htm#TDPSG55281
 * - https://www.ibm.com/docs/en/dsm?topic=record-enabling-unified-auditing-in-oracle-12c
 * - https://youtu.be/vo3g_kAQM1E?si=HB89-hvF-7Js6Zvt
 */
SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Unified Auditing';

/* PURGE THE UNIFIED AUDIT TRAIL, IF NECESSARY.
 */
-- BEGIN DBMS_AUDIT_MGMT.CLEAN_AUDIT_TRAIL(
--     AUDIT_TRAIL_TYPE  => DBMS_AUDIT_MGMT.AUDIT_TRAIL_UNIFIED,
--     USE_LAST_ARCH_TIMESTAMP  => FALSE
-- ); END;
-- /

/* 2. Thuc hien ghi nhat ky he thong dung Standard audit.
 *  Theo doi hanh vi cua nhung user nao tren nhung doi tuong cu the, tren
 *  cac doi tuong khac nhau (table, view, stored procedure, function), hay
 *  chi dinh theo doi cac hanh vi hien thanh cong hay khong thanh cong.
 */
-- HANDY FOR CHECKING AUDIT POLICIES
SELECT * FROM AUDIT_UNIFIED_POLICIES WHERE ORACLE_SUPPLIED != 'YES';

/* General standard audits showcasing privileges, actions, roles, when and
 *  evaluate clause. On all users except SYS, no matter successful or not.
 */
CREATE AUDIT POLICY AUDPOL_GENERAL
PRIVILEGES UPDATE ANY TABLE, DROP ANY TABLE, DROP USER, DROP ANY ROLE
ACTIONS ALL ON A01_QLNOIBO.NHANSU,
    INSERT, DELETE, UPDATE ON A01_QLNOIBO.SINHVIEN,
    INSERT, DELETE, UPDATE ON A01_QLNOIBO.PHANCONG,
    UPDATE ON A01_QLNOIBO.V_DANGKY_V,
    ALTER USER, DROP USER, DROP ROLE
ROLES RL_A01_GV -- THIS ROLE DOESN'T HAVE ANY SYS PRIV, ONLY FOR SHOW
WHEN 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') != ''SYS'''
EVALUATE PER SESSION;

AUDIT POLICY AUDPOL_GENERAL;

-- AUD: ALL ON NHANSU
CONN TK0001/123@LOCALHOST:1521/XEPDB1;
SELECT * FROM A01_QLNOIBO.NHANSU WHERE MANV = 'TK0001';
UPDATE A01_QLNOIBO.NHANSU SET MANV = MANV WHERE MANV = 'TK0001';
-- AUD: UPDATE ON SINHVIEN
CONN GV0001/123@LOCALHOST:1521/XEPDB1;
UPDATE A01_QLNOIBO.SINHVIEN SET MASV = MASV WHERE MASV = 'S10001';
-- AUD: DELETE ON PHANCONG
CONN TD0001/123@LOCALHOST:1521/XEPDB1;
DELETE FROM A01_QLNOIBO.PHANCONG WHERE MAGV = '-1';
-- AUD: UPDATE ON V_DANGKY_V
CONN V20062/123@LOCALHOST:1521/XEPDB1;
UPDATE A01_QLNOIBO.V_DANGKY_V SET DIEMTH = DIEMTH WHERE MASV = 'S10081';
-- AUD: UPDATE ANY TABLE, DROP ANY ROLE, DROP ROLE
CONN AD0001/123@LOCALHOST:1521/XEPDB1;
UPDATE A01_QLNOIBO.CTDAOTAO SET MACT = MACT WHERE MACT = 'CQ';
CREATE ROLE RL_A01_AUDTEST; DROP ROLE RL_A01_AUDTEST;

/* General standard audits showcasing execute on procedures. On TK0001, only
 *  when unsuccessful, i.e., "only invalid object errors, non-existent
 *  object errors, and authorization failures are audited; errors
 *  encountered during the execution of the procedure or function are
 *  not audited."
 */
CREATE AUDIT POLICY AUDPOL_GENERAL_USP
ACTIONS EXECUTE ON A01_QLNOIBO.USP_CREATE_USERS,
    EXECUTE ON A01_QLNOIBO.USP_ASSIGN_ROLE;

AUDIT POLICY AUDPOL_GENERAL_USP BY TK0001 WHENEVER NOT SUCCESSFUL;

CONN TK0001/123@LOCALHOST:1521/XEPDB1;
-- SHOULD THROW SOME ERRORS, JUST IGNORE THEM
EXEC A01_QLNOIBO.USP_CREATE_USERS();
EXEC A01_QLNOIBO.USP_ASSIGN_ROLE('NV', 'NV', 'NHANSU', 'MANV');

/* DISPLAY STANDARD AUDITS
 */
CONN AD0001/123@LOCALHOST:1521/XEPDB1;
SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, SCN, ACTION_NAME, OBJECT_SCHEMA,
    OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, OBJECT_PRIVILEGES,
    TARGET_USER, CURRENT_USER, UNIFIED_AUDIT_POLICIES,
    FGA_POLICY_NAME FROM UNIFIED_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'Standard'
    AND (UNIFIED_AUDIT_POLICIES LIKE '%AUDPOL_GENERAL%'
        OR UNIFIED_AUDIT_POLICIES LIKE '%AUDPOL_GENERAL_USP%')
ORDER BY EVENT_TIMESTAMP;

/* 3. Thuc hien Fine-grained Audit cac tinh huong sau va tao ngu canh de co
 *  the ghi viet duoc (co du lieu ghi vet) cac hanh vi sau:
 */
/* 3a) Hanh vi Cap nhat quan he DANGKY tai cac truong lien quan den diem so
 *  nhung nguoi do khong thuoc vai tro Giang vien.
 */
BEGIN DBMS_FGA.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'DANGKY',
    POLICY_NAME  => 'AUDPOL_DANGKY_UPD_DIEM_NOT_V',
    AUDIT_CONDITION  => 'SUBSTR(SYS_CONTEXT(''USERENV'', ''SESSION_USER''), 1, 1) != ''V''',
    AUDIT_COLUMN  => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',
    STATEMENT_TYPES  => 'UPDATE'
); END;
/

-- In policies.sql, GIANGVIEN (V) was not granted UPDATE on DANGKY, but on
--  V_DANGKY_V instead. Hence, to facilitate the scenario, V will be
--  temporarily granted SELECT, UPDATE on DANGKY.
GRANT SELECT, UPDATE(DIEMTH) ON A01_QLNOIBO.DANGKY TO V20062;
SELECT * FROM A01_QLNOIBO.DANGKY WHERE MASV = 'S10081' AND MAGV = 'V20062';

-- V20062 WON'T TRIGGER THE AUDIT
CONN V20062/123@LOCALHOST:1521/XEPDB1;
UPDATE A01_QLNOIBO.DANGKY SET DIEMTH = DIEMTH
WHERE MASV = 'S10081' AND MAGV = 'V20062';
-- AD0001 WILL TRIGGER THE AUDIT
CONN AD0001/123@LOCALHOST:1521/XEPDB1;
UPDATE A01_QLNOIBO.DANGKY SET DIEMTH = DIEMTH
WHERE MASV = 'S10081' AND MAGV = 'V20062';

SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, SCN, ACTION_NAME, OBJECT_SCHEMA,
    OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, OBJECT_PRIVILEGES,
    TARGET_USER, CURRENT_USER, UNIFIED_AUDIT_POLICIES,
    FGA_POLICY_NAME FROM UNIFIED_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'FineGrainedAudit' AND OBJECT_NAME = 'DANGKY'
    AND DBUSERNAME NOT IN ('SYS', 'A01_QLNOIBO')
ORDER BY EVENT_TIMESTAMP;

REVOKE SELECT, UPDATE ON A01_QLNOIBO.DANGKY FROM V20062;

/* 3b) Hanh vi cua nguoi dung nay co the doc tren truong PHUCAP cua nguoi
 *  khac o quan he NHANSU.
 */
BEGIN DBMS_FGA.ADD_POLICY(
    OBJECT_SCHEMA  => 'A01_QLNOIBO',
    OBJECT_NAME  => 'NHANSU',
    POLICY_NAME  => 'AUDPOL_NHANSU_SEL_PHUCAP',
    AUDIT_CONDITION  => 'MANV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
    AUDIT_COLUMN  => 'PHUCAP',
    STATEMENT_TYPES  => 'SELECT'
); END;
/

CONN TK0001/123@LOCALHOST:1521/XEPDB1;
-- WON'T TRIGGER THE AUDIT
SELECT * FROM A01_QLNOIBO.NHANSU WHERE MANV = 'TK0001';
-- WON'T TRIGGER THE AUDIT
SELECT HOTEN FROM A01_QLNOIBO.NHANSU WHERE MANV = 'NV0001';
-- WILL TRIGGER THE AUDIT
SELECT * FROM A01_QLNOIBO.NHANSU WHERE MANV = 'NV0001';

CONN AD0001/123@LOCALHOST:1521/XEPDB1;
-- WILL TRIGGER THE AUDIT
SELECT HOTEN, PHUCAP FROM A01_QLNOIBO.NHANSU WHERE MANV = 'NV0001';

SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, SCN, ACTION_NAME, OBJECT_SCHEMA,
    OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, OBJECT_PRIVILEGES,
    TARGET_USER, CURRENT_USER, UNIFIED_AUDIT_POLICIES,
    FGA_POLICY_NAME FROM UNIFIED_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'FineGrainedAudit' AND OBJECT_NAME = 'NHANSU'
    AND DBUSERNAME NOT IN ('SYS', 'A01_QLNOIBO')
ORDER BY EVENT_TIMESTAMP;

/* 4. Kiem tra (doc xuat) du lieu nhat ky he thong.
 */
SELECT AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, SCN, ACTION_NAME, OBJECT_SCHEMA,
    OBJECT_NAME, SQL_TEXT, SYSTEM_PRIVILEGE_USED, OBJECT_PRIVILEGES,
    TARGET_USER, CURRENT_USER, UNIFIED_AUDIT_POLICIES,
    FGA_POLICY_NAME FROM UNIFIED_AUDIT_TRAIL
ORDER BY EVENT_TIMESTAMP;
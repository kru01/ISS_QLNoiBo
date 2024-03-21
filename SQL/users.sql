CL SCR;
ALTER SESSION SET CURRENT_SCHEMA = A01_QLNOIBO;

CREATE USER AD0001 IDENTIFIED BY 123;
GRANT DBA TO AD0001;
GRANT CREATE SESSION TO AD0001 WITH ADMIN OPTION;
GRANT SELECT ANY TABLE, INSERT ANY TABLE TO AD0001;
GRANT UPDATE ANY TABLE, DELETE ANY TABLE TO AD0001;

GRANT CREATE USER, ALTER USER, DROP USER TO AD0001;
GRANT CREATE ROLE, DROP ANY ROLE TO AD0001;
GRANT GRANT ANY ROLE TO AD0001 WITH ADMIN OPTION;
GRANT CREATE ANY VIEW, DROP ANY VIEW TO AD0001;

GRANT GRANT ANY PRIVILEGE TO AD0001 WITH ADMIN OPTION;
GRANT UNLIMITED TABLESPACE TO AD0001;

GRANT LBAC_DBA TO AD0001;
GRANT EXECUTE ON SA_SYSDBA TO AD0001;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO AD0001;
GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO AD0001 WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.SA_USER_ADMIN TO  AD0001 WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.SA_LABEL_ADMIN TO AD0001 WITH GRANT OPTION; 
GRANT EXECUTE ON SA_POLICY_ADMIN TO AD0001 WITH GRANT OPTION; 
GRANT EXECUTE ON CHAR_TO_LABEL TO AD0001 WITH GRANT OPTION;

CREATE OR REPLACE PROCEDURE USP_CREATE_USERS
AS
    CURSOR CUR_NHANSU IS (SELECT MANV FROM NHANSU
        WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    CURSOR CUR_SINHVIEN IS (SELECT MASV FROM SINHVIEN
        WHERE MASV NOT IN (SELECT USERNAME FROM ALL_USERS));
BEGIN
    FOR USR IN CUR_NHANSU LOOP
        EXECUTE IMMEDIATE 'CREATE USER ' || USR.MANV || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || USR.MANV;
    END LOOP;
    FOR USR IN CUR_SINHVIEN LOOP
        EXECUTE IMMEDIATE 'CREATE USER ' || USR.MASV || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || USR.MASV;
    END LOOP;
END;
/
EXEC USP_CREATE_USERS();
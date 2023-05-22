--SELECT owner, object_name FROM all_procedures WHERE object_type = 'PROCEDURE';

--ADD
CONNECT MYADMIN/123;
CREATE OR REPLACE PROCEDURE sp_addDepartment
(
    departmentID IN VARCHAR2,
    departmentName IN VARCHAR2,
    departmentHeadID IN VARCHAR2
)
AS
    strSQL VARCHAR(2000);
    
    BEGIN
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE (strSQL);

    INSERT INTO MYADMIN.PHONGBAN (MAPB, TENPB, TRPHG) VALUES ( departmentID , departmentName , TO_NUMBER(departmentHeadID) );
    COMMIT;
    
    END;
   
/
DISCONNECT MYADMIN;


--DELETE
CONNECT MYADMIN/123;
CREATE OR REPLACE PROCEDURE sp_deleteDepartment
(
    departmentID IN VARCHAR2
)
AS
    strSQL VARCHAR(2000);
    
    BEGIN
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE (strSQL);
    
    UPDATE MYADMIN.NHANVIEN
    SET PHG = 'NULL'
    WHERE PHG = departmentID; 
    
    DELETE FROM MYADMIN.PHONGBAN WHERE MAPB = departmentID;
    COMMIT;
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE (strSQL);
    
    END;
/
DISCONNECT MYADMIN;


--UPDATE
CONNECT MYADMIN/123;
CREATE OR REPLACE PROCEDURE sp_updateDepartment
(
    departmentID IN VARCHAR2,
    departmentName IN VARCHAR2,
    departmentHeadID IN VARCHAR2
)
AS
    strSQL VARCHAR2(2000);
    BEGIN
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE (strSQL);
    
    -- Update departmentName and departmentHeadID
    UPDATE MYADMIN.PHONGBAN
    SET TENPB = departmentName, TRPHG = departmentHeadID
    WHERE MAPB = departmentID;
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE (strSQL);
    
    END;
/
DISCONNECT MYADMIN;
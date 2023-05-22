--SELECT owner, object_name FROM all_procedures WHERE object_type = 'PROCEDURE';

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

    INSERT INTO SYS.PHONGBAN (MAPB, TENPB, TRPHG) VALUES ( departmentID , departmentName , TO_NUMBER(departmentHeadID) );
    COMMIT;
    
    END;
   
/
DISCONNECT MYADMIN;
--EXECUTE sp_addDepartment('PB07', 'PHONG BAN SO 7', '7');


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
        
    DELETE FROM SYS.PHONGBAN WHERE MAPB = departmentID;
    COMMIT;
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE (strSQL);
    
    END;
/
DISCONNECT MYADMIN;
--EXECUTE sp_deleteDepartment('PB01');
--DELETE FROM SYS.PHONGBAN WHERE MAPB = 'PB08';
--COMMIT;


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
    UPDATE SYS.PHONGBAN
    SET TENPB = departmentName, TRPHG = departmentHeadID
    WHERE MAPB = departmentID;
    
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE (strSQL);
    
    END;
/
DISCONNECT MYADMIN;
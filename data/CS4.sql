--Chinh sach 4: RBAC

--SELECT * FROM DBA_ROLES;
--EXECUTE sp_dropRole('TaiChinh');
--EXECUTE sp_dropRole('BanGiamDoc');

--tao role
CONNECT MYADMIN/123;

EXECUTE sp_createRole('TaiChinh');
EXECUTE sp_createRole('BanGiamDoc');

DISCONNECT MYADMIN;


--grant select on all table to BanGiamDoc
CONNECT MYADMIN/123;
CREATE OR REPLACE PROCEDURE sp_grant_select_on_all_table
(
    role_name VARCHAR2
)
AS   
BEGIN
    FOR r IN (
        SELECT owner, table_name 
        FROM all_tables 
        WHERE table_name in ('NHANVIEN', 'DEAN', 'PHANCONG', 'PHONGBAN') 
    )
    
    LOOP
        EXECUTE IMMEDIATE 
            'GRANT SELECT ON '||r.owner||'.'||r.table_name||' to ' || role_name;
    END LOOP;
    
END; 
/

EXECUTE MYADMIN.sp_grant_select_on_all_table('BanGiamDoc');

DISCONNECT MYADMIN;


--grant privilege to role TaiChinh
CONNECT MYADMIN/123;

GRANT NHANVIEN TO TAICHINH;
GRANT SELECT ON MYADMIN.NHANVIEN TO TAICHINH;
GRANT SELECT ON MYADMIN.PHANCONG TO TAICHINH;
GRANT UPDATE(LUONG, PHUCAP) ON MYADMIN.NHANVIEN TO TAICHINH;

DISCONNECT MYADMIN;


--grant role TaiChinh to user
CONNECT MYADMIN/123;

CREATE OR REPLACE PROCEDURE sp_grantTaiChinh
AS
  v_manv NHANVIEN.MANV%TYPE;
  v_username VARCHAR2(100);
BEGIN
  FOR rec IN (SELECT MANV FROM NHANVIEN WHERE VAITRO = 'Tai Chinh') LOOP
    v_manv := rec.MANV;
    v_username := 'nv' || v_manv;
    EXECUTE IMMEDIATE 'GRANT TAICHINH TO ' || v_username;
  END LOOP;
END;
/
BEGIN
  sp_grantTaiChinh;
END;
/

DISCONNECT MYADMIN;
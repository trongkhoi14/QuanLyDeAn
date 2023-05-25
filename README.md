# QuanLyDeAn
PHÂN HỆ 1: DÀNH CHO NGƯỜI QUẢN TRỊ CƠ SỞ DỮ LIỆU
- Xem danh sách người dùng trong hệ thống.
- Thông tin về quyền (privileges) của mỗi user/ role trên các đối tượng dữ liệu.
- Cho phép tạo mới, xóa, sửa (hiệu chỉnh) user hoặc role.
- Cho phép thực hiện việc cấp quyền: cấp quyền cho user, cấp quyền cho role, cấp role cho
user. Quá trình cấp quyền có tùy chọn là có cho phép người được cấp quyền có thể cấp
quyền đó cho user/ role khác hay không (có chỉ định WITH GRANT OPTION hay không).
Quyền, select, update thì cho phép phân quyền tinh đến mức cột; quyền insert, delete thì
không.
- Cho phép thu hồi quyền từ người dùng/ role.
- Cho phép kiểm tra quyền của các chủ thể vừa được cấp quyền.
- Cho phép chỉnh sửa quyền của user/ role.

PHÂN HỆ 2: QUẢN LÝ THÔNG TIN NHÂN VIÊN VÀ VIỆC THAM GIA ĐỀ ÁN

Đáp ứng các chính sách bảo mật bằng:
- Access control (DAC, RBAC, MAC, VPD)
- Mã hóa
- Auditing

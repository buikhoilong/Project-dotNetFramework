-- Cài đặt --
Bước 1: Giải nén tệp "432_434_cdth19e.zip";
Bước 2: Mở SQL Server Management Studio và chạy file Script "qly_ban_hang_linh_kien.sql" để có cơ sở dữ liệu;
Bước 3: Khởi động file "432_434_cdth19e.sln" để mở source-code;
Bước 4: Vào file "dbConnection.cs" ở tab Solution Explorer và đổi Server Name* tại biến ServerName để kết 
	nối với SQL Server cục bộ, kết nối cơ sở dữ liệu;
Bước 5: Nhấn F5 hoặc click nút Start trên Toolbar để khởi động chương trình!

--Cách lấy SQL Server Management Studio --

Bước 1: Mở SQL Server Management Studio;
Bước 2: Xổ cây thư mục Databases trong tab Object Explorer, click chuột phải vào "qly_ban_hang_linh_kien" 
	(tên database) chọn Properties;
Bước 3: Tại cửa sổ Database Properties - qly_ban_hang_linh_kien, click vào "View connection" ở tab Connection;
Bước 4: Tại cửa sổ Connection Properties, ta lấy được Server Name nằm trong cụm thuộc tính Product;

-- Chạy chương trình -- 
Bước 1: Đăng nhập với tài khoản test Mặc định là:
						 Tên đăng nhập: a
						      Mật khẩu: a
Bước 2: Chọn các chức năng ở menu để sử dụng
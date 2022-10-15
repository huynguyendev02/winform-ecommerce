CREATE DATABASE DatabaseDoAnCNTT
GO

USE DatabaseDoAnCNTT
GO

CREATE TABLE product_category (
	id				int	IDENTITY(1,1) primary key,
	name_category	text,
	desc_category	text,
	created_at		date,
	modified_at		date,
	deleted_at		date
)
GO

CREATE TABLE product_inventory (
	id				int	IDENTITY(1,1) primary key,
	quantity		int,
	created_at		date,
	modified_at		date,
	deleted_at		date
)
GO

CREATE TABLE discount (
	id					int	IDENTITY(1,1) primary key,
	name_discount		text,
	desc_discount		text,
	discount_percent	decimal,
	active				BIT,
	created_at			date,
	modified_at			date,
	deleted_at			date
)
GO

CREATE TABLE product (
	id					int	IDENTITY(1,1) primary key,
	name_product		text,
	desc_product		text,
	category_id			int				foreign key references product_category(id),
	inventory_id		int				foreign key references product_inventory(id),
	price				decimal,
	discount_id			int				foreign key references discount(id),
	image_url				text,
	created_at			date,
	modified_at			date,
	deleted_at			date
)
GO



CREATE TABLE users (
	id					int	 IDENTITY(1,1) primary key,
	username			nvarchar(50),
	passwords			text,
	first_name			text,
	last_name			text,
	telephone			int,
	created_at			date,
	modified_at			date
)
GO

CREATE TABLE shopping_session (
	id					int	IDENTITY(1,1) primary key,
	users_id			int			foreign key references users(id),
	total				decimal,
	created_at			date,
	modified_at			date
)
GO

CREATE TABLE cart_item (
	id					int	IDENTITY(1,1) primary key,
	session_id			int			foreign key references shopping_session(id),
	product_id			int			foreign key references product(id),
	quanlity			int,
	created_at			date,
	modified_at			date
)
GO

CREATE TABLE user_address (
	id					int	IDENTITY(1,1) primary key,
	users_id			int			foreign key references users(id),
	address_line1		text,
	address_line2		text,
	city				text,
	postal_code			text,
	country				text,
	telephone			text,
	mobile				text
)
GO

CREATE TABLE user_payment (
	id					int	IDENTITY(1,1) primary key,
	users_id			int			foreign key references users(id),
	payment_type		text,
	providers			text,
	account_no			int,
	expiry				date
)
GO

CREATE TABLE payment_details (
	id					int	IDENTITY(1,1) primary key,
	order_id			int,
	amount				int,
	providers			text,
	statuss				text,
	created_at			date,
	modified_at			date
)
GO

CREATE TABLE order_details (
	id					int	IDENTITY(1,1) primary key,
	users_id			int			foreign key references users(id),
	total				decimal,
	payment_id			int			foreign key references payment_details(id),
	created_at			date,
	modified_at			date
)
GO

CREATE TABLE order_items (
	id					int	IDENTITY(1,1) primary key,
	order_id			int			foreign key references order_details(id),
	product_id			int			foreign key references product(id),
	quanlity			int,
	created_at			date,
	modified_at			date
)
GO

insert into product_category (name_category, desc_category)
values 
	('Laptop','Máy tính di động'),
	('Điện thoại', 'Điện thoại di động'),
	('Máy tính bảng', 'Thiết bị di động cỡ lớn'),
	('Máy lạnh', 'Thiết bị điều hoà'),
	('Bộ sạc', 'Nạp lại năng lượng')

insert into product_inventory (quantity)
values
	(123),(100),(54),(454),(2333),(999)

insert into discount (name_discount,desc_discount,discount_percent,active)
values 
	('Đại hạ giá valentine','Hạ giá toàn bộ khi các cặp đôi đến mua vào ngày 14/2',0.12, 0),
	('Giáng sinh rực rỡ', 'Đại hạ giá noel dành cho các thiết bị laptop trong ngày 24-26/12',0.20,0)

insert into product (name_product,desc_product,category_id,inventory_id,price,discount_id,image_url)
values 
	('Apple Iphone 14 Pro Max','Dòng Iphone mới nhất với dynamic island đến từ nhà Apple', 2, 1, 1299, null,null),
	('Apple Macbook Pro 16inch', 'Laptop dành cho những người làm đồ hoạ, IT', 1,2,2999,null,null),
	('Samsung Galaxy Tab S8 Ultra', 'Dòng tablet mới nhất, xịn nhất từ nhà Samsung', 3,3,1999,null,null),
	('Máy lạnh Panasonic Inverter 1 HP CU/CS-XU9XKH-8', 'Máy lạnh Panasonic Inverter 1 HP CU/CS-XU9XKH-8 thiết kế màu trắng với phần vỏ làm bằng nhựa phủ một lớp nhám. Trên máy không có màn hình hiển thị nhiệt độ.',4,4,999,null,null),
	('Củ sạc Xiaomi Mi Charger 20W Type-C', 'Bộ sạc nhanh Xiaomi Mi 20W Charger mà bạn đang theo dõi là giải pháp tối ưu để sạc nhanh cho các dòng smartphone thế hệ mới, sản phẩm có đầu ra 20W, cổng USB Type-C và đảm bảo an toàn cho người dùng nhờ cơ chế điều tiết dòng điện thông minh.', 5,5,12,null,null)

insert into users(username,passwords,first_name,last_name,telephone)
values
	('admin','admin','admin','admin','000000000'),
	('testuser','123456','Nguyen','Huy','0999111999')
insert into user_address (
	users_id,
	address_line1,
	address_line2,
	city,
	postal_code,
	country	,
	telephone,
	mobile)
values
	(2,'Đại học Sư Phạm Kĩ Thuật','Đại học Ngân Hàng','TP Hồ Chí Minh', '90000','Việt Nam','027934853','097547483')
insert into user_payment (
	users_id,
	payment_type,
	providers,
	account_no,
	expiry)
values 
	(2,'Credit Card','VISA',1,'2026-11-11')
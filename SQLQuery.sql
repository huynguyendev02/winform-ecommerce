    CREATE DATABASE DatabaseEC
GO

USE DatabaseEC
GO

CREATE TABLE product_category (
	id				int	IDENTITY(1,1) primary key,
	name_category	NVARCHAR(MAX),
	desc_category	NVARCHAR(MAX),
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
	name_discount		NVARCHAR(MAX),
	desc_discount		NVARCHAR(MAX),
	discount_percent	decimal,
	active				BIT,
	created_at			date,
	modified_at			date,
	deleted_at			date
)
GO

CREATE TABLE product (
	id					int	IDENTITY(1,1) primary key,
	name_product		NVARCHAR(MAX),
	desc_product		NVARCHAR(MAX),
	category_id			int				foreign key references product_category(id),
	inventory_id		int				foreign key references product_inventory(id),
	price				decimal,
	discount_id			int				foreign key references discount(id),
	image_url				NVARCHAR(MAX),
	created_at			date,
	modified_at			date,
	deleted_at			date
)
GO



CREATE TABLE users (
	id					int	 IDENTITY(1,1) primary key,
	username			nvarchar(MAX),
	passwords			NVARCHAR(MAX),
	first_name			NVARCHAR(MAX),
	last_name			NVARCHAR(MAX),
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
	address_line1		NVARCHAR(MAX),
	address_line2		NVARCHAR(MAX),
	city				NVARCHAR(MAX),
	postal_code			NVARCHAR(MAX),
	country				NVARCHAR(MAX),
	telephone			NVARCHAR(MAX),
	mobile				NVARCHAR(MAX)
)
GO

CREATE TABLE user_payment (
	id					int	IDENTITY(1,1) primary key,
	users_id			int			foreign key references users(id),
	payment_type		NVARCHAR(MAX),
	providers			NVARCHAR(MAX),
	account_no			int,
	expiry				date
)
GO

CREATE TABLE payment_details (
	id					int	IDENTITY(1,1) primary key,
	order_id			int,
	amount				int,
	providers			NVARCHAR(MAX),
	statuss				NVARCHAR(MAX),
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
	('Mac','Which Mac is right for you?'),
	('iPad', 'Introducing the all‑new iPad and iPad Pro.'),
	('iPhone', 'Which iPhone is right for you?'),
	('Watch', 'Any case. Any band. Any style you want.'),
	('Airpods', 'A magical connection to your devices.'),
    ('TV & Home', 'The future hits home.'),
    ('Accessories','Find the accessories you’re looking for.')

insert into product_inventory (quantity)
values
	(1234),(1212),(3232),(2121),(1717),(1414)

insert into product (name_product,desc_product,category_id,inventory_id,price,discount_id,image_url)
values
	('MacBook Air','Don’t take it lightly.', 1, 1, 9499, null,'https://iili.io/H9zWSFS.png'),
	('MacBook Pro 13”', 'Pro anywhere.', 1,1,9999,null,'https://iili.io/H9zWZPV.png'),
	('MacBook Pro 14” and 16”', 'Incredible power. Incredibly simple.', 1,1,15999,null,'https://iili.io/H9zXoRn.png'),
	('iPad', 'Lovable. Drawable. Magical.',2,2,3499,null,'https://iili.io/H9zXDXf.png'),
	('iPad Pro', 'Supercharged by M2', 2,2,6499,null,'https://iili.io/H9zh3mu.png'),
    ('iPad mini', 'The full iPad experience designed to fit in one hand.',2,2,3999,null,'https://iili.io/H9zjBun.png'),
    ('iPhone 14','Big and bigger.',3,3,9499,null,'https://iili.io/H9zjxnf.png'),
    ('iPhone 14 Pro', 'Pro. Beyond.',3,3,12999,null,'https://iili.io/H9zjzG4.png'),
    ('iPhone SE','Love the power. Love the price.',3,3,5999,null,'https://iili.io/H9zjAaS.png'),
    ('Apple Watch Ultra', 'Adventure awaits.', 4,4,6399,null,'https://iili.io/H9zjYue.png'),
    ('Apple Watch Series','A healthy leap ahead.',4,4,3199,null,'https://iili.io/H9zjE6Q.png'),
    ('Apple Watch SE', 'A great deal to love.',4,4,1999,null,'https://iili.io/H9zjgSI.png'),
    ('AirPods Pro', '2nd generation', 5,5,1849,null,'https://iili.io/H9zjDKl.png'),
    ('AirPods Max','Personalized Spatial Audio with dynamic head tracking',5,5,4599,null,'https://freeimage.host/i/H9zwUsj'),
    ('Apple Pencil (2nd generation)','Designed for iPad Pro and iPad Air',6,6,999,null,'https://iili.io/H9zwtzg.png'),
    ('MagSafe Charger','Mix. Match. MagSafe.',6,6,299,null,'https://iili.io/H9zwpqv.png')


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



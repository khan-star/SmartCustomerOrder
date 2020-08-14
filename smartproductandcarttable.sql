Create table Products (Productid int primary key identity(1,1), Title varchar(50), 
Price int, Quantity int, Images varbinary(max))

insert into Products (Title,Price,Quantity,Images) select 'Spoon',100,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 001.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Sun Glass',200,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 002.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Watch',150,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 003.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Head Phone',200,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 004.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Cocooil',70,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 005.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Shoes',100,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 006.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Perfume',199,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 007.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Pressed Cream',99,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 008.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Pot Tree',50,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 009.jpg', Single_Blob) image;
insert into Products (Title,Price,Quantity,Images) select 'Coke',20,1, * from OpenRowSet(Bulk 'D:\PROJECTS\SMARTCUSTOMERORDER\Image\image 010.jpg', Single_Blob) image;

select * from Products

Create table Carts (Id int primary key identity(1,1), Productid int)

drop table Carts

sp_help 'Carts'
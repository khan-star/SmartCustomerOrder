create database Smart

Use smart

create table UserDetail(SNo int Primary Key identity(1,1), Name varchar(50), Surname varchar(50), 
Gender varchar(20), Email varchar(100))

Insert into UserDetail (Name,Surname,Gender,Email) values ('Ibuyas', 'Khan', 'Male', 'Ibuyas.Khan77@gmail.com')
Insert into UserDetail (Name,Surname,Gender,Email) values ('salman', 'Asik', 'Male', 'asiksalman93@gmail.com')

select * from UserDetail
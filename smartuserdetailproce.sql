-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALter PROCEDURE UserDetails (@User xml)
AS
BEGIN
SET NOCOUNT ON;
select t.c. query('SNo').value('.','int') as 'SN',
   	   t.c. query('Name').value('.','varchar(50)') as 'FName',
	   t.c. query('Surname').value('.','varchar(50)') as 'SName',
	   t.c. query('Gender').value('.','varchar(20)') as 'Gen',
	   t.c. query('Email').value('.','varchar(100)') as 'Em'
	   into #tmp from @User.nodes('/Userxml') as t(c)

	   Declare @SNo int
	   select @SNo=SN from #tmp

	   if(@SNo=0)
	   begin
	   insert into UserDetail(Name,Surname,Gender,Email)
	   select FName, SName, Gen, Em from #tmp
	   end
	   else
	   begin
	   update t2 set Name=FName, Surname=SName, Gender=Gen, Email=Em from #tmp t1 join Userdetail t2 on t1.SN=t2.SNO	   
	   end

END
GO

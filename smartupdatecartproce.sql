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
CREATE PROCEDURE [dbo].[UpdateCart](@Cid xml)
AS
BEGIN
SET NOCOUNT ON;
	   Select 
	   t.c.query('Id').value('.','int') as 'Id',
	   t.c.query('Productid').value('.','int') as 'Pid'
       into #tmp from @Cid.nodes('/Productxml') as t(c)

	   declare @Id int, @Pid int
	   select @Id = Id, @Pid = Pid from #tmp

	   if(@Id=0)
	   begin
	   insert into Carts(Productid)
	   select Pid from #tmp
	   end
	   else
	   begin
	   update t2 set Productid = @Pid
	   from #tmp t1 join Carts t2 on t1.Id=t2.Id
	   Where t2.Id = @Id
	   end

END
GO

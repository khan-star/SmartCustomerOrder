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
Alter PROCEDURE [dbo].[GetProductsLists](@Productid int=0)
AS
BEGIN
SET NOCOUNT ON;
if(@Productid!=0)
begin
select Productid,Title,Price,Quantity,Images from Products where Productid=@Productid
end
else
begin
select Productid,Title,Price,Quantity,Images from Products
end
END

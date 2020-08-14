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
Alter PROCEDURE [dbo].[GetCartList](@Productid int = 0)
AS
BEGIN
SET NOCOUNT ON;
if(@Productid = 0)
begin
	--select Productid,Title,Price,Quantity,Images from Carts where Productid = @Productid
	Select P.Productid, P.Images, Sum(P.Price) "Price", P.Title, Sum(P.Quantity) "TotalQuantity" 
	from Products P join Carts C
	on P.Productid = C.Productid
	group by P.Productid, P.Images,P.Title
end
END

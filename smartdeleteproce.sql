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
Alter PROCEDURE DeleteUser (@SNo int = 0)
AS
BEGIN
SET NOCOUNT ON;
if(@SNo = 0)
begin
delete from UserDetail where @SNo=SNo
end
else
begin
delete from UserDetail where @SNo=SNo
end
END
GO

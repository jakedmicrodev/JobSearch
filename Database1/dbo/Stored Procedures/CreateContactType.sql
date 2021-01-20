
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Create an contact type
-- =============================================
CREATE PROCEDURE [dbo].[CreateContactType] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[ContactTypes]
	([Name])
	VALUES
	(@Name)
END
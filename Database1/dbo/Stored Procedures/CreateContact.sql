-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Create a contact
-- =============================================
CREATE PROCEDURE [dbo].[CreateContact] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@CompanyId int,
	@ContactTypeId int = null,
	@Phone nvarchar(50) = null,
	@Email nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Contacts]
	([Name]
	,[CompanyId]
	,[ContactTypeId]
	,[Phone]
	,[Email]
	)
	VALUES
	(@Name
	,@CompanyId
	,@ContactTypeId
	,@Phone
	,@Email
	)
END
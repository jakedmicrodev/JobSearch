
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Update a contact
-- =============================================
CREATE PROCEDURE [dbo].[UpdateContact] 
	-- Add the parameters for the stored procedure here
	@Id int,
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
	UPDATE [dbo].[Contacts]
	SET [Name] = @Name
	,[CompanyId] = @CompanyId
	,[ContactTypeId] = @ContactTypeId
	,[Phone] = @Phone
	,[Email] = @Email
	WHERE
	[Id] = @Id
END
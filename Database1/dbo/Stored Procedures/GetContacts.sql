-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select one or more contacts
-- =============================================
CREATE PROCEDURE [dbo].[GetContacts] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@Name nvarchar(50) = null,
	@CompanyId int = null,
	@ContactTypeId int = null,
	@Phone nvarchar(50) = null,
	@Email nvarchar(50) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [Id]
      ,[Name]
      ,[CompanyId]
      ,[ContactTypeId]
      ,[Phone]
      ,[Email]
  FROM [dbo].[Contacts]
  WHERE @Id IS NULL OR [Id] = @Id
  AND @Name IS NULL OR [Name] LIKE @Name
  AND @CompanyId IS NULL OR [CompanyId] = @CompanyId
  AND @ContactTypeId IS NULL OR [ContactTypeId] = @ContactTypeId
  AND @Phone IS NULL OR [Phone] LIKE '%' + @Phone + '%'
  AND @Email IS NULL OR [Email] LIKE '%' + @Email + '%'

END
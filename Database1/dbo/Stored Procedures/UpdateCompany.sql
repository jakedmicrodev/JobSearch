
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Update a company
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCompany] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(50),
	@Website nvarchar(50) = null,
	@IsRecruiter bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Companies]
	SET [Name] = @Name
	,[Website] = @Website
	,[IsRecruiter] = @IsRecruiter
	WHERE
	[Id] = @Id
END
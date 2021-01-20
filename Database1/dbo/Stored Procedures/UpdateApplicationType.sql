
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-13 10:04:38.880
-- Description:	Update an application type
-- =============================================
CREATE PROCEDURE [dbo].[UpdateApplicationType] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[ApplicationTypes]
	SET [Name] = @Name
	WHERE
	[Id] = @Id
END
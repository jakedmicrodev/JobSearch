
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Update a requester
-- =============================================
CREATE PROCEDURE [dbo].[UpdateRequester] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Requesters]
	SET [Name] = @Name
	WHERE
	[Id] = @Id
END
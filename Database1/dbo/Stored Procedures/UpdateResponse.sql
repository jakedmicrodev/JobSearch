-- =============================================
-- Author:		Jake
-- Create date: 2020-12-13 09:58:51.553
-- Description:	Update a response
-- =============================================
CREATE PROCEDURE [dbo].[UpdateResponse] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@ContactTypeId int,
	@ResponseDate smalldatetime,
	@ResultId int,
	@ContactId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Responses]
	SET [ContactTypeId] = @ContactTypeId
	,[ResponseDate] = @ResponseDate
	,[ResultId] = @ResultId
	,[ContactId] = @ContactId
	WHERE [Id] = @Id
END
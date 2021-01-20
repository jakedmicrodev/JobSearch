-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Create a response
-- =============================================
CREATE PROCEDURE [dbo].[CreateResponse] 
	-- Add the parameters for the stored procedure here
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
	INSERT INTO [dbo].[Responses]
	([ContactTypeId]
	,[ResponseDate]
	,[ResultId]
	,[ContactId]
	)
	VALUES
	(@ContactTypeId
	,@ResponseDate
	,@ResultId
	,@ContactId
	)
END
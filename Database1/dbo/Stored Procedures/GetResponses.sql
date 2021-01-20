
-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select responses
-- =============================================
CREATE PROCEDURE [dbo].[GetResponses] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@ContactTypeId int = null,
	@StartDate smalldatetime = null,
	@EndDate smalldatetime = null,
	@ResultId int = null,
	@ContactId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [Id]
		  ,[ContactTypeId]
		  ,[ResponseDate]
		  ,[ResultId]
		  ,[ContactId]
	  FROM [dbo].[Responses]
	  WHERE [Id] IS NULL OR [Id] = @Id
	  AND @ContactTypeId IS NULL OR [ContactTypeId] = @ContactTypeId
	  AND (@StartDate IS NULL AND @EndDate IS NULL) OR [ResponseDate] BETWEEN @StartDate AND @EndDate
	  AND @ResultId IS NULL OR [ResultId] = @ResultId 
	  AND @ContactId IS NULL OR [ContactId] = @ContactId
	  ORDER BY [ResponseDate]
END
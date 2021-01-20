-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select one or more interviews
-- =============================================
CREATE PROCEDURE [dbo].[GetInterviews] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@CompanyId int = null,
	@StartDate smalldatetime = null,
	@EndDate smalldatetime = null,
	@InterviewTypeId int = null,
	@Notes nvarchar(max) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Id]
		  ,[CompanyId]
		  ,[InterviewDate]
		  ,[InterviewTypeId]
		  ,[Notes]
	  FROM [dbo].[Interviews]
	  WHERE @Id IS NULL OR [Id] = @Id
	  AND @CompanyId IS NULL OR [CompanyId] = @CompanyId
	  AND (@StartDate IS NULL AND @EndDate IS NULL) OR [InterviewDate] BETWEEN @StartDate AND @EndDate
	  AND @InterviewTypeId IS NULL OR [InterviewTypeId] = @InterviewTypeId
	  AND @Notes IS NULL OR [Notes] LIKE '%' + @Notes + '%'

END
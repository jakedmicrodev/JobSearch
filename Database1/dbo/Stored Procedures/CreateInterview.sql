-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Create an interview
-- =============================================
CREATE PROCEDURE [dbo].[CreateInterview] 
	-- Add the parameters for the stored procedure here
	@CompanyId int,
	@InterviewDate smalldatetime,
	@InterviewTypeId int,
	@Notes nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Interviews]
	([CompanyId]
	,[InterviewDate]
	,[InterviewTypeId]
	,[Notes]
	)
	VALUES
	(@CompanyId
	,@InterviewDate
	,@InterviewTypeId
	,@Notes
	)
END

-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Update an interview
-- =============================================
CREATE PROCEDURE [dbo].[UpdateInterview] 
	-- Add the parameters for the stored procedure here
	@Id int,
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
	UPDATE [dbo].[Interviews]
	SET [CompanyId] = @CompanyId
	,[InterviewDate] = @InterviewDate
	,[InterviewTypeId] = @InterviewTypeId
	,[Notes] = @Notes
	WHERE
	[Id] = @Id
END
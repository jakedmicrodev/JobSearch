-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select application types
-- =============================================
CREATE PROCEDURE [dbo].[GetApplicationTypes] 
	-- Add the parameters for the stored procedure here
	@Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [Id]
		  ,[Name]
	  FROM [dbo].[ApplicationTypes]
	  WHERE [Id] IS NULL OR [Id] = @Id
END
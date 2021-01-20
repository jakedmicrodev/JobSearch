-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Get one or more companies
-- =============================================
CREATE PROCEDURE [dbo].[GetCompanies] 
	-- Add the parameters for the stored procedure here
	@Id int = null, 
	@Name nvarchar(50) = null,
	@Website nvarchar(50) = null,
	@IsRecruiter bit = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [Id]
      ,[Name]
      ,[Website]
      ,[IsRecruiter]
  FROM [dbo].[Companies]
  WHERE @Id IS NULL OR [Id] = @Id
  AND @Name IS NULL OR [Name] = @Name
  AND @Website IS NULL OR [Website] = @Website
  AND @IsRecruiter IS NULL OR [IsRecruiter] = @IsRecruiter

END
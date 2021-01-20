-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Get an application
-- =============================================
CREATE PROCEDURE [dbo].[GetApplications] 
	-- Add the parameters for the stored procedure here
	@Id int = null,
	@CompanyId int = null,
	@PositionId int = null,
	@PayRate nvarchar(50) = null,
	@Requirements nvarchar(50) = null,
	@LocationId int = null,
	@RequesterId int = null,
	@ApplicationTypeId int = null,
	@ContactId int = null,
	@ResponseId int = null,
	@ResultId int = null,
	@StartDate smalldatetime = null,
	@EndDate smalldatetime = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.[Id]
		  ,a.[CompanyId]
		  ,co.[Name]
		  ,a.[PositionId]
		  ,po.[Name] AS [Position]
		  ,a.[PayRate]
		  ,a.[Requirements]
		  ,a.[LocationId]
		  ,lo.[Name] AS [Location]
		  ,a.[RequesterId]
		  ,re.[Name] AS [Requester]
		  ,a.[ApplicationTypeId]
		  ,at.[Name] AS [ApplicationType]
		  ,a.[ContactId]
		  ,ct.[Name] AS [Contact]
		  ,a.[ResponseId]
		  ,res.[ResponseDate]
		  ,a.[ResultId]
		  ,r.[Name] AS [Result]
		  ,a.[SubmitDate]
	  FROM [dbo].[Applications] a
	  LEFT JOIN [dbo].[Companies] co ON a.[CompanyId] = co.[Id]
	  LEFT JOIN [dbo].[Positions] po ON a.[PositionId] = po.[Id]
	  LEFT JOIN [dbo].[Locations] lo ON a.[LocationId] = lo.[Id]
	  LEFT JOIN [dbo].[Requesters] re ON a.[RequesterId] = re.[Id]
	  LEFT JOIN [dbo].[ApplicationTypes] at ON a.[ApplicationTypeId] = at.[Id]
	  LEFT JOIN [dbo].[Contacts] ct ON a.[ContactId] = ct.[Id]
	  LEFT JOIN [dbo].[Responses] res ON a.[ResponseId] = res.[Id]
	  LEFT JOIN [dbo].[Results] r ON a.[ResultId] = r.[Id]
	  WHERE a.[Id] IS NULL OR a.[Id] = @Id
	  AND @Id IS NULL OR a.[Id] = @Id
	  AND @CompanyId IS NULL OR a.[CompanyId] = @CompanyId
	  AND @PositionId IS NULL OR a.[PositionId] = @PositionId
	  AND @PayRate IS NULL OR a.[PayRate] LIKE @PayRate
	  AND @Requirements IS NULL OR a.[Requirements] LIKE @Requirements
	  AND @LocationId IS NULL OR a.[LocationId] = @LocationId
	  AND @RequesterId IS NULL OR a.[RequesterId] = @RequesterId
	  AND @ApplicationTypeId IS NULL OR a.[ApplicationTypeId] = @ApplicationTypeId
	  AND @ContactId IS NULL OR a.[ContactId] = @ContactId
	  AND @ResponseId IS NULL OR a.[ResponseId] = @ResponseId
	  AND @ResultId IS NULL OR a.[ResultId] = @ResultId
	  AND (@StartDate IS NULL AND @EndDate IS NULL) OR a.[SubmitDate] BETWEEN @StartDate AND @EndDate
END
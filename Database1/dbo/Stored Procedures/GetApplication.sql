-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select an application
-- =============================================
CREATE PROCEDURE [dbo].[GetApplication] 
	-- Add the parameters for the stored procedure here
	@Id int
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
	  WHERE a.[Id] = @Id
END
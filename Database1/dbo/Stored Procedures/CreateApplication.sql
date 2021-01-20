-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:49:23.403
-- Description:	Create application
-- =============================================
CREATE PROCEDURE [dbo].[CreateApplication] 
	-- Add the parameters for the stored procedure here
	@CompanyId int = null, 
	@PositionId int = null, 
	@PayRate nvarchar(50) = null, 
	@Requirements nvarchar(max) = null, 
	@LocationId int = null, 
	@RequesterId int = null, 
	@ApplicationTypeId int = null, 
	@ContactId int = null, 
	@ResponseId int = null, 
	@ResultId int = null,
	@SubmitDate smalldatetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Applications]
	([CompanyId]
	,[PositionId]
	,[PayRate]
	,[Requirements]
	,[LocationId]
	,[RequesterId]
	,[ApplicationTypeId]
	,[ContactId]
	,[ResponseId]
	,[ResultId]
	,[SubmitDate]
	)
	VALUES
	(@CompanyId
	,@PositionId
	,@PayRate
	,@Requirements
	,@LocationId
	,@RequesterId
	,@ApplicationTypeId
	,@ContactId
	,@ResponseId
	,@ResultId
	,@SubmitDate
	)
END
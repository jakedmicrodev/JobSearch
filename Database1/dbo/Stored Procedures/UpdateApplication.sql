-- =============================================
-- Author:		Jake
-- Create date: 2020-12-13 10:02:38.080
-- Description:	Update an application
-- =============================================
CREATE PROCEDURE [dbo].[UpdateApplication] 
	-- Add the parameters for the stored procedure here
	@Id int,
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
	UPDATE [dbo].[Applications]
	SET [CompanyId] = @CompanyId
	,[PositionId] = @PositionId
	,[PayRate] = @PayRate
	,[Requirements] = @Requirements
	,[LocationId] = @LocationId
	,[RequesterId] = @RequesterId
	,[ApplicationTypeId] = @ApplicationTypeId
	,[ContactId] = @ContactId
	,[ResponseId] = @ResponseId
	,[ResultId] = @ResultId
	,[SubmitDate] = @SubmitDate
	WHERE [Id] = @Id
END
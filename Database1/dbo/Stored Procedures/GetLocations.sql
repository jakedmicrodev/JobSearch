﻿
-- =============================================
-- Author:		Jake
-- Create date: now
-- Description:	Select locations
-- =============================================
CREATE PROCEDURE [dbo].[GetLocations] 
	-- Add the parameters for the stored procedure here
	@Id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [Id]
		  ,[Name]
	  FROM [dbo].[Locations]
	  WHERE [Id] IS NULL OR [Id] = @Id
END
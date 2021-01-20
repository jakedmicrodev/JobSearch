﻿-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Create a company
-- =============================================
CREATE PROCEDURE [dbo].[CreateCompany] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Website nvarchar(50) = null,
	@IsRecruiter bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Companies]
	([Name]
	,[Website]
	,[IsRecruiter]
	)
	VALUES
	(@Name
	,@Website
	,@IsRecruiter
	)
END
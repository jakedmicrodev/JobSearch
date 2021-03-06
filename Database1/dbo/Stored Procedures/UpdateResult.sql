﻿
-- =============================================
-- Author:		Jake
-- Create date: 2020-12-12 22:53:25.713
-- Description:	Update a result
-- =============================================
CREATE PROCEDURE [dbo].[UpdateResult] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Results]
	SET [Name] = @Name
	WHERE
	[Id] = @Id
END
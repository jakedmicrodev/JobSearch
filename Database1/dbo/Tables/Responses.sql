CREATE TABLE [dbo].[Responses] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [ContactTypeId] INT           NOT NULL,
    [ResponseDate]  SMALLDATETIME NOT NULL,
    [ResultId]      INT           NOT NULL,
    [ContactId]     INT           NOT NULL
);


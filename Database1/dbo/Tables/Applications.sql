CREATE TABLE [dbo].[Applications] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [CompanyId]         INT            NULL,
    [PositionId]        INT            NULL,
    [PayRate]           NVARCHAR (50)  NULL,
    [Requirements]      NVARCHAR (MAX) NULL,
    [LocationId]        INT            NULL,
    [RequesterId]       INT            NULL,
    [ApplicationTypeId] INT            NULL,
    [ContactId]         INT            NULL,
    [ResponseId]        INT            NULL,
    [ResultId]          INT            NULL,
    [SubmitDate]        SMALLDATETIME  NULL
);


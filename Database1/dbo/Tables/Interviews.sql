CREATE TABLE [dbo].[Interviews] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [CompanyId]       INT            NOT NULL,
    [InterviewDate]   SMALLDATETIME  NOT NULL,
    [InterviewTypeId] INT            NOT NULL,
    [Notes]           NVARCHAR (MAX) NULL
);


CREATE TABLE [dbo].[Contacts] (
    [Id]            INT           NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [CompanyId]     INT           NOT NULL,
    [ContactTypeId] INT           NULL,
    [Phone]         NVARCHAR (50) NULL,
    [Email]         NVARCHAR (50) NULL
);


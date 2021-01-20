CREATE TABLE [dbo].[Companies] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Website]     NVARCHAR (50) NULL,
    [IsRecruiter] BIT           CONSTRAINT [DF_Companies_IsRecruiter] DEFAULT ((0)) NOT NULL
);


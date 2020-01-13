CREATE TABLE [dbo].[UserData] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    [Age]         INT           NOT NULL,
	[Sex_ID]         INT
    PRIMARY KEY CLUSTERED ([Id] ASC) NOT NULL
);


CREATE TABLE [dbo].[student] (
    [StdId]        INT           IDENTITY (1, 1) NOT NULL,
    [StdFirstName] VARCHAR (50)  NULL,
    [StdLastName]  VARCHAR (50)  NULL,
    [Birthdate]    DATE          NULL,
    [Phone]        VARCHAR (50)  NULL,
    [Gender]       VARCHAR (50)  NULL,
    [Address]      VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([StdId] ASC)
);
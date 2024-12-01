CREATE TABLE [dbo].[score] (
    [StudentId] INT NOT NULL,
    [CourseName] VARCHAR(50) NULL,
    [Score] FLOAT NULL,
    [Description] TEXT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);
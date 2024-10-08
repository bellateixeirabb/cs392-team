CREATE TABLE [dbo].[EnhancedBMI] (
    [Id]            INT           NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Gender]        NVARCHAR (20) NOT NULL,
    [Weight]        INT           NOT NULL,
    [Height]        INT           NOT NULL,
    [BMI]           FLOAT (53)    NOT NULL,
    [DateTimeStamp] DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


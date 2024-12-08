CREATE TABLE [dbo].[Books] (
    [Book_id]         INT            IDENTITY (1, 1) NOT NULL,
    [Author]          NVARCHAR (150) NULL,
    [Title]           NVARCHAR (150) NULL,
    [Genre]           NVARCHAR (150) NULL,
    [CopiesAvailable] INT            NULL,
    [IsDeleted]       INT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Book_id] ASC)
);


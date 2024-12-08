CREATE TABLE [dbo].[BorrowRecords] (
    [RecordId]   INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     INT            NULL,
    [IssueDate]  DATETIME       NULL,
    [ReturnDate] DATETIME       NULL,
    [Status]     NVARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([RecordId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);


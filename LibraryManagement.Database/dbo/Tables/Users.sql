CREATE TABLE [dbo].[Users] (
    [UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (150) NULL,
    [Email]    NVARCHAR (150) NULL,
    [password] NVARCHAR (150) NULL,
    [Role]     NVARCHAR (1)   NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


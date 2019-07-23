CREATE TABLE [dbo].[CardIssue] (
    [编号]   INT           IDENTITY (1, 1) NOT NULL,
    [名称]   NVARCHAR (50) NOT NULL,
    [发卡范围] NVARCHAR (50) NULL,
    [卡号]   NVARCHAR (50) NULL,
    [密码]   NVARCHAR (50) CONSTRAINT [DF_CardIssue_密码] DEFAULT (N'e10adc3949ba59abbe56e057f20f883e') NULL,
    PRIMARY KEY CLUSTERED ([编号] ASC)
);



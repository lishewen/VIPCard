CREATE TABLE [dbo].[Salesman] (
    [编号] INT           IDENTITY (1, 1) NOT NULL,
    [姓名] NVARCHAR (50) NOT NULL,
    [密码] NVARCHAR (50) CONSTRAINT [DF_Salesman_密码] DEFAULT (N'e10adc3949ba59abbe56e057f20f883e') NOT NULL,
    [手机] NVARCHAR (50) NULL,
    [卡号] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Salesman] PRIMARY KEY CLUSTERED ([编号] ASC)
);


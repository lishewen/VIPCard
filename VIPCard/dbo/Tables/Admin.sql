CREATE TABLE [dbo].[Admin] (
    [编号]  INT           IDENTITY (1, 1) NOT NULL,
    [用户名] NVARCHAR (50) NOT NULL,
    [密码]  NVARCHAR (50) NOT NULL,
    [卡号]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([编号] ASC)
);



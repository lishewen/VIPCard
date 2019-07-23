CREATE TABLE [dbo].[User] (
    [编号]    INT             IDENTITY (1, 1) NOT NULL,
    [用户名]   NVARCHAR (50)   CONSTRAINT [DF_User_用户名] DEFAULT ('') NULL,
    [密码]    NVARCHAR (50)   CONSTRAINT [DF__User__密码__182C9B23] DEFAULT (N'e10adc3949ba59abbe56e057f20f883e') NOT NULL,
    [手机]    NVARCHAR (50)   CONSTRAINT [DF_User_手机] DEFAULT ('') NULL,
    [卡号]    NVARCHAR (50)   NOT NULL,
    [余额]    DECIMAL (18, 2) CONSTRAINT [DF__User__余额__1920BF5C] DEFAULT ((0)) NOT NULL,
    [发卡方编号] INT             CONSTRAINT [DF__User__发卡地编号__1A14E395] DEFAULT ((1)) NULL,
    [性别]    NVARCHAR (50)   CONSTRAINT [DF_User_性别] DEFAULT (N'未知') NULL,
    [激活时间]  DATETIME        CONSTRAINT [DF_User_激活时间] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK__User__1DF06E6E1273C1CD] PRIMARY KEY CLUSTERED ([编号] ASC),
    CONSTRAINT [FK_User_CardIssue] FOREIGN KEY ([发卡方编号]) REFERENCES [dbo].[CardIssue] ([编号])
);



GO
CREATE TRIGGER [dbo].[LSWTriggerEx]
    ON [dbo].[User]
    AFTER INSERT, UPDATE
    AS  EXTERNAL NAME [SqlVipCard].[SqlVipCard.Triggers].[LSWTriggerEx]


GO
EXECUTE sp_addextendedproperty @name = N'SqlAssemblyFile', @value = N'LSWTrigger.vb', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'User', @level2type = N'TRIGGER', @level2name = N'LSWTriggerEx';


GO
EXECUTE sp_addextendedproperty @name = N'SqlAssemblyFileLine', @value = N'11', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'User', @level2type = N'TRIGGER', @level2name = N'LSWTriggerEx';


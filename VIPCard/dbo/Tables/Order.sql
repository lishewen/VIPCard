CREATE TABLE [dbo].[Order] (
    [编号]    INT             IDENTITY (1, 1) NOT NULL,
    [用户ID]  INT             NOT NULL,
    [店铺ID]  INT             NOT NULL,
    [金额]    DECIMAL (18, 2) NOT NULL,
    [时间]    DATETIME        CONSTRAINT [DF__Order__时间__145C0A3F] DEFAULT (getdate()) NOT NULL,
    [成本]    DECIMAL (18, 2) NOT NULL,
    [消费返还]  DECIMAL (18, 2) NOT NULL,
    [发卡方提成] DECIMAL (18, 2) NOT NULL,
    [我方提成]  DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK__Order__1DF06E6E07020F21] PRIMARY KEY CLUSTERED ([编号] ASC),
    CONSTRAINT [FK_Order_Store] FOREIGN KEY ([店铺ID]) REFERENCES [dbo].[Store] ([编号]),
    CONSTRAINT [FK_Order_User] FOREIGN KEY ([用户ID]) REFERENCES [dbo].[User] ([编号])
);



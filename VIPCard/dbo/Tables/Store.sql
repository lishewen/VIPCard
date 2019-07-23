CREATE TABLE [dbo].[Store] (
    [编号]     INT           IDENTITY (1, 1) NOT NULL,
    [店名]     NVARCHAR (50) NOT NULL,
    [所属行业ID] INT           NOT NULL,
    [客户端ID]  NVARCHAR (50) NOT NULL,
    [业务员ID]  INT           CONSTRAINT [DF_Store_业务员ID] DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([编号] ASC),
    CONSTRAINT [FK_Store_Salesman] FOREIGN KEY ([业务员ID]) REFERENCES [dbo].[Salesman] ([编号]),
    CONSTRAINT [FK_Store_Trade] FOREIGN KEY ([所属行业ID]) REFERENCES [dbo].[Trade] ([编号])
);



CREATE TABLE [dbo].[Trade] (
    [编号]    INT           IDENTITY (1, 1) NOT NULL,
    [名称]    NVARCHAR (50) NOT NULL,
    [消费方分成] INT           CONSTRAINT [DF__Trade__本行业分成__15502E78] DEFAULT ((30)) NOT NULL,
    [发卡方分成] INT           CONSTRAINT [DF__Trade__发卡方分成__164452B1] DEFAULT ((30)) NOT NULL,
    [成本比重]  INT           DEFAULT ((90)) NOT NULL,
    PRIMARY KEY CLUSTERED ([编号] ASC)
);



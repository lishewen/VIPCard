/****** Object:  View [dbo].[V_Order]    Script Date: 2012-05-08 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Order]
AS
SELECT     'A'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, '积分' AS 消费类型
FROM         dbo.[Order] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号
UNION
SELECT      'C'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, '现金' AS 消费类型
FROM         dbo.[CashOrder] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号

GO
/****** Object:  View [dbo].[V_OrderC]    Script Date: 2012-05-08 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_OrderC]
AS
SELECT     'A'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, C.店名, A.金额, A.时间, A.我方提成, A.发卡方提成, A.消费返还, A.成本, D.名称, '积分' AS 消费类型
FROM         dbo.[Order] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.CardIssue AS D ON B.发卡方编号 = D.编号
UNION
SELECT     'C'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, C.店名, A.金额, A.时间, A.我方提成, A.发卡方提成, A.消费返还, A.成本, D.名称, '现金' AS 消费类型
FROM         dbo.[CashOrder] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.CardIssue AS D ON B.发卡方编号 = D.编号

GO
/****** Object:  View [dbo].[V_OrderS]    Script Date: 2012-05-08 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_OrderS]
AS
SELECT      'A'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, A.我方提成, A.发卡方提成, A.消费返还, A.成本, D.姓名, C.业务员ID, '积分' AS 消费类型
FROM         dbo.[Order] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.Salesman AS D ON C.业务员ID = D.编号
UNION
SELECT      'C'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, A.我方提成, A.发卡方提成, A.消费返还, A.成本, D.姓名, C.业务员ID, '现金' AS 消费类型
FROM         dbo.[CashOrder] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.Salesman AS D ON C.业务员ID = D.编号

GO
/****** Object:  View [dbo].[V_OrderT]    Script Date: 2012-05-08 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_OrderT]
AS
SELECT      'A'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, D.名称 AS 行业, A.我方提成, A.发卡方提成, A.消费返还, A.成本, '积分' AS 消费类型
FROM         dbo.[Order] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.Trade AS D ON C.所属行业ID = D.编号
UNION
SELECT      'C'+cast(A.编号 as varchar) as 编号, B.用户名, B.卡号, B.手机, C.店名, A.金额, A.时间, D.名称 AS 行业, A.我方提成, A.发卡方提成, A.消费返还, A.成本, '现金' AS 消费类型
FROM         dbo.[CashOrder] AS A LEFT OUTER JOIN
                      dbo.[User] AS B ON A.用户ID = B.编号 LEFT OUTER JOIN
                      dbo.Store AS C ON A.店铺ID = C.编号 LEFT OUTER JOIN
                      dbo.Trade AS D ON C.所属行业ID = D.编号

GO
CREATE TRIGGER LSWOrderTrigger
   ON  [Order]
   AFTER INSERT
AS 
BEGIN
	declare @id int,@sid int,@uid int,@成本比重 int,@消费方分成 int,@发卡方分成 int
	declare @money decimal(18,2),@成本 decimal(18,2),@消费返还 decimal(18,2)
	declare @发卡方提成 decimal(18,2),@我方提成 decimal(18,2)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	SELECT @id=编号,@sid=[店铺ID],@uid=[用户ID],@money=金额
		FROM INSERTED
		
	select @成本比重=成本比重,@消费方分成=消费方分成,@发卡方分成=发卡方分成 from trade
	where 编号 in
	(SELECT [所属行业ID] FROM store where 编号=@sid)
	
	set @成本=@money*@成本比重/100
	set @消费返还=(@money-@成本)*@消费方分成/100
	set @发卡方提成=(@money-@成本)*@发卡方分成/100
	set @我方提成=@money-@成本-@消费返还-@发卡方提成
	
	UPDATE [Order] SET 成本=@成本,消费返还=@消费返还,发卡方提成=@发卡方提成,我方提成=@我方提成 Where 编号=@id
	UPDATE [User] SET 余额=余额-@money+@消费返还 Where 编号=@uid
END
GO
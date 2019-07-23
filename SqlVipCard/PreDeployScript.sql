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
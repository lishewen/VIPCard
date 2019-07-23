USE [sqlbreakupclub]
GO

/****** Object:  View [dbo].[V_User]    Script Date: 2012-05-19 23:44:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [dbo].[V_User]
AS
SELECT   c.编号, c.用户名, c.手机, c.卡号, c.余额, c.性别, c.激活时间, 
                c.级别, b.[消费额], d.名称 AS '发卡人'
FROM      dbo.[User] AS c LEFT OUTER JOIN
                    (SELECT   用户ID, SUM(金额) AS '消费额'
                     FROM      (SELECT   用户ID, 金额
                                      FROM      dbo.[Order]
                                      UNION
                                      SELECT   用户ID, 金额
                                      FROM      dbo.CashOrder) AS a
                     GROUP BY 用户ID) AS b ON c.编号 = b.用户ID LEFT OUTER JOIN
                dbo.CardIssue AS d ON c.发卡方编号 = d.编号



GO



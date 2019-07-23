-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_VUser 
	-- Add the parameters for the stored procedure here
	@sid int=0
WITH ENCRYPTION
AS
BEGIN
IF @sid=0
BEGIN
	SELECT   c.编号, c.用户名, c.手机, c.卡号, c.余额, c.性别, c.激活时间, c.级别, c.年, c.职业, ISNULL(b.消费额, 0) AS '消费额', 
					ISNULL(b.积分消费额, 0) AS '积分消费额', ISNULL(b.现金消费额, 0) AS '现金消费额', d.名称 AS '发卡人', 
					CASE WHEN c.用户名 = '' THEN '未激活' ELSE '激活' END AS '状态'
	FROM      dbo.[User] AS c LEFT OUTER JOIN
						(SELECT   用户ID, SUM(金额) AS '消费额', SUM(积分消费额) AS '积分消费额', SUM(现金消费额) 
										 AS '现金消费额'
						 FROM      (SELECT   用户ID, 金额, 金额 AS '积分消费额', 0 AS '现金消费额'
										  FROM      dbo.[Order]
										  UNION
										  SELECT   用户ID, 金额, 0 AS '积分消费额', 金额 AS '现金消费额'
										  FROM      dbo.CashOrder) AS a
						 GROUP BY 用户ID) AS b ON c.编号 = b.用户ID LEFT OUTER JOIN
					dbo.CardIssue AS d ON c.发卡方编号 = d.编号
END	
ELSE
BEGIN
	SELECT   c.编号, c.用户名, c.手机, c.卡号, c.余额, c.性别, c.激活时间, c.级别, c.年, c.职业, ISNULL(b.消费额, 0) AS '消费额', 
					ISNULL(b.积分消费额, 0) AS '积分消费额', ISNULL(b.现金消费额, 0) AS '现金消费额', d.名称 AS '发卡人', 
					CASE WHEN c.用户名 = '' THEN '未激活' ELSE '激活' END AS '状态'
	FROM      dbo.[User] AS c LEFT OUTER JOIN
						(SELECT   用户ID, SUM(金额) AS '消费额', SUM(积分消费额) AS '积分消费额', SUM(现金消费额) 
										 AS '现金消费额'
						 FROM      (SELECT   用户ID, 金额, 金额 AS '积分消费额', 0 AS '现金消费额'
										  FROM      dbo.[Order] WHERE 店铺ID=@sid
										  UNION
										  SELECT   用户ID, 金额, 0 AS '积分消费额', 金额 AS '现金消费额'
										  FROM      dbo.CashOrder WHERE 店铺ID=@sid) AS a
						 GROUP BY 用户ID) AS b ON c.编号 = b.用户ID LEFT OUTER JOIN
					dbo.CardIssue AS d ON c.发卡方编号 = d.编号
END
END
GO

CREATE PROCEDURE [dbo].[LSWAddUserEx]
@startno INT, @endno INT, @fid INT
AS EXTERNAL NAME [SqlVipCard].[SqlVipCard.StoredProcedures].[LSWAddUserEx]


GO
EXECUTE sp_addextendedproperty @name = N'SqlAssemblyFile', @value = N'LSWStoredProcedure.vb', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'PROCEDURE', @level1name = N'LSWAddUserEx';


GO
EXECUTE sp_addextendedproperty @name = N'SqlAssemblyFileLine', @value = N'9', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'PROCEDURE', @level1name = N'LSWAddUserEx';


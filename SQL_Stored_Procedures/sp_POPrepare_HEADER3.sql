USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_POPrepare_HEADER3]    Script Date: 8/19/2022 3:42:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_POPrepare_HEADER3] 
--@FromDate DateTime,
--@ToDate DateTime,
@POPNumber nvarchar(20),
@Supplier nvarchar(50),
@Brand nvarchar(50),
@Memo nvarchar(50)

AS
BEGIN
	--IF (@POPNumber = '' AND @Supplier = '' AND @Brand = '' AND @Memo = '')
	--	SELECT
	--		CreateDate,
	--		POPrepareNumber,
	--		Supplier,
	--		Brand,
	--		Memo
	--	FROM POPrepare
	--	WHERE
	--	POPrepareStatus = 'POPrepare'
	--	ORDER BY POPrepareNumber DESC
	--ELSE 
	IF (@Brand = '')
		SELECT
			CreateDate,
			POPrepareNumber,
			Supplier,
			Brand,
			Memo
		FROM POPrepare
		WHERE 
		POPrepareStatus = 'POPrepare' and 
		--CreateDate >= @FromDate And CreateDate < DATEADD(DAY, 1, @ToDate) and 
		POPrepareNumber like '%'+@POPNumber+'%' and 
		Supplier like '%'+@Supplier+'%' and 
		Memo like '%'+@Memo+'%'
		ORDER BY POPrepareNumber desc
	ELSE
		SELECT
			CreateDate,
			POPrepareNumber,
			Supplier,
			Brand,
			Memo
		FROM POPrepare
		WHERE 
		POPrepareStatus = 'POPrepare' and 
		--CreateDate >= @FromDate And CreateDate < DATEADD(DAY, 1, @ToDate) and 
		POPrepareNumber like '%'+@POPNumber+'%' and 
		Supplier like '%'+@Supplier+'%' and 
		Brand like '%'+@Brand+'%' and
		Memo like '%'+@Memo+'%'
		ORDER BY POPrepareNumber desc
END

select * from poprepare
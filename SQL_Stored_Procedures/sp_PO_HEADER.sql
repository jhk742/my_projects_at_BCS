USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_PO_HEADER]    Script Date: 8/19/2022 3:42:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_PO_HEADER]
@FromDate DateTime,
@ToDate DateTime

WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;

	IF OBJECT_ID('tempdb..#TEMPPRECEIPTD') IS NOT NULL DROP TABLE #TEMPPRECEIPTD ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
		SELECT PTHNUM_0, POHNUM_0, CREDAT_0
		INTO #TEMPPRECEIPTD
		FROM PRECEIPTD WITH(NOLOCK)
		GROUP BY PTHNUM_0, POHNUM_0, CREDAT_0

	SELECT A.ORDDAT_0, A.POHNUM_0, B.PTHNUM_0, B.CREDAT_0, A.POHFCY_0, A.BPSNUM_0, A.PMemo, A.PStatus, A.EXTRCPDAT1_0
	FROM PORDER A WITH(NOLOCK)
	LEFT OUTER JOIN #TEMPPRECEIPTD B WITH(NOLOCK) ON A.POHNUM_0 = B.POHNUM_0
	WHERE A.PStatus != 'Deleted' and A.ORDDAT_0 >= @FromDate And A.ORDDAT_0 < DATEADD(DAY, 1, @ToDate)
	ORDER BY A.ORDDAT_0 DESC

END


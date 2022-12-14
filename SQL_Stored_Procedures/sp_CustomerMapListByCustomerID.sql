USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerMapListByCustomerID]    Script Date: 8/19/2022 3:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_CustomerMapListByCustomerID]
@CustomerID Nvarchar(100)

WITH RECOMPILE
AS 
BEGIN
	

	
	DECLARE @INACTIVEDATE datetime
	SET @INACTIVEDATE = DATEADD(MONTH,-6,GETDATE())
	
	IF OBJECT_ID('tempdb..#TEMPADDRESS') IS NOT NULL DROP TABLE #TEMPADDRESS ------------------------------------------------------------------------------ TEMP TABLE [#TEMPADDRESS]
		SELECT 
		B.BPCKEY_0 AS CustomerKey,
		A.BPANUM_0 AS CustomerID,
		B.BPCNAM_0 AS CustomerName,
		A.BPAADDLIG_0 AS Address,
		A.CTY_0 AS City,
		A.POSCOD_0 AS Postal,
		A.SAT_0 AS State,
		A.CRY_0 AS CountryID,
		A.CRYNAM_0 AS CountryName,
		A.BPAADDLIG_1 AS Memo, 
		A.TEL_0 ,A.TEL_1,A.FAX_0,A.MOB_0,A.WEB_0,
		B.GRP_0, B.REP_0 AS SalesRep,
		B.PTE_0 AS Payment, B.YPACKMEMO_0,B.YDELVMEMO_0,BPCSTA_0 AS InActive,WEB_3,WEB_4,
		C.LastInvoiceDate
		--,IIF(BPCSTA_0 != 2, 'InActive',IIF(@INACTIVEDATE < C.LastInvoiceDate, 'Active','6MonthNoInvoice')) AS CustomerState
		,IIF(BPCSTA_0 != 2, 'InActive','Active') AS CustomerState
		INTO #TEMPADDRESS
		FROM CoreXDB.dbo.BPADDRESS A
		LEFT OUTER JOIN CoreXDB.dbo.BPCUSTOMER B ON A.BPANUM_0 = B.BPCNUM_0
		LEFT OUTER JOIN (SELECT BPR_0,MAX(ACCDAT_0) AS LastInvoiceDate FROM CoreXDB.dbo.SINVOICE GROUP BY BPR_0) C ON A.BPANUM_0 = C.BPR_0
		WHERE A.BPAADD_0 = 'SHIP' AND BPANUM_0 = @CustomerID
		ORDER BY CustomerState,REP_0,BPCNUM_0, BPCNAM_0 DESC
		
		SELECT *,IIF(CustomerState = 'Active',1,IIF(CustomerState = '6MonthNoInvoice',2,3)) AS CustomerSort 
		FROM #TEMPADDRESS 
		ORDER BY CustomerSort,SalesRep,CustomerID, CustomerName DESC
				

END


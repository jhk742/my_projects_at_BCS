USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ARBalanceAccountReport]    Script Date: 8/19/2022 3:39:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_ARBalanceAccountReport] 
@FromDate Datetime, @ToDate DateTime

WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @FDATE datetime, @TDATE datetime
	SET @FDATE = @FromDate
	SET @TDATE = @ToDate
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

	--beginning
	--get All Invoice
		IF OBJECT_ID('tempdb..#TEMPSINVOICE') IS NOT NULL DROP TABLE #TEMPSINVOICE ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select 
					BPR_0 AS CustomerID,
					NUM_0 AS InvoiceNumber,
					ACCDAT_0 AS InvoiceDate,
					AMTATI_0 AS InvoiceAmount,
					FCY_0 AS Site
				INTO #TEMPSINVOICE
				from SINVOICE WITH(NOLOCK)
				WHERE CPY_0 = 'BIC' and (NUM_0 like 'INV%' OR NUM_0 like 'DIR%') and ACCDAT_0 < @FDATE
				--and NUM_0 not in(
				--'DIR004536', 'DIR004606', 'DIR004619', 'DIR004547',	'DIR004607', 'DIR000237', 'DIR004504', 'DIR004551',	'DIR004307', 'DIR004639', 'DIR004582', 'DIR004642',	
				--'DIR004583', 'DIR004672', 'DIR004584', 'DIR004641',	'DIR004540', 'DIR004541', 'DIR004640', 'DIR004673',	'DIR004667', 'INV024584', 'DIR004674', 'DIR004675',	
				--'INV043624', 'INV043625', 'DIR004660', 'DIR004505',	'DIR004655', 'DIR004656', 'DIR004657', 'DIR004658',	'DIR003823', 'DIR004564', 'DIR004568', 'DIR004631',	
				--'DIR004633', 'DIR004632', 'DIR004634', 'DIR004535',	'INV015039', 'INV015041', 'INV020100', 'INV021016',	'INV039129', 'INV047455', 'INV054376', 'DIR004154',	
				--'DIR003488', 'DIR003897', 'DIR004109', 'DIR004534',	'DIR004608', 'DIR004565', 'DIR004537', 'DIR004538',	'INV043519', 'INV068012', 'DIR003511', 'DIR004569',	
				--'DIR003483', 'DIR004539', 'DIR004668', 'DIR004061',	'DIR004611', 'DIR004136', 'DIR004137', 'DIR004138',	'DIR004139', 'DIR004140', 'DIR004189', 'DIR004190',	
				--'DIR004191', 'DIR004192', 'DIR004064', 'DIR004308',	'DIR004195', 'DIR004196', 'INV044704', 'DIR004665',	'DIR004662', 'DIR005025', 'INV197137', 'INV225335'
				--, 'INV043525' -- CURTIVAR
				--, 'DIR004609' -- IMPORTADORA
				--, 'INV201355' -- MAKANA
				--, 'INV200164', 'INV200165','INV201031','INV206389' -- VENDORPICKUP
				--)
				--and BPR_0 not in('SUPERCITY', 'MARUWA', 'WHOLESOME')
				and (CASE WHEN '' != '' THEN BPR_0 ELSE '' END)
					= (CASE WHEN '' != '' THEN '' ELSE '' END)
				order by NUM_0


		--get PaymentAmount Total (Payment + X3 payment)
		IF OBJECT_ID('tempdb..#TEMPPAYMENT') IS NOT NULL DROP TABLE #TEMPPAYMENT ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.VCRNUM_0, SUM(IIF(DENCOD_0 = 'OVER', 0, PD.AMTLIN_0)) AS VCRNUM_Total
				INTO #TEMPPAYMENT
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and (PD.VCRNUM_0 like 'INV%' OR PD.VCRNUM_0 like 'DIR%') 
				GROUP BY PD.VCRNUM_0
				order by PD.VCRNUM_0

		--Over Payment Total
		IF OBJECT_ID('tempdb..#TEMPOVERPAYMENT') IS NOT NULL DROP TABLE #TEMPOVERPAYMENT ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0 AS InvoiceNumber, SUM(PD.AMTLIN_0) AS OverPaymentTotal
				INTO #TEMPOVERPAYMENT
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and (PD.VCRNUM_0 like 'OP%')-- AND DENCOD_0 not in('SHRT', 'OVER') 
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get Credit Total
		IF OBJECT_ID('tempdb..#TEMPCREDIT') IS NOT NULL DROP TABLE #TEMPCREDIT ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPCREDIT
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and (PD.VCRNUM_0 like 'SCM%' AND PD.VCRNUM_0 not like 'SCMT%') AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0


		--get return Credit Total
		IF OBJECT_ID('tempdb..#TEMPRETURNCREDIT') IS NOT NULL DROP TABLE #TEMPRETURNCREDIT ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPRETURNCREDIT
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and PD.VCRNUM_0 like 'BCS%' AND PD.NUMDEP_0 like 'INV%' 
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get term Credit Total
		IF OBJECT_ID('tempdb..#TEMPTERMCREDIT') IS NOT NULL DROP TABLE #TEMPTERMCREDIT ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPTERMCREDIT
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and PD.VCRNUM_0 like 'SCMT%' AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get Write-off Total
		IF OBJECT_ID('tempdb..#TEMPWO') IS NOT NULL DROP TABLE #TEMPWO ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPWO
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < @FDATE and PD.VCRNUM_0 like 'WO%' AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		IF OBJECT_ID('tempdb..#beginning') IS NOT NULL DROP TABLE #beginning	
		select
		A.CustomerID,
		G.BPCNAM_0 AS CustomerName,
		--SUM(IIF(A.InvoiceDate = @TDATE, A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS NotDue,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -30, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -1, @TDATE), A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days030,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -60, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -31, @TDATE) , A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days3160,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -90, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -61, @TDATE) , A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days6190,
		--SUM(IIF(A.InvoiceDate <= DATEADD(DAY, -91, @TDATE), A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days90Over,
		--A.InvoiceAmount, 
		--ISNULL(B.VCRNUM_Total,0) AS PaymentAmount, 
		--ISNULL(C.NUMDEP_Total,0) AS CreditTotal, 
		--ISNULL(D.NUMDEP_Total,0) AS ReturnCreditTotal, 
		--ISNULL(E.NUMDEP_Total,0) AS TermCreditTotal,
		SUM(A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0) + ISNULL(WO.NUMDEP_Total,0))) AS Total
		--IIF(A.InvoiceAmount = ISNULL(B.VCRNUM_Total,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0), 'CLOSE', 'OPEN')
		into #beginning
		from #TEMPSINVOICE A
		left outer join #TEMPPAYMENT B ON A.InvoiceNumber = B.VCRNUM_0
		left outer join #TEMPCREDIT C ON A.InvoiceNumber = C.NUMDEP_0
		left outer join #TEMPRETURNCREDIT D ON A.InvoiceNumber = D.NUMDEP_0
		left outer join #TEMPTERMCREDIT E ON A.InvoiceNumber = E.NUMDEP_0
		left outer join #TEMPWO WO ON A.InvoiceNumber = WO.NUMDEP_0
		left outer join GACCDUDATE F ON A.InvoiceNumber = F.NUM_0
		left outer join BPCUSTOMER G ON A.CustomerID = G.BPCNUM_0
		LEFT OUTER JOIN #TEMPOVERPAYMENT O ON A.InvoiceNumber = O.InvoiceNumber
		where A.InvoiceAmount > ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0) + ISNULL(WO.NUMDEP_Total,0)
		AND (F.FLGCLE_0 != 2 OR F.FLGCLE_0 is null)
		group by CustomerID, G.BPCNAM_0
		order by A.CustomerID



	--debit (accounting journal)
	IF OBJECT_ID('tempdb..#debit') IS NOT NULL DROP TABLE #debit
	select BPR_0,SUM(AMTCUR_0) as debit
	into #debit
	from GACCENTRYD 
	where ACC_0 = '12100' and sns_0 = 1 
	and ACCDAT_0 >= @FDATE and ACCDAT_0 < DATEADD(DAY, 1, @TDATE)
	group by BPR_0
	order by BPR_0

	--payment로 수정
			--credit
			--IF OBJECT_ID('tempdb..#credit') IS NOT NULL DROP TABLE #credit
			--select BPR_0,SUM(AMTCUR_0) as credit
			--into #credit
			--from GACCENTRYD 
			--where ACC_0 = '12100' and sns_0 = -1 
			--and ACCDAT_0 >= @FDATE and ACCDAT_0 < DATEADD(DAY, 1, @TDATE)
			--group by BPR_0
			--order by BPR_0

			--select * 
			--from paymentd 
			--where BPRLIN_0 = 'M4D'
	--DECLARE @FDATE datetime, @TDATE datetime
	--set @FDATE = '12-01-2021'
	--set @TDATE = '12-24-2021'
		
			IF OBJECT_ID('tempdb..#credit') IS NOT NULL DROP TABLE #credit
			select BPRLIN_0 AS CustomerID, SUM(AMTLIN_0) as credit
			into #credit
			from PAYMENTD
			where UPDDATTIM_0 >= @FDATE and UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and NUM_0 not like 'PAY%'
			and DENCOD_0 != 'OVER'
			--and DENCOD_0 != 'SPDIR'
			and VCRNUM_0 not like 'P%'
			and NUMDEP_0 not like 'P%'
			group by BPRLIN_0

			--select TOP 10000 * from PAYMENTD order by rowid desc
			--select * from #credit where BPRLIN_0 = 'M4D'

	--ending

		--get All Invoice
		IF OBJECT_ID('tempdb..#TEMPSINVOICE2') IS NOT NULL DROP TABLE #TEMPSINVOICE2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select 
					BPR_0 AS CustomerID,
					NUM_0 AS InvoiceNumber,
					ACCDAT_0 AS InvoiceDate,
					AMTATI_0 AS InvoiceAmount,
					FCY_0 AS Site
				INTO #TEMPSINVOICE2
				from SINVOICE WITH(NOLOCK)
				WHERE CPY_0 = 'BIC' and (NUM_0 like 'INV%' OR NUM_0 like 'DIR%') and ACCDAT_0 < DATEADD(DAY, 1, @TDATE)
				--and NUM_0 not in(
				--'DIR004536', 'DIR004606', 'DIR004619', 'DIR004547',	'DIR004607', 'DIR000237', 'DIR004504', 'DIR004551',	'DIR004307', 'DIR004639', 'DIR004582', 'DIR004642',	
				--'DIR004583', 'DIR004672', 'DIR004584', 'DIR004641',	'DIR004540', 'DIR004541', 'DIR004640', 'DIR004673',	'DIR004667', 'INV024584', 'DIR004674', 'DIR004675',	
				--'INV043624', 'INV043625', 'DIR004660', 'DIR004505',	'DIR004655', 'DIR004656', 'DIR004657', 'DIR004658',	'DIR003823', 'DIR004564', 'DIR004568', 'DIR004631',	
				--'DIR004633', 'DIR004632', 'DIR004634', 'DIR004535',	'INV015039', 'INV015041', 'INV020100', 'INV021016',	'INV039129', 'INV047455', 'INV054376', 'DIR004154',	
				--'DIR003488', 'DIR003897', 'DIR004109', 'DIR004534',	'DIR004608', 'DIR004565', 'DIR004537', 'DIR004538',	'INV043519', 'INV068012', 'DIR003511', 'DIR004569',	
				--'DIR003483', 'DIR004539', 'DIR004668', 'DIR004061',	'DIR004611', 'DIR004136', 'DIR004137', 'DIR004138',	'DIR004139', 'DIR004140', 'DIR004189', 'DIR004190',	
				--'DIR004191', 'DIR004192', 'DIR004064', 'DIR004308',	'DIR004195', 'DIR004196', 'INV044704', 'DIR004665',	'DIR004662', 'DIR005025', 'INV197137', 'INV225335'
				--, 'INV043525' -- CURTIVAR
				--, 'DIR004609' -- IMPORTADORA
				--, 'INV201355' -- MAKANA
				--, 'INV200164', 'INV200165','INV201031','INV206389' -- VENDORPICKUP
				--)
				--and BPR_0 not in('SUPERCITY', 'MARUWA', 'WHOLESOME')
				and (CASE WHEN '' != '' THEN BPR_0 ELSE '' END)
					= (CASE WHEN '' != '' THEN '' ELSE '' END)
				order by NUM_0


		--get PaymentAmount Total (Payment + X3 payment)
		IF OBJECT_ID('tempdb..#TEMPPAYMENT2') IS NOT NULL DROP TABLE #TEMPPAYMENT2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.VCRNUM_0, SUM(IIF(DENCOD_0 = 'OVER', 0, PD.AMTLIN_0)) AS VCRNUM_Total
				INTO #TEMPPAYMENT2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and (PD.VCRNUM_0 like 'INV%' OR PD.VCRNUM_0 like 'DIR%') 
				GROUP BY PD.VCRNUM_0
				order by PD.VCRNUM_0

		--Over Payment Total
		IF OBJECT_ID('tempdb..#TEMPOVERPAYMENT2') IS NOT NULL DROP TABLE #TEMPOVERPAYMENT2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0 AS InvoiceNumber, SUM(PD.AMTLIN_0) AS OverPaymentTotal
				INTO #TEMPOVERPAYMENT2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and (PD.VCRNUM_0 like 'OP%')-- AND DENCOD_0 not in('SHRT', 'OVER') 
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get Credit Total
		IF OBJECT_ID('tempdb..#TEMPCREDIT2') IS NOT NULL DROP TABLE #TEMPCREDIT2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPCREDIT2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and (PD.VCRNUM_0 like 'SCM%' AND PD.VCRNUM_0 not like 'SCMT%') AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0


		--get return Credit Total
		IF OBJECT_ID('tempdb..#TEMPRETURNCREDIT2') IS NOT NULL DROP TABLE #TEMPRETURNCREDIT2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPRETURNCREDIT2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and PD.VCRNUM_0 like 'BCS%' AND PD.NUMDEP_0 like 'INV%' 
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get term Credit Total
		IF OBJECT_ID('tempdb..#TEMPTERMCREDIT2') IS NOT NULL DROP TABLE #TEMPTERMCREDIT2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPTERMCREDIT2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and PD.VCRNUM_0 like 'SCMT%' AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		--get Write-off Total
		IF OBJECT_ID('tempdb..#TEMPWO2') IS NOT NULL DROP TABLE #TEMPWO2 ------------------------------------------------------------------------------ TEMP TABLE [#TEMPCREDITRETURN]
				select PD.NUMDEP_0, SUM(PD.AMTLIN_0) AS NUMDEP_Total
				INTO #TEMPWO2
				from PAYMENTD PD WITH(NOLOCK)
				WHERE PD.UPDDATTIM_0 < DATEADD(DAY, 1, @TDATE) and PD.VCRNUM_0 like 'WO%' AND (PD.NUMDEP_0 like 'INV%' OR PD.NUMDEP_0 like 'DIR%')
				GROUP BY PD.NUMDEP_0
				order by PD.NUMDEP_0

		IF OBJECT_ID('tempdb..#ending') IS NOT NULL DROP TABLE #ending
		select
		A.CustomerID,
		G.BPCNAM_0 AS CustomerName,
		--SUM(IIF(A.InvoiceDate = @TDATE, A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS NotDue,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -30, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -1, @TDATE), A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days030,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -60, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -31, @TDATE) , A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days3160,
		--SUM(IIF(A.InvoiceDate >= DATEADD(DAY, -90, @TDATE) and A.InvoiceDate <= DATEADD(DAY, -61, @TDATE) , A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days6190,
		--SUM(IIF(A.InvoiceDate <= DATEADD(DAY, -91, @TDATE), A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0)), 0)) AS Days90Over,
		--A.InvoiceAmount, 
		--ISNULL(B.VCRNUM_Total,0) AS PaymentAmount, 
		--ISNULL(C.NUMDEP_Total,0) AS CreditTotal, 
		--ISNULL(D.NUMDEP_Total,0) AS ReturnCreditTotal, 
		--ISNULL(E.NUMDEP_Total,0) AS TermCreditTotal,
		SUM(A.InvoiceAmount - (ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0) + ISNULL(WO.NUMDEP_Total,0))) AS Total
		--IIF(A.InvoiceAmount = ISNULL(B.VCRNUM_Total,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0), 'CLOSE', 'OPEN')
		into #ending
		from #TEMPSINVOICE2 A
		left outer join #TEMPPAYMENT2 B ON A.InvoiceNumber = B.VCRNUM_0
		left outer join #TEMPCREDIT2 C ON A.InvoiceNumber = C.NUMDEP_0
		left outer join #TEMPRETURNCREDIT2 D ON A.InvoiceNumber = D.NUMDEP_0
		left outer join #TEMPTERMCREDIT2 E ON A.InvoiceNumber = E.NUMDEP_0
		left outer join #TEMPWO2 WO ON A.InvoiceNumber = WO.NUMDEP_0
		left outer join GACCDUDATE F ON A.InvoiceNumber = F.NUM_0
		left outer join BPCUSTOMER G ON A.CustomerID = G.BPCNUM_0
		LEFT OUTER JOIN #TEMPOVERPAYMENT2 O ON A.InvoiceNumber = O.InvoiceNumber
		where A.InvoiceAmount > ISNULL(B.VCRNUM_Total,0) + ISNULL(O.OverPaymentTotal,0) + ISNULL(C.NUMDEP_Total,0) + ISNULL(D.NUMDEP_Total,0) + ISNULL(E.NUMDEP_Total,0) + ISNULL(WO.NUMDEP_Total,0) 
		AND (F.FLGCLE_0 != 2 OR F.FLGCLE_0 is null)
		group by CustomerID, G.BPCNAM_0
		order by A.CustomerID

	--select A.BPCNUM_0, B.Total, C.debit, D.credit, E.Total--, B.Total + C.debit - D.credit
	--from BPCUSTOMER A 
	--left outer join #beginning B ON A.BPCNUM_0 = B.CustomerID
	--left outer join #debit C ON A.BPCNUM_0 = C.BPR_0
	--left outer join #credit D ON A.BPCNUM_0 = D.BPR_0
	--left outer join #ending E ON A.BPCNUM_0 = E.CustomerID
	----where E.Total != B.Total + C.debit - D.credit
	--order by bpcnum_0


	select A.BPCNUM_0 AS CustomerID,
	A.BPCNAM_0 AS CustomerName, 
	ISNULL(B.Total,0) AS BeginningBalance, 
	ISNULL(C.debit,0) AS Debit, 
	ISNULL(D.credit,0) AS Credit, 
	ISNULL(E.Total,0) AS EndingBalance
	--, ISNULL(B.Total,0) + ISNULL(C.debit,0) - ISNULL(D.credit,0)
	from BPCUSTOMER A 
	left outer join #beginning B ON A.BPCNUM_0 = B.CustomerID
	left outer join #debit C ON A.BPCNUM_0 = C.BPR_0
	left outer join #credit D ON A.BPCNUM_0 = D.CustomerID
	left outer join #ending E ON A.BPCNUM_0 = E.CustomerID
	--where ISNULL(E.Total,0) != ISNULL(B.Total,0) + ISNULL(C.debit,0) - ISNULL(D.credit,0)
	where not (ISNULL(B.Total,0) = 0 AND
	ISNULL(C.debit,0) = 0 AND
	ISNULL(D.credit,0)= 0 AND 
	ISNULL(E.Total,0) = 0)
	order by bpcnum_0

	

END



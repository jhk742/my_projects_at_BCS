USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_PurchaseOrderExceptionReport]    Script Date: 8/19/2022 3:40:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_PurchaseOrderExceptionReport] 
@FromDate Datetime, 
@AsOfDate DateTime, 
@CheckNumber varchar(10), 
@SupplierID varchar(50), 
@POOpenStatus varchar(10), 
@POFromX3 varchar(30),
@PONumber varchar(50),
@GRNumber varchar(50),
@SupplierDocNumber varchar(100)

WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Date datetime, @FDATE datetime
	SET @Date = @AsOfDate
	SET @FDATE= @FromDate
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

IF OBJECT_ID('tempdb..#POTEMP') IS NOT NULL DROP TABLE #POTEMP
		select 
		POHNUM_0, 
		SUM(GROPRI_0 * QTY_0) AS TotalPOGrossAmount, 
		SUM(QTY_0 * EDLP) AS POEDLP,
		SUM(QTY_0 * ROUND(GROPRI_0*(EDLPP/100),2)) AS POEDLPP,
		SUM(QTY_0 * TermPromo) AS POTermPromo,
		SUM(QTY_0 * ROUND(GROPRI_0*(TermPromoP/100),2)) AS POTermPromoP,
		SUM((GROPRI_0 - NETPRI_0) * QTY_0) AS TotalPOPromotionAmount ,
		SUM(NETPRI_0 * QTY_0) AS TotalPOAmount
		into #POTEMP
		from porderd 
		group by POHNUM_0 
		order by POHNUM_0 desc


IF OBJECT_ID('tempdb..#RECTEMP') IS NOT NULL DROP TABLE #RECTEMP
		select 
		POHNUM_0,
		PTHNUM_0,
		SUM(GROPRI_0 * QTYUOM_0) AS TotalRECGrossAmount, 
		SUM(QTYUOM_0 * EDLP) AS RECEDLP,
		SUM(QTYUOM_0 * ROUND(GROPRI_0*(EDLPP/100),2)) AS RECEDLPP,
		SUM(QTYUOM_0 * TermPromo) AS RECTermPromo,
		SUM(QTYUOM_0 * ROUND(GROPRI_0*(TermPromoP/100),2)) AS RECTermPromoP,
		SUM((GROPRI_0 - NETPRI_0) * QTYUOM_0) AS TotalRECPromotionAmount,
		SUM(NETPRI_0 * QTYUOM_0) AS TotalRECAmount
		into #RECTEMP
		from PRECEIPTD 
		where RCPDAT_0 >= @FDATE And RCPDAT_0 < DATEADD(DAY, 1, @Date)
		group by POHNUM_0 , PTHNUM_0
		order by POHNUM_0 desc


IF OBJECT_ID('tempdb..#TEMP') IS NOT NULL DROP TABLE #TEMP
		select 
		A.POHNUM_0, 
		B.PTHNUM_0, 
		A.TotalPOGrossAmount,
		A.POEDLP,
		A.POEDLPP,
		A.POTermPromo,
		A.POTermPromoP,
		A.TotalPOPromotionAmount,
		A.TotalPOAmount,
		B.TotalRECGrossAmount,
		B.RECEDLP,
		B.RECEDLPP,
		B.RECTermPromo,
		B.RECTermPromoP,
		B.TotalRECPromotionAmount,
		B.TotalRECAmount
		into #TEMP
		from #POTEMP A 
		left outer join #RECTEMP B ON B.POHNUM_0 = A.POHNUM_0

IF OBJECT_ID('tempdb..#TEMPOrder') IS NOT NULL DROP TABLE #TEMPOrder
		select A.POHNUM_0 AS PONumber, SUM(A.NETPRI_0 * A.QTY_0) AS POAmount
		into #TEMPOrder
		from PORDERD A
		group by A.POHNUM_0
		order by A.POHNUM_0

IF OBJECT_ID('tempdb..#TEMPREC') IS NOT NULL DROP TABLE #TEMPREC
		select A.PTHNUM_0, SUM((A.GROPRI_0 - A.NETPRI_0)*QTYUOM_0) AS GRPurchaseAllowance, SUM(A.NETPRI_0 * QTYUOM_0) AS GRAmount
		into #TEMPREC
		from PRECEIPTD A 
		group by A.PTHNUM_0
		order by A.PTHNUM_0

IF OBJECT_ID('tempdb..#TEMPPINVOICE') IS NOT NULL DROP TABLE #TEMPPINVOICE 
		select 
			PINVOICE.BPR_0 AS CustomerID,
			PINVOICE.NUM_0 AS InvoiceNumber,
			PINVOICE.ACCDAT_0 AS InvoiceDate,
			PINVOICE.AMTATI_0 AS InvoiceAmount,
			PINVOICE.UPDDAT_0,
			PINVOICE.PStatus,
			PINVOICE.BPRVCR_0,
			PINVOICE.ORIDOCNUM_0,
			PINVOICE.INVREF_0 AS SupplierDocNumber
		INTO #TEMPPINVOICE
		from PINVOICE WITH(NOLOCK)
		WHERE PINVOICE.CPY_0 = 'BIC' and PINVOICE.NUM_0 like 'PIN%' and PINVOICE.ACCDAT_0 < DATEADD(DAY, 1, @Date)
		and NUM_0 not in(
		'PIN002177', 'PIN002170', 'PIN002171', 'PIN002467',	'PIN001387', 'PIN001663', 'PIN001671', 'PIN002120',	'PIN002216', 'PIN003636', 'PIN004171', 'PIN004625',	
		'PIN002172', 'PIN004535', 'PIN003064', 'PIN004371',	'PIN004789', 'PIN004903', 'PIN004904', 'PIN005783',	'PIN006168', 'PIN192498', 'PIN002319', 'PIN002707',	
		'PIN002318', 'PIN002176', 'PIN002226', 'PIN002174',	'PIN002312', 'PIN002468', 'PIN005309', 'PIN192355', 'PIN003667', 'PIN003481', 'PIN000092', 
		'PIN000211', 'PIN192574', 'PIN000394', 'PIN002410', 'PIN000642', 'PIN000070', 'PIN000966', 'PIN005699', 'PIN006102', 'PIN192461', 'PIN192464', 'PIN000068',
		'PIN005678', 'PIN000047', 'PIN004550', 'PIN006166', 'PIN002471', 'PIN002469', 'PIN002470', 'PIN004782', 'PIN192651', 'PIN006131', 'PIN006144', 'PIN006115',
		'PIN000091'
		)
		order by PINVOICE.NUM_0
--select * from #TEMPPINVOICE order by InvoiceNumber desc

--get VCRNUM Total
IF OBJECT_ID('tempdb..#TEMPPVCRNUM') IS NOT NULL DROP TABLE #TEMPPVCRNUM 
		select PD.VCRNUM_0, SUM(PD.AMTLIN_0) AS PVCRNUM_Total
		INTO #TEMPPVCRNUM
		from PAYMENTD PD WITH(NOLOCK)
		left outer join PAYMENTH PH WITH(NOLOCK) ON PD.NUM_0 = PH.NUM_0
		WHERE PH.ACCDAT_0 < DATEADD(DAY, 1, @Date) and VCRNUM_0 like 'PIN%'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.VCRNUM_0
		order by PD.VCRNUM_0

--get NetSettlement Credit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementCredit') IS NOT NULL DROP TABLE #TEMPNetSettlementCredit 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSCreditTotal
		INTO #TEMPNetSettlementCredit
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement Promotion Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementPromotion') IS NOT NULL DROP TABLE #TEMPNetSettlementPromotion 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSPromotionTotal
		INTO #TEMPNetSettlementPromotion
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 = 'PR'
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement EDLP Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementEDLP') IS NOT NULL DROP TABLE #TEMPNetSettlementEDLP 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSEDLPTotal
		INTO #TEMPNetSettlementEDLP
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 = 'EDLP'
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement Billback Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementBillback') IS NOT NULL DROP TABLE #TEMPNetSettlementBillback 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSBillbackTotal
		INTO #TEMPNetSettlementBillback
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 = 'BB'
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement Credit Memo Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementCreditMemo') IS NOT NULL DROP TABLE #TEMPNetSettlementCreditMemo 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSCreditMemoTotal
		INTO #TEMPNetSettlementCreditMemo
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 not in ('PR', 'EDLP', 'BB', 'RC', 'TC')
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement Return Credit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementReturnCredit') IS NOT NULL DROP TABLE #TEMPNetSettlementReturnCredit 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSReturnCreditTotal
		INTO #TEMPNetSettlementReturnCredit
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 = 'RC'
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement TermCredit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementTermCredit') IS NOT NULL DROP TABLE #TEMPNetSettlementTermCredit 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSTermCreditTotal
		INTO #TEMPNetSettlementTermCredit
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		and DSP_0 = 'TC'
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

--get NetSettlement Debit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementDebit') IS NOT NULL DROP TABLE #TEMPNetSettlementDebit 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS NSDebitTotal
		INTO #TEMPNetSettlementDebit
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.CREDATTIM_0 < DATEADD(DAY, 1, @Date) and PD.NUM_0 like 'NS%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'SPDIR'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPLASTPAYMENT') IS NOT NULL DROP TABLE #TEMPLASTPAYMENT 
		select * 
		into #TEMPLASTPAYMENT
		from
		(
		SELECT *, ROW_NUMBER() OVER(Partition by VCRNUM_0 ORDER BY ROWID DESC) AS Row_Number 
		from (select PH.NUM_0, PD.VCRNUM_0, PD.ROWID
		from PAYMENTD PD WITH(NOLOCK)
		left outer join PAYMENTH PH WITH(NOLOCK) ON PD.NUM_0 = PH.NUM_0
		WHERE PH.ACCDAT_0 < DATEADD(DAY, 1, @Date) and VCRNUM_0 like 'PIN%')a)
		t 
		where ROW_NUMBER = 1
		order by VCRNUM_0

IF OBJECT_ID('tempdb..#TEMPPAYMENTTEMP') IS NOT NULL DROP TABLE #TEMPPAYMENTTEMP 
		select NUMDEP_0, SUM(IIF(DENCOD_0 = 'SPMEN', AMTLIN_0 * -1, AMTLIN_0)) AS PaymentAmount
		into #TEMPPAYMENTTEMP
		from PAYMENTD 
		where NUMDEP_0 like 'PIN%' and NUM_0 not like 'NS%'
		group by NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPPAYMENT') IS NOT NULL DROP TABLE #TEMPPAYMENT 
		select A.VCRNUM_0 AS PINNumber, B.NUM_0 AS LastPaymentNumber, A.PVCRNUM_Total AS TotalPaymentAmount, PAYMENTH.CREDAT_0 AS LastPaymentDate, PAYMENTH.PAM_0 AS PaymentType, PAYMENTH.CHQNUM_0 AS LastCheckNumber, PAYMENTH.ACCDAT_0 AS LastCheckDate, PAYMENTH.AMTCUR_0 AS APLastCheckAmount, C.PaymentAmount
		into #TEMPPAYMENT
		from #TEMPPVCRNUM A
		left outer join #TEMPLASTPAYMENT B ON A.VCRNUM_0 = B.VCRNUM_0
		left outer join PAYMENTH ON B.NUM_0 = PAYMENTH.NUM_0
		left outer join #TEMPPAYMENTTEMP C ON A.VCRNUM_0 = C.NUMDEP_0 
		order by A.VCRNUM_0

--get Payment Term Credit Total
IF OBJECT_ID('tempdb..#TEMPPaymentTermCredit') IS NOT NULL DROP TABLE #TEMPPaymentTermCredit 
		select PD.NUMDEP_0, SUM(AMTLIN_0) AS PaymentTermCreditTotal
		INTO #TEMPPaymentTermCredit
		from PAYMENTD PD WITH(NOLOCK)
		WHERE PD.NUM_0 like 'PAY%' and PD.NUMDEP_0 like 'PIN%' and DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		order by PD.NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPNETSETTLEDAMOUNTBYINVOICE') IS NOT NULL DROP TABLE #TEMPNETSETTLEDAMOUNTBYINVOICE 
		select BPR_0 AS CustomerID, NUM_0 AS InvoiceNumber, SUM(AMTCURNET_0) AS Amount 
		into #TEMPNETSETTLEDAMOUNTBYINVOICE 
		from NETAUTO WITH(NOLOCK)
		where NUM_0 like 'PIN%'                      
		GROUP BY BPR_0, NUM_0

IF OBJECT_ID('tempdb..#TEMPAPAGAINDETAIL') IS NOT NULL DROP TABLE #TEMPAPAGAINDETAIL 
		select 
		A.CustomerID
		,A.InvoiceNumber
		,A.InvoiceDate
		,A.InvoiceAmount
		,IIF(B.PVCRNUM_Total is null, 0, B.PVCRNUM_Total) AS PaidAmount, IIF(C.Amount is null, 0, C.Amount) AS X3NetSettledAmount
		--,(A.InvoiceAmount - (IIF(B.PVCRNUM_Total is null, 0, B.PVCRNUM_Total) + IIF(C.Amount is null, 0, C.Amount))) AS AP
		,(A.InvoiceAmount - (IIF(B.PVCRNUM_Total is null, 0, B.PVCRNUM_Total) + IIF(C.Amount is null, 0, C.Amount))) - ISNULL(E.NSCreditTotal, 0) - ISNULL(G.PaymentTermCreditTotal, 0) + ISNULL(F.NSDebitTotal, 0) AS AP
		,BPRVCR_0
		,ORIDOCNUM_0
		,ISNULL(E.NSCreditTotal, 0) AS NSCreditTotal
		, ISNULL(F.NSDebitTotal, 0) AS NSDebitTotal
		,A.SupplierDocNumber
		INTO #TEMPAPAGAINDETAIL
		from #TEMPPINVOICE A
		left outer join #TEMPPVCRNUM B ON A.InvoiceNumber = B.VCRNUM_0
		left outer join #TEMPNETSETTLEDAMOUNTBYINVOICE C ON A.InvoiceNumber = C.InvoiceNumber
		left outer join #TEMPNetSettlementCredit E ON A.InvoiceNumber = E.NUMDEP_0
		left outer join #TEMPNetSettlementDebit F ON A.InvoiceNumber = F.NUMDEP_0
		left outer join #TEMPPaymentTermCredit G ON A.InvoiceNumber = G.NUMDEP_0
		--where A.InvoiceNumber like 'PIN0%'
		--where (A.InvoiceAmount - (IIF(B.PVCRNUM_Total is null, 0, B.PVCRNUM_Total) + IIF(C.Amount is null, 0, C.Amount))) > 0
		order by A.CustomerID, A.InvoiceNumber

IF OBJECT_ID('tempdb..#TEMPPOREC') IS NOT NULL DROP TABLE #TEMPPOREC
		select A.PTHNUM_0, A.POHNUM_0
		into #TEMPPOREC
		from PRECEIPTD A 
		where A.PTHNUM_0 not like 'REC0%'--CREDAT_0 >= '2018-12-14'
		group by A.PTHNUM_0, A.POHNUM_0
		order by A.PTHNUM_0

IF OBJECT_ID('tempdb..#TEMPALLOWANCE') IS NOT NULL DROP TABLE #TEMPALLOWANCE
		select NUMDEP_0 AS PINNumber, SUM(IIF(DENCOD_0 = 'SPDIR', -1 * AMTLIN_0, AMTLIN_0)) AS Allowance
		into #TEMPALLOWANCE
		from paymentd 
		where NUMDEP_0 like 'PIN%' and DENCOD_0 != 'SPINV' and NUM_0 not like 'NS%'
		GROUP BY NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPCREDIT') IS NOT NULL DROP TABLE #TEMPCREDIT
		select NUMDEP_0 AS PINNumber, SUM(AMTLIN_0) AS CREDIT
		into #TEMPCREDIT
		from paymentd 
		where NUMDEP_0 like 'PIN%' and DENCOD_0 = 'SPMEN' and NUM_0 not like 'NS%'
		GROUP BY NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPDEBIT') IS NOT NULL DROP TABLE #TEMPDEBIT
		select NUMDEP_0 AS PINNumber, SUM(AMTLIN_0) AS DEBIT
	    into #TEMPDEBIT
		from paymentd 
		where NUMDEP_0 like 'PIN%' and DENCOD_0 = 'SPDIR' and NUM_0 not like 'NS%'
		GROUP BY NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPCOMPLETE') IS NOT NULL DROP TABLE #TEMPCOMPLETE
		select ISNULL(PORDER.BPSNUM_0, PAYMENT.CustomerID) AS SupplierID
		,ISNULL(PORDER.CREDAT_0, NULL/*SCOSRV.CREDAT_0*/) AS PODate
		,ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) AS PONumber
		,ISNULL(#TEMP.TotalPOGrossAmount, 0) AS POGrossAmount
		,ISNULL(#TEMP.POEDLP, 0) + ISNULL(#TEMP.POEDLPP, 0) AS POEDLP
		,ISNULL(#TEMP.POTermPromo, 0) + ISNULL(#TEMP.POTermPromoP, 0) AS POTermPromo
		--,#TEMP.TotalPOAmount
		,ISNULL(POAmount.POAmount, NULL/*SCOSRV.DISCRGVAL3_0*/) AS POAmount
		,PORDER.PStatus AS POStatus
		,PRECEIPT.CREDAT_0 AS GoodsReceiptDate
		,ISNULL(ISNULL(POREC.PTHNUM_0, PAYMENT.ORIDOCNUM_0), '') AS GoodsReceiptNo
		--,PREC.GRPurchaseAllowance
		, IIF(POAmount.POAmount - PREC.GRAmount < 0 , 0, POAmount.POAmount - PREC.GRAmount) AS NotGR
		,#TEMP.TotalRECGrossAmount AS RECGrossAmount
		,#TEMP.RECEDLP + #TEMP.RECEDLPP AS RECEDLP
		,#TEMP.RECTermPromo + #TEMP.RECTermPromoP AS RECTermPromo
		--,#TEMP.TotalRECAmount
		,PREC.GRAmount
		, IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) AS GRStatus
		,PRECEIPT.CREDAT_0 AS APInvoiceDate--,PAYMENT.InvoiceDate AS APInvoiceDate --PINVOICE.STRDATSVC_0 AS APInvoiceDate               AP INVOICE DATE BOIIIIIIIIIIIIIIIIIIIII
		,PAYMENT.InvoiceNumber AS APInvoiceNumber
		,PAYMENT.InvoiceAmount AS APInvoiceAmount
		,PT.NUM_0 AS PaymentTerm--payment Term
		,IIF(PT.DCPercentage = 0, NULL, IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NOT NULL, DATEADD(Day, PT.DCDays, PINVOICE.STRDATSVC_0), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(Day, PT.DCDays, PAYMENT.InvoiceDate), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(Day, PT.DCDays, PRECEIPT.CREDAT_0), NULL)))) AS DiscountDueDate
		,IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NOT NULL, DATEADD(Day, PT.NetDaysToPay, PINVOICE.STRDATSVC_0), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(Day, PT.NetDaysToPay, PAYMENT.InvoiceDate), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(Day, PT.NetDaysToPay, PRECEIPT.CREDAT_0), NULL))) AS PaymentDueDate
		--,IIF(PT.DCPercentage = 0, NULL, DATEADD(Day, PT.DCDays, PRECEIPT.CREDAT_0)) AS DiscountDueDate--Discount Due Date: REMOVE THIS LINE AND THE ONE BELOW & uncomment THE TWO LINE ABOVE BEFORE UPDATE ON 5/16/2022 12:00:00 pm
		--,DATEADD(Day, PT.NetDaysToPay, PRECEIPT.CREDAT_0) AS PaymentDueDate--Payment Due Date
		,PINVOICE.PStatus AS APInvoiceStatus
		,LASTPAYMENT.LastPaymentDate
		,LASTPAYMENT.LastPaymentNumber
		,LASTPAYMENT.PaymentType
		,LASTPAYMENT.LastCheckNumber AS LastCheckNumber
		,CONVERT(DATE,LASTPAYMENT.LastCheckDate) AS LastCheckDate
		,LASTPAYMENT.APLastCheckAmount
		--,ISNULL(X3Credit.Amount, 0) AS X3Credit --IIF(LASTPAYMENT.PaymentAmount is null, X3Credit.Amount, ALLLOWANCE.Allowance) AS APPaymentAllowance
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSPromotion.NSPromotionTotal, 0), null) AS Promotion
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSEDLP.NSEDLPTotal, 0), null) AS EDLP
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSBillback.NSBillbackTotal, 0), null) AS Billback
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(X3Credit.Amount, 0) + ISNULL(NSCreditMemo.NSCreditMemoTotal, 0), null)  AS Credit
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSReturnCredit.NSReturnCreditTotal, 0), null) AS ReturnCredit
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSTermCredit.NSTermCreditTotal, 0), null) AS TermCredit
		,   IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSPromotion.NSPromotionTotal, 0), null)
		  + IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSEDLP.NSEDLPTotal, 0), null)
		  + IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSBillback.NSBillbackTotal, 0), null)
		  + IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(X3Credit.Amount, 0) + ISNULL(NSCreditMemo.NSCreditMemoTotal, 0), null)
			AS PurchaseAllowance
		,IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(DEBIT.DEBIT, 0) + ISNULL(NSD.NSDebitTotal, 0), null) AS Debit
		,  PAYMENT.InvoiceAmount 
			- (IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSPromotion.NSPromotionTotal, 0), null)
				+ IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSEDLP.NSEDLPTotal, 0), null)
				+ IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSBillback.NSBillbackTotal, 0), null)
				+ IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(X3Credit.Amount, 0) + ISNULL(NSCreditMemo.NSCreditMemoTotal, 0), null)) -- PurchaseAllowance 
		    - (IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSTermCredit.NSTermCreditTotal, 0), null)) --TermCredit
			- (IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(NSReturnCredit.NSReturnCreditTotal, 0), null)) --ReturnCredit
			+ (IIF(IIF(PRECEIPT.PStatus is null, PAYMENT.BPRVCR_0, PRECEIPT.PStatus ) = 'INVOICE', ISNULL(DEBIT.DEBIT, 0) + ISNULL(NSD.NSDebitTotal, 0), null)) --Debit
			AS NetAPAmount
		, ISNULL(LASTPAYMENT.PaymentAmount, LASTPAYMENT.TotalPaymentAmount) AS PaymentAmount
		,PAYMENT.AP AS POOpenBalance
		, IIF(PAYMENT.AP <= 0, 'Close', 'Open') AS POOpenStatus
		, PORDER.POHNUM_0 AS TEST1
		, POREC2.POHNUM_0 AS TEST2
		, ISNULL(PAYMENT.SupplierDocNumber, '') AS SupplierDocNumber
		, PINVOICE.STRDATSVC_0 AS SupplierDocDate
		into #TEMPCOMPLETE
		from PORDER
		left outer join #TEMPOrder POAmount ON PORDER.POHNUM_0 = POAmount.PONumber
		left outer join #TEMPPOREC POREC ON PORDER.POHNUM_0 = POREC.POHNUM_0
		left outer join PRECEIPT ON POREC.PTHNUM_0 = PRECEIPT.PTHNUM_0
		left outer join #TEMPREC PREC ON PRECEIPT.PTHNUM_0 = PREC.PTHNUM_0
		left outer join PINVOICE ON PREC.PTHNUM_0 = PINVOICE.ORIDOCNUM_0
		full outer join #TEMPAPAGAINDETAIL PAYMENT ON PINVOICE.NUM_0 = PAYMENT.InvoiceNumber
		left outer join #TEMPPAYMENT LASTPAYMENT ON PAYMENT.InvoiceNumber = LASTPAYMENT.PINNumber
		left outer join #TEMPPOREC POREC2 ON PAYMENT.ORIDOCNUM_0 = POREC2.PTHNUM_0
		--left outer join SCOSRV ON POREC2.POHNUM_0 = SCOSRV.SCONUM_0
		left outer join #TEMPALLOWANCE ALLLOWANCE ON PAYMENT.InvoiceNumber = ALLLOWANCE.PINNumber
		left outer join #TEMPCREDIT CREDIT ON PAYMENT.InvoiceNumber = CREDIT.PINNumber
		left outer join #TEMPDEBIT DEBIT ON PAYMENT.InvoiceNumber = DEBIT.PINNumber
		left outer join #TEMPNETSETTLEDAMOUNTBYINVOICE X3Credit ON PAYMENT.InvoiceNumber = X3Credit.InvoiceNumber
		--left outer join #TEMPNetSettlementCredit NSC ON PINVOICE.NUM_0 = NSC.NUMDEP_0
		left outer join #TEMPNetSettlementPromotion NSPromotion ON PINVOICE.NUM_0 = NSPromotion.NUMDEP_0
		left outer join #TEMPNetSettlementEDLP NSEDLP ON PINVOICE.NUM_0 = NSEDLP.NUMDEP_0
		left outer join #TEMPNetSettlementBillback NSBillback ON PINVOICE.NUM_0 = NSBillback.NUMDEP_0
		left outer join #TEMPNetSettlementCreditMemo NSCreditMemo ON PINVOICE.NUM_0 = NSCreditMemo.NUMDEP_0
		left outer join #TEMPNetSettlementReturnCredit NSReturnCredit ON PINVOICE.NUM_0 = NSReturnCredit.NUMDEP_0
		left outer join #TEMPNetSettlementTermCredit NSTermCredit ON PINVOICE.NUM_0 = NSTermCredit.NUMDEP_0
		left outer join #TEMPNetSettlementDebit NSD ON PINVOICE.NUM_0 = NSD.NUMDEP_0
		left outer join #TEMP ON PORDER.POHNUM_0 = #TEMP.POHNUM_0
		left outer join PaymentTermHeader PT ON PORDER.PTE_0 = PT.NUM_0
		where ((PORDER.PStatus != 'Deleted' OR PORDER.PStatus is null) and (ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) is null OR ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) not like 'BCSSC%'))-- and PAYMENT.InvoiceNumber in( 'PIN193833', 'PIN193708')
		and not (ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) like 'PO0%' AND ISNULL(POREC.PTHNUM_0, PAYMENT.ORIDOCNUM_0) is null)
		and ((PORDER.CREDAT_0 >= @FDATE and PORDER.CREDAT_0 < DATEADD(DAY, 1, @Date)) OR PORDER.CREDAT_0 is null)
		and CASE WHEN  @POFromX3 != 'Checked' 
		    THEN PORDER.POHNUM_0
			ELSE IIF(PAYMENT.AP <= 0, 'Close', 'Open')
			END is not null
		--and PORDER.CREDAT_0 < DATEADD(DAY, 1, @Date)
		--and PAYMENT.InvoiceNumber = 'PIN005978'
		--and PINVOICE.PStatus  = 'PAYMENT' and LASTPAYMENT.LastPaymentDate is null
		and (PORDER.CPY_0 != 'IFN' OR PORDER.POHNUM_0 is NULL)
		--and PRECEIPT.CREDAT_0 <= PINVOICE.STRDATSVC_0
		--or PAYMENT.AP > 0
		order by PAYMENT.InvoiceNumber, PORDER.POHNUM_0

		



	IF(@SupplierID = '' AND @CheckNumber = '')
		BEGIN
			SELECT *
			FROM #TEMPCOMPLETE
			WHERE 
			POOpenStatus LIKE '%'+@POOpenStatus+'%'
			and PONumber LIKE '%'+@PONumber+'%'
			and GoodsReceiptNo LIKE '%'+@GRNumber+'%'
			and SupplierDocNumber LIKE '%'+@SupplierDocNumber+'%'
			order by PODate, APInvoiceDate, APInvoiceNumber
		END
	ELSE IF(@SupplierID = '' AND @CheckNumber != '')
		BEGIN
			SELECT *
			FROM #TEMPCOMPLETE
			WHERE 
			LastCheckNumber = @CheckNumber
			AND POOpenStatus LIKE '%'+@POOpenStatus+'%'
			and PONumber LIKE '%'+@PONumber+'%'
			and GoodsReceiptNo LIKE '%'+@GRNumber+'%'
			and SupplierDocNumber LIKE '%'+@SupplierDocNumber+'%'
			order by PODate, APInvoiceDate, APInvoiceNumber
		END
	ELSE IF(@SupplierID != '' AND @CheckNumber = '')
		BEGIN
			SELECT *
			FROM #TEMPCOMPLETE
			WHERE 
			SupplierID LIKE '%'+@SupplierID+'%'
			AND POOpenStatus LIKE '%'+@POOpenStatus+'%'
			and PONumber LIKE '%'+@PONumber+'%'
			and GoodsReceiptNo LIKE '%'+@GRNumber+'%'
			and SupplierDocNumber LIKE '%'+@SupplierDocNumber+'%'
			order by PODate, APInvoiceDate, APInvoiceNumber
		END
	ELSE IF(@SupplierID != '' AND @CheckNumber != '')
		BEGIN
			SELECT *
			FROM #TEMPCOMPLETE
			WHERE 
			SupplierID LIKE '%'+@SupplierID+'%'
			AND LastCheckNumber = @CheckNumber
			AND POOpenStatus LIKE '%'+@POOpenStatus+'%'
			and PONumber LIKE '%'+@PONumber+'%'
			and GoodsReceiptNo LIKE '%'+@GRNumber+'%'
			and SupplierDocNumber LIKE '%'+@SupplierDocNumber+'%'
			order by PODate, APInvoiceDate, APInvoiceNumber
		END

END



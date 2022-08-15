USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_OpenAP_1]    Script Date: 8/15/2022 9:47:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_OpenAP_1] 

WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;

	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

IF OBJECT_ID('tempdb..#POTEMP') IS NOT NULL DROP TABLE #POTEMP
		SELECT 
			POHNUM_0, 
			SUM(GROPRI_0 * QTY_0) AS TotalPOGrossAmount, 
			SUM(QTY_0 * EDLP) AS POEDLP,
			SUM(QTY_0 * ROUND(GROPRI_0 * (EDLPP / 100), 2)) AS POEDLPP,
			SUM(QTY_0 * TermPromo) AS POTermPromo,
			SUM(QTY_0 * ROUND(GROPRI_0 * (TermPromoP / 100), 2)) AS POTermPromoP,
			SUM((GROPRI_0 - NETPRI_0) * QTY_0) AS TotalPOPromotionAmount,
			SUM(NETPRI_0 * QTY_0) AS TotalPOAmount
		INTO #POTEMP
		FROM porderd 
		GROUP BY POHNUM_0 
		ORDER BY POHNUM_0 DESC


IF OBJECT_ID('tempdb..#RECTEMP') IS NOT NULL DROP TABLE #RECTEMP
		SELECT 
			POHNUM_0,
			PTHNUM_0,
			SUM(GROPRI_0 * QTYUOM_0) AS TotalRECGrossAmount, 
			SUM(QTYUOM_0 * EDLP) AS RECEDLP,
			SUM(QTYUOM_0 * ROUND(GROPRI_0 * (EDLPP / 100), 2)) AS RECEDLPP,
			SUM(QTYUOM_0 * TermPromo) AS RECTermPromo,
			SUM(QTYUOM_0 * ROUND(GROPRI_0 * (TermPromoP / 100), 2)) AS RECTermPromoP,
			SUM((GROPRI_0 - NETPRI_0) * QTYUOM_0) AS TotalRECPromotionAmount,
			SUM(NETPRI_0 * QTYUOM_0) AS TotalRECAmount
		INTO #RECTEMP
		FROM PRECEIPTD 
		WHERE RCPDAT_0 >= '1-1-2022'
		GROUP BY POHNUM_0, PTHNUM_0
		ORDER BY POHNUM_0 DESC

IF OBJECT_ID('tempdb..#TEMP') IS NOT NULL DROP TABLE #TEMP
		SELECT 
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
		INTO #TEMP
		FROM #POTEMP A 
		LEFT OUTER JOIN #RECTEMP B ON B.POHNUM_0 = A.POHNUM_0

IF OBJECT_ID('tempdb..#TEMPOrder') IS NOT NULL DROP TABLE #TEMPOrder
		SELECT A.POHNUM_0 AS PONumber, SUM(A.NETPRI_0 * A.QTY_0) AS POAmount
		INTO #TEMPOrder
		FROM PORDERD A
		GROUP BY A.POHNUM_0
		ORDER BY A.POHNUM_0

IF OBJECT_ID('tempdb..#TEMPREC') IS NOT NULL DROP TABLE #TEMPREC
		SELECT A.PTHNUM_0, SUM((A.GROPRI_0 - A.NETPRI_0) * QTYUOM_0) AS GRPurchaseAllowance, SUM(A.NETPRI_0 * QTYUOM_0) AS GRAmount
		INTO #TEMPREC
		FROM PRECEIPTD A 
		GROUP BY A.PTHNUM_0
		ORDER BY A.PTHNUM_0

IF OBJECT_ID('tempdb..#TEMPPINVOICE') IS NOT NULL DROP TABLE #TEMPPINVOICE 
		SELECT 
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
		FROM PINVOICE WITH(NOLOCK)
		WHERE PINVOICE.CPY_0 = 'BIC' AND PINVOICE.NUM_0 LIKE 'PIN%'
		AND NUM_0 NOT IN (
		'PIN002177', 'PIN002170', 'PIN002171', 'PIN002467',	'PIN001387', 'PIN001663', 'PIN001671', 'PIN002120',	'PIN002216', 'PIN003636', 'PIN004171', 'PIN004625',	
		'PIN002172', 'PIN004535', 'PIN003064', 'PIN004371',	'PIN004789', 'PIN004903', 'PIN004904', 'PIN005783',	'PIN006168', 'PIN192498', 'PIN002319', 'PIN002707',	
		'PIN002318', 'PIN002176', 'PIN002226', 'PIN002174',	'PIN002312', 'PIN002468', 'PIN005309', 'PIN192355', 'PIN003667', 'PIN003481', 'PIN000092', 
		'PIN000211', 'PIN192574', 'PIN000394', 'PIN002410', 'PIN000642', 'PIN000070', 'PIN000966', 'PIN005699', 'PIN006102', 'PIN192461', 'PIN192464', 'PIN000068',
		'PIN005678', 'PIN000047', 'PIN004550', 'PIN006166', 'PIN002471', 'PIN002469', 'PIN002470', 'PIN004782', 'PIN192651', 'PIN006131', 'PIN006144', 'PIN006115',
		'PIN000091'
		)
		ORDER BY PINVOICE.NUM_0

--get VCRNUM Total
IF OBJECT_ID('tempdb..#TEMPPVCRNUM') IS NOT NULL DROP TABLE #TEMPPVCRNUM 
		SELECT PD.VCRNUM_0, SUM(PD.AMTLIN_0) AS PVCRNUM_Total
		INTO #TEMPPVCRNUM
		FROM PAYMENTD PD WITH(NOLOCK)
		LEFT OUTER JOIN PAYMENTH PH WITH(NOLOCK) ON PD.NUM_0 = PH.NUM_0
		WHERE VCRNUM_0 LIKE 'PIN%'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.VCRNUM_0
		ORDER BY PD.VCRNUM_0

--get NetSettlement Credit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementCredit') IS NOT NULL DROP TABLE #TEMPNetSettlementCredit 
		SELECT PD.NUMDEP_0, SUM(AMTLIN_0) AS NSCreditTotal
		INTO #TEMPNetSettlementCredit
		FROM PAYMENTD PD WITH(NOLOCK)
		WHERE PD.NUM_0 LIKE 'NS%' AND PD.NUMDEP_0 LIKE 'PIN%' AND DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		ORDER BY PD.NUMDEP_0

--get NetSettlement Debit Total
IF OBJECT_ID('tempdb..#TEMPNetSettlementDebit') IS NOT NULL DROP TABLE #TEMPNetSettlementDebit 
		SELECT PD.NUMDEP_0, SUM(AMTLIN_0) AS NSDebitTotal
		INTO #TEMPNetSettlementDebit
		FROM PAYMENTD PD WITH(NOLOCK)
		WHERE PD.NUM_0 LIKE 'NS%' AND PD.NUMDEP_0 LIKE 'PIN%' AND DENCOD_0 = 'SPDIR'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		ORDER BY PD.NUMDEP_0

--get Payment Term Credit Total
IF OBJECT_ID('tempdb..#TEMPPaymentTermCredit') IS NOT NULL DROP TABLE #TEMPPaymentTermCredit 
		SELECT PD.NUMDEP_0, SUM(AMTLIN_0) AS PaymentTermCreditTotal
		INTO #TEMPPaymentTermCredit
		FROM PAYMENTD PD WITH(NOLOCK)
		WHERE PD.NUM_0 LIKE 'PAY%' AND PD.NUMDEP_0 LIKE 'PIN%' AND DENCOD_0 = 'CSMEM'-- and PH.FRMNUM_0 != ''
		GROUP BY PD.NUMDEP_0
		ORDER BY PD.NUMDEP_0

IF OBJECT_ID('tempdb..#TEMPNETSETTLEDAMOUNTBYINVOICE') IS NOT NULL DROP TABLE #TEMPNETSETTLEDAMOUNTBYINVOICE 
		SELECT BPR_0 AS CustomerID, NUM_0 AS InvoiceNumber, SUM(AMTCURNET_0) AS Amount 
		INTO #TEMPNETSETTLEDAMOUNTBYINVOICE 
		FROM NETAUTO WITH(NOLOCK)
		WHERE NUM_0 LIKE 'PIN%'                      
		GROUP BY BPR_0, NUM_0

IF OBJECT_ID('tempdb..#TEMPAPAGAINDETAIL') IS NOT NULL DROP TABLE #TEMPAPAGAINDETAIL 
		SELECT 
		A.CustomerID
		,A.InvoiceNumber
		,A.InvoiceDate
		,A.InvoiceAmount
		,IIF(B.PVCRNUM_Total IS NULL, 0, B.PVCRNUM_Total) AS PaidAmount, IIF(C.Amount IS NULL, 0, C.Amount) AS X3NetSettledAmount
		,(A.InvoiceAmount - (IIF(B.PVCRNUM_Total IS NULL, 0, B.PVCRNUM_Total) + IIF(C.Amount IS NULL, 0, C.Amount))) - ISNULL(E.NSCreditTotal, 0) - ISNULL(G.PaymentTermCreditTotal, 0) + ISNULL(F.NSDebitTotal, 0) AS AP
		,BPRVCR_0
		,ORIDOCNUM_0
		,ISNULL(E.NSCreditTotal, 0) AS NSCreditTotal
		,ISNULL(F.NSDebitTotal, 0) AS NSDebitTotal
		,A.SupplierDocNumber
		INTO #TEMPAPAGAINDETAIL
		FROM #TEMPPINVOICE A
		LEFT OUTER JOIN #TEMPPVCRNUM B ON A.InvoiceNumber = B.VCRNUM_0
		LEFT OUTER JOIN #TEMPNETSETTLEDAMOUNTBYINVOICE C ON A.InvoiceNumber = C.InvoiceNumber
		LEFT OUTER JOIN #TEMPNetSettlementCredit E ON A.InvoiceNumber = E.NUMDEP_0
		LEFT OUTER JOIN #TEMPNetSettlementDebit F ON A.InvoiceNumber = F.NUMDEP_0
		LEFT OUTER JOIN #TEMPPaymentTermCredit G ON A.InvoiceNumber = G.NUMDEP_0
		ORDER BY A.CustomerID, A.InvoiceNumber

IF OBJECT_ID('tempdb..#TEMPPOREC') IS NOT NULL DROP TABLE #TEMPPOREC
		SELECT A.PTHNUM_0, A.POHNUM_0
		INTO #TEMPPOREC
		FROM PRECEIPTD A 
		WHERE A.PTHNUM_0 NOT LIKE 'REC0%'
		GROUP BY A.PTHNUM_0, A.POHNUM_0
		ORDER BY A.PTHNUM_0

IF OBJECT_ID('tempdb..#TEMPCOMPLETE') IS NOT NULL DROP TABLE #TEMPCOMPLETE
		SELECT 
			ISNULL(PORDER.BPSNUM_0, PAYMENT.CustomerID) AS SupplierID
			,PORDER.POHNUM_0 AS PONumber
			,PRECEIPT.CREDAT_0 AS GoodsReceiptDate
			,ISNULL(POREC.PTHNUM_0, PAYMENT.ORIDOCNUM_0) AS GoodsReceiptNo
			,FORMAT(#TEMP.TotalRECGrossAmount, 'N2') AS RECGrossAmount
			,FORMAT(#TEMP.RECEDLP + #TEMP.RECEDLPP, 'N2') AS RECEDLP
			,FORMAT(#TEMP.RECTermPromo + #TEMP.RECTermPromoP, 'N2') AS RECTermPromo
			,FORMAT(PREC.GRAmount, 'N2') AS GRNetAmount
			,IIF(PRECEIPT.PStatus IS NULL, PAYMENT.BPRVCR_0, PRECEIPT.PStatus) AS GRStatus
			,PRECEIPT.CREDAT_0 AS APInvoiceDate
			,PAYMENT.InvoiceNumber AS APInvoiceNumber
			,PINVOICE.STRDATSVC_0 AS SupplierDocDate
			,PAYMENT.SupplierDocNumber
			,FORMAT(PAYMENT.InvoiceAmount, 'N2') AS APInvoiceAmount
			,PT.NUM_0 AS PaymentTerm
			,IIF(PT.DCPercentage = 0, NULL, IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NOT NULL, DATEADD(DAY, PT.DCDays, PINVOICE.STRDATSVC_0), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(DAY, PT.DCDays, PAYMENT.InvoiceDate), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(DAY, PT.DCDays, PRECEIPT.CREDAT_0), NULL)))) AS DiscountDueDate
			,IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NOT NULL, DATEADD(DAY, PT.NetDaysToPay, PINVOICE.STRDATSVC_0), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NOT NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(DAY, PT.NetDaysToPay, PAYMENT.InvoiceDate), IIF(PRECEIPT.CREDAT_0 IS NOT NULL AND PAYMENT.InvoiceDate IS NULL AND PINVOICE.STRDATSVC_0 IS NULL, DATEADD(DAY, PT.NetDaysToPay, PRECEIPT.CREDAT_0), NULL))) AS PaymentDueDate
			,IIF(PAYMENT.AP <= 0, 'Close', 'Open') AS POOpenStatus
			,FORMAT(PAYMENT.AP, 'N2') AS Balance
		INTO #TEMPCOMPLETE
		FROM PORDER
		LEFT OUTER JOIN #TEMPOrder POAmount ON PORDER.POHNUM_0 = POAmount.PONumber
		LEFT OUTER JOIN #TEMPPOREC POREC ON PORDER.POHNUM_0 = POREC.POHNUM_0
		LEFT OUTER JOIN PRECEIPT ON POREC.PTHNUM_0 = PRECEIPT.PTHNUM_0
		LEFT OUTER JOIN #TEMPREC PREC ON PRECEIPT.PTHNUM_0 = PREC.PTHNUM_0
		LEFT OUTER JOIN PINVOICE ON PREC.PTHNUM_0 = PINVOICE.ORIDOCNUM_0
		FULL OUTER JOIN #TEMPAPAGAINDETAIL PAYMENT ON PINVOICE.NUM_0 = PAYMENT.InvoiceNumber
		LEFT OUTER JOIN #TEMPPOREC POREC2 ON PAYMENT.ORIDOCNUM_0 = POREC2.PTHNUM_0
		LEFT OUTER JOIN #TEMP ON PORDER.POHNUM_0 = #TEMP.POHNUM_0
		LEFT OUTER JOIN PaymentTermHeader PT ON PORDER.PTE_0 = PT.NUM_0
		WHERE PRECEIPT.CREDAT_0 IS NOT NULL AND ((PORDER.PStatus != 'Deleted' OR PORDER.PStatus IS NULL) AND (ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) IS NULL OR ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) NOT LIKE 'BCSSC%'))
		AND NOT (ISNULL(PORDER.POHNUM_0, POREC2.POHNUM_0) LIKE 'PO0%' AND ISNULL(POREC.PTHNUM_0, PAYMENT.ORIDOCNUM_0) IS NULL)
		AND ((PRECEIPT.CREDAT_0 >= '6-1-2022' ))
		AND (PORDER.CPY_0 != 'IFN' OR PORDER.POHNUM_0 IS NULL)
		ORDER BY PAYMENT.InvoiceNumber, PORDER.POHNUM_0

		SELECT * FROM #TEMPCOMPLETE WHERE POOpenStatus = 'Open'
		ORDER BY SupplierID, APInvoiceDate, APInvoiceNumber
END



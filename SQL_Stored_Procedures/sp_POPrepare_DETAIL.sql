USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_POPrepare_DETAIL]    Script Date: 8/19/2022 3:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_POPrepare_DETAIL] 
											@POPNumber varchar(50)
WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
	A.ItemID, 
	RTRIM(LTRIM(B.ITMREFBPS_0)) AS VendorCode, 
	cast(A.OrderQty as decimal(10,2)) AS OrderQty,
	P.StockConversionQty AS CsInner,
	(A.OrderQty * P.StockConversionQty) AS StockQty,
	'' AS ReceivedQty,
	P.ProductDesc, 
	P.StrPackSize, 
	cast(P.BasePrice as decimal(10,2)) AS UnitPr,
	CONVERT(DECIMAL(18,2), 0) AS EDLP, 
	CONVERT(DECIMAL(18,2), 0) AS EDLPP, 
	CONVERT(DECIMAL(18,2), 0) AS TermPromo, 
	CONVERT(DECIMAL(18,2), 0) AS TermPromoP, 
	cast(P.BasePrice as decimal(10,2)) AS NetPrice, 
	cast(P.BasePrice * A.OrderQty as decimal(10,2)) AS OrderAmount,
	P.PurchaseUnit AS SUnitM, 
	DATEADD(DAY, Brand.LeadTime, GETDATE()) AS ExpectedRcptDate,
	'' AS ReceivingSite, 
	F.Supplier AS BilledBySupplier,
	0 AS PODetailKey

	FROM POPrepareDetail A WITH(NOLOCK)
	LEFT OUTER JOIN POPrepare F WITH(NOLOCK) ON A.POPrepareNumber = F.POPrepareNumber
	LEFT OUTER JOIN ITMBPS B WITH(NOLOCK) ON A.ItemID = B.ITMREF_0 and F.Supplier = B.BPSNUM_0
	left outer join Product P WITH(NOLOCK) ON A.ItemID = P.ProductID and P.IsInActive = 0
	LEFT OUTER JOIN Brand WITH(NOLOCK) ON Brand.BrandCode = P.Brand
	
	WHERE A.POPrepareNumber = @POPNumber --and G.ProductKey > '10000'

	order by ProductID

END

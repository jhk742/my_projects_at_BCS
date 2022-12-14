USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_UPDATE_PRECEIPTD_POCALC]    Script Date: 8/19/2022 3:44:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_UPDATE_PRECEIPTD_POCALC] 
@SupplierInvoiceQty DECIMAL(10, 2),
--@BCSGrossPrice decimal(10,2),
@SupplierGrossPrice decimal(10,2),
--@BCSEDLP decimal(10,2),
@SupplierEDLP decimal(10,2),
--@BCSEDLPP decimal(10,2),
@SupplierEDLPP decimal(10,2),
--@BCSTermPromo decimal(10,2),
@SupplierTermPromo decimal(10,2),
--@BCSTermPromoP decimal(10,2),
@SupplierTermPromoP decimal(10,2),
@poplin_0 decimal(10,2),
@PONumber varchar(20)
AS
BEGIN
	UPDATE PORDERD
	SET
	--DISCRGVAL1_0 = @SupplierInvoiceQty,
	--DISCRGVAL2_0 = @BCSGrossPrice,
	--DISCRGVAL3_0 = @SupplierGrossPrice,
	--DISCRGVAL4_0 = @BCSEDLP,
	--DISCRGVAL5_0 = @SupplierEDLP,
	--DISCRGVAL6_0 = @BCSEDLPP,
	--DISCRGVAL7_0 = @SupplierEDLPP,
	--DISCRGVAL8_0 = @BCSTermPromo,
	--DISCRGVAL9_0 = @SupplierTermPromo,
	--DISCRGREN1_0 = @BCSTermPromoP,
	--DISCRGREN2_0 = @SupplierTermPromoP


	DISCRGVAL6_0 = @SupplierInvoiceQty,
	DISCRGVAL7_0 = @SupplierGrossPrice,
	DISCRGVAL8_0 = @SupplierEDLP,
	DISCRGVAL9_0 = @SupplierEDLPP,
	DISCRGREN1_0 = @SupplierTermPromo,
	DISCRGREN2_0 = @SupplierTermPromoP
	WHERE POPLIN_0 = @POPLIN_0 and POHNUM_0 = @PONumber
END

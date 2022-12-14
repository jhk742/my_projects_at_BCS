USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_PO_UPDATE]    Script Date: 8/19/2022 3:42:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_PO_UPDATE] 
									@PONumber varchar(50),
									@Memo varchar(300),
									@WHMemo varchar(300),
									@OrderSite varchar(5),
									@CreateUser varchar(50),
									@Supplier varchar(50),
									@ShipVia varchar(100)
	
AS
BEGIN

	DECLARE @SupplierName varchar(100), @PaymentTerm varchar(50)

	SELECT @SupplierName = BPSNAM_0, @PaymentTerm = PTE_0
	FROM BPSUPPLIER
	WHERE BPSNUM_0 = @Supplier

	--Select @SupplierName = BPSNAM_0 
	--from BPSUPPLIER 
	--where BPSNUM_0 = @Supplier

	if(@OrderSite in('BCS', 'WH2') )
		BEGIN
			UPDATE PORDER
			SET PMemo = @Memo, 
			WHMemo = @WHMemo,
			CPY_0 = 'BIC',
			POHFCY_0 = @OrderSite,
			UPDDAT_0 = CONVERT(date, getdate()),
			UPDDATTIM_0 = GETDATE(),
			UPDUSR_0 = @CreateUser,
			BPSNUM_0 = @Supplier,
			BPRNAM_0 = @SupplierName,
			BPONAM_0 = @Supplier,
			BPRPAY_0 = @Supplier,
			BPSINV_0 = @Supplier,
			PTE_0 = @PaymentTerm,
			BPTNUM_0 = @ShipVia

			WHERE POHNUM_0 = @PONumber
		END
	else if(@OrderSite = 'IFN')
		BEGIN
			UPDATE PORDER
			SET PMemo = @Memo, 
			WHMemo = @WHMemo,
			CPY_0 = @OrderSite,
			POHFCY_0 = @OrderSite,
			UPDDAT_0 = CONVERT(date, getdate()),
			UPDDATTIM_0 = GETDATE(),
			UPDUSR_0 = @CreateUser,
			BPSNUM_0 = @Supplier,
			BPRNAM_0 = @SupplierName,
			BPONAM_0 = @Supplier,
			BPRPAY_0 = @Supplier,
			BPSINV_0 = @Supplier,
			PTE_0 = @PaymentTerm,
			BPTNUM_0 = @ShipVia

			WHERE POHNUM_0 = @PONumber
		END
END

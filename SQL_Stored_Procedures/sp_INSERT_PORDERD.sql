USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_INSERT_PORDERD]    Script Date: 8/19/2022 3:41:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INSERT_PORDERD] 
                                          @ReceivingSite varchar(3),
										  @ProductBCS varchar(50),
										  @ProductSupplier varchar(50),
									      @OrderQty decimal(18,2),
										  @STKQty decimal(18,2),
										  @Description varchar(200),
										  @PackSize varchar(50),
										  @GrossPrice decimal(18,2),
										  @EDLP decimal(18,2),
										  @EDLPP decimal(18,2),	
										  @TermPromo decimal(18,2),	
										  @TermPromoP decimal(18,2),	
										  @NetPrice decimal(18,2),	
										  @OrderAmount decimal(18,2),	
										  @Unit varchar(50),
										  @ExpectedRcptDate datetime,
										  @BilledBySupplier varchar(50),
										  @Line int,
										  @SupplierID varchar(50),
										  @Memo varchar(200),
										  @Location varchar(50),
										  @CreateUser varchar(50),
										  @NewPONumber varchar(50)
	
AS
BEGIN
	DECLARE
	@ProductGroup varchar(2),
	@Company varchar(5)
	
	SELECT @ProductGroup = CdPackDeptTypeCode
	FROM Product
	WHERE ProductID = @ProductBCS

	if(@ReceivingSite = 'IFN')
		SET @Company = 'IFN'
	ELSE IF (@ReceivingSite in ('BCS', 'WH2'))
		SET @Company = 'BIC'
	
	INSERT INTO PORDERD(
	   [UPDTICK_0]
      ,[POHNUM_0]
      ,[POPLIN_0]
      ,[POPSEQ_0]
      ,[POPDAT_0]
      ,[STRDAT_0]
      ,[CPY_0]
      ,[POHTYP_0]
      ,[LINREVNUM_0]
      ,[ITMREF_0]
      ,[ITMDES1_0]
      ,[ITMDES_0]
      ,[GROPRI_0]
      ,[PRIREN_0]
      ,[DISCRGVAL1_0]
      ,[DISCRGVAL2_0]
      ,[DISCRGVAL3_0]
      ,[DISCRGVAL4_0]
      ,[DISCRGVAL5_0]
      ,[DISCRGVAL6_0]
      ,[DISCRGVAL7_0]
      ,[DISCRGVAL8_0]
      ,[DISCRGVAL9_0]
      ,[DISCRGREN1_0]
      ,[DISCRGREN2_0]
      ,[DISCRGREN3_0]
      ,[DISCRGREN4_0]
      ,[DISCRGREN5_0]
      ,[DISCRGREN6_0]
      ,[DISCRGREN7_0]
      ,[DISCRGREN8_0]
      ,[DISCRGREN9_0]
      ,[NETPRI_0]
      ,[LINBUY_0]
      ,[PRHFCY_0]
      ,[FCYADD_0]
      ,[PJT_0]
      ,[EECINCRAT_0]
      ,[ORICRY_0]
      ,[TSICOD_0]
      ,[TSICOD_1]
      ,[TSICOD_2]
      ,[TSICOD_3]
      ,[TSICOD_4]
      ,[QUAFLG_0]
      ,[VAT_0]
      ,[VAT_1]
      ,[VAT_2]
      ,[TAXRCP_0]
      ,[TAXISS_0]
      ,[TAXOTH1_0]
      ,[TAXOTH2_0]
      ,[POPCREFLG_0]
      ,[EXPNUM_0]
      ,[CREUSR_0]
      ,[CREDAT_0]
      ,[UPDUSR_0]
      ,[UPDDAT_0]
      ,[MATTOL_0]
      ,[CREDATTIM_0]
      ,[UPDDATTIM_0]
	  ,[QTY_0]
      ,[WIPNUM_0]
      ,[PTHNUM_0]
      ,[EDLP]
      ,[EDLPP]
      ,[TermPromo]
      ,[TermPromoP]
      ,[Unit]
      ,[ExpectedRcptDate]
      ,[BilledBySupplier]
	  ,[PackSize]
      ,[ProductSupplier]
	  ,[OrderAmount]
	  ,[ReceivingSite]
	  ,[InnerCase]
	  )
	  VALUES(
	  1--[UPDTICK_0]
      ,@NewPONumber--[POHNUM_0]
      ,@Line--[POPLIN_0]
      ,1--[POPSEQ_0]
      ,'1753-01-01 00:00:00.000'--[POPDAT_0]
      ,'1753-01-01 00:00:00.000'--[STRDAT_0]
      ,@Company--[CPY_0]
      ,1--[POHTYP_0]
      ,0--[LINREVNUM_0]
      ,@ProductBCS--[ITMREF_0]
      ,@Description--[ITMDES1_0]
      ,@Description--[ITMDES_0]
      ,@GrossPrice--[GROPRI_0]
      ,2--[PRIREN_0]
      ,0--[DISCRGVAL1_0]
      ,0--[DISCRGVAL2_0]
      ,0--[DISCRGVAL3_0]
      ,0--[DISCRGVAL4_0]
      ,0--[DISCRGVAL5_0]
      ,0--[DISCRGVAL6_0]
      ,0--[DISCRGVAL7_0]
      ,0--[DISCRGVAL8_0]
      ,0--[DISCRGVAL9_0]
      ,0--[DISCRGREN1_0]
      ,0--[DISCRGREN2_0]
      ,0--[DISCRGREN3_0]
      ,0--[DISCRGREN4_0]
      ,0--[DISCRGREN5_0]
      ,0--[DISCRGREN6_0]
      ,0--[DISCRGREN7_0]
      ,0--[DISCRGREN8_0]
      ,0--[DISCRGREN9_0]
      ,@NetPrice--[NETPRI_0]
      ,''--[LINBUY_0]
      ,@ReceivingSite--@Location--[PRHFCY_0]
      ,'MAIN'--[FCYADD_0]
      ,''--[PJT_0]
      ,0--[EECINCRAT_0]
      ,''--[ORICRY_0]
      ,''--,[TSICOD_0]
      ,''--[TSICOD_1]
      ,@ProductGroup--[TSICOD_2]
      ,''--[TSICOD_3]
      ,''--[TSICOD_4]
      ,1--[QUAFLG_0]
      ,'NT'--[VAT_0]
      ,''--[VAT_1]
      ,''--[VAT_2]
      ,''--[TAXRCP_0]
      ,''--[TAXISS_0]
      ,''--[TAXOTH1_0]
      ,''--[TAXOTH2_0]
      ,0--[POPCREFLG_0]
      ,1--[EXPNUM_0]
      ,@CreateUser--[CREUSR_0]
      ,CONVERT(date, getdate())--[CREDAT_0]
      ,@CreateUser--[UPDUSR_0]
      ,CONVERT(date, getdate())--[UPDDAT_0]
      ,''--[MATTOL_0]
      ,GETDATE()--[CREDATTIM_0]
      ,GETDATE()--[UPDDATTIM_0]
	  ,@OrderQty--[QTY_0]
      ,''--[WIPNUM_0]
      ,''--[PTHNUM_0]
      ,@EDLP--[EDLP]
      ,@EDLPP--[EDLPP]
      ,@TermPromo--[TermPromo]
      ,@TermPromoP--[TermPromoP]
      ,@Unit--[Unit]
      ,@ExpectedRcptDate--[ExpectedRcptDate]
      ,@BilledBySupplier--[BilledBySupplier]
	  ,@PackSize--[PackSize]
      ,@ProductSupplier--[ProductSupplier]
	  ,@OrderAmount
	  ,@ReceivingSite
	  ,@STKQty--@InnerCase
	  )

	--ONORDER update
	UPDATE Product
	SET QtyOnOrder = @OrderQty
	WHERE ProductID = @ProductBCS
	                
END
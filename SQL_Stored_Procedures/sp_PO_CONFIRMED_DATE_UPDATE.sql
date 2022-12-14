USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_PO_CONFIRMED_DATE_UPDATE]    Script Date: 8/19/2022 3:43:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_PO_CONFIRMED_DATE_UPDATE] 
									@POHNUMBER varchar(30),
									@POConfirmedRcptDate DateTime,
									@RcptDateFlag int
	
AS
BEGIN

UPDATE PORDER
	SET OCNDAT_0 = @POConfirmedRcptDate,
	TSSCOD_0 = @RcptDateFlag
	WHERE POHNUM_0 = @POHNUMBER

UPDATE PORDERD
	SET STRDAT_0 = @RcptDateFlag
	WHERE POHNUM_0 = @POHNUMBER

END


USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_PO_ETA_DATE_UPDATE]    Script Date: 8/19/2022 3:43:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_PO_ETA_DATE_UPDATE] 
									@POHNUMBER varchar(30),
									@POExpectedRcptDate DateTime,
									@RcptDateFlag int
	
AS
BEGIN

UPDATE PORDER
	SET EXTRCPDAT1_0 = @POExpectedRcptDate,
	TSSCOD_0 = @RcptDateFlag
	WHERE POHNUM_0 = @POHNUMBER

UPDATE PORDERD
	SET POPDAT_0 = @POExpectedRcptDate
	WHERE POHNUM_0 = @POHNUMBER
	
END


--select extrcpdat1_0, ocndat_0 from porder order by orddat_0 desc
--select * from porderd order by credat_0 desc
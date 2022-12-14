USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_POCalendarREAL]    Script Date: 8/19/2022 3:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_POCalendarREAL]
@Date DateTime

WITH RECOMPILE
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @TheDate DateTime
	SET @TheDate = @Date
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

	SELECT
		POHNUM_0,
		BPSNUM_0,
		IIF(TSSCOD_0 = '', 'A', IIF(TSSCOD_0 = 1, 'E', 'C')) AS Flag
	FROM PORDER
	WHERE EXTRCPDAT1_0 = @TheDate

END
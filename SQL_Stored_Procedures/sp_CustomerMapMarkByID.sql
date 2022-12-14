USE [CoreXDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerMapMarkByID]    Script Date: 8/19/2022 3:40:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_CustomerMapMarkByID]
@CustomerID Nvarchar(100),
@Address Nvarchar(255) OUTPUT

WITH RECOMPILE
AS 
BEGIN
		DECLARE @Address1 varchar(MAX), @City varchar(100), @State varchar(100), @Postal varchar(100)
		SELECT 
			@Address1 = BPAADDLIG_0,
			@City =  CTY_0,
			@Postal = POSCOD_0 ,
			@State =  SAT_0 
		FROM BPADDRESS
		WHERE BPANUM_0 = @CustomerID AND BPAADD_0 = 'SHIP'--BPAADDFLG_0 = 1

		SET @Address = @Address1 + ', '+@City + ', '+@State+' '+@Postal
END


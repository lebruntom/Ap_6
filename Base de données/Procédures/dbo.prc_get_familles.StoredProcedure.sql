USE [ges_AMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_get_familles]    Script Date: 12/12/2021 19:03:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_get_familles]
AS
BEGIN

	SET NOCOUNT ON;
	select * from FAMILLE
END
GO

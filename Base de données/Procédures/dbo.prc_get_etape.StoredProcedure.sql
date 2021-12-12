USE [ges_AMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_get_etape]    Script Date: 12/12/2021 19:03:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_etape]
	-- Add the parameters for the stored procedure here

AS
BEGIN

	SET NOCOUNT ON;

	SELECT ETAPE.ETP_NUM, ETP_LIBELLE, ETP_NORME, ETP_DATE_NORME
	from ETAPE_NORMEE
	inner join ETAPE on ETAPE_NORMEE.ETP_NUM = ETAPE.ETP_NUM
	Order by ETAPE.ETP_NUM
END
GO

USE [ges_AMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_get_workflow]    Script Date: 12/12/2021 19:03:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_workflow](@depotLegal varchar(10))
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from SUBIR WHERE MED_DEPOTLEGAL = @depotLegal
END
GO

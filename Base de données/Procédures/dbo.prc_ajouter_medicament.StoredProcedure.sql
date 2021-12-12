USE [ges_AMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajouter_medicament]    Script Date: 12/12/2021 19:03:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prc_ajouter_medicament]
	-- Add the parameters for the stored procedure here
	@DepotLegal nchar(10),
	@NomCommercial nchar(25),
	@FamilleCode nchar(3),
	@Composition nchar(255),
	@Effet nchar(255),
	@ContreIndication nchar(255),
	@PrixUnitaire float

AS
BEGIN
	SET NOCOUNT ON;
	
    -- Insertion du medicament
	INSERT INTO MEDICAMENT (MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, FAM_CODE, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON) VALUES (@DepotLegal, @NomCommercial, @FamilleCode, @Composition, @Effet, @ContreIndication, @PrixUnitaire)
END
GO

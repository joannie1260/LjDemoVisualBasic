Imports Microsoft.VisualBasic

Public Class Listings
    Public Property Valide As Boolean
    Public Property Vendu As Boolean
    Public Property GenreRetribution As String
    Public Property DateInscription As DateTime
    Public Property DateExpiration As DateTime
    Public Property MunCode As String
    Public Property CentrisMunCode As String
    Public Property QuartrCode As String
    Public Property PresDe As String
    Public Property NoCiviqueDebut As String
    Public Property NoCiviqueFin As String
    Public Property NomRueComplet As String
    Public Property Appartement As String
    Public Property CodePostal As String
    Public Property Cadastre As String
    Public Property IndCertificatLocalisation As String
    Public Property AnneeCertificatLocalisation As Integer
    Public Property NomProprietaire1 As String
    Public Property AdresseProprietaire1 As String
    Public Property Tel1Proprietaire1 As String
    Public Property Tel2Proprietaire1 As String
    Public Property PrixAlternatif As Integer
    Public Property DevisePrixAlternatif As String
    Public Property UmPrixAlternatif As String
    Public Property Tel1Proprietaire2 As String
    Public Property Tel2Proprietaire2 As String
    Public Property PosteTel2Proprietaire2 As Integer
    Public Property DateOccupation As DateTime
    Public Property DelaiOccupationFrancais As String
    Public Property DelaiOccupationAnglais As String
    Public Property DateActeVente As DateTime
    Public Property DelaiActeVenteFrancais As String
    Public Property DelaiActeVenteAnglais As String
    Public Property DateFinBail As DateTime
    Public Property TelRendezVous As String
    Public Property InfoRendezVous As String
    Public Property CodeRendezVous As String
    Public Property CategoriePropriete As String
    Public Property GenrePropriete As String
    Public Property TypeBatiment As String
    Public Property TypeCopropriete As String
    Public Property Niveau As String
    Public Property NbEtages As Integer
    Public Property AnneeContruction As Integer
    Public Property CodeAnneeConstruction As String
    Public Property DimensionBatiment As String
    Public Property FacadeBatiment As Integer
    Public Property ProfondeurBatiment As Double
    Public Property IndIrregulierBatiment As String
    Public Property UmDimensionBatiment As String
    Public Property AireAuSol As Double
    Public Property UmAireAuSol As String
    Public Property AireHabitable As Double
    Public Property UmAireHabitable As String
    Public Property DimensionTerrain As String
    Public Property FacadeTerrain As Integer
    Public Property ProfondeurTerrain As Integer
    Public Property IndIrregulierTerrain As String
    Public Property UmDimensionTerrain As String
    Public Property SuperficieTerrain As Integer
    Public Property UmSuperficieTerrain As String
    Public Property Matricule As String
    Public Property AnneeEvaluation As Integer
    Public Property EvaluationMunicipaleTerrain As Integer
    Public Property EvaluationMunicipaleBatiment As Integer
    Public Property NbPieces As Integer
    Public Property NbChambres As Integer
    Public Property NbChambresSousSol As Integer
    Public Property NbChambresHorsSol As Integer
    Public Property NbSallesBains As Integer
    Public Property NbSallesEau As Integer
    Public Property NomFichierPhoto As String
    Public Property NoContratCourtage As String
    Public Property RevenusLocationAnPotentiels As Integer
    Public Property AutresRevenusBrut As Integer
    Public Property RevenusAnPotentiels As Integer
    Public Property PerteVacancesMauvCreances As Integer
    Public Property DepensesTotExploitation As Integer
    Public Property RevenusAnNetAvantServDette As Integer
    Public Property ServiceDette As Integer
    Public Property NomPlanEau As String
    Public Property FacadePlanEau As Integer
    Public Property NbChauffeEauTotal As Integer
    Public Property NbChauffeEauLoue As Integer
    Public Property InclusFrancais As String
    Public Property InclusAnglais As String
    Public Property ExclusFrancais As String
    Public Property ExclusAnglais As String
    Public Property NbUnitesTotal As Integer
    Public Property CodeNbUnitesTotal As String
    Public Property IndPlanArpentage As String
    Public Property AnneePlanArpentage As Integer
    Public Property IndTitrePropriete As String
    Public Property IndVenteSansGarantieLegale As String
    Public Property NoteTaxe As String
    Public Property NoCasier As String
    Public Property NoStationnement As String
    Public Property IndAdresseSurInternet As String
    Public Property DateModif As DateTime
    Public Property FrequencePrixLocation As String
    Public Property CodeStatut As String
    Public Property PourcQuotePart As Integer
    Public Property UtilisationCommerciale As String
    Public Property ChampInutilise2 As String
    Public Property NomDuParc As String
    Public Property DatePromesseAchatCond As DateTime
    Public Property IndPromesseAchatCond As String
    Public Property RaisonSociale As String
    Public Property EnOperDepuis As String
    Public Property IndFranchise As String
    Public Property DescGenreEntr As String
    Public Property TypeBail As String
    Public Property GenreBail As String
    Public Property IndOptRenouvBail As String
    Public Property AnneeMoisEcheanceBail As String
    Public Property UrlVisiteVirtuelleFrancais As String
    Public Property UrlVisiteVirtuelleAnglais As String
    Public Property UrlDescDetaillee As String
    Public Property IndTaxesPrixDemande As String
    Public Property IndTaxesPrixLocationDemande As String
    Public Property Descriptionfr As String
    Public Property Descriptionen As String
    Public Property TaxeMunicipale As Integer
    Public Property TaxeScolaire As Integer
    Public Property Municipalite As String
    Public Property GenreFr As String
    Public Property GenreEn As String
    Public Property NoInscription As String
    Public Property CodeLangueInscription As String
    Public Property AgentInscripteur1 As String
    Public Property BureauInscripteur1 As String
    Public Property AgentInscripteur2 As String
    Public Property BureauInscripteur2 As String
    Public Property AgentInscripteur3 As String
    Public Property BureauInscripteur3 As String
    Public Property AgentInscripteur4 As String
    Public Property BureauInscripteur4 As String
    Public Property PrixDemande As Integer
    Public Property UmPrixDemande As String
    Public Property DevisePrixDemande As String
    Public Property PrixLocationDemande As Integer
    Public Property UmPrixLocationDemande As String
    Public Property DevisePrixLocationDemande As String
    Public Property IndClauseRestrictive As String
    Public Property CodeDeclarationVendeur As String
    Public Property IndRepriseFinance As String
    Public Property IndInternet As String
    Public Property IndEchangePossible As String
    Public Property Clef As String
    Public Property Region As String
    Public Property RetributionVendeur As String
    Public Property TypeSuperficieHabitable As String
    Public Property RevPotentielBrutResidentiel As Integer
    Public Property RevPotentielBrutCommercial As Integer
    Public Property RevPotentielBrutStationnement As Integer
    Public Property RevPotentielBrutAutre As Integer
    Public Property AuGenreProprieteInfoF As String
    Public Property AuGenreProprieteInfoA As String
    Public Property PrixDemandeTaxeIncl As Integer
    Public Property CaractList As String
    Public Property AllRooms As List(Of Room)
    Public Property AllPhotos As List(Of Photo)
    Public Property BuildingCaracteristics As List(Of BuildingCaracteristic)
    Public Property LandCaracteristics As List(Of LandCaracteristic)
    Public Property OtherCaracteristics As List(Of OtherCaracteristic)
    Public Property Revenues As List(Of Object)
    Public Property Depenses As List(Of Depens)
    Public Property OpenHouses As Object
    Public Property AllIntergenRooms As List(Of Object)
    Public Property BrokerIds As String
    Public Property Members As Object
    Public Property Bathrooms As Integer
    Public Property Bedrooms As Integer
    Public Property CivicAddress As String
    Public Property ZipCode As String
    Public Property OpenHouseDate As Object
    Public Property City As String
    Public Property InscriptionDate As DateTime
    Public Property Description As String
    Public Property Category As String
    Public Property Genre As String
    Public Property GenreCode As String
    Public Property DetailURL As String
    Public Property RemoteDetailURL As String
    Public Property ID As String
    Public Property PictureURL As String
    Public Property Powderrooms As Integer
    Public Property FormattedPrice As String
    Public Property RawPrice As String
    Public Property Price As Integer
    Public Property PriceUnit As String
    Public Property RentalPrice As Integer
    Public Property RentalPriceUnit As String
    Public Property RentalPriceFrequency As String
    Public Property Province As String
    Public Property Sold As Boolean
    Public Property PhotoUrl As String
    Public Property PhotoVersion As String
    Public Property PhotoModifyDate As String
    Public Property Lang As String
    Public Property Adresse As String
    Public Property RegionAbrege As String
    Public Property AddendaFR As String
    Public Property AddendaEN As String
    Public Property Longitude As String
    Public Property Latitude As String
    Public Property HasTaxe As Boolean
    Public Property VirtualVisitUrl As String
    Public Property TotalRevenues As Integer
    Public Property TotalDepenses As Integer
    Public Property BaseTags As Object
    Public Property Tags As String
    Public Property IsShared As Boolean
    Public Property Hash As String
    Public Property HasVideo As Boolean
    Public Property CaractCodes As String

    Public Class Room
        Public Property NoInscription As String
        Public Property OrdreAffichage As Integer
        Public Property Dimensions As String
        Public Property PieceCode As String
        Public Property CouvrePlancherCode As String
        Public Property PieceNomFr As String
        Public Property EtageNomFr As String
        Public Property PlancherFr As String
        Public Property PieceNomEn As String
        Public Property EtageNomEn As String
        Public Property PlancherEn As String
        Public Property InformationsFrancaises As String
        Public Property InformationsAnglaises As String
        Public Property Etage As String
        Public Property IndIrregulier As Boolean
        Public Property IndInacheve As Boolean
        Public Property EtageNom As String
        Public Property Informations As String
        Public Property PieceNom As String
        Public Property Plancher As String
    End Class


    Public Class Photo
        Public Property NoInscription As String
        Public Property Seq As Integer
        Public Property NomFichierPhoto As String
        Public Property CodeDescriptionPhoto As String
        Public Property Pdf As Boolean
        Public Property IsHd As Integer
        Public Property IsAdd As Integer
        Public Property DescriptionFrancaise As String
        Public Property DescriptionAnglaise As String
        Public Property PhotoUrl As String
        Public Property NoVersion As String
        Public Property ModifyDate As String
        Public Property Lang As Object
        Public Property PictureURL As String
        Public Property DescriptionEn As String
        Public Property DescriptionFr As String
        Public Property URL As String
    End Class

    Public Class BuildingCaracteristic
        Public Property Code As String
        Public Property NoInscription As String
        Public Property Descriptiontypefr As String
        Public Property Descriptionsoustypefr As String
        Public Property Descriptiontypeen As String
        Public Property Descriptionsoustypeen As String
        Public Property Nombre As Integer
        Public Property DescriptionAbregeeFrancaise As String
        Public Property DescriptionAbregeeAnglaise As String
        Public Property Lang As Object
        Public Property DescriptionAbrege As String
        Public Property DescriptionType As String
        Public Property DescriptionSousType As String
    End Class

    Public Class LandCaracteristic
        Public Property Code As String
        Public Property NoInscription As String
        Public Property Descriptiontypefr As String
        Public Property Descriptionsoustypefr As String
        Public Property Descriptiontypeen As String
        Public Property Descriptionsoustypeen As String
        Public Property Nombre As Integer
        Public Property DescriptionAbregeeFrancaise As String
        Public Property DescriptionAbregeeAnglaise As String
        Public Property Lang As Object
        Public Property DescriptionAbrege As String
        Public Property DescriptionType As String
        Public Property DescriptionSousType As String
    End Class

    Public Class OtherCaracteristic
        Public Property Code As String
        Public Property NoInscription As String
        Public Property Descriptiontypefr As String
        Public Property Descriptionsoustypefr As String
        Public Property Descriptiontypeen As String
        Public Property Descriptionsoustypeen As String
        Public Property Nombre As Integer
        Public Property DescriptionAbregeeFrancaise As String
        Public Property DescriptionAbregeeAnglaise As String
        Public Property Lang As Object
        Public Property DescriptionAbrege As String
        Public Property DescriptionType As String
        Public Property DescriptionSousType As String
    End Class

    Public Class Depens
        Public Property NoInscription As String
        Public Property Tdep_Code As String
        Public Property DescriptionFrancaise As String
        Public Property DescriptionAnglaise As String
        Public Property MontantDepense As Integer
        Public Property Annee As Integer
        Public Property AnneeExpiration As Integer
        Public Property Frequence As String
        Public Property PartDepense As String
    End Class



End Class

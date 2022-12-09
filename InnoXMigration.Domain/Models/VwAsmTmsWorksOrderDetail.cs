using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsWorksOrderDetail
{
    public int WodIdpk { get; set; }

    public DateTime? WodDate { get; set; }

    public int? WodMaintActivityIdfk { get; set; }

    public int? WodJobDetailIdfk { get; set; }

    public decimal? WodCost { get; set; }

    public decimal WodVatCharge { get; set; }

    public decimal? WodTotalCost { get; set; }

    public string? WodReferenceNoTotAmt { get; set; }

    public int? WodCurrencyIdfk { get; set; }

    public int? WodExtWorkshopIdfk { get; set; }

    public string? WodReferenceNo { get; set; }

    public int? WodPreparedByEmpIdfk { get; set; }

    public DateTime? WodPreparedOn { get; set; }

    public int? WodRecommendedByEmpIdfk { get; set; }

    public DateTime? WodRecommendedOn { get; set; }

    public int? WodAuthorisedByEmpIdfk { get; set; }

    public DateTime? WodAuthorisedOn { get; set; }

    public bool? WodPrepared { get; set; }

    public bool? WodRecommended { get; set; }

    public bool? WodAuthorised { get; set; }

    public bool? WodActive { get; set; }

    public string? WodRmks { get; set; }

    public string? WodCreatedBy { get; set; }

    public int? WodEditedBy { get; set; }

    public int? WodDeletedBy { get; set; }

    public DateTime? WodCreationDate { get; set; }

    public DateTime? WodEditedDate { get; set; }

    public DateTime? WodDeletionDate { get; set; }

    public int MtaIdpk { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int MjdIdpk { get; set; }

    public int? MjdMaintActivityIdfk { get; set; }

    public string? MjdJob { get; set; }

    public string? MjdDescription { get; set; }

    public DateTime? MjdDate { get; set; }

    public bool? MjdActive { get; set; }

    public int ExtWorkshopId { get; set; }

    public string? ExtWorkshopName { get; set; }

    public string? ExtWorkshopShtName { get; set; }

    public string? ExtWorkshopCode { get; set; }

    public string? ExtWorkshopContact { get; set; }

    public string? ExtWorkshopTelNo { get; set; }

    public string ExtWorkshopPlc { get; set; } = null!;

    public string ExtWorkshopAddress { get; set; } = null!;

    public string ExtWorkshopEmail { get; set; } = null!;

    public bool? ExtWorkshopActive { get; set; }

    public string? ExtWorkshopRmks { get; set; }

    public bool ExtWorkshopExternal { get; set; }

    public int? ExtWorkshopLocIdfk { get; set; }

    public int ExtWorkshopTwnIdpk { get; set; }

    public string? ExtWorkshopTwnName { get; set; }

    public string? ExtWorkshopTwnShtName { get; set; }

    public bool? ExtWorkshopTwnActive { get; set; }

    public string ExtWorkshopTwnRmks { get; set; } = null!;

    public int? ExtWorkshopRgnIdpk { get; set; }

    public string? ExtWorkshopRgnName { get; set; }

    public string? ExtWorkshopRgnShtName { get; set; }

    public bool? ExtWorkshopRgnActive { get; set; }

    public int? ExtWorkshopCtyIdpk { get; set; }

    public string? ExtWorkshopCtyName { get; set; }

    public string? ExtWorkshopCtyShtName { get; set; }

    public string? ExtWorkshopCtyNationality { get; set; }

    public int ExtWorkshopLocIdpk { get; set; }

    public string ExtWorkshopLocShtName { get; set; } = null!;

    public string ExtWorkshopLocName { get; set; } = null!;

    public bool? ExtWorkshopLocActive { get; set; }

    public int? ExtWorkshopAreIdpk { get; set; }

    public string ExtWorkshopAreName { get; set; } = null!;

    public string ExtWorkshopAreShtName { get; set; } = null!;

    public int? VdtIdpk { get; set; }

    public string? VdtChassisNo { get; set; }

    public string? VdtRegNo { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MjdRmks { get; set; }

    public string? MakeModelName { get; set; }

    public string? MakeModelShtName { get; set; }

    public DateTime WodSubmittedOn { get; set; }

    public bool WodSubmitted { get; set; }

    public int SubmittedByEmpIdpk { get; set; }

    public string SubmittedByStaffNo { get; set; } = null!;

    public string SubmittedByLnam { get; set; } = null!;

    public string SubmittedByFname { get; set; } = null!;

    public string SubmittedByOname { get; set; } = null!;

    public string SubmittedByHrmsName { get; set; } = null!;

    public string SubmittedByEmpName { get; set; } = null!;

    public string SubmittedByEmpName1 { get; set; } = null!;

    public string SubmittedByEmpName2 { get; set; } = null!;

    public string SubmittedByEmpName3 { get; set; } = null!;

    public string SubmittedByempName4 { get; set; } = null!;

    public int SubmittedByDeptIdpk { get; set; }

    public string SubmittedByDeptName { get; set; } = null!;

    public string SubmittedByDeptShtName { get; set; } = null!;

    public int SubmittedBySxnIdpk { get; set; }

    public string SubmittedBySxnName { get; set; } = null!;

    public string SubmittedBySxnShtName { get; set; } = null!;

    public int SubmittedByTitIdpk { get; set; }

    public string SubmittedByTitName { get; set; } = null!;

    public int SubmittedByLocIdpk { get; set; }

    public string SubmittedByLocName { get; set; } = null!;

    public string SubmittedByLocShtName { get; set; } = null!;

    public string SubmittedByMobNo { get; set; } = null!;

    public string SubmittedByMobNox { get; set; } = null!;

    public string SubmittedByPlc { get; set; } = null!;

    public int SubmittedByJbtIdpk { get; set; }

    public string SubmittedByJbtName { get; set; } = null!;

    public string SubmittedByJbtShtName { get; set; } = null!;

    public string SubmittedByEmpName5 { get; set; } = null!;

    public int PreparedByEmpIdpk { get; set; }

    public string PreparedByStaffNo { get; set; } = null!;

    public string PreparedByLnam { get; set; } = null!;

    public string PreparedByFname { get; set; } = null!;

    public string PreparedByOname { get; set; } = null!;

    public string PreparedByHrmsName { get; set; } = null!;

    public string PreparedByEmpName { get; set; } = null!;

    public string PreparedByEmpName1 { get; set; } = null!;

    public string PreparedByEmpName2 { get; set; } = null!;

    public string PreparedByEmpName3 { get; set; } = null!;

    public string PreparedByempName4 { get; set; } = null!;

    public int PreparedByDeptIdpk { get; set; }

    public string PreparedByDeptName { get; set; } = null!;

    public string PreparedByDeptShtName { get; set; } = null!;

    public int PreparedBySxnIdpk { get; set; }

    public string PreparedBySxnName { get; set; } = null!;

    public string PreparedBySxnShtName { get; set; } = null!;

    public int PreparedByTitIdpk { get; set; }

    public string PreparedByTitName { get; set; } = null!;

    public int PreparedByLocIdpk { get; set; }

    public string PreparedByLocName { get; set; } = null!;

    public string PreparedByLocShtName { get; set; } = null!;

    public string PreparedByMobNo { get; set; } = null!;

    public string PreparedByMobNox { get; set; } = null!;

    public string PreparedByPlc { get; set; } = null!;

    public int PreparedByJbtIdpk { get; set; }

    public string PreparedByJbtName { get; set; } = null!;

    public string PreparedByJbtShtName { get; set; } = null!;

    public string PreparedByEmpName5 { get; set; } = null!;

    public int RecommendedByEmpIdpk { get; set; }

    public string RecommendedByStaffNo { get; set; } = null!;

    public string RecommendedByLnam { get; set; } = null!;

    public string RecommendedByFname { get; set; } = null!;

    public string RecommendedByOname { get; set; } = null!;

    public string RecommendedByHrmsName { get; set; } = null!;

    public string RecommendedByEmpName { get; set; } = null!;

    public string RecommendedByEmpName1 { get; set; } = null!;

    public string RecommendedByEmpName2 { get; set; } = null!;

    public string RecommendedByEmpName3 { get; set; } = null!;

    public string RecommendedByempName4 { get; set; } = null!;

    public int RecommendedByDeptIdpk { get; set; }

    public string RecommendedByDeptName { get; set; } = null!;

    public string RecommendedByDeptShtName { get; set; } = null!;

    public int RecommendedBySxnIdpk { get; set; }

    public string RecommendedBySxnName { get; set; } = null!;

    public string RecommendedBySxnShtName { get; set; } = null!;

    public int RecommendedByTitIdpk { get; set; }

    public string RecommendedByTitName { get; set; } = null!;

    public int RecommendedByLocIdpk { get; set; }

    public string RecommendedByLocName { get; set; } = null!;

    public string RecommendedByLocShtName { get; set; } = null!;

    public string RecommendedByMobNo { get; set; } = null!;

    public string RecommendedByMobNox { get; set; } = null!;

    public string RecommendedByPlc { get; set; } = null!;

    public int RecommendedByJbtIdpk { get; set; }

    public string RecommendedByJbtName { get; set; } = null!;

    public string RecommendedByJbtShtName { get; set; } = null!;

    public string RecommendedByEmpName5 { get; set; } = null!;

    public int AuthorisedByEmpIdpk { get; set; }

    public string AuthorisedByStaffNo { get; set; } = null!;

    public string AuthorisedByLnam { get; set; } = null!;

    public string AuthorisedByFname { get; set; } = null!;

    public string AuthorisedByOname { get; set; } = null!;

    public string AuthorisedByHrmsName { get; set; } = null!;

    public string AuthorisedByEmpName { get; set; } = null!;

    public string AuthorisedByEmpName1 { get; set; } = null!;

    public string AuthorisedByEmpName2 { get; set; } = null!;

    public string AuthorisedByEmpName3 { get; set; } = null!;

    public string AuthorisedByempName4 { get; set; } = null!;

    public int AuthorisedByDeptIdpk { get; set; }

    public string AuthorisedByDeptName { get; set; } = null!;

    public string AuthorisedByDeptShtName { get; set; } = null!;

    public int AuthorisedBySxnIdpk { get; set; }

    public string AuthorisedBySxnName { get; set; } = null!;

    public string AuthorisedBySxnShtName { get; set; } = null!;

    public int AuthorisedByTitIdpk { get; set; }

    public string AuthorisedByTitName { get; set; } = null!;

    public int AuthorisedByLocIdpk { get; set; }

    public string AuthorisedByLocName { get; set; } = null!;

    public string AuthorisedByLocShtName { get; set; } = null!;

    public string AuthorisedByMobNo { get; set; } = null!;

    public string AuthorisedByMobNox { get; set; } = null!;

    public string AuthorisedByPlc { get; set; } = null!;

    public int AuthorisedByJbtIdpk { get; set; }

    public string AuthorisedByJbtName { get; set; } = null!;

    public string AuthorisedByJbtShtName { get; set; } = null!;

    public string AuthorisedByEmpName5 { get; set; } = null!;

    public string PreparedBy { get; set; } = null!;

    public string RecommendedBy { get; set; } = null!;

    public string AuthorisedBy { get; set; } = null!;

    public string? MrqDefectRequest { get; set; }

    public string? MrqReviewReport { get; set; }

    public DateTime? MrqDate { get; set; }

    public int MrqIdpk { get; set; }

    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdAddress { get; set; }

    public string? WsdTelNo { get; set; }

    public string? WsdEmail { get; set; }

    public string? WsdPlc { get; set; }

    public decimal WodDiscount { get; set; }
}

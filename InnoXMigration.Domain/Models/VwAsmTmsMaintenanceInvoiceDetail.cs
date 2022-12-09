using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceInvoiceDetail
{
    public int MaiIdpk { get; set; }

    public DateTime? MaiDate { get; set; }

    public string? MaiReferenceNo { get; set; }

    public int? MaiMaintActivityIdfk { get; set; }

    public int? MaiCurrencyIdfk { get; set; }

    public int? MaiInvoiceNo { get; set; }

    public int? MaiPreparedByEmpIdfk { get; set; }

    public DateTime? MaiPreparedOn { get; set; }

    public int? MaiRecommendedByEmpIdfk { get; set; }

    public DateTime? MaiRecommendedOn { get; set; }

    public int? MaiAuthorisedByEmpIdfk { get; set; }

    public DateTime? MaiAuthorisedOn { get; set; }

    public bool MaiPrepared { get; set; }

    public bool MaiRecommended { get; set; }

    public bool MaiAuthorised { get; set; }

    public bool MaiActive { get; set; }

    public string MaiRmks { get; set; } = null!;

    public string? MaiCreatedBy { get; set; }

    public int? MaiEditedBy { get; set; }

    public int? MaiDeletedBy { get; set; }

    public DateTime? MaiCreationDate { get; set; }

    public DateTime? MaiEditedDate { get; set; }

    public DateTime? MaiDeletionDate { get; set; }

    public int MtaIdpk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

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

    public string? MakeModelName { get; set; }

    public string? MakeModelShtName { get; set; }

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

    public string PreparedByPlc { get; set; } = null!;

    public int PreparedByJbtIdpk { get; set; }

    public string PreparedByJbtName { get; set; } = null!;

    public string PreparedByJbtShtName { get; set; } = null!;

    public string PreparedByMobNox { get; set; } = null!;

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

    public string RecommendedByPlc { get; set; } = null!;

    public int RecommendedByJbtIdpk { get; set; }

    public string RecommendedByJbtName { get; set; } = null!;

    public string RecommendedByJbtShtName { get; set; } = null!;

    public string RecommendedByMobNox { get; set; } = null!;

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

    public string AuthorisedByPlc { get; set; } = null!;

    public int AuthorisedByJbtIdpk { get; set; }

    public string AuthorisedByJbtName { get; set; } = null!;

    public string AuthorisedByJbtShtName { get; set; } = null!;

    public string AuthorisedByMobNox { get; set; } = null!;

    public string AuthorisedByEmpName5 { get; set; } = null!;

    public string PreparedBy { get; set; } = null!;

    public string RecommendedBy { get; set; } = null!;

    public string AuthorisedBy { get; set; } = null!;

    public int WsdIdpk { get; set; }

    public string? WsdName { get; set; }

    public string? WsdShtName { get; set; }

    public string? WsdCode { get; set; }

    public string? WsdContact { get; set; }

    public string? WsdAddress { get; set; }

    public string? WsdTelNo { get; set; }

    public string? WsdEmail { get; set; }

    public string? WsdPlc { get; set; }

    public int? WsdTownIdfk { get; set; }

    public bool? WsdActive { get; set; }

    public string? WsdRmks { get; set; }

    public int? WsdCreatedBy { get; set; }

    public int? WsdEditedBy { get; set; }

    public DateTime? WsdCreationDate { get; set; }

    public DateTime? WsdEditedDate { get; set; }

    public string? MrqDefectRequest { get; set; }

    public string? MrqReviewReport { get; set; }

    public DateTime? MrqDate { get; set; }

    public int MrqIdpk { get; set; }

    public int WodIdpk { get; set; }

    public DateTime? WodDate { get; set; }

    public decimal? WodCost { get; set; }

    public string? WodReferenceNo { get; set; }

    public int ExtWorkshopId { get; set; }

    public string? ExtWorkshopName { get; set; }

    public string? ExtWorkshopShtName { get; set; }

    public string? ExtWorkshopCode { get; set; }

    public string? ExtWorkshopContact { get; set; }

    public string? ExtWorkshopTelNo { get; set; }

    public string ExtWorkshopPlc { get; set; } = null!;

    public int ExtWorkshopTwnIdpk { get; set; }

    public string? ExtWorkshopTwnName { get; set; }

    public int? ExtWorkshopRgnIdpk { get; set; }

    public string? ExtWorkshopRgnName { get; set; }

    public string? ExtWorkshopRgnShtName { get; set; }

    public string? ExtWorkshopTwnShtName { get; set; }

    public int ExtWorkshopLocIdpk { get; set; }

    public string ExtWorkshopLocShtName { get; set; } = null!;

    public string ExtWorkshopLocName { get; set; } = null!;

    public string? MjdJob { get; set; }

    public string? MjdDescription { get; set; }

    public DateTime? MjdDate { get; set; }

    public int MjdIdpk { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public decimal? WodTotalCost { get; set; }

    public decimal MaiAmount { get; set; }

    public decimal MaiVatCharge { get; set; }

    public decimal MaiDiscount { get; set; }

    public decimal? TotalCost { get; set; }
}

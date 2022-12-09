using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsMaintenanceActivityMaterial
{
    public int MamIdpk { get; set; }

    public DateTime? MamDate { get; set; }

    public int? MamMaintActivityIdfk { get; set; }

    public int? MamMaterialIdfk { get; set; }

    public decimal? MamUnitPrice { get; set; }

    public decimal? MamQuantity { get; set; }

    public decimal? MamTotal { get; set; }

    public string? MamQuantityUnit { get; set; }

    public string? MamRequisitionNo { get; set; }

    public string? MamCode { get; set; }

    public string? MamStoreNo { get; set; }

    public int? MamPreparedByEmpIdfk { get; set; }

    public int? MamRecommendedByEmpIdfk { get; set; }

    public bool? MamActive { get; set; }

    public string? MamRmks { get; set; }

    public string? MamCreatedBy { get; set; }

    public int? MamEditedBy { get; set; }

    public DateTime? MamCreationDate { get; set; }

    public DateTime? MamEditedDate { get; set; }

    public int CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurShtName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public int? MamCurrencyIdfk { get; set; }

    public int MtrIdpk { get; set; }

    public string? MtrName { get; set; }

    public string? MtrShtName { get; set; }

    public string? MtrCode { get; set; }

    public string? MtrStoreNo { get; set; }

    public int MtaIdpk { get; set; }

    public DateTime? MtaDateIn { get; set; }

    public DateTime? MtaDateOut { get; set; }

    public string? MtaJobNo { get; set; }

    public int? MtaMaintenanceTypeIdfk { get; set; }

    public decimal? MtaSpeedoIn { get; set; }

    public decimal? MtaSpeedoOut { get; set; }

    public int SubmittedByEmpIdpk { get; set; }

    public string SubmittedByStaffNo { get; set; } = null!;

    public string SubmittedByLnam { get; set; } = null!;

    public string SubmittedByFname { get; set; } = null!;

    public string SubmittedByOname { get; set; } = null!;

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

    public int Expr1 { get; set; }

    public int RecommendedByEmpIdpk { get; set; }

    public string RecommendedByStaffNo { get; set; } = null!;

    public string RecommendedByLnam { get; set; } = null!;

    public string RecommendedByFname { get; set; } = null!;

    public string RecommendedByOname { get; set; } = null!;

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

    public int? MamRelatedJobIdfk { get; set; }

    public int MjdIdpk { get; set; }

    public int? MjdMaintActivityIdfk { get; set; }

    public string? MjdJob { get; set; }

    public string? MjdDescription { get; set; }

    public DateTime? MjdDate { get; set; }

    public bool? MjdActive { get; set; }

    public string? MjdRmks { get; set; }

    public DateTime? MamPreparedOn { get; set; }

    public DateTime? MamRecommendedOn { get; set; }

    public DateTime? MamAuthorisedOn { get; set; }

    public bool? MamPrepared { get; set; }

    public bool? MamRecommended { get; set; }

    public bool? MamAuthorised { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int? SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int VasIdpk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public string? VdtRegNo { get; set; }

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime? VdtSupplyDate { get; set; }

    public decimal? VdtPrice { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public bool? VstFitStatus { get; set; }

    public int OwnerEmpIdfk { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string? OwnerPlc { get; set; }

    public string OwnerLname { get; set; } = null!;

    public string OwnerFname { get; set; } = null!;

    public bool? MtaOpened { get; set; }

    public string? RequestedByStaffNo { get; set; }

    public string? RequestedByLname { get; set; }

    public string? RequestedByFname { get; set; }

    public string? RequestedByOnames { get; set; }

    public string? RequestedByEmpName { get; set; }

    public string? RequestedByEmpName1 { get; set; }

    public string? RequestedByEmpName5 { get; set; }

    public string? RequestedByDptName { get; set; }

    public int? ReqDriverEmpId { get; set; }

    public string? ReqDriverStaffNo { get; set; }

    public string? ReqDriverLname { get; set; }

    public string? ReqDriverFname { get; set; }

    public string? ReqDriverOnames { get; set; }

    public string? ReqDriverEmpName { get; set; }

    public int? MamSubmittedByEmpIdfk { get; set; }

    public DateTime? MamSubmittedOn { get; set; }

    public bool MamSubmitted { get; set; }

    public decimal MamVatCharge { get; set; }

    public decimal MamDiscount { get; set; }
}

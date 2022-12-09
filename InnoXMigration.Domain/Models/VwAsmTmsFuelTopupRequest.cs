using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelTopupRequest
{
    public int FtrIdpk { get; set; }

    public int? FtrRequesterEmpIdfk { get; set; }

    public decimal? FtrQuantityRequested { get; set; }

    public decimal FtrQuantityApproved { get; set; }

    public decimal FtrQuantityToppedUp { get; set; }

    public DateTime? FtrApprovedOn { get; set; }

    public string FtrApprovalRmks { get; set; } = null!;

    public string FtrCancellationRmks { get; set; } = null!;

    public string FtrPurpose { get; set; } = null!;

    public bool FtrApproved { get; set; }

    public bool FtrCancelled { get; set; }

    public int? FtrCancelledByEmpIdfk { get; set; }

    public DateTime? FtrCancelledOn { get; set; }

    public bool FtrSmsSent { get; set; }

    public bool? FtrActive { get; set; }

    public string FtrRmks { get; set; } = null!;

    public int? FtrCreatedBy { get; set; }

    public int? FtrEditedBy { get; set; }

    public DateTime? FtrCreationDate { get; set; }

    public DateTime? FtrEditedDate { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string VdtChassisNo { get; set; } = null!;

    public decimal VdtCubicCapacity { get; set; }

    public decimal VdtTankCapacity { get; set; }

    public byte VdtNoOfCylinders { get; set; }

    public string VdtTyreSizeFront { get; set; } = null!;

    public string VdtTyreSizeMiddle { get; set; } = null!;

    public string VdtTyreSizeRear { get; set; } = null!;

    public decimal VdtNetWeight { get; set; }

    public decimal VdtGrossWeight { get; set; }

    public decimal VdtLength { get; set; }

    public decimal VdtWidth { get; set; }

    public decimal VdtHeight { get; set; }

    public byte VdtNoOfAxles { get; set; }

    public byte VdtNoOfWheels { get; set; }

    public string VdtEngineNo { get; set; } = null!;

    public string VdtHorsePower { get; set; } = null!;

    public DateTime? VdtManufactureDate { get; set; }

    public DateTime VdtSupplyDate { get; set; }

    public decimal? ManufactureAge { get; set; }

    public decimal? SupplyAge { get; set; }

    public byte VdtSeatingCapacity { get; set; }

    public int? MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public int? VstIdpk { get; set; }

    public string? VstName { get; set; }

    public string? VstShtName { get; set; }

    public int? FtrVehicleDetailIdfk { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLname { get; set; }

    public string? RequesterFname { get; set; }

    public string RequesterOnames { get; set; } = null!;

    public string RequesterHrmsName { get; set; } = null!;

    public string? RequesterEmpName { get; set; }

    public string? RequesterEmpName1 { get; set; }

    public string? RequesterEmpName2 { get; set; }

    public string? RequesterEmpName3 { get; set; }

    public string? RequesterEmpName4 { get; set; }

    public string? RequesterEmpName5 { get; set; }

    public string? RequesterEmpName6 { get; set; }

    public string? RequesterEmpName7 { get; set; }

    public string? RequesterEmpName8 { get; set; }

    public string? RequesterEmpName9 { get; set; }

    public string? RequesterEmpName10 { get; set; }

    public string? RequesterEmpName11 { get; set; }

    public int RequesterDeptId { get; set; }

    public string RequesterDeptName { get; set; } = null!;

    public string RequesterDeptShtName { get; set; } = null!;

    public int RequesterSxnId { get; set; }

    public string RequesterSxnName { get; set; } = null!;

    public string RequesterSxnShtName { get; set; } = null!;

    public int RequesterLocId { get; set; }

    public string RequesterLocName { get; set; } = null!;

    public string RequesterLocShtName { get; set; } = null!;

    public string RequesterMobNox { get; set; } = null!;

    public string RequesterPlc { get; set; } = null!;

    public string RequesterMobNo { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public int? RecommendedByEmpId { get; set; }

    public string? RecommendedByStaffNo { get; set; }

    public string? RecommendedByLname { get; set; }

    public string? RecommendedByFname { get; set; }

    public string? RecommendedByOnames { get; set; }

    public string? RecommendedByHrmsName { get; set; }

    public string? RecommendedByEmpName { get; set; }

    public string? RecommendedByEmpName1 { get; set; }

    public string? RecommendedByEmpName2 { get; set; }

    public string? RecommendedByEmpName3 { get; set; }

    public string? RecommendedByEmpName4 { get; set; }

    public string? RecommendedByEmpName5 { get; set; }

    public string? RecommendedByEmpName6 { get; set; }

    public string? RecommendedByEmpName7 { get; set; }

    public string? RecommendedByEmpName8 { get; set; }

    public string? RecommendedByEmpName9 { get; set; }

    public string? RecommendedByEmpName10 { get; set; }

    public string? RecommendedByEmpName11 { get; set; }

    public int? RecommendedByDeptId { get; set; }

    public string? RecommendedByDeptName { get; set; }

    public string? RecommendedByDeptShtName { get; set; }

    public int? RecommendedBySxnId { get; set; }

    public string? RecommendedBySxnName { get; set; }

    public string? RecommendedBySxnShtName { get; set; }

    public int? RecommendedByLocId { get; set; }

    public string? RecommendedByLocName { get; set; }

    public string? RecommendedByLocShtName { get; set; }

    public string? RecommendedByMobNox { get; set; }

    public string? RecommendedByPlc { get; set; }

    public string? RecommendedByMobNo { get; set; }

    public int? RecommendedByJbtId { get; set; }

    public string? RecommendedByJbtName { get; set; }

    public string? RecommendedByJbtShtName { get; set; }

    public int? FtrApproverEmpIdfk { get; set; }

    public int? ApproverEmpId { get; set; }

    public string? ApproverStaffNo { get; set; }

    public string? ApproverLname { get; set; }

    public string? ApproverFname { get; set; }

    public string? ApproverOnames { get; set; }

    public string? ApproverHrmsName { get; set; }

    public string? ApproverEmpName { get; set; }

    public string? ApproverEmpName1 { get; set; }

    public string? ApproverEmpName2 { get; set; }

    public string? ApproverEmpName3 { get; set; }

    public string? ApproverEmpName4 { get; set; }

    public string? ApproverEmpName5 { get; set; }

    public string? ApproverEmpName6 { get; set; }

    public string? ApproverEmpName7 { get; set; }

    public string? ApproverEmpName8 { get; set; }

    public string? ApproverEmpName9 { get; set; }

    public string? ApproverEmpName10 { get; set; }

    public string? ApproverEmpName11 { get; set; }

    public int? ApproverDeptId { get; set; }

    public string? ApproverDeptName { get; set; }

    public string? ApproverDeptShtName { get; set; }

    public int? ApproverSxnId { get; set; }

    public string? ApproverSxnName { get; set; }

    public string? ApproverSxnShtName { get; set; }

    public int? ApproverLocId { get; set; }

    public string? ApproverLocName { get; set; }

    public string? ApproverLocShtName { get; set; }

    public string? ApproverMobNox { get; set; }

    public string? ApproverPlc { get; set; }

    public string? ApproverMobNo { get; set; }

    public int? ApproverJbtId { get; set; }

    public string? ApproverJbtName { get; set; }

    public string? ApproverJbtShtName { get; set; }

    public int? FtrRequestTypeIdfk { get; set; }

    public int FttIdpk { get; set; }

    public string? FttName { get; set; }

    public string? FttShtName { get; set; }

    public bool? FttActive { get; set; }

    public int? FtrRequestWindowIdfk { get; set; }

    public int FtwIdpk { get; set; }

    public string? Ftwname { get; set; }

    public string? FtwShtName { get; set; }

    public DateTime? FtwStartDate { get; set; }

    public DateTime? FtwEndDate { get; set; }

    public bool FtwOpened { get; set; }

    public bool FtwActive { get; set; }

    public bool FtrRecommended { get; set; }

    public int FtrRecommededByEmpIdfk { get; set; }

    public int FtrApprovedByEmpIdfk { get; set; }

    public string FtrDebitCategory { get; set; } = null!;

    public int FtrCostCenterIdfk { get; set; }

    public string FtrCostCenter { get; set; } = null!;

    public int CctIdpk { get; set; }

    public string CctName { get; set; } = null!;

    public string CctShtName { get; set; } = null!;
}

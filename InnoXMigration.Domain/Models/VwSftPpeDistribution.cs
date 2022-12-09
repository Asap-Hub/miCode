using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftPpeDistribution
{
    public int PddIdpk { get; set; }

    public DateTime? PddDate { get; set; }

    public int? PddPpeTypeIdfk { get; set; }

    public int? PddDeptIdfk { get; set; }

    public decimal? PddQuantityDistributed { get; set; }

    public int? PddSectionIdfk { get; set; }

    public int? PddUnitIdfk { get; set; }

    public int? PddLocationIdfk { get; set; }

    public bool? PddActive { get; set; }

    public string? PddRmks { get; set; }

    public bool PddSigned { get; set; }

    public int FlocIdpk { get; set; }

    public string FlocName { get; set; } = null!;

    public string FlocShtName { get; set; } = null!;

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int FuntIdpk { get; set; }

    public string FuntName { get; set; } = null!;

    public string FuntShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public string SxnCode { get; set; } = null!;

    public string? PddDeletionReason { get; set; }

    public DateTime? PddDeletedOn { get; set; }

    public int? PddCreatedBy { get; set; }

    public int? PddEditedBy { get; set; }

    public DateTime? PddCreationDate { get; set; }

    public DateTime? PddEditedDate { get; set; }

    public int? PddRequestIdfk { get; set; }

    public int RequestId { get; set; }

    public int? RequestEmpId { get; set; }

    public int? RequestGroupId { get; set; }

    public DateTime? RequestApprovedOn { get; set; }

    public string RequestApprovalRmks { get; set; } = null!;

    public bool RequestApproved { get; set; }

    public bool RequestCancelled { get; set; }

    public bool RequestDistributed { get; set; }

    public int RequestPszId { get; set; }

    public string? RequestPszName { get; set; }

    public string? RequestPszShtName { get; set; }

    public int RequestPptId { get; set; }

    public string RequestPtpName { get; set; } = null!;

    public string RequestPtpShtName { get; set; } = null!;

    public int RequestSgpId { get; set; }

    public string RequestSgpName { get; set; } = null!;

    public string RequestSgpShtName { get; set; } = null!;

    public DateTime? RequestSgpDateFormed { get; set; }

    public int RequestDeptId { get; set; }

    public string RequestDeptName { get; set; } = null!;

    public string RequestDeptShtName { get; set; } = null!;

    public int RequestSxnId { get; set; }

    public string RequestSxnName { get; set; } = null!;

    public string RequestSxnShtName { get; set; } = null!;

    public decimal PrqQuantityRequested { get; set; }

    public decimal PrqQuantityDistributed { get; set; }

    public string? RequestStaffNo { get; set; }

    public string? RequestLname { get; set; }

    public string? RequestFnames { get; set; }

    public string RequestOnames { get; set; } = null!;

    public string? RequestEmpName { get; set; }

    public string? RequestEmpName1 { get; set; }

    public string? RequestEmpName5 { get; set; }

    public string? RequestEmpName11 { get; set; }

    public int RequestLocId { get; set; }

    public string RequestLocName { get; set; } = null!;

    public string RequestIntercom { get; set; } = null!;

    public string RequestMobNox { get; set; } = null!;

    public DateTime? PrqDistributedOn { get; set; }

    public string RequestLocShtName { get; set; } = null!;

    public int RequestJbtId { get; set; }

    public string RequestJbtShtName { get; set; } = null!;

    public string RequestJbtName { get; set; } = null!;

    public int? PddEmpDeptIdfk { get; set; }

    public int? PddEmpSectionIdfk { get; set; }

    public int? PddEmpLocIdfk { get; set; }

    public int? EmpDeptId { get; set; }

    public string? EmpDeptName { get; set; }

    public string? EmpDeptShtName { get; set; }

    public string? EmpDeptCode { get; set; }

    public bool? EmpDeptActive { get; set; }

    public int? EmpSxnId { get; set; }

    public string? EmpSxnName { get; set; }

    public string? EmpSxnShtName { get; set; }

    public string? EmpSxnCode { get; set; }

    public bool? EmpSxnActive { get; set; }

    public int? EmpUntId { get; set; }

    public string? EmpUntName { get; set; }

    public string? EmpUntShtName { get; set; }

    public string? EmpUntCode { get; set; }

    public int? EmpLocId { get; set; }

    public string? EmpLocName { get; set; }

    public string? EmpLocShtName { get; set; }

    public bool? LocActive { get; set; }

    public int RqwIdpk { get; set; }

    public string RqwName { get; set; } = null!;

    public string RqwShtName { get; set; } = null!;

    public int CoordEmpId { get; set; }

    public int AcknowEmpId { get; set; }

    public int ApprovEmpId { get; set; }

    public int PrqRequestNo { get; set; }

    public int? UntIdpk { get; set; }

    public int? LocIdpk { get; set; }

    public decimal PrqQuantityRecommended { get; set; }

    public decimal PrqQuantityAcknowledged { get; set; }

    public decimal PrqQuantityApproved { get; set; }

    public string? LocShtName { get; set; }

    public string? UntShtName { get; set; }

    public DateTime? PrqCreationDate { get; set; }
}

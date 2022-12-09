using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftPpeRequest
{
    public int PrqIdpk { get; set; }

    public int PrqRequestNo { get; set; }

    public int? PrqRequesterEmpIdfk { get; set; }

    public int? PrqPpeTypeIdfk { get; set; }

    public int? PrqGroupIdfk { get; set; }

    public int? PrqPpeSizeIdfk { get; set; }

    public decimal PrqQuantityRequested { get; set; }

    public decimal PrqQuantityDistributed { get; set; }

    public DateTime? PrqApprovedOn { get; set; }

    public string PrqApprovalRmks { get; set; } = null!;

    public string PrqCancellationRmks { get; set; } = null!;

    public bool PrqApproved { get; set; }

    public bool PrqCancelled { get; set; }

    public int PrqCancelledByEmpIdfk { get; set; }

    public DateTime? PrqCancelledOn { get; set; }

    public bool PrqSmsSent { get; set; }

    public string PrqDebitCategory { get; set; } = null!;

    public string PrqDebit { get; set; } = null!;

    public string PrqDebitDept { get; set; } = null!;

    public string PrqDebitSection { get; set; } = null!;

    public bool PrqActive { get; set; }

    public string PrqRmks { get; set; } = null!;

    public int PtpIdpk { get; set; }

    public string PtpName { get; set; } = null!;

    public string PtpShtName { get; set; } = null!;

    public bool PtpActive { get; set; }

    public int SgpIdpk { get; set; }

    public string SgpName { get; set; } = null!;

    public string SgpShtName { get; set; } = null!;

    public DateTime? SgpDateFormed { get; set; }

    public bool? SgpActive { get; set; }

    public string? PrqCreatedBy { get; set; }

    public int? PrqEditedBy { get; set; }

    public DateTime? PrqCreationDate { get; set; }

    public DateTime? PrqEditedDate { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string SxnCode { get; set; } = null!;

    public bool SxnActive { get; set; }

    public bool DptActive { get; set; }

    public int RequesterEmpId { get; set; }

    public string? RequesterStaffNo { get; set; }

    public string? RequesterLastname { get; set; }

    public string? RequesterFirstname { get; set; }

    public string RequesterOnames { get; set; } = null!;

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

    public string RequesterIntercom { get; set; } = null!;

    public string RequesterMobNo { get; set; } = null!;

    public int RequesterJbtId { get; set; }

    public string RequesterJbtName { get; set; } = null!;

    public string RequesterJbtShtName { get; set; } = null!;

    public short RequesterGndId { get; set; }

    public string RequesterGndName { get; set; } = null!;

    public string RequesterGndShtName { get; set; } = null!;

    public int CoordEmpId { get; set; }

    public string CoordStaffNo { get; set; } = null!;

    public string CoordLastname { get; set; } = null!;

    public string CoordFirstname { get; set; } = null!;

    public string CoordOnames { get; set; } = null!;

    public string CoordEmpName { get; set; } = null!;

    public string CoordEmpName1 { get; set; } = null!;

    public string CoordEmpName2 { get; set; } = null!;

    public string CoordEmpName3 { get; set; } = null!;

    public string CoordEmpName4 { get; set; } = null!;

    public string CoordEmpName5 { get; set; } = null!;

    public string CoordEmpName6 { get; set; } = null!;

    public string CoordEmpName7 { get; set; } = null!;

    public string CoordEmpName8 { get; set; } = null!;

    public string CoordEmpName9 { get; set; } = null!;

    public string CoordEmpName10 { get; set; } = null!;

    public string CoordEmpName11 { get; set; } = null!;

    public int CoordDeptId { get; set; }

    public string CoordDeptName { get; set; } = null!;

    public string CoordDeptShtName { get; set; } = null!;

    public int CoordSxnId { get; set; }

    public string CoordSxnName { get; set; } = null!;

    public string CoordSxnShtName { get; set; } = null!;

    public int CoordLocId { get; set; }

    public string CoordLocName { get; set; } = null!;

    public string CoordLocShtName { get; set; } = null!;

    public string CoordMobNox { get; set; } = null!;

    public string CoordIntercom { get; set; } = null!;

    public string CoordMobNo { get; set; } = null!;

    public int CoordJbtId { get; set; }

    public string CoordJbtName { get; set; } = null!;

    public string CoordJbtShtName { get; set; } = null!;

    public short CoordGndId { get; set; }

    public string CoordGndName { get; set; } = null!;

    public string CoordGndShtName { get; set; } = null!;

    public int PszIdpk { get; set; }

    public string? PszName { get; set; }

    public string? PszShtName { get; set; }

    public bool PrqDistributed { get; set; }

    public DateTime? PrqDistributedOn { get; set; }

    public DateTime? PrqScheduledCollectionDate { get; set; }

    public int AcknowEmpId { get; set; }

    public string AcknowStaffNo { get; set; } = null!;

    public string AcknowLastname { get; set; } = null!;

    public string AcknowFirstname { get; set; } = null!;

    public string AcknowOnames { get; set; } = null!;

    public string AcknowEmpName { get; set; } = null!;

    public string AcknowEmpName1 { get; set; } = null!;

    public string AcknowEmpName2 { get; set; } = null!;

    public string AcknowEmpName3 { get; set; } = null!;

    public string AcknowEmpName4 { get; set; } = null!;

    public string AcknowEmpName5 { get; set; } = null!;

    public string AcknowEmpName6 { get; set; } = null!;

    public string AcknowEmpName7 { get; set; } = null!;

    public string AcknowEmpName8 { get; set; } = null!;

    public string AcknowEmpName9 { get; set; } = null!;

    public string AcknowEmpName10 { get; set; } = null!;

    public string AcknowEmpName11 { get; set; } = null!;

    public int AcknowDeptId { get; set; }

    public string AcknowDeptName { get; set; } = null!;

    public string AcknowDeptShtName { get; set; } = null!;

    public int AcknowSxnId { get; set; }

    public string AcknowSxnName { get; set; } = null!;

    public string AcknowSxnShtName { get; set; } = null!;

    public int AcknowLocId { get; set; }

    public string AcknowLocName { get; set; } = null!;

    public string AcknowLocShtName { get; set; } = null!;

    public string AcknowMobNox { get; set; } = null!;

    public string AcknowIntercom { get; set; } = null!;

    public string AcknowMobNo { get; set; } = null!;

    public int AcknowJbtId { get; set; }

    public string AcknowJbtName { get; set; } = null!;

    public string AcknowJbtShtName { get; set; } = null!;

    public short AcknowGndId { get; set; }

    public string AcknowGndName { get; set; } = null!;

    public string AcknowGndShtName { get; set; } = null!;

    public int ApprovEmpId { get; set; }

    public string ApprovStaffNo { get; set; } = null!;

    public string ApprovLastname { get; set; } = null!;

    public string ApprovFirstname { get; set; } = null!;

    public string ApprovOnames { get; set; } = null!;

    public string ApprovEmpName { get; set; } = null!;

    public string ApprovEmpName1 { get; set; } = null!;

    public string ApprovEmpName2 { get; set; } = null!;

    public string ApprovEmpName3 { get; set; } = null!;

    public string ApprovEmpName4 { get; set; } = null!;

    public string ApprovEmpName5 { get; set; } = null!;

    public string ApprovEmpName6 { get; set; } = null!;

    public string ApprovEmpName7 { get; set; } = null!;

    public string ApprovEmpName8 { get; set; } = null!;

    public string ApprovEmpName9 { get; set; } = null!;

    public string ApprovEmpName10 { get; set; } = null!;

    public string ApprovEmpName11 { get; set; } = null!;

    public int ApprovDeptId { get; set; }

    public string ApprovDeptName { get; set; } = null!;

    public string ApprovDeptShtName { get; set; } = null!;

    public int ApprovSxnId { get; set; }

    public string ApprovSxnName { get; set; } = null!;

    public string ApprovSxnShtName { get; set; } = null!;

    public int ApprovLocId { get; set; }

    public string ApprovLocName { get; set; } = null!;

    public string ApprovLocShtName { get; set; } = null!;

    public string ApprovMobNox { get; set; } = null!;

    public string ApprovIntercom { get; set; } = null!;

    public string ApprovMobNo { get; set; } = null!;

    public int ApprovJbtId { get; set; }

    public string ApprovJbtName { get; set; } = null!;

    public string ApprovJbtShtName { get; set; } = null!;

    public short ApprovGndId { get; set; }

    public string ApprovGndName { get; set; } = null!;

    public string ApprovGndShtName { get; set; } = null!;

    public bool PrqRecommended { get; set; }

    public bool PrqAcknowledged { get; set; }

    public decimal PrqQuantityRecommended { get; set; }

    public decimal PrqQuantityAcknowledged { get; set; }

    public decimal PrqQuantityApproved { get; set; }

    public int? PrqRequestWindowIdfk { get; set; }

    public int RqwIdpk { get; set; }

    public string RqwName { get; set; } = null!;

    public string RqwShtName { get; set; } = null!;

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool RqwOpened { get; set; }

    public bool RqwActive { get; set; }
}

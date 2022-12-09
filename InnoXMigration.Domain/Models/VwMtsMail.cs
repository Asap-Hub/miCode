using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsMail
{
    public int MtrIdpk { get; set; }

    public DateTime? MtrDocDate { get; set; }

    public DateTime? MtrRecDate { get; set; }

    public DateTime? MtrOutDate { get; set; }

    public string MtrFileNo { get; set; } = null!;

    public string MtrSubject { get; set; } = null!;

    public string MtrSummaryContent { get; set; } = null!;

    public int? MtrDocSrcIdfk { get; set; }

    public int? MtrFwdFromIdfk { get; set; }

    public string MtrIncomingNotes { get; set; } = null!;

    public string MtrOutgoingMinutes { get; set; } = null!;

    public string MtrRmks { get; set; } = null!;

    public int? MtrCreatedBy { get; set; }

    public int? MtrEditedBy { get; set; }

    public DateTime? MtrCreationDate { get; set; }

    public DateTime? MtrEditedDate { get; set; }

    public int DocSrcItemIdpk { get; set; }

    public string DocSrcItemName { get; set; } = null!;

    public string DocSrcItemShtName { get; set; } = null!;

    public int FwdFromItemIdpk { get; set; }

    public string FwdFromItemName { get; set; } = null!;

    public string FwdFromItemShtName { get; set; } = null!;

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public int? UsaIdpk { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string MtrOutTo { get; set; } = null!;

    public string MtrCc { get; set; } = null!;

    public string MtrBcc { get; set; } = null!;

    public int? DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public string? DtpCode { get; set; }

    public bool? DtpActive { get; set; }

    public string? DtpRmks { get; set; }

    public int? DcsIdpk { get; set; }

    public string? DcsName { get; set; }

    public string? DcsShtname { get; set; }

    public bool? DcsActive { get; set; }

    public string? DcsRmks { get; set; }

    public int? DscIdpk { get; set; }

    public string? DscName { get; set; }

    public string? DscShtName { get; set; }

    public bool? DscActive { get; set; }

    public string? DscRmks { get; set; }

    public int? MtrNum { get; set; }

    public string MtrShareWith { get; set; } = null!;

    public string? MtrType { get; set; }

    public int? SignedByEmpId { get; set; }

    public string SignedByStaffNo { get; set; } = null!;

    public string? SignedByLname { get; set; }

    public string? SignedByFname { get; set; }

    public string? SignedByOnames { get; set; }

    public string SignedByEmpName { get; set; } = null!;

    public string? SigneByEmpname1 { get; set; }

    public string? SignedByEmpName2 { get; set; }

    public int SignedByDptId { get; set; }

    public string SignedByDptName { get; set; } = null!;

    public string SignedByDptShtName { get; set; } = null!;

    public int SignedById { get; set; }

    public string SignedBySxnName { get; set; } = null!;

    public string SignedBySxnShtName { get; set; } = null!;

    public int SignedByUntId { get; set; }

    public string SignedByUntName { get; set; } = null!;

    public string SignedByUntShtName { get; set; } = null!;

    public int SignedByLocId { get; set; }

    public string SignedByLocName { get; set; } = null!;

    public string SignedByLocShtName { get; set; } = null!;

    public int SignedByJbtId { get; set; }

    public string SignedByJbtName { get; set; } = null!;

    public string SignedByJbtShtName { get; set; } = null!;

    public int MtrSignedByIdfk { get; set; }

    public int MtrSignedForIdfk { get; set; }

    public int SignedForEmpId { get; set; }

    public string SignedForStaffNo { get; set; } = null!;

    public string SignedForLname { get; set; } = null!;

    public string SignedForFname { get; set; } = null!;

    public string SignedForOnames { get; set; } = null!;

    public string SignedForEmpName { get; set; } = null!;

    public string SignedForEmpname1 { get; set; } = null!;

    public string SignedForEmpName2 { get; set; } = null!;

    public int SignedForDptId { get; set; }

    public string SignedForDptName { get; set; } = null!;

    public string SignedForDptShtName { get; set; } = null!;

    public int SignedForId { get; set; }

    public string SignedForSxnName { get; set; } = null!;

    public string SignedForSxnShtName { get; set; } = null!;

    public int SignedForUntId { get; set; }

    public string SignedForUntName { get; set; } = null!;

    public string SignedForUntShtName { get; set; } = null!;

    public int SignedForLocId { get; set; }

    public string SignedForLocName { get; set; } = null!;

    public string SignedForLocShtName { get; set; } = null!;

    public int SignedForJbtId { get; set; }

    public string SignedForJbtName { get; set; } = null!;

    public string SignedForJbtShtName { get; set; } = null!;

    public int? DocSrcUserItemIdpkx { get; set; }

    public int? DocSrcItemIdpkx { get; set; }

    public string? DocSrcItemNamex { get; set; }

    public string? DocSrcItemShtNamex { get; set; }

    public bool? MtrDispatched { get; set; }

    public bool? MtrHasAttachment { get; set; }

    public DateTime? MtrSignDate { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? EmpIntercom { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? SignedByPlc { get; set; }

    public bool? MtrIncoming { get; set; }

    public bool? MtrOutgoing { get; set; }

    public bool MtrRegistered { get; set; }

    public int? DcuIdpk { get; set; }

    public string? DcuName { get; set; }

    public string? DcuShtName { get; set; }

    public string? DcuCode { get; set; }

    public int? MtrDocUnitIdfk { get; set; }

    public DateTime? Expr1 { get; set; }

    public int? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? Expr4 { get; set; }

    public string? Expr5 { get; set; }

    public int? Expr6 { get; set; }

    public string? Expr7 { get; set; }

    public string? Expr8 { get; set; }

    public int? Expr9 { get; set; }

    public string? Expr10 { get; set; }

    public string? Expr11 { get; set; }

    public int? Expr12 { get; set; }

    public string? Expr13 { get; set; }

    public string? Expr14 { get; set; }

    public string? Expr15 { get; set; }

    public bool? Expr16 { get; set; }

    public bool? Expr17 { get; set; }

    public bool Expr18 { get; set; }

    public int? Expr19 { get; set; }

    public string? Expr20 { get; set; }

    public string? Expr21 { get; set; }

    public string? Expr22 { get; set; }

    public int? Expr23 { get; set; }

    public bool MtrLocked { get; set; }

    public int MtrLockedByIdfk { get; set; }

    public DateTime? MtrLockedDate { get; set; }

    public int MtrUnlockedByIdfk { get; set; }

    public DateTime? MtrUnlockedDate { get; set; }
}

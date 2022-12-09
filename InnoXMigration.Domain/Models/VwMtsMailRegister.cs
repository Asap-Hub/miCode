using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsMailRegister
{
    public int MrgIdpk { get; set; }

    public int? MrgEmpIdfk { get; set; }

    public string? MrgRecipient { get; set; }

    public DateTime? MrgDocDate { get; set; }

    public DateTime? MrgRecDate { get; set; }

    public DateTime? MrgOutDate { get; set; }

    public string MrgFileNo { get; set; } = null!;

    public string MrgSubject { get; set; } = null!;

    public int? MrgDocSrcIdfk { get; set; }

    public int? MrgFwdFromIdfk { get; set; }

    public string MrgIncomingNotes { get; set; } = null!;

    public string MrgOutgoingMinutes { get; set; } = null!;

    public string MrgRmks { get; set; } = null!;

    public int? MrgCreatedBy { get; set; }

    public int? MrgEditedBy { get; set; }

    public DateTime? MrgCreationDate { get; set; }

    public DateTime? MrgEditedDate { get; set; }

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

    public int? MrgNum { get; set; }

    public string MrgShareWith { get; set; } = null!;

    public string? MrgType { get; set; }

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

    public int MrgSignedByIdfk { get; set; }

    public int MrgSignedForIdfk { get; set; }

    public int? DocSrcUserItemIdpkx { get; set; }

    public int? DocSrcItemIdpkx { get; set; }

    public string? DocSrcItemNamex { get; set; }

    public string? DocSrcItemShtNamex { get; set; }

    public bool? MrgDispatched { get; set; }

    public bool? MrgHasAttachment { get; set; }

    public DateTime? MrgSignDate { get; set; }

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

    public bool MrgIsStaff { get; set; }
}

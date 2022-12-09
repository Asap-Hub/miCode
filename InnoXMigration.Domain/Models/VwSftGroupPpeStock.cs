using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftGroupPpeStock
{
    public int GpsIdpk { get; set; }

    public DateTime? GpsDate { get; set; }

    public bool? GpsSigned { get; set; }

    public int? GpsBatchNo { get; set; }

    public int? GpsGroupIdfk { get; set; }

    public int? GpsIssuerEmpIdfk { get; set; }

    public int? GpsReceiverEmpIdfk { get; set; }

    public bool? GpsActive { get; set; }

    public string? GpsRmks { get; set; }

    public int IssuerEmpId { get; set; }

    public string? IssuerStaffNo { get; set; }

    public string? IssuerLname { get; set; }

    public string? IssuerFname { get; set; }

    public string? IssuerEmpName { get; set; }

    public string? IssuerEmpName2 { get; set; }

    public string? IssuerEmpName16 { get; set; }

    public short IssuerGndId { get; set; }

    public string IssuerGndName { get; set; } = null!;

    public string IssuerGndShtName { get; set; } = null!;

    public int IssuerDptId { get; set; }

    public string IssuerDptName { get; set; } = null!;

    public string IssuerDptShtName { get; set; } = null!;

    public int IssuerSxnId { get; set; }

    public string IssuerSxnName { get; set; } = null!;

    public string IssuerSxnShtName { get; set; } = null!;

    public int IssuerUntId { get; set; }

    public string IssuerUntName { get; set; } = null!;

    public string IssuerUntShtName { get; set; } = null!;

    public int IssuerLocId { get; set; }

    public string IssuerLocName { get; set; } = null!;

    public string IssuerLocShtName { get; set; } = null!;

    public string IssuerMobNo { get; set; } = null!;

    public string IssuerMobNox { get; set; } = null!;

    public string IssuerIntercom { get; set; } = null!;

    public int IssuerJbtId { get; set; }

    public string IssuerJbtName { get; set; } = null!;

    public string IssuerJbtShtName { get; set; } = null!;

    public int ReceiverEmpId { get; set; }

    public string? ReceiverStaffNo { get; set; }

    public string? ReceiverLname { get; set; }

    public string? ReceiverFname { get; set; }

    public string? ReceiverEmpName { get; set; }

    public string? ReceiverEmpName2 { get; set; }

    public string? ReceiverEmpName16 { get; set; }

    public short ReceiverGndId { get; set; }

    public string ReceiverGndName { get; set; } = null!;

    public string ReceiverGndShtName { get; set; } = null!;

    public int ReceiverDptId { get; set; }

    public string ReceiverDptName { get; set; } = null!;

    public string ReceiverDptShtName { get; set; } = null!;

    public int ReceiverSxnId { get; set; }

    public string ReceiverSxnName { get; set; } = null!;

    public string ReceiverSxnShtName { get; set; } = null!;

    public int ReceiverUntId { get; set; }

    public string ReceiverUntName { get; set; } = null!;

    public string ReceiverUntShtName { get; set; } = null!;

    public int ReceiverLocId { get; set; }

    public string ReceiverLocName { get; set; } = null!;

    public string ReceiverLocShtName { get; set; } = null!;

    public string ReceiverMobNo { get; set; } = null!;

    public string ReceiverMobNox { get; set; } = null!;

    public string ReceiverIntercom { get; set; } = null!;

    public int ReceiverJbtId { get; set; }

    public string ReceiverJbtName { get; set; } = null!;

    public string ReceiverJbtShtName { get; set; } = null!;

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime SgpDateFormed { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int? GpsRequestWindowIdfk { get; set; }

    public int RqwIdpk { get; set; }

    public string? RqwName { get; set; }

    public string? RqwShtName { get; set; }

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool? RqwOpened { get; set; }

    public bool? RqwActive { get; set; }

    public string GpsSource { get; set; } = null!;
}

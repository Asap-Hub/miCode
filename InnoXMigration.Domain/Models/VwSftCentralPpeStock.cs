using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftCentralPpeStock
{
    public int CpsIdpk { get; set; }

    public DateTime? CpsDate { get; set; }

    public bool? CpsSigned { get; set; }

    public string? CpsBatchNo { get; set; }

    public int? CpsIssuerEmpIdfk { get; set; }

    public int? CpsReceiverEmpIdfk { get; set; }

    public bool? CpsActive { get; set; }

    public string? CpsRmks { get; set; }

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

    public int? CpsRequestWindowIdfk { get; set; }

    public int RqwIdpk { get; set; }

    public string? RqwName { get; set; }

    public string? RqwShtName { get; set; }

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool? RqwOpened { get; set; }

    public bool? RqwActive { get; set; }

    public string? CpsSource { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurSymbol { get; set; }

    public bool? CurForeign { get; set; }

    public byte? CurOrder { get; set; }

    public decimal? CpsTotalCost { get; set; }

    public int? CpsCurrencyIdfk { get; set; }
}

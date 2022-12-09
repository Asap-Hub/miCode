using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftCentralPpeStockDetail
{
    public int CpdIdpk { get; set; }

    public int? CpsRequestWindowIdfk { get; set; }

    public string? CpdBatchNo { get; set; }

    public int RqwIdpk { get; set; }

    public int CpsIdpk { get; set; }

    public string? CpsBatchNo { get; set; }

    public bool? CpsSigned { get; set; }

    public bool? RqwActive { get; set; }

    public bool? CpdActive { get; set; }

    public int? CpdPpeIdfk { get; set; }

    public int? CpdPpeSizeIdfk { get; set; }

    public int PszIdpk { get; set; }

    public string? PszName { get; set; }

    public string? PszShtName { get; set; }

    public int PtpIdpk { get; set; }

    public string? PtpName { get; set; }

    public string? PtpShtName { get; set; }

    public DateTime? CpsDate { get; set; }

    public int IssuerEmpId { get; set; }

    public string? IssuerStaffNo { get; set; }

    public string? IssuerEmpName { get; set; }

    public string? IssuerEmpName16 { get; set; }

    public int ReceiverEmpId { get; set; }

    public string? ReceiverStaffNo { get; set; }

    public string? ReceiverEmpName { get; set; }

    public string? ReceiverEmpName16 { get; set; }

    public string? CpdRmks { get; set; }

    public string? RqwName { get; set; }

    public string? RqwShtName { get; set; }

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool? RqwOpened { get; set; }

    public string? CpsRmks { get; set; }

    public decimal? CpdQuantityReceived { get; set; }

    public decimal? CpdQuantityIssuedToIndividuals { get; set; }

    public decimal? CpdCentralQuantityLeft { get; set; }

    public decimal? CpdQuantityLeftForGroups { get; set; }

    public int? CpdCentralStockIdfk { get; set; }

    public decimal? CpdQuantityIssuedToGroups { get; set; }

    public bool? PszActive { get; set; }

    public bool? PtpActive { get; set; }

    public decimal? CpdTotalCost { get; set; }

    public int? CpdCurrencyIdfk { get; set; }

    public int? CurIdpk { get; set; }

    public string? CurName { get; set; }

    public string? CurSymbol { get; set; }

    public decimal? CpsTotalCost { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }
}

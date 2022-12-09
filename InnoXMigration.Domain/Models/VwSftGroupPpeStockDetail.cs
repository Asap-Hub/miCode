using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftGroupPpeStockDetail
{
    public int GpdIdpk { get; set; }

    public int? GpsRequestWindowIdfk { get; set; }

    public int RqwIdpk { get; set; }

    public int GpsIdpk { get; set; }

    public int? GpsBatchNo { get; set; }

    public bool? GpsSigned { get; set; }

    public bool? RqwActive { get; set; }

    public bool? GpdActive { get; set; }

    public int? GpdGroupStockIdfk { get; set; }

    public int? GpdPpeIdfk { get; set; }

    public int? GpdPpeSizeIdfk { get; set; }

    public decimal GpdQuantity { get; set; }

    public decimal? GpdQuantityIssued { get; set; }

    public decimal? GpdQuantityLeft { get; set; }

    public int PszIdpk { get; set; }

    public string? PszName { get; set; }

    public string? PszShtName { get; set; }

    public int PtpIdpk { get; set; }

    public string? PtpName { get; set; }

    public string? PtpShtName { get; set; }

    public DateTime? GpsDate { get; set; }

    public int IssuerEmpId { get; set; }

    public string? IssuerStaffNo { get; set; }

    public string? IssuerEmpName { get; set; }

    public string? IssuerEmpName16 { get; set; }

    public int ReceiverEmpId { get; set; }

    public string? ReceiverStaffNo { get; set; }

    public string? ReceiverEmpName { get; set; }

    public string? ReceiverEmpName16 { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime SgpDateFormed { get; set; }

    public int? GroupDptId { get; set; }

    public string? GroupDptName { get; set; }

    public string? GroupDptShtName { get; set; }

    public int? GroupLocId { get; set; }

    public string? GroupLocName { get; set; }

    public string? GroupLocShtName { get; set; }

    public int? GroupAreId { get; set; }

    public string? GroupAreName { get; set; }

    public string? GroupAreShtName { get; set; }

    public string? GpdRmks { get; set; }

    public string? RqwName { get; set; }

    public string? RqwShtName { get; set; }

    public DateTime? RqwStartDate { get; set; }

    public DateTime? RqwEndDate { get; set; }

    public bool? RqwOpened { get; set; }

    public string? GpsRmks { get; set; }

    public string? GpdBatchNo { get; set; }

    public decimal GpdQuantityIssuedToIndividuals { get; set; }

    public decimal GpdQuantityReceived { get; set; }

    public string GpdDeletionReason { get; set; } = null!;

    public DateTime? GpdDeletedOn { get; set; }

    public int GpdRequestWindowIdfk { get; set; }
}

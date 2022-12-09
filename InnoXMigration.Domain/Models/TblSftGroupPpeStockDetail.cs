using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupPpeStockDetail
{
    public int GpdIdpk { get; set; }

    public int? GpdGroupStockIdfk { get; set; }

    public int? GpdPpeIdfk { get; set; }

    public int? GpdPpeSizeIdfk { get; set; }

    public int? GpdRequestWindowIdfk { get; set; }

    public string? GpdBatchNo { get; set; }

    public decimal? GpdQuantity { get; set; }

    public decimal? GpdQuantityIssued { get; set; }

    public decimal? GpdQuantityIssuedToIndividuals { get; set; }

    public decimal? GpdQuantityReceived { get; set; }

    public string? GpdDeletionReason { get; set; }

    public DateTime? GpdDeletedOn { get; set; }

    public bool? GpdActive { get; set; }

    public string? GpdRmks { get; set; }

    public int? GpdCreatedBy { get; set; }

    public int? GpdEditedBy { get; set; }

    public DateTime? GpdCreationDate { get; set; }

    public DateTime? GpdEditedDate { get; set; }
}

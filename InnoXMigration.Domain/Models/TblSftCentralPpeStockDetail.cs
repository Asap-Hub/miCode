using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftCentralPpeStockDetail
{
    public int CpdIdpk { get; set; }

    public int? CpdCentralStockIdfk { get; set; }

    public int? CpdRequestWindowIdfk { get; set; }

    public string? CpdBatchNo { get; set; }

    public int? CpdPpeIdfk { get; set; }

    public int? CpdPpeSizeIdfk { get; set; }

    public decimal? CpdQuantityReceived { get; set; }

    public decimal? CpdQuantityIssuedToGroups { get; set; }

    public decimal? CpdQuantityIssuedToIndividuals { get; set; }

    public string? CpdDeletionReason { get; set; }

    public decimal? CpdTotalCost { get; set; }

    public int? CpdCurrencyIdfk { get; set; }

    public bool? CpdActive { get; set; }

    public string? CpdRmks { get; set; }

    public int? CpdCreatedBy { get; set; }

    public int? CpdEditedBy { get; set; }

    public DateTime? CpdDeletedOn { get; set; }

    public DateTime? CpdCreationDate { get; set; }

    public DateTime? CpdEditedDate { get; set; }
}

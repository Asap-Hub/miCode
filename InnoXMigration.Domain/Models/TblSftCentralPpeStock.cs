using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftCentralPpeStock
{
    public int CpsIdpk { get; set; }

    public DateTime? CpsDate { get; set; }

    public int? CpsIssuerEmpIdfk { get; set; }

    public int? CpsReceiverEmpIdfk { get; set; }

    public int? CpsRequestWindowIdfk { get; set; }

    public string? CpsSource { get; set; }

    public string? CpsBatchNo { get; set; }

    public bool? CpsSigned { get; set; }

    public string? CpsDeletionReason { get; set; }

    public DateTime? CpsDeletedOn { get; set; }

    public decimal? CpsTotalCost { get; set; }

    public int? CpsCurrencyIdfk { get; set; }

    public bool? CpsActive { get; set; }

    public string? CpsRmks { get; set; }

    public int? CpsCreatedBy { get; set; }

    public int? CpsEditedBy { get; set; }

    public DateTime? CpsSignedOffOn { get; set; }

    public DateTime? CpsCreationDate { get; set; }

    public DateTime? CpsEditedDate { get; set; }
}

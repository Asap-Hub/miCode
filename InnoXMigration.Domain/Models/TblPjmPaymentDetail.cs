using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmPaymentDetail
{
    public int PdtIdpk { get; set; }

    public DateTime? PdtDate { get; set; }

    public int? PdtProjectIdfk { get; set; }

    public int? PdtContractorIdfk { get; set; }

    public decimal? PdtAmount { get; set; }

    public int? PdtCurrencyIdfk { get; set; }

    public int? PdtModeOfPaymentIdfk { get; set; }

    public int? PdtProjModuleIdfk { get; set; }

    public bool? PdtActive { get; set; }

    public string? PdtRmks { get; set; }

    public int? PdtCreatedBy { get; set; }

    public int? PdtEditedBy { get; set; }

    public DateTime? PdtCreationDate { get; set; }

    public DateTime? PdtEditedDate { get; set; }
}

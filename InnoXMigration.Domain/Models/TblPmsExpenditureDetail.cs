using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmsExpenditureDetail
{
    public int EdtIdpk { get; set; }

    public DateTime? EdtDate { get; set; }

    public int? EdtProjectIdfk { get; set; }

    public string? EdtExpendtureType { get; set; }

    public string? EdtExpenditureCategory { get; set; }

    public int? EdtContractorIdfk { get; set; }

    public int? EdtModuleIdfk { get; set; }

    public int? EdtModeOfPaymentIdfk { get; set; }

    public decimal? EdtAmount { get; set; }

    public int? EdtCurrencyIdfk { get; set; }

    public bool? EdtContractValue { get; set; }

    public bool? EdtActive { get; set; }

    public string? EdtRmks { get; set; }

    public int? EdtCreatedBy { get; set; }

    public int? EdtEditedBy { get; set; }

    public DateTime? EdtCreationDate { get; set; }

    public DateTime? EdtEditedDate { get; set; }
}

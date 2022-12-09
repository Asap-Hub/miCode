using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenCompanyDetailsx
{
    public int CdtIdpk { get; set; }

    public string? CdtName { get; set; }

    public string? CdtTradingName { get; set; }

    public string? CdtTinNo { get; set; }

    public string? CdtPensionEployerCode { get; set; }

    public string? CdtRegistrationNo { get; set; }

    public string? CdtTaxCalculationMethod { get; set; }

    public int? CdtCreatedBy { get; set; }

    public DateTime? CdtCreationDate { get; set; }
}

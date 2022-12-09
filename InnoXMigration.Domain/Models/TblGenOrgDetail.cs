using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenOrgDetail
{
    public int OdtIdpk { get; set; }

    public DateTime? OdtDate { get; set; }

    public string? OdtName { get; set; }

    public string? OdtShtName { get; set; }

    public string? OdtAddress { get; set; }

    public string? OdtCeosalutation { get; set; }

    public string? OdtCeoShtSalutation { get; set; }

    public string? OdtTel1 { get; set; }

    public string? OdtTel2 { get; set; }

    public string? OdtFax { get; set; }

    public string? OdtEmail { get; set; }

    public string? OdtRemarks { get; set; }

    public int? OdtCreatedBy { get; set; }

    public int? OdtEditedBy { get; set; }

    public DateTime? OdtCreationDate { get; set; }

    public DateTime? OdtEditedDate { get; set; }
}

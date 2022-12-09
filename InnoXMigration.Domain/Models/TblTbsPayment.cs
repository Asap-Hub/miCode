using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsPayment
{
    public int PmtIdpk { get; set; }

    public int? PmtCustIdfk { get; set; }

    public DateTime? PmtDate { get; set; }

    public double? PmtAmtGhc { get; set; }

    public double? PmtAmtUsd { get; set; }

    public string? PmtRmks { get; set; }

    public int? PmtEditedBy { get; set; }

    public DateTime? PmtEditedDate { get; set; }

    public int? PmtCreatedBy { get; set; }

    public DateTime? PmtCreationDate { get; set; }
}

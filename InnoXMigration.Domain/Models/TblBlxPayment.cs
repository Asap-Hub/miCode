using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxPayment
{
    public int FbpmIdpk { get; set; }

    public int? FbpmCustIdfk { get; set; }

    public DateTime? FbpmDate { get; set; }

    public double? FbpmAmtGhc { get; set; }

    public double? FbpmAmtUsd { get; set; }

    public string? FbpmRmks { get; set; }

    public int? FbpmEditedBy { get; set; }

    public DateTime? FbpmEditedDate { get; set; }

    public int? FbpmCreatedBy { get; set; }

    public DateTime? FbpmCreationDate { get; set; }
}

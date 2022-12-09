using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenBankandBranchesx
{
    public int FbnbIdpk { get; set; }

    public int? FbnbBankIdfk { get; set; }

    public int? FbnbBranchIdfk { get; set; }

    public bool? FbnbActive { get; set; }

    public string? FbnbRmks { get; set; }

    public int? FbnbCreatedBy { get; set; }

    public int? FbnbEditedBy { get; set; }

    public DateTime? FbnbCreationDate { get; set; }

    public DateTime? FbnbEditedDate { get; set; }
}

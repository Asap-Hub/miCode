using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxPostBill
{
    public int FpblIdpk { get; set; }

    public short? FpblCustIdfk { get; set; }

    public string? FpblCategory { get; set; }

    public int? FpblBillNameIdfk { get; set; }

    public string? FpblActivity { get; set; }

    public string? FpblRmks { get; set; }

    public short? FpblCreatedBy { get; set; }

    public DateTime? FpblCreationDate { get; set; }
}

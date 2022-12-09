using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsPostBill
{
    public int PblIdpk { get; set; }

    public short? PblCustIdfk { get; set; }

    public string? PblCategory { get; set; }

    public int? PblBillNameIdfk { get; set; }

    public string? PblActivity { get; set; }

    public string? PblRmks { get; set; }

    public short? PblCreatedBy { get; set; }

    public DateTime? PblCreationDate { get; set; }
}

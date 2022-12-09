using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxSignBill
{
    public int FsnbIdpk { get; set; }

    public DateTime? FsnbDate { get; set; }

    public int? FsnbEmpIdfk { get; set; }

    public string? FsnbBillName { get; set; }

    public string? FsnbBillTitle { get; set; }

    public string? FsnbMobNo { get; set; }

    public string? FsnbRmks { get; set; }

    public int? FsnbCreatedBy { get; set; }

    public int? FsnbEditedBy { get; set; }

    public DateTime? FsnbCreationDate { get; set; }

    public DateTime? FsnbEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxSignBill
{
    public int FsnbIdpk { get; set; }

    public int? FsnbEmpIdfk { get; set; }

    public string? FsnbBillName { get; set; }

    public string? FsnbBillTitle { get; set; }

    public DateTime? FsnbDate { get; set; }

    public string? FsnbRmks { get; set; }

    public string? SignedByStaffNo { get; set; }

    public string? SignedByName { get; set; }

    public string SignedByDept { get; set; } = null!;

    public string SignedByShtDept { get; set; } = null!;

    public string SignedBySection { get; set; } = null!;

    public string SignedByShtSection { get; set; } = null!;

    public string SignedByJobTitle { get; set; } = null!;

    public string SignedByShtJobTitle { get; set; } = null!;

    public string? FsnbMobNo { get; set; }
}

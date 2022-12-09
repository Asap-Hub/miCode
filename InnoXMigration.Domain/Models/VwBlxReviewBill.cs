using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxReviewBill
{
    public int FrvbIdpk { get; set; }

    public DateTime? FrvbDate { get; set; }

    public string? FrvbBillName { get; set; }

    public string? FrvbBillTitle { get; set; }

    public int? FrvbEmpIdfk { get; set; }

    public string? FrvbRmks { get; set; }

    public string? ReviewedByStaffNo { get; set; }

    public string ReviewedByDept { get; set; } = null!;

    public string ReviewedByShtDept { get; set; } = null!;

    public string ReviewedBySection { get; set; } = null!;

    public string ReviewedByShtSection { get; set; } = null!;

    public string? ReviewedByName { get; set; }

    public string ReviewedByJobTitle { get; set; } = null!;

    public string? ReviewedByShtJobTitle { get; set; }

    public string? FrvbMobNo { get; set; }
}

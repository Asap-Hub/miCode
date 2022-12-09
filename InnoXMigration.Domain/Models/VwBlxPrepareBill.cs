using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxPrepareBill
{
    public int FprbIdpk { get; set; }

    public DateTime? FprbDate { get; set; }

    public int? FprbEmpIdfk { get; set; }

    public string? FprbBillName { get; set; }

    public string? FprbBillTitle { get; set; }

    public string? FprbRmks { get; set; }

    public string? PreparedByStaffNo { get; set; }

    public string? PreparedByName { get; set; }

    public string PreparedByDept { get; set; } = null!;

    public string PreparedByShtDept { get; set; } = null!;

    public string PreparedBySection { get; set; } = null!;

    public string PreparedByShtSection { get; set; } = null!;

    public string PreparedByJobTitle { get; set; } = null!;

    public string PreparedByShtJobTitle { get; set; } = null!;

    public string? FprbMobNo { get; set; }
}

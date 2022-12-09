using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrCeoHistory
{
    public short CehIdpk { get; set; }

    public DateTime? CehDate { get; set; }

    public bool? CehIsCeo { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? CehRmks { get; set; }

    public bool EmpActive { get; set; }
}

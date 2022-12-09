using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrEmpTest
{
    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOtherNames { get; set; }

    public int? EmpTitleIdfk { get; set; }

    public int TitIdpk { get; set; }

    public string? TitName { get; set; }

    public string? TitShtName { get; set; }

    public bool? TitActive { get; set; }

    public string? EmpName { get; set; }
}

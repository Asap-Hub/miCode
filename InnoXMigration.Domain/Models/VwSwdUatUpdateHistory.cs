using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatUpdateHistory
{
    public int UuhIdpk { get; set; }

    public int? UuhEmpIdfk { get; set; }

    public int? UuhProcessIdfk { get; set; }

    public string? UuhComment { get; set; }

    public string? UuhActionBy { get; set; }

    public string? UuhStatus { get; set; }

    public string? UuhImpact { get; set; }

    public int TspIdpk { get; set; }

    public int? TspProcessNo { get; set; }

    public string? TspTestCase { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public DateTime? UuhCreationDate { get; set; }

    public string JbtShtName { get; set; } = null!;

    public int? TspScenarioIdfk { get; set; }

    public string? UuhRmks { get; set; }
}

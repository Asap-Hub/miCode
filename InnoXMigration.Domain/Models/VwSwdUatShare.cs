using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatShare
{
    public int UshIdpk { get; set; }

    public int? UshScenarioIdfk { get; set; }

    public int? UshEmpIdfk { get; set; }

    public int? DptIdpk { get; set; }

    public int? SxnIdpk { get; set; }

    public int? UntIdpk { get; set; }

    public int? LocIdpk { get; set; }

    public int? JbtIdpk { get; set; }

    public bool? UshAdmin { get; set; }

    public bool? UshTester { get; set; }

    public bool? UshReader { get; set; }

    public bool? UshResolver { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpName16 { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public bool? UshActive { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpMobNox { get; set; }

    public string? EmpIntercom { get; set; }
}

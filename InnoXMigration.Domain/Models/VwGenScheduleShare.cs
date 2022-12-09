using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleShare
{
    public int ScsIdpk { get; set; }

    public int? ScsScheduleIdfk { get; set; }

    public int? ScsEmpIdfk { get; set; }

    public bool? ScsOwner { get; set; }

    public bool? ScsUpdate { get; set; }

    public bool? ScsReader { get; set; }

    public bool? ScsSign { get; set; }

    public string? ScsType { get; set; }

    public bool? ScsRead { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOtherNames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int ScdIdpk { get; set; }

    public string? ScdProjectIdfk { get; set; }

    public string? ScdTask { get; set; }

    public string? ScdTaskDescription { get; set; }

    public DateTime? ScdStartDate { get; set; }

    public DateTime? ScdDueDate { get; set; }

    public DateTime? ScdCompletionDate { get; set; }

    public DateTime? ScdUpdateDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenIssueLogComment
{
    public int IlcIdpk { get; set; }

    public string? IlcComment { get; set; }

    public bool? IlcActive { get; set; }

    public int? IlcCreatedBy { get; set; }

    public int IlgIdpk { get; set; }

    public DateTime? IlgIssueDate { get; set; }

    public DateTime? IlcCreationDate { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int? IlcEmpIdfk { get; set; }

    public int? IlcIssueLogIdfk { get; set; }

    public bool Ilgfixed { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;
}

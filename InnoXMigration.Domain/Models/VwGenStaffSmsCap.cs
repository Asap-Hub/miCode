using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenStaffSmsCap
{
    public int SscIdpk { get; set; }

    public int? SscEmpIdfk { get; set; }

    public int? SscCap { get; set; }

    public bool? SscActive { get; set; }

    public string? SscRmks { get; set; }

    public int? SscCreatedBy { get; set; }

    public int? SscEditedBy { get; set; }

    public DateTime? SscCreationDate { get; set; }

    public DateTime? SscEditedDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? Adname { get; set; }

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

    public int EmpIdpk { get; set; }

    public bool EmpActive { get; set; }

    public string? Expr1 { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }
}

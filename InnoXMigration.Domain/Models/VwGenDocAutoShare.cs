using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenDocAutoShare
{
    public int DasIdpk { get; set; }

    public string? DasEmpIdfk { get; set; }

    public string? DasShareWithEmpIdfk { get; set; }

    public bool DasOwner { get; set; }

    public bool DasReader { get; set; }

    public bool DasPrint { get; set; }

    public bool? DasActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int AstIdpk { get; set; }

    public string AstName { get; set; } = null!;

    public string AstShtName { get; set; } = null!;

    public int PstIdpk { get; set; }

    public string PstName { get; set; } = null!;

    public string PstShtName { get; set; } = null!;

    public int AscIdpk { get; set; }

    public string AscName { get; set; } = null!;

    public string AscShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public bool EmpIsStaff { get; set; }

    public string DasSource { get; set; } = null!;
}

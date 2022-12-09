using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsTemplateAssignment
{
    public int TmaIdpk { get; set; }

    public int? TmaTemplateIdfk { get; set; }

    public int? TmaEmpIdfk { get; set; }

    public bool? TmaActive { get; set; }

    public string? TmaRmks { get; set; }

    public int DtmIdpk { get; set; }

    public string? DtmName { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public bool DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public bool SxnActive { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public bool UntActive { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public bool JbtActive { get; set; }

    public int TmtIdpk { get; set; }

    public string? TmtName { get; set; }

    public string? TmtShtName { get; set; }

    public bool? TmtActive { get; set; }

    public int? DtmTemplateTypeIdfk { get; set; }
}

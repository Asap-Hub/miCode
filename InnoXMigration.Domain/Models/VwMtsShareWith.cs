using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsShareWith
{
    public int SwtIdpk { get; set; }

    public int? SwtMailIdfk { get; set; }

    public int? SwtEmpIdfk { get; set; }

    public int? SwtDocIdfk { get; set; }

    public bool? SwtOwner { get; set; }

    public bool? SwtReader { get; set; }

    public bool? SwtPrint { get; set; }

    public bool? SwtShareDocOnly { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string? SwtType { get; set; }

    public bool? SwtSign { get; set; }

    public string? SwtSharedFrom { get; set; }
}

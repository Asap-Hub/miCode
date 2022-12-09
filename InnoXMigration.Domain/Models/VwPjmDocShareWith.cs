using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmDocShareWith
{
    public int SwtIdpk { get; set; }

    public int? SwtDocDetailIdfk { get; set; }

    public int? SwtEmpIdfk { get; set; }

    public bool? SwtOwner { get; set; }

    public bool? SwtReader { get; set; }

    public bool? SwtPrint { get; set; }

    public bool? SwtShareDocOnly { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? Emplastname { get; set; }

    public string? Empfirstname { get; set; }

    public string Empothernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string? SwtType { get; set; }

    public string EmpLegacyName { get; set; } = null!;

    public bool? SwtSign { get; set; }

    public string? SwtSharedFrom { get; set; }

    public bool? SwtActive { get; set; }

    public bool? SwtRead { get; set; }
}

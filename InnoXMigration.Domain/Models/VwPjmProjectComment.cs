using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmProjectComment
{
    public int PcmIdpk { get; set; }

    public string? PcmComment { get; set; }

    public bool? PcmActive { get; set; }

    public int? PcmCreatedBy { get; set; }

    public int PjrIdpk { get; set; }

    public DateTime? PcmCreationDate { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? Emplastname { get; set; }

    public string? Empfirstname { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int? PcmEmpIdfk { get; set; }

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

    public int? PcmProjectIdfk { get; set; }
}

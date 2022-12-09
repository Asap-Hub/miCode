using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTaskComment
{
    public int TcmIdpk { get; set; }

    public int? TcmEmpIdfk { get; set; }

    public string? TcmComment { get; set; }

    public bool? TcmActive { get; set; }

    public DateTime? TcmCreationDate { get; set; }

    public int? TcmCreatedBy { get; set; }

    public int? TcmEditedBy { get; set; }

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

    public short GndIdpk { get; set; }

    public string GndName { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public int DptIdpk { get; set; }

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

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int OfcIdpk { get; set; }

    public string OfcName { get; set; } = null!;

    public string OfcShtName { get; set; } = null!;

    public int RomIdpk { get; set; }

    public string RomName { get; set; } = null!;

    public string RomShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public int? TcmTaskIdfk { get; set; }
}

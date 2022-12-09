using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbCorrespondent
{
    public int CrdIdpk { get; set; }

    public bool CrdActive { get; set; }

    public int EmpIdpk { get; set; }

    public string EmpStaffNo { get; set; } = null!;

    public string EmpLname { get; set; } = null!;

    public string EmpOnames { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string EmpName1 { get; set; } = null!;

    public string EmpName2 { get; set; } = null!;

    public string CrdName { get; set; } = null!;

    public string CrdRmks { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool EmpActive { get; set; }

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public bool EmpIsStaff { get; set; }

    public string EmpMobNo { get; set; } = null!;

    public string? EmpIntercom { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public DateTime? RetireDate { get; set; }

    public string CrdContactNumbers { get; set; } = null!;
}

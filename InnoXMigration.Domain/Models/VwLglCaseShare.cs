using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglCaseShare
{
    public int CshIdpk { get; set; }

    public int? CshEmpIdfk { get; set; }

    public bool CshOwn { get; set; }

    public bool CshUpdate { get; set; }

    public bool CshRead { get; set; }

    public bool CshLock { get; set; }

    public bool CshSign { get; set; }

    public int EmpIdpk { get; set; }

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

    public int? CshCaseIdfk { get; set; }

    public string CshTask { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string EmpTelNo { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpPersonalEmail { get; set; } = null!;

    public string EmpNickname { get; set; } = null!;

    public string EmpInitials { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpHideMobNo { get; set; }

    public bool EmpShowInTelDirectory { get; set; }

    public bool? CshActive { get; set; }

    public int CseIdpk { get; set; }

    public string CseSubject { get; set; } = null!;

    public string CseShtName { get; set; } = null!;

    public DateTime CseReceivedDate { get; set; }

    public string CseSuitNo { get; set; } = null!;

    public string CseClients { get; set; } = null!;
}

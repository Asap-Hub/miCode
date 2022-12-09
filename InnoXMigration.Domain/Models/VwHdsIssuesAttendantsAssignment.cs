using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHdsIssuesAttendantsAssignment
{
    public int IaaIdpk { get; set; }

    public int? IaaEmpIdfk { get; set; }

    public int? IaaCreatedBy { get; set; }

    public int? IaaEditedBy { get; set; }

    public DateTime? IaaCreationDate { get; set; }

    public DateTime? IaaEditedDate { get; set; }

    public bool? IaaActive { get; set; }

    public string? IaaRmks { get; set; }

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

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int? IaaIssueTypeIdfk { get; set; }

    public int? IaaIssueClassIdfk { get; set; }

    public int? IaaIssueSubClassIdfk { get; set; }

    public int? IaaIssueLocationIdfk { get; set; }

    public bool? IaaAssign { get; set; }

    public bool? IaaUpdate { get; set; }

    public bool? IaaRead { get; set; }

    public bool? IaaManager { get; set; }

    public bool? IaaDirector { get; set; }

    public int IclIdpk { get; set; }

    public string? IclName { get; set; }

    public string? IclShtName { get; set; }

    public int IscIdpk { get; set; }

    public string? IscName { get; set; }

    public string? IscShtName { get; set; }

    public int ItpIdpk { get; set; }

    public string? ItpName { get; set; }

    public string? ItpShtName { get; set; }

    public int IlcIdpk { get; set; }

    public string? IlcName { get; set; }

    public string? IlcShtName { get; set; }
}

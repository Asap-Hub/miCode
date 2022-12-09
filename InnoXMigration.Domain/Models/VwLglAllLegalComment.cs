using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwLglAllLegalComment
{
    public int AlcIdpk { get; set; }

    public int? AlcEmpIdfk { get; set; }

    public int? AlcRecordIdfk { get; set; }

    public string? AlcFrom { get; set; }

    public string? AlcComment { get; set; }

    public bool? AlcActive { get; set; }

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

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public DateTime? AlcCreationDate { get; set; }

    public int? AlcCreatedBy { get; set; }

    public int? AlcEditedBy { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public bool EmpHideMobNo { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;
}

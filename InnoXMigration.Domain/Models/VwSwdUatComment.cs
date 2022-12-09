using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdUatComment
{
    public int UcmIdpk { get; set; }

    public string? UcmComment { get; set; }

    public bool? UcmActive { get; set; }

    public int? UcmCreatedBy { get; set; }

    public DateTime? UcmCreationDate { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int? UcmEmpIdfk { get; set; }

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

    public int? UcmScenarioIdfk { get; set; }

    public int UtsIdpk { get; set; }

    public string? UtsName { get; set; }

    public string? UtsShtName { get; set; }

    public int? UtsModuleIdfk { get; set; }

    public string UtsCode { get; set; } = null!;

    public bool? UtsActive { get; set; }

    public string? UtsRmks { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }
}

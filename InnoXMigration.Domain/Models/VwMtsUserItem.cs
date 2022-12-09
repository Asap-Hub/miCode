using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsUserItem
{
    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName3 { get; set; }

    public bool? UsaSuperUser { get; set; }

    public string? EmpFirstName { get; set; }

    public bool? UsaSeeAllForms { get; set; }

    public string? EmpMobNo { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? GndshtName { get; set; }

    public string? StpShtName { get; set; }

    public string? EmpName2 { get; set; }

    public int UtmIdpk { get; set; }

    public int? UtmUserIdfk { get; set; }

    public int? UtmDocCatIdfk { get; set; }

    public bool? UtmActive { get; set; }

    public int? UtmItemIdfk { get; set; }

    public int? ItmIdpk { get; set; }

    public string Itmname { get; set; } = null!;

    public string ItmShtName { get; set; } = null!;

    public bool? ItmActive { get; set; }

    public string? ItmRmks { get; set; }

    public int? UsaIdpk { get; set; }

    public string? UtmRmks { get; set; }

    public int? DctIdpk { get; set; }

    public string? DctName { get; set; }

    public string? DctShtName { get; set; }

    public bool? DctActive { get; set; }

    public string? DctRmks { get; set; }

    public int? UtmEmpIdfk { get; set; }

    public string? EmpItemDept { get; set; }

    public string? EmpItemDeptShtName { get; set; }

    public string? EmpItemLoc { get; set; }

    public string? EmpItemStaffNo { get; set; }

    public int? EmpItemSxnId { get; set; }

    public string? EmpItemSxnName { get; set; }

    public string? EmpItemSxnShtName { get; set; }
}

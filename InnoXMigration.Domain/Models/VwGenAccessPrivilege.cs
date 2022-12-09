using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenAccessPrivilege
{
    public int ApvIdpk { get; set; }

    public int? ApvUsaIdfk { get; set; }

    public int? ApvFormIdfk { get; set; }

    public bool? ApvInsert { get; set; }

    public bool? ApvRead { get; set; }

    public bool? ApvUpdate { get; set; }

    public bool? ApvPrint { get; set; }

    public bool? ApvDelete { get; set; }

    public int? AfmIdpk { get; set; }

    public string? AfmName { get; set; }

    public string? AfmShtName { get; set; }

    public string? AfmType { get; set; }

    public string? AfmDesc { get; set; }

    public bool? AfmActive { get; set; }

    public bool? AfmVisible { get; set; }

    public int? UsaIdpk { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? UsaPassword { get; set; }

    public bool? UsaChangePassword { get; set; }

    public bool? UsaLoggedIn { get; set; }

    public bool? UsaActive { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public DateTime? EmpDoB { get; set; }

    public bool? EmpVisible { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public bool? SxnActive { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpName { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public bool? UsaSuperUser { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? ApmActive { get; set; }

    public int? UsaDefaultModuleIdfk { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName3 { get; set; }

    public bool? UsaSeeAllForms { get; set; }

    public DateTime? ApvCreationDate { get; set; }

    public string? ApmCode { get; set; }

    public bool? UsaEditIntercom { get; set; }

    public string? AfmCode { get; set; }

    public int? ApvCreatedBy { get; set; }
}

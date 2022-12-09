using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenAccessPrivilegesHistory
{
    public int AphIdpk { get; set; }

    public int? AphUsaIdfk { get; set; }

    public bool? AphInsert { get; set; }

    public bool? AphRead { get; set; }

    public bool? AphUpdate { get; set; }

    public int? AfmIdpk { get; set; }

    public string? AfmName { get; set; }

    public string? AfmShtName { get; set; }

    public string? AfmType { get; set; }

    public string? AfmDesc { get; set; }

    public bool? AfmActive { get; set; }

    public string? AfmRmks { get; set; }

    public DateTime? AfmCreationDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? UsaPassword { get; set; }

    public string? EmpName { get; set; }

    public int? UsaIdpk { get; set; }
}

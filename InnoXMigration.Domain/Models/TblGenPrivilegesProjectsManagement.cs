using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPrivilegesProjectsManagement
{
    public int PpmIdpk { get; set; }

    public int? PpmEmpIdfk { get; set; }

    public bool? PpmDeptAdmin { get; set; }

    public bool? PpmSectionAdmin { get; set; }

    public bool? PpmUnitAdmin { get; set; }

    public string? PpmRmks { get; set; }

    public int? PpmCreatedBy { get; set; }

    public int? PpmEditedBy { get; set; }

    public DateTime? PpmCreationDate { get; set; }

    public DateTime? PpmEditedDate { get; set; }
}

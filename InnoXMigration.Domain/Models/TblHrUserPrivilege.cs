using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrUserPrivilege
{
    public int HupIdpk { get; set; }

    public int? HupEmpIdfk { get; set; }

    public bool? HupSysAdmin { get; set; }

    public bool? HupOrgAdmin { get; set; }

    public bool? HupDeptAdmin { get; set; }

    public bool? HupSectionAdmin { get; set; }

    public bool? HupUnitAdmin { get; set; }

    public bool? HupSupervisor { get; set; }

    public bool? HupManager { get; set; }

    public bool? HupDirector { get; set; }

    public string? HupRmks { get; set; }

    public int? HupCreatedBy { get; set; }

    public int? HupEditedBy { get; set; }

    public DateTime? HupCreationDate { get; set; }

    public DateTime? HupEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftUserPrivilege
{
    public int SupIdpk { get; set; }

    public int? SupEmpIdfk { get; set; }

    public bool? SupSysAdmin { get; set; }

    public bool? SupOrgAdmin { get; set; }

    public bool? SupDeptAdmin { get; set; }

    public bool? SupSectionAdmin { get; set; }

    public bool? SupUnitAdmin { get; set; }

    public bool? SupManager { get; set; }

    public bool? SupDirector { get; set; }

    public bool? SupManageCentralPpeStocks { get; set; }

    public bool? SupSignOffCentralPpeStocks { get; set; }

    public string? SupRmks { get; set; }

    public int? SupCreatedBy { get; set; }

    public int? SupEditedBy { get; set; }

    public DateTime? SupCreationDate { get; set; }

    public DateTime? SupEditedDate { get; set; }
}

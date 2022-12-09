using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPrivilegesSafetyManagement
{
    public int PsmIdpk { get; set; }

    public int? PsmEmpIdfk { get; set; }

    public bool? PsmSysAdmin { get; set; }

    public bool? PsmOrgAdmin { get; set; }

    public bool? PsmDeptAdmin { get; set; }

    public bool? PsmSectionAdmin { get; set; }

    public string? PsmUnitAdmin { get; set; }

    public bool? PsmDirector { get; set; }

    public bool? PsmManager { get; set; }

    public bool? PsmSupervisor { get; set; }

    public bool? PsmRecommendTopics { get; set; }

    public bool? PsmApproveTopics { get; set; }

    public bool? PsmManageCentralPpeStocks { get; set; }

    public bool? PsmSignOffCentralPpeStocks { get; set; }

    public string? PsmRmks { get; set; }

    public int? PsmCreatedBy { get; set; }

    public int? PsmEditedBy { get; set; }

    public DateTime? PsmCreationDate { get; set; }

    public DateTime? PsmEditedDate { get; set; }
}

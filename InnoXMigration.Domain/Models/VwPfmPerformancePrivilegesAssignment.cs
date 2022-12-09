using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmPerformancePrivilegesAssignment
{
    public int PpaIdpk { get; set; }

    public int? PpaEmpIdfk { get; set; }

    public int? PpaDeptIdfk { get; set; }

    public bool? PpaSectionIdfk { get; set; }

    public bool? PpaUnitIdfk { get; set; }

    public bool? PpaSysAdmin { get; set; }

    public bool? PpaDeptAdmin { get; set; }

    public bool? PpaSectionAdmin { get; set; }

    public bool? PpaUnitAdmin { get; set; }

    public bool? PpaView { get; set; }

    public bool? PpaSubmit { get; set; }

    public bool? PpaAcknowledge { get; set; }

    public bool? PpaApprove { get; set; }

    public bool? PpaSendAlerts { get; set; }

    public bool? PpaAlertFyi { get; set; }

    public bool? PpaSupervisor { get; set; }

    public bool? PpaManager { get; set; }

    public bool? PpaDirector { get; set; }

    public bool? PpaActive { get; set; }

    public string? PpaRmks { get; set; }
}

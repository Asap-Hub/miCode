using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPrivilegesComputingAsset
{
    public int PcaIdpk { get; set; }

    public int? PcaEmpIdfk { get; set; }

    public bool? PcaSupervisor { get; set; }

    public bool? PcaManager { get; set; }

    public bool? PcaDirector { get; set; }

    public bool? PcaClassifyIssues { get; set; }

    public bool? PcaAssignRequests { get; set; }

    public bool? PcaTechnician { get; set; }

    public bool? PcaSysAdmin { get; set; }

    public bool? PcaActive { get; set; }

    public string? PcaRmks { get; set; }

    public int? PcaCreatedBy { get; set; }

    public int? PcaEditedBy { get; set; }

    public DateTime? PcaCreationDate { get; set; }

    public DateTime? PcaEditedDate { get; set; }
}

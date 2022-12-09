using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOrgBranch
{
    public int ObrIdpk { get; set; }

    public string? ObrName { get; set; }

    public string? ObrShtName { get; set; }

    public string? ObrCode { get; set; }

    public DateTime? ObrStartDate { get; set; }

    public DateTime? ObrEndDate { get; set; }

    public int? ObrHeadEmpIdfk { get; set; }

    public int? ObrCompanyIdfk { get; set; }

    public bool? ObrActive { get; set; }

    public string? ObrRmks { get; set; }

    public int? ObrCreatedBy { get; set; }

    public int? ObrEditedBy { get; set; }

    public DateTime? ObrCreationDate { get; set; }

    public DateTime? ObrEditedDate { get; set; }
}

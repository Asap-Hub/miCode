using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOrgChart
{
    public int OgcIdpk { get; set; }

    public string? OgcDate { get; set; }

    public string? OgcChart { get; set; }

    public string? OgcDeptId { get; set; }

    public string? OgcActive { get; set; }

    public string? OgcRmks { get; set; }

    public string? OgcCreationDate { get; set; }

    public string? OgcEditedDate { get; set; }

    public string? OgcCreatedBy { get; set; }

    public string? OgcEditedBy { get; set; }
}

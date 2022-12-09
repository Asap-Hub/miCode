using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtWorkProgramActivity
{
    public int WpaIdpk { get; set; }

    public string? WpaName { get; set; }

    public string? WpaShtName { get; set; }

    public bool? WpaActive { get; set; }

    public string? WpaRmks { get; set; }

    public int? WpaCreatedBy { get; set; }

    public int? WpaEditedBy { get; set; }

    public DateTime? WpaCreationDate { get; set; }

    public DateTime? WpaEditedDate { get; set; }
}

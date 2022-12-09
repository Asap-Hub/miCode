using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtActivityHeader
{
    public int AchIdpk { get; set; }

    public string? AchName { get; set; }

    public string? AchShtName { get; set; }

    public bool? AchActive { get; set; }

    public string? AchRmks { get; set; }

    public int? AchCreatedBy { get; set; }

    public int? AchEditedBy { get; set; }

    public DateTime? AchCreationDate { get; set; }

    public DateTime? AchEditedDate { get; set; }
}

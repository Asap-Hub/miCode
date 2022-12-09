using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsStage
{
    public int FstgIdpk { get; set; }

    public string? FstgName { get; set; }

    public string? FstgShtName { get; set; }

    public double? FstgOrder { get; set; }

    public bool? FstgActive { get; set; }

    public string? FstgRmks { get; set; }

    public int? FstgCreatedBy { get; set; }

    public int? FstgEditedBy { get; set; }

    public DateTime? FstgCreationDate { get; set; }

    public DateTime? FstgEditedDate { get; set; }
}

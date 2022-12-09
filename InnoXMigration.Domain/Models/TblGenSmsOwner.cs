using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsOwner
{
    public int SowIdpk { get; set; }

    public string? SowName { get; set; }

    public string? SowShtName { get; set; }

    public bool? SowActive { get; set; }

    public string? SowRmks { get; set; }

    public string? SowCreatedBy { get; set; }

    public int? SowEditedBy { get; set; }

    public DateTime? SowCreationDate { get; set; }

    public DateTime? SowEditedDate { get; set; }
}

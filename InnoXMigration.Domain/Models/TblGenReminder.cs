using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenReminder
{
    public int RmnIdpk { get; set; }

    public string? RmnName { get; set; }

    public string? RmnShtName { get; set; }

    public byte? RmnOrder { get; set; }

    public bool? RmnActive { get; set; }

    public string? RmnRmks { get; set; }

    public int? RmnCreatedBy { get; set; }

    public int? RmnEditedBy { get; set; }

    public DateTime? RmnCreationDate { get; set; }

    public DateTime? RmnEditedDate { get; set; }
}

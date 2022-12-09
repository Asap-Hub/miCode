using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrJobTitle
{
    public int DjtIdpk { get; set; }

    public string? DjtName { get; set; }

    public string? DjtShtName { get; set; }

    public bool? DjtActive { get; set; }

    public string? DjtRmks { get; set; }

    public int? DjtCreatedBy { get; set; }

    public int? DjtEditedBy { get; set; }

    public DateTime? DjtCreationDate { get; set; }

    public DateTime? DjtEditedDate { get; set; }
}

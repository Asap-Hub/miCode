using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOffice
{
    public int OfcIdpk { get; set; }

    public string? OfcName { get; set; }

    public string? OfcShtName { get; set; }

    public int? OfcLocationIdfk { get; set; }

    public bool? OfcActive { get; set; }

    public string? OfcRmks { get; set; }

    public int? OfcCreatedBy { get; set; }

    public int? OfcEditedBy { get; set; }

    public DateTime? OfcCreationDate { get; set; }

    public DateTime? OfcEditedDate { get; set; }
}

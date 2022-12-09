using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSubject
{
    public int SbjIdpk { get; set; }

    public string? SbjName { get; set; }

    public string? SbjShtName { get; set; }

    public string? SbjShtCode { get; set; }

    public bool? SbjActive { get; set; }

    public string? SbjRmks { get; set; }

    public int? SbjCreatedBy { get; set; }

    public int? SbjEditedBy { get; set; }

    public DateTime? SbjCreationDate { get; set; }

    public DateTime? SbjEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrIdtype
{
    public int IdtIdpk { get; set; }

    public string? IdtName { get; set; }

    public string? IdtShtName { get; set; }

    public bool? IdtActive { get; set; }

    public string? IdtRmks { get; set; }

    public int? IdtCreatedBy { get; set; }

    public int? IdtEditedBy { get; set; }

    public DateTime? IdtCreationDate { get; set; }

    public DateTime? IdtEditedDate { get; set; }
}

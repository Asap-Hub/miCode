using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompOsflavour
{
    public int OsfIdpk { get; set; }

    public string? OsfName { get; set; }

    public string? OsfShtName { get; set; }

    public int? OsfOperatingSystemIdfk { get; set; }

    public bool? OsfActive { get; set; }

    public string? OsfRmks { get; set; }

    public int? OsfCreatedBy { get; set; }

    public int? OsfEditedBy { get; set; }

    public DateTime? OsfCreationDate { get; set; }

    public DateTime? OsfEditedDate { get; set; }
}

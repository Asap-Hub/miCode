using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamEquipmentStatus
{
    public int EstIdpk { get; set; }

    public string? EstName { get; set; }

    public string? EstShtName { get; set; }

    public bool? EstFitStatus { get; set; }

    public bool? EstActive { get; set; }

    public string? EstRmks { get; set; }

    public string? EstCreatedBy { get; set; }

    public int? EstEditedBy { get; set; }

    public DateTime? EstCreationDate { get; set; }

    public DateTime? EstEditedDate { get; set; }
}

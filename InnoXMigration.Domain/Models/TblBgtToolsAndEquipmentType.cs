using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtToolsAndEquipmentType
{
    public int TetIdpk { get; set; }

    public string? TetName { get; set; }

    public string? TetShtName { get; set; }

    public bool? TetActive { get; set; }

    public string? TetRmks { get; set; }

    public int? TetCreatedBy { get; set; }

    public int? TetEditedBy { get; set; }

    public DateTime? TetCreationDate { get; set; }

    public DateTime? TetEditedDate { get; set; }
}

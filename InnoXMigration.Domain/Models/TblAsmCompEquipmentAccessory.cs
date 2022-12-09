using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompEquipmentAccessory
{
    public int EqaIdpk { get; set; }

    public int? EqaEquipIdfk { get; set; }

    public int? EqaAccessoryIdfk { get; set; }

    public string? EqaValue { get; set; }

    public bool? EqaActive { get; set; }

    public string? EqaRmks { get; set; }

    public string? EqaCreatedBy { get; set; }

    public int? EqaEditedBy { get; set; }

    public DateTime? EqaCreationDate { get; set; }

    public DateTime? EqaEditedDate { get; set; }
}

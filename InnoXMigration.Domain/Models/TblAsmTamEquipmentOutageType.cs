using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamEquipmentOutageType
{
    public int EotIdpk { get; set; }

    public string? EotName { get; set; }

    public string? EotShtName { get; set; }

    public bool? EotActive { get; set; }

    public string? EotRmks { get; set; }

    public string? EotCreatedBy { get; set; }

    public int? EotEditedBy { get; set; }

    public DateTime? EotCreationDate { get; set; }

    public DateTime? EotEditedDate { get; set; }
}

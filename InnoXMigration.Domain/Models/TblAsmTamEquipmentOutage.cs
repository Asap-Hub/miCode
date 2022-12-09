using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamEquipmentOutage
{
    public int EotIdpk { get; set; }

    public DateTime? EotStartDate { get; set; }

    public DateTime? EotEndDate { get; set; }

    public int? EotOutageTypeIdfk { get; set; }

    public int? EotEquipmentTypeIdfk { get; set; }

    public int? EotEquipmentIdfk { get; set; }

    public string? EotReason { get; set; }

    public string? EotRmks { get; set; }

    public int? EotCreatedBy { get; set; }

    public int? EotEditedBy { get; set; }

    public DateTime? EotCreationDate { get; set; }

    public DateTime? EotEditedDate { get; set; }
}

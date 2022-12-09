using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompEquipmentModel
{
    public int EmdIdpk { get; set; }

    public string? EmdName { get; set; }

    public string? EmdShtName { get; set; }

    public int? EmdManufacturerIdfk { get; set; }

    public int? EmdEquipmentTypeIdfk { get; set; }

    public bool? EmdActive { get; set; }

    public string? EmdRmks { get; set; }

    public string? EmdCreatedBy { get; set; }

    public int? EmdEditedBy { get; set; }

    public DateTime? EmdCreationDate { get; set; }

    public DateTime? EmdEditedDate { get; set; }
}

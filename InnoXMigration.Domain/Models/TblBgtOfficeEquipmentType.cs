using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtOfficeEquipmentType
{
    public int OetIdpk { get; set; }

    public string? OetName { get; set; }

    public string? OetShtName { get; set; }

    public bool? OetActive { get; set; }

    public string? OetRmks { get; set; }

    public int? OetCreatedBy { get; set; }

    public int? OetEditedBy { get; set; }

    public DateTime? OetCreationDate { get; set; }

    public DateTime? OetEditedDate { get; set; }
}

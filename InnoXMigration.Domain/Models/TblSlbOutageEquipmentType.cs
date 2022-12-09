using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOutageEquipmentType
{
    public int OetIdpk { get; set; }

    public string? OetName { get; set; }

    public string? OetShtName { get; set; }

    public bool? OetTransformer { get; set; }

    public bool? OetLine { get; set; }

    public bool? OetFeeder { get; set; }

    public bool? OetCapacitorBank { get; set; }

    public bool? OetStaticVarCompensator { get; set; }

    public bool? OetActive { get; set; }

    public string? OetRmks { get; set; }

    public int? OetCreatedBy { get; set; }

    public int? OetEditedBy { get; set; }

    public DateTime? OetCreationDate { get; set; }

    public DateTime? OetEditedDate { get; set; }
}

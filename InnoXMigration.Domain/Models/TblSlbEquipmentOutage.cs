using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbEquipmentOutage
{
    public int EotIdpk { get; set; }

    public int? EotStationIdfk { get; set; }

    public int? EotOutageTypeIdfk { get; set; }

    public int? EotEquipmentTypeIdfk { get; set; }

    public int? EotEquipmentDetailIdfk { get; set; }

    public string? EotEquipment { get; set; }

    public DateTime? EotStartTime { get; set; }

    public DateTime? EotEndTime { get; set; }

    public string? EotReason { get; set; }

    public string? EotDetails { get; set; }

    public bool? EotActive { get; set; }

    public string? EotRmks { get; set; }

    public int? EotCreatedBy { get; set; }

    public int? EotEditedBy { get; set; }

    public DateTime? EotCreationDate { get; set; }

    public DateTime? EotEditedDate { get; set; }
}

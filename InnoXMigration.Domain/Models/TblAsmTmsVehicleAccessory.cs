using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleAccessory
{
    public int VacIdpk { get; set; }

    public int? VacVehicleIdfk { get; set; }

    public int? VacAccessoryIdfk { get; set; }

    public string? VacValue { get; set; }

    public bool? VacActive { get; set; }

    public string? VacRmks { get; set; }

    public string? VacCreatedBy { get; set; }

    public int? VacEditedBy { get; set; }

    public DateTime? VacCreationDate { get; set; }

    public DateTime? VacEditedDate { get; set; }
}

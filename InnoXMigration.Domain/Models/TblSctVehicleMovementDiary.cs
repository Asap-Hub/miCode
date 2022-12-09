using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSctVehicleMovementDiary
{
    public int VmdIdpk { get; set; }

    public DateTime? VmdDate { get; set; }

    public string? VmdPurpose { get; set; }

    public int? VmdGateIdfk { get; set; }

    public int? VmdVehicleDetailIdfk { get; set; }

    public string? VmdRegNo { get; set; }

    public int? VmdAuthorisedByEmpIdfk { get; set; }

    public string? VmdAuthorisedByName { get; set; }

    public int? VmdDriverEmpIdfk { get; set; }

    public string? VmdDriverName { get; set; }

    public bool? VmdIn { get; set; }

    public int? VmdOdometerReading { get; set; }

    public int? VmdFromRegionIdfk { get; set; }

    public string? VmdFromTown { get; set; }

    public int? VmdToRegionIdfk { get; set; }

    public string? VmdToTown { get; set; }

    public bool? VmdOfficialVehicle { get; set; }

    public bool? VmdDriverStaff { get; set; }

    public bool? VmdAuthoriserStaff { get; set; }

    public bool? VmdActive { get; set; }

    public string? VmdRmks { get; set; }

    public int? VmdCreatedBy { get; set; }

    public int? VmdEditedBy { get; set; }

    public DateTime? VmdCreationDate { get; set; }

    public DateTime? VmdEditedDate { get; set; }
}

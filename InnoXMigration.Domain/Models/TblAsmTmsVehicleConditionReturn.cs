using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleConditionReturn
{
    public int VcrIdpk { get; set; }

    public int? VcrVehicleAssignmentIdfk { get; set; }

    public DateTime? VcrDate { get; set; }

    public string? VcrCondition { get; set; }

    public string? VcrInside { get; set; }

    public string? VcrOutside { get; set; }

    public string? VcrTyre { get; set; }

    public string? VcrSuspension { get; set; }

    public string? VcrEngine { get; set; }

    public string? VcrAirConditioner { get; set; }

    public bool? VcrBoard { get; set; }

    public bool? VcrCard { get; set; }

    public bool? VcrNonCard { get; set; }

    public decimal? VcrOdometerStart { get; set; }

    public decimal? VcrOdometerEnd { get; set; }

    public bool? VcrSubmitted { get; set; }

    public bool? VcrAcknowledged { get; set; }

    public int? VcrAcknowledgedByEmpIdfk { get; set; }

    public int? VcrSubmittedByEmpIdfk { get; set; }

    public bool? VcrActive { get; set; }

    public string? VcrRmks { get; set; }

    public string? VcrCreatedBy { get; set; }

    public int? VcrEditedBy { get; set; }

    public DateTime? VcrCreationDate { get; set; }

    public DateTime? VcrEditedDate { get; set; }
}

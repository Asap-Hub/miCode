using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleLogBook
{
    public int VlbIdpk { get; set; }

    public int? VlbVehicleAssignIdfk { get; set; }

    public DateTime? VlbTimeIn { get; set; }

    public DateTime? VlbTimeOut { get; set; }

    public decimal? VlbOdometerStart { get; set; }

    public decimal? VlbOdometerEnd { get; set; }

    public int? VlbToRegionIdfk { get; set; }

    public int? VlbFromRegionIdfk { get; set; }

    public string? VlbFromRegion { get; set; }

    public string? VlbFromTown { get; set; }

    public string? VlbToRegion { get; set; }

    public string? VlbToTown { get; set; }

    public int? VlbAuthorisedByEmpIdfk { get; set; }

    public string? VlbDescription { get; set; }

    public bool? VlbCancelled { get; set; }

    public DateTime? VlbDateUpdated { get; set; }

    public bool? VlbAuthorised { get; set; }

    public int? VlbStartFuelLevelIdfk { get; set; }

    public int? VlbFinalFuelLevelIdfk { get; set; }

    public bool? VlbActive { get; set; }

    public string? VlbRmks { get; set; }

    public int? VlbCreatorEmpIdfk { get; set; }

    public int? VlbCreatorDeptIdfk { get; set; }

    public int? VlbCreatorSectionIdfk { get; set; }

    public int? VlbEditedBy { get; set; }

    public DateTime? VlbCancellationDate { get; set; }

    public DateTime? VlbCreationDate { get; set; }

    public DateTime? VlbEditedDate { get; set; }

    public DateTime? VlbDateAuthorised { get; set; }
}

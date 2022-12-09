using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleAssignment
{
    public int VasIdpk { get; set; }

    public int? VasVehicleDetailIdfk { get; set; }

    public DateTime? VasStartDate { get; set; }

    public DateTime? VasEndDate { get; set; }

    public int? VasDeptIdfk { get; set; }

    public int? VasSectionIdfk { get; set; }

    public int? VasUnitIdfk { get; set; }

    public int? VasOwnerEmpIdfk { get; set; }

    public int? VasDriverEmpIdfk { get; set; }

    public int? VasVehicleControllerEmpIdfk { get; set; }

    public int? VasAdminEmpIdfk { get; set; }

    public int? VasDefaultWorkshopIdfk { get; set; }

    public int? VasTransportUnitIdfk { get; set; }

    public int? VasLocationIdfk { get; set; }

    public int? VasDirectorEmpIdfk { get; set; }

    public int? VasManagerEmpIdfk { get; set; }

    public bool? VasAssigned { get; set; }

    public bool? VasDeleted { get; set; }

    public bool? VasActive { get; set; }

    public string? VasRmks { get; set; }

    public int? VasCreatedBy { get; set; }

    public int? VasEditedBy { get; set; }

    public DateTime? VasCreationDate { get; set; }

    public DateTime? VasEditedDate { get; set; }
}

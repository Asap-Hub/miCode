using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsVehicleSimcardsAssignment
{
    public int VsaIdpk { get; set; }

    public int? VsaVendorIdfk { get; set; }

    public int? VsaVehicleDetailIdfk { get; set; }

    public DateTime? VsaStartDate { get; set; }

    public DateTime? VsaEndDate { get; set; }

    public string? VsaMobNo { get; set; }

    public int? VsaTrackerUrlIdfk { get; set; }

    public bool? VsaActive { get; set; }

    public string? VsaRmks { get; set; }

    public string? VsaCreatedBy { get; set; }

    public int? VsaEditedBy { get; set; }

    public DateTime? VsaCreationDate { get; set; }

    public DateTime? VsaEditedDate { get; set; }
}

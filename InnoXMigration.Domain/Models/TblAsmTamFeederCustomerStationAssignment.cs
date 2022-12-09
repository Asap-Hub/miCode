using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamFeederCustomerStationAssignment
{
    public int FcaIdpk { get; set; }

    public string? FcaStartDate { get; set; }

    public string? FcaEndDate { get; set; }

    public int? FcaFeederIdfk { get; set; }

    public int? FcaSubstationIdfk { get; set; }

    public int? FcaCustomerIdfk { get; set; }

    public bool? FcaAssigned { get; set; }

    public bool? FcaStationService { get; set; }

    public bool? FcaActive { get; set; }

    public string? FcaRmks { get; set; }

    public int? FcaCreatedBy { get; set; }

    public int? FcaEditedBy { get; set; }

    public DateTime? FcaCreationDate { get; set; }

    public DateTime? FcaEditedDate { get; set; }
}

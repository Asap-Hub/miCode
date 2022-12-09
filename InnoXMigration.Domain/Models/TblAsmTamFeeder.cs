using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamFeeder
{
    public int FdrIdpk { get; set; }

    public DateTime? FdrStartDate { get; set; }

    public DateTime? FdrEndDate { get; set; }

    public int? FdrStationIdfk { get; set; }

    public string? FdrName { get; set; }

    public string? FdrShtName { get; set; }

    public int? FdrCustomerIdfk { get; set; }

    public bool? FdrStationService { get; set; }

    public bool? FdrActive { get; set; }

    public string? FdrRmks { get; set; }

    public int? FdrCreatedBy { get; set; }

    public int? FdrEditedBy { get; set; }

    public DateTime? FdrCreationDate { get; set; }

    public DateTime? FdrEditedDate { get; set; }
}

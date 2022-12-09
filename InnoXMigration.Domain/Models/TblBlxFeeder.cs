using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxFeeder
{
    public int FfdrIdpk { get; set; }

    public string? FfdrName { get; set; }

    public string? FfdrShtName { get; set; }

    public double? FfdrMultiplier { get; set; }

    public int? FfdrCustIdfk { get; set; }

    public int? FfdrSstIdfk { get; set; }

    public bool? FfdrStationService { get; set; }

    public bool? FfdrAssigned { get; set; }

    public int? FfdrParentFdrIdfk { get; set; }

    public bool? FfdrActive { get; set; }

    public string? FfdrRmks { get; set; }

    public int? FfdrEditedBy { get; set; }

    public int? FfdrCreatedBy { get; set; }

    public DateTime? FfdrCreationDate { get; set; }

    public DateTime? FfdrEditedDate { get; set; }
}

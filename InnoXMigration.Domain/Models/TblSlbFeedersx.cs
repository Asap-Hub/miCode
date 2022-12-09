using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbFeedersx
{
    public int FdrIdpk { get; set; }

    public string? FdrName { get; set; }

    public string? FdrShtName { get; set; }

    public int? FdrSubstationIdfk { get; set; }

    public int? FdrCustomerIdfk { get; set; }

    public bool? FdrStationService { get; set; }

    public bool? FdrActive { get; set; }

    public string? FdrRmks { get; set; }

    public int? FdrCreatedBy { get; set; }

    public int? FdrLastEditedBy { get; set; }

    public DateTime? FdrCreationDate { get; set; }

    public DateTime? FdrLastEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamBusDetail
{
    public int BdtIdpk { get; set; }

    public int? BdtStationIdfk { get; set; }

    public string? BdtName { get; set; }

    public string? BdtShtName { get; set; }

    public decimal? BdtMinimumVoltage { get; set; }

    public decimal? BdtMaximumVoltage { get; set; }

    public bool? BdtActive { get; set; }

    public string? BdtRmks { get; set; }

    public int? BdtCreatedBy { get; set; }

    public int? BdtEditedBy { get; set; }

    public DateTime? BdtCreationDate { get; set; }

    public DateTime? BdtEditedDate { get; set; }
}

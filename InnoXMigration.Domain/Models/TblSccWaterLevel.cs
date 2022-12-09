using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccWaterLevel
{
    public int DwlIdpk { get; set; }

    public DateTime? DwlDate { get; set; }

    public int? DwlGenStationIdfk { get; set; }

    public decimal? DwlHeadLevel { get; set; }

    public decimal? DwlTaillevel { get; set; }

    public decimal? DwlProjected { get; set; }

    public string? DwlRmks { get; set; }

    public int? DwlCreatedBy { get; set; }

    public int? DwlEditedBy { get; set; }

    public DateTime? DwlCreationDate { get; set; }

    public DateTime? DwlEditedDate { get; set; }
}

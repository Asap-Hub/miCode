using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamGenerationPlant
{
    public int GplIdpk { get; set; }

    public string? GplName { get; set; }

    public string? GplShtName { get; set; }

    public int? GplGenerationStationIdfk { get; set; }

    public int? GplPlantTypeIdfk { get; set; }

    public decimal? GplMegawattsCapacity { get; set; }

    public byte? GplDisplayOrder { get; set; }

    public bool? GplActive { get; set; }

    public string? GplRmks { get; set; }

    public int? GplCreatedBy { get; set; }

    public int? GplEditedBy { get; set; }

    public DateTime? GplCreationDate { get; set; }

    public DateTime? GplEditedDate { get; set; }
}

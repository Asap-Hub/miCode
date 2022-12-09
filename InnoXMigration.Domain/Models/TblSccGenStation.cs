using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccGenStation
{
    public int GstIdpk { get; set; }

    public string? GstName { get; set; }

    public string? GstShtName { get; set; }

    public string? GstCode { get; set; }

    public int? GstFuelTypeIdfk { get; set; }

    public byte? GstDisplayOrder { get; set; }

    public decimal? GstMaxOperatingLevel { get; set; }

    public decimal? GstMinOperatingLevel { get; set; }

    public bool? GstActive { get; set; }

    public string? GstRmks { get; set; }

    public int? GstCreatedBy { get; set; }

    public int? GstEditedBy { get; set; }

    public DateTime? GstCreationDate { get; set; }

    public DateTime? GstEditedDate { get; set; }
}

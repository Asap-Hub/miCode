using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDistrict
{
    public int DstIdpk { get; set; }

    public string? DstName { get; set; }

    public string? DstShtName { get; set; }

    public int? DstRegionIdfk { get; set; }

    public string? DstCapial { get; set; }

    public bool? DstActive { get; set; }

    public string? DstRemarks { get; set; }

    public int? DstCreatedBy { get; set; }

    public int? DstLastEditedBy { get; set; }

    public DateTime? DstCreationDate { get; set; }

    public DateTime? DstLastEditedDate { get; set; }
}

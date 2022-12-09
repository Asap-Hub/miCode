using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmSectionInitiative
{
    public int SxiIdpk { get; set; }

    public string? SxiName { get; set; }

    public string? SxiShtName { get; set; }

    public bool? SxiActive { get; set; }

    public decimal? SxiOrder { get; set; }

    public string? SxiRmks { get; set; }

    public string? SxiCreatedBy { get; set; }

    public int? SxiEditedBy { get; set; }

    public DateTime? SxiCreationDate { get; set; }

    public DateTime? SxiEditedDate { get; set; }
}

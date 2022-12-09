using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamStationBusDetail
{
    public int SbdIdpk { get; set; }

    public int SbdStationIdfk { get; set; }

    public string SbdName { get; set; } = null!;

    public string SbdShtName { get; set; } = null!;

    public bool? SbdActive { get; set; }

    public string? SbdRmks { get; set; }

    public int? SbdCreatedBy { get; set; }

    public int? SbdEditedBy { get; set; }

    public DateTime? SbdCreationDate { get; set; }

    public DateTime? SbdEditedDate { get; set; }
}

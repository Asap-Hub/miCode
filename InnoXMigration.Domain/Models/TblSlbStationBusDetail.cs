using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbStationBusDetail
{
    public int SbdIdpk { get; set; }

    public int? SbdStationIdfk { get; set; }

    public string? SbdName { get; set; }

    public string? SbdShtName { get; set; }

    public bool? SbdActive { get; set; }

    public string? SbdRmks { get; set; }

    public int? SbdCreatedBy { get; set; }

    public int? SbdEditedBy { get; set; }

    public DateTime? SbdCreationDate { get; set; }

    public DateTime? SbdEditedDate { get; set; }
}

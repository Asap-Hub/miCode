using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoLocation
{
    public int WlcIdpk { get; set; }

    public string? WlcName { get; set; }

    public string? WlcShtName { get; set; }

    public int? WlcWasacoStationIdfk { get; set; }

    public bool? WlcActive { get; set; }

    public string? WlcRmks { get; set; }

    public int? WlcCreatedBy { get; set; }

    public int? WlcEditedBy { get; set; }

    public DateTime? WlcCreationDate { get; set; }

    public DateTime? WlcEditedDate { get; set; }
}

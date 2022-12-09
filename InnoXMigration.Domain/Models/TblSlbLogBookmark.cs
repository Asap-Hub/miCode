using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogBookmark
{
    public int LbmIdpk { get; set; }

    public int? LbmEmpIdfk { get; set; }

    public int? LbmLogIdfk { get; set; }

    public int? LbmHomeStationIdfk { get; set; }

    public bool? LbmActive { get; set; }

    public string? LbmRmks { get; set; }

    public int? LbmCreatedBy { get; set; }

    public int? LbmEditedBy { get; set; }

    public DateTime? LbmCreationDate { get; set; }

    public DateTime? LbmEditedDate { get; set; }
}

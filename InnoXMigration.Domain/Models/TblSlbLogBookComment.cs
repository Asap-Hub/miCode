using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogBookComment
{
    public int LbcIdpk { get; set; }

    public int? LbcLogIdfk { get; set; }

    public int? LbcEmpIdfk { get; set; }

    public int? LbmHomeStationIdfk { get; set; }

    public string? LbcComment { get; set; }

    public bool? LbcActive { get; set; }

    public int? LbcCreatedBy { get; set; }

    public int? LbcEditedBy { get; set; }

    public DateTime? LbcCreationDate { get; set; }

    public DateTime? LbcEditedDate { get; set; }
}

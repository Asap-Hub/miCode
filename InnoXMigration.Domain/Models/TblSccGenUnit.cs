using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSccGenUnit
{
    public int GunIdpk { get; set; }

    public int? GunStationIdfk { get; set; }

    public string? GunName { get; set; }

    public string? GunShtName { get; set; }

    public string? GunCode { get; set; }

    public bool? GunActive { get; set; }

    public string? GunRmks { get; set; }

    public int? GunCreatedBy { get; set; }

    public int? GunEditedBy { get; set; }

    public DateTime? GunCreationDate { get; set; }

    public DateTime? GunEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrRoom
{
    public int OraIdpk { get; set; }

    public int? OraOfficeIdfk { get; set; }

    public int? OraRoomIdfk { get; set; }

    public bool? OraActive { get; set; }

    public string? OraRmks { get; set; }

    public int OfcIdpk { get; set; }

    public string? OfcName { get; set; }

    public string? OfcShtName { get; set; }

    public bool? OfcActive { get; set; }

    public string? OfcRmks { get; set; }

    public int RomIdpk { get; set; }

    public string? RomName { get; set; }

    public string? RomShtName { get; set; }

    public bool? RomActive { get; set; }

    public string? RomRmks { get; set; }
}

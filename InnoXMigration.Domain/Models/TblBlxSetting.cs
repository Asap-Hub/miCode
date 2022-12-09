using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxSetting
{
    public int SetIdpk { get; set; }

    public string? SetName { get; set; }

    public string? SetShtName { get; set; }

    public int? ShtCreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }
}

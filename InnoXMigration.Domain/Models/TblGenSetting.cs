using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSetting
{
    public int SetIdpk { get; set; }

    public string? SetName { get; set; }

    public string? SetShtName { get; set; }

    public string? SetCode { get; set; }

    public string? SetModule { get; set; }

    public string? SetDescription { get; set; }

    public int? ShtCreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }
}

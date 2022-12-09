using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsShareDocWith
{
    public int SdwIdpk { get; set; }

    public int? SdwMailIdfk { get; set; }

    public string? SdwStaffNo { get; set; }

    public string? SdwEmpName { get; set; }

    public bool? SdwShareDocOnly { get; set; }

    public int? SdwDocIdfk { get; set; }

    public DateTime? SdwCreationDate { get; set; }
}

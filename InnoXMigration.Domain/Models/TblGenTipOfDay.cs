using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTipOfDay
{
    public int TodIdpk { get; set; }

    public int? TodModuleIdfk { get; set; }

    public byte[]? TodDoc { get; set; }

    public string? TodTitle { get; set; }

    public decimal? TodOrder { get; set; }

    public bool? TodActive { get; set; }

    public int? TodCreatedBy { get; set; }

    public int? TodEditedBy { get; set; }

    public DateTime? TodCreationDate { get; set; }

    public DateTime? TodEditedDate { get; set; }
}

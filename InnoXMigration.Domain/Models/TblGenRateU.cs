using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenRateU
{
    public int RtsIdpk { get; set; }

    public byte? RtsOverallRate { get; set; }

    public byte? RtsEaseOfUseRate { get; set; }

    public byte? RtsPerformanceRate { get; set; }

    public byte? RtsHelpRate { get; set; }

    public string? RtsViews { get; set; }

    public bool? RtsActive { get; set; }

    public int? RtsCreatedBy { get; set; }

    public DateTime? RtsCreationDate { get; set; }
}

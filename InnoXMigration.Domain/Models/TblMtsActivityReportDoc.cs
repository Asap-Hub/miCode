using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsActivityReportDoc
{
    public int ArdIdpk { get; set; }

    public int? ArdReportIdfk { get; set; }

    public byte[]? ArdDoc { get; set; }

    public string? ArdTitle { get; set; }

    public string? ArdFormat { get; set; }

    public bool? ArdMainDoc { get; set; }

    public bool? ArdActive { get; set; }

    public int? ArdCreatedBy { get; set; }

    public int? ArdEditedBy { get; set; }

    public DateTime? ArdCreationDate { get; set; }

    public DateTime? ArdEditedDate { get; set; }
}

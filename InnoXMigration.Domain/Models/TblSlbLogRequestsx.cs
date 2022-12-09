using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogRequestsx
{
    public int FlrqIdpk { get; set; }

    public int? FlrqRecordIdfk { get; set; }

    public string? FlrqRequest { get; set; }

    public bool? FlrqGranted { get; set; }

    public bool? FlrqClosed { get; set; }

    public string? FlrqRmks { get; set; }

    public int? FlrqCreatedBy { get; set; }

    public int? FlrqEditedBy { get; set; }

    public DateTime? FlrqCreationDate { get; set; }

    public DateTime? FlrqEditedDate { get; set; }
}

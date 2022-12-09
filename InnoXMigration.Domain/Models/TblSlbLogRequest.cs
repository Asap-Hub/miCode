using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogRequest
{
    public int LrqIdpk { get; set; }

    public int? LrqRecordIdfk { get; set; }

    public string? LrqRequest { get; set; }

    public bool? LrqGranted { get; set; }

    public bool? LrqClosed { get; set; }

    public string? LrqRmks { get; set; }

    public int? LrqCreatedBy { get; set; }

    public int? LrqEditedBy { get; set; }

    public DateTime? LrqCreationDate { get; set; }

    public DateTime? LrqEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftPpeSignOffMessage
{
    public int PsmIdpk { get; set; }

    public string? PsmMessage { get; set; }

    public bool? PsmActive { get; set; }

    public string? PsmRmks { get; set; }

    public int? PsmCreatedBy { get; set; }

    public int? PsmEditedBy { get; set; }

    public DateTime? PsmCreationDate { get; set; }

    public DateTime? PsmEditedDate { get; set; }
}

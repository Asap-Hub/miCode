using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueLogImage
{
    public int IliIdpk { get; set; }

    public int? IliIssueLogIdfk { get; set; }

    public byte[]? IliImage { get; set; }

    public bool? IliActive { get; set; }

    public string? IliRmks { get; set; }

    public int? IliCreatedBy { get; set; }

    public int? IliEditedBy { get; set; }

    public DateTime? IliCreationDate { get; set; }

    public DateTime? IliEditedDate { get; set; }
}

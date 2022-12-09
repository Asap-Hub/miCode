using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSvlServer
{
    public int SvrIdpk { get; set; }

    public string? SvrName { get; set; }

    public string? SvrShtName { get; set; }

    public bool? SvrActive { get; set; }

    public string? SvrRmks { get; set; }

    public int? SvrCreatedBy { get; set; }

    public int? SvrEditedBy { get; set; }

    public DateTime? SvrCreationDate { get; set; }

    public DateTime? SvrEditedDate { get; set; }
}

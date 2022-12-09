using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogBookImage
{
    public int LbiIdpk { get; set; }

    public int? LbiLogIdfk { get; set; }

    public byte[]? LbiImage { get; set; }

    public bool? LbiActive { get; set; }

    public string? LbiRmks { get; set; }

    public int? LbiCreatedBy { get; set; }

    public int? LbiEditedBy { get; set; }

    public DateTime? LbiCreationDate { get; set; }

    public DateTime? LbiEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenLoggerComment
{
    public int LgcIdpk { get; set; }

    public int? LgcLoggerIdfk { get; set; }

    public int? LgcEmpIdfk { get; set; }

    public string? LgcComment { get; set; }

    public bool? LgcActive { get; set; }

    public int? LgcCreatedBy { get; set; }

    public int? LgcEditedBy { get; set; }

    public DateTime? LgcCreationDate { get; set; }

    public DateTime? LgcEditedDate { get; set; }
}

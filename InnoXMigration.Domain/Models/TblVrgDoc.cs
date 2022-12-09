using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgDoc
{
    public int DocIdpk { get; set; }

    public int? DocDocDetailsIdfk { get; set; }

    public byte[]? DocDoc { get; set; }

    public string? DocFormat { get; set; }

    public bool? DocActive { get; set; }

    public int? DocCreatedBy { get; set; }

    public int? DocEditedBy { get; set; }

    public DateTime? DocCreationDate { get; set; }

    public DateTime? DocEditedDate { get; set; }
}

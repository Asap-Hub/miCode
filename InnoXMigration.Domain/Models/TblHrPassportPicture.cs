using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrPassportPicture
{
    public int PpxIdpk { get; set; }

    public int? PpxEmpIdfk { get; set; }

    public byte[]? PpxPicture { get; set; }

    public DateTime? PpxDate { get; set; }

    public bool? PpxActive { get; set; }

    public int? PpxCreatedBy { get; set; }

    public int? PpxEditedBy { get; set; }

    public DateTime? PpxCreationDate { get; set; }

    public DateTime? PpxEditedDate { get; set; }
}

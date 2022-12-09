using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenStickyNote
{
    public int SntIdpk { get; set; }

    public string? SntNotes { get; set; }

    public byte[]? SntNotesx { get; set; }

    public int? SntCreatedBy { get; set; }

    public DateTime? SntCreationDate { get; set; }

    public DateTime? SntEditedDate { get; set; }
}

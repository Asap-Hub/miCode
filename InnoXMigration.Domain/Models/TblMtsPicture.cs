using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsPicture
{
    public int PctIdpk { get; set; }

    public int? PctPicLibraryIdfk { get; set; }

    public byte[]? PctPicture { get; set; }

    public string? PctFormat { get; set; }

    public bool? PctActive { get; set; }

    public int? PctCreatedBy { get; set; }

    public int? PctEditedBy { get; set; }

    public DateTime PctCreationDate { get; set; }

    public DateTime? PctEditedDate { get; set; }
}

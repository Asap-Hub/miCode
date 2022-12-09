using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingImage
{
    public int TimIdpk { get; set; }

    public int? TimTrekkingRequestIdfk { get; set; }

    public byte[]? TimImage { get; set; }

    public bool? TimActive { get; set; }

    public string? TimRmks { get; set; }

    public int? TimCreatedBy { get; set; }

    public int? TimEditedBy { get; set; }

    public DateTime? TimCreationDate { get; set; }

    public DateTime? TimEditedDate { get; set; }
}

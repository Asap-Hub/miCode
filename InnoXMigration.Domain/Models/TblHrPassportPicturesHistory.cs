using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrPassportPicturesHistory
{
    public int PphIdpk { get; set; }

    public int? PphEmpIdfk { get; set; }

    public byte[]? PphPicture { get; set; }

    public DateTime? PphDate { get; set; }

    public bool? PphDeleted { get; set; }

    public bool? PphActive { get; set; }

    public string? PphRmks { get; set; }

    public int? PphCreatedBy { get; set; }

    public int? PphEditedBy { get; set; }

    public DateTime? PphCreationDate { get; set; }

    public DateTime? PphEditedDate { get; set; }
}

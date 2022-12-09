using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdModel
{
    public int SdmIdpk { get; set; }

    public string? SdmName { get; set; }

    public string? SdmShtName { get; set; }

    public bool? SdmActive { get; set; }

    public string? SdmRmks { get; set; }

    public int? SdmCreatedBy { get; set; }

    public int? SdmEditedBy { get; set; }

    public DateTime? SdmCreationDate { get; set; }

    public DateTime? SdmEditedDate { get; set; }
}

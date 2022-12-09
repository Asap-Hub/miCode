using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdDevStage
{
    public int SdsIdpk { get; set; }

    public string? SdsName { get; set; }

    public string? SdsShtName { get; set; }

    public int? SdsModelIdfk { get; set; }

    public bool? SdsActive { get; set; }

    public byte? SdsOrder { get; set; }

    public string? SdsRmks { get; set; }

    public int? SdsCreatedBy { get; set; }

    public int? SdsEditedBy { get; set; }

    public DateTime? SdsCreationDate { get; set; }

    public DateTime? SdsEditedDate { get; set; }
}

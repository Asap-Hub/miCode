using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectComponent
{
    public int PcmIdpk { get; set; }

    public string? PcmName { get; set; }

    public string? PcmShtName { get; set; }

    public int? PcmProjectIdfk { get; set; }

    public byte? PcmOrder { get; set; }

    public bool? PcmActive { get; set; }

    public string? PcmRmks { get; set; }

    public int? PcmCreatedBy { get; set; }

    public int? PcmEditedBy { get; set; }

    public DateTime? PcmCreationDate { get; set; }

    public DateTime? PcmEditedDate { get; set; }
}

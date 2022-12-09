using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamStaticVarCompensator
{
    public int SvcIdpk { get; set; }

    public DateTime? SvcStartDate { get; set; }

    public DateTime? SvcEndDate { get; set; }

    public int? SvcStationIdfk { get; set; }

    public string? SvcNomenclature { get; set; }

    public string? SvcShtName { get; set; }

    public bool? SvcActive { get; set; }

    public string? SvcRmks { get; set; }

    public int? SvcCreatedBy { get; set; }

    public int? SvcEditedBy { get; set; }

    public DateTime? SvcCreationDate { get; set; }

    public DateTime? SvcEditedDate { get; set; }
}

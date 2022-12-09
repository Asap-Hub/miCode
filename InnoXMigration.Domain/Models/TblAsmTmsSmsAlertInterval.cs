using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsSmsAlertInterval
{
    public int SaiIdpk { get; set; }

    public DateTime? SaiDate { get; set; }

    public byte? SaiFirstInterval { get; set; }

    public byte? SaiSecondInterval { get; set; }

    public byte? SaiThirdInterval { get; set; }

    public bool? SaiActive { get; set; }

    public string? SaiRmks { get; set; }

    public string? SaiCreatedBy { get; set; }

    public int? SaiEditedBy { get; set; }

    public DateTime? SaiCreationDate { get; set; }

    public DateTime? SaiEditedDate { get; set; }
}

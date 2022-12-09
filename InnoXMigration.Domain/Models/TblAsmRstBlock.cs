using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstBlock
{
    public int BlkIdpk { get; set; }

    public string? BlkName { get; set; }

    public string? BlkShtName { get; set; }

    public int? BlkLocationIdfk { get; set; }

    public int? BklTownIdfk { get; set; }

    public bool? BlkActive { get; set; }

    public string? BlkRmks { get; set; }

    public string? BlkCreatedBy { get; set; }

    public int? BlkEditedBy { get; set; }

    public DateTime? BlkCreationDate { get; set; }

    public DateTime? BlkEditedDate { get; set; }
}

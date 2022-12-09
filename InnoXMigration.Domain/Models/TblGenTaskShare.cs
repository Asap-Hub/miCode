using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTaskShare
{
    public int TssIdpk { get; set; }

    public int? TssTaskIdfk { get; set; }

    public int? TssEmpIdfk { get; set; }

    public bool? TssSave { get; set; }

    public bool? TssEdit { get; set; }

    public bool? TssRead { get; set; }

    public bool? TssActive { get; set; }

    public string? TssRmks { get; set; }

    public int? TssCreatedBy { get; set; }

    public int? TssEditedBy { get; set; }

    public DateTime? TssCreationDate { get; set; }

    public DateTime? TssEditedDate { get; set; }
}

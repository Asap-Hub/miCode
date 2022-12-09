using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustRlr
{
    public int FcrrIdpk { get; set; }

    public int? FcrrCustIdfk { get; set; }

    public double? FcrrTsrate { get; set; }

    public double? FcrrRegRate { get; set; }

    public DateTime? FcrrDate { get; set; }

    public string? FcrrRmks { get; set; }

    public int? FcrrCreatedBy { get; set; }

    public int? FcrrEditedBy { get; set; }

    public DateTime? FcrrCreationDate { get; set; }

    public DateTime? FcrrEditedDate { get; set; }
}

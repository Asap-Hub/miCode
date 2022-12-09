using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustTsr
{
    public int FctrIdpk { get; set; }

    public int? FctrCustIdfk { get; set; }

    public double? FctrRate { get; set; }

    public DateTime? FctrDate { get; set; }

    public string? FctrRmks { get; set; }

    public int? FctrCreatedBy { get; set; }

    public int? FctrEditedBy { get; set; }

    public DateTime? FctrCreationDate { get; set; }

    public DateTime? FctrEditedDate { get; set; }
}

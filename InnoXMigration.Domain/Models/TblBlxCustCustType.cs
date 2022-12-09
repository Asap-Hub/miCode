using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustCustType
{
    public int FcctIdpk { get; set; }

    public DateTime? FcctDate { get; set; }

    public int? FcctCustIdfk { get; set; }

    public int? FcctCustTypeIdfk { get; set; }

    public string? FcctRmks { get; set; }

    public int? FcctCreatedBy { get; set; }

    public int? FcctEditedBy { get; set; }

    public DateTime? FcctCreationDate { get; set; }

    public DateTime? FcctEditedDate { get; set; }
}

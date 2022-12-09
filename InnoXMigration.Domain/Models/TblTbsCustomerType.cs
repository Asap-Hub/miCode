using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsCustomerType
{
    public int CtpIdpk { get; set; }

    public string? CtpName { get; set; }

    public string? CtpShtName { get; set; }

    public bool? CtpActive { get; set; }

    public string? CtpRmks { get; set; }

    public int? CtpCreatedBy { get; set; }

    public DateTime? CtpCreationDate { get; set; }

    public int? CtpEditedBy { get; set; }

    public DateTime? CtpEditedDate { get; set; }
}

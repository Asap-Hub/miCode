using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustType
{
    public int FctpIdpk { get; set; }

    public string? FctpName { get; set; }

    public string? FctpShtName { get; set; }

    public bool? FctpActive { get; set; }

    public string? FctpRmks { get; set; }

    public int? FctpCreatedBy { get; set; }

    public DateTime? FctpCreationDate { get; set; }

    public int? FctpEditedBy { get; set; }

    public DateTime? FctpEditedDate { get; set; }
}

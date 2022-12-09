using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenHelpModule
{
    public int HmdIdpk { get; set; }

    public string? HmdName { get; set; }

    public string? HmdShtName { get; set; }

    public bool? HmdActive { get; set; }

    public decimal? HmdOrder { get; set; }

    public string? HmdRmks { get; set; }

    public int? HmdCreatedBy { get; set; }

    public int? HmdEditedBy { get; set; }

    public DateTime? HmdCreationDate { get; set; }

    public DateTime? HmdEditedDate { get; set; }
}

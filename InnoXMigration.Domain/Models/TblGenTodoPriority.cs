using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTodoPriority
{
    public int TdpIdpk { get; set; }

    public string? TdpName { get; set; }

    public string? TdpShtName { get; set; }

    public bool? TdpActive { get; set; }

    public byte? TdpOrder { get; set; }

    public string? TdpRmks { get; set; }

    public int? TdpCreatedBy { get; set; }

    public int? TdpEditedBy { get; set; }

    public DateTime? TdpCreationDate { get; set; }

    public DateTime? TdpEditedDate { get; set; }
}

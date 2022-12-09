using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtActivityResponsilbility
{
    public int ArpIdpk { get; set; }

    public string? ArpName { get; set; }

    public string? ArpShtName { get; set; }

    public bool? ArpActive { get; set; }

    public string? ArpRmks { get; set; }

    public int? ArpCreatedBy { get; set; }

    public int? ArpEditedBy { get; set; }

    public DateTime? ArpCreationDate { get; set; }

    public DateTime? ArpEditedDate { get; set; }
}

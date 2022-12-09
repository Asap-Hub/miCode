using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOmgReason
{
    public int RsnIdpk { get; set; }

    public string? RsnName { get; set; }

    public string? RsnShtName { get; set; }

    public string? RsnCode { get; set; }

    public bool? RsnActive { get; set; }

    public string? RsnRmks { get; set; }

    public int? RsnCreatedBy { get; set; }

    public int? RsnEditedBy { get; set; }

    public DateTime? RsnCreationDate { get; set; }

    public DateTime? RsnEditedDate { get; set; }
}

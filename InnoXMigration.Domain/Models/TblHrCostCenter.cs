using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCostCenter
{
    public int FcctIdpk { get; set; }

    public string? FcctName { get; set; }

    public string? FcctShtName { get; set; }

    public string? FcctCode { get; set; }

    public bool? FcctActive { get; set; }

    public string? FcctRmks { get; set; }

    public int? FcctCreatedBy { get; set; }

    public int? FcctEditedBy { get; set; }

    public DateTime? FcctCreationDate { get; set; }

    public DateTime? FcctEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompCompType
{
    public int FcctIdpk { get; set; }

    public int? FcctCompIdfk { get; set; }

    public int? FcctCompTypeIdfk { get; set; }

    public DateTime? FcctStartDate { get; set; }

    public DateTime? FcctEndDate { get; set; }

    public string? FcctRmks { get; set; }

    public bool? FcctActive { get; set; }

    public int? FcctCreatedBy { get; set; }

    public int? FcctEditedBy { get; set; }

    public DateTime? FcctCreationDate { get; set; }

    public DateTime? FcctEditedDate { get; set; }
}

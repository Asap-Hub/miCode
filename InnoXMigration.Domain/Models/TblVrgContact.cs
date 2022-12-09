using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgContact
{
    public int FcntIdpk { get; set; }

    public string? FcntName { get; set; }

    public string? FcntMobNo { get; set; }

    public string? FcntEmail { get; set; }

    public string? FcntFax { get; set; }

    public bool? FcntActive { get; set; }

    public string? FcntRmks { get; set; }

    public int? FcntCreatedBy { get; set; }

    public int? FcntEditedBy { get; set; }

    public DateTime? FcntCreationDate { get; set; }

    public DateTime? FcntEditedDate { get; set; }
}

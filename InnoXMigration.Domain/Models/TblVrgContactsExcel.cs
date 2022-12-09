using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgContactsExcel
{
    public int? FccdIdpk { get; set; }

    public int? FccdCompIdfk { get; set; }

    public string? FcntName { get; set; }

    public string? FcntMobNo { get; set; }

    public string? FcntEmail { get; set; }

    public string? FcntFax { get; set; }

    public DateTime? FccdStartDate { get; set; }

    public DateTime? FccdEndDate { get; set; }

    public bool? FccdPrimary { get; set; }

    public bool? FccdActive { get; set; }

    public string? FccdRmks { get; set; }

    public int? FccdCreatedBy { get; set; }

    public int? FccdEditedBy { get; set; }

    public DateTime? FccdCreationDate { get; set; }

    public DateTime? FccdEditedDate { get; set; }
}

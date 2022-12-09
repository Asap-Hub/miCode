using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompContact
{
    public int FccdIdpk { get; set; }

    public int? FccdCompIdfk { get; set; }

    public string? FccdContactName { get; set; }

    public string? FccdFname { get; set; }

    public string? FccdMobNo { get; set; }

    public string? FccdEmail { get; set; }

    public string? FccdFax { get; set; }

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

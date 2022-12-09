using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsContactType
{
    public int FcttIdpk { get; set; }

    public string? FcttName { get; set; }

    public string? FcttShtName { get; set; }

    public bool? FcttMainContact { get; set; }

    public bool? FcttActive { get; set; }

    public string? FcttRmks { get; set; }

    public int? FcttCreatedBy { get; set; }

    public int? FcttEditedBy { get; set; }

    public DateTime? FcttCreationDate { get; set; }

    public DateTime? FcttEditedDate { get; set; }
}

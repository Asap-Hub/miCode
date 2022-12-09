using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsFuelTopupRequestWindow
{
    public int FtwIdpk { get; set; }

    public string? FtwName { get; set; }

    public string? FtwShtName { get; set; }

    public DateTime? FtwStartDate { get; set; }

    public DateTime? FtwEndDate { get; set; }

    public bool? FtwOpened { get; set; }

    public bool? FtwActive { get; set; }

    public string? FtwRmks { get; set; }

    public string? FtwCreatedBy { get; set; }

    public int? FtwEditedBy { get; set; }

    public DateTime? FtwCreationDate { get; set; }

    public DateTime? FtwEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgDefaultSm
{
    public int FvdsIdpk { get; set; }

    public string? FvdsTitle { get; set; }

    public string? FvdsMessage { get; set; }

    public bool? FvdsActive { get; set; }

    public string? FvdsRmks { get; set; }

    public int? FvdsCreatedBy { get; set; }

    public int? FvdsEditedBy { get; set; }

    public DateTime? FvdsCreationDate { get; set; }

    public DateTime? FvdsEditedDate { get; set; }
}

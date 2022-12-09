using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrAreasx
{
    public int FareIdpk { get; set; }

    public string? FareName { get; set; }

    public string? FareShtName { get; set; }

    public bool? FareActive { get; set; }

    public string? FareRmks { get; set; }

    public int? FareCreatedby { get; set; }

    public int? FareLastEditedBy { get; set; }

    public DateTime? FareCreationDate { get; set; }

    public DateTime? FareLastEditedDate { get; set; }
}

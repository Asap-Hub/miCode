using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrDeliveredBy
{
    public int DbyIdpk { get; set; }

    public string? DbyName { get; set; }

    public string? DbyShtName { get; set; }

    public bool? DbyActive { get; set; }

    public string? DbyRmks { get; set; }

    public int? DbyCreatedby { get; set; }

    public int? DbyEditedBy { get; set; }

    public DateTime? DbyCreationDate { get; set; }

    public DateTime? DbyEditedDate { get; set; }
}

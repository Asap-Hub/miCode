using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrDeliveryMethod
{
    public int DlmIdpk { get; set; }

    public string? DlmName { get; set; }

    public string? DlmShtName { get; set; }

    public bool? DlmActive { get; set; }

    public string? DlmRmks { get; set; }

    public int? DlmCreatedby { get; set; }

    public int? DlmEditedBy { get; set; }

    public DateTime? DlmCreationDate { get; set; }

    public DateTime? DlmEditedDate { get; set; }
}

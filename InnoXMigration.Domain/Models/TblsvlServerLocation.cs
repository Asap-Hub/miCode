using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlServerLocation
{
    public int SlcIdpk { get; set; }

    public string? SlcName { get; set; }

    public string? SlcShtName { get; set; }

    public bool? SlcActive { get; set; }

    public string? SlcRmks { get; set; }

    public int? SlcCreatedBy { get; set; }

    public int? SlcEditedBy { get; set; }

    public DateTime? SlcCreationDate { get; set; }

    public DateTime? SlcEditedDate { get; set; }
}

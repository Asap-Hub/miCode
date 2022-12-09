using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenMobileServiceProvider
{
    public int MspIdpk { get; set; }

    public string? MspName { get; set; }

    public string? MspShtName { get; set; }

    public bool? MspActive { get; set; }

    public string? MspRmks { get; set; }

    public int? MspCreatedBy { get; set; }

    public int? MspEditedBy { get; set; }

    public DateTime? MspCreationDate { get; set; }

    public DateTime? MspEditedDate { get; set; }
}

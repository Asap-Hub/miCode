using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtAdditionalResource
{
    public int AdrIdpk { get; set; }

    public string? AdrName { get; set; }

    public string? AdrShtName { get; set; }

    public bool? AdrActive { get; set; }

    public string? AdrRmks { get; set; }

    public int? AdrCreatedBy { get; set; }

    public int? AdrEditedBy { get; set; }

    public DateTime? AdrCreationDate { get; set; }

    public DateTime? AdrEditedDate { get; set; }
}

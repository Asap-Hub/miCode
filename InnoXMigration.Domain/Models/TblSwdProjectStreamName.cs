using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectStreamName
{
    public int PsnIdpk { get; set; }

    public string? PsnName { get; set; }

    public string? PsnShtName { get; set; }

    public int? PsnProjectIdfk { get; set; }

    public bool? PsnMasterStream { get; set; }

    public bool? PsnActive { get; set; }

    public string? PsnRmks { get; set; }

    public int? PsnCreatedBy { get; set; }

    public int? PsnEditedBy { get; set; }

    public DateTime? PsnCreationDate { get; set; }

    public DateTime? PsnEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdFunctionalDomain
{
    public int FdmIdpk { get; set; }

    public string? FdmName { get; set; }

    public string? FdmShtName { get; set; }

    public bool? FdmActive { get; set; }

    public string? FdmRmks { get; set; }

    public int? FdmCreatedBy { get; set; }

    public int? FdmEditedBy { get; set; }

    public DateTime? FdmCreationDate { get; set; }

    public DateTime? FdmEditedDate { get; set; }
}

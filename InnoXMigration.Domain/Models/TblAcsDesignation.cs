using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsDesignation
{
    public int FdsgIdpk { get; set; }

    public string? FdsgName { get; set; }

    public string? FdsgShtName { get; set; }

    public bool? FdsgActive { get; set; }

    public string? FdsgRmks { get; set; }

    public int? FdsgCreatedBy { get; set; }

    public int? FdsgEditedBy { get; set; }

    public DateTime? FdsgCreationDate { get; set; }

    public DateTime? FdsgEditedDate { get; set; }
}

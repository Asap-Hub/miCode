using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectStatus
{
    public int PstIdpk { get; set; }

    public string? PstName { get; set; }

    public string? PstShtName { get; set; }

    public decimal? PstOrder { get; set; }

    public bool? PstActive { get; set; }

    public string? PstRmks { get; set; }

    public int? PstCreatedBy { get; set; }

    public int? PstEditedBy { get; set; }

    public DateTime? PstCreationDate { get; set; }

    public DateTime? PstEditedDate { get; set; }
}

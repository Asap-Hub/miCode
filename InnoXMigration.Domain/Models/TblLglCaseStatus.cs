using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseStatus
{
    public int CstIdpk { get; set; }

    public string? CstName { get; set; }

    public string? CstShtName { get; set; }

    public byte? CstOrder { get; set; }

    public bool? CstActive { get; set; }

    public string? CstRmks { get; set; }

    public int? CstCreatedBy { get; set; }

    public int? CstEditedBy { get; set; }

    public DateTime? CstCreationDate { get; set; }

    public DateTime? CstEditedDate { get; set; }
}

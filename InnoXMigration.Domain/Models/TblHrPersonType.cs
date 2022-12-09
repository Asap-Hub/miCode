using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrPersonType
{
    public int PstIdpk { get; set; }

    public string PstName { get; set; } = null!;

    public string? PstShtName { get; set; }

    public bool? PstExEmp { get; set; }

    public bool? PstActive { get; set; }

    public string? PstRmks { get; set; }

    public int? PstCreatedBy { get; set; }

    public int? PstEditedBy { get; set; }

    public DateTime? PstCreationDate { get; set; }

    public DateTime? PstEditedDate { get; set; }
}

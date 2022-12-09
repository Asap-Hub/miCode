using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgPersonnelSetup
{
    public int PstIdpk { get; set; }

    public int? PstEmpIdfk { get; set; }

    public DateTime? PstDate { get; set; }

    public bool? PstInspect { get; set; }

    public bool? PstRecommend { get; set; }

    public bool? PstApprove { get; set; }

    public bool? PstActive { get; set; }

    public string? PstRmks { get; set; }

    public int? PstCreatedBy { get; set; }

    public int? PstEditedBy { get; set; }

    public DateTime? PstCreationDate { get; set; }

    public DateTime? PstEditedDate { get; set; }
}

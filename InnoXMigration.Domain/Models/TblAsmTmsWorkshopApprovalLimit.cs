using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsWorkshopApprovalLimit
{
    public int WalIdpk { get; set; }

    public int? WalEmpIdfk { get; set; }

    public int? WalWorkshopIdfk { get; set; }

    public bool? WalSubmit { get; set; }

    public bool? WalPrepare { get; set; }

    public bool? WalRecommend { get; set; }

    public bool? WalAuthorise { get; set; }

    public bool? WalActive { get; set; }

    public string? WalRmks { get; set; }

    public int? WalCreatedBy { get; set; }

    public int? WalEditedBy { get; set; }

    public DateTime? WalCreationDate { get; set; }

    public DateTime? WalEditedDate { get; set; }
}

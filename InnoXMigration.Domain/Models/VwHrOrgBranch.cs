using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrOrgBranch
{
    public int ObrIdpk { get; set; }

    public string? ObrName { get; set; }

    public string? ObrShtName { get; set; }

    public string? ObrCode { get; set; }

    public int? ObrHeadEmpIdfk { get; set; }

    public DateTime? ObrStartDate { get; set; }

    public DateTime? ObrEndDate { get; set; }

    public bool? ObrActive { get; set; }

    public string? ObrRmks { get; set; }

    public int? ObrCreatedBy { get; set; }

    public int? ObrEditedBy { get; set; }

    public DateTime? ObrCreationDate { get; set; }

    public DateTime? ObrEditedDate { get; set; }

    public int HeadEmpId { get; set; }

    public string HeadStaffNo { get; set; } = null!;

    public string HeadLastName { get; set; } = null!;

    public string HeadFirstName { get; set; } = null!;

    public string HeadOtherNames { get; set; } = null!;

    public string HeadEmpName { get; set; } = null!;

    public string HeadEmpName1 { get; set; } = null!;

    public string HeadEmpName2 { get; set; } = null!;

    public string HeadEmpName3 { get; set; } = null!;

    public string HeadEmpName4 { get; set; } = null!;

    public string HeadEmpName5 { get; set; } = null!;

    public int HeadObrId { get; set; }

    public string HeadObrName { get; set; } = null!;

    public string HeadObrShtName { get; set; } = null!;

    public int HeadSxnId { get; set; }

    public string HeadSxnName { get; set; } = null!;

    public string HeadSxnShtName { get; set; } = null!;

    public int HeadTitId { get; set; }

    public string HeadTitName { get; set; } = null!;

    public int HeadLocId { get; set; }

    public string HeadLocName { get; set; } = null!;

    public string HeadLocShtName { get; set; } = null!;

    public int HeadJbtId { get; set; }

    public string HeadJbtName { get; set; } = null!;

    public string HeadJbtShtName { get; set; } = null!;
}

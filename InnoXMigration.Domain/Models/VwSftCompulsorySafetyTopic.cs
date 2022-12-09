using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftCompulsorySafetyTopic
{
    public int CstIdpk { get; set; }

    public int? CstSafetyGroupIdfk { get; set; }

    public int? CstSafetyTopicIdfk { get; set; }

    public bool? CstActive { get; set; }

    public int StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public bool? StpRejected { get; set; }

    public bool? StpRecommended { get; set; }

    public bool? StpApproved { get; set; }

    public bool? StpEdit { get; set; }

    public bool? StpActive { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public DateTime? SgpEndDate { get; set; }

    public string CstRmks { get; set; } = null!;

    public bool CstApproved { get; set; }

    public bool CstTreated { get; set; }

    public string CstResourcePersons { get; set; } = null!;

    public byte CstCompulsoryNo { get; set; }

    public int McdIdpk { get; set; }

    public string? McdName { get; set; }

    public string? McdShtName { get; set; }

    public DateTime? McdStartDate { get; set; }

    public DateTime? McdEndDate { get; set; }
}

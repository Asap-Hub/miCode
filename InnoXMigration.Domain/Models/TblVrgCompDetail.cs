using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompDetail
{
    public int FcdtIdpk { get; set; }

    public string? FcdtName { get; set; }

    public string? FcdtShtName { get; set; }

    public int? FcdtLocIdfk { get; set; }

    public string? FcdtMainEmail { get; set; }

    public string? FcdtOtherEmail { get; set; }

    public string? FcdtMainMobNo { get; set; }

    public string? FcdtOtherMobNo { get; set; }

    public string? FcdtMainTelNo { get; set; }

    public string? FcdtOtherTelNo { get; set; }

    public string? FcdtMainAddress { get; set; }

    public string? FcdtOtherAddress { get; set; }

    public string? FcdtPhysicalAddress { get; set; }

    public string? FcdtMainFax { get; set; }

    public string? FcdtOtherFax { get; set; }

    public int? FcdtSalutationIdfk { get; set; }

    public string? FcdtWebsite { get; set; }

    public int? FcdtCompletedByEmpIdfk { get; set; }

    public int? FcdtRecommendedByEmpIdfk { get; set; }

    public int? FcdtApprovedByEmpIdfk { get; set; }

    public int? FcdtPrimaryContactIdfk { get; set; }

    public bool? FcdtInspected { get; set; }

    public bool? FcdtRecommeded { get; set; }

    public bool? FcdtApproved { get; set; }

    public bool? FcdtActive { get; set; }

    public string? FcdtRmks { get; set; }

    public int? FcdtCreatedBy { get; set; }

    public int? FcdtEditedBy { get; set; }

    public DateTime? FcdtCreationDate { get; set; }

    public DateTime? FcdtEditedDate { get; set; }
}

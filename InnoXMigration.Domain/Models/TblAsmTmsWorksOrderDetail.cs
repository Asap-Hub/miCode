using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsWorksOrderDetail
{
    public int WodIdpk { get; set; }

    public DateTime? WodDate { get; set; }

    public int? WodMaintActivityIdfk { get; set; }

    public int? WodJobDetailIdfk { get; set; }

    public decimal? WodCost { get; set; }

    public decimal? WodTotalCost { get; set; }

    public decimal? WodVatCharge { get; set; }

    public decimal? WodDiscount { get; set; }

    public int? WodCurrencyIdfk { get; set; }

    public int? WodExtWorkshopIdfk { get; set; }

    public int? WodIntWorkshopIdfk { get; set; }

    public string? WodReferenceNo { get; set; }

    public int? WodPreparedByEmpIdfk { get; set; }

    public DateTime? WodPreparedOn { get; set; }

    public int? WodRecommendedByEmpIdfk { get; set; }

    public DateTime? WodRecommendedOn { get; set; }

    public int? WodAuthorisedByEmpIdfk { get; set; }

    public DateTime? WodAuthorisedOn { get; set; }

    public bool? WodSubmitted { get; set; }

    public DateTime? WodSubmittedOn { get; set; }

    public int? WodSubmittedByEmpIdfk { get; set; }

    public bool? WodPrepared { get; set; }

    public bool? WodRecommended { get; set; }

    public bool? WodAuthorised { get; set; }

    public bool? WodActive { get; set; }

    public string? WodRmks { get; set; }

    public string? WodCreatedBy { get; set; }

    public int? WodEditedBy { get; set; }

    public int? WodDeletedBy { get; set; }

    public DateTime? WodCreationDate { get; set; }

    public DateTime? WodEditedDate { get; set; }

    public DateTime? WodDeletionDate { get; set; }
}

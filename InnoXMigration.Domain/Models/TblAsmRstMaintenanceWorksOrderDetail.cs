using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstMaintenanceWorksOrderDetail
{
    public int MwdIdpk { get; set; }

    public DateTime? MwdDate { get; set; }

    public int? MwdMaintActivityIdfk { get; set; }

    public int? MwdJobDetailIdfk { get; set; }

    public decimal? MwdCost { get; set; }

    public decimal? MwdVatCharge { get; set; }

    public decimal? MwdTotalCost { get; set; }

    public decimal? MwdDiscount { get; set; }

    public int? MwdCurrencyIdfk { get; set; }

    public int? MwdContractorIdfk { get; set; }

    public string? MwdReferenceNo { get; set; }

    public int? MwdPreparedByEmpIdfk { get; set; }

    public DateTime? MwdPreparedOn { get; set; }

    public int? MwdRecommendedByEmpIdfk { get; set; }

    public DateTime? MwdRecommendedOn { get; set; }

    public int? MwdAuthorisedByEmpIdfk { get; set; }

    public DateTime? MwdAuthorisedOn { get; set; }

    public bool? MwdSubmitted { get; set; }

    public DateTime? MwdSubmittedOn { get; set; }

    public int? MwdSubmittedByEmpIdfk { get; set; }

    public bool? MwdPrepared { get; set; }

    public bool? MwdRecommended { get; set; }

    public bool? MwdAuthorised { get; set; }

    public bool? MwdActive { get; set; }

    public string? MwdRmks { get; set; }

    public string? MwdCreatedBy { get; set; }

    public int? MwdEditedBy { get; set; }

    public int? MwdDeletedBy { get; set; }

    public DateTime? MwdCreationDate { get; set; }

    public DateTime? MwdEditedDate { get; set; }

    public DateTime? MwdDeletionDate { get; set; }
}

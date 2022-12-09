using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompMaintenanceActivityMaterial
{
    public int MamIdpk { get; set; }

    public DateTime? MamDate { get; set; }

    public int? MamMaintActivityIdfk { get; set; }

    public int? MamRelatedJobIdfk { get; set; }

    public int? MamMaterialIdfk { get; set; }

    public decimal? MamUnitPrice { get; set; }

    public decimal? MamQuantity { get; set; }

    public decimal? MamVatCharge { get; set; }

    public decimal? MamDiscount { get; set; }

    public string? MamQuantityUnit { get; set; }

    public int? MamCurrencyIdfk { get; set; }

    public string? MamRequisitionNo { get; set; }

    public string? MamCode { get; set; }

    public string? MamStoreNo { get; set; }

    public int? MamSubmittedByEmpIdfk { get; set; }

    public DateTime? MamSubmittedOn { get; set; }

    public int? MamPreparedByEmpIdfk { get; set; }

    public DateTime? MamPreparedOn { get; set; }

    public int? MamRecommendedByEmpIdfk { get; set; }

    public DateTime? MamRecommendedOn { get; set; }

    public int? MamAuthorisedByEmpIdfk { get; set; }

    public DateTime? MamAuthorisedOn { get; set; }

    public bool? MamSubmitted { get; set; }

    public bool? MamPrepared { get; set; }

    public bool? MamRecommended { get; set; }

    public bool? MamAuthorised { get; set; }

    public bool? MamActive { get; set; }

    public string? MamRmks { get; set; }

    public string? MamCreatedBy { get; set; }

    public int? MamEditedBy { get; set; }

    public int? MamDeletedBy { get; set; }

    public DateTime? MamCreationDate { get; set; }

    public DateTime? MamEditedDate { get; set; }

    public DateTime? MamDeletionDate { get; set; }
}

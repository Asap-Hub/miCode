using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompMaintenanceActivityInvoiceDetail
{
    public int MaiIdpk { get; set; }

    public DateTime? MaiDate { get; set; }

    public int? MaiMaintActivityIdfk { get; set; }

    public int? MaiRelatedJobIdfk { get; set; }

    public string? MaiReferenceNo { get; set; }

    public int? MaiInvoiceNo { get; set; }

    public decimal? MaiAmount { get; set; }

    public decimal? MaiVatCharge { get; set; }

    public decimal? MaiDiscount { get; set; }

    public int? MaiCurrencyIdfk { get; set; }

    public int? MaiSubmittedByEmpIdfk { get; set; }

    public DateTime? MaiSubmittedOn { get; set; }

    public int? MaiPreparedByEmpIdfk { get; set; }

    public DateTime? MaiPreparedOn { get; set; }

    public int? MaiRecommendedByEmpIdfk { get; set; }

    public DateTime? MaiRecommendedOn { get; set; }

    public int? MaiAuthorisedByEmpIdfk { get; set; }

    public DateTime? MaiAuthorisedOn { get; set; }

    public bool? MaiSubmitted { get; set; }

    public bool? MaiPrepared { get; set; }

    public bool? MaiRecommended { get; set; }

    public bool? MaiAuthorised { get; set; }

    public bool? MaiActive { get; set; }

    public string? MaiRmks { get; set; }

    public string? MaiCreatedBy { get; set; }

    public int? MaiEditedBy { get; set; }

    public int? MaiDeletedBy { get; set; }

    public DateTime? MaiCreationDate { get; set; }

    public DateTime? MaiEditedDate { get; set; }

    public DateTime? MaiDeletionDate { get; set; }
}

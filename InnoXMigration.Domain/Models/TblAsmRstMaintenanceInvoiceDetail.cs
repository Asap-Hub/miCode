using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmRstMaintenanceInvoiceDetail
{
    public int MidIdpk { get; set; }

    public DateTime? MidDate { get; set; }

    public int? MidMaintActivityIdfk { get; set; }

    public int? MidJobDetailIdfk { get; set; }

    public decimal? MidCost { get; set; }

    public decimal? MidVatCharge { get; set; }

    public decimal? MidDiscount { get; set; }

    public decimal? MidTotalCost { get; set; }

    public int? MidCurrencyIdfk { get; set; }

    public int? MidExtWorkshopIdfk { get; set; }

    public int? MidIntWorkshopIdfk { get; set; }

    public string? MidReferenceNo { get; set; }

    public int? MidPreparedByEmpIdfk { get; set; }

    public DateTime? MidPreparedOn { get; set; }

    public int? MidRecommendedByEmpIdfk { get; set; }

    public DateTime? MidRecommendedOn { get; set; }

    public int? MidAuthorisedByEmpIdfk { get; set; }

    public DateTime? MidAuthorisedOn { get; set; }

    public bool? MidSubmitted { get; set; }

    public DateTime? MidSubmittedOn { get; set; }

    public int? MidSubmittedByEmpIdfk { get; set; }

    public bool? MidPrepared { get; set; }

    public bool? MidRecommended { get; set; }

    public bool? MidAuthorised { get; set; }

    public bool? MidActive { get; set; }

    public string? MidRmks { get; set; }

    public string? MidCreatedBy { get; set; }

    public int? MidEditedBy { get; set; }

    public int? MidDeletedBy { get; set; }

    public DateTime? MidCreationDate { get; set; }

    public DateTime? MidEditedDate { get; set; }

    public DateTime? MidDeletionDate { get; set; }
}

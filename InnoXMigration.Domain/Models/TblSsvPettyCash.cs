using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvPettyCash
{
    public int PtcIdpk { get; set; }

    public int? PtcRequesterEmpIdfk { get; set; }

    public int? PtcRequestAreaIdfk { get; set; }

    public int? PtcAuthorisedByEmpIdfk { get; set; }

    public int? PtcCashierEmpIdfk { get; set; }

    public int? PtcCancelledByEmpIdfk { get; set; }

    public DateTime? PtcRequestDate { get; set; }

    public string? PtcParticulars { get; set; }

    public decimal? PtcAmount { get; set; }

    public DateTime? PtcAuthorisedOn { get; set; }

    public DateTime? PtcDisbursedOn { get; set; }

    public DateTime? PtcCancelledOn { get; set; }

    public string? PtcAuthoriseRmks { get; set; }

    public string? PtcDisburseRmks { get; set; }

    public string? PtcCancelledRmks { get; set; }

    public bool? PtcAuthorised { get; set; }

    public bool? PtcCancelled { get; set; }

    public bool? PtcSmsSent { get; set; }

    public bool? PtcDisbursed { get; set; }

    public bool? PtcActive { get; set; }

    public string? PtcRmks { get; set; }

    public string? PtcCreatedBy { get; set; }

    public int? PtcEditedBy { get; set; }

    public DateTime? PtcCreationDate { get; set; }

    public DateTime? PtcEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsReceivablesBroughtForward
{
    public int RbfIdpk { get; set; }

    public int? FrbcustIdfk { get; set; }

    public DateTime? RbfDate { get; set; }

    public double? RbfTscghc { get; set; }

    public double? RbfTscusd { get; set; }

    public double? RbfRegLev { get; set; }

    public double? RbfJanArrearsGhc { get; set; }

    public double? RbfJanArrearsUsd { get; set; }

    public double? RbfPaymentGhc { get; set; }

    public double? RbfPaymentUsd { get; set; }

    public double? RbfRecBrFwdGhc { get; set; }

    public double? RbfRecBrFwdUsd { get; set; }

    public double? RbfTotAmtPayablUsd { get; set; }

    public double? RbfTotAmtPayableGhc { get; set; }

    public string? Rbrmks { get; set; }

    public int? RbfPreparedByIdfk { get; set; }

    public string? RbfReviewedByIdfk { get; set; }

    public string? RbfSignedByIdfk { get; set; }

    public int? RbfCreatedBy { get; set; }

    public int? RbfEditedBy { get; set; }

    public DateTime? RbfCreationDate { get; set; }

    public DateTime? RbfEditedDate { get; set; }
}

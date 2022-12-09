using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRecBrForwad
{
    public int FrbfIdpk { get; set; }

    public int? FrbfCustIdfk { get; set; }

    public DateTime? FrbfDate { get; set; }

    public double? FrbfTscghc { get; set; }

    public double? FrbfTscusd { get; set; }

    public double? FrbfRegLev { get; set; }

    public double? FrbfJanArrearsGhc { get; set; }

    public double? FrbfJanArrearsUsd { get; set; }

    public double? FrbfPaymentGhc { get; set; }

    public double? FrbfPaymentUsd { get; set; }

    public double? FrbfRecBrFwdGhc { get; set; }

    public double? FrbfRecBrFwdUsd { get; set; }

    public double? FrbfTotAmtPayablUsd { get; set; }

    public double? FrbfTotAmtPayableGhc { get; set; }

    public string? FrbfRmks { get; set; }

    public int? FrbfPreparedByIdfk { get; set; }

    public string? FrbfReviewedByIdfk { get; set; }

    public string? FrbfSignedByIdfk { get; set; }

    public int? FrbfCreatedBy { get; set; }

    public int? FrbfEditedBy { get; set; }

    public DateTime? FrbfCreationDate { get; set; }

    public DateTime? FrbfEditedDate { get; set; }
}

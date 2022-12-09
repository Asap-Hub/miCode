using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAcsPayment
{
    public int FpayIdpk { get; set; }

    public int? FpayApplicantIdfk { get; set; }

    public int? FpayCurrencyIdfk { get; set; }

    public DateTime? FpayDate { get; set; }

    public double? FpayAmount { get; set; }

    public string? FpayRmks { get; set; }

    public int? FpayCreatedBy { get; set; }

    public int? FpayEditedBy { get; set; }

    public DateTime? FpayCreationDate { get; set; }

    public DateTime? FpayEditedDate { get; set; }
}

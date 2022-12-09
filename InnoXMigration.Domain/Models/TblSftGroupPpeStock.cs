using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftGroupPpeStock
{
    public int GpsIdpk { get; set; }

    public DateTime? GpsDate { get; set; }

    public int? GpsGroupIdfk { get; set; }

    public int? GpsIssuerEmpIdfk { get; set; }

    public int? GpsReceiverEmpIdfk { get; set; }

    public int? GpsRequestWindowIdfk { get; set; }

    public int? GpsBatchNo { get; set; }

    public string? GpsSource { get; set; }

    public bool? GpsSigned { get; set; }

    public string? GpsDeletionReason { get; set; }

    public DateTime? GpsDeletedOn { get; set; }

    public bool? GpsActive { get; set; }

    public string? GpsRmks { get; set; }

    public int? GpsCreatedBy { get; set; }

    public int? GpsEditedBy { get; set; }

    public DateTime? GpsSignedOffOn { get; set; }

    public DateTime? GpsCreationDate { get; set; }

    public DateTime? GpsEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompRecommendation
{
    public int CrcIdpk { get; set; }

    public int? CrcCompanyIdfk { get; set; }

    public DateTime? CrcDateRecommended { get; set; }

    public bool? CrcActive { get; set; }

    public string? CrcDeletionRmks { get; set; }

    public string? CrcRmks { get; set; }

    public int? CrcCreatedBy { get; set; }

    public int? CrcEditedBy { get; set; }

    public DateTime? CrcCreationDate { get; set; }

    public DateTime? CrcEditedDate { get; set; }
}

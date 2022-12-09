using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftStationSectionItemsAssignment
{
    public int SiaIdpk { get; set; }

    public int? SiaSafetyGroupIdfk { get; set; }

    public int? SiaInspectionStationIdfk { get; set; }

    public int? SiaInspectionSectionIdfk { get; set; }

    public int? SiaItemIdfk { get; set; }

    public bool? SiaActive { get; set; }

    public int WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public int IsnIdpk { get; set; }

    public string? IsnName { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime SgpDateFormed { get; set; }

    public bool SgpActive { get; set; }

    public bool? WstActive { get; set; }

    public string? IsnShtName { get; set; }

    public bool? IsnActive { get; set; }

    public int IitIdpk { get; set; }

    public string? IitName { get; set; }

    public string? IitShtName { get; set; }

    public bool? IitActive { get; set; }

    public int GznIdpk { get; set; }

    public string GznName { get; set; } = null!;

    public string GznShtName { get; set; } = null!;

    public int GtmIdpk { get; set; }

    public string GtmName { get; set; } = null!;

    public string GtmShtName { get; set; } = null!;

    public bool GtmActive { get; set; }

    public string? SiaRmks { get; set; }

    public DateTime? SiaStartDate { get; set; }

    public DateTime? SiaEndDate { get; set; }

    public bool? IsnFirstAidKitChecklist { get; set; }

    public decimal SiaOrder { get; set; }

    public bool SiaPositiveAnswerYes { get; set; }
}

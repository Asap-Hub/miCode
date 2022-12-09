using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmCoreValue
{
    public int CvlIdpk { get; set; }

    public string? CvlMissionIdfk { get; set; }

    public string? CvlCategory { get; set; }

    public string? CvlCoreValue { get; set; }

    public string? CvlShtCoreValue { get; set; }

    public DateTime? CvlStartDate { get; set; }

    public DateTime? CvlEndDate { get; set; }

    public int CvlDeptIdfk { get; set; }

    public int CvlSectionIdfk { get; set; }

    public int CvlUnitIdfk { get; set; }

    public bool CvlActive { get; set; }

    public string CvlRmks { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public bool DptActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string SxnCode { get; set; } = null!;

    public bool SxnActive { get; set; }

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string UntCode { get; set; } = null!;

    public bool UntActive { get; set; }

    public int MvsIdpk { get; set; }

    public string MvsName { get; set; } = null!;

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public bool? MvsActive { get; set; }

    public string MvsRmks { get; set; } = null!;

    public int? CvlOrder { get; set; }
}

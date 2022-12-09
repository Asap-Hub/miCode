using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmUnitInitiativeAssignment
{
    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public string? DptCode { get; set; }

    public string? SxnCode { get; set; }

    public int UiaIdpk { get; set; }

    public int? UiaPeriodIdfk { get; set; }

    public int? UiaSectionIdfk { get; set; }

    public int? UiaUnitIdfk { get; set; }

    public int? UiaUnitInitiativeIdfk { get; set; }

    public bool? UiaActive { get; set; }

    public string? UiaRmks { get; set; }

    public int? SxiIdpk { get; set; }

    public int? SxiSectionIdfk { get; set; }

    public int? MvsIdpk { get; set; }

    public string? MvsName { get; set; }

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public int? ThmIdpk { get; set; }

    public string? ThmName { get; set; }

    public int? ObjIdpk { get; set; }

    public string? ObjObjective { get; set; }

    public int? PtvIdpk { get; set; }

    public string? PtvName { get; set; }

    public int? CinIdpk { get; set; }

    public string? CinName { get; set; }

    public string? CinShtName { get; set; }

    public int? PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? UinIdpk { get; set; }

    public string? UinName { get; set; }

    public string? UinShtName { get; set; }

    public bool? UinActive { get; set; }

    public bool? SxiActive { get; set; }

    public int? UiaCorporateInitiativeAssignmentIdfk { get; set; }

    public bool? ObjActive { get; set; }
}

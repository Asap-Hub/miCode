using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmInitiativesTargetsAssignment
{
    public int ItaIdpk { get; set; }

    public string? ItaInitiativeIdfk { get; set; }

    public string? ItaTargetIdfk { get; set; }

    public bool? ItaActive { get; set; }

    public int SinIdpk { get; set; }

    public string? SinName { get; set; }

    public string? SinShtName { get; set; }

    public bool? SinActive { get; set; }

    public int TgtIdpk { get; set; }

    public string? TgtName { get; set; }

    public string? TgtShtName { get; set; }

    public bool? TgtActive { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsUserClass
{
    public int UcsIdpk { get; set; }

    public int? UcsClassIdfk { get; set; }

    public int? UcsSubClassIdfk { get; set; }

    public bool? UcsActive { get; set; }

    public string? UcsRmks { get; set; }

    public int DcsIdpk { get; set; }

    public string? DcsName { get; set; }

    public string? DcsShtname { get; set; }

    public string? UcsClassCode { get; set; }

    public string? UcsSubClassCode { get; set; }

    public bool? DcsActive { get; set; }

    public int DscIdpk { get; set; }

    public string? DscName { get; set; }

    public string? DscShtName { get; set; }

    public bool? DscActive { get; set; }

    public int? UcsAssignUnitIdfk { get; set; }

    public int DcuIdpk { get; set; }

    public string? DcuName { get; set; }

    public string? DcuShtName { get; set; }

    public string? DcuCode { get; set; }

    public bool? DcuActive { get; set; }

    public string? DcuRmks { get; set; }

    public int? UcsUserIdfk { get; set; }
}

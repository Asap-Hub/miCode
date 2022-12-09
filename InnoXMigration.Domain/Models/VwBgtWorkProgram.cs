using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBgtWorkProgram
{
    public int WkpIdpk { get; set; }

    public int? BgtIdpk { get; set; }

    public string? BgtName { get; set; }

    public string? BgtShtName { get; set; }

    public DateTime? BgtStartDate { get; set; }

    public DateTime? BgtEndDate { get; set; }

    public string? WkpStatus { get; set; }

    public bool BgtActive { get; set; }

    public int DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? WkpBudgetIdfk { get; set; }

    public int? WkpActivityUnitIdfk { get; set; }

    public int? WkpAnnualTargetIdfk { get; set; }

    public string? WkpResponsibilities { get; set; }

    public string? WkpActivityHeader { get; set; }

    public string WkpQuarter1Target { get; set; } = null!;

    public string WkpQuarter1Achieved { get; set; } = null!;

    public string WkpQuarter2Target { get; set; } = null!;

    public string WkpQuarter2Achieved { get; set; } = null!;

    public string WkpQuarter3Target { get; set; } = null!;

    public string WkpQuarter3Achieved { get; set; } = null!;

    public string WkpQuarter4Target { get; set; } = null!;

    public string WkpQuarter4Achieved { get; set; } = null!;

    public decimal WkpPercentageComplete { get; set; }

    public string WkpActivity { get; set; } = null!;

    public string? WkpAdditionalResources { get; set; }

    public bool WkpActive { get; set; }

    public string WkpRmks { get; set; } = null!;

    public string BgtRmks { get; set; } = null!;

    public string? DptCode { get; set; }

    public bool? DptActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? SxnDeptIdfk { get; set; }

    public string? SxnCode { get; set; }

    public bool? SxnActive { get; set; }

    public int? AcuIdpk { get; set; }

    public string? AcuName { get; set; }

    public string? AcuShtName { get; set; }

    public bool? AcuActive { get; set; }

    public int? AntIdpk { get; set; }

    public string? AntName { get; set; }

    public string? AntShtName { get; set; }

    public bool? AntActive { get; set; }

    public int? WkpMeasureIdfk { get; set; }

    public int? MsrIdpk { get; set; }

    public string? MsrName { get; set; }

    public string? MsrShtName { get; set; }

    public bool? MsrActive { get; set; }

    public int? WkpSectionIdfk { get; set; }

    public int? WkpDeptIdfk { get; set; }
}

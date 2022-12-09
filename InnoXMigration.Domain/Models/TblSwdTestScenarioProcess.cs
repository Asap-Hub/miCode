using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdTestScenarioProcess
{
    public int TspIdpk { get; set; }

    public int? TspScenarioIdfk { get; set; }

    public int? TspProcessNo { get; set; }

    public string? TspTestCase { get; set; }

    public string? TspDescription { get; set; }

    public string? TspExpectedResult { get; set; }

    public string? TspActualTestResult { get; set; }

    public string? TspFailureComment { get; set; }

    public string? TspResolversComment { get; set; }

    public int? TspStatusIdfk { get; set; }

    public int? TspImpactIdfk { get; set; }

    public decimal? TspPercentageWeight { get; set; }

    public int? TspLastUpdatedBy { get; set; }

    public bool? TspAcknowledged { get; set; }

    public DateTime? TspAcknowledgedOn { get; set; }

    public int? TspAcknowledgedByEmpIdfk { get; set; }

    public bool? TspActive { get; set; }

    public bool? TspDeleted { get; set; }

    public string? TspRmks { get; set; }

    public string? TspDeletionReason { get; set; }

    public int? TspCreatedBy { get; set; }

    public int? TspEditedBy { get; set; }

    public int? TspDeletedByEmpIdfk { get; set; }

    public DateTime? TspCreationDate { get; set; }

    public DateTime? TspEditedDate { get; set; }

    public DateTime? TspDeletedOn { get; set; }
}

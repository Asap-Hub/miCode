using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmCorporateMeasure
{
    public int CmsIdpk { get; set; }

    public int? CmsPeriodIdfk { get; set; }

    public int? CmsPerspectiveIdfk { get; set; }

    public int? CmsMeasureIdfk { get; set; }

    public int? CmsTargetIdfk { get; set; }

    public bool? CmsActive { get; set; }

    public string? CmsRmks { get; set; }

    public int PrdIdpk { get; set; }

    public string? PrdName { get; set; }

    public string? PrdShtName { get; set; }

    public DateTime? PrdStartDate { get; set; }

    public DateTime? PrdEndDate { get; set; }

    public bool? PrdActive { get; set; }

    public int PtvIdpk { get; set; }

    public string? PtvName { get; set; }

    public string? PtvShtName { get; set; }

    public string? PtvQuestionsAnswered { get; set; }

    public bool? PtvActive { get; set; }

    public int MsrIdpk { get; set; }

    public string? MsrName { get; set; }

    public string? MsrShtName { get; set; }

    public bool? MsrActive { get; set; }

    public int TgtIdpk { get; set; }

    public string? TgtName { get; set; }

    public string? TgtShtName { get; set; }

    public bool? TgtActive { get; set; }

    public int? PtvOrder { get; set; }

    public bool? PtvFinancials { get; set; }

    public bool? PtvOrganisationalCapacity { get; set; }

    public bool? PtvCustomersStakeholders { get; set; }

    public bool? PtvBusinessProcesses { get; set; }
}

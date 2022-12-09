using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgPerspective
{
    public int PtvIdpk { get; set; }

    public string? PtvName { get; set; }

    public string? PtvShtName { get; set; }

    public string? PtvQuestionsAnswered { get; set; }

    public int? PtvOrder { get; set; }

    public bool? PtvFinancials { get; set; }

    public bool? PtvOrganisationalCapacity { get; set; }

    public bool? PtvCustomersStakeholders { get; set; }

    public bool? PtvBusinessProcesses { get; set; }

    public bool? PtvActive { get; set; }

    public string? PtvRmks { get; set; }

    public int? PtvCreatedBy { get; set; }

    public int? PtvEditedBy { get; set; }

    public DateTime? PtvCreationDate { get; set; }

    public DateTime? PtvEditedDate { get; set; }
}

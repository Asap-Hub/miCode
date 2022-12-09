using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUserAcceptanceTest
{
    public int UatIdpk { get; set; }

    public DateTime? UatStartDate { get; set; }

    public DateTime? UatEndDate { get; set; }

    public int? UatTestScenarioIdfk { get; set; }

    public int? UatLastUpdatedBy { get; set; }

    public bool? UatActive { get; set; }

    public string? UatRmks { get; set; }

    public int? UatCreatedBy { get; set; }

    public int? UatEditedBy { get; set; }

    public DateTime? UatCreationDate { get; set; }

    public DateTime? UatEditedDate { get; set; }
}

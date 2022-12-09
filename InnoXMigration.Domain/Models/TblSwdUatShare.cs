using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatShare
{
    public int UshIdpk { get; set; }

    public int? UshScenarioIdfk { get; set; }

    public int? UshEmpIdfk { get; set; }

    public bool? UshAdmin { get; set; }

    public bool? UshTester { get; set; }

    public bool? UshResolver { get; set; }

    public bool? UshReader { get; set; }

    public int? UshTeamLeadEmpIdfk { get; set; }

    public int? UshProcessOwnerEmpIdfk { get; set; }

    public bool? UshActive { get; set; }

    public int? UshCreatedBy { get; set; }

    public DateTime? UshCreationDate { get; set; }

    public int? UshEditedBy { get; set; }

    public DateTime? UshEditedDate { get; set; }
}

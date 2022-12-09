using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatComment
{
    public int UcmIdpk { get; set; }

    public int? UcmScenarioIdfk { get; set; }

    public int? UcmEmpIdfk { get; set; }

    public string? UcmComment { get; set; }

    public bool? UcmActive { get; set; }

    public int? UcmCreatedBy { get; set; }

    public int? UcmEditedBy { get; set; }

    public DateTime? UcmCreationDate { get; set; }

    public DateTime? UcmEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperatorViewStation
{
    public int OvaIdpk { get; set; }

    public int? OvaEmpIdfk { get; set; }

    public int? OvaSstIdfk { get; set; }

    public bool? OvaActive { get; set; }

    public string? OvaRmks { get; set; }

    public int? OvaCreatedBy { get; set; }

    public int? OvaEditedBy { get; set; }

    public DateTime? OvaCreationDate { get; set; }

    public DateTime? OvaEditedDate { get; set; }
}

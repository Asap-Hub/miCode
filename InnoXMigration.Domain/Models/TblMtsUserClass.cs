using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsUserClass
{
    public int UcsIdpk { get; set; }

    public int? UcsUserIdfk { get; set; }

    public int? UcsClassIdfk { get; set; }

    public int? UcsSubClassIdfk { get; set; }

    public int? UcsAssignUnitIdfk { get; set; }

    public string? UcsClassCode { get; set; }

    public string? UcsSubClassCode { get; set; }

    public bool? UcsActive { get; set; }

    public string? UcsRmks { get; set; }

    public DateTime? UcsCreationDate { get; set; }

    public DateTime? UcsEditedDate { get; set; }
}

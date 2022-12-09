using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsLastFileNumber
{
    public int LfnIdpk { get; set; }

    public int? LfnDocUnitIdfk { get; set; }

    public int? LfnClassIdfk { get; set; }

    public int? LfnSubClassIdfk { get; set; }

    public int? LfnLastNumber { get; set; }

    public int? LfnMaxNo { get; set; }

    public string? LfnRmks { get; set; }

    public int? LfnEditedBy { get; set; }

    public int? LfnCreatedBy { get; set; }

    public DateTime? LfnCreationDate { get; set; }

    public DateTime? LfnEditedDate { get; set; }
}

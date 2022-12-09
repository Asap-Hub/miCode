using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsDocReadStatus
{
    public int DrsIdpk { get; set; }

    public int? DrsDocIdfk { get; set; }

    public string? DrsDocSource { get; set; }

    public int? DrsEmpIdfk { get; set; }

    public DateTime? DrsDateRead { get; set; }

    public DateTime? DrsDateLastSeen { get; set; }
}

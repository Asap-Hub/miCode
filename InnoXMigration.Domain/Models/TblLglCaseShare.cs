using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseShare
{
    public int CshIdpk { get; set; }

    public int? CshCaseIdfk { get; set; }

    public int? CshEmpIdfk { get; set; }

    public bool? CshOwn { get; set; }

    public bool? CshUpdate { get; set; }

    public bool? CshRead { get; set; }

    public bool? CshLock { get; set; }

    public bool? CshActive { get; set; }

    public bool? CshSign { get; set; }

    public string? CshTask { get; set; }

    public int? CshCreatedBy { get; set; }

    public DateTime? CshCreationDate { get; set; }

    public int? CshEditedBy { get; set; }

    public DateTime? CshEditedDate { get; set; }
}

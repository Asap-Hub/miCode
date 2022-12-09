using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbUserPrivilege
{
    public int EupIdpk { get; set; }

    public int? EupEmpIdfk { get; set; }

    public bool? EupViewAllLogsWithDate { get; set; }

    public DateTime? EupStartDate { get; set; }

    public DateTime? EupEndDate { get; set; }

    public bool? EupActive { get; set; }

    public string? EupRmks { get; set; }

    public int? EupCreatedBy { get; set; }

    public int? EupEditedBy { get; set; }

    public DateTime? EupCreationDate { get; set; }

    public DateTime? EupEditedDate { get; set; }
}

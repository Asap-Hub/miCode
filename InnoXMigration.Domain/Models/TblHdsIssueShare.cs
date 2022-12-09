using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueShare
{
    public int IshIdpk { get; set; }

    public int? IshIssueLogIdfk { get; set; }

    public int? IshEmpIdfk { get; set; }

    public bool? IshOwner { get; set; }

    public bool? IshUpdate { get; set; }

    public bool? IshReader { get; set; }

    public bool? IshSign { get; set; }

    public bool? IshActive { get; set; }

    public int? IshCreatedBy { get; set; }

    public DateTime? IshCreationDate { get; set; }

    public int? IshEditedBy { get; set; }

    public DateTime? IshEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobDescComment
{
    public int JdcIdpk { get; set; }

    public int? JdcJobDescIdfk { get; set; }

    public int? JdcEmpIdfk { get; set; }

    public string? JdcComment { get; set; }

    public bool? JdcActive { get; set; }

    public int? JdcCreatedBy { get; set; }

    public int? JdcEditedBy { get; set; }

    public DateTime? JdcCreationDate { get; set; }

    public DateTime? JdcEditedDate { get; set; }
}

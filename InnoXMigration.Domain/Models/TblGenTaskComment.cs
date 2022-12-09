using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTaskComment
{
    public int TcmIdpk { get; set; }

    public int? TcmTaskIdfk { get; set; }

    public int? TcmEmpIdfk { get; set; }

    public string? TcmComment { get; set; }

    public bool? TcmActive { get; set; }

    public int? TcmCreatedBy { get; set; }

    public int? TcmEditedBy { get; set; }

    public DateTime? TcmCreationDate { get; set; }

    public DateTime? TcmEditedDate { get; set; }
}

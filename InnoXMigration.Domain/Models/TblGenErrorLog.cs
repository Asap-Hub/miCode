using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenErrorLog
{
    public int ElgIdpk { get; set; }

    public string? ElgFormCode { get; set; }

    public string? ElgError { get; set; }

    public int? ElgCreatedBy { get; set; }

    public DateTime? ElgCreationDate { get; set; }
}

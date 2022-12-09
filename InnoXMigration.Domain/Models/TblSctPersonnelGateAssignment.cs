using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSctPersonnelGateAssignment
{
    public int PgaIdpk { get; set; }

    public string? PgaEmpIdfk { get; set; }

    public string? PgaGateIdfk { get; set; }

    public bool? PgaView { get; set; }

    public bool? PgaLog { get; set; }

    public bool? PgaActive { get; set; }

    public string? PgaRmks { get; set; }

    public int? PgaCreatedBy { get; set; }

    public int? PgaEditedBy { get; set; }

    public DateTime? PgaCreationDate { get; set; }

    public DateTime? PgaEditedDate { get; set; }
}

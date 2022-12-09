using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTamAccuracyClass
{
    public int AclIdpk { get; set; }

    public string? AclName { get; set; }

    public string? AclShtName { get; set; }

    public bool? AclActive { get; set; }

    public string? AclRmks { get; set; }

    public string? AclCreatedBy { get; set; }

    public int? AclEditedBy { get; set; }

    public DateTime? AclCreationDate { get; set; }

    public DateTime? AclEditedDate { get; set; }
}

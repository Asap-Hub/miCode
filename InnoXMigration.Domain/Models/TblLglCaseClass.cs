using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblLglCaseClass
{
    public int CclIdpk { get; set; }

    public string? CclName { get; set; }

    public string? CclShtName { get; set; }

    public byte? CclOrder { get; set; }

    public bool? CclActive { get; set; }

    public string? CclRmks { get; set; }

    public int? CclCreatedBy { get; set; }

    public int? CclEditedBy { get; set; }

    public DateTime? CclCreationDate { get; set; }

    public DateTime? CclEditedDate { get; set; }
}

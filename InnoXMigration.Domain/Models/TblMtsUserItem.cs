using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsUserItem
{
    public int UtmIdpk { get; set; }

    public int? UtmUserIdfk { get; set; }

    public int? UtmDocCatIdfk { get; set; }

    public int? UtmItemIdfk { get; set; }

    public int? UtmEmpIdfk { get; set; }

    public bool? UtmActive { get; set; }

    public string? UtmRmks { get; set; }

    public int? UtmCreatedBy { get; set; }

    public DateTime? UtmCreationDate { get; set; }

    public int? UtmEditedBy { get; set; }

    public DateTime? UtmEditedDate { get; set; }
}

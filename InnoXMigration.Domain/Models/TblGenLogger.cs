using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenLogger
{
    public int LgrIdpk { get; set; }

    public int? LgrPickedByEmpIdfk { get; set; }

    public int? LgrReturnedByEmpIdfk { get; set; }

    public string? LgrCategory { get; set; }

    public int? LgrCategoryIdfk { get; set; }

    public DateTime? LgrTimeIn { get; set; }

    public DateTime? LgrTimeOut { get; set; }

    public string? LgrSignInDescription { get; set; }

    public string? LgrSignOutRemarks { get; set; }

    public bool? LgrSignedIn { get; set; }

    public bool? LgrSignedOut { get; set; }

    public DateTime? LgrDateSignedIn { get; set; }

    public DateTime? LgrDateSignedOut { get; set; }

    public bool? LgrActive { get; set; }

    public string? LgrRmksSignIn { get; set; }

    public string? LgrRmksSignOut { get; set; }

    public int? LgrCreatedBy { get; set; }

    public int? LgrEditedBy { get; set; }

    public DateTime? LgrCreationDate { get; set; }

    public DateTime? LgrEditedDate { get; set; }
}

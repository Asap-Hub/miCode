using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsVenue
{
    public int MvnIdpk { get; set; }

    public string? MvnName { get; set; }

    public string? MvnShtName { get; set; }

    public bool? MvnActive { get; set; }

    public string? MvnRmks { get; set; }

    public int? MvnEditedBy { get; set; }

    public int? MvnCreatedBy { get; set; }

    public DateTime? MvnCreationDate { get; set; }

    public DateTime? MvnEditedDate { get; set; }
}

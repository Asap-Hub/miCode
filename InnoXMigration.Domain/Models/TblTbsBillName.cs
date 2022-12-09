using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsBillName
{
    public int BnmIdpk { get; set; }

    public string? BnmName { get; set; }

    public string? BnmShtName { get; set; }

    public DateTime? BnmStartDate { get; set; }

    public DateTime? BnmEndDate { get; set; }

    public bool? BnmActive { get; set; }

    public string? BnmRmks { get; set; }

    public int? BnmEditedBy { get; set; }

    public int? BnmCreatedBy { get; set; }

    public DateTime? BnmCreationDate { get; set; }

    public DateTime? BnmEditedDate { get; set; }
}

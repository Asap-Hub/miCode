using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgReferee
{
    public int FrfrIdpk { get; set; }

    public string? FrfrName { get; set; }

    public string? FrfrShtName { get; set; }

    public bool? FrfrActive { get; set; }

    public string? FrfrRmks { get; set; }

    public int? FrfrCreatedBy { get; set; }

    public int? FrfrEditedBy { get; set; }

    public DateTime? FrfrCreationDate { get; set; }

    public DateTime? FrfrEditedDate { get; set; }
}

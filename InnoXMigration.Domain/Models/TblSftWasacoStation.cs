using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoStation
{
    public int WstIdpk { get; set; }

    public string? WstName { get; set; }

    public string? WstShtName { get; set; }

    public int? WstSafetyGroupIdfk { get; set; }

    public bool? WstActive { get; set; }

    public string? WstRmks { get; set; }

    public int? WstCreatedBy { get; set; }

    public int? WstEditedBy { get; set; }

    public DateTime? WstCreationDate { get; set; }

    public DateTime? WstEditedDate { get; set; }
}

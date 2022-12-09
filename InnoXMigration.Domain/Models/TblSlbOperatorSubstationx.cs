using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbOperatorSubstationx
{
    public int FosaIdpk { get; set; }

    public string? FosaOprIdfk { get; set; }

    public string? FosaSstIdfk { get; set; }

    public bool? FosaActive { get; set; }

    public string? FosaRmks { get; set; }

    public int? FosaCreatedBy { get; set; }

    public int? FosaEditedBy { get; set; }

    public DateTime? FosaCreationDate { get; set; }

    public DateTime? FosaEditedDate { get; set; }
}

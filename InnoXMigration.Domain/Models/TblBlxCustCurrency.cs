using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustCurrency
{
    public int FccyIdpk { get; set; }

    public int? FccyCustIdfk { get; set; }

    public int? FccyCurrencyIdfk { get; set; }

    public DateTime? FccyDate { get; set; }

    public string? FccyRmks { get; set; }

    public int? FccyCreatedBy { get; set; }

    public int? FccyEditedBy { get; set; }

    public DateTime? FccyCreationDate { get; set; }

    public DateTime? FccyEditedDate { get; set; }
}

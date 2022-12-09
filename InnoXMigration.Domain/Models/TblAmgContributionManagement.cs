using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgContributionManagement
{
    public int CmgIdpk { get; set; }

    public DateTime? CmgDate { get; set; }

    public int? CmgAssociationMemberIdfk { get; set; }

    public int? CmgElementIdfk { get; set; }

    public decimal? CmgAmount { get; set; }

    public int? CmgCurrencyIdfk { get; set; }

    public bool? CmgActive { get; set; }

    public string? CmgRmks { get; set; }

    public int? CmgCreatedBy { get; set; }

    public int? CmgEditedBy { get; set; }

    public DateTime? CmgCreationDate { get; set; }

    public DateTime? CmgEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsCustomerCurrencyAssignment
{
    public int CcaIdpk { get; set; }

    public int? CcaCustIdfk { get; set; }

    public int? CcaCurrencyIdfk { get; set; }

    public DateTime? CcaDate { get; set; }

    public string? CcaRmks { get; set; }

    public int? CcaCreatedBy { get; set; }

    public int? CcaEditedBy { get; set; }

    public DateTime? CcaCreationDate { get; set; }

    public DateTime? CcaEditedDate { get; set; }
}

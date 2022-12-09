using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompRegistrationRenewal
{
    public int CrrIdpk { get; set; }

    public int? CrrCompanyIdfk { get; set; }

    public DateTime? CrrRenewalDate { get; set; }

    public bool? CrrLatest { get; set; }

    public bool? CrrActive { get; set; }

    public string? CrrRmks { get; set; }

    public int? CrrCreatedBy { get; set; }

    public int? CrrEditedBy { get; set; }

    public DateTime? CrrCreationDate { get; set; }

    public DateTime? CrrEditedDate { get; set; }
}

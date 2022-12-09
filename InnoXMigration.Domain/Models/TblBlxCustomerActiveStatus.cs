using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxCustomerActiveStatus
{
    public int FcasIdpk { get; set; }

    public int? FcasCustIdfk { get; set; }

    public DateTime? FcasStartDate { get; set; }

    public DateTime? FcasEndDate { get; set; }

    public bool? FcasActive { get; set; }

    public string? FcasRmks { get; set; }

    public int? FcasCreatedBy { get; set; }

    public int? FcasEditedBy { get; set; }

    public DateTime? FcasCreationDate { get; set; }

    public DateTime? FcasEditedDate { get; set; }
}

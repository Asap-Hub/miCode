using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlAccountVisibility
{
    public int AcvIdpk { get; set; }

    public string? AcvServerAccountIdfk { get; set; }

    public string? AcvUserIdfk { get; set; }

    public bool? AcvShare { get; set; }

    public bool? AcvAlter { get; set; }

    public string? AcvRmks { get; set; }

    public int? AcvCreatedBy { get; set; }

    public int? AcvEditedBy { get; set; }

    public DateTime? AcvCreationDate { get; set; }

    public DateTime? AcvEditedDate { get; set; }
}

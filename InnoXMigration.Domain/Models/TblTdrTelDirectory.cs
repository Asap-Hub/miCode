using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTdrTelDirectory
{
    public int TdrIdpk { get; set; }

    public int? TdrGroupIdfk { get; set; }

    public int? TdrOtherSourceIdfk { get; set; }

    public int? TdrEmpIdfk { get; set; }

    public bool? TdrActive { get; set; }

    public string? TdrRmks { get; set; }

    public int? TdrCreatedBy { get; set; }

    public int? TdrEditedBy { get; set; }

    public DateTime? TdrCreationDate { get; set; }

    public DateTime? TdrEditedDate { get; set; }
}

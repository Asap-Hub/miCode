using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDocAutoShare
{
    public int DasIdpk { get; set; }

    public string? DasEmpIdfk { get; set; }

    public string? DasShareWithEmpIdfk { get; set; }

    public string? DasSource { get; set; }

    public bool? DasOwner { get; set; }

    public bool? DasReader { get; set; }

    public bool? DasPrint { get; set; }

    public bool? DasActive { get; set; }

    public string? DasRmks { get; set; }

    public int? DasCreatedBy { get; set; }

    public int? DasEditedBy { get; set; }

    public DateTime? DasCreationDate { get; set; }

    public DateTime? DasEditedDate { get; set; }
}

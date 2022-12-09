using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrUnitsx
{
    public int FuntIdpk { get; set; }

    public string? FuntName { get; set; }

    public string? FuntShtName { get; set; }

    public int? FuntSxnIdfk { get; set; }

    public string? FuntCode { get; set; }

    public int? FuntHeadEmpIdfk { get; set; }

    public bool? FuntActive { get; set; }

    public string? FuntRmks { get; set; }

    public int? FuntCreatedBy { get; set; }

    public int? FuntEditedBy { get; set; }

    public DateTime? FuntCreationDate { get; set; }

    public DateTime? FuntEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAlert
{
    public int AltIdpk { get; set; }

    public int? AltEmpIdfk { get; set; }

    public string? AltFormCode { get; set; }

    public string? AltMessage { get; set; }

    public bool? AltTakeAction { get; set; }

    public bool? AltSeen { get; set; }

    public int? AltCreatedBy { get; set; }

    public int? AltEditedBy { get; set; }

    public DateTime? AltCreationDate { get; set; }

    public DateTime? AltEditedDate { get; set; }
}

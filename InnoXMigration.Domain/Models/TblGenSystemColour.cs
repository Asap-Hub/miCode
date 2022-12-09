using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSystemColour
{
    public int SclIdpk { get; set; }

    public string? SclName { get; set; }

    public string? SclRgbCode { get; set; }

    public string? SclRgbCodex { get; set; }

    public byte? SclOrder { get; set; }

    public bool? SclActive { get; set; }

    public string? SclRmks { get; set; }

    public string? SclCreatedBy { get; set; }

    public int? SclEditedBy { get; set; }

    public DateTime? SclCreationDate { get; set; }

    public DateTime? SclEditedDate { get; set; }
}

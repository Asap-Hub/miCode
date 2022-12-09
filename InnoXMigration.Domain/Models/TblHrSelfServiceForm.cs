using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSelfServiceForm
{
    public int SsfIdpk { get; set; }

    public string? SsfFileName { get; set; }

    public byte[]? SsfFile { get; set; }

    public string? SsfFormat { get; set; }

    public bool? SsfActive { get; set; }

    public string? SsfRmks { get; set; }

    public int? SsfCreatedBy { get; set; }

    public int? SsfEditedBy { get; set; }

    public DateTime? SsfCreationDate { get; set; }

    public DateTime? SsfEditedDate { get; set; }
}

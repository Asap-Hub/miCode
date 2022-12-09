using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsSubfolder
{
    public int SbfIdpk { get; set; }

    public string? SbfName { get; set; }

    public string? SbfShtName { get; set; }

    public int? SbfFolderIdfk { get; set; }

    public string? SbfRmks { get; set; }

    public int FldIdpk { get; set; }

    public string? FldName { get; set; }

    public string? FldShtName { get; set; }

    public int? FldOrder { get; set; }

    public bool? FldActive { get; set; }

    public string? FldRmks { get; set; }

    public int? SbfEditedBy { get; set; }

    public bool? SbfActive { get; set; }

    public int? SbfCreatedBy { get; set; }

    public DateTime? SbfCreationDate { get; set; }

    public DateTime? SbfEditedDate { get; set; }

    public int? FldEditedBy { get; set; }

    public int? FldCreatedBy { get; set; }

    public DateTime? FldCreationDate { get; set; }

    public DateTime? FldEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsSubfolder
{
    public int SbfIdpk { get; set; }

    public string? SbfName { get; set; }

    public string? SbfShtName { get; set; }

    public int? SbfFolderIdfk { get; set; }

    public bool? SbfActive { get; set; }

    public string? SbfRmks { get; set; }

    public int? SbfEditedBy { get; set; }

    public int? SbfCreatedBy { get; set; }

    public DateTime? SbfCreationDate { get; set; }

    public DateTime? SbfEditedDate { get; set; }
}

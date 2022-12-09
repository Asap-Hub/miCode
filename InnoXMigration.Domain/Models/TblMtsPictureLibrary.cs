using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsPictureLibrary
{
    public int PclIdpk { get; set; }

    public string? PclTitle { get; set; }

    public DateTime? PclDateTaken { get; set; }

    public int? PclFolderIdfk { get; set; }

    public int? PclSubfolderIdfk { get; set; }

    public string? PclDescription { get; set; }

    public bool? PclActive { get; set; }

    public string? PclRmks { get; set; }

    public int? PclCreatedBy { get; set; }

    public int? PclEditedBy { get; set; }

    public DateTime? PclCreationDate { get; set; }

    public DateTime? PclEditedDate { get; set; }
}

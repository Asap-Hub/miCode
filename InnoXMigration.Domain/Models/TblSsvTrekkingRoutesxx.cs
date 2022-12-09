using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingRoutesxx
{
    public int TkrIdpk { get; set; }

    public string? TkrName { get; set; }

    public string? TkrShtName { get; set; }

    public bool? TkrActive { get; set; }

    public string? TkrRmks { get; set; }

    public string? TkrCreatedBy { get; set; }

    public int? TkrEditedBy { get; set; }

    public DateTime? TkrCreationDate { get; set; }

    public DateTime? TkrEditedDate { get; set; }
}

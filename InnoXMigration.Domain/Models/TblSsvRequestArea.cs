using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvRequestArea
{
    public int RqaIdpk { get; set; }

    public string? RqaName { get; set; }

    public string? RqaShtName { get; set; }

    public int? RqaLocationIdfk { get; set; }

    public bool? RqaActive { get; set; }

    public string? RqaRmks { get; set; }

    public string? RqaCreatedBy { get; set; }

    public int? RqaEditedBy { get; set; }

    public DateTime? RqaCreationDate { get; set; }

    public DateTime? RqaEditedDate { get; set; }
}

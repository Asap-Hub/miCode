using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPmgTheme
{
    public int ThmIdpk { get; set; }

    public int? ThmMissionIdfk { get; set; }

    public string? ThmName { get; set; }

    public string? ThmShtName { get; set; }

    public string? ThmCommentary { get; set; }

    public int? ThmLeaderEmpIdfk { get; set; }

    public byte? ThmOrder { get; set; }

    public bool? ThmActive { get; set; }

    public string? ThmRmks { get; set; }

    public string? ThmCreatedBy { get; set; }

    public int? ThmEditedBy { get; set; }

    public DateTime? ThmCreationDate { get; set; }

    public DateTime? ThmEditedDate { get; set; }
}

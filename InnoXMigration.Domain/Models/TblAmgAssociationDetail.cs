using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgAssociationDetail
{
    public int AdtIdpk { get; set; }

    public string? AdtName { get; set; }

    public string? AdtShtName { get; set; }

    public DateTime? AdtDateFormed { get; set; }

    public string? AdtSecretary { get; set; }

    public string? AdtChairman { get; set; }

    public bool? AdtActive { get; set; }

    public string? AdtRmks { get; set; }

    public string? AdtCreatedBy { get; set; }

    public int? AdtEditedBy { get; set; }

    public DateTime? AdtCreationDate { get; set; }

    public DateTime? AdtEditedDate { get; set; }
}

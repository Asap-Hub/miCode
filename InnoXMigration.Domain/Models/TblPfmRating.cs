using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPfmRating
{
    public int RtnIdpk { get; set; }

    public decimal? RtnRate { get; set; }

    public string? RtnInterpretation { get; set; }

    public string? RtnShtInterpretation { get; set; }

    public string? RtnGrade { get; set; }

    public bool? RtnActive { get; set; }

    public string? RtnRmks { get; set; }

    public string? RtnCreatedBy { get; set; }

    public int? RtnEditedBy { get; set; }

    public DateTime? RtnCreationDate { get; set; }

    public DateTime? RtnEditedDate { get; set; }
}

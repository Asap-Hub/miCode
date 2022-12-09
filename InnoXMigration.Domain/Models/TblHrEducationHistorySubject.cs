using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEducationHistorySubject
{
    public int EhsIdpk { get; set; }

    public int? EhsEmpIdfk { get; set; }

    public int? EhsEducationHistoryIdfk { get; set; }

    public int? EhsProgramIdfk { get; set; }

    public int? EhsSubjectIdfk { get; set; }

    public decimal? EhsMark { get; set; }

    public string? EhsGrade { get; set; }

    public int? EhsCreatedBy { get; set; }

    public int? EhsEditedBy { get; set; }

    public DateTime? EhsCreationDate { get; set; }

    public DateTime? EhsEditedDate { get; set; }
}

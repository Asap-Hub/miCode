using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftMeetingQuestion
{
    public int MtqIdpk { get; set; }

    public int? MtqAskedByEmpIdfk { get; set; }

    public int? MtqGroupIdfk { get; set; }

    public int? MtqMeetingDetailIdfk { get; set; }

    public DateTime? MtqQuestionTime { get; set; }

    public string? MtqQuestion { get; set; }

    public string? MtqAnswers { get; set; }

    public bool? MtqActive { get; set; }

    public string? MtqRmks { get; set; }

    public int? MtqCreatedBy { get; set; }

    public int? MtqEditedBy { get; set; }

    public DateTime? MtqCreationDate { get; set; }

    public DateTime? MtqEditedDate { get; set; }
}

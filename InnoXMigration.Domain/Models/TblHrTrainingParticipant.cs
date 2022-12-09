using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrTrainingParticipant
{
    public int TptIdpk { get; set; }

    public int? TptEmpIdfk { get; set; }

    public int? TptTrainingHistoryIdfk { get; set; }

    public int? TptProgramIdfk { get; set; }

    public int? TptInstitutionIdfk { get; set; }

    public DateTime? TptStartDate { get; set; }

    public DateTime? TptEndDate { get; set; }

    public bool? TptActive { get; set; }

    public string? TptRmks { get; set; }

    public int? TptCreatedBy { get; set; }

    public int? TptEditedBy { get; set; }

    public DateTime? TptCreationDate { get; set; }

    public DateTime? TptEditedDate { get; set; }
}

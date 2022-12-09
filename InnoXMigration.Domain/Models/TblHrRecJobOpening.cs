using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrRecJobOpening
{
    public int RjoIdpk { get; set; }

    public int? RjoProjectIdfk { get; set; }

    public int? RjoRequesterEmpIdfk { get; set; }

    public DateTime? RjoStartDate { get; set; }

    public DateTime? RjoEndDate { get; set; }

    public int? RjoDeptIdfk { get; set; }

    public int? RjoSectionIdfk { get; set; }

    public int? RjoJobIdfk { get; set; }

    public int? RjoJobLevelIdfk { get; set; }

    public int? RjoGradeIdfk { get; set; }

    public int? RjoStepIdfk { get; set; }

    public int? RjoLocationIdfk { get; set; }

    public bool? RjoInternalOpening { get; set; }

    public bool? RjoExternalOpening { get; set; }

    public bool? RjoInterviewRequired { get; set; }

    public short? RjoNoRequired { get; set; }

    public short? RjoNoOfApplicants { get; set; }

    public short? RjoNoInterviewed { get; set; }

    public short? RjoNoEmployed { get; set; }

    public bool? RjoSubmitted { get; set; }

    public bool? RjoAcknowledged { get; set; }

    public bool? RjoApproved { get; set; }

    public bool? RjoHrPersonnelAlerted { get; set; }

    public int? RjoSubmittedByEmpIdfk { get; set; }

    public DateTime? RjoSubmittedOn { get; set; }

    public bool? RjoPublished { get; set; }

    public int? RjoPublishedByEmpIdfk { get; set; }

    public bool? RjoActive { get; set; }

    public string? RjoRmks { get; set; }

    public int? RjoCreatedBy { get; set; }

    public int? RjoEditedBy { get; set; }

    public DateTime? RjoCreationDate { get; set; }

    public DateTime? RjoEditedDate { get; set; }
}

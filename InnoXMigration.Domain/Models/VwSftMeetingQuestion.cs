using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingQuestion
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

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstname { get; set; }

    public string? EmpName { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int MtdIdpk { get; set; }

    public string? MtdName { get; set; }

    public DateTime? MtdStartTime { get; set; }

    public DateTime? MtdEndTime { get; set; }

    public string MtdWhy { get; set; } = null!;

    public int StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public string? StpDescription { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public bool? SgpActive { get; set; }
}

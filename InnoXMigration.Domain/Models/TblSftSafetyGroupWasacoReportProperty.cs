using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupWasacoReportProperty
{
    public int WrpIdpk { get; set; }

    public int? WrpGroupIdfk { get; set; }

    public DateTime? WrpStartDate { get; set; }

    public DateTime? WrpEndDate { get; set; }

    public int? WrpNoOfAnnualReports { get; set; }

    public int? WrpNoOfAnnualCompulsaryReports { get; set; }

    public int? WrpNoOfFirstQuarterReports { get; set; }

    public int? WrpNoOfSecondQuarterReports { get; set; }

    public int? WrpNoOfThirdQuarterReports { get; set; }

    public int? WrpNoOfFourthQuarterReports { get; set; }

    public byte? WrpNoOfJanuaryReports { get; set; }

    public byte? WrpNoOfFebruaryReports { get; set; }

    public byte? WrpNoOfMarchReports { get; set; }

    public byte? WrpNoOfAprilReports { get; set; }

    public byte? WrpNoOfMayReports { get; set; }

    public byte? WrpNoOfJuneReports { get; set; }

    public byte? WrpNoOfJulyReports { get; set; }

    public byte? WrpNoOfAugustReports { get; set; }

    public byte? WrpNoOfSeptemberReports { get; set; }

    public byte? WrpNoOfOctoberReports { get; set; }

    public byte? WrpNoOfNovemberReports { get; set; }

    public byte? WrpNoOfDecemberReports { get; set; }

    public int? WrpMinReportDuration { get; set; }

    public int? WrpMaxReportDuration { get; set; }

    public bool? WrpActive { get; set; }

    public string? WrpRmks { get; set; }

    public int? WrpCreatedBy { get; set; }

    public int? WrpEditedBy { get; set; }

    public DateTime? WrpCreationDate { get; set; }

    public DateTime? WrpEditedDate { get; set; }
}

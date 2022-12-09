using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupWasacoAuditChecklistProperty
{
    public int WapIdpk { get; set; }

    public int? WapGroupIdfk { get; set; }

    public DateTime? WapStartDate { get; set; }

    public DateTime? WapEndDate { get; set; }

    public int? WapNoOfAnnualInspections { get; set; }

    public int? WapNoOfAnnualCompulsaryInspections { get; set; }

    public int? WapNoOfFirstQuarterInspections { get; set; }

    public int? WapNoOfSecondQuarterInspections { get; set; }

    public int? WapNoOfThirdQuarterInspections { get; set; }

    public int? WapNoOfFourthQuarterInspections { get; set; }

    public byte? WapNoOfJanuaryInspections { get; set; }

    public byte? WapNoOfFebruaryInspections { get; set; }

    public byte? WapNoOfMarchInspections { get; set; }

    public byte? WapNoOfAprilInspections { get; set; }

    public byte? WapNoOfMayInspections { get; set; }

    public byte? WapNoOfJuneInspections { get; set; }

    public byte? WapNoOfJulyInspections { get; set; }

    public byte? WapNoOfAugustInspections { get; set; }

    public byte? WapNoOfSeptemberInspections { get; set; }

    public byte? WapNoOfOctoberInspections { get; set; }

    public byte? WapNoOfNovemberInspections { get; set; }

    public byte? WapNoOfDecemberInspections { get; set; }

    public int? WapMinInspectionDuration { get; set; }

    public int? WapMaxInspectionDuration { get; set; }

    public bool? WapActive { get; set; }

    public string? WapRmks { get; set; }

    public int? WapCreatedBy { get; set; }

    public int? WapEditedBy { get; set; }

    public DateTime? WapCreationDate { get; set; }

    public DateTime? WapEditedDate { get; set; }
}

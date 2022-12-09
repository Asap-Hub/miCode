using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupInspectionPropertiesx
{
    public int SipIdpk { get; set; }

    public int? SipGroupIdfk { get; set; }

    public DateTime? SipStartDate { get; set; }

    public DateTime? SipEndDate { get; set; }

    public int? SipNoOfAnnualInspections { get; set; }

    public int? SipNoOfAnnualCompulsaryInspections { get; set; }

    public int? SipNoOfFirstQuarterInspections { get; set; }

    public int? SipNoOfSecondQuarterInspections { get; set; }

    public int? SipNoOfThirdQuarterInspections { get; set; }

    public int? SipNoOfFourthQuarterInspections { get; set; }

    public byte? SipNoOfJanuaryInspections { get; set; }

    public byte? SipNoOfFebruaryInspections { get; set; }

    public byte? SipNoOfMarchInspections { get; set; }

    public byte? SipNoOfAprilInspections { get; set; }

    public byte? SipNoOfMayInspections { get; set; }

    public byte? SipNoOfJuneInspections { get; set; }

    public byte? SipNoOfJulyInspections { get; set; }

    public byte? SipNoOfAugustInspections { get; set; }

    public byte? SipNoOfSeptemberInspections { get; set; }

    public byte? SipNoOfOctoberInspections { get; set; }

    public byte? SipNoOfNovemberInspections { get; set; }

    public byte? SipNoOfDecemberInspections { get; set; }

    public int? SipMinInspectionDuration { get; set; }

    public int? SipMaxInspectionDuration { get; set; }

    public bool? SipActive { get; set; }

    public string? SipRmks { get; set; }

    public int? SipCreatedBy { get; set; }

    public int? SipEditedBy { get; set; }

    public DateTime? SipCreationDate { get; set; }

    public DateTime? SipEditedDate { get; set; }
}

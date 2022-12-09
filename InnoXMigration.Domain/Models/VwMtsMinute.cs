using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsMinute
{
    public int MntIdpk { get; set; }

    public DateTime? MntDate { get; set; }

    public TimeSpan? MntTimeFrom { get; set; }

    public TimeSpan? MntTimeTo { get; set; }

    public DateTime? MntNextMeeting { get; set; }

    public string? MntTitle { get; set; }

    public int? MntChairPersonEmpIdfk { get; set; }

    public int? MntRecorderEmpIdfk { get; set; }

    public int? MntVenueIdfk { get; set; }

    public string? MntRmks { get; set; }

    public int? MvnIdpk { get; set; }

    public string? MvnName { get; set; }

    public string? MvnShtName { get; set; }

    public bool? MvnActive { get; set; }

    public string? MvnRmks { get; set; }

    public int? ChairEmpId { get; set; }

    public string? ChairStaffNo { get; set; }

    public string? ChairLname { get; set; }

    public string? ChairFname { get; set; }

    public string? ChairOnames { get; set; }

    public string? ChairEmpName { get; set; }

    public string? ChairEmpName1 { get; set; }

    public int? ChairDeptIdpk { get; set; }

    public string? ChairDept { get; set; }

    public string? ChairShtDept { get; set; }

    public int? ChairSxnIdpk { get; set; }

    public string? ChairSection { get; set; }

    public string? ChairShtSection { get; set; }

    public int? ChairUnitIdpk { get; set; }

    public string? ChairUnit { get; set; }

    public string? ChairShtUnit { get; set; }

    public int? ChairLocIdpk { get; set; }

    public string? ChairLocation { get; set; }

    public string? ChairShtLocation { get; set; }

    public int? RecorderEmpId { get; set; }

    public string? RecorderStaffNo { get; set; }

    public string? RecorderLname { get; set; }

    public string? RecorderFname { get; set; }

    public string? RecorderOnames { get; set; }

    public string? RecorderEmpName { get; set; }

    public string? RecorderEmpName1 { get; set; }

    public int? RecorderDeptIdpk { get; set; }

    public string? RecorderDept { get; set; }

    public string? RecorderShtDept { get; set; }

    public int? RecorderSxnIdpk { get; set; }

    public string? RecorderSection { get; set; }

    public string? RecorderShtSection { get; set; }

    public int? RecorderUnitIdpk { get; set; }

    public string? RecorderUnit { get; set; }

    public string? RecorderShtUnit { get; set; }

    public int? RecorderLocIdpk { get; set; }

    public string? RecorderLocation { get; set; }

    public string? RecorderShtLocation { get; set; }

    public int? RecorderJbtIdpk { get; set; }

    public string? RecorderJobTitle { get; set; }

    public string? RecorderShtJobTitle { get; set; }

    public int? MntCreatedBy { get; set; }

    public int? MntEditedBy { get; set; }

    public DateTime? MntCreationDate { get; set; }

    public DateTime? MntEditedDate { get; set; }

    public bool? MntSchedule { get; set; }
}

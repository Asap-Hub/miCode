using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftMeetingSchedule
{
    public int MscIdpk { get; set; }

    public int MscGroupIdfk { get; set; }

    public int MscTopicIdfk { get; set; }

    public DateTime? MscDate { get; set; }

    public string MscWhy { get; set; } = null!;

    public bool MscActive { get; set; }

    public string MscRmks { get; set; } = null!;

    public int StpIdpk { get; set; }

    public string StpTitle { get; set; } = null!;

    public string StpDescription { get; set; } = null!;

    public bool StpActive { get; set; }

    public int SgpIdpk { get; set; }

    public string SgpName { get; set; } = null!;

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public bool? SgpActive { get; set; }

    public int RspIdpk { get; set; }

    public string RspResourcePerson { get; set; } = null!;

    public string RspCompany { get; set; } = null!;

    public string RspMobNo { get; set; } = null!;

    public string RspAddress { get; set; } = null!;

    public bool RspActive { get; set; }

    public int MscResourcePersonIdfk { get; set; }

    public int RspEmpIdfk { get; set; }

    public int? MscMeetingCalendarIdfk { get; set; }

    public int? McdIdpk { get; set; }

    public string? McdName { get; set; }

    public string? McdShtName { get; set; }

    public DateTime? McdStartDate { get; set; }

    public DateTime? McdEndDate { get; set; }

    public bool? McdOpened { get; set; }

    public bool? McdActive { get; set; }

    public int? MscSubmittedByEmpIdfk { get; set; }

    public int SubByEmpId { get; set; }

    public string SubByStaffNo { get; set; } = null!;

    public string SubByLname { get; set; } = null!;

    public string SubByFname { get; set; } = null!;

    public string SubByEmpName { get; set; } = null!;

    public string SubByEmpName1 { get; set; } = null!;

    public int SubByDptId { get; set; }

    public string SubByDptName { get; set; } = null!;

    public string SubByDptShtName { get; set; } = null!;

    public int SubBySxnId { get; set; }

    public string SubBySxnName { get; set; } = null!;

    public string SubBySxnShtName { get; set; } = null!;

    public string SubByEmpName6 { get; set; } = null!;

    public int AcknowlByEmpId { get; set; }

    public string AcknowlByStaffNo { get; set; } = null!;

    public string AcknowlByLname { get; set; } = null!;

    public string AcknowlByFname { get; set; } = null!;

    public string AcknowlByEmpName { get; set; } = null!;

    public string AcknowlByEmpName1 { get; set; } = null!;

    public int AcknowlByDptId { get; set; }

    public string AcknowlByDptName { get; set; } = null!;

    public string AcknowlByDptShtName { get; set; } = null!;

    public int AcknowlBySxnId { get; set; }

    public string AcknowlBySxnName { get; set; } = null!;

    public string AcknowlBySxnShtName { get; set; } = null!;

    public string AcknowlByEmpName6 { get; set; } = null!;

    public int DelByEmpId { get; set; }

    public string DelByStaffNo { get; set; } = null!;

    public string DelByLname { get; set; } = null!;

    public string DelByFname { get; set; } = null!;

    public string DelByEmpName { get; set; } = null!;

    public string DelByEmpName1 { get; set; } = null!;

    public int DelByDptId { get; set; }

    public string DelByDptName { get; set; } = null!;

    public string DelByDptShtName { get; set; } = null!;

    public int DelBySxnId { get; set; }

    public string DelBySxnName { get; set; } = null!;

    public string DelBySxnShtName { get; set; } = null!;

    public string DelByEmpName6 { get; set; } = null!;

    public bool MscSubmitted { get; set; }

    public bool MscAcknowledged { get; set; }

    public bool MscDeleted { get; set; }

    public string MscDeletionReason { get; set; } = null!;

    public DateTime? MscDeletedOn { get; set; }
}

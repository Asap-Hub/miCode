using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTodoShare
{
    public int TdsIdpk { get; set; }

    public int? TdsSharedWithEmpIdfk { get; set; }

    public bool? TdsEdit { get; set; }

    public bool? TdsActive { get; set; }

    public int SharedWithEmpId { get; set; }

    public string? SharedWithStaffNo { get; set; }

    public string? SharedWithLname { get; set; }

    public string? SharedWithFname { get; set; }

    public string SharedWithOnames { get; set; } = null!;

    public string? SharedWithEmpName { get; set; }

    public string? SharedWithEmpName1 { get; set; }

    public string? SharedWithEmpName2 { get; set; }

    public string? SharedWithEmpName3 { get; set; }

    public string? SharedWithEmpName4 { get; set; }

    public string? SharedWithEmpName5 { get; set; }

    public string? SharedWithEmpName6 { get; set; }

    public string? SharedWithEmpName7 { get; set; }

    public string? SharedWithEmpName8 { get; set; }

    public string? SharedWithEmpName9 { get; set; }

    public string? SharedWithEmpName10 { get; set; }

    public string? SharedWithEmpName11 { get; set; }

    public string? SharedWithEmpName12 { get; set; }

    public int SharedWithDptId { get; set; }

    public string SharedWithDptName { get; set; } = null!;

    public string SharedWithDptShtName { get; set; } = null!;

    public int SharedWithSxnId { get; set; }

    public string SharedWithSxnName { get; set; } = null!;

    public string SharedWithSxnShtName { get; set; } = null!;

    public int SharedWithLocId { get; set; }

    public string SharedWithLocName { get; set; } = null!;

    public string SharedWithLocShtName { get; set; } = null!;

    public string SharedWithIntercom { get; set; } = null!;

    public string SharedWithMobNo { get; set; } = null!;

    public string SharedWithMobNox { get; set; } = null!;

    public bool SharedWithIsStaff { get; set; }

    public bool SharedWithEmpActive { get; set; }

    public int SharedWithJbtId { get; set; }

    public string SharedWithJbtName { get; set; } = null!;

    public string SharedWithJbtShtName { get; set; } = null!;

    public int TdcIdpk { get; set; }

    public string? TdcName { get; set; }

    public string? TdcShtName { get; set; }

    public byte? TdcOrder { get; set; }

    public bool? TdcActive { get; set; }

    public int? TdsTodoClassIdfk { get; set; }

    public int? TdsSharedByEmpIdfk { get; set; }
}

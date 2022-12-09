using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyGroupMember
{
    public int SgmIdpk { get; set; }

    public int? SgmSafetyGroupIdfk { get; set; }

    public int? SgmEmpIdfk { get; set; }

    public DateTime? SgmStartDate { get; set; }

    public DateTime? SgmEndDate { get; set; }

    public int? SgmDeptIdfk { get; set; }

    public int? SgmSectionIdfk { get; set; }

    public int? SgmUnitIdfk { get; set; }

    public int? SgmLocationIdfk { get; set; }

    public int? SgmSupervisorEmpIdfk { get; set; }

    public int? SgmRemovalReasonIdfk { get; set; }

    public bool? SgmSmsSent { get; set; }

    public int? SgmSmsCount { get; set; }

    public bool? SgmDeleted { get; set; }

    public bool? SgmActive { get; set; }

    public string? SgmRmks { get; set; }

    public int? SgmCreatedby { get; set; }

    public int? SgmEditedBy { get; set; }

    public DateTime? SgmCreationDate { get; set; }

    public DateTime? SgmEditedDate { get; set; }
}

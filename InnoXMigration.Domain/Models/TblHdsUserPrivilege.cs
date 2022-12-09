using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsUserPrivilege
{
    public int HdpIdpk { get; set; }

    public int? HdpEmpIdfk { get; set; }

    public bool? HdpSysAdmin { get; set; }

    public bool? HdpClassifyIssues { get; set; }

    public long? HdpEditIssues { get; set; }

    public bool? HdpSupervisor { get; set; }

    public bool? HdpManager { get; set; }

    public bool? HdpDirector { get; set; }

    public bool? HdpCeo { get; set; }

    public string? HdpRmks { get; set; }

    public int? HdpCreatedBy { get; set; }

    public int? HdpEditedBy { get; set; }

    public DateTime? HdpCreationDate { get; set; }

    public DateTime? HdpEditedDate { get; set; }
}

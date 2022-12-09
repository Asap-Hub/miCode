using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSmsPrivilegesAssignment
{
    public int SpaIdpk { get; set; }

    public int? SpaEmpIdfk { get; set; }

    public int? SpaSmsGroupIdfk { get; set; }

    public bool? SpaSend { get; set; }

    public bool? SpaApprove { get; set; }

    public bool? SpaRecommend { get; set; }

    public bool? SpaAlert { get; set; }

    public bool? SpaManage { get; set; }

    public int? SpaDailyMax { get; set; }

    public int? SpaMonthlyMax { get; set; }

    public bool? SpaActive { get; set; }

    public string? SpaRmks { get; set; }

    public int? SpaCreatedBy { get; set; }

    public int? SpaEditedBy { get; set; }

    public DateTime? SpaCreationDate { get; set; }

    public DateTime? SpaEditedDate { get; set; }
}

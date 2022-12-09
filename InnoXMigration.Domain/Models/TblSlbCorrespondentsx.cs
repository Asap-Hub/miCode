using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbCorrespondentsx
{
    public int FcrdIdpk { get; set; }

    public int? FcrdEmpIdfk { get; set; }

    public string? FcrdStaffNo { get; set; }

    public string? FcrdName { get; set; }

    public string? FcrdJobTitle { get; set; }

    public string? FcrdCompany { get; set; }

    public string? FcrdDepartment { get; set; }

    public string? FcrdContactNumbers { get; set; }

    public string? FcrdRmks { get; set; }

    public bool? FcrdActive { get; set; }

    public int? FcrdCreatedBy { get; set; }

    public int? FcrdEditedBy { get; set; }

    public DateTime? FcrdCreationDate { get; set; }

    public DateTime? FcrdEditedDate { get; set; }
}

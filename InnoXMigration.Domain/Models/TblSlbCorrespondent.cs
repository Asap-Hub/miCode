using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbCorrespondent
{
    public int CrdIdpk { get; set; }

    public int? CrdEmpIdfk { get; set; }

    public string? CrdStaffNo { get; set; }

    public string? CrdName { get; set; }

    public string? CrdJobTitle { get; set; }

    public string? CrdCompany { get; set; }

    public string? CrdDepartment { get; set; }

    public string? CrdContactNumbers { get; set; }

    public string? CrdRmks { get; set; }

    public bool? CrdActive { get; set; }

    public int? CrdCreatedBy { get; set; }

    public int? CrdEditedBy { get; set; }

    public DateTime? CrdCreationDate { get; set; }

    public DateTime? CrdEditedDate { get; set; }
}

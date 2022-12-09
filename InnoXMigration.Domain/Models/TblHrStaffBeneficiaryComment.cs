using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrStaffBeneficiaryComment
{
    public int SbcIdpk { get; set; }

    public int? SbcEmpIdfk { get; set; }

    public string? SbcComment { get; set; }

    public bool? SbcActive { get; set; }

    public int? SbcCreatedBy { get; set; }

    public int? SbcEditedBy { get; set; }

    public DateTime? SbcCreationDate { get; set; }

    public DateTime? SbcEditedDate { get; set; }
}

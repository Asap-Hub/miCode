using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftPpeDistribution
{
    public int PddIdpk { get; set; }

    public DateTime? PddDate { get; set; }

    public int? PddRequestIdfk { get; set; }

    public int? PddPpeTypeIdfk { get; set; }

    public decimal? PddQuantityDistributed { get; set; }

    public int? PddDeptIdfk { get; set; }

    public int? PddSectionIdfk { get; set; }

    public int? PddUnitIdfk { get; set; }

    public int? PddLocationIdfk { get; set; }

    public int? PddEmpDeptIdfk { get; set; }

    public int? PddEmpSectionIdfk { get; set; }

    public int? PddEmpLocIdfk { get; set; }

    public bool? PddSigned { get; set; }

    public bool? PddActive { get; set; }

    public string? PddDeletionReason { get; set; }

    public DateTime? PddDeletedOn { get; set; }

    public string? PddRmks { get; set; }

    public int? PddCreatedBy { get; set; }

    public int? PddEditedBy { get; set; }

    public DateTime? PddCreationDate { get; set; }

    public DateTime? PddEditedDate { get; set; }
}

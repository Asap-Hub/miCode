using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompApproval
{
    public int CapIdpk { get; set; }

    public int? CapCompanyIdfk { get; set; }

    public DateTime? CapDateApproved { get; set; }

    public bool? CapActive { get; set; }

    public string? CapDeletionRmks { get; set; }

    public string? CapRmks { get; set; }

    public int? CapCreatedBy { get; set; }

    public int? CapEditedBy { get; set; }

    public DateTime? CapCreationDate { get; set; }

    public DateTime? CapEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpsDocDetail
{
    public int EddIdpk { get; set; }

    public int? EddEmpIdfk { get; set; }

    public string? EddTitle { get; set; }

    public string? EddDescription { get; set; }

    public DateTime? EddDocDate { get; set; }

    public int? EddDocTypeIdfk { get; set; }

    public string? EddType { get; set; }

    public bool? EddClassified { get; set; }

    public bool? EddActive { get; set; }

    public string? EddRmks { get; set; }

    public bool? EddHasAttachment { get; set; }

    public int? EddCreatedBy { get; set; }

    public int? EddEditedBy { get; set; }

    public DateTime? EddCreationDate { get; set; }

    public DateTime? EddEditedDate { get; set; }
}

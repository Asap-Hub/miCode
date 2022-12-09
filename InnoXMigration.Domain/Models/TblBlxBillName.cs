using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxBillName
{
    public int FbnmIdpk { get; set; }

    public string? FbnmName { get; set; }

    public string? FbnmShtName { get; set; }

    public DateTime? FbnmStartDate { get; set; }

    public DateTime? FbnmEndDate { get; set; }

    public bool? FbnmActive { get; set; }

    public string? FbnmRmks { get; set; }

    public int? FbnmEditedBy { get; set; }

    public int? FbnmCreatedBy { get; set; }

    public DateTime? FbnmCreationDate { get; set; }

    public DateTime? FbnmEditedDate { get; set; }
}

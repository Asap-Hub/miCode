using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblTbsRemark
{
    public int RmkIdpk { get; set; }

    public int? RmkBillNameIdfk { get; set; }

    public int? RmkCustIdfk { get; set; }

    public DateTime? RmkDate { get; set; }

    public string? RmkRemark { get; set; }

    public int? RmkCreatedBy { get; set; }

    public int? RmkEditedBy { get; set; }

    public DateTime? RmkCreationDate { get; set; }

    public DateTime? RmkEditedDate { get; set; }
}

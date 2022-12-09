using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxRemark
{
    public int FrmkIdpk { get; set; }

    public int? FrmkBillNameIdfk { get; set; }

    public int? FrmkCustIdfk { get; set; }

    public DateTime? FrmkDate { get; set; }

    public string? FrmkRemark { get; set; }

    public int? FrmkCreatedBy { get; set; }

    public int? FrmkEditedBy { get; set; }

    public DateTime? FrmkCreationDate { get; set; }

    public DateTime? FrmkEditedDate { get; set; }
}

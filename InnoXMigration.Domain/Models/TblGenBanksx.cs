using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenBanksx
{
    public int FbnkIdpk { get; set; }

    public string? FbnkName { get; set; }

    public string? FbnkShtName { get; set; }

    public string? FbnkCode { get; set; }

    public bool? FbnkActive { get; set; }

    public string? FbnkRmks { get; set; }

    public int? FbnkCreatedBy { get; set; }

    public int? FbnkEditedBy { get; set; }

    public DateTime? FbnkCreationDate { get; set; }

    public DateTime? FbnkEditedDate { get; set; }
}

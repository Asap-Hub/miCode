using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinPettyCashRequestArea
{
    public int PraIdpk { get; set; }

    public string? PraName { get; set; }

    public string? PraShtName { get; set; }

    public bool? PraActive { get; set; }

    public string? PraRmks { get; set; }

    public int? PraCreatedBy { get; set; }

    public int? PraEditedBy { get; set; }

    public DateTime? PraCreationDate { get; set; }

    public DateTime? PraEditedDate { get; set; }
}

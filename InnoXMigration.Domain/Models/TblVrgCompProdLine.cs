using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompProdLine
{
    public int FcplIdpk { get; set; }

    public int? FcplCompIdfk { get; set; }

    public int? FcplProdTypeIdfk { get; set; }

    public int? FcplProdIdfk { get; set; }

    public int? FcplBrandIdfk { get; set; }

    public DateTime? FcplStartDate { get; set; }

    public DateTime? FcplEndDate { get; set; }

    public string? FcplRmks { get; set; }

    public bool? FcplActive { get; set; }

    public int? FcplCreatedBy { get; set; }

    public int? FcplEditedBy { get; set; }

    public DateTime? FcplCreationDate { get; set; }

    public DateTime? FcplEditedDate { get; set; }
}

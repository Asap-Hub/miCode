using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxTeeOff
{
    public int FtofIdpk { get; set; }

    public DateTime? FtofDate { get; set; }

    public DateTime? FtofEndDate { get; set; }

    public int? FtofParentIdfk { get; set; }

    public int? FtofParentCustIdfk { get; set; }

    public int? FtofParentSstIdfk { get; set; }

    public int? FtofChildIdfk { get; set; }

    public int? FtofChildCustIdfk { get; set; }

    public int? FtofChildSstIdfk { get; set; }

    public bool? FtofActive { get; set; }

    public string? FtofRmks { get; set; }

    public int? FtofCreatedBy { get; set; }

    public int? FtofEditedBy { get; set; }

    public DateTime? FtofCreationDate { get; set; }

    public DateTime? FtofEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAdgroup
{
    public int AgpIdpk { get; set; }

    public string? AgpName { get; set; }

    public string? AgpShtName { get; set; }

    public bool? AgpUserGroup { get; set; }

    public bool? AgpActive { get; set; }

    public string? AgpActualAdname { get; set; }

    public string? AgpRmks { get; set; }

    public int? AgpCreatedby { get; set; }

    public int? AgpLastEditedBy { get; set; }

    public DateTime? AgpCreationDate { get; set; }

    public DateTime? AgpLastEditedDate { get; set; }
}

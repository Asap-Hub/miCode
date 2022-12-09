using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTodoClass
{
    public int TdcIdpk { get; set; }

    public string? TdcName { get; set; }

    public string? TdcShtName { get; set; }

    public byte? TdcOrder { get; set; }

    public bool? TdcActive { get; set; }

    public string? TdcRmks { get; set; }

    public int? TdcCreatedBy { get; set; }

    public int? TdcEditedBy { get; set; }

    public DateTime? TdcCreationDate { get; set; }

    public DateTime? TdcEditedDate { get; set; }
}

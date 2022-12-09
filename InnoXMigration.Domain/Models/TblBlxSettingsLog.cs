using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBlxSettingsLog
{
    public int FstlIdpk { get; set; }

    public int? FstlSettingIdfk { get; set; }

    public bool? FstlValue { get; set; }

    public int? FstlCreatedBy { get; set; }

    public DateTime? FstlCreationDate { get; set; }
}

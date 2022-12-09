using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenSettingsLog
{
    public int StlIdpk { get; set; }

    public int? StlSettingIdfk { get; set; }

    public string? StlValue { get; set; }

    public string? StlSettingCode { get; set; }

    public int? StlCreatedBy { get; set; }

    public DateTime? StlCreationDate { get; set; }
}

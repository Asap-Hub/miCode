using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSlbLogSettingsx
{
    public bool? FlgsInBacklogMode { get; set; }

    public DateTime? FlgsBacklogStartDate { get; set; }

    public DateTime? FlgsBacklogEndDate { get; set; }
}

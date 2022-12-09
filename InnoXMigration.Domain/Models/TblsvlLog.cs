using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlLog
{
    public int LogIdpk { get; set; }

    public DateTime? LogDateIn { get; set; }

    public DateTime? LogDateOut { get; set; }

    public int? LogCategoryIdfk { get; set; }

    public int? LogServerDetailsIdfk { get; set; }

    public int? LogApplicationIdfk { get; set; }

    public int? LogRequestByIdfk { get; set; }

    public string? LogIncomingIssue { get; set; }

    public string? LogActivity { get; set; }

    public int? LogIncomingStatusIdfk { get; set; }

    public int? LogOutgoingStatusIdfk { get; set; }

    public int? LogPriorityIdfk { get; set; }

    public string? LogRmks { get; set; }

    public int? LogCreatedBy { get; set; }

    public int? LogEditedBy { get; set; }

    public DateTime? LogCreationDate { get; set; }

    public DateTime? LogEditedDate { get; set; }
}

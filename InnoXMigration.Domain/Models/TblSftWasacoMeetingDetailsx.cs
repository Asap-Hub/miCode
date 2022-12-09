using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftWasacoMeetingDetailsx
{
    public int WmdIdpk { get; set; }

    public string? WmdName { get; set; }

    public DateTime? WmdStartDate { get; set; }

    public DateTime? WmdEndDate { get; set; }

    public int? WmdTeamIdfk { get; set; }

    public bool? WmdScoring { get; set; }

    public bool? WmdWasacoAuditChecklist { get; set; }

    public bool? WmdWasacoAuditReport { get; set; }

    public bool? WmdActive { get; set; }

    public string? WmdRmks { get; set; }

    public int? WmdCreatedBy { get; set; }

    public int? WmdEditedBy { get; set; }

    public DateTime? WmdCreationDate { get; set; }

    public DateTime? WmdEditedDate { get; set; }
}

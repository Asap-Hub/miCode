using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTodoList
{
    public int TdlIdpk { get; set; }

    public string? TdlTitle { get; set; }

    public DateTime? TdlStartDate { get; set; }

    public DateTime? TdlDueDate { get; set; }

    public int? TdlPriorityIdfk { get; set; }

    public byte? TdlInitialPercentComplete { get; set; }

    public string? TdlToDo { get; set; }

    public string? TdlUpdateActivity { get; set; }

    public string? TdlLocation { get; set; }

    public DateTime? TdlReminderDate { get; set; }

    public byte? TdlPercentComplete { get; set; }

    public DateTime? TdlCreationDate { get; set; }

    public DateTime? TdlUpdateDate { get; set; }

    public DateTime? TdlEditedDate { get; set; }

    public int? TdlEditedBy { get; set; }

    public int? TdlCreatedBy { get; set; }

    public DateTime? TdlCompletionDate { get; set; }

    public string? TdlCategory { get; set; }

    public byte[]? TdlTitlex { get; set; }

    public byte[]? TdlToDox { get; set; }

    public byte[]? TdlUpdateActivityx { get; set; }

    public byte[]? TdlLocationx { get; set; }

    public byte[]? TdlCategoryx { get; set; }

    public bool? TdlActive { get; set; }

    public byte[]? TdlCancelComment { get; set; }

    public int? TdlClassIdfk { get; set; }

    public int? TdlCreatedByEmpIdfk { get; set; }

    public int? TdlOwnerEmpIdfk { get; set; }

    public int? TdlReminderIdfk { get; set; }

    public int? RmnIdpk { get; set; }

    public string? RmnName { get; set; }

    public string? RmnShtName { get; set; }

    public byte? RmnOrder { get; set; }

    public bool? RmnActive { get; set; }

    public string TdlTag { get; set; } = null!;

    public int? TdcIdpk { get; set; }

    public string? TdcName { get; set; }

    public string? TdcShtName { get; set; }

    public byte? TdcOrder { get; set; }

    public bool? TdcActive { get; set; }

    public int? TdpIdpk { get; set; }

    public string? TdpName { get; set; }

    public string? TdpShtName { get; set; }

    public byte? TdpOrder { get; set; }

    public bool? TdpActive { get; set; }
}

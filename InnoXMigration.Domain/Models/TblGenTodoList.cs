using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTodoList
{
    public int TdlIdpk { get; set; }

    public DateTime? TdlStartDate { get; set; }

    public DateTime? TdlDueDate { get; set; }

    public int? TdlClassIdfk { get; set; }

    public int? TdlPriorityIdfk { get; set; }

    public byte? TdlInitialPercentComplete { get; set; }

    public byte? TdlPercentComplete { get; set; }

    public string? TdlTitle { get; set; }

    public byte[]? TdlTitlex { get; set; }

    public string? TdlToDo { get; set; }

    public byte[]? TdlToDox { get; set; }

    public string? TdlUpdateActivity { get; set; }

    public byte[]? TdlUpdateActivityx { get; set; }

    public byte[]? TdlCancelComment { get; set; }

    public string? TdlReminder { get; set; }

    public int? TdlReminderIdfk { get; set; }

    public string? TdlLocation { get; set; }

    public byte[]? TdlLocationx { get; set; }

    public string? TdlCategory { get; set; }

    public byte[]? TdlCategoryx { get; set; }

    public int? TdlCreatedByEmpIdfk { get; set; }

    public int? TdlOwnerEmpIdfk { get; set; }

    public int? TdlCreatedBy { get; set; }

    public int? TdlEditedBy { get; set; }

    public DateTime? TdlReminderDate { get; set; }

    public string? TdlTag { get; set; }

    public bool? TdlActive { get; set; }

    public DateTime? TdlCreationDate { get; set; }

    public DateTime? TdlEditedDate { get; set; }

    public DateTime? TdlCompletionDate { get; set; }

    public DateTime? TdlUpdateDate { get; set; }
}

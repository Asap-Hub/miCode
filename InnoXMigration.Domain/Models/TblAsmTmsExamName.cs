using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamName
{
    public int ExnIdpk { get; set; }

    public string? ExnName { get; set; }

    public string? ExnShtName { get; set; }

    public short? ExnDuration { get; set; }

    public short? ExnNoOfQuestions { get; set; }

    public bool? ExnActive { get; set; }

    public string? ExnRmks { get; set; }

    public string? ExnCreatedBy { get; set; }

    public int? ExnEditedBy { get; set; }

    public DateTime? ExnCreationDate { get; set; }

    public DateTime? ExnEditedDate { get; set; }
}

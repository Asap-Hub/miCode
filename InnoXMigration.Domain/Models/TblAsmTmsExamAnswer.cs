using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamAnswer
{
    public int ExaIdpk { get; set; }

    public byte? ExaAnswerNo { get; set; }

    public int? ExaQuestionIdfk { get; set; }

    public byte[]? ExaAnswer { get; set; }

    public bool? ExaCorrectAnswer { get; set; }

    public byte? ExaNoOfLines { get; set; }

    public bool? ExaActive { get; set; }

    public string? ExaRmks { get; set; }

    public int? ExaCreatedBy { get; set; }

    public int? ExaEditedBy { get; set; }

    public DateTime? ExaCreationDate { get; set; }

    public DateTime? ExaEditedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmTmsExamStudentAnswer
{
    public int EsaIdpk { get; set; }

    public int? EsaEmpIdfk { get; set; }

    public int? EsaQuestionIdfk { get; set; }

    public int? EsaStudentAnswerIdfk { get; set; }

    public int? EsaExamDetailIdfk { get; set; }

    public bool? EsaGotCorrectAnswer { get; set; }

    public bool? EsaAnswerA { get; set; }

    public bool? EsaAnswerB { get; set; }

    public bool? EsaAnswerC { get; set; }

    public bool? EsaAnswerD { get; set; }

    public bool? EsaAnswerE { get; set; }

    public byte? EsaQuestionOrder { get; set; }

    public bool? EsaAnswersSubmitted { get; set; }

    public bool? EsaActive { get; set; }

    public string? EsaRmks { get; set; }

    public int? EsaCreatedBy { get; set; }

    public int? EsaEditedBy { get; set; }

    public DateTime? EsaCreationDate { get; set; }

    public DateTime? EsaEditedDate { get; set; }
}

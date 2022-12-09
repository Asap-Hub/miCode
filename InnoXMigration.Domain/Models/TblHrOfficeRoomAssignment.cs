using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOfficeRoomAssignment
{
    public int OraIdpk { get; set; }

    public int? OraOfficeIdfk { get; set; }

    public int? OraRoomIdfk { get; set; }

    public bool? OraActive { get; set; }

    public string? OraRmks { get; set; }

    public int? OraCreatedBy { get; set; }

    public int? OraEditedBy { get; set; }

    public DateTime? OraCreationDate { get; set; }

    public DateTime? OraEditedDate { get; set; }
}

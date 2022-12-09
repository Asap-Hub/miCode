using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCompPicture
{
    public int EimIdpk { get; set; }

    public int? EimEquipIdfk { get; set; }

    public byte[]? EimPicture { get; set; }

    public byte? EimIndex { get; set; }

    public int? EimCreatedBy { get; set; }

    public int? EimEditedBy { get; set; }

    public DateTime? EimCreationDate { get; set; }

    public DateTime? EimEditedDate { get; set; }
}

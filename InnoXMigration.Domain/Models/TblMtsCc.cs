using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblMtsCc
{
    public int CcpIdpk { get; set; }

    public int? CcpMailIdfk { get; set; }

    public int? CcpItemIdfk { get; set; }

    public DateTime? CcpCreationDate { get; set; }
}

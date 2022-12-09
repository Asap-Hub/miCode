using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwBlxTeeOff
{
    public int FtofIdpk { get; set; }

    public DateTime? FtofDate { get; set; }

    public string? PrtffdrName { get; set; }

    public string? ChdffdrName { get; set; }

    public string? PrtfcustShtName { get; set; }

    public string? ChdfcustShtName { get; set; }

    public string? PrtfsstShtName { get; set; }

    public string? ChdfsstShtName { get; set; }

    public int? FtofParentIdfk { get; set; }

    public int? FtofChildIdfk { get; set; }

    public bool? FtofActive { get; set; }

    public string? FtofRmks { get; set; }

    public int? FtofParentCustIdfk { get; set; }

    public int? FtofParentSstIdfk { get; set; }

    public int? FtofChildCustIdfk { get; set; }

    public int? FtofChildSstIdfk { get; set; }

    public int PrtffdrIdpk { get; set; }

    public string? PrtffdrShtName { get; set; }

    public bool? PrtffdrActive { get; set; }

    public int ChdffdrIdpk { get; set; }

    public string? ChdffdrShtName { get; set; }

    public bool? ChdffdrActive { get; set; }

    public int PrtfcustIdpk { get; set; }

    public string? PrtfcustName { get; set; }

    public int ChdfcustIdpk { get; set; }

    public string? ChdfcustName { get; set; }

    public int PrtfsstIdpk { get; set; }

    public string? PrtfsstName { get; set; }

    public int ChdfsstIdpk { get; set; }

    public string? ChdfsstName { get; set; }

    public DateTime? FtofEndDate { get; set; }
}

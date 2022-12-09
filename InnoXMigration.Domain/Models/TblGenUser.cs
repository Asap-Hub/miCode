using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenUser
{
    public int UsaIdpk { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? UsaPassword { get; set; }

    public bool? UsaChangePassword { get; set; }

    public string? UsaPin { get; set; }

    public bool? UsaResetOthersPasswords { get; set; }

    public bool? UsaLoggedIn { get; set; }

    public bool? UsaSuperUser { get; set; }

    public bool? UsaAllowSendingOfSms { get; set; }

    public bool? UsaSeeExecDashboard { get; set; }

    public bool? UsaSeeClassifiedDocs { get; set; }

    public bool? UsaSeeAuditTrail { get; set; }

    public bool? UsaSeeSalaries { get; set; }

    public bool? UsaEditOthersMobNos { get; set; }

    public bool? UsaSeeHiddenMobNos { get; set; }

    public bool? UsaEditIntercom { get; set; }

    public bool? UsaEditEmails { get; set; }

    public int? UsaDefaultModuleIdfk { get; set; }

    public DateTime? UsaStartDate { get; set; }

    public DateTime? UsaEndDate { get; set; }

    public bool? UsaActive { get; set; }

    public bool? UsaSeeAllForms { get; set; }

    public bool? UsaNewAccount { get; set; }

    public bool? UsaShowTaskOnStartup { get; set; }

    public bool? UsaShowToDoOnStartup { get; set; }

    public bool? UsaShowAdvertOnStartup { get; set; }

    public bool? UsaShowTipOfDayOnStartup { get; set; }

    public bool? UsaShowRightNavigatorOnStartup { get; set; }

    public bool? UsaStartNewsflashOnStartup { get; set; }

    public bool? UsaShowNewsflashBarOnStartup { get; set; }

    public bool? UsaShowWorkAnniversaryInNewsflash { get; set; }

    public bool? UsaShowBirthdayInNewsflash { get; set; }

    public bool? UsaShowAlertsWindowOnStartup { get; set; }

    public string? UsaAppTheme { get; set; }

    public int? UsaFormHeaderBackColourIdfk { get; set; }

    public int? UsaFormFooterBackColourIdfk { get; set; }

    public string? UsaRmks { get; set; }

    public int? UsaCreatedBy { get; set; }

    public int? UsaEditedBy { get; set; }

    public DateTime? UsaCreationDate { get; set; }

    public DateTime? UsaEditedDate { get; set; }
}

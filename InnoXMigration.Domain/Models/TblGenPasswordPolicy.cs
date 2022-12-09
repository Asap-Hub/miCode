using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPasswordPolicy
{
    public byte? PplMaxLength { get; set; }

    public byte? PplMinLength { get; set; }

    public bool? PplLetters { get; set; }

    public byte? PplLettersMin { get; set; }

    public bool? PplUpperCase { get; set; }

    public byte? PplUpperCaseMin { get; set; }

    public bool? PplSpecialCharacters { get; set; }

    public byte? PplSpecialCharactersMin { get; set; }

    public bool? PplNumbers { get; set; }

    public byte? PplNumbersMin { get; set; }

    public bool? PplAllowLoginMore { get; set; }

    public DateTime? PplCreationDate { get; set; }

    public int? PplEditedBy { get; set; }
}

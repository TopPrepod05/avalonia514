using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AvaloniaApplication12.Models;

[Index(nameof(Login), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
public class User
{
    public int Id { get; set; }
    [Required][MaxLength(20)] public string Login { get; set; } = string.Empty;
    [Required][MaxLength(30)] public string Email { get; set; } = string.Empty;

}








// 
//





















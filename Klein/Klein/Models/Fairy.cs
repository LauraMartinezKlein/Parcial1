using System;
using System.ComponentModel.DataAnnotations;

namespace Klein.Models
{
    public enum TypeList {

        Luna,
        Luz,
        Lima
    }

    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        [Required]
        public string NickName { get; set; }

        [Required]
        [Display(Name="Nombre Completo")]
        [StringLength(24,MinimumLength =2)]
        public TypeList Wishes { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Direccion de correo no valida")]
        public string Email { get; set; }

        [Display(Name="Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}
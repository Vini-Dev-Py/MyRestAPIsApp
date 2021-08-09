using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyRestCarnes.Model.Base;

namespace MyRestCarnes.Model
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }
        
        [Column("role")]
        public string Role { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("refresh_token")]
        public string RefreshToken { get; set; }

        [Column("refresh_token_expiry_time")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}

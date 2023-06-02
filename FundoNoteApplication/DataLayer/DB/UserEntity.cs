using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datalayer.DB
{
	public class UserEntity
	{
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity property
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegisterAt { get; set; }  //it become an nullable column ?
    }
}

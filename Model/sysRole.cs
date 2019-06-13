using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class sysRole
    {
        [Key]
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDesc { get; set; }
        public int flag { get; set; }
        public ICollection<sysUserRole> sysUserRoles { get; set; }
    }
}

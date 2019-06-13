using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class sysUser
    {
        [Key]
        public int userId { get; set; }
        public string account { get; set; }
        public int sex { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public int flag { get; set; }
        public virtual ICollection<sysUserRole> sysUserRoles { get; set; }

    }
}

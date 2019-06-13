using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class sysUserRole
    {
        [Key]
        public int id { get; set; }
        public int sysUserId { get; set; }
        public int sysRoleId { get; set; }
        public virtual sysUser sysUser { get; set; }
        public virtual sysRole sysRole { get; set; }
    }
}

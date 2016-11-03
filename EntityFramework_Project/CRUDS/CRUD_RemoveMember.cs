using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project.CRUDS
{
    public static class CRUD_RemoveMember
    {
        public static void RemoveMember(tbl_Member member)
        {
              using (var ctx = new HemmakvällEntities())
            {

                ctx.tbl_Member.Remove(member);
                ctx.SaveChanges();
            }
        }
         
    }
}

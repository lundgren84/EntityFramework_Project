using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project.CRUDS
{
    public static class CRUD_RemoveMember
    {
        public static void RemoveMember(string name)
        {
            char[] whitespace = new char[] { ' ', '\t' };
            string[] FirstAndLastname = name.Split(whitespace);
            using (var ctx = new HemmakvällEntities())
            {
                var membertoremove = ctx.tbl_Member.Where(x => x.FirstName == FirstAndLastname[0] && x.LastName == FirstAndLastname[1]).FirstOrDefault();
                ctx.tbl_Member.Remove(membertoremove);
                ctx.SaveChanges();
            }
        }
         
    }
}

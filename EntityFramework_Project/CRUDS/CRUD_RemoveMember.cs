using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project.CRUDS
{
    public static class CRUD_RemoveMember
    {
        public static string RemoveMember(string name)
        {
            string success = "You have successfully removed the said member";
            string failure = "The member you tried to remove is currently renting movies with us, and you are unable to remove him";
            char[] whitespace = new char[] { ' ', '\t' };
            string[] FirstAndLastname = name.Split(whitespace);
            string firstName = FirstAndLastname[0];
            string lastName = FirstAndLastname[1];
            using (var ctx = new HemmakvällEntities())
            {
                var membertoremove = ctx.tbl_Member.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
                ctx.tbl_Member.Remove(membertoremove);
                try
                {
                    ctx.SaveChanges();
                }
                catch
                {
                    return failure;
                }
            }
            return success;
        }
         
    }
}

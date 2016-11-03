﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project.CRUDS
{
   public class CRUD_Add_Search_Member
    {
        public static void NewMember(tbl_Member member)
        {
            using (var ctx = new HemmakvällEntities())
            {
                member.tbl_HemmaKväll = ctx.tbl_HemmaKväll.Where(x => x.Hemmakväll_ID == 1).FirstOrDefault();
                ctx.tbl_Member.Add(member);
                ctx.SaveChanges();
            }
        }

        public static List<tbl_Member> GetAllMembers()
        {
            List<tbl_Member> result = new List<tbl_Member>();
            using (var ctx = new HemmakvällEntities())
            {
                result = ctx.tbl_Member.ToList();
            }
                return result;
        }
    }
}
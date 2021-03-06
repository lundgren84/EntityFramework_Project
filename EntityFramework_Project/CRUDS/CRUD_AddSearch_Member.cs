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

        public static List<tbl_Member> SearchOnMember(string selectedValue, string searchValue)
        {
            List<tbl_Member> result = new List<tbl_Member>();
            using (var ctx = new HemmakvällEntities())
            {
                if (selectedValue == "1")
                {
                    //FirstName
                    result = ctx.tbl_Member.Where(x => x.FirstName.ToLower().StartsWith(searchValue)).ToList();
                }
                else if (selectedValue == "2")
                {
                    //LastName
                    result = ctx.tbl_Member.Where(x => x.LastName.ToLower().StartsWith(searchValue)).ToList();
                }
                else if (selectedValue == "3")
                {
                    //ID
                    result = ctx.tbl_Member.Where(x => x.Member_ID.Equals(searchValue.ToString())).ToList();
                }
                else if (selectedValue == "4")
                {
                    //SSN
                    result = ctx.tbl_Member.Where(x => x.CSN.StartsWith(searchValue.ToString())).ToList();
                }
                else if (selectedValue == "5")
                {
                    //Phone
                    result = ctx.tbl_Member.Where(x => x.PhoneNumber.StartsWith(searchValue.ToString())).ToList();
                }
            }
            return result;
        }

        public static List<tbl_Movie> GetAllMovies()
        {
            List<tbl_Movie> result = new List<tbl_Movie>();

            using (var ctx = new HemmakvällEntities())
            {
                result = ctx.tbl_Movie.ToList();
                foreach (var item in result)
                {
                    item.tbl_Member = ctx.tbl_Member.Where(x => x.Member_ID == item.Member_ID).FirstOrDefault();
                }
            }

            return result;
        }

        public static List<tbl_Movie> SearchOnMovies(string selectedValue1, string selectedValue2, string v)
        {
            int genreInt = int.Parse(selectedValue2);
            List<tbl_Movie> result = new List<tbl_Movie>();
            //Search type
            if (selectedValue1 == "0") { }
            //Genre
            if (selectedValue2 == "0") { }
            
            using (var ctx = new HemmakvällEntities())
            {
                //Default
                if (selectedValue1 == "0")
                {
               
                }
                //ID
                if (selectedValue1 == "1")
                {

                }
                //titel
                if (selectedValue1 == "2")
                {

                }
            }

            return result;
        }
    }
}

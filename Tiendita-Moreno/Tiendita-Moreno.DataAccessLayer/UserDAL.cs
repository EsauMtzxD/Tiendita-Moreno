using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita_Moreno.BussinessEntities;

namespace Tiendita_Moreno.DataAccessLayer
{
    public class UserDAL
    {

        public static bool Login(string Usr, string Pwd)
        {

            bool isExist = false;

            using(StoreDbContext dbCtx = new StoreDbContext())
            {

                User u = dbCtx.Users.Where(x => x.Uid == Usr && x.Pwd == Pwd).FirstOrDefault();

                if(u != null)
                {

                    isExist = true;

                }

            }

            return isExist;

        }

        public static int CheckTheUsers()
        {

            int registers = 0;

            using(StoreDbContext dbCtx = new StoreDbContext())
            {

                registers = dbCtx.Users.Count();

            }

            return registers;

        }

        public static bool CreateUser(User user)
        {

            bool isInsert = false;

            using(StoreDbContext dbCtx = new StoreDbContext())
            {

                dbCtx.Users.Add(user);

                int rowsAffected = dbCtx.SaveChanges();

                if(rowsAffected > 0)
                {

                    isInsert = true;

                }

            }

            return isInsert;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita_Moreno.BussinessEntities;

namespace Tiendita_Moreno.BussinessLogicLayer
{
    public class UserBLL
    {

        public static string Login(string User, string Pwd)
        {

            string msgError = string.Empty;

            if (string.IsNullOrEmpty(User) && string.IsNullOrEmpty(Pwd))
            {

                msgError = "Insertar el Usuario y/o Contraseña ";

            }
            else if (string.IsNullOrEmpty(User))
            {

                msgError = "Insertar el Usuario";

            }
            else if (string.IsNullOrEmpty(Pwd))
            {

                msgError = "Insertar la Contraseña";

            }
            else
            {

                try
                {

                    bool isExist = DataAccessLayer.UserDAL.Login(User, Pwd);

                    if (isExist != true)
                    {

                        msgError = "Usuario y/o Contraseña incorrectos";

                    }


                }
                catch (Exception e)
                {

                    msgError = e.Message.ToString();

                }

            }

            return msgError;

        }

        public static int CheckTheUsers()
        {

            return DataAccessLayer.UserDAL.CheckTheUsers();

        }

        public static string CreateUser(string User, string Pass, string cPass)
        {

            string Uid = User;
            string Pwd = Pass;
            string cPwd = cPass;

            string msgError = string.Empty;

            if(string.IsNullOrEmpty(Uid) && string.IsNullOrEmpty(Pwd)
                && string.IsNullOrEmpty(cPwd))
            {

                msgError = "Favor de llenar los campos";

            }
            else if (string.IsNullOrEmpty(Uid))
            {

                msgError = "Favor de Ingresar un Usuario";

            }
            else if (string.IsNullOrEmpty(Pwd))
            {

                msgError = "Favor de ingresar la contraseña";

            }
            else if (string.IsNullOrEmpty(cPwd))
            {

                msgError = "Favor de confirmar la contraseña";

            }
            else if(Pwd.Length < 8)
            {

                msgError = "Ingresar un contraseña con mas de 8 caracteres";

            }
            else if (Pwd != cPwd)
            {

                msgError = "Las contraseñas no son iguales";

            }
            else
            {

                User u = new User();

                u.Uid = User;
                u.Pwd = Pass;

                bool isInsert = DataAccessLayer.UserDAL.CreateUser(u);

                if(isInsert != true)
                {

                    msgError = "No se pudo crear el usuario";

                }

            }

            return msgError;

        }

    }
}

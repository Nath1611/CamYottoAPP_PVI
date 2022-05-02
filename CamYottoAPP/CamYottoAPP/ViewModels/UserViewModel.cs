using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using CamYottoAPP.Models;

namespace CamYottoAPP.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public Usuario MyUsuario { get; set; }
        public Tools.Crypto MyCrypto { get; set; }

        public UserViewModel()
        {
            MyUsuario = new Usuario();
            MyCrypto = new Tools.Crypto();
        }


        public async Task<bool> AddUser(int pUserId,
                                        string pUserName,
                                        int pPhone,
                                        string pEmail,
                                        string pPassword)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyUsuario.Idusuario = pUserId;
                MyUsuario.Nombre = pUserName;
                MyUsuario.Telefono = pPhone;
                MyUsuario.Email = pEmail;

                //ENCRIPTAR CONTRASEÑA
                string EncryptedPassword = MyCrypto.EncriptarEnUnSentido(pPassword);
                MyUsuario.Contrasenna = EncryptedPassword;

                bool r = await MyUsuario.AddNewUser();

                return r;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { IsBusy = false; }
        }

        internal Task<bool> AddUser(string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }


        //FUNCION PARA VALIDAR EL PERMISO DE ACCESO DEL USUARIO
        public async Task<bool> ValidateUserAccess(string pEmail, string pPassword)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {

                string EncriptedPassword = MyCrypto.EncriptarEnUnSentido(pPassword);

                MyUsuario.Nombre = pEmail;
                MyUsuario.Contrasenna = EncriptedPassword;

                bool r = await MyUsuario.ValidateUserAccess();

                return r;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }
        }


    }
}

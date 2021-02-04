using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLADORA.SEND_CORREO;
using CONTROLADORA.INFORME;
using CONTROLADORA.VALIDAR_AGREGAR;
using CONTROLADORA.USUARIOS_DE_GRUPO;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADORA
{
    public class usuarioModel
    {
        //manejo subir los datos de usuario al cache.
        checkLogin checkLogin = new checkLogin();
        public bool loginUsuario (string nombreUsuario, string claveUsuario)
        {
            return checkLogin.login(nombreUsuario, claveUsuario);
        }
        //manejo subir los datos del grupo al cache.
        readGrupo read = new readGrupo();
        public bool readGrupo(int idGrupo)
        {
            return read.leerGrupo(idGrupo);
        }

        recoverPassword recoverPassword = new recoverPassword();
        public string recover(string userRequesting, string emailRequesting)
        {
            return recoverPassword.recover(userRequesting, emailRequesting);
        }

        connectionInforme connectionInforme = new connectionInforme();
        public DataTable obtenerInforme(string nombreUsuario, string AU, string MU, string EU, string AG, string MG, string EG, DateTime fechaInicio, DateTime fechaFin)
        {
            return connectionInforme.obtenerInforme(nombreUsuario, AU, MU, EU, AG, MG, EG, fechaInicio, fechaFin);
        }

        agregarUsuario agregarUsuario = new agregarUsuario();
        public bool agregarU (string nombreUsuario)
        {
            return agregarUsuario.agregarU(nombreUsuario);
        }

        validarGrupo validarGrupo = new validarGrupo();
        public bool agregarG (string nombreGrupo)
        {
            return validarGrupo.agregarG(nombreGrupo);
        }

        readNombreGrupo readNombreGrupo = new readNombreGrupo();
        public bool leerGrupo (string nombreGrupo)
        {
            return readNombreGrupo.leerGrupo(nombreGrupo);
        }

        usuariosDeGrupo usuariosDeGrupo = new usuariosDeGrupo();
        public DataTable enviarDatos (int idGrupo)
        {
            return usuariosDeGrupo.enviarDato(idGrupo);
        }

    }
}

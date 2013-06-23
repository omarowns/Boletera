using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using BoleteraNS;

namespace Boletera
{
    class Usuario
    {
        private string nombre;
        private string turno;
        private string rol;
        private string pswd;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public string Pswd
        {
            get { return pswd; }
            set { pswd = value; }
        }

        public Usuario(string name,string turn,string role,string pass)
        {
            this.nombre = name;
            turno = turn;
            rol = role;
            pswd = pass;
        }

        public void addToDB(){
            string query = String.Format("INSERT INTO usuario (nombre,turno,rol,password,ultimo_login) VALUES ('{0}','{1}','{2}',password('{3}'),NOW())", nombre, turno, rol, pswd);
            Globals.connector.update(query);
        }
    }
}

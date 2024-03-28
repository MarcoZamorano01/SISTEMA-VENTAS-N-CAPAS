using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class ClienteDal
    {
        public DataTable ListaClienteDal()
        {
            string cosulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaClienteDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, PERSONA.NOMBRE+' '+PERSONA.APELLIDO AS NOMBRE, CLIENTE.TIPOCLIENTE,CLIENTE.CODIGOCLIENTE,PERSONA.TELEFONO,CLIENTE.ESTADO\r\nFROM CLIENTE \r\nINNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarClienteDal(CLIENTE cliente)
        {
            string consulta = "insert into cliente values('" + cliente.IdPersona + "','" + cliente.TipoCliente + "'," + "'" + cliente.CodigoCliente + "',"+ "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public CLIENTE ObtenerClienteId(int Id)
        {
            string consulta = "select * from cliente where idcliente=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            CLIENTE cli = new CLIENTE();
            if (tabla.Rows.Count > 0)
            {
                cli.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                cli.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                cli.TipoCliente = tabla.Rows[0]["TipoCliente"].ToString();
                cli.CodigoCliente = tabla.Rows[0]["CodigoCliente"].ToString();
                cli.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return cli;
        }
        public void EditarClienteDal(CLIENTE cliente)
        {
            string consulta = "update cliente set idpersona='" + cliente.IdPersona + "'," + "tipocliente='" + cliente.TipoCliente + "'," + "codigocliente='" + cliente.CodigoCliente + "' " + "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}

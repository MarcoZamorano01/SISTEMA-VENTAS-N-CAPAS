using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL.EXAMEN2
{
    public class Examen2Dal//POR MARCO ANDRES ZAMORANO ARAMAYO
    {
        public DataTable LitarUnoDal()//el uno
        {
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE + ' ' + P.APELLIDO AS NOMBRES\r\nFROM CLIENTE C\r\nINNER JOIN PERSONA P ON P.IDPERSONA = C.IDPERSONA";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarDosDal()//el dos
        {
            string consulta = "SELECT PEER.IDPROVEEDOR, PEER.NOMBRE, SUM(I.TOTAL)TOTAL_ING\r\nFROM PROVEEDOR PEER\r\nINNER JOIN INGRESO I ON PEER.IDPROVEEDOR = I.IDPROVEEDOR\r\nGROUP BY PEER.IDPROVEEDOR, PEER.NOMBRE ";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarTresDal()//el tres
        {
            string consulta = "SELECT TOP 1 M.IDMARCA, M.NOMBRE, SUM(V.TOTAL)TOTAL\r\nFROM MARCA M\r\nINNER JOIN PRODUCTO P ON P.IDMARCA = M.IDMARCA\r\nINNER JOIN DETALLEVENTA DT ON P.IDPRODUCTO = DT.IDPRODUCTO\r\nINNER JOIN VENTA V ON V.IDVENTA = DT.IDVENTA\r\nGROUP BY M.IDMARCA, M.NOMBRE \r\nORDER BY TOTAL DESC";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarCuatroDal()//el cuatro
        {
            string consulta = "SELECT ESTADO, SUM(UNIDAD)PROD_INVENTARIO\r\nFROM PRODUCTO\r\nGROUP BY ESTADO";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarCincoDal()//el cinco
        {
            string consulta = "SELECT P.IDPRODUCTO, P.NOMBRE, DG.FECHAVENC\r\nFROM PRODUCTO P\r\nINNER JOIN DETALLEING DG ON DG.IDPRODUCTO = P.IDPRODUCTO\r\nWHERE YEAR(FECHAVENC) = 2024 AND MONTH(FECHAVENC)= 04 AND DAY(FECHAVENC) >= 1\r\nORDER BY DG.FECHAVENC";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarSeisDal()//el seis
        {
            string consulta = "SELECT V.IDVENDEDOR, P.NOMBRE, DT.CANTIDAD\r\nFROM VENTA V\r\nINNER JOIN DETALLEVENTA DT ON DT.IDVENTA = V.IDVENTA\r\nINNER JOIN PRODUCTO P ON P.IDPRODUCTO = DT.IDPRODUCTO\r\nORDER BY IDVENDEDOR";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarSieteDal()//el siete
        {
            string consulta = "SELECT C.IDCLIENTE, SUM(I.TOTAL)INGRESO_TOTAL, C.ESTADO\r\nFROM CLIENTE C\r\nINNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\nINNER JOIN DETALLEVENTA DT ON DT.IDVENTA = V.IDVENTA\r\nINNER JOIN PRODUCTO P ON P.IDPRODUCTO = DT.IDPRODUCTO\r\nINNER JOIN DETALLEING DG ON DG.IDPRODUCTO = P.IDPRODUCTO\r\nINNER JOIN INGRESO I ON I.IDINGRESO = DG.IDINGRESO\r\nGROUP BY C.IDCLIENTE, C.ESTADO";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarOchoDal()//el ocho
        {
            string consulta = "SELECT TOP 1 PEER.IDPROVEEDOR, PEER.NOMBRE, SUM(DG.CANTIDAD)CANTIDAD_PRODUC\r\nFROM PROVEEDOR PEER\r\nINNER JOIN INGRESO I ON PEER.IDPROVEEDOR = I.IDPROVEEDOR\r\nINNER JOIN DETALLEING DG ON I.IDINGRESO = DG.IDINGRESO\r\nGROUP BY PEER.IDPROVEEDOR, PEER.NOMBRE\r\nORDER BY CANTIDAD_PRODUC DESC";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarNueveDal()//el nueve
        {
            string consulta = "SELECT TP.IDTIPOPROD, TP.NOMBRE, SUM(DT.CANTIDAD)CANTIDAD\r\nFROM PRODUCTO P \r\nINNER JOIN TIPOPROD TP ON TP.IDTIPOPROD = P.IDTIPOPROD\r\nINNER JOIN DETALLEVENTA DT ON DT.IDPRODUCTO = P.IDPRODUCTO\r\nGROUP BY TP.IDTIPOPROD, TP.NOMBRE";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public DataTable LitarDiezDal()//el diez
        {
            string consulta = "SELECT C.IDCLIENTE, V.TOTAL\r\nFROM CLIENTE C\r\nINNER JOIN VENTA V ON V.IDCLIENTE = C.IDCLIENTE\r\nWHERE V.TOTAL >= 20.00\r\nORDER BY IDCLIENTE";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
    }
}

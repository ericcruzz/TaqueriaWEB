using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class PagoVO
    {
        private int _ID_Pago;
        private DateTime _Fecha;
        private DateTime _Hora;
        private double _Subtotal;
        private double _Iva;
        private double _Total;
        private int _FormaDePago_ID;
        private int _Comanda_ID;

        public int ID_Pago { get => _ID_Pago; set => _ID_Pago = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public DateTime Hora { get => _Hora; set => _Hora = value; }
        public double Subtotal { get => _Subtotal; set => _Subtotal = value; }
        public double Iva { get => _Iva; set => _Iva = value; }
        public double Total { get => _Total; set => _Total = value; }
        public int FormaDePago_ID { get => _FormaDePago_ID; set => _FormaDePago_ID = value; }
        public int Comanda_ID { get => _Comanda_ID; set => _Comanda_ID = value; }

        public PagoVO()
        {
            ID_Pago = 0;
            Fecha = DateTime.Parse("1990-01-01");
            Hora = DateTime.Parse("00:00:00");
            Subtotal = 0;
            Iva = 0;
            Total = 0;
            FormaDePago_ID = 0;
            Comanda_ID = 0;
        }
        public PagoVO(DataRow dr)
        {
            ID_Pago = int.Parse(dr["ID_Pago"].ToString());
            Fecha = DateTime.Parse(dr["Fecha"].ToString());
            Hora = DateTime.Parse(dr["Hora"].ToString());
            Subtotal = double.Parse(dr["Subtotal"].ToString());
            Iva = double.Parse(dr["Iva"].ToString());
            Total = double.Parse(dr["Total"].ToString());
            FormaDePago_ID = int.Parse(dr["FormaDePago_ID"].ToString());
            Comanda_ID = int.Parse(dr["Comanda_ID"].ToString());
        }
    }
}

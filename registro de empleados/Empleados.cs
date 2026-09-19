namespace RegistroEmpleados
{
    public class Empleado
    {
        public string Nombre { get; set; } = "";
        public int Id { get; set; }
        public int HorasExtra { get; set; }
        public decimal SalarioBase { get; set; }

        public decimal PagoTotal()
        {
            decimal pagoExtra = HorasExtra * 50;
            return SalarioBase + pagoExtra;
        }

        public override string ToString()
        {
            decimal total = PagoTotal();

            return $"{Id,-3} {Nombre,-20} Q {SalarioBase,10:N2} x{HorasExtra,-5} = Q {total,10:N2}";
        }
    }
}
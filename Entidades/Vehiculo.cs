namespace Entidades
{
    public enum EPropulsion { Combustion, Hibrida, Electrica}

    public class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion { get { return propulsion; } }

        protected Vehiculo(EPropulsion propulsion)
            : this(propulsion, false)
        {

        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
            this.numeroDeChasis = Guid.NewGuid();
        }

        protected string Tipo { get; } 

        protected virtual string GetInfo()
        {
            return "";
        }

        public override string ToString()
        {
            return GetInfo();
        }

        public static bool operator ==(Vehiculo v1,  Vehiculo v2)
        {
            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1,  Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
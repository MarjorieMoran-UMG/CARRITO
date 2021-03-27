using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRO.Clase
{
    class ClsMotor
    {
        public int Anio { get;}
        public int VelMaxima { get; set; }
        public string Color { get; set; }
        private int VelActual = 0;
        public bool EncenderRadio { get; set; } = false;
        public bool Encendido { get; set; } = false;

        private int primera = 10;
        private int cambioasegunda = 15;
        private int segunda = 15;
        private int cambioatercera = 25;
        private int tercera = 25;
        private int cambioacuarta = 35;
        private int cuarta = 35;
        private int cambioaquinta = 45;
        private int quinta = 45;
        private int volar = 50;

        public ClsMotor(int AnioCarro, int VelMax)
        {
            this.VelMaxima = VelMax;
            this.Anio = AnioCarro;
        }

        public ClsMotor(int AnioCarro, int VelMax, string ColorCarro)
        {
            this.VelMaxima = VelMax;
            this.Anio = AnioCarro;
            this.Color = ColorCarro;
        }


        public string EncenderCarro()
        {
            string Respuesta = "";
            if (Encendido)
            {
                VelMaxima = 0;
                Encendido = false;
                Respuesta = "¡Ahora el carro está apagado!";
            }
            else
            {
                VelActual = 0;
                Encendido = true;
                Respuesta = "¡Carro encedido! ¡Por favor ponte el cinturón de seguridad!";
            }
            VelActual = 0;
            return Respuesta;
        }

        public string Frenar()
        { 
            if (!Encendido)
            {
                return "Por favor enciende el carro primero";
            } else
            {
                VelActual = 0;
            }
            return "El carro se ha detenido";
        }

        public string Acelerar()
        {
            if (!Encendido)
            {
                return "Enciende el carro por favor";
            }
            if (VelActual>VelMaxima)
            {
                VelActual = VelMaxima;
                return $"Ya llegaste al tope {VelMaxima} KPH";
            }else
            {
                VelActual = VelActual + 5;
                return $"Vas a {VelActual} KPH";
            }
        }

        public string PalankdeCambios()
        {
            string RCambio = "";
            if ((VelActual == primera) || (VelActual < segunda))
            {
                RCambio = "Primera";
            }else
            if ((VelActual == segunda) || (VelActual<tercera))
            {
                RCambio = "Segunda";
            }else
            if ((VelActual == tercera) || (VelActual<cuarta))
            {
                RCambio = "Tercera";
            }else
            if ((VelActual == cuarta) || (VelActual<=quinta))
            {
                RCambio = "Cuarta";
            }else
            if ((VelActual == quinta) || (VelActual<volar))
            {
                RCambio = "Quinta";
            }
            else
            if (VelActual >= volar)
            {
                RCambio = "Vas a alta velocidad por tu seguridad por favor maneja con precaución";
            }
            return RCambio;
        }


        public string Cambios()
        {
            string RCambio = "";
            if (VelActual == cambioasegunda)
            {
                RCambio = "Por la seguridad del carro por favor cambia a segunda";
            }else
            if (VelActual == cambioatercera)
            {
                RCambio = "Por la seguridad del carro por favor cambia a tercera";
            }else
            if (VelActual == cambioacuarta)
            {
                RCambio = "Por la seguridad del carro por favor cambia a cuarta";
            }else
            if (VelActual == cambioaquinta)
            {
                RCambio = "Por la seguridad del carro por favor cambia a quinta";
            }else
            if (VelActual >= volar)
            {
                RCambio = "Vas a alta velocidad por tu seguridad por favor maneja con precaución";
            }
            return RCambio;
        }
    }
}


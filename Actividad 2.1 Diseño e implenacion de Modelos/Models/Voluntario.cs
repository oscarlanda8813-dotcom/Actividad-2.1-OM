//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Voluntario

using System;

namespace DirectorioONG.Models
{
    public class Voluntario
    {
        private string idVoluntario;
        private string nombre;
        private int horasAportadas;
        private string rutaImagen;
        private bool estadoActivo;

        public string IdVoluntario
        {
            get { return idVoluntario; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID requerido."); idVoluntario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre requerido."); nombre = value; }
        }
        public int HorasAportadas
        {
            get { return horasAportadas; }
            set { if (value < 0) throw new ArgumentException("Las horas no pueden ser negativas."); horasAportadas = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Voluntario()
        {
            idVoluntario = "VOL-000";
            nombre = "Sin Nombre";
            horasAportadas = 0;
            rutaImagen = "voluntario_default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Voluntario(string idVoluntario, string nombre, int horasAportadas, string rutaImagen, bool estadoActivo)
        {
            IdVoluntario = idVoluntario;
            Nombre = nombre;
            HorasAportadas = horasAportadas;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Evalúa si el voluntario alcanza el nivel de reconocimiento por acumular al menos 50 horas de servicio.
        public bool ElegibleParaReconocimiento()
        {
            int horasMinimasEstandar = 50;
            return EstadoActivo && HorasAportadas >= horasMinimasEstandar;
        }

        // Versión B (Con parámetro externo): Evalúa la elegibilidad para reconocimientos o insignias según una meta de horas personalizada.
        public bool ElegibleParaReconocimiento(int metaHorasRequeridas)
        {
            return EstadoActivo && HorasAportadas >= metaHorasRequeridas;
        }

        public override string ToString()
        {
            return $"[Admin] ID: {IdAdmin} | Nombre: {Nombre} | Correo: {Correo} | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SQL
using MySql.Data.MySqlClient; //MYSQL

namespace CapaModelo2
{
    public class CM_Siembra
    {
        public static int Etapa;
        public static int Nitra;

        public static int NitroDosis; //Nitrogeno agregado en fase
        public static int FosfoDosis; //Fosforo agregado en fase

        public static int Ntotal; //Nitrogeno total agregado
        public static int Ptotal; //Fosforo total agregado

        public static int Nc; //Nivel critico
        public static int Ps; //Fosforo en suelo
        public static int EQ; //Equivalente en fertilizante 
        public static int Ns; //Nitrogeno en suelo
        public static double Np; //Nitrogeno en planta

        public static double NcD; //Nivel critico Double

        public static int NitroDis; //Nitrogeno disponible
        public static int FosfoDis; //Nitrogeno disponible

        public static string Sector; //Sector actual

        public static string ss; //semilla seleccionada



        public static string Plantacion;
        public static string Estado;
        public static string Fase;
        public static string Inicio;
        public static string Fin;

        public static int SId;
        public static int r;
        public static int fer = 0; //fertilizacion activada o desactivada


        public static string secl; //Sector listo

    }
}


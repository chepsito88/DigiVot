﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public class Construye_Objeto
    {
        public static ICrud intancias (int Opc) {
            switch (Opc)
            {
                case 1:return new DAO_Perfiles();
                case 2:return new DAO_Reglas();
                case 3:return new DAO_PerfilReglas();
                case 4: return new Adapter_DAO_Usuario();
                case 5: return new DAO_Candidato();
                case 6: return new DAO_Partidos();
                case 7: return new DAO_Ciudadano();
                case 8: return new DAO_Elecciones();
                case 9:return new DAO_Funcionario();
                case 10: return new DAO_Mesa();
                case 11: return new DAO_Localidades();
                case 12: return new DAO_Casilla();
                case 13: return new DAO_Reportes();
                default: return null;
            }
        }
    }
}

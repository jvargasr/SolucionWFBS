﻿using System;
using System.Collections.Generic;
using System.Data;
using WFBS.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class ReporteGrupal
    {
        [TestMethod]
        public void cantidadMaximaNotas()
        {
            Collections col = new Collections();
            List<WFBS.Negocio.Area> areas = new List<WFBS.Negocio.Area>();
            List<WFBS.Negocio.Competencia> competencias = new List<WFBS.Negocio.Competencia>();
            List<float> brechas = new List<float>();


            int nbrechas = 0;
            foreach (WFBS.Negocio.Area a in areas)
            {
                foreach (WFBS.Negocio.Competencia com in competencias)
                {
                    brechas = col.ObtenerNotasCompetencia((int)a.Id_area, (int)com.Id_com);
                    if (brechas.Count > nbrechas)
                        nbrechas = brechas.Count;

                }
            }
        }

        [TestMethod]
        public void ListarResultados()
        {
            Collections col = new Collections();
            List<WFBS.Negocio.Area> areas = new List<WFBS.Negocio.Area>();
            List<WFBS.Negocio.Competencia> competencias = new List<WFBS.Negocio.Competencia>();
            List<float> brechas = new List<float>();
            DataRow row;
            DataTable table = new DataTable();
            float sumabrechas = 0;
            foreach (WFBS.Negocio.Area a in areas)
            {
                foreach (WFBS.Negocio.Competencia com in competencias)
                {
                    sumabrechas = 0;
                    brechas = col.ObtenerNotasCompetencia((int)a.Id_area, (int)com.Id_com);
                    if (brechas.Count > 0)
                    {
                        row = table.NewRow();
                        row["Cargo"] = a.area;
                        row["Competencia"] = com.Nombre;
                        for (int i = 0; i < brechas.Count; i++)
                        {
                            row["N" + (i + 1)] = brechas[i];
                            sumabrechas = brechas[i] + sumabrechas;
                        }
                        row["Brecha Promedio"] = (sumabrechas / brechas.Count).ToString("0.0");
                        table.Rows.Add(row);
                    }
                }
            }
        }
    }
}

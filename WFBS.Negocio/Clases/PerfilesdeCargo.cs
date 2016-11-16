﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.DALC;
using System.Xml.Serialization;
using System.IO;

namespace WFBS.Negocio
{
    public class PerfilesdeCargo
    {
        public int id_perfil_de_cargo { get; set; }
        public string descripcion { get; set; }
        public int Obsoleto { get; set; }
        public decimal Id_PC { get; set; }
        public string Obs { get; set; }
        public string id_areas { get; set; }
        public PerfilesdeCargo()
        {
            this.Init();
        }

        private void Init()
        {
            this.descripcion = string.Empty;
            this.id_perfil_de_cargo = 0;
            this.Obsoleto = 0;
            this.id_areas = string.Empty;
        }

        public PerfilesdeCargo(string xml)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(PerfilesdeCargo));
            StringReader read = new StringReader(xml);

            PerfilesdeCargo pc = (PerfilesdeCargo)serializador.Deserialize(read);

            this.id_perfil_de_cargo = Convert.ToInt32(pc.Id_PC);
            this.descripcion = pc.descripcion;
            this.Obsoleto = pc.Obsoleto;
            this.id_areas = pc.id_areas;
        }

        public bool Create(List<Area> areasSelec)
        {
            try
            {
                DALC.WFBSEntities perfilesDC = new DALC.WFBSEntities();
                DALC.PERFIL_DE_CARGO pc = new PERFIL_DE_CARGO();

                string areas = string.Empty;
                pc.OBSOLETO = this.Obsoleto;
                pc.DESCRIPCION = this.descripcion;
                foreach (Area a in areasSelec)
                {
                    areas = areas + a.Id_area.ToString() + ",";
                }
                pc.ID_AREAS = areas;

                perfilesDC.PERFIL_DE_CARGO.Add(pc);
                perfilesDC.SaveChanges();
                perfilesDC = null;
                return true;
            }
            catch (Exception ex)
            {
                Logger.log("No se pudo agregar el perfil de cargo: " + ex.ToString());
                return false;
            }
        }
        public bool Read()
        {
            try
            {
                DALC.WFBSEntities perfilesDC = new DALC.WFBSEntities();
                DALC.PERFIL_DE_CARGO pc = perfilesDC.PERFIL_DE_CARGO.First(p => p.ID_PERFIL_DE_CARGO == this.id_perfil_de_cargo);

                this.id_perfil_de_cargo = Convert.ToInt32(pc.ID_PERFIL_DE_CARGO);
                this.descripcion = pc.DESCRIPCION;
                this.Obsoleto = Convert.ToInt32(pc.OBSOLETO);
                this.id_areas = pc.ID_AREAS;

                perfilesDC = null;
                return true;
            }
            catch (Exception ex)
            {
                Logger.log("No se pudo leer el perfil de cargo: " + ex.ToString());
                return false;
            }
        }
        public bool Update(List<Area> areasSelec)
        {
            string areas = string.Empty;
            try
            {
                DALC.WFBSEntities perfilesDC = new DALC.WFBSEntities();
                DALC.PERFIL_DE_CARGO pc = perfilesDC.PERFIL_DE_CARGO.First(p => p.ID_PERFIL_DE_CARGO == this.Id_PC);
                pc.ID_PERFIL_DE_CARGO = this.id_perfil_de_cargo;
                pc.DESCRIPCION = this.descripcion;
                pc.OBSOLETO = this.Obsoleto;
                foreach (Area a in areasSelec)
                {
                    areas = areas + a.Id_area.ToString() + ",";
                }
                pc.ID_AREAS = areas;
                perfilesDC.SaveChanges();
                perfilesDC = null;
                return true;
            }
            catch (Exception ex)
            {
                Logger.log("No se pudo actualizar el perfil de cargo: " + ex.ToString());
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                DALC.WFBSEntities perfilesDC = new DALC.WFBSEntities();
                DALC.PERFIL_DE_CARGO pc = perfilesDC.PERFIL_DE_CARGO.First(p => p.ID_PERFIL_DE_CARGO == this.id_perfil_de_cargo);
                // pcargo.OBSOLETA = 1;
                pc.OBSOLETO = 1;
                perfilesDC.SaveChanges();
                perfilesDC = null;
                return true;
            }
            catch (Exception ex)
            {
                Logger.log("No se pudo desactivar el perfil de cargo: " + ex.ToString());
                return false;
            }
        }

        public string Serializar()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(PerfilesdeCargo));
            StringWriter writer = new StringWriter();
            serializador.Serialize(writer, this);
            writer.Close();
            return writer.ToString();
        }
    }
}

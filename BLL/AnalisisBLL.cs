﻿using Rosario_Registry.DAL;
using Rosario_Registry.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rosario_Registry.BLL
{
    public class AnalisisBLL
    {
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.analisis.Add(analisis) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.analisis.Find(analisis.AnalisisId);
                foreach(var item in Anterior.Resultado)
                {
                    if (!analisis.Resultado.Exists(d => d.AnalisisId == item.AnalisisId))
                        db.Entry(item).State = EntityState.Deleted;
                }


                db.Entry(analisis).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.analisis.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Analisis Buscar(int id)
        {
            Contexto db = new Contexto();
            Analisis analisis = new Analisis();

            try
            {
                analisis = db.analisis.Find(id);
                analisis.Resultado.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return analisis;
        }
        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> analisis)
        {
            List<Analisis> Lista = new List<Analisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.analisis.Where(analisis).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}

using Rosario_Registry.DAL;
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
    public class TipoAnalisisBLL
    {
        public static bool Guardar(TiposAnalisis tiposanalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.tiposanalisis.Add(tiposanalisis) != null)
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

        public static bool Modificar(TiposAnalisis tiposanalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(tiposanalisis).State = EntityState.Modified;
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
                var eliminar = db.tiposanalisis.Find(id);
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

        public static TiposAnalisis Buscar(int id)
        {
            Contexto db = new Contexto();
            TiposAnalisis tiposanalisis = new TiposAnalisis();

            try
            {
                tiposanalisis = db.tiposanalisis.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return tiposanalisis;
        }

        public static List<TiposAnalisis> GetList(Expression<Func<TiposAnalisis, bool>> tiposanalisis)
        {
            List<TiposAnalisis> Lista = new List<TiposAnalisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.tiposanalisis.Where(tiposanalisis).ToList();
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

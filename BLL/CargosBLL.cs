using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rosario_Registry.DAL;
using Rosario_Registry.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Rosario_Registry.BLL
{
    public class CargosBLL
    {
        public static bool Guardar(Cargos cargos)
        {
            bool paso = false;
            ContextoCargos db = new ContextoCargos();
            try
            {
                if (db.cargos.Add(cargos) != null)
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

        public static bool Modificar(Cargos cargos)
        {
            bool paso = false;
            ContextoCargos db = new ContextoCargos();

            try
            {
                db.Entry(cargos).State = EntityState.Modified;
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
            ContextoCargos db = new ContextoCargos();

            try
            {
                var eliminar = db.cargos.Find(id);
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

        public static Cargos Buscar(int id)
        {
            ContextoCargos db = new ContextoCargos();
            Cargos cargos = new Cargos();

            try
            {
                cargos = db.cargos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return cargos;
        }

        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> cargos)
        {
            List<Cargos> Lista = new List<Cargos>();
            ContextoCargos db = new ContextoCargos();

            try
            {
                Lista = db.cargos.Where(cargos).ToList();
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
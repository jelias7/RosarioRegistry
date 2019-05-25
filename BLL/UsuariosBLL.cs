﻿using System;
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
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuarios)
        {
            bool paso = false;
            ContextoUsuarios db = new ContextoUsuarios();
            try
            {
                if (db.User.Add(usuarios) != null)
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

        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            ContextoUsuarios db = new ContextoUsuarios();

            try
            {
                db.Entry(usuarios).State = EntityState.Modified;
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
            ContextoUsuarios db = new ContextoUsuarios();

            try
            {
                var eliminar = db.User.Find(id);
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

        public static Usuarios Buscar(int id)
        {
            ContextoUsuarios db = new ContextoUsuarios();
            Usuarios usuarios = new Usuarios();

            try
            {
                usuarios = db.User.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return usuarios;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> usuarios)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            ContextoUsuarios db = new ContextoUsuarios();

            try
            {
                Lista = db.User.Where(usuarios).ToList();
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

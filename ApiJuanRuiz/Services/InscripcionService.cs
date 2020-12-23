using ApiJuanRuiz.DBContext;
using ApiJuanRuiz.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJuanRuiz.Services
{
    public class InscripcionService
    {
        public readonly InscripcionDBContext _context;
        public InscripcionService(InscripcionDBContext context)
        {
            _context = context;
        }

        public List<Inscripcion> VerListado()
        {
            var Lista = _context.Inscripcion.Include(x => x.Casa).OrderByDescending(x => x.Id).ToList();
            return Lista;
        }

        public Inscripcion ObtenerPorID(int ID)
        {
            try
            {
                var ListaEncontrada = _context.Inscripcion.Where(x => x.Id == ID).FirstOrDefault();
                var casaencontrada = _context.Casa.Where(x => x.Id == ListaEncontrada.Id).FirstOrDefault();

                return ListaEncontrada;
            }
            catch (Exception error)
            {
                return new Inscripcion();
            }
        }
        public bool Agregar(Inscripcion AgregarEst)
        {
            try
            {
                _context.Inscripcion.Add(AgregarEst);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool Editar(Inscripcion EditarEst)
        {
            try
            {
                var Ins = _context.Inscripcion.FirstOrDefault(x => x.Id == EditarEst.Id);
                Ins.Nombre = EditarEst.Nombre;
                Ins.Apellido = EditarEst.Apellido;
                Ins.Edad = EditarEst.Edad;
                Ins.IdCasa = EditarEst.IdCasa;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Eliminar(int ID)
        {
            try
            {
                var noticiaEliminar = _context.Inscripcion.FirstOrDefault(x => x.Id == ID);
                _context.Inscripcion.Remove(noticiaEliminar);
                _context.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                return true;
            }
        }



    }

}

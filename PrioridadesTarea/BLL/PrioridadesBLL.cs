using Microsoft.EntityFrameworkCore;
using PrioridadesTarea.DAL;
using PrioridadesTarea.Models;

namespace PrioridadesTarea.BLL
{
    public class PrioridadesBLL
    {
        private Contexto _contexto;

        public PrioridadesBLL(Contexto contexto) {
            _contexto = contexto;
        }

        public bool Existe(int prioridadId) {
            return _contexto.Prioridades.Any(o => o.PrioridadId == prioridadId);
        }

        public bool Insertar(Prioridades prioridad) {
            _contexto.Prioridades.Add(prioridad); 
            return _contexto.SaveChanges() > 0;
        }

        public bool Modificar(Prioridades prioridad) {
            _contexto.Entry(prioridad).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }

        public bool Guardar(Prioridades prioridad) {
            if (!Existe(prioridad.PrioridadId))
                return this.Insertar(prioridad);
            else
                return this.Modificar(prioridad);
        }

        public bool Eliminar(Prioridades prioridad) {
            _contexto.Entry(prioridad).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Prioridades? Buscar(int prioridadId) {
            return _contexto.Prioridades.Where(o => o.PrioridadId == prioridadId)
                .AsNoTracking()
                .SingleOrDefault();
        }
    }
}

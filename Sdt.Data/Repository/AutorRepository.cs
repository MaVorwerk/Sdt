using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sdt.Data.Context;
using Sdt.Data.Contracts;
using Sdt.Domain.Entities;

namespace Sdt.Data.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private bool disposedValue;
        private readonly SdtDataContext _context;

        public AutorRepository(SdtDataContext context)
        {
            _context = context;
        }

        public void Add(Autor entity)
        {
            _context.Autoren.Add(entity);
        }

        public void Delete(Autor entity)
        {
            _context.Autoren.Remove(entity);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Autoren.FindAsync(id) != null;
        }

        public IQueryable<Autor> GetAll()
        {
            return _context.Autoren.Include(c => c.Sprueche);
        }

        public Autor GetById(int id)
        {
            return _context.Autoren.Find(id);
        }

        public IQueryable<Autor> GetOnlyAutoren()
        {
            return _context.Autoren;
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public void Update(Autor entity)
        {
            _context.Autoren.Update(entity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    _context.Dispose();
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~AutorRepository()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

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
    public class SpruchRepository : ISpruchRepository
    {
        private bool disposedValue;

        private readonly SdtDataContext _context;

        public SpruchRepository(SdtDataContext context)
        {
            _context = context;
        }

        public void Add(Spruch entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Spruch entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Spruch> GetAll()
        {
            return _context.Sprueche.Include(c => c.Autor);
        }

        public Spruch GetById(int id)
        {
            return _context.Sprueche.Include(c => c.Autor).SingleOrDefault(c => c.SpruchId == id);
        }

        public Spruch GetSpruchDesTages()
        {
            var spruecheIds = _context.Sprueche.Select(c => c.SpruchId).ToList(); //1,5,10,33
            var random = new Random();
            var zufallsSpruchId = spruecheIds[random.Next(0, spruecheIds.Count)]; // [1,5,10,33] => position 0,1,2,3

            return GetById(zufallsSpruchId);
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Spruch entity)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~SpruchRepository()
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

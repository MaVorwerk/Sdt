using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdt.Data.Contracts;
using Sdt.Domain.Entities;

namespace Sdt.Data.Repository
{
    public class FakeAutorRepository : IAutorRepository
    {
        private bool disposedValue;
        private static readonly List<Autor> _autoren;

        static FakeAutorRepository()
        {
            _autoren = GetGeneratedAutorList();
        }

        private static List<Autor> GetGeneratedAutorList()
        {
            return new List<Autor>()
            {
                new Autor()
                {
                    AutorId = 1,
                    Name = "Albert Einstein FAKE",
                    Beschreibung = "Physiker",
                    Geburtsdatum = new DateTime(1899, 1, 2),
                    Sprueche = new List<Spruch>()
                    {
                        new Spruch()
                        {
                            //Autor = _autoren[0], 
                            AutorId = 1,
                            SpruchId = 1,
                            SpruchText =
                                "Ich bin nicht sicher, mit welchen Waffen der dritte Weltkrieg ausgetragen wird, aber im vierten Weltkrieg werden sie mit Stöcken und Steinen kämpfen."
                        },
                        new Spruch()
                        {
                            AutorId = 1,
                            SpruchId = 2,
                            SpruchText = "Phantasie ist wichtiger als Wissen, denn Wissen ist begrenzt."
                        }
                    }
                },
                new Autor()
                {
                    AutorId = 2,
                    Name = "Mark Twain FAKE",
                    Beschreibung = "Philosoph",
                    Geburtsdatum = new DateTime(1835, 11, 30),
                    Sprueche = new List<Spruch>
                    {
                        new Spruch()
                        {
                            AutorId = 2,
                            SpruchId = 3,
                            SpruchText =
                                "Gott hat den Menschen erschaffen, weil er vom Affen enttäuscht war. Danach hat er auf weitere Experimente verzichtet."
                        },
                        new Spruch()
                        {
                            AutorId = 2,
                            SpruchId = 4,
                            SpruchText = "Man könnte viele Beispiele für unsinnige Ausgaben nennen, aber keines ist treffender als die Errichtung einer Friedhofsmauer. Die, die drinnen sind, können sowieso nicht hinaus, und die, die draußen sind, wollen nicht hinein."
                        },
                        new Spruch()
                        {
                            AutorId = 2,
                            SpruchId = 5,
                            SpruchText = "Man vergisst vielleicht, wo man die Friedenspfeife vergraben hat. Aber man vergisst niemals, wo das Beil liegt."
                        }
                    }
                },
                new Autor()
                {
                    AutorId = 3,
                    Name = "Oscar Wilde FAKE",
                    Beschreibung = "Schriftsteller",
                    Geburtsdatum = new DateTime(1854, 10, 16),
                    Sprueche = new List<Spruch>
                    {
                        new Spruch()
                        {
                            AutorId = 3,
                            SpruchId = 6,
                            SpruchText ="Gesegnet seien jene, die nichts zu sagen haben und den Mund halten."
                        },
                        new Spruch()
                        {
                            AutorId = 3,
                            SpruchId = 7,
                            SpruchText = "Ein Zyniker ist ein Mensch, der von jedem Ding den Preis und von keinem den Wert kennt."
                        },
                        new Spruch()
                        {
                            AutorId = 3,
                            SpruchId = 8,
                            SpruchText = "Die Ehe ist ein Versuch, zu zweit wenigstens halb so glücklich zu werden, wie man allein gewesen ist."
                        }
                    }
                }
            };
        }

        public void Add(Autor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Autor entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Autor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Autor GetById(int id)
        {
            return _autoren.Find(c => c.AutorId == id);
        }

        public IQueryable<Autor> GetOnlyAutoren()
        {
            return _autoren.AsQueryable();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Autor entity)
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
        // ~FakeAutorRepository()
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

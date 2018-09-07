//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.Linq;

namespace CardBringer2
{
    using System;
    using System.Collections.Generic;
    
    public partial class oglas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oglas()
        {
            this.kosharica = new HashSet<kosharica>();
        }
    
        public int idOglas { get; set; }
        public int idKorisnik { get; set; }
        public int idKarta { get; set; }
        public decimal cijena { get; set; }
        public int kolicina { get; set; }
        public byte aktivan { get; set; }

        //public static oglas Dohvati(int idOglas)
        //{
        //    oglas o = new oglas();
        //    using (var context = new CardBringerDBEntities())
        //    {
        //        o = context.oglas.SingleOrDefault(c => c.idOglas == idOglas);
        //    }
        //    return o;
        //}

        public void Spremi()
        {
            using (var context = new CardBringerDBEntities())
            {
                context.oglas.Add(this);
                context.SaveChanges();
            }
        }

        //public void UkloniOglas()
        //{
        //    using (var context = new CardBringerDBEntities())
        //    {
        //        context.oglas.Remove(this);
        //        context.SaveChanges();
        //    }
        //}

        //public static void DeaktivirajOglas(int idOglas)
        //{
        //    using (var context = new CardBringerDBEntities())
        //    {
        //        var result = context.oglas.SingleOrDefault(c => c.idOglas == idOglas && c.kolicina > 0);
        //        if (result == null) return;
        //        result.aktivan = 0;
        //        context.SaveChanges();
        //    }
        //}

        public static void UpdateKolicinuUOglasu(int idOglas, int novaKolicina, bool vracanjeIzKosarice)
        {
            using (var context = new CardBringerDBEntities())
            {
                var result = context.oglas.SingleOrDefault(c => c.idOglas == idOglas);
                if (result == null) return;
                if (vracanjeIzKosarice)
                {
                    result.kolicina += novaKolicina;
                }
                else
                {
                    result.kolicina = novaKolicina;
                }
                context.SaveChanges();
            }
        }

        public static void DeaktivirajOglas(int id)
        {
            using (var context = new CardBringerDBEntities())
            {
                var result = context.oglas.SingleOrDefault(c => c.idOglas == id && c.kolicina == 0);
                if (result == null) return;
                result.aktivan = 0;
                context.SaveChanges();
            }
        }

        public static List<object> DohvatiSveAktivneOglase()
        {
            List<object> oglasi = new List<object>();
            using (var context = new CardBringerDBEntities())
            {
                var result = context.oglas
                    .Join(context.korisnik, (o => o.idKorisnik), (p => p.idKorisnika),
                    (o, p) => new {
                        o,
                        p
                    })
                    .Join(context.karta, r => r.o.idKarta, s => s.idKarta,
                    (r, s) => new {
                        s.imeKarte,
                        s.opisKarte,
                        r.o.cijena,
                        r.o.kolicina,
                        r.p.ime,
                        r.o.idOglas,
                        s.slikaKarte,
                        r.o.aktivan
                    })
                    .Where(c=> c.aktivan == 1 && c.kolicina > 0)
                    .ToList();

                foreach (var r in result)
                {
                    oglasi.Add(r);
                }
            }
            return oglasi;
        }

        public static List<object> DohvatiSvojeOglase()
        {
            if (korisnik.PrijavljeniKorisnik == null)
            {
                return null;
            }

            List<object> oglasi = new List<object>();
            using (var context = new CardBringerDBEntities())
            {
                var result = context.oglas
                    .Join(context.korisnik, (o => o.idKorisnik), (p => p.idKorisnika),
                        (o, p) => new {
                            o,
                            p
                        })
                    .Join(context.karta, r => r.o.idKarta, s => s.idKarta,
                        (r, s) => new {
                            s.imeKarte,
                            s.opisKarte,
                            r.o.cijena,
                            r.o.kolicina,
                            r.p.ime,
                            r.o.idOglas,
                            s.slikaKarte,
                            r.o.aktivan
                        })
                    .Where(c => c.ime == CardBringer2.korisnik.PrijavljeniKorisnik.ime && c.aktivan == 1)
                    .ToList();

                foreach (var r in result)
                {
                    oglasi.Add(r);
                }
            }
            return oglasi;
        }

        public static List<object> TraziOglase(string pretrazivaniString)
        {
            if (korisnik.PrijavljeniKorisnik == null)
            {
                return null;
            }

            List<object> oglasi = new List<object>();
            using (var context = new CardBringerDBEntities())
            {
                var result = context.oglas
                    .Join(context.korisnik, (o => o.idKorisnik), (p => p.idKorisnika),
                        (o, p) => new {
                            o,
                            p
                        })
                    .Join(context.karta, r => r.o.idKarta, s => s.idKarta,
                        (r, s) => new {
                            s.imeKarte,
                            s.opisKarte,
                            r.o.cijena,
                            r.o.kolicina,
                            r.p.ime,
                            r.o.idOglas,
                            s.slikaKarte,
                            r.o.aktivan
                        })
                    .Where(c => c.imeKarte.Contains(pretrazivaniString) && c.aktivan == 1)
                    .ToList();

                foreach (var r in result)
                {
                    oglasi.Add(r);
                }
            }
            return oglasi;
        }
        public virtual karta karta { get; set; }
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kosharica> kosharica { get; set; }
    }
}

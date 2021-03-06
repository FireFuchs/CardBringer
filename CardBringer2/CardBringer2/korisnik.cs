//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Linq;

namespace CardBringer2
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.oglas = new HashSet<oglas>();
            this.kosharica = new HashSet<kosharica>();
            this.wishlist = new HashSet<wishlist>();
        }

        public static korisnik PrijavljeniKorisnik { get; set; }
        public int idKorisnika { get; set; }
        public string ime { get; set; }
        public string lozinka { get; set; }
        public string email { get; set; }
        public string mjestoStanovanja { get; set; }
        public int idUloga { get; set; }

        public void Odjava()
        {
            PrijavljeniKorisnik = null;
        }

        public static korisnik Prijava(string username, string password)
        {
            korisnik k;
            using (var context = new CardBringerDBEntities())
            {
                k = context.korisnik.FirstOrDefault(c => c.ime == username && c.lozinka == password);
            }
            return PrijavljeniKorisnik = k;
        }

        public korisnik Registracija()
        {
            using (var context = new CardBringerDBEntities())
            {
                var vecPostoji = context.korisnik.SingleOrDefault(c => c.ime == this.ime || c.email == this.email);
                if (vecPostoji != null) return null; 
                PrijavljeniKorisnik = context.korisnik.Add(this);
                context.SaveChanges();
                return PrijavljeniKorisnik;
            }
        }

        public static List<object> DohvatiKorisnike()
        {
            List<object> lista = new List<object>();
            using (var context = new CardBringerDBEntities())
            {
                var result = context.korisnik
                    .Join(context.uloga, (o => o.idUloga), (p => p.idUloga),
                        (o, p) => new {
                            o.idKorisnika,
                            o.ime,
                            o.email,
                            o.mjestoStanovanja,
                            p.nazivUloge,
                            o.idUloga
                     })
                    .ToList();

                foreach (var r in result)
                {
                    lista.Add(r);
                }
            }
            return lista;
        }


        public static void PromijeniUloguKorisnika(int idKorisnika, int idUloga)
        {
            korisnik k = new korisnik();
            using (var context = new CardBringerDBEntities())
            {
                k = context.korisnik.SingleOrDefault(c => c.idKorisnika == idKorisnika);
                k.idUloga = idUloga;
                context.SaveChanges();
            }
        }

        public virtual uloga uloga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<oglas> oglas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kosharica> kosharica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wishlist> wishlist { get; set; }
    }
}

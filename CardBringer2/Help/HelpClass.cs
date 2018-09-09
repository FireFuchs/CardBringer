using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public static class HelpClass
    {
        // Prilikom pokretanja, individualna forma postavlja svoj kodni broj u varijablu TrenutnaForma koja služi za identifikaciju
        // odgovarajućeg help teksta forme
        public static int TrenutnaForma = 0;
        private static readonly IDictionary<int, string> tekstoviHelpa = new Dictionary<int, string>()
        {
            {0,
                $"Nije naveden tekst helpa za ovu formu" },


            // Administracija
            {1,
                @"Administrator
                
                Administrator prozor sastoji se od dva gumba
                'Dodavanje nove karte' i 'Promjena uloga korisnika'

                Ako želite dodati novu kartu u bazu podataka,
                pritisnite gumb 'Dodavanje nove karte'.

                Ako želite nekom korisniku promijeniti kakvu ulogu
                ima u aplikaciji CardBringer, pritisnite gumb
                'promjena uloga korisnika'."},

            // Kosarica
            {2,
                @"Košarica

                Košarica je prozor u kojem vidite sve karte koje ste
                dodali u košaricu pomoću početnog prozora.

                Tablica pokazuje sve karte koje su trenutno u košarici. 
                Desno od svih karata u košarici redom se nalazi:

                Ukupna cijena: označava koliko sveukupno koštaju 
	                sve karte koje ste stavili u košaricu 
                Broj karata: označava koliko sveukupno imate karata 
	                u košarici.

                Ako želite kupiti sadržaj vaše košarice, potrebno
                je stisnuti na gumb kupi. Pritiskom na gumb kupi prikazat
                će prozor za upis vaše kartice kojom će te platiti kupovinu.
                Nakon što unesete sve potrebne podatke, pritisnite plati, i
                sadržaj vaše košarice će biti kupljen.

                Ako ne želite neku stavku u vašoj košarici. 
                Prvo odaberete stavku koju više ne želite. 
                Nakon što ste pritisnuli neželjenu stavku, pritisnite gumb 
                'Makni!'. Nakon pritiska neželjena stavka iz košarice će biti uklonjena." },

            // ListaZelja
            {3,
                @"Lista želja

                Lista želja je prozor koji se sastoji od dva dijela,
                Lijevi dio(Željene karte) i Desni dio(Sve karte).

                Lijevi dio se sastoji od dijela s pojedinostima karte i
                tablice s kartama koje su na listi želja.

                Desni dio se sastoji od tražilice, reset gumba, tablice
                svih karata i pojedinosti o odabranoj karti.

                kako bi dodali na listu želja neku kartu. potrebno je prvo odabrati
                s popisa svih karata i nakon što ste odabrali željenu kartu,
                pritisnite gumb '<--- Dodaj'. Odabrana karta će biti dodana
                na vašu listu želja.

                Ako želite maknuti kartu sa svoje liste želja, odaberite
                kartu koju više ne želite, i zatim pritisnite gumb
                '---> Makni'. Odabrana karta će biti maknuta s vaše liste želja.

                U tražilicu možemo upisati ime karte koju želimo,
                i pritiskom na tipku 'Enter' ili tipku traži
                i aplikacija će automatski filtrirati sve karte
                koje imaju ime koje ste napisali u tražilicu.

                Kako bi vratili da se sve karte opet pokazuju,
                potrebno je stisnuti gumb 'Reset' ili obrisati sve iz
                tražilice i pritisnuti gumb traži ili tipku 'Enter'." },

            // LoginRegisterForma
            {4,
                @"Login/register

                Login i Register forma se sastoji od dva dijela
                Login/Prijava dio(Gornji) i
                Register/Registriranje dio(Donji)


                Login/Prijava Dio

                Da bi se prijavili u aplikaciju potrebno
                je upisati svoje korisničko ime u
                gornje polje(korisničko ime) i zatim
                potrebno je upisati svoju lozinku u dolnje(lozinka)
                polje. Nakon upisivanje, moguće je pritisnuti tipku
                Enter ili možemo pritisnuti gumb prijava koji
                će poslati upisane podatke na server i biti
                će te prijavljeni.


                Register/Registracija dio

                Registracija se odrađuje u drugom dijelu
                Login/Register prozora. Prvo je potrebno upisati
                željenu email adresu u prvo polje. Zatim je potrebno
                upisati Željeno korisničko ime u drugo polje.
                Nakon upisivanja željenog korisničkog imena,
                potrebno je odrediti svoju željenu lozinku, i
                ispod lozinke potrebno je ponoviti svoju lozinku
                kako bi se potvrdilo da ste unijeli pravilnu lozinku.
                U posljednje polje potrebno je upisati svoje mjesto
                stanovanja kako bi se narudžba mogla obaviti.
                Nakon što ste sve još jednom pregledali, pritisnite
                tipku 'Enter' ili pritisnite gumb Register.
                Uspješno ste kreirali novi profil.


                gost pristup

                Ako ne želite napraviti novi profil, ili se
                ne želite ulogirati. Može se pristupiti pomoću
                gumba 'gost pristup' koji će vam omogućiti pristup
                aplikaciji, ali je vrlo limitiran." },

            // MojeKupnje
            {5,
                @"Moje kupnje

                Moje Kupnje je prozor u kojem možete vidjeti sve vaše
                prethodne kupovine koje ste obavili pomoću aplikacije
                CardBringer. 

                Moje kupnje prozor sastoji se samo od jedne liste koja
                sadrži sve vaše kupnje koje ste imali koristeći 
                aplikaciju."},

            // MojProfil
            {6,
                @"Moj Profil

                Moj Profil prozor je prozor u kojemu možete vidjeti vaše
                podatke i oglase koje ste vi objavili.

                ID: označava koji je vaš identifikacijski broj
                Nickname: označava vaše korisničko ime koje ste vi unijeli
                Email: označava vaš Email koji ste vi unijeli
                Adresa: označava mjesto vašeg stanovanja
                Uloga: označava što ste vi po ulozi u ovoj aplikaciji
                (Default korisnik)

                Prozor dolje lijevo pokazuje sve aktivne oglase koje
                ste vi objavili. pritiskom na bilo koji oglas pokazuje
                pojedinosti toga oglasa na desnoj strani aplikacije.

                Desno iznad svih oglasa nalazi se gumb 'Ukloni oglas'
                pritisak tog gumba će izbrisati izabrani oglas, te ako
                želite vratiti taj oglas morat će te ga ponovo napraviti." },

            // NovaKartaAdmin
            {7,
                @"Nova Karta Admin 

                Nova Karta Admin je prozor koji služi za dodavanje 
                novih karata u bazu podataka. Kako bi stavili 
                sliku za kartu, pritisnete gumb 'Izaberi sliku' 
                koji će onda od vas zatražiti da nađete na svom
                računalu sliku karte koju želite. Nakon što ste
                izabrali sliku karte, pritisnite 'OK'.

                Nakon odabira slike, Upišite ime karte u polje
                ispod gumba 'Izaberi sliku'. Nakon Upisa imena,
                napišite u polje opis karte, sve što piše u podnožju
                karte koju dodajete. Nakon što ste sve potrebne podatke
                upisali, pritisnite veliki gumb 'Spremi Kartu'. Nova
                karta će biti dodana u bazu podataka." },

            //ObjaviOglas
            {8,
                @"Objavi oglas

                Objavi oglas je prozor koji se koristi da bi stavili
                svoju kartu na prodaju.

                Lijevo možete vidjeti tablicu sa svim kartama. Odabir
                bilo koje karte će prikazati detalje te karte na desnom
                dijelu.

                Kako bi objavili oglas, potrebno je prvo odabrati kartu
                iz popisa svih karata. Nakon što ste odabrali kartu koju
                želite prodati, ispod popisa svih karata prvoj je potrebno
                upisati Cijenu karte. Zatim ispod toga potrebno je
                unijeti koliko tih karata želite prodati. Kada ste sve
                podatke ponovo provjerili, pritiskom na tipku 'Enter'
                ili na gumb 'Objavi oglas' možete objaviti svoj oglas
                o karti koju ste odabrali." },

            // Pocetna
            {9,
                @"Početna

                Početna stranica je prva stranica koja se pojavi
                nakon prijave u aplikaciju. Najveći prozor koji
                možemo vidjeti je popis svih oglasa koji su trenutno
                aktivni. Desno iznad svih oglasa nalazi se tražilica.

                U tražilicu možemo upisati ime karte koju želimo,
                i pritiskom na tipku 'Enter' ili tipku traži
                i aplikacija će automatski filtrirati sve oglase
                koji sadrže tu kartu koju ste napisali u tražilicu.

                Kako bi vratili da se svi oglasi opet pokazuju,
                potrebno je stisnuti gumb 'Reset' ili obrisati sve iz
                tražilice i pritisnuti gumb traži ili tipku 'Enter'.

                Desno od svih oglasa nalazi se dio za dodavanje u
                košaricu. Kako bi dodali neki oglas u košaricu, potrebno
                je prvotno odabrati oglas u popisu oglasa. Nakon odabira
                skroz desno se pokazuju pojedinosti oglasa (slika karte,
                ime karte, cijena karte, količina karata, tko prodaje kartu
                i opis karte). Kada smo odabrali koji oglas želimo,
                u polje 'Broj karata: ' upisujemo koliko karata iz toga
                oglasa želimo dodati u košaricu(default 1). Nakon upisa
                željenih karata, pritiskom na tipku 'Enter' ili na gumb
                'U Košaricu' možete dodati taj oglas u Vašu košaricu." },

            // PromjenaUlogeKorisnika
            {10,
                @"Promjena Uloge Korisnika

                Prozor promjena uloge korisnika sadrži tablicu svih
                korisnika koji su trenutno u bazi podataka.

                Ako nekom korisniku želimo dati administrativna
                prava, potrebno je prvo toga korisnika odabrati.
                Nakon što smo odabrali tog korisnika,
                pritisnemo gumb 'Daj administratorske privilegije'.
                Odabrani korisnik će biti promoviran u administratora
                u aplikaciji CardBringer.

                Ako nekom korisniku želimo oduzeti administratorska
                prava. Odaberemo korisnika iz tablice kojem želimo
                oduzeti prava. Nakon što smo odabrali tog korisnika,
                pritisnemo gumb 'makni administratorske privilegije'.
                Odabrani korisnik više neće biti administrator u
                aplikaciji CardBringer." }
        };


        public static string DohvatiHelpTekst()
        {
            return tekstoviHelpa[TrenutnaForma];
        }
    }
}

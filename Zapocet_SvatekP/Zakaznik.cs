using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zapocet_SvatekP
{
    [Serializable()]
    public class Zakaznik : INotifyPropertyChanged
    {
        private string _jmeno;
        private string _prijmeni;
        private int _rokNarozeni;
        private string _email;
        private string _telCislo;

        public string Jmeno
        {
            get { return _jmeno; }
            set
            {
                if (_jmeno != value)
                {
                    _jmeno = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Prijmeni
        {
            get { return _prijmeni; }
            set
            {
                if (_prijmeni != value)
                {
                    _prijmeni = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int RokNarozeni
        {
            get { return _rokNarozeni; }
            set
            {
                if (_rokNarozeni != value)
                {
                    _rokNarozeni = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TelCislo
        {
            get { return _telCislo; }
            set
            {
                if (_telCislo != value)
                {
                    _telCislo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BindingList<Termin> Rezervovane { get; private set; } = new BindingList<Termin>();

        public Zakaznik(string jmeno, string prijmeni, int rokNarozeni, string email, string telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
            Email = email;
            TelCislo = telCislo;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace PlatosComida
{
    public class Plato : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }

        private string _imagen;
        public string Imagen
        {
            get { return _imagen; }
            set
            {
                _imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                _tipo = value;
                NotifyPropertyChanged("Tipo");
            }
        }

        private bool _gluten;
        public bool Gluten
        {
            get { return _gluten; }
            set
            {
                _gluten = value;
                NotifyPropertyChanged("Gluten");
            }
        }

        private bool _soja;
        public bool Soja
        {
            get { return _soja; }
            set
            {
                _soja = value;
                NotifyPropertyChanged("Soja");
            }
        }

        private bool _leche;
        public bool Leche
        {
            get { return _leche; }
            set
            {
                _leche = value;
                NotifyPropertyChanged("Leche");
            }
        }

        private bool _sulfitos;
        public bool Sulfitos
        {
            get { return _sulfitos; }
            set
            {
                _sulfitos = value;
                NotifyPropertyChanged("Sulfitos");
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}



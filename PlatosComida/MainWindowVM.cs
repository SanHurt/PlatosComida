using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatosComida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Plato _platoActual;
        private ObservableCollection<Plato> _platos;
        private List<string> _tipos;
        public List<string> Tipos
        {
            get { return _tipos; }
            set
            {
                _tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }
        public ObservableCollection<Plato> Platos
        {
            get { return _platos; }
            set
            {
                _platos = value;
                NotifyPropertyChanged("Platos");
            }
        }
        public MainWindowVM()
        {
            _platos = 
            Plato.GetSamples(@"E:\DAM\2DAM\DINT\T5\ACTIVIDADES\Actividades1\Imagenes");

            PlatoActual = _platos.FirstOrDefault();
            _tipos = new List<string> {"Mexicana" , "Americana", "China" };

        }

        
        public Plato PlatoActual
        {
            get { return _platoActual; }
            set
            {
                _platoActual = value;
                NotifyPropertyChanged("PlatoActual");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void LimpiarPlato()
        {
            PlatoActual = null;
        }
    }

    
}

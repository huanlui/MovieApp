using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Annotations;

namespace MovieApp.Pages
{
    public class MovieDetailModel : INotifyPropertyChanged
    {
        private string _title;
        private string _description;
        private string _image_path;

        public MovieDetailModel()
        {
            _title = "Titanic";
            _description = "Es un peliculón, pero lo malo es que al final se hunden. Yo los habría dejado sobrevivir, o al menos que se hundiera ella.";
            _image_path = "C:\\Proyectos\\Formacion\\IOC\\MovieApp\\Pelis\\Titanic\\Imagen.jpg";
        }

        public String Title
        {
            get { return _title; }
            set
            {
                if (value == _title) return;
                _title = value;
                OnPropertyChanged();
            }
        }

        public String Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public String ImagePath
        {
            get { return _image_path; }
            set
            {
                if (value == _image_path) return;
                _image_path = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string property_name = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(property_name));
        }
    }
}

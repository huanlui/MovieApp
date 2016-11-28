using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppApi.Fixtures
{
    public class ShowImage
    {
        public bool ShowImageForMovie(String movie_title)
        {
          //  IEnglishToImagePathTranslator translator = AppEngine.Container.EnglishToImagePathTranslator;

         //   String file_url = translator.Translate(english_word);
            String file_url = String.Format(@"C:\Proyectos\Formacion\IOC\MovieApp\Pelis\{0}\Imagen.jpg", movie_title);
            String source_file_path = SaveToTempFileAndGetPath(movie_title, file_url);
            String source_file_name = Path.GetFileName(source_file_path);

            var dest_file_name = Path.Combine(@".\FitNesseRoot\files\fitnesse\images\fixture_temps", source_file_name);
            File.Copy(source_file_path,
                    dest_file_name,
                    overwrite: true);

            return true;
        }

        private string SaveToTempFileAndGetPath(string movie_title, string thumbnail_url)
        {
            WebClient webClient = new WebClient();
            String local_path = Path.Combine(Path.GetTempPath(), String.Format("{0}.jpg", movie_title.Replace(" ","_")));
            webClient.DownloadFile(thumbnail_url, local_path);
            return local_path;
        }
    }
}

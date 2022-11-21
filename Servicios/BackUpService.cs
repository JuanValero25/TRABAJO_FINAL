using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Servicios
{
    public class BackUpService
    {
        string startPath = @".\xmlDB\";
        string zipPath = @".\dbresult.zip";
        public void CreateBackup()
        {

            if (File.Exists("dbresult.zip"))
            {
                File.Delete("dbresult.zip");
            }

            ZipFile.CreateFromDirectory(startPath, zipPath);

            MessageBox.Show("Backup Creado porfavor buscarlo en el root del projecto como dbresult.zip");
        }

        public void RestereBackup(string fileDir)
        {


            if (Directory.Exists("./xmlDB/"))
            {
                Directory.Delete("./xmlDB/", true);
                Directory.CreateDirectory("./xmlDB/");
            }

            ZipFile.ExtractToDirectory(fileDir, startPath);
            MessageBox.Show("restore completado");
        }

    }
}

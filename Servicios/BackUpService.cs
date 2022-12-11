using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Servicios
{
    public class BackUpService
    {
        string startPath = @".\xmlDB\";
        string zipPath = @".\dbresult.zip";

        BitacoraXMLMPP bitcacoraMapper = new BitacoraXMLMPP();
        public void CreateBackup()
        {

            if (File.Exists("dbresult.zip"))
            {
                File.Delete("dbresult.zip");
            }
            var bitacora = new Bitacora();
            bitacora.ID = bitacora.generateID();
            bitacora.Operacion = "BACKUP";
            bitacora.fechaOperacion = DateTime.Now;
            bitcacoraMapper.Save(bitacora);
            ZipFile.CreateFromDirectory(startPath, zipPath);

            MessageBox.Show("Backup Creado porfavor buscarlo en el root del projecto como dbresult.zip");
        }

        public void RestoreBackup(string fileDir)
        {


          var bitacoras =  bitcacoraMapper.GetAll();
            var bitacora = new Bitacora();
            bitacora.ID = bitacora.generateID();
            bitacora.Operacion = "RESTORE";
            bitacora.fechaOperacion = DateTime.Now;
            bitacoras.Add(bitacora);

            if (Directory.Exists("./xmlDB/"))
            {
                Directory.Delete("./xmlDB/", true);
                Directory.CreateDirectory("./xmlDB/");
            }

            ZipFile.ExtractToDirectory(fileDir, startPath);

            if (File.Exists("./xmlDB/Bitacora.xml"))
            {
                File.Delete("./xmlDB/Bitacora.xml");
            }

            foreach (var bita in bitacoras) {
                bitcacoraMapper.Save(bita);
            }


            MessageBox.Show("restore completado");
        }

        public List<Bitacora> GetAll() {

            return bitcacoraMapper.GetAll();
        }

    }
}

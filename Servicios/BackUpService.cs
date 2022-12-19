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

            Dictionary<string, Bitacora> bitacoraMap = new Dictionary<string, Bitacora>();

          var bitacoras =  bitcacoraMapper.GetAll();
            var bitacora = new Bitacora();
            bitacora.ID = bitacora.generateID();
            bitacora.Operacion = "RESTORE";
            bitacora.fechaOperacion = DateTime.Now;
            bitacoras.Add(bitacora);

            foreach (var oldBitacora in bitacoras) {
                bitacoraMap.Add(oldBitacora.ID, oldBitacora);
            }


            if (Directory.Exists("./xmlDB/"))
            {
                Directory.Delete("./xmlDB/", true);
                Directory.CreateDirectory("./xmlDB/");
            }

            ZipFile.ExtractToDirectory(fileDir, startPath);

            var bitacoras2 = bitcacoraMapper.GetAll();

            foreach (var oldBitacora in bitacoras2)
            {
                if (!bitacoraMap.ContainsKey(oldBitacora.ID)) {
                    bitacoraMap.Add(oldBitacora.ID, oldBitacora);
                }
            }

            if (File.Exists("./xmlDB/Bitacora.xml"))
            {
                File.Delete("./xmlDB/Bitacora.xml");
            }

            foreach (var bita in bitacoraMap) {
                bitcacoraMapper.Save(bita.Value);
            }


            MessageBox.Show("restore completado");
        }

        public List<Bitacora> GetAll() {

            return bitcacoraMapper.GetAll();
        }

    }
}

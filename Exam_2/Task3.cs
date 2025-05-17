using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2.Var00
{
    public class Task3 : ITask3
    {
        private string _folderPath;
        private string _filePath;
        public string FolderPath => _folderPath;
        public string FilePath => _filePath;

        public Task3(string fileName)
        {
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _filePath = Path.Combine(FolderPath, fileName);

            string textToWrite = DateTime.Now.ToString();
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(_filePath, textToWrite);
            }
            else
            {
                File.AppendAllText(_filePath, Environment.NewLine + textToWrite);
            }
        }

        public void Clear()
        {
            if (_filePath == null) return;
            
            File.WriteAllText(FilePath, string.Empty);
        }

        public void Copy(string newPath)
        {
            if (_filePath == null || newPath == null) return;
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            string fileName = Path.GetFileName(FilePath);
            string newFilePath = Path.Combine(newPath, fileName);
            
            File.Copy(FilePath, newFilePath, overwrite: true);
        }
    }
}
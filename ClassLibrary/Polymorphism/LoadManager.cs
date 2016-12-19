using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary.Polymorphism
{
    public class LoadManager
    {
        private IList<Files> files = new List<Files>();

        public IList<Files> Files
        {
            get { return files; }
        }

        public void LoadFiles(Files file)
        {
            files.Add(file);
        }

        public void OpenAllFiles()
        {
            foreach (IFileOpen file in Files)
            {
                file.Open(); ;
            }
        }

        public void OpenFile(IFileOpen file)
        {
            file.Open();
        }

        public FileType GetFileType(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            return (FileType)Enum.Parse(typeof(FileType), fi.Extension);
        }

    }
}

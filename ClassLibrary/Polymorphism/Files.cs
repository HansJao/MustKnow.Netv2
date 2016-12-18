namespace ClassLibrary.Polymorphism
{
    public abstract class Files:IFileOpen
    {
        private FileType fileType = FileType.doc;
        public abstract void Open();

    }

    public abstract class DocFile : Files
    {
        public int GetPageCount()
        {
            return 1;
        }

    }
    public abstract class ImgeFile : Files
    {
        public void ZoomIn()
        {
           
        }
        public void ZoomOut()
        {

        }
    }

    public enum FileType
    {
        doc,pdf,txt,ppt,jpg,gif,mp3,avi
    }
}

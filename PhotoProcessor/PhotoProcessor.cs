using System;

namespace Delegates
{
    public class PhotoProcessorDll
    {
        public void ProcessDll(string path, Action<PhotoDll> filterhandler)
        {
            var photo = PhotoDll.Load(path);
            filterhandler(photo);
            photo.Save();
        }
    }
}

using System;

namespace Delegates
{
    // Done: create a new dll project from photo, photofiilters and photoprocessor
    // and expand the filter. works fine
    //
    public class PhotoProcessorWithAction
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);
            photo.Save();
        }
    }
}

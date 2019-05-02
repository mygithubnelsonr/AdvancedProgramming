using System;

namespace Deligates
{
    public class PhotoProcessor
    {
        // public delegate void PhotoFilterHandler(Photo photo);

        // there are two system deligates we can use instate of crreate our own
        //System.Action<>
        //System.Func<>


        public void Process(string path, Action<Photo> filterhandler)
        {
            var photo = Photo.Load(path);

            //var filter = new PhotoFilters();
            //filter.ApplyBrighttness(photo);
            //filter.ApplyContrast(photo);
            //filter.Resize(photo);

            filterhandler(photo);
            photo.Save();
        }
    }
}

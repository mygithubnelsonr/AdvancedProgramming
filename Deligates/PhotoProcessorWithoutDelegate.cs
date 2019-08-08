namespace Delegates
{
    public class PhotoProcessorWithoutDelegate
    {
        // this is a method like it usaly look like
        // so it is not extensible
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filter = new PhotoFilters();

            filter.ApplyBrightness(photo);
            filter.ApplyContrast(photo);
            filter.Resize(photo);

            photo.Save();
        }
    }
}

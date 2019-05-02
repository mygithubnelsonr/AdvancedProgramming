using System;

namespace Deligates
{
    // Done: create a new dll project from photo, photofiilters and photoprocessor
    // and expand the filter. works fine
    //

    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            // replaced with system.action
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            filterHandler += ToGrayFilter;

            processor.Process("photo.jpg", filterHandler);

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEyes");
        }

        static void ToGrayFilter(Photo photo)
        {
            Console.WriteLine("Apply change to Gray filter");
        }

    }
}

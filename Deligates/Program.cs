using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingPhotoProcessorWithoutDelegates();

            UsingPhotoProcessorWithDelegates();

            UsingPhotoProcessorWithAction();

            UsingPhotoProcessorWithDll();

#if DEBUG
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
#endif
        }

        private static void UsingPhotoProcessorWithoutDelegates()
        {
            Console.WriteLine("UsingPhotoProcessorWithoutDelegates:");
            var processor = new PhotoProcessorWithoutDelegate();
            processor.Process("photo.jpg");
        }

        private static void UsingPhotoProcessorWithDelegates()
        {
            Console.WriteLine("UsingPhotoProcessorWithDelegates:");
            var processor = new PhotoProcessorWithDelegate();
            var filters = new PhotoFilters();

            PhotoProcessorWithDelegate.PhotoFilterHandler filterHandler;
            filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;
            filterHandler += ToGrayFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        private static void UsingPhotoProcessorWithAction()
        {
            // using Syste.Action for void, System.Func for methods returning a value
            Console.WriteLine("UsingPhotoProcessorWithAction:");

            var processor = new PhotoProcessorWithAction();
            var filters = new PhotoFilters();

            // replaced deligate with system.action
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            filterHandler += ToGrayFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        private static void UsingPhotoProcessorWithDll()
        {
            Console.WriteLine("UsingPhotoProcessorWithDll:");

            var processor = new PhotoProcessorDll();
            var filters = new PhotoFiltersDll();

            Action<PhotoDll> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilterDll;
            filterHandler += ToGrayFilterDll;

            processor.ProcessDll("photo.jpg", filterHandler);
        }

        // additional filters
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEyes");
        }

        static void ToGrayFilter(Photo photo)
        {
            Console.WriteLine("Apply change to Gray filter");
        }

        // additional photo filters for dll version
        static void RemoveRedEyeFilterDll(PhotoDll photo)
        {
            Console.WriteLine("Apply RemoveRedEyes");
        }
        static void ToGrayFilterDll(PhotoDll photo)
        {
            Console.WriteLine("Apply change to Gray filter");
        }
    }
}

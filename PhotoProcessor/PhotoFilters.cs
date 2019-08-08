using System;

namespace Delegates
{
    public class PhotoFiltersDll
    {
        public void ApplyBrightness(PhotoDll photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(PhotoDll photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(PhotoDll photo)
        {
            Console.WriteLine("Resize phhoto");
        }
    }
}

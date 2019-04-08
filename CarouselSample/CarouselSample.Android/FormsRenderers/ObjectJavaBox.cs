namespace CarouselSample.Droid.Forms_Renderers
{
    internal class MyObjectJavaBox<T> : Java.Lang.Object
    {
        public MyObjectJavaBox(T instance)
        {
            Instance = instance;
        }

        public T Instance { get; set; }
    }
}
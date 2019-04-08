package md514cb70e9ceded3c4e00f4cf68e4bde48;


public class CustomCarouselPageRenderer
	extends md5c39980c71d9cdfdd08461dc2a1e42517.MyCarouselPageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CarouselSample.Droid.Renderers.CustomCarouselPageRenderer, CarouselSample.Android", CustomCarouselPageRenderer.class, __md_methods);
	}


	public CustomCarouselPageRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomCarouselPageRenderer.class)
			mono.android.TypeManager.Activate ("CarouselSample.Droid.Renderers.CustomCarouselPageRenderer, CarouselSample.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomCarouselPageRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomCarouselPageRenderer.class)
			mono.android.TypeManager.Activate ("CarouselSample.Droid.Renderers.CustomCarouselPageRenderer, CarouselSample.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomCarouselPageRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomCarouselPageRenderer.class)
			mono.android.TypeManager.Activate ("CarouselSample.Droid.Renderers.CustomCarouselPageRenderer, CarouselSample.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

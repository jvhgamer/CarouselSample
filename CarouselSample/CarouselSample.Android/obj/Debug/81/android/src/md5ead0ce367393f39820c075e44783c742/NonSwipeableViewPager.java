package md5ead0ce367393f39820c075e44783c742;


public class NonSwipeableViewPager
	extends android.support.v4.view.ViewPager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_executeKeyEvent:(Landroid/view/KeyEvent;)Z:GetExecuteKeyEvent_Landroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("CarouselSample.Droid.Class.NonSwipeableViewPager, CarouselSample.Android", NonSwipeableViewPager.class, __md_methods);
	}


	public NonSwipeableViewPager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == NonSwipeableViewPager.class)
			mono.android.TypeManager.Activate ("CarouselSample.Droid.Class.NonSwipeableViewPager, CarouselSample.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public NonSwipeableViewPager (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == NonSwipeableViewPager.class)
			mono.android.TypeManager.Activate ("CarouselSample.Droid.Class.NonSwipeableViewPager, CarouselSample.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public boolean onInterceptTouchEvent (android.view.MotionEvent p0)
	{
		return n_onInterceptTouchEvent (p0);
	}

	private native boolean n_onInterceptTouchEvent (android.view.MotionEvent p0);


	public boolean executeKeyEvent (android.view.KeyEvent p0)
	{
		return n_executeKeyEvent (p0);
	}

	private native boolean n_executeKeyEvent (android.view.KeyEvent p0);

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

using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;

namespace CarouselSample.Droid.Class
{
    public class NonSwipeableViewPager : ViewPager
    {
        public NonSwipeableViewPager(Context context) : base(context)
        {

        }

        public NonSwipeableViewPager(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {

        }

        public NonSwipeableViewPager(Context context, IAttributeSet attrs) : base(context, attrs)
        {

        }


        public override bool OnTouchEvent(MotionEvent e)
        {
            return false;
        }

        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            return false;
        }

        public override bool ExecuteKeyEvent(KeyEvent ev)
        {
            return false;
        }
    }
}
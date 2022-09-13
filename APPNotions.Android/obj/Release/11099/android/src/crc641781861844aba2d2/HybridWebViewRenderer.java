package crc641781861844aba2d2;


public class HybridWebViewRenderer
	extends crc643f46942d9dd1fff9.WebViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("APPNotions.Droid.Renderers.HybridWebViewRenderer, APPNotions.Android", HybridWebViewRenderer.class, __md_methods);
	}


	public HybridWebViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == HybridWebViewRenderer.class)
			mono.android.TypeManager.Activate ("APPNotions.Droid.Renderers.HybridWebViewRenderer, APPNotions.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public HybridWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == HybridWebViewRenderer.class)
			mono.android.TypeManager.Activate ("APPNotions.Droid.Renderers.HybridWebViewRenderer, APPNotions.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public HybridWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == HybridWebViewRenderer.class)
			mono.android.TypeManager.Activate ("APPNotions.Droid.Renderers.HybridWebViewRenderer, APPNotions.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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

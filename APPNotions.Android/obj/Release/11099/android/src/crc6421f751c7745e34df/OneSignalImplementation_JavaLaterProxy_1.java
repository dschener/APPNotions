package crc6421f751c7745e34df;


public class OneSignalImplementation_JavaLaterProxy_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.OneSignal.OneSignalImplementation+JavaLaterProxy`1, Com.OneSignal", OneSignalImplementation_JavaLaterProxy_1.class, __md_methods);
	}


	public OneSignalImplementation_JavaLaterProxy_1 ()
	{
		super ();
		if (getClass () == OneSignalImplementation_JavaLaterProxy_1.class)
			mono.android.TypeManager.Activate ("Com.OneSignal.OneSignalImplementation+JavaLaterProxy`1, Com.OneSignal", "", this, new java.lang.Object[] {  });
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

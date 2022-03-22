package crc6421f751c7745e34df;


public class OneSignalImplementation_OSPermissionObserver
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OSPermissionObserver
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOSPermissionChanged:(Lcom/onesignal/OSPermissionStateChanges;)V:GetOnOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_Handler:Com.OneSignal.Android.IOSPermissionObserverInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.OneSignal.OneSignalImplementation+OSPermissionObserver, Com.OneSignal", OneSignalImplementation_OSPermissionObserver.class, __md_methods);
	}


	public OneSignalImplementation_OSPermissionObserver ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSPermissionObserver.class)
			mono.android.TypeManager.Activate ("Com.OneSignal.OneSignalImplementation+OSPermissionObserver, Com.OneSignal", "", this, new java.lang.Object[] {  });
	}


	public void onOSPermissionChanged (com.onesignal.OSPermissionStateChanges p0)
	{
		n_onOSPermissionChanged (p0);
	}

	private native void n_onOSPermissionChanged (com.onesignal.OSPermissionStateChanges p0);

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

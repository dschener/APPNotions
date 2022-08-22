package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSGetTagsHandler
	extends crc6464e9980dccb00d43.OneSignalImplementation_JavaLaterProxy_1
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.OSGetTagsHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_tagsAvailable:(Lorg/json/JSONObject;)V:GetTagsAvailable_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSGetTagsHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSGetTagsHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSGetTagsHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSGetTagsHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSGetTagsHandler.class)
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSGetTagsHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
	}


	public void tagsAvailable (org.json.JSONObject p0)
	{
		n_tagsAvailable (p0);
	}

	private native void n_tagsAvailable (org.json.JSONObject p0);

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

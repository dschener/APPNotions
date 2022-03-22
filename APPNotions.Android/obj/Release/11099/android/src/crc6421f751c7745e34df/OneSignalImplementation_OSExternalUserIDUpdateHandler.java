package crc6421f751c7745e34df;


public class OneSignalImplementation_OSExternalUserIDUpdateHandler
	extends crc6421f751c7745e34df.OneSignalImplementation_JavaLaterProxy_1
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.OSExternalUserIdUpdateCompletionHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lcom/onesignal/OneSignal$ExternalIdError;)V:GetOnFailure_Lcom_onesignal_OneSignal_ExternalIdError_Handler:Com.OneSignal.Android.OneSignal/IOSExternalUserIdUpdateCompletionHandlerInvoker, OneSignal.Android.Binding\n" +
			"n_onSuccess:(Lorg/json/JSONObject;)V:GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSExternalUserIdUpdateCompletionHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.OneSignal.OneSignalImplementation+OSExternalUserIDUpdateHandler, Com.OneSignal", OneSignalImplementation_OSExternalUserIDUpdateHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSExternalUserIDUpdateHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSExternalUserIDUpdateHandler.class)
			mono.android.TypeManager.Activate ("Com.OneSignal.OneSignalImplementation+OSExternalUserIDUpdateHandler, Com.OneSignal", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (com.onesignal.OneSignal.ExternalIdError p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (com.onesignal.OneSignal.ExternalIdError p0);


	public void onSuccess (org.json.JSONObject p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (org.json.JSONObject p0);

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

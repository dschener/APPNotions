package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSSMSUpdateHandler
	extends crc6464e9980dccb00d43.OneSignalImplementation_JavaLaterProxy_1
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.OSSMSUpdateHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lcom/onesignal/OneSignal$OSSMSUpdateError;)V:GetOnFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_Handler:Com.OneSignal.Android.OneSignal/IOSSMSUpdateHandlerInvoker, OneSignal.Android.Binding\n" +
			"n_onSuccess:(Lorg/json/JSONObject;)V:GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSSMSUpdateHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSSMSUpdateHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSSMSUpdateHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSSMSUpdateHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSSMSUpdateHandler.class)
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSSMSUpdateHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (com.onesignal.OneSignal.OSSMSUpdateError p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (com.onesignal.OneSignal.OSSMSUpdateError p0);


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

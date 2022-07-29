package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSInAppMessageLifeCycleHandler
	extends com.onesignal.OSInAppMessageLifecycleHandler
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWillDisplayInAppMessage:(Lcom/onesignal/OSInAppMessage;)V:GetOnWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler\n" +
			"n_onDidDisplayInAppMessage:(Lcom/onesignal/OSInAppMessage;)V:GetOnDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler\n" +
			"n_onWillDismissInAppMessage:(Lcom/onesignal/OSInAppMessage;)V:GetOnWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler\n" +
			"n_onDidDismissInAppMessage:(Lcom/onesignal/OSInAppMessage;)V:GetOnDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSInAppMessageLifeCycleHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSInAppMessageLifeCycleHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSInAppMessageLifeCycleHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSInAppMessageLifeCycleHandler.class)
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSInAppMessageLifeCycleHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
	}


	public void onWillDisplayInAppMessage (com.onesignal.OSInAppMessage p0)
	{
		n_onWillDisplayInAppMessage (p0);
	}

	private native void n_onWillDisplayInAppMessage (com.onesignal.OSInAppMessage p0);


	public void onDidDisplayInAppMessage (com.onesignal.OSInAppMessage p0)
	{
		n_onDidDisplayInAppMessage (p0);
	}

	private native void n_onDidDisplayInAppMessage (com.onesignal.OSInAppMessage p0);


	public void onWillDismissInAppMessage (com.onesignal.OSInAppMessage p0)
	{
		n_onWillDismissInAppMessage (p0);
	}

	private native void n_onWillDismissInAppMessage (com.onesignal.OSInAppMessage p0);


	public void onDidDismissInAppMessage (com.onesignal.OSInAppMessage p0)
	{
		n_onDidDismissInAppMessage (p0);
	}

	private native void n_onDidDismissInAppMessage (com.onesignal.OSInAppMessage p0);

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

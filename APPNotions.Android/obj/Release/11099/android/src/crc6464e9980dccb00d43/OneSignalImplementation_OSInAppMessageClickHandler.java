package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSInAppMessageClickHandler
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.OSInAppMessageClickHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_inAppMessageClicked:(Lcom/onesignal/OSInAppMessageAction;)V:GetInAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_Handler:Com.OneSignal.Android.OneSignal/IOSInAppMessageClickHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSInAppMessageClickHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSInAppMessageClickHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSInAppMessageClickHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSInAppMessageClickHandler.class)
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSInAppMessageClickHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
	}


	public void inAppMessageClicked (com.onesignal.OSInAppMessageAction p0)
	{
		n_inAppMessageClicked (p0);
	}

	private native void n_inAppMessageClicked (com.onesignal.OSInAppMessageAction p0);

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

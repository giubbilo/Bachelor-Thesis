package md53ae5da072f0c36446c4221842ee3d946;


public class ViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("UNIVPM.Resources.ViewHolder, UNIVPM", ViewHolder.class, __md_methods);
	}


	public ViewHolder ()
	{
		super ();
		if (getClass () == ViewHolder.class)
			mono.android.TypeManager.Activate ("UNIVPM.Resources.ViewHolder, UNIVPM", "", this, new java.lang.Object[] {  });
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

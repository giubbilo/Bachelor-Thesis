package md59c6e42a47ebff12a262d0a9599d5b4b0;


public class ImageSliderMed
	extends android.support.v4.view.PagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_isViewFromObject:(Landroid/view/View;Ljava/lang/Object;)Z:GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler\n" +
			"n_instantiateItem:(Landroid/view/View;I)Ljava/lang/Object;:GetInstantiateItem_Landroid_view_View_IHandler\n" +
			"n_destroyItem:(Landroid/view/View;ILjava/lang/Object;)V:GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("UNIVPM.ImageSliderMed, UNIVPM", ImageSliderMed.class, __md_methods);
	}


	public ImageSliderMed ()
	{
		super ();
		if (getClass () == ImageSliderMed.class)
			mono.android.TypeManager.Activate ("UNIVPM.ImageSliderMed, UNIVPM", "", this, new java.lang.Object[] {  });
	}

	public ImageSliderMed (android.content.Context p0)
	{
		super ();
		if (getClass () == ImageSliderMed.class)
			mono.android.TypeManager.Activate ("UNIVPM.ImageSliderMed, UNIVPM", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public boolean isViewFromObject (android.view.View p0, java.lang.Object p1)
	{
		return n_isViewFromObject (p0, p1);
	}

	private native boolean n_isViewFromObject (android.view.View p0, java.lang.Object p1);


	public java.lang.Object instantiateItem (android.view.View p0, int p1)
	{
		return n_instantiateItem (p0, p1);
	}

	private native java.lang.Object n_instantiateItem (android.view.View p0, int p1);


	public void destroyItem (android.view.View p0, int p1, java.lang.Object p2)
	{
		n_destroyItem (p0, p1, p2);
	}

	private native void n_destroyItem (android.view.View p0, int p1, java.lang.Object p2);

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

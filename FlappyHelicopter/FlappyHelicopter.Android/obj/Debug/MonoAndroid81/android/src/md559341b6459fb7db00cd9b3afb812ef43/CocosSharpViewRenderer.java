package md559341b6459fb7db00cd9b3afb812ef43;


public class CocosSharpViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CocosSharp.CocosSharpViewRenderer, CocosSharp.Forms", CocosSharpViewRenderer.class, __md_methods);
	}


	public CocosSharpViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CocosSharpViewRenderer.class)
			mono.android.TypeManager.Activate ("CocosSharp.CocosSharpViewRenderer, CocosSharp.Forms", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CocosSharpViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CocosSharpViewRenderer.class)
			mono.android.TypeManager.Activate ("CocosSharp.CocosSharpViewRenderer, CocosSharp.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CocosSharpViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CocosSharpViewRenderer.class)
			mono.android.TypeManager.Activate ("CocosSharp.CocosSharpViewRenderer, CocosSharp.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
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

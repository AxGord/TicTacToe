
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class LoadScreen : global::pony.unity3d.ui.ucore.LoadScreenUCore 
	{
		static LoadScreen() 
		{
			#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/LoadScreen.hx"
			global::pony.unity3d.ui.LoadScreen.lastLoader = default(global::pony.Loader);
		}
		public    LoadScreen(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    LoadScreen() : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  global::pony.Loader lastLoader;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/LoadScreen.hx"
				return new global::pony.unity3d.ui.LoadScreen(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/LoadScreen.hx"
				return new global::pony.unity3d.ui.LoadScreen();
			}
			#line default
		}
		
		
	}
}



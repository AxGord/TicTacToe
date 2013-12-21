
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  interface IKeyboard<T> : global::haxe.lang.IHxObject, global::pony.ui.IKeyboard 
	{
		   void enable();
		
		   void disable();
		
	}
	public class IKeyboard__Statics_
	{
		public static   object __hx_cast<T_c_c>(global::pony.ui.IKeyboard me)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/IKeyboard.hx"
				return ( (( me != default(global::pony.ui.IKeyboard) )) ? (me.pony_ui_IKeyboard_cast<T_c_c>()) : (default(global::pony.ui.IKeyboard)) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  interface IKeyboard : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object pony_ui_IKeyboard_cast<T_c>();
		
	}
}




#pragma warning disable 109, 114, 219, 429, 168, 162
public  class UI : global::haxe.lang.HxObject, global::pony.magic.StaticInit 
{
	public    UI(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 12 "src/UI.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    UI()
	{
		unchecked 
		{
			#line 12 "src/UI.hx"
			global::UI.__hx_ctor__UI(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__UI(global::UI __temp_me16)
	{
		unchecked 
		{
			#line 12 "src/UI.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static  global::UnityEngine.GameObject mainMenu;
	
	public static  global::UnityEngine.GameObject endText;
	
	public static  global::pony.ui.ButtonCore bGame;
	
	public static  global::pony.ui.ButtonCore bMenu;
	
	public static  global::pony.ui.ButtonCore bReturn;
	
	public static  global::pony.ui.ButtonCore bExit;
	
	public static  global::pony.ui.ButtonCore bRandom;
	
	public static  global::Array<object> bS;
	
	public static   void initStatic()
	{
		unchecked 
		{
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.mainMenu = global::UnityEngine.GameObject.Find("/UI/MainMenu");
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.endText = global::UnityEngine.GameObject.Find("/UI/EndText");
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.bGame = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bGame"), typeof(global::pony.unity3d.ui.Button))) ).core;
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.bMenu = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/bMenu"), typeof(global::pony.unity3d.ui.Button))) ).core;
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.bReturn = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bReturn"), typeof(global::pony.unity3d.ui.Button))) ).core;
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.bExit = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bExit"), typeof(global::pony.unity3d.ui.Button))) ).core;
			#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			global::UI.bRandom = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bRandom"), typeof(global::pony.unity3d.ui.Button))) ).core;
			#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			{
				#line 24 "src/UI.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{});
				#line 24 "src/UI.hx"
				{
					#line 24 "src/UI.hx"
					int _g1 = 1;
					#line 24 "src/UI.hx"
					while (( _g1 < 4 ))
					{
						#line 24 "src/UI.hx"
						int i = _g1++;
						#line 24 "src/UI.hx"
						_g.push(((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(global::haxe.lang.Runtime.concat("/UI/MainMenu/bS", global::haxe.lang.Runtime.toString(i))), typeof(global::pony.unity3d.ui.Button))) ).core);
					}
					
				}
				
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				global::UI.bS = _g;
			}
			
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 12 "src/UI.hx"
			return new global::UI(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 12 "src/UI.hx"
			return new global::UI();
		}
		#line default
	}
	
	
}




#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Scene : global::haxe.lang.HxObject, global::pony.magic.StaticInit 
{
	public    Scene(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 12 "src/Scene.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    Scene()
	{
		unchecked 
		{
			#line 12 "src/Scene.hx"
			global::Scene.__hx_ctor__Scene(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__Scene(global::Scene __temp_me10)
	{
		unchecked 
		{
			#line 12 "src/Scene.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static  global::Array<object> points;
	
	public static  global::haxe.ds.EnumValueMap<global::Player, object> players;
	
	public static   void initStatic()
	{
		unchecked 
		{
			#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			{
				#line 14 "src/Scene.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{});
				#line 14 "src/Scene.hx"
				{
					#line 14 "src/Scene.hx"
					int _g1 = 0;
					#line 14 "src/Scene.hx"
					while (( _g1 < 27 ))
					{
						#line 14 "src/Scene.hx"
						int i = _g1++;
						#line 14 "src/Scene.hx"
						_g.push(((global::PlacePoint) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(global::haxe.lang.Runtime.concat("/Points/", global::haxe.lang.Runtime.toString(i))), typeof(global::PlacePoint))) ));
					}
					
				}
				
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				global::Scene.points = _g;
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				global::haxe.ds.EnumValueMap<global::Player, object> _g11 = new global::haxe.ds.EnumValueMap<global::Player, object>();
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				_g11.@set(global::Player.X, global::UnityEngine.GameObject.Find("/Players/X"));
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				_g11.@set(global::Player.Toe, global::UnityEngine.GameObject.Find("/Players/O"));
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				_g11.@set(global::Player.Rhomb, global::UnityEngine.GameObject.Find("/Players/Rhomb"));
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/magic/StaticInit.hx"
				global::Scene.players = _g11;
			}
			
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 12 "src/Scene.hx"
			return new global::Scene(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 12 "src/Scene.hx"
			return new global::Scene();
		}
		#line default
	}
	
	
}



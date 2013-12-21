
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class DoorUCore : global::pony.unity3d.scene.OpenClose 
	{
		public    DoorUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    DoorUCore() : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				return new global::pony.unity3d.scene.ucore.DoorUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				return new global::pony.unity3d.scene.ucore.DoorUCore();
			}
			#line default
		}
		
		
		public  global::pony.unity3d.scene.MouseHelper mh;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				base.Start();
				this.mh = ((global::pony.unity3d.scene.MouseHelper) (global::hugs.GameObjectMethods.getOrAddTypedComponent<object>(this.gameObject, typeof(global::pony.unity3d.scene.MouseHelper))) );
				object __temp_stmt645 = default(object);
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				{
					#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("change"), ((int) (930255216) ))) ), 0);
					#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
					__temp_stmt645 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				this.mh.down.@add(__temp_stmt645, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				switch (hash)
				{
					case 24411:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						this.mh = ((global::pony.unity3d.scene.MouseHelper) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 24411:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						return this.mh;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				baseArr.push("mh");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/DoorUCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



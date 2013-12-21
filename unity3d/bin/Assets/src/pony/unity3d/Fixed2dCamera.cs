
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class Fixed2dCamera : global::haxe.lang.HxObject 
	{
		static Fixed2dCamera() 
		{
			#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
			global::pony.unity3d.Fixed2dCamera.begin = ((float) (0) );
			global::pony.unity3d.Fixed2dCamera.exists = false;
			#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
			global::pony.unity3d.Fixed2dCamera.visible = true;
			#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
			global::pony.unity3d.Fixed2dCamera.SIZE = 0;
		}
		public    Fixed2dCamera(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Fixed2dCamera()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				global::pony.unity3d.Fixed2dCamera.__hx_ctor_pony_unity3d_Fixed2dCamera(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_unity3d_Fixed2dCamera(global::pony.unity3d.Fixed2dCamera __temp_me128)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  float begin;
		
		public static  bool exists;
		
		public static  bool visible;
		
		public static  int SIZE;
		
		public static  global::pony.unity3d.Fixed2dCameraU obj;
		
		public static   bool _set_visible(bool v)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				if (( global::pony.unity3d.Fixed2dCamera.obj == default(global::pony.unity3d.Fixed2dCameraU) )) 
				{
					object listener = default(object);
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					object __temp_stmt622 = default(object);
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					{
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						object l = default(object);
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						{
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							global::haxe.lang.Function __temp_stmt623 = default(global::haxe.lang.Function);
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							{
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								global::Array<bool> v1 = new global::Array<bool>(new bool[]{v});
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								__temp_stmt623 = new global::pony.unity3d.Fixed2dCamera_set_visible_52__Fun(((global::Array<bool>) (global::Array<object>.__hx_cast<bool>(((global::Array) (v1) ))) ));
							}
							
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							object f = global::pony._Function.Function_Impl_.@from(__temp_stmt623, 0);
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						__temp_stmt622 = l;
					}
					
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					listener = ((object) (__temp_stmt622) );
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					{
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						int priority = 0;
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						object listener1 = ((object) (listener) );
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						object __temp_stmt624 = default(object);
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						{
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							object f1 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							object this2 = default(object);
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							{
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								object __temp_getvar242 = f1;
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								double __temp_ret243 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar242, "used", 1303220797, true)) );
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								object __temp_expr625 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar242, "used", 1303220797, ( __temp_ret243 + 1.0 ))) );
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								double __temp_expr626 = __temp_ret243;
							}
							
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							{
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								bool __temp_odecl620 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								bool __temp_odecl621 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
								#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
								this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f1, __temp_odecl621, true, default(global::pony.events.Event), __temp_odecl620}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
							}
							
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							__temp_stmt624 = this2;
						}
						
						#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
						this1.@add(((object) (__temp_stmt624) ), new global::haxe.lang.Null<int>(priority, true));
					}
					
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
					object __temp_expr627 = this1.target;
				}
				 else 
				{
					if (( v != global::pony.unity3d.Fixed2dCamera.visible )) 
					{
						if (v) 
						{
							#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							global::pony.unity3d.Fixed2dCamera.obj.size = global::pony.unity3d.Fixed2dCamera.SIZE;
						}
						 else 
						{
							#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
							global::pony.unity3d.Fixed2dCamera.obj.size = 0;
						}
						
						global::pony.unity3d.Fixed2dCamera.visible = v;
					}
					
				}
				
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				return true;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				return new global::pony.unity3d.Fixed2dCamera(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				return new global::pony.unity3d.Fixed2dCamera();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class Fixed2dCamera_set_visible_52__Fun : global::haxe.lang.Function 
	{
		public    Fixed2dCamera_set_visible_52__Fun(global::Array<bool> v1) : base(0, 0)
		{
			unchecked 
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				this.v1 = v1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Fixed2dCamera.hx"
				return global::pony.unity3d.Fixed2dCamera._set_visible(this.v1[0]);
			}
			#line default
		}
		
		
		public  global::Array<bool> v1;
		
	}
}



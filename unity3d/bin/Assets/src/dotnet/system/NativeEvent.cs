
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dotnet.system
{
	public  class NativeEvent<T> : global::haxe.lang.HxObject, global::dotnet.system.NativeEvent 
	{
		public    NativeEvent(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    NativeEvent()
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				global::dotnet.system.NativeEvent<object>.__hx_ctor_dotnet_system_NativeEvent<T>(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_dotnet_system_NativeEvent<T_c>(global::dotnet.system.NativeEvent<T_c> __temp_me26)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<T_c_c>(global::dotnet.system.NativeEvent me)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				return ( (( me != default(global::dotnet.system.NativeEvent) )) ? (me.dotnet_system_NativeEvent_cast<T_c_c>()) : (default(global::dotnet.system.NativeEvent)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				return new global::dotnet.system.NativeEvent<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				return new global::dotnet.system.NativeEvent<object>();
			}
			#line default
		}
		
		
		public virtual   object dotnet_system_NativeEvent_cast<T_c>()
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
					return this;
				}
				
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				global::dotnet.system.NativeEvent<T_c> new_me = new global::dotnet.system.NativeEvent<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				{
					#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
					object __temp_iterator146 = global::Reflect.fields(this).iterator();
					#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator146, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator146, "next", 1224901875, default(global::Array)));
						#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
						switch (field)
						{
							default:
							{
								#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 30 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/dotnet/system/NativeEvent.hx"
				return new_me;
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dotnet.system
{
	public  interface NativeEvent : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object dotnet_system_NativeEvent_cast<T_c>();
		
	}
}



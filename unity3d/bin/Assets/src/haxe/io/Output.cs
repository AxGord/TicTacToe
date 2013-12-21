
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Output : global::haxe.lang.HxObject 
	{
		public    Output(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Output()
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				global::haxe.io.Output.__hx_ctor_haxe_io_Output(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Output(global::haxe.io.Output __temp_me47)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				return new global::haxe.io.Output(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				return new global::haxe.io.Output();
			}
			#line default
		}
		
		
		public virtual   void close()
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				switch (hash)
				{
					case 1214453688:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("close"), ((int) (1214453688) ))) );
					}
					
					
					default:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				switch (hash)
				{
					case 1214453688:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
						this.close();
						#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
						break;
					}
					
					
					default:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Output.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}



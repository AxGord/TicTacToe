
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class BytesOutput : global::haxe.io.Output 
	{
		public    BytesOutput(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    BytesOutput()
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				global::haxe.io.BytesOutput.__hx_ctor_haxe_io_BytesOutput(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_BytesOutput(global::haxe.io.BytesOutput __temp_me48)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				__temp_me48.b = new global::haxe.io.BytesBuffer();
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				return new global::haxe.io.BytesOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				return new global::haxe.io.BytesOutput();
			}
			#line default
		}
		
		
		public  global::haxe.io.BytesBuffer b;
		
		public virtual   void writeByte(int c)
		{
			unchecked 
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				( this.b.b as global::System.IO.Stream ).WriteByte(((byte) (c) ));
			}
			#line default
		}
		
		
		public virtual   global::haxe.io.Bytes getBytes()
		{
			unchecked 
			{
				#line 119 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				return this.b.getBytes();
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						this.b = ((global::haxe.io.BytesBuffer) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 493819893:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBytes"), ((int) (493819893) ))) );
					}
					
					
					case 1238832007:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeByte"), ((int) (1238832007) ))) );
					}
					
					
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return this.b;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				switch (hash)
				{
					case 493819893:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return this.getBytes();
					}
					
					
					case 1238832007:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						this.writeByte(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						break;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				baseArr.push("b");
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
				{
					#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/BytesOutput.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



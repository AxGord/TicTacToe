
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io
{
	public  class Bytes : global::haxe.lang.HxObject 
	{
		public    Bytes(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Bytes(int length, byte[] b)
		{
			unchecked 
			{
				#line 29 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				global::haxe.io.Bytes.__hx_ctor_haxe_io_Bytes(this, length, b);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Bytes(global::haxe.io.Bytes __temp_me43, int length, byte[] b)
		{
			unchecked 
			{
				#line 30 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				__temp_me43.length = length;
				__temp_me43.b = b;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				return new global::haxe.io.Bytes(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				return new global::haxe.io.Bytes(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((byte[]) (arr[1]) ));
			}
			#line default
		}
		
		
		public  int length;
		
		public  byte[] b;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						this.length = ((int) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						this.b = ((byte[]) (@value) );
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return @value;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
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
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 98:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return this.b;
					}
					
					
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return this.length;
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				switch (hash)
				{
					case 520590566:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return ((double) (this.length) );
					}
					
					
					default:
					{
						#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				baseArr.push("b");
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				baseArr.push("length");
				#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
				{
					#line 24 "C:\\HaxeToolkit\\haxe\\std/haxe/io/Bytes.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



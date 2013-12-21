
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Date : global::haxe.lang.HxObject 
{
	public    Date(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    Date(int year, int month, int day, int hour, int min, int sec)
	{
		unchecked 
		{
			#line 31 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			global::Date.__hx_ctor__Date(this, year, month, day, hour, min, sec);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__Date(global::Date __temp_me5, int year, int month, int day, int hour, int min, int sec)
	{
		unchecked 
		{
			#line 33 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			if (( day <= 0 )) 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
				day = 1;
			}
			
			if (( year <= 0 )) 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
				year = 1;
			}
			
			__temp_me5.date = new global::System.DateTime(((int) (year) ), ((int) (( month + 1 )) ), ((int) (day) ), ((int) (hour) ), ((int) (min) ), ((int) (sec) ));
		}
		#line default
	}
	
	
	public static   global::Date now()
	{
		unchecked 
		{
			#line 95 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			global::Date d = new global::Date(((int) (0) ), ((int) (0) ), ((int) (0) ), ((int) (0) ), ((int) (0) ), ((int) (0) ));
			d.date = global::System.DateTime.Now;
			return d;
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			return new global::Date(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			return new global::Date(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[1])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[3])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[4])) ), ((int) (global::haxe.lang.Runtime.toInt(arr[5])) ));
		}
		#line default
	}
	
	
	public  global::System.DateTime date;
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			switch (hash)
			{
				case 1113806382:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
					this.date = ((global::System.DateTime) (@value) );
					#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
					return @value;
				}
				
				
				default:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
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
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			switch (hash)
			{
				case 1113806382:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
					return this.date;
				}
				
				
				default:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
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
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			baseArr.push("date");
			#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
			{
				#line 27 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Date.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
}



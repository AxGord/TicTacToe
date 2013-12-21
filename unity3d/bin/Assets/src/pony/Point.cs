
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony._Point
{
	public sealed class IntPoint_Impl_ 
	{
		public static   object add1(object lhs, object rhs)
		{
			unchecked 
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				{
					#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl456 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "x", 120, true)) ) + ((int) (global::haxe.lang.Runtime.getField_f(rhs, "x", 120, true)) ) );
					#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl457 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "y", 121, true)) ) + ((int) (global::haxe.lang.Runtime.getField_f(rhs, "y", 121, true)) ) );
					#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{120, 121}), new global::Array<double>(new double[]{((double) (__temp_odecl456) ), ((double) (__temp_odecl457) )}));
				}
				
			}
			#line default
		}
		
		
		public static   object add2(object lhs, object rhs)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl458 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "x", 120, true)) ) + ((int) (global::haxe.lang.Runtime.getField_f(rhs, "x", 120, true)) ) );
					#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl459 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "y", 121, true)) ) + ((int) (global::haxe.lang.Runtime.getField_f(rhs, "y", 121, true)) ) );
					#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{120, 121}), new global::Array<double>(new double[]{((double) (__temp_odecl458) ), ((double) (__temp_odecl459) )}));
				}
				
			}
			#line default
		}
		
		
		public static   object m1(object lhs, object rhs)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl460 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "x", 120, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(rhs, "x", 120, true)) ) );
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl461 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "y", 121, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(rhs, "y", 121, true)) ) );
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{120, 121}), new global::Array<double>(new double[]{((double) (__temp_odecl460) ), ((double) (__temp_odecl461) )}));
				}
				
			}
			#line default
		}
		
		
		public static   object m2(object lhs, object rhs)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				{
					#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl462 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "x", 120, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(rhs, "x", 120, true)) ) );
					#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl463 = ( ((int) (global::haxe.lang.Runtime.getField_f(lhs, "y", 121, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(rhs, "y", 121, true)) ) );
					#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{120, 121}), new global::Array<double>(new double[]{((double) (__temp_odecl462) ), ((double) (__temp_odecl463) )}));
				}
				
			}
			#line default
		}
		
		
		public static   int getX(object this1)
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "x", 120, true)) );
			}
			#line default
		}
		
		
		public static   int getY(object this1)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "y", 121, true)) );
			}
			#line default
		}
		
		
		public static   object fromRect(object r)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
				{
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl464 = ((int) (global::haxe.lang.Runtime.getField_f(r, "x", 120, true)) );
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					int __temp_odecl465 = ((int) (global::haxe.lang.Runtime.getField_f(r, "y", 121, true)) );
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Point.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{120, 121}), new global::Array<double>(new double[]{((double) (__temp_odecl464) ), ((double) (__temp_odecl465) )}));
				}
				
			}
			#line default
		}
		
		
	}
}



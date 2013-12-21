
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Std 
{
	public    Std()
	{
		unchecked 
		{
			#line 26 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   bool @is(object v, object t)
	{
		unchecked 
		{
			#line 29 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(v, default(object))) 
			{
				return global::haxe.lang.Runtime.eq(t, typeof(object));
			}
			
			if (global::haxe.lang.Runtime.eq(t, default(object))) 
			{
				return false;
			}
			
			global::System.Type clt = ((global::System.Type) (t) );
			if (global::haxe.lang.Runtime.typeEq(clt, default(global::System.Type))) 
			{
				return false;
			}
			
			string name = global::haxe.lang.Runtime.toString(clt);
			#line 38 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			switch (name)
			{
				case "System.Double":
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Boolean":
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return v is bool;
				}
				
				
				case "System.Object":
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return true;
				}
				
				
			}
			
			#line 50 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			global::System.Type clv = v.GetType();
			#line 52 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			return clt.IsAssignableFrom(((global::System.Type) (clv) ));
		}
		#line default
	}
	
	
	public static   string @string(object s)
	{
		unchecked 
		{
			#line 56 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (global::haxe.lang.Runtime.eq(s, default(object))) 
			{
				return "null";
			}
			
			if (( s is bool )) 
			{
				if (((bool) (s) )) 
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return "true";
				}
				 else 
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return "false";
				}
				
			}
			
			#line 61 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			return s.ToString();
		}
		#line default
	}
	
	
	public static   global::haxe.lang.Null<int> parseInt(string x)
	{
		unchecked 
		{
			#line 69 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (string.Equals(x, default(string))) 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
			#line 71 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			int ret = 0;
			int @base = 10;
			int i = -1;
			int len = x.Length;
			#line 76 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (( x.StartsWith("0") && ( len > 2 ) )) 
			{
				#line 78 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				int c = ((int) (global::haxe.lang.Runtime.toInt(x[1])) );
				if (( ( c == 120 ) || ( c == 88 ) )) 
				{
					#line 81 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					i = 1;
					@base = 16;
				}
				
			}
			
			#line 86 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			bool foundAny = false;
			bool isNeg = false;
			while ((  ++ i < len ))
			{
				#line 90 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				int c1 = default(int);
				#line 90 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				c1 = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
				if ( ! (foundAny) ) 
				{
					#line 93 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					switch (c1)
					{
						case 45:
						{
							#line 96 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:case 43:
						{
							#line 99 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							if (isNeg) 
							{
								return default(global::haxe.lang.Null<int>);
							}
							
							continue;
						}
						
						
					}
					
				}
				
				#line 105 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				if (( ( c1 >= 48 ) && ( c1 <= 57 ) )) 
				{
					#line 107 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					if ((  ! (foundAny)  && ( c1 == 48 ) )) 
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						foundAny = true;
						continue;
					}
					
					#line 112 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret *= @base;
					#line 112 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					foundAny = true;
					#line 114 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret += ( c1 - 48 );
				}
				 else 
				{
					if (( @base == 16 )) 
					{
						if (( ( c1 >= 97 ) && ( c1 <= 102 ) )) 
						{
							ret *= @base;
							#line 117 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							foundAny = true;
							ret += ( ( c1 - 97 ) + 10 );
						}
						 else 
						{
							if (( ( c1 >= 65 ) && ( c1 <= 70 ) )) 
							{
								ret *= @base;
								#line 120 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
								foundAny = true;
								ret += ( ( c1 - 65 ) + 10 );
							}
							 else 
							{
								#line 123 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
								break;
							}
							
						}
						
					}
					 else 
					{
						#line 126 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						break;
					}
					
				}
				
			}
			
			#line 130 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (foundAny) 
			{
				if (isNeg) 
				{
					#line 131 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return new global::haxe.lang.Null<int>( - (ret) , true);
				}
				 else 
				{
					#line 131 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return new global::haxe.lang.Null<int>(ret, true);
				}
				
			}
			 else 
			{
				#line 133 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
		}
		#line default
	}
	
	
	public static   double parseFloat(string x)
	{
		unchecked 
		{
			#line 137 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (string.Equals(x, default(string))) 
			{
				#line 137 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				return global::Math.NaN;
			}
			
			x = x.TrimStart();
			#line 140 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			double ret = 0.0;
			double div = 0.0;
			double e = 0.0;
			#line 144 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			int len = x.Length;
			bool foundAny = false;
			bool isNeg = false;
			int i = -1;
			while ((  ++ i < len ))
			{
				#line 150 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				int c = default(int);
				#line 150 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				c = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
				if ( ! (foundAny) ) 
				{
					#line 153 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					switch (c)
					{
						case 45:
						{
							#line 156 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:case 43:
						{
							#line 159 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							if (isNeg) 
							{
								return global::Math.NaN;
							}
							
							continue;
						}
						
						
					}
					
				}
				
				#line 165 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				if (( c == 46 )) 
				{
					#line 167 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					if (( div != 0.0 )) 
					{
						break;
					}
					
					div = 1.0;
					#line 171 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					continue;
				}
				
				#line 174 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				if (( ( c >= 48 ) && ( c <= 57 ) )) 
				{
					#line 176 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					if ((  ! (foundAny)  && ( c == 48 ) )) 
					{
						#line 178 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						foundAny = true;
						continue;
					}
					
					#line 182 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret *= ((double) (10) );
					#line 182 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					foundAny = true;
					#line 182 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					div *= ((double) (10) );
					#line 184 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret += ((double) (( c - 48 )) );
				}
				 else 
				{
					if (( foundAny && (( ( c == 101 ) || ( c == 69 ) )) )) 
					{
						bool eNeg = false;
						bool eFoundAny = false;
						if (( ( i + 1 ) < len )) 
						{
							#line 190 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							int next = default(int);
							#line 190 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							next = ((int) (x[( i + 1 )]) );
							if (( next == 45 )) 
							{
								#line 193 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
								eNeg = true;
								i++;
							}
							 else 
							{
								if (( next == 43 )) 
								{
									i++;
								}
								
							}
							
						}
						
						#line 200 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						while ((  ++ i < len ))
						{
							#line 202 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							c = ((int) (x[i]) );
							if (( ( c >= 48 ) && ( c <= 57 ) )) 
							{
								#line 205 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
								if ((  ! (eFoundAny)  && ( c == 48 ) )) 
								{
									continue;
								}
								
								eFoundAny = true;
								e *= ((double) (10) );
								e += ((double) (( c - 48 )) );
							}
							 else 
							{
								#line 211 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
								break;
							}
							
						}
						
						#line 215 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						if (eNeg) 
						{
							#line 215 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
							e =  - (e) ;
						}
						
					}
					 else 
					{
						#line 217 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
						break;
					}
					
				}
				
			}
			
			#line 221 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (( div == 0.0 )) 
			{
				#line 221 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				div = 1.0;
			}
			
			#line 223 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
			if (foundAny) 
			{
				#line 225 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				if (isNeg) 
				{
					#line 225 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret =  - ((( ret / div ))) ;
				}
				 else 
				{
					#line 225 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					ret = ( ret / div );
				}
				
				if (( e != 0.0 )) 
				{
					#line 228 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return ( ret * global::System.Math.Pow(((double) (10.0) ), ((double) (e) )) );
				}
				 else 
				{
					#line 230 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
					return ret;
				}
				
			}
			 else 
			{
				#line 233 "C:\\HaxeToolkit\\haxe\\std/cs/_std/Std.hx"
				return global::Math.NaN;
			}
			
		}
		#line default
	}
	
	
}



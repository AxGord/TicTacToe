
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class StringTools : global::haxe.lang.HxObject 
{
	public    StringTools(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    StringTools()
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			global::StringTools.__hx_ctor__StringTools(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__StringTools(global::StringTools __temp_me12)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   string urlEncode(string s)
	{
		unchecked 
		{
			#line 52 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return System.Uri.EscapeUriString(s);
		}
		#line default
	}
	
	
	public static   string urlDecode(string s)
	{
		unchecked 
		{
			#line 77 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return System.Uri.UnescapeDataString(s);
		}
		#line default
	}
	
	
	public static   string htmlEscape(string s, global::haxe.lang.Null<bool> quotes)
	{
		unchecked 
		{
			#line 98 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			s = global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
			if ((quotes).@value) 
			{
				#line 99 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
				return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "\"").@join("&quot;"), "\'").@join("&#039;");
			}
			 else 
			{
				#line 99 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
				return s;
			}
			
		}
		#line default
	}
	
	
	public static   string htmlUnescape(string s)
	{
		unchecked 
		{
			#line 117 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&quot;").@join("\""), "&#039;").@join("\'"), "&amp;").@join("&");
		}
		#line default
	}
	
	
	public static   bool startsWith(string s, string start)
	{
		unchecked 
		{
			#line 131 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s.StartsWith(start);
		}
		#line default
	}
	
	
	public static   bool endsWith(string s, string end)
	{
		unchecked 
		{
			#line 148 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s.EndsWith(end);
		}
		#line default
	}
	
	
	public static   bool isSpace(string s, int pos)
	{
		unchecked 
		{
			#line 166 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			global::haxe.lang.Null<int> c = global::haxe.lang.StringExt.charCodeAt(s, pos);
			return ( ( ( c.@value > 8 ) && ( c.@value < 14 ) ) || global::haxe.lang.Runtime.eq((c).toDynamic(), 32) );
		}
		#line default
	}
	
	
	public static   string ltrim(string s)
	{
		unchecked 
		{
			#line 181 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s.TrimStart();
		}
		#line default
	}
	
	
	public static   string rtrim(string s)
	{
		unchecked 
		{
			#line 206 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s.TrimEnd();
		}
		#line default
	}
	
	
	public static   string trim(string s)
	{
		unchecked 
		{
			#line 228 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s.Trim();
		}
		#line default
	}
	
	
	public static   string lpad(string s, string c, int l)
	{
		unchecked 
		{
			#line 249 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			if (( c.Length <= 0 )) 
			{
				return s;
			}
			
			#line 252 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			while (( s.Length < l ))
			{
				s = global::haxe.lang.Runtime.concat(c, s);
			}
			
			#line 255 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s;
		}
		#line default
	}
	
	
	public static   string rpad(string s, string c, int l)
	{
		unchecked 
		{
			#line 271 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			if (( c.Length <= 0 )) 
			{
				return s;
			}
			
			#line 274 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			while (( s.Length < l ))
			{
				s = global::haxe.lang.Runtime.concat(s, c);
			}
			
			#line 277 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return s;
		}
		#line default
	}
	
	
	public static   string replace(string s, string sub, string @by)
	{
		unchecked 
		{
			#line 298 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			if (( sub.Length == 0 )) 
			{
				return global::haxe.lang.StringExt.split(s, sub).@join(@by);
			}
			 else 
			{
				#line 301 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
				return s.Replace(sub, @by);
			}
			
		}
		#line default
	}
	
	
	public static   string hex(int n, global::haxe.lang.Null<int> digits)
	{
		unchecked 
		{
			#line 319 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			string s = "";
			string hexChars = "0123456789ABCDEF";
			do 
			{
				s = global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
				n = ((int) (( ((uint) (n) ) >> 4 )) );
			}
			while (( n > 0 ));
			#line 326 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			if (( ! (global::haxe.lang.Runtime.eq((digits).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) )) 
			{
				while (( s.Length < digits.@value ))
				{
					s = global::haxe.lang.Runtime.concat("0", s);
				}
				
			}
			
			return s;
		}
		#line default
	}
	
	
	public static   int fastCodeAt(string s, int index)
	{
		unchecked 
		{
			#line 354 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			if (( ((uint) (index) ) < s.Length )) 
			{
				#line 354 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
				return ((int) (global::haxe.lang.Runtime.toInt(s[index])) );
			}
			 else 
			{
				#line 354 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
				return -1;
			}
			
		}
		#line default
	}
	
	
	public static   bool isEof(int c)
	{
		unchecked 
		{
			#line 379 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return ( c == -1 );
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return new global::StringTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 32 "C:\\HaxeToolkit\\haxe\\std/StringTools.hx"
			return new global::StringTools();
		}
		#line default
	}
	
	
}



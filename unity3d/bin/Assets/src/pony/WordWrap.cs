
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class WordWrap : global::haxe.lang.HxObject 
	{
		static WordWrap() 
		{
			#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
			global::pony.WordWrap.newLine = global::haxe.lang.StringExt.charCodeAt("\n", 0).@value;
			global::pony.WordWrap.def = global::haxe.lang.StringExt.charCodeAt("-", 0).@value;
			global::pony.WordWrap.space = global::haxe.lang.StringExt.charCodeAt(" ", 0).@value;
			#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
			global::pony.WordWrap.splitChars = new global::Array<object>(new object[]{" ", "-", "\t"});
		}
		public    WordWrap(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    WordWrap()
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				global::pony.WordWrap.__hx_ctor_pony_WordWrap(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_WordWrap(global::pony.WordWrap __temp_me110)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  int newLine;
		
		public static  int def;
		
		public static  int space;
		
		public static  global::Array<object> splitChars;
		
		public static   string wordWrap(string str, int width)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				global::Array<object> words = global::pony.StringTls.explode(str, global::pony.WordWrap.splitChars);
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				int curLineLength = 0;
				global::StringBuf strBuilder = new global::StringBuf();
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
					int _g = 0;
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
					while (( _g < words.length ))
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
						string word = global::haxe.lang.Runtime.toString(words[_g]);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
						 ++ _g;
						#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
						if (( ( curLineLength + word.Length ) > width )) 
						{
							#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
							if (( curLineLength > 0 )) 
							{
								#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
								strBuilder.b.Append(((char) (global::pony.WordWrap.newLine) ));
								curLineLength = 0;
							}
							
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
							while (( word.Length > width ))
							{
								#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
								strBuilder.addSub(word, 0, new global::haxe.lang.Null<int>(( width - 1 ), true));
								strBuilder.b.Append(((char) (global::pony.WordWrap.def) ));
								word = global::haxe.lang.StringExt.substr(word, ( width - 1 ), default(global::haxe.lang.Null<int>));
								strBuilder.b.Append(((char) (global::pony.WordWrap.newLine) ));
							}
							
							#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
							word = word.TrimStart();
						}
						
						#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
						strBuilder.b.Append(((object) (global::Std.@string(word)) ));
						strBuilder.b.Append(((char) (global::pony.WordWrap.space) ));
						curLineLength += word.Length;
					}
					
				}
				
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				return strBuilder.toString();
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				return new global::pony.WordWrap(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/WordWrap.hx"
				return new global::pony.WordWrap();
			}
			#line default
		}
		
		
	}
}



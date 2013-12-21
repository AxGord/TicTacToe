
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Listener0
{
	public sealed class Listener0_Impl_ 
	{
		public static   object _new<Target>(object l)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
				return l;
			}
			#line default
		}
		
		
		public static   object from0(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
				{
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
					object l = default(object);
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(f, 0);
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
					return l;
				}
				
			}
			#line default
		}
		
		
		public static   object fromEvent(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
					object l = global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(f, 1), true);
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
					return l;
				}
				
			}
			#line default
		}
		
		
		public static   object to<Target>(object this1)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
				return this1;
			}
			#line default
		}
		
		
		public static   object fromListener(object f)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener0.hx"
				return ((object) (f) );
			}
			#line default
		}
		
		
	}
}



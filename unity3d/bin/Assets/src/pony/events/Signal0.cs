
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal0
{
	public sealed class Signal0_Impl_ 
	{
		public static   global::pony.events.Signal _new<Target>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return s;
			}
			#line default
		}
		
		
		public static   bool _get_silent<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return this1.silent;
			}
			#line default
		}
		
		
		public static   bool _set_silent<Target>(global::pony.events.Signal this1, bool b)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return this1.silent = b;
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_lostListeners<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return ((global::pony.events.Signal) (this1.lostListeners) );
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_takeListeners<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return ((global::pony.events.Signal) (this1.takeListeners) );
			}
			#line default
		}
		
		
		public static   bool _get_haveListeners<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return ((bool) ( ! ((( this1.listeners.data.length == 0 ))) ) );
			}
			#line default
		}
		
		
		public static   object _get_data<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return this1.data;
			}
			#line default
		}
		
		
		public static   object _set_data<Target>(global::pony.events.Signal this1, object d)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return this1.data = d;
			}
			#line default
		}
		
		
		public static   Target _get_target<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   int _get_listenersCount<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return this1.listeners.data.length;
			}
			#line default
		}
		
		
		public static   Target @add<Target>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				int __temp_priority116 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority116, true));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target once<Target>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				{
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					int priority = 0;
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object listener1 = ((object) (listener) );
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object __temp_stmt513 = default(object);
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object f = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object this2 = default(object);
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_getvar215 = f;
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_ret216 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar215, "used", 1303220797, true)) );
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_expr514 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar215, "used", 1303220797, ( __temp_ret216 + 1.0 ))) );
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_expr515 = __temp_ret216;
						}
						
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl511 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl512 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl512, true, default(global::pony.events.Event), __temp_odecl511}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						__temp_stmt513 = this2;
					}
					
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					this1.@add(((object) (__temp_stmt513) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target @remove<Target>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.@remove(((object) (listener) ));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target changePriority<Target>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				int __temp_priority117 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					this1.listeners.changeElement(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority117, true));
					#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					global::pony.events.Signal __temp_expr516 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatch<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.dispatchEmpty(default(object));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchEvent<Target>(global::pony.events.Signal this1, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.dispatchEvent(@event);
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchArgs<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.dispatchEmpty(default(object));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchEmpty<Target>(global::pony.events.Signal this1, object _)
		{
			unchecked 
			{
				#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.dispatchEmpty(default(object));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target removeAllListeners<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.removeAllListeners();
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target listen<T, Target>(global::pony.events.Signal this1, global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				{
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					int priority = 0;
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object listener = default(object);
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object __temp_stmt517 = default(object);
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object l = global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true);
						#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						__temp_stmt517 = l;
					}
					
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					listener = ((object) (__temp_stmt517) );
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					s.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object __temp_expr518 = s.target;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target sw<Target>(global::pony.events.Signal this1, object l1, object l2)
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				{
					#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					int priority = 0;
					#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object listener = ((object) (l1) );
					#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object __temp_stmt523 = default(object);
					#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object f = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object this2 = default(object);
						#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_getvar217 = f;
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_ret218 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar217, "used", 1303220797, true)) );
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_expr524 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar217, "used", 1303220797, ( __temp_ret218 + 1.0 ))) );
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_expr525 = __temp_ret218;
						}
						
						#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl519 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl520 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl520, true, default(global::pony.events.Event), __temp_odecl519}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						__temp_stmt523 = this2;
					}
					
					#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					this1.@add(((object) (__temp_stmt523) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				{
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					int priority1 = 0;
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object listener1 = default(object);
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						global::haxe.lang.Function __temp_stmt526 = default(global::haxe.lang.Function);
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							global::Array<object> l21 = new global::Array<object>(new object[]{((object) (l1) )});
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							global::Array<object> l11 = new global::Array<object>(new object[]{((object) (l2) )});
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) )});
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							__temp_stmt526 = new global::pony.events._Signal0.Signal0_Impl__sw_109__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l11) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l21) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
						}
						
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt526, 0);
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						listener1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					object __temp_stmt527 = default(object);
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object f3 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						object this3 = default(object);
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_getvar219 = f3;
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_ret220 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar219, "used", 1303220797, true)) );
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_expr528 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar219, "used", 1303220797, ( __temp_ret220 + 1.0 ))) );
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							double __temp_expr529 = __temp_ret220;
						}
						
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl521 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							bool __temp_odecl522 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							this3 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl522, true, default(global::pony.events.Event), __temp_odecl521}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						__temp_stmt527 = this3;
					}
					
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					this1.@add(((object) (__temp_stmt527) ), new global::haxe.lang.Null<int>(priority1, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   void enableSilent<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.silent = true;
			}
			#line default
		}
		
		
		public static   void disableSilent<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this1.silent = false;
			}
			#line default
		}
		
		
		public static   Target destroy<Target>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				{
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					{
						#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							object __temp_iterator221 = this1.subMap.vs.iterator();
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator221, "hasNext", 407283053, default(global::Array))) ))
							{
								#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
								global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator221, "next", 1224901875, default(global::Array))) );
								#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
								e.removeAllListeners();
							}
							
						}
						
						#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						{
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							global::pony.Dictionary<object, object> _this = this1.subMap;
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							_this.ks = new global::Array<object>(new object[]{});
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
							_this.vs = new global::Array<object>(new object[]{});
						}
						
						#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
						global::pony.events.Signal __temp_expr530 = this1;
					}
					
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					this1.removeAllListeners();
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this1.takeListeners);
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
					global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this1.lostListeners);
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal @from<A>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return ((global::pony.events.Signal) (s) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal0
{
	public  class Signal0_Impl__sw_109__Fun : global::haxe.lang.Function 
	{
		public    Signal0_Impl__sw_109__Fun(global::Array<object> l11, global::Array<object> l21, global::Array<object> f2) : base(0, 0)
		{
			unchecked 
			{
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this.l11 = l11;
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this.l21 = l21;
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal0.hx"
				return ((global::pony.events.Signal) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), this.l11[0], this.l21[0])) );
			}
			#line default
		}
		
		
		public  global::Array<object> l11;
		
		public  global::Array<object> l21;
		
		public  global::Array<object> f2;
		
	}
}



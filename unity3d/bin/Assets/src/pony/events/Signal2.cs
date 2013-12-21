
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal2
{
	public sealed class Signal2_Impl_ 
	{
		public static   global::pony.events.Signal _new<Target, T1, T2>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return s;
			}
			#line default
		}
		
		
		public static   bool _get_silent<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.silent;
			}
			#line default
		}
		
		
		public static   bool _set_silent<Target, T1, T2>(global::pony.events.Signal this1, bool b)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.silent = b;
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_lostListeners<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return ((global::pony.events.Signal) (this1.lostListeners) );
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal _get_takeListeners<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return ((global::pony.events.Signal) (this1.takeListeners) );
			}
			#line default
		}
		
		
		public static   bool _get_haveListeners<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return ((bool) ( ! ((( this1.listeners.data.length == 0 ))) ) );
			}
			#line default
		}
		
		
		public static   object _get_data<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.data;
			}
			#line default
		}
		
		
		public static   object _set_data<Target, T1, T2>(global::pony.events.Signal this1, object d)
		{
			unchecked 
			{
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.data = d;
			}
			#line default
		}
		
		
		public static   Target _get_target<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   int _get_listenersCount<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.listeners.data.length;
			}
			#line default
		}
		
		
		public static   Target @add<Target, T1, T2>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				int __temp_priority120 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority120, true));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target once<Target, T1, T2>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					int priority = 0;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object listener1 = ((object) (listener) );
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object __temp_stmt556 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object f = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object this2 = default(object);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_getvar230 = f;
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_ret231 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar230, "used", 1303220797, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_expr557 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar230, "used", 1303220797, ( __temp_ret231 + 1.0 ))) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_expr558 = __temp_ret231;
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl554 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl555 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl555, true, default(global::pony.events.Event), __temp_odecl554}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						__temp_stmt556 = this2;
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.@add(((object) (__temp_stmt556) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target @remove<Target, T1, T2>(global::pony.events.Signal this1, object listener)
		{
			unchecked 
			{
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.@remove(((object) (listener) ));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target changePriority<Target, T1, T2>(global::pony.events.Signal this1, object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				int __temp_priority121 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.listeners.changeElement(((object) (listener) ), new global::haxe.lang.Null<int>(__temp_priority121, true));
					#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events.Signal __temp_expr559 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatch<Target, T1, T2>(global::pony.events.Signal this1, T1 a, T2 b)
		{
			unchecked 
			{
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{a, b})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						global::pony.events.Signal __temp_expr560 = this1;
					}
					
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
				}
				
			}
			#line default
		}
		
		
		public static   Target dispatchEvent<Target, T1, T2>(global::pony.events.Signal this1, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.dispatchEvent(@event);
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchArgs<Target, T1, T2>(global::pony.events.Signal this1, global::Array args)
		{
			unchecked 
			{
				#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events.Signal __temp_expr561 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target dispatchEmpty<Target, T1, T2>(global::pony.events.Signal this1, object _)
		{
			unchecked 
			{
				#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.dispatchEmpty(default(object));
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal sub<Target, T1, T2>(global::pony.events.Signal this1, object a, object b)
		{
			unchecked 
			{
				#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.subArgs(( (global::haxe.lang.Runtime.eq(b, default(object))) ? (new global::Array<object>(new object[]{a})) : (new global::Array<object>(new object[]{a, b})) ));
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal sub1<Target, T1, T2>(global::pony.events.Signal this1, T1 a)
		{
			unchecked 
			{
				#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events.Signal s = this1.subArgs(new global::Array<object>(new object[]{a}));
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					return ((global::pony.events.Signal) (s) );
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal sub2<Target, T1, T2>(global::pony.events.Signal this1, T1 a, T2 b)
		{
			unchecked 
			{
				#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events.Signal s = this1.subArgs(new global::Array<object>(new object[]{a, b}));
					#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					return ((global::pony.events.Signal) (s) );
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal subArgs<Target, T1, T2>(global::pony.events.Signal this1, global::Array args)
		{
			unchecked 
			{
				#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return this1.subArgs(args);
			}
			#line default
		}
		
		
		public static   Target removeSub<Target, T1, T2>(global::pony.events.Signal this1, object a, object b)
		{
			unchecked 
			{
				#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.removeSubArgs(( (global::haxe.lang.Runtime.eq(b, default(object))) ? (new global::Array<object>(new object[]{a})) : (new global::Array<object>(new object[]{a, b})) ));
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
				}
				
			}
			#line default
		}
		
		
		public static   Target removeSubArgs<Target, T1, T2>(global::pony.events.Signal this1, global::Array args)
		{
			unchecked 
			{
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.removeSubArgs(args);
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target removeAllSub<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object __temp_iterator232 = this1.subMap.vs.iterator();
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator232, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator232, "next", 1224901875, default(global::Array))) );
							#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							e.removeAllListeners();
						}
						
					}
					
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						global::pony.Dictionary<object, object> _this = this1.subMap;
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						_this.ks = new global::Array<object>(new object[]{});
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						_this.vs = new global::Array<object>(new object[]{});
					}
					
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events.Signal __temp_expr562 = this1;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target removeAllListeners<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 119 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.removeAllListeners();
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target listen<T, Target, T1, T2>(global::pony.events.Signal this1, global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					int priority = 0;
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object listener = default(object);
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object __temp_stmt563 = default(object);
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object l = global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true);
						#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						__temp_stmt563 = l;
					}
					
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					listener = ((object) (__temp_stmt563) );
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					s.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object __temp_expr564 = s.target;
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target sw<Target, T1, T2>(global::pony.events.Signal this1, object l1, object l2)
		{
			unchecked 
			{
				#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					int priority = 0;
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object listener = ((object) (l1) );
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object __temp_stmt569 = default(object);
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object f = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object this2 = default(object);
						#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_getvar233 = f;
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_ret234 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar233, "used", 1303220797, true)) );
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_expr570 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar233, "used", 1303220797, ( __temp_ret234 + 1.0 ))) );
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_expr571 = __temp_ret234;
						}
						
						#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl565 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl566 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl566, true, default(global::pony.events.Event), __temp_odecl565}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						__temp_stmt569 = this2;
					}
					
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.@add(((object) (__temp_stmt569) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					int priority1 = 0;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object listener1 = default(object);
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						global::haxe.lang.Function __temp_stmt572 = default(global::haxe.lang.Function);
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							global::Array<object> l21 = new global::Array<object>(new object[]{((object) (l1) )});
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							global::Array<object> l11 = new global::Array<object>(new object[]{((object) (l2) )});
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this1) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) )});
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							__temp_stmt572 = new global::pony.events._Signal2.Signal2_Impl__sw_130__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l21) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l11) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
						}
						
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt572, 0);
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						listener1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					object __temp_stmt573 = default(object);
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object f3 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						object this3 = default(object);
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_getvar235 = f3;
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_ret236 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar235, "used", 1303220797, true)) );
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_expr574 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar235, "used", 1303220797, ( __temp_ret236 + 1.0 ))) );
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							double __temp_expr575 = __temp_ret236;
						}
						
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl567 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							bool __temp_odecl568 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							this3 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl568, true, default(global::pony.events.Event), __temp_odecl567}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						__temp_stmt573 = this3;
					}
					
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.@add(((object) (__temp_stmt573) ), new global::haxe.lang.Null<int>(priority1, true));
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   Target destroy<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				{
					#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					{
						#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							object __temp_iterator237 = this1.subMap.vs.iterator();
							#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator237, "hasNext", 407283053, default(global::Array))) ))
							{
								#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
								global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator237, "next", 1224901875, default(global::Array))) );
								#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
								e.removeAllListeners();
							}
							
						}
						
						#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						{
							#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							global::pony.Dictionary<object, object> _this = this1.subMap;
							#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							_this.ks = new global::Array<object>(new object[]{});
							#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
							_this.vs = new global::Array<object>(new object[]{});
						}
						
						#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
						global::pony.events.Signal __temp_expr576 = this1;
					}
					
					#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					this1.removeAllListeners();
					#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this1.takeListeners);
					#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
					global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this1.lostListeners);
				}
				
				return global::haxe.lang.Runtime.genericCast<Target>(this1.target);
			}
			#line default
		}
		
		
		public static   void enableSilent<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.silent = true;
			}
			#line default
		}
		
		
		public static   void disableSilent<Target, T1, T2>(global::pony.events.Signal this1)
		{
			unchecked 
			{
				#line 140 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this1.silent = false;
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal @from<A, B, C>(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return ((global::pony.events.Signal) (s) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Signal2
{
	public  class Signal2_Impl__sw_130__Fun : global::haxe.lang.Function 
	{
		public    Signal2_Impl__sw_130__Fun(global::Array<object> l21, global::Array<object> l11, global::Array<object> f2) : base(0, 0)
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this.l21 = l21;
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this.l11 = l11;
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal2.hx"
				return ((global::pony.events.Signal) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), this.l11[0], this.l21[0])) );
			}
			#line default
		}
		
		
		public  global::Array<object> l21;
		
		public  global::Array<object> l11;
		
		public  global::Array<object> f2;
		
	}
}



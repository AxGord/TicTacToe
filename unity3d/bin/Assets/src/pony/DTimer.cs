
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class DTimer : global::haxe.lang.HxObject 
	{
		public    DTimer(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    DTimer(global::haxe.lang.Null<int> hour, global::haxe.lang.Null<int> min, global::haxe.lang.Null<int> sec, global::haxe.lang.Null<bool> forward, global::haxe.lang.Null<bool> repeat)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				global::pony.DTimer.__hx_ctor_pony_DTimer(this, hour, min, sec, forward, repeat);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_DTimer(global::pony.DTimer __temp_me78, global::haxe.lang.Null<int> hour, global::haxe.lang.Null<int> min, global::haxe.lang.Null<int> sec, global::haxe.lang.Null<bool> forward, global::haxe.lang.Null<bool> repeat)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				bool __temp_repeat77 = ( (global::haxe.lang.Runtime.eq((repeat).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (repeat.@value) );
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				bool __temp_forward76 = ( (global::haxe.lang.Runtime.eq((forward).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (forward.@value) );
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_sec75 = ( (global::haxe.lang.Runtime.eq((sec).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (sec.@value) );
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_min74 = ( (global::haxe.lang.Runtime.eq((min).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (min.@value) );
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_hour73 = ( (global::haxe.lang.Runtime.eq((hour).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (hour.@value) );
				__temp_me78.update = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me78.updateVisual = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me78.progress = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me78.complite = new global::pony.events.Signal(((object) (default(object)) ));
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority = 0;
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener = default(object);
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt366 = default(object);
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l = default(object);
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me78) ), global::haxe.lang.Runtime.toString("takeVisual"), ((int) (56966759) ))) ), 0);
							#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt366 = l;
					}
					
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener = ((object) (__temp_stmt366) );
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this1 = __temp_me78.updateVisual.takeListeners;
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr367 = this1.target;
				}
				
				{
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority1 = 0;
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener1 = default(object);
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt368 = default(object);
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l1 = default(object);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me78) ), global::haxe.lang.Runtime.toString("lostVisual"), ((int) (1134216132) ))) ), 0);
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
						}
						
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt368 = l1;
					}
					
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener1 = ((object) (__temp_stmt368) );
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this2 = __temp_me78.updateVisual.lostListeners;
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this2.@add(((object) (listener1) ), new global::haxe.lang.Null<int>(priority1, true));
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr369 = this2.target;
				}
				
				{
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority2 = 0;
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener2 = default(object);
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt370 = default(object);
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l2 = default(object);
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me78) ), global::haxe.lang.Runtime.toString("takeProgress"), ((int) (390040340) ))) ), 0);
							#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l2 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
						}
						
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt370 = l2;
					}
					
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener2 = ((object) (__temp_stmt370) );
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this3 = __temp_me78.progress.takeListeners;
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this3.@add(((object) (listener2) ), new global::haxe.lang.Null<int>(priority2, true));
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr371 = this3.target;
				}
				
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority3 = 0;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener3 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt372 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l3 = default(object);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me78) ), global::haxe.lang.Runtime.toString("lostProgress"), ((int) (1944510897) ))) ), 0);
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l3 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt372 = l3;
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener3 = ((object) (__temp_stmt372) );
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this4 = __temp_me78.progress.lostListeners;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this4.@add(((object) (listener3) ), new global::haxe.lang.Null<int>(priority3, true));
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr373 = this4.target;
				}
				
				__temp_me78.setTime(new global::haxe.lang.Null<int>(__temp_hour73, true), new global::haxe.lang.Null<int>(__temp_min74, true), new global::haxe.lang.Null<int>(__temp_sec75, true));
				__temp_me78.forward = __temp_forward76;
				__temp_me78.repeat = __temp_repeat77;
			}
			#line default
		}
		
		
		public static   global::pony.DTimer delay(int sec, global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 214 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				global::pony.DTimer t = new global::pony.DTimer(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(sec, true), new global::haxe.lang.Null<bool>(false, true), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) ));
				{
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority = 0;
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener = default(object);
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(f, 0);
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt376 = default(object);
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object f2 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object this1 = default(object);
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object __temp_getvar156 = f2;
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							double __temp_ret157 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar156, "used", 1303220797, true)) );
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object __temp_expr377 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar156, "used", 1303220797, ( __temp_ret157 + 1.0 ))) );
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							double __temp_expr378 = __temp_ret157;
						}
						
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							bool __temp_odecl374 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							bool __temp_odecl375 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f2, __temp_odecl375, true, default(global::pony.events.Event), __temp_odecl374}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt376 = this1;
					}
					
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					t.complite.@add(((object) (__temp_stmt376) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				return t;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return new global::pony.DTimer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return new global::pony.DTimer(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[2]), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[3]), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[4]));
			}
			#line default
		}
		
		
		public  int hour;
		
		public  int min;
		
		public  int sec;
		
		public  bool forward;
		
		public  bool repeat;
		
		public  bool started;
		
		public  global::pony.events.Signal update;
		
		public  global::pony.events.Signal updateVisual;
		
		public  global::pony.events.Signal progress;
		
		public  global::pony.events.Signal complite;
		
		public  double sumdt;
		
		public  object startTime;
		
		public  double startTotal;
		
		public  double total;
		
		public virtual   void takeVisual()
		{
			unchecked 
			{
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				object __temp_stmt347 = default(object);
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("visual"), ((int) (1871454912) ))) ), 0);
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					__temp_stmt347 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.update.@add(__temp_stmt347, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public virtual   void lostVisual()
		{
			unchecked 
			{
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				object __temp_stmt348 = default(object);
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("visual"), ((int) (1871454912) ))) ), 0);
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					__temp_stmt348 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.update.@remove(__temp_stmt348);
			}
			#line default
		}
		
		
		public virtual   void takeProgress()
		{
			unchecked 
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				object __temp_stmt349 = default(object);
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_progress"), ((int) (1304489740) ))) ), 0);
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					__temp_stmt349 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.update.@add(__temp_stmt349, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public virtual   void lostProgress()
		{
			unchecked 
			{
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				object __temp_stmt350 = default(object);
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_progress"), ((int) (1304489740) ))) ), 0);
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					__temp_stmt350 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.update.@remove(__temp_stmt350);
			}
			#line default
		}
		
		
		public virtual   global::pony.DTimer setTime(global::haxe.lang.Null<int> hour, global::haxe.lang.Null<int> min, global::haxe.lang.Null<int> sec)
		{
			unchecked 
			{
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_sec72 = ( (global::haxe.lang.Runtime.eq((sec).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (sec.@value) );
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_min71 = ( (global::haxe.lang.Runtime.eq((min).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (min.@value) );
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				int __temp_hour70 = ( (global::haxe.lang.Runtime.eq((hour).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (hour.@value) );
				this.startTime = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{5443986, 5741457, 1158861092}), new global::Array<double>(new double[]{((double) (__temp_min71) ), ((double) (__temp_sec72) ), ((double) (__temp_hour70) )}));
				this.hour = __temp_hour70;
				this.min = __temp_min71;
				this.sec = __temp_sec72;
				this.total = this.startTotal = ((double) (( ( ( ( __temp_hour70 * 60 ) * 60 ) + ( __temp_min71 * 60 ) ) + __temp_sec72 )) );
				this.sumdt = ((double) (0) );
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.update;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{__temp_hour70, __temp_min71, __temp_sec72})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr351 = _this;
				}
				
				#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return this;
			}
			#line default
		}
		
		
		public   global::pony.DTimer reset()
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return this.setTime(new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "hour", 1158861092, true)) ), true), new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "min", 5443986, true)) ), true), new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "sec", 5741457, true)) ), true));
			}
			#line default
		}
		
		
		public virtual   global::pony.DTimer start()
		{
			unchecked 
			{
				#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.started = true;
				if (this.forward) 
				{
					int priority = 0;
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener = default(object);
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt354 = default(object);
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l = default(object);
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_update"), ((int) (1971099560) ))) ), 1);
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt354 = l;
					}
					
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener = ((object) (__temp_stmt354) );
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr355 = this1.target;
				}
				 else 
				{
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					int priority1 = 0;
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener1 = default(object);
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt352 = default(object);
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l1 = default(object);
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_updateBack"), ((int) (1280283119) ))) ), 1);
							#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
						}
						
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt352 = l1;
					}
					
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener1 = ((object) (__temp_stmt352) );
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this2 = global::pony.DeltaTime.update;
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this2.@add(((object) (listener1) ), new global::haxe.lang.Null<int>(priority1, true));
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr353 = this2.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.DTimer stop()
		{
			unchecked 
			{
				#line 116 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.started = false;
				if (this.forward) 
				{
					object listener = default(object);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt358 = default(object);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l = default(object);
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_update"), ((int) (1971099560) ))) ), 1);
							#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt358 = l;
					}
					
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener = ((object) (__temp_stmt358) );
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this1.@remove(((object) (listener) ));
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr359 = this1.target;
				}
				 else 
				{
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object listener1 = default(object);
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_stmt356 = default(object);
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					{
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						object l1 = default(object);
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						{
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_updateBack"), ((int) (1280283119) ))) ), 1);
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
							l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
						}
						
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						__temp_stmt356 = l1;
					}
					
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					listener1 = ((object) (__temp_stmt356) );
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					global::pony.events.Signal this2 = global::pony.DeltaTime.update;
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					this2.@remove(((object) (listener1) ));
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					object __temp_expr357 = this2.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   void _update(double dt)
		{
			unchecked 
			{
				#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.sumdt += dt;
				this.total += dt;
				bool updated = ( this.sumdt > 1 );
				while (( this.sumdt > 1 ))
				{
					this.sumdt--;
					this.sec++;
					if (( this.sec > 59 )) 
					{
						this.min++;
						this.sec = 0;
						if (( this.min > 59 )) 
						{
							this.hour++;
							this.min = 0;
							if (( this.hour > 23 )) 
							{
								this.hour = 0;
							}
							
						}
						
					}
					
				}
				
				#line 143 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				if (updated) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.update;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.hour, this.min, this.sec})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr360 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void _updateBack(double dt)
		{
			unchecked 
			{
				#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.sumdt -= dt;
				this.total -= dt;
				bool updated = ( this.sumdt < 0 );
				while (( this.sumdt < 0 ))
				{
					this.sumdt++;
					this.sec--;
					if (( this.sec < 0 )) 
					{
						this.min--;
						this.sec = 59;
						if (( this.min < 0 )) 
						{
							this.hour--;
							this.min = 59;
							if (( this.hour < 0 )) 
							{
								#line 162 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
								this.stop();
								this.hour = this.min = this.sec = 0;
								#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal _this = this.complite;
									#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal __temp_expr361 = _this;
								}
								
								#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
								if (this.repeat) 
								{
									this.setTime(new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "hour", 1158861092, true)) ), true), new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "min", 5443986, true)) ), true), new global::haxe.lang.Null<int>(((int) (global::haxe.lang.Runtime.getField_f(this.startTime, "sec", 5741457, true)) ), true));
									this.start();
								}
								
							}
							
						}
						
					}
					
				}
				
				#line 174 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				if (updated) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this1 = this.update;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.hour, this.min, this.sec})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr362 = _this1;
				}
				
			}
			#line default
		}
		
		
		public virtual   void visual()
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array args = new global::Array<object>(new object[]{this.toString()});
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.updateVisual;
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr363 = _this;
			}
			#line default
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				#line 183 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::pony.FloatTools._toFixed(((double) (this.hour) ), 0, new global::haxe.lang.Null<int>(2, true), ".", "0", "0"), ":"), global::pony.FloatTools._toFixed(((double) (this.min) ), 0, new global::haxe.lang.Null<int>(2, true), ".", "0", "0")), ":"), global::pony.FloatTools._toFixed(((double) (this.sec) ), 0, new global::haxe.lang.Null<int>(2, true), ".", "0", "0"));
			}
			#line default
		}
		
		
		public virtual   global::pony.DTimer parse(string s)
		{
			unchecked 
			{
				#line 187 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				global::Array<object> a = global::haxe.lang.StringExt.split(s, ":");
				this.setTime(global::Std.parseInt(global::haxe.lang.Runtime.toString(a[0])), global::Std.parseInt(global::haxe.lang.Runtime.toString(a[1])), global::Std.parseInt(global::haxe.lang.Runtime.toString(a[2])));
				return this;
			}
			#line default
		}
		
		
		public virtual   void _progress()
		{
			unchecked 
			{
				#line 193 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				if (this.forward) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.progress;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( this.total / this.startTotal )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr365 = _this;
				}
				 else 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this1 = this.progress;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( 1 - ( this.total / this.startTotal ) )})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr364 = _this1;
				}
				
			}
			#line default
		}
		
		
		public virtual   void minus(int h, int m, int s)
		{
			unchecked 
			{
				#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				this.hour -= h;
				this.min -= m;
				this.sec -= s;
				while (( this.sec < 0 ))
				{
					this.sec += 60;
					this.min--;
				}
				
				#line 207 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				while (( this.min < 0 ))
				{
					this.min += 60;
					this.hour--;
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				switch (hash)
				{
					case 338842564:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.total = ((double) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 810101762:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.startTotal = ((double) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 99632527:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.startTime = ((object) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 79542747:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.sumdt = ((double) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 5741457:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.sec = ((int) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.min = ((int) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 1158861092:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.hour = ((int) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
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
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				switch (hash)
				{
					case 338842564:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.total = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 810101762:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.startTotal = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 99632527:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.startTime = ((object) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 79542747:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.sumdt = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 2144012733:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.complite = ((global::pony.events.Signal) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 103479213:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.progress = ((global::pony.events.Signal) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 1867499945:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.updateVisual = ((global::pony.events.Signal) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 117802505:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.update = ((global::pony.events.Signal) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 890972481:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.started = ((bool) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 108828507:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.repeat = ((bool) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 1707794885:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.forward = ((bool) (@value) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 5741457:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.sec = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.min = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					case 1158861092:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.hour = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
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
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				switch (hash)
				{
					case 141066352:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("minus"), ((int) (141066352) ))) );
					}
					
					
					case 1304489740:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_progress"), ((int) (1304489740) ))) );
					}
					
					
					case 1029017651:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parse"), ((int) (1029017651) ))) );
					}
					
					
					case 946786476:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
					}
					
					
					case 1871454912:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("visual"), ((int) (1871454912) ))) );
					}
					
					
					case 1280283119:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_updateBack"), ((int) (1280283119) ))) );
					}
					
					
					case 1971099560:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_update"), ((int) (1971099560) ))) );
					}
					
					
					case 1281093634:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("stop"), ((int) (1281093634) ))) );
					}
					
					
					case 67859554:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("start"), ((int) (67859554) ))) );
					}
					
					
					case 1724402127:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("reset"), ((int) (1724402127) ))) );
					}
					
					
					case 310447311:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setTime"), ((int) (310447311) ))) );
					}
					
					
					case 1944510897:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lostProgress"), ((int) (1944510897) ))) );
					}
					
					
					case 390040340:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("takeProgress"), ((int) (390040340) ))) );
					}
					
					
					case 1134216132:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lostVisual"), ((int) (1134216132) ))) );
					}
					
					
					case 56966759:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("takeVisual"), ((int) (56966759) ))) );
					}
					
					
					case 338842564:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.total;
					}
					
					
					case 810101762:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.startTotal;
					}
					
					
					case 99632527:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.startTime;
					}
					
					
					case 79542747:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.sumdt;
					}
					
					
					case 2144012733:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.complite;
					}
					
					
					case 103479213:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.progress;
					}
					
					
					case 1867499945:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.updateVisual;
					}
					
					
					case 117802505:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.update;
					}
					
					
					case 890972481:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.started;
					}
					
					
					case 108828507:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.repeat;
					}
					
					
					case 1707794885:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.forward;
					}
					
					
					case 5741457:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.sec;
					}
					
					
					case 5443986:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.min;
					}
					
					
					case 1158861092:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.hour;
					}
					
					
					default:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
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
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				switch (hash)
				{
					case 338842564:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.total;
					}
					
					
					case 810101762:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.startTotal;
					}
					
					
					case 99632527:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.startTime)) );
					}
					
					
					case 79542747:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.sumdt;
					}
					
					
					case 5741457:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((double) (this.sec) );
					}
					
					
					case 5443986:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((double) (this.min) );
					}
					
					
					case 1158861092:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return ((double) (this.hour) );
					}
					
					
					default:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				switch (hash)
				{
					case 141066352:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.minus(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1304489740:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this._progress();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1029017651:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.parse(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 946786476:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.toString();
					}
					
					
					case 1871454912:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.visual();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1280283119:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this._updateBack(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1971099560:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this._update(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1281093634:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.stop();
					}
					
					
					case 67859554:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.start();
					}
					
					
					case 1724402127:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.reset();
					}
					
					
					case 310447311:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return this.setTime(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[2]));
					}
					
					
					case 1944510897:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.lostProgress();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 390040340:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.takeProgress();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 1134216132:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.lostVisual();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					case 56966759:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						this.takeVisual();
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						break;
					}
					
					
					default:
					{
						#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("total");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("startTotal");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("startTime");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("sumdt");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("complite");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("progress");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("updateVisual");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("update");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("started");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("repeat");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("forward");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("sec");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("min");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				baseArr.push("hour");
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
				{
					#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DTimer.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}



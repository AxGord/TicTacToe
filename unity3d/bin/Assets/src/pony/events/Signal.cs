
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal : global::haxe.lang.HxObject 
	{
		public    Signal(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Signal(object target)
		{
			unchecked 
			{
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal.__hx_ctor_pony_events_Signal(this, target);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_events_Signal(global::pony.events.Signal __temp_me82, object target)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				__temp_me82.silent = false;
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				__temp_me82.subMap = new global::pony.Dictionary<object, object>(new global::haxe.lang.Null<int>(5, true));
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me82.target = target;
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me82.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me82.lRunCopy = new global::List<object>();
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr409 = __temp_me82;
				}
				
				{
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = default(global::pony.events.Signal);
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this = ((global::pony.events.Signal) (global::Type.createEmptyInstance<object>(typeof(global::pony.events.Signal))) );
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.target = __temp_me82;
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.lRunCopy = new global::List<object>();
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						s = _this;
					}
					
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me82.lostListeners = ((global::pony.events.Signal) (s) );
				}
				
				{
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s1 = default(global::pony.events.Signal);
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this1 = ((global::pony.events.Signal) (global::Type.createEmptyInstance<object>(typeof(global::pony.events.Signal))) );
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.target = __temp_me82;
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.lRunCopy = new global::List<object>();
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						s1 = _this1;
					}
					
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_me82.takeListeners = ((global::pony.events.Signal) (s1) );
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal create<A>(A t)
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = new global::pony.events.Signal(((object) (t) ));
					#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return s;
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.events.Signal createEmpty()
		{
			unchecked 
			{
				#line 289 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 289 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal s = new global::pony.events.Signal(((object) (default(object)) ));
					#line 289 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return s;
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return new global::pony.events.Signal(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return new global::pony.events.Signal(((object) (arr[0]) ));
			}
			#line default
		}
		
		
		public  bool silent;
		
		public  global::pony.events.Signal lostListeners;
		
		public  global::pony.events.Signal takeListeners;
		
		public  object data;
		
		public  object target;
		
		public  global::pony.Priority<object> listeners;
		
		public  global::List<object> lRunCopy;
		
		public  global::pony.Dictionary<object, object> subMap;
		
		public  bool haveListeners;
		
		public   global::pony.events.Signal init(object target)
		{
			unchecked 
			{
				#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.target = target;
				this.listeners = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
				this.lRunCopy = new global::List<object>();
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal @add(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority79 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_getvar158 = listener;
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					double __temp_ret159 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar158, "used", 1303220797, true)) );
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::haxe.lang.Runtime.setField(__temp_getvar158, "used", 1303220797, ( __temp_ret159 + 1.0 ));
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					double __temp_expr379 = __temp_ret159;
				}
				
				bool f = ( this.listeners.data.length == 0 );
				this.listeners.addElement(listener, new global::haxe.lang.Null<int>(__temp_priority79, true));
				if (( f && ( this.takeListeners != default(global::pony.events.Signal) ) )) 
				{
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this1 = this.takeListeners;
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this1.dispatchEmpty(default(object));
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr380 = this1.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal @remove(object listener)
		{
			unchecked 
			{
				#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				if (( this.listeners.data.length == 0 )) 
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				if (this.listeners.removeElement(listener)) 
				{
					{
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_iterator160 = this.lRunCopy.iterator();
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator160, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.Priority<object> c = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::haxe.lang.Runtime.callField(__temp_iterator160, "next", 1224901875, default(global::Array))) ))) );
							#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							c.removeElement(listener);
						}
						
					}
					
					{
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar161 = listener;
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_ret162 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar161, "used", 1303220797, true)) );
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar161, "used", 1303220797, ((double) (( __temp_ret162 - 1 )) ));
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_expr381 = __temp_ret162;
						}
						
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ((int) (global::haxe.lang.Runtime.getField_f(listener, "used", 1303220797, true)) ) == 0 )) 
						{
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "id", 23515, true)) ));
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							{
								#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									object __temp_getvar163 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_ret164 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar163, "used", 1303220797, true)) );
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField_f(__temp_getvar163, "used", 1303220797, ((double) (( __temp_ret164 - 1 )) ));
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_expr382 = __temp_ret164;
								}
								
								#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
								{
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
									{
										#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true)));
									}
									 else 
									{
										#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(listener, "f", 102, true), "f", 102, true)));
									}
									
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField(listener, "f", 102, default(object));
									#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony._Function.Function_Impl_.unusedCount--;
								}
								
							}
							
						}
						
					}
					
					if (( ( this.listeners.data.length == 0 ) && ( this.lostListeners != default(global::pony.events.Signal) ) )) 
					{
						#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events._Signal0.Signal0_Impl_.dispatchEmpty<object>(this.lostListeners, default(object));
					}
					
				}
				
				#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal changePriority(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority80 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this.listeners.changeElement(listener, new global::haxe.lang.Null<int>(__temp_priority80, true));
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal once(object listener, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				int __temp_priority81 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				object __temp_stmt385 = default(object);
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object f = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object this1 = default(object);
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_getvar165 = f;
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						double __temp_ret166 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar165, "used", 1303220797, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_expr386 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar165, "used", 1303220797, ( __temp_ret166 + 1.0 ))) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						double __temp_expr387 = __temp_ret166;
					}
					
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						bool __temp_odecl383 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						bool __temp_odecl384 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
						#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl384, true, default(global::pony.events.Event), __temp_odecl383}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
					}
					
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					__temp_stmt385 = this1;
				}
				
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this.@add(((object) (__temp_stmt385) ), new global::haxe.lang.Null<int>(__temp_priority81, true));
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal dispatchEvent(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 138 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				@event.signal = this;
				if (this.silent) 
				{
					#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				global::pony.Priority<object> c = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (this.listeners.data.copy()) ))) ));
				this.lRunCopy.@add(c);
				{
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator167 = c.iterator();
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator167, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator167, "next", 1224901875, default(global::Array))) );
						bool r = false;
						#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						try 
						{
							#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							r = global::pony.events._Listener.Listener_Impl_.call(l, @event);
						}
						catch (global::System.Exception __temp_catchallException390)
						{
							#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_catchall391 = __temp_catchallException390;
							#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							if (( __temp_catchall391 is global::haxe.lang.HaxeException )) 
							{
								#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								__temp_catchall391 = ((global::haxe.lang.HaxeException) (__temp_catchallException390) ).obj;
							}
							
							#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							if (( __temp_catchall391 is string )) 
							{
								#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								string msg = global::haxe.lang.Runtime.toString(__temp_catchall391);
								#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									this.@remove(l);
									this.lRunCopy.@remove(c);
									#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									throw global::haxe.lang.HaxeException.wrap(msg);
								}
								
							}
							 else 
							{
								#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								object e = __temp_catchall391;
								this.@remove(l);
								this.lRunCopy.@remove(c);
								#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								try 
								{
									#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), global::haxe.lang.Runtime.getField(e, "pos", 5594516, true), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"dispatchEvent", "pony.events.Signal", "Signal.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (165) )})));
								}
								catch (global::System.Exception __temp_catchallException388)
								{
									object __temp_catchall389 = __temp_catchallException388;
									#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( __temp_catchall389 is global::haxe.lang.HaxeException )) 
									{
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										__temp_catchall389 = ((global::haxe.lang.HaxeException) (__temp_catchallException388) ).obj;
									}
									
									#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									{
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										object e1 = __temp_catchall389;
										#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										{
										}
										
									}
									
								}
								
								
								throw global::haxe.lang.HaxeException.wrap(e);
							}
							
						}
						
						
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ((int) (global::haxe.lang.Runtime.getField_f(l, "count", 1248019663, true)) ) == 0 )) 
						{
							#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this.@remove(l);
						}
						
						if ( ! (r) ) 
						{
							#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							break;
						}
						
					}
					
				}
				
				#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.lRunCopy.@remove(c);
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal dispatchArgs(global::Array args)
		{
			unchecked 
			{
				#line 177 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal dispatchEmpty(object _)
		{
			unchecked 
			{
				#line 182 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.dispatchEvent(new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal subArgs(global::Array args)
		{
			unchecked 
			{
				#line 196 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal s = ((global::pony.events.Signal) (this.subMap.@get(args)) );
				if (( s == default(global::pony.events.Signal) )) 
				{
					s = new global::pony.events.Signal(((object) (this.target) ));
					s.data = args;
					global::haxe.lang.Function __temp_stmt393 = default(global::haxe.lang.Function);
					#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array<object> a1 = new global::Array<object>(new object[]{args});
						#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array<object> f = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subHandler"), ((int) (1111449130) ))) )});
						#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt393 = new global::pony.events.Signal_subArgs_200__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (a1) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f) ))) ));
					}
					
					#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt392 = global::pony._Function.Function_Impl_.@from(__temp_stmt393, 1);
					#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt392, true), default(global::haxe.lang.Null<int>));
					this.subMap.@set(args, s);
				}
				
				#line 203 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return s;
			}
			#line default
		}
		
		
		public virtual   void subHandler(global::Array args, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 207 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array a = ((global::Array) (global::haxe.lang.Runtime.callField(@event.args, "copy", 1103412149, default(global::Array))) );
				{
					#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int _g = 0;
					#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (( global::haxe.lang.Runtime.compare(_g, ((int) (global::haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) )) < 0 ))
					{
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object arg = args[_g];
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						 ++ _g;
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ! (global::haxe.lang.Runtime.eq(((object) (global::haxe.lang.Runtime.callField(a, "shift", 2082663554, default(global::Array))) ), arg)) )) 
						{
							#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return ;
						}
						
					}
					
				}
				
				((global::pony.events.Signal) (this.subMap.@get(args)) ).dispatchEvent(new global::pony.events.Event(((global::Array) (a) ), ((object) (@event.target) ), ((global::pony.events.Event) (@event) )));
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal removeSubArgs(global::Array args)
		{
			unchecked 
			{
				#line 221 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal s = ((global::pony.events.Signal) (this.subMap.@get(args)) );
				if (( s == default(global::pony.events.Signal) )) 
				{
					#line 222 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return this;
				}
				
				s.removeAllListeners();
				this.subMap.@remove(args);
				return this;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal removeAllSub()
		{
			unchecked 
			{
				#line 229 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 229 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator168 = this.subMap.vs.iterator();
					#line 229 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator168, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 229 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator168, "next", 1224901875, default(global::Array))) );
						#line 229 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						e.removeAllListeners();
					}
					
				}
				
				{
					#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.Dictionary<object, object> _this = this.subMap;
					#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.ks = new global::Array<object>(new object[]{});
					#line 230 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.vs = new global::Array<object>(new object[]{});
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal removeAllListeners()
		{
			unchecked 
			{
				#line 235 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 235 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator169 = this.lRunCopy.iterator();
					#line 235 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator169, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 235 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.Priority<object> c = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::haxe.lang.Runtime.callField(__temp_iterator169, "next", 1224901875, default(global::Array))) ))) );
						#line 235 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						c.clear();
					}
					
				}
				
				this.lRunCopy.clear();
				bool f = ( this.listeners.data.length == 0 );
				{
					#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_iterator170 = this.listeners.iterator();
					#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator170, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator170, "next", 1224901875, default(global::Array))) );
						#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar171 = l;
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_ret172 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar171, "used", 1303220797, true)) );
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar171, "used", 1303220797, ((double) (( __temp_ret172 - 1 )) ));
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							int __temp_expr394 = __temp_ret172;
						}
						
						#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (( ((int) (global::haxe.lang.Runtime.getField_f(l, "used", 1303220797, true)) ) == 0 )) 
						{
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(l, "f", 102, true), "id", 23515, true)) ));
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							{
								#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									object __temp_getvar173 = global::haxe.lang.Runtime.getField(l, "f", 102, true);
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_ret174 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar173, "used", 1303220797, true)) );
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField_f(__temp_getvar173, "used", 1303220797, ((double) (( __temp_ret174 - 1 )) ));
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									int __temp_expr395 = __temp_ret174;
								}
								
								#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(l, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
								{
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
									{
										#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true)));
									}
									 else 
									{
										#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(l, "f", 102, true), "f", 102, true)));
									}
									
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::haxe.lang.Runtime.setField(l, "f", 102, default(object));
									#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony._Function.Function_Impl_.unusedCount--;
								}
								
							}
							
						}
						
					}
					
				}
				
				this.listeners.clear();
				if ( ! (f) ) 
				{
					#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal this1 = this.lostListeners;
					#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this1.dispatchEmpty(default(object));
					#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_expr396 = this1.target;
				}
				
				return this;
			}
			#line default
		}
		
		
		public   object buildListenerEvent(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array<object> event1 = new global::Array<object>(new object[]{@event});
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{this});
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerEvent_252__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (event1) ))) )), 0);
					#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
			}
			#line default
		}
		
		
		public   object buildListenerArgs(global::Array args)
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (args) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{this});
					#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerArgs_253__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) )), 0);
						#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public   object buildListenerEmpty()
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{this});
					#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events.Signal_buildListenerEmpty_254__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) )), 0);
						#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public   bool _get_haveListeners()
		{
			unchecked 
			{
				#line 256 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return  ! ((( this.listeners.data.length == 0 ))) ;
			}
			#line default
		}
		
		
		public   global::pony.events.Signal listen(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 259 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				s.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.events.Signal sw(object l1, object l2)
		{
			unchecked 
			{
				#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int priority = 0;
					#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt401 = default(object);
					#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f = global::haxe.lang.Runtime.getField(l1, "f", 102, true);
						#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object this1 = default(object);
						#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar175 = f;
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_ret176 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar175, "used", 1303220797, true)) );
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_expr402 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar175, "used", 1303220797, ( __temp_ret176 + 1.0 ))) );
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_expr403 = __temp_ret176;
						}
						
						#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl397 = ((bool) (global::haxe.lang.Runtime.getField(l1, "event", 1975830554, true)) );
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl398 = ((bool) (global::haxe.lang.Runtime.getField(l1, "ignoreReturn", 98429794, true)) );
							#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl398, true, default(global::pony.events.Event), __temp_odecl397}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt401 = this1;
					}
					
					#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(((object) (__temp_stmt401) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				{
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					int priority1 = 0;
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object listener = default(object);
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::haxe.lang.Function __temp_stmt404 = default(global::haxe.lang.Function);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> l21 = new global::Array<object>(new object[]{l1});
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> l11 = new global::Array<object>(new object[]{l2});
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) )});
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							__temp_stmt404 = new global::pony.events.Signal_sw_265__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l11) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (l21) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
						}
						
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt404, 0);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					object __temp_stmt405 = default(object);
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object f3 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object this2 = default(object);
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_getvar177 = f3;
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_ret178 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar177, "used", 1303220797, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							object __temp_expr406 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar177, "used", 1303220797, ( __temp_ret178 + 1.0 ))) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							double __temp_expr407 = __temp_ret178;
						}
						
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl399 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							bool __temp_odecl400 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl400, true, default(global::pony.events.Event), __temp_odecl399}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						__temp_stmt405 = this2;
					}
					
					#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					this.@add(((object) (__temp_stmt405) ), new global::haxe.lang.Null<int>(priority1, true));
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   void enableSilent()
		{
			unchecked 
			{
				#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.silent = true;
			}
			#line default
		}
		
		
		public virtual   void disableSilent()
		{
			unchecked 
			{
				#line 270 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.silent = false;
			}
			#line default
		}
		
		
		public   int _get_listenersCount()
		{
			unchecked 
			{
				#line 272 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return this.listeners.data.length;
			}
			#line default
		}
		
		
		public   void destroy()
		{
			unchecked 
			{
				#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						object __temp_iterator179 = this.subMap.vs.iterator();
						#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator179, "hasNext", 407283053, default(global::Array))) ))
						{
							#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal e = ((global::pony.events.Signal) (global::haxe.lang.Runtime.callField(__temp_iterator179, "next", 1224901875, default(global::Array))) );
							#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							e.removeAllListeners();
						}
						
					}
					
					#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.Dictionary<object, object> _this = this.subMap;
						#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.ks = new global::Array<object>(new object[]{});
						#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.vs = new global::Array<object>(new object[]{});
					}
					
					#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr408 = this;
				}
				
				this.removeAllListeners();
				global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this.takeListeners);
				global::pony.events._Signal0.Signal0_Impl_.destroy<object>(this.lostListeners);
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.target = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.data = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 419661303:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.haveListeners = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 435030268:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.subMap = ((global::pony.Dictionary<object, object>) (global::pony.Dictionary<object, object>.__hx_cast<object, object>(((global::pony.Dictionary) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1033575828:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.lRunCopy = ((global::List<object>) (global::List<object>.__hx_cast<object>(((global::List) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1938711935:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.listeners = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.target = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.data = ((object) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 1417333816:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.takeListeners = ((global::pony.events.Signal) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 171917051:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.lostListeners = ((global::pony.events.Signal) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					case 936212117:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.silent = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 612773114:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("destroy"), ((int) (612773114) ))) );
					}
					
					
					case 899736473:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_listenersCount"), ((int) (899736473) ))) );
					}
					
					
					case 753054365:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("disableSilent"), ((int) (753054365) ))) );
					}
					
					
					case 1650187640:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("enableSilent"), ((int) (1650187640) ))) );
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) );
					}
					
					
					case 1878640711:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("listen"), ((int) (1878640711) ))) );
					}
					
					
					case 527667534:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_haveListeners"), ((int) (527667534) ))) );
					}
					
					
					case 2067338603:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerEmpty"), ((int) (2067338603) ))) );
					}
					
					
					case 485177407:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerArgs"), ((int) (485177407) ))) );
					}
					
					
					case 19112696:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildListenerEvent"), ((int) (19112696) ))) );
					}
					
					
					case 1214242434:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeAllListeners"), ((int) (1214242434) ))) );
					}
					
					
					case 783593027:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeAllSub"), ((int) (783593027) ))) );
					}
					
					
					case 1731362585:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeSubArgs"), ((int) (1731362585) ))) );
					}
					
					
					case 1111449130:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subHandler"), ((int) (1111449130) ))) );
					}
					
					
					case 242754301:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subArgs"), ((int) (242754301) ))) );
					}
					
					
					case 1081751923:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEmpty"), ((int) (1081751923) ))) );
					}
					
					
					case 1530424631:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchArgs"), ((int) (1530424631) ))) );
					}
					
					
					case 1181009664:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) );
					}
					
					
					case 1236434305:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("once"), ((int) (1236434305) ))) );
					}
					
					
					case 343521524:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changePriority"), ((int) (343521524) ))) );
					}
					
					
					case 76061764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("remove"), ((int) (76061764) ))) );
					}
					
					
					case 4846113:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("add"), ((int) (4846113) ))) );
					}
					
					
					case 1169898256:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
					}
					
					
					case 436667088:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_listenersCount();
					}
					
					
					case 419661303:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						if (handleProperties) 
						{
							#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return this._get_haveListeners();
						}
						 else 
						{
							#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							return this.haveListeners;
						}
						
					}
					
					
					case 435030268:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.subMap;
					}
					
					
					case 1033575828:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.lRunCopy;
					}
					
					
					case 1938711935:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.listeners;
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.target;
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.data;
					}
					
					
					case 1417333816:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.takeListeners;
					}
					
					
					case 171917051:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.lostListeners;
					}
					
					
					case 936212117:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.silent;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 436667088:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (this._get_listenersCount()) );
					}
					
					
					case 116192081:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.target)) );
					}
					
					
					case 1113806378:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(this.data)) );
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
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
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				switch (hash)
				{
					case 612773114:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.destroy();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 899736473:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_listenersCount();
					}
					
					
					case 753054365:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.disableSilent();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 1650187640:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.enableSilent();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.sw(dynargs[0], dynargs[1]);
					}
					
					
					case 1878640711:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.listen(((global::pony.events.Signal) (dynargs[0]) ));
					}
					
					
					case 527667534:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this._get_haveListeners();
					}
					
					
					case 2067338603:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerEmpty();
					}
					
					
					case 485177407:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 19112696:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.buildListenerEvent(((global::pony.events.Event) (dynargs[0]) ));
					}
					
					
					case 1214242434:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeAllListeners();
					}
					
					
					case 783593027:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeAllSub();
					}
					
					
					case 1731362585:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.removeSubArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1111449130:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						this.subHandler(((global::Array) (dynargs[0]) ), ((global::pony.events.Event) (dynargs[1]) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						break;
					}
					
					
					case 242754301:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.subArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1081751923:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchEmpty(dynargs[0]);
					}
					
					
					case 1530424631:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchArgs(((global::Array) (dynargs[0]) ));
					}
					
					
					case 1181009664:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.dispatchEvent(((global::pony.events.Event) (dynargs[0]) ));
					}
					
					
					case 1236434305:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.once(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 343521524:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.changePriority(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 76061764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.@remove(dynargs[0]);
					}
					
					
					case 4846113:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.@add(dynargs[0], global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1169898256:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return this.init(dynargs[0]);
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("listenersCount");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("haveListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("subMap");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("lRunCopy");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("listeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("target");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("data");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("takeListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("lostListeners");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				baseArr.push("silent");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public   int listenersCount
		{
			get { return _get_listenersCount(); }
		}
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_subArgs_200__Fun : global::haxe.lang.Function 
	{
		public    Signal_subArgs_200__Fun(global::Array<object> a1, global::Array<object> f) : base(1, 0)
		{
			unchecked 
			{
				#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.a1 = a1;
				#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.f = f;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Event a2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 200 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return ((global::haxe.lang.Function) (this.f[0]) ).__hx_invoke2_o(default(double), default(double), ((global::Array) (this.a1[0]) ), a2);
			}
			#line default
		}
		
		
		public  global::Array<object> a1;
		
		public  global::Array<object> f;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerEvent_252__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerEvent_252__Fun(global::Array<object> _g, global::Array<object> event1) : base(0, 0)
		{
			unchecked 
			{
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.event1 = event1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.event1[0]) ));
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<object> event1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerArgs_253__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerArgs_253__Fun(global::Array<object> _g, global::Array<object> @event) : base(0, 0)
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.@event = @event;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 253 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<object> @event;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_buildListenerEmpty_254__Fun : global::haxe.lang.Function 
	{
		public    Signal_buildListenerEmpty_254__Fun(global::Array<object> @event, global::Array<object> _g) : base(0, 0)
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.@event = @event;
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this._g = _g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> @event;
		
		public  global::Array<object> _g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class Signal_sw_265__Fun : global::haxe.lang.Function 
	{
		public    Signal_sw_265__Fun(global::Array<object> l11, global::Array<object> l21, global::Array<object> f2) : base(0, 0)
		{
			unchecked 
			{
				#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.l11 = l11;
				#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.l21 = l21;
				#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 265 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				return ((global::pony.events.Signal) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), this.l11[0], this.l21[0])) );
			}
			#line default
		}
		
		
		public  global::Array<object> l11;
		
		public  global::Array<object> l21;
		
		public  global::Array<object> f2;
		
	}
}



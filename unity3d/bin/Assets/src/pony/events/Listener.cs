
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Listener
{
	public sealed class Listener_Impl_ 
	{
		static Listener_Impl_() 
		{
			#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
			global::pony.events._Listener.Listener_Impl_.flist = new global::haxe.ds.IntMap<object>();
		}
		public static  global::haxe.ds.IntMap<object> flist;
		
		public static   object _new(object f, global::haxe.lang.Null<bool> @event, global::haxe.lang.Null<bool> ignoreReturn, global::haxe.lang.Null<int> count)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				int __temp_count115 = ( (global::haxe.lang.Runtime.eq((count).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (-1) )) : (count.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				bool __temp_ignoreReturn114 = ( (global::haxe.lang.Runtime.eq((ignoreReturn).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (ignoreReturn.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				bool __temp_event113 = ( (global::haxe.lang.Runtime.eq((@event).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (@event.@value) );
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				object this1 = default(object);
				{
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar200 = f;
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					double __temp_ret201 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar200, "used", 1303220797, true)) );
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField(__temp_getvar200, "used", 1303220797, ( __temp_ret201 + 1.0 ));
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					double __temp_expr498 = __temp_ret201;
				}
				
				this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_ignoreReturn114, true, default(global::pony.events.Event), __temp_event113}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (__temp_count115) ), ((double) (0) )}));
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return this1;
			}
			#line default
		}
		
		
		public static   object fromEFunction(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(f, 1), true);
			}
			#line default
		}
		
		
		public static   object fromFunction(object f)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
			}
			#line default
		}
		
		
		public static   object fromSignal(global::pony.events.Signal s)
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array<object> @event = new global::Array<object>(new object[]{new global::pony.events.Event(((global::Array) (default(global::Array)) ), ((object) (s.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) ))});
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{s});
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.events._Listener.Listener_Impl__fromSignal_65__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@event) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) )), 0);
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						return global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   object _fromFunction(object f, bool ev)
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				if (global::pony.events._Listener.Listener_Impl_.flist.exists(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ))) 
				{
					return (global::pony.events._Listener.Listener_Impl_.flist.@get(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ))).toDynamic();
				}
				 else 
				{
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object o = default(object);
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						int count = -1;
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool ignoreReturn = true;
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this1 = default(object);
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object __temp_getvar202 = f;
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							double __temp_ret203 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar202, "used", 1303220797, true)) );
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField(__temp_getvar202, "used", 1303220797, ( __temp_ret203 + 1.0 ));
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							double __temp_expr499 = __temp_ret203;
						}
						
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, ignoreReturn, true, default(global::pony.events.Event), ev}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (count) ), ((double) (0) )}));
						#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						o = this1;
					}
					
					global::pony.events._Listener.Listener_Impl_.flist.@set(((int) (global::haxe.lang.Runtime.getField_f(f, "id", 23515, true)) ), o);
					return o;
				}
				
			}
			#line default
		}
		
		
		public static   int _get_count(object this1)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "count", 1248019663, true)) );
			}
			#line default
		}
		
		
		public static   bool call(object this1, global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				if (( ! (((bool) (global::haxe.lang.Runtime.getField(this1, "active", 373703110, true)) )) )) 
				{
					#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return true;
				}
				
				{
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar204 = this1;
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret205 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar204, "count", 1248019663, true)) );
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar204, "count", 1248019663, ((double) (( __temp_ret205 - 1 )) ));
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr500 = __temp_ret205;
				}
				
				@event.currentListener = this1;
				bool r = true;
				if (((bool) (global::haxe.lang.Runtime.getField(this1, "event", 1975830554, true)) )) 
				{
					if (((bool) (global::haxe.lang.Runtime.getField(this1, "ignoreReturn", 98429794, true)) )) 
					{
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Array args = new global::Array<object>(new object[]{@event});
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this2 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( args == default(global::Array) )) 
						{
							#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							args = new global::Array<object>(new object[]{});
						}
						
						#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this2, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this2, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args}))) ));
					}
					 else 
					{
						object __temp_stmt504 = default(object);
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::Array args1 = new global::Array<object>(new object[]{@event});
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object this3 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							if (( args1 == default(global::Array) )) 
							{
								#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								args1 = new global::Array<object>(new object[]{});
							}
							
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							__temp_stmt504 = global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this3, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this3, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args1}))) ));
						}
						
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_stmt503 = global::haxe.lang.Runtime.eq(__temp_stmt504, false);
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (__temp_stmt503) 
						{
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							r = false;
						}
						
					}
					
				}
				 else 
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::Array args2 = new global::Array<object>(new object[]{});
					{
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						int _g = 0;
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Array _g1 = @event.args;
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						while (( global::haxe.lang.Runtime.compare(_g, ((int) (global::haxe.lang.Runtime.getField_f(_g1, "length", 520590566, true)) )) < 0 ))
						{
							#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object e = _g1[_g];
							#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							 ++ _g;
							#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.callField(args2, "push", 1247875546, new global::Array<object>(new object[]{e}));
						}
						
					}
					
					global::haxe.lang.Runtime.callField(args2, "push", 1247875546, new global::Array<object>(new object[]{@event.target}));
					global::haxe.lang.Runtime.callField(args2, "push", 1247875546, new global::Array<object>(new object[]{@event}));
					if (((bool) (global::haxe.lang.Runtime.getField(this1, "ignoreReturn", 98429794, true)) )) 
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Array args3 = ((global::Array) (global::haxe.lang.Runtime.callField(args2, "slice", 2127021138, new global::Array<object>(new object[]{0, ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "count", 1248019663, true)) )}))) );
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object this4 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( args3 == default(global::Array) )) 
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							args3 = new global::Array<object>(new object[]{});
						}
						
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this4, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this4, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args3}))) ));
					}
					 else 
					{
						object __temp_stmt502 = default(object);
						#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::Array args4 = ((global::Array) (global::haxe.lang.Runtime.callField(args2, "slice", 2127021138, new global::Array<object>(new object[]{0, ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "count", 1248019663, true)) )}))) );
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object this5 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							if (( args4 == default(global::Array) )) 
							{
								#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								args4 = new global::Array<object>(new object[]{});
							}
							
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							__temp_stmt502 = global::Reflect.callMethod(default(object), global::haxe.lang.Runtime.getField(this5, "f", 102, true), ((global::Array) (global::haxe.lang.Runtime.callField(((global::Array) (global::haxe.lang.Runtime.getField(this5, "args", 1081380189, true)) ), "concat", 1204816148, new global::Array<object>(new object[]{args4}))) ));
						}
						
						#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_stmt501 = global::haxe.lang.Runtime.eq(__temp_stmt502, false);
						#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (__temp_stmt501) 
						{
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							r = false;
						}
						
					}
					
				}
				
				#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				global::haxe.lang.Runtime.setField(this1, "prev", 1247723251, @event);
				if (@event._stopPropagation) 
				{
					#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return false;
				}
				 else 
				{
					#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return r;
				}
				
			}
			#line default
		}
		
		
		public static   object setCount(object this1, int count)
		{
			unchecked 
			{
				#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object f = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object this2 = default(object);
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object __temp_getvar206 = f;
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						double __temp_ret207 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar206, "used", 1303220797, true)) );
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						global::haxe.lang.Runtime.setField(__temp_getvar206, "used", 1303220797, ( __temp_ret207 + 1.0 ));
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						double __temp_expr507 = __temp_ret207;
					}
					
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					{
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_odecl505 = ((bool) (global::haxe.lang.Runtime.getField(this1, "event", 1975830554, true)) );
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						bool __temp_odecl506 = ((bool) (global::haxe.lang.Runtime.getField(this1, "ignoreReturn", 98429794, true)) );
						#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f, __temp_odecl506, true, default(global::pony.events.Event), __temp_odecl505}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (count) ), ((double) (0) )}));
					}
					
					#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					return this2;
				}
				
			}
			#line default
		}
		
		
		public static   void _use(object this1)
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar208 = this1;
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret209 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar208, "used", 1303220797, true)) );
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar208, "used", 1303220797, ((double) (( __temp_ret209 + 1 )) ));
					#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr508 = __temp_ret209;
				}
				
			}
			#line default
		}
		
		
		public static   void unuse(object this1)
		{
			unchecked 
			{
				#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				{
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_getvar210 = this1;
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_ret211 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar210, "used", 1303220797, true)) );
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					global::haxe.lang.Runtime.setField_f(__temp_getvar210, "used", 1303220797, ((double) (( __temp_ret211 - 1 )) ));
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					int __temp_expr509 = __temp_ret211;
				}
				
				if (( ((int) (global::haxe.lang.Runtime.getField_f(this1, "used", 1303220797, true)) ) == 0 )) 
				{
					global::pony.events._Listener.Listener_Impl_.flist.@remove(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "id", 23515, true)) ));
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							object __temp_getvar212 = global::haxe.lang.Runtime.getField(this1, "f", 102, true);
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							int __temp_ret213 = ((int) (global::haxe.lang.Runtime.getField_f(__temp_getvar212, "used", 1303220797, true)) );
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField_f(__temp_getvar212, "used", 1303220797, ((double) (( __temp_ret213 - 1 )) ));
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							int __temp_expr510 = __temp_ret213;
						}
						
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "used", 1303220797, true)) ), 0) <= 0 )) 
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							if (( global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true) is global::haxe.lang.Closure )) 
							{
								#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								global::pony._Function.Function_Impl_.cslist.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true)));
							}
							 else 
							{
								#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
								global::pony._Function.Function_Impl_.list.@remove(global::pony._Function.Function_Impl_.buildCSHash(global::haxe.lang.Runtime.getField(global::haxe.lang.Runtime.getField(this1, "f", 102, true), "f", 102, true)));
							}
							
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::haxe.lang.Runtime.setField(this1, "f", 102, default(object));
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							global::pony._Function.Function_Impl_.unusedCount--;
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   int _get_used(object this1)
		{
			unchecked 
			{
				#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((int) (global::haxe.lang.Runtime.getField_f(this1, "used", 1303220797, true)) );
			}
			#line default
		}
		
		
		public static   int unusedCount()
		{
			unchecked 
			{
				#line 116 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				int c = 0;
				{
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					object __temp_iterator214 = global::pony.events._Listener.Listener_Impl_.flist.iterator();
					#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator214, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						object l = ((object) (global::haxe.lang.Runtime.callField(__temp_iterator214, "next", 1224901875, default(global::Array))) );
						#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
						if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(l, "used", 1303220797, true)) ), 0) <= 0 )) 
						{
							#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
							c++;
						}
						
					}
					
				}
				
				return c;
			}
			#line default
		}
		
		
		public static   bool _get_active(object this1)
		{
			unchecked 
			{
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((bool) (global::haxe.lang.Runtime.getField(this1, "active", 373703110, true)) );
			}
			#line default
		}
		
		
		public static   bool _set_active(object this1, bool b)
		{
			unchecked 
			{
				#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return ((bool) (global::haxe.lang.Runtime.setField(this1, "active", 373703110, b)) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events._Listener
{
	public  class Listener_Impl__fromSignal_65__Fun : global::haxe.lang.Function 
	{
		public    Listener_Impl__fromSignal_65__Fun(global::Array<object> @event, global::Array<object> _g) : base(0, 0)
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				this.@event = @event;
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				this._g = _g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				((global::pony.events.Signal) (this._g[0]) ).dispatchEvent(((global::pony.events.Event) (this.@event[0]) ));
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Listener.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> @event;
		
		public  global::Array<object> _g;
		
	}
}



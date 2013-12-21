
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Loader : global::haxe.lang.HxObject 
	{
		public    Loader(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Loader(global::haxe.lang.Null<int> intensivity, global::haxe.lang.Null<int> beginWait)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				global::pony.Loader.__hx_ctor_pony_Loader(this, intensivity, beginWait);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_Loader(global::pony.Loader __temp_me97, global::haxe.lang.Null<int> intensivity, global::haxe.lang.Null<int> beginWait)
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				__temp_me97.loaded = false;
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				__temp_me97.complites = 0;
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				__temp_me97.total = 0;
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				__temp_me97.totalActions = 0;
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				int __temp_beginWait96 = ( (global::haxe.lang.Runtime.eq((beginWait).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (beginWait.@value) );
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				int __temp_intensivity95 = ( (global::haxe.lang.Runtime.eq((intensivity).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (10) )) : (intensivity.@value) );
				__temp_me97.intensivity = __temp_intensivity95;
				__temp_me97.beginWait = __temp_beginWait96;
				__temp_me97.actions = new global::List<object>();
				__temp_me97.progress = new global::pony.events.Signal(((object) (__temp_me97) ));
				__temp_me97.complite = new global::pony.events.Signal(((object) (__temp_me97) ));
				{
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					int priority = 0;
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object listener = default(object);
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					{
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me97) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) ), 0);
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object __temp_stmt453 = default(object);
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					{
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object f1 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object this1 = default(object);
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object __temp_getvar193 = f1;
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							double __temp_ret194 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar193, "used", 1303220797, true)) );
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object __temp_expr454 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar193, "used", 1303220797, ( __temp_ret194 + 1.0 ))) );
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							double __temp_expr455 = __temp_ret194;
						}
						
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							bool __temp_odecl451 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							bool __temp_odecl452 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f1, __temp_odecl452, true, default(global::pony.events.Event), __temp_odecl451}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						__temp_stmt453 = this1;
					}
					
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					__temp_me97.complite.@add(((object) (__temp_stmt453) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				return new global::pony.Loader(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				return new global::pony.Loader(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
			#line default
		}
		
		
		public  int intensivity;
		
		public  int beginWait;
		
		public  global::List<object> actions;
		
		public  int totalActions;
		
		public  int total;
		
		public  int complites;
		
		public  global::pony.events.Signal progress;
		
		public  global::pony.events.Signal complite;
		
		public  bool loaded;
		
		public virtual   void init(global::haxe.lang.Null<bool> fastLoad)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				bool __temp_fastLoad94 = ( (global::haxe.lang.Runtime.eq((fastLoad).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (fastLoad.@value) );
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				if ( ! (__temp_fastLoad94) ) 
				{
					if (( this.beginWait == 0 )) 
					{
						int priority = 0;
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object listener = default(object);
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_stmt435 = default(object);
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object l = default(object);
							#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							{
								#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
								#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
							}
							
							#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							__temp_stmt435 = l;
						}
						
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						listener = ((object) (__temp_stmt435) );
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						global::pony.events.Signal this1 = global::pony.DeltaTime.update;
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
						#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_expr436 = this1.target;
					}
					 else 
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						int priority1 = 0;
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object listener1 = default(object);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_stmt433 = default(object);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object l1 = default(object);
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							{
								#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("wait"), ((int) (1324505717) ))) ), 0);
								#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
							}
							
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							__temp_stmt433 = l1;
						}
						
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						listener1 = ((object) (__temp_stmt433) );
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						global::pony.events.Signal this2 = global::pony.DeltaTime.update;
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this2.@add(((object) (listener1) ), new global::haxe.lang.Null<int>(priority1, true));
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_expr434 = this2.target;
					}
					
				}
				 else 
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					global::pony.events.Signal _this = this.complite;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					global::pony.events.Signal __temp_expr432 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void fast()
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.complite;
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr437 = _this;
			}
			#line default
		}
		
		
		public virtual   void wait()
		{
			unchecked 
			{
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				if (( this.beginWait-- <= 0 )) 
				{
					{
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object listener = default(object);
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_stmt438 = default(object);
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object l = default(object);
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							{
								#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("wait"), ((int) (1324505717) ))) ), 0);
								#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
							}
							
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							__temp_stmt438 = l;
						}
						
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						listener = ((object) (__temp_stmt438) );
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						global::pony.events.Signal this1 = global::pony.DeltaTime.update;
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this1.@remove(((object) (listener) ));
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_expr439 = this1.target;
					}
					
					{
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						int priority = 0;
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object listener1 = default(object);
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_stmt440 = default(object);
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object l1 = default(object);
							#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							{
								#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
								#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
								l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
							}
							
							#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							__temp_stmt440 = l1;
						}
						
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						listener1 = ((object) (__temp_stmt440) );
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						global::pony.events.Signal this2 = global::pony.DeltaTime.update;
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this2.@add(((object) (listener1) ), new global::haxe.lang.Null<int>(priority, true));
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object __temp_expr441 = this2.target;
					}
					
				}
				
			}
			#line default
		}
		
		
		public   void begin()
		{
			unchecked 
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				int priority = 0;
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				object listener = default(object);
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				object __temp_stmt442 = default(object);
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object l = default(object);
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					{
						#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
						#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					__temp_stmt442 = l;
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				listener = ((object) (__temp_stmt442) );
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				global::pony.events.Signal this1 = global::pony.DeltaTime.update;
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				object __temp_expr443 = this1.target;
			}
			#line default
		}
		
		
		public virtual   void update()
		{
			unchecked 
			{
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				{
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					int _g1 = 0;
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					int _g = this.intensivity;
					#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					while (( _g1 < _g ))
					{
						#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						int _ = _g1++;
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						if (( this.actions.length > 0 )) 
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							((global::haxe.lang.Function) (this.actions.pop().@value) ).__hx_invoke0_o();
						}
						 else 
						{
							break;
						}
						
					}
					
				}
				
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				if (( this.totalActions == 0 )) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.progress;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( ((double) (this.complites) ) / this.total )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr446 = _this;
				}
				 else 
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					if (( this.total == 0 )) 
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this1 = this.progress;
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( 1 - ( ((double) (this.actions.length) ) / this.totalActions ) )})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr445 = _this1;
					}
					 else 
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this2 = this.progress;
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( (( ( 1 - ( ((double) (this.actions.length) ) / this.totalActions ) ) + ( ((double) (this.complites) ) / this.total ) )) / 2 )})) ), ((object) (_this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr444 = _this2;
					}
					
				}
				
				#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				if (( ( this.actions.length == 0 ) && ( this.complites == this.total ) )) 
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this3 = this.complite;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this3.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this3.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr447 = _this3;
				}
				
			}
			#line default
		}
		
		
		public   double listPercent()
		{
			unchecked 
			{
				#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				return ( 1 - ( ((double) (this.actions.length) ) / this.totalActions ) );
			}
			#line default
		}
		
		
		public   double counterPercent()
		{
			unchecked 
			{
				#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				return ( ((double) (this.complites) ) / this.total );
			}
			#line default
		}
		
		
		public virtual   void end()
		{
			unchecked 
			{
				#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				{
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object listener = default(object);
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object __temp_stmt448 = default(object);
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					{
						#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						object l = default(object);
						#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						{
							#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
							#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						__temp_stmt448 = l;
					}
					
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					listener = ((object) (__temp_stmt448) );
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					this1.@remove(((object) (listener) ));
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					object __temp_expr449 = this1.target;
				}
				
				this.loaded = true;
			}
			#line default
		}
		
		
		public virtual   void addAction(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				this.totalActions++;
				this.actions.push(f);
			}
			#line default
		}
		
		
		public   void fastEnd()
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.complite;
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr450 = _this;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				switch (hash)
				{
					case 1373469718:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.complites = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 338842564:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.total = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 271358105:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.totalActions = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 399259966:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.beginWait = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 1042925606:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.intensivity = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				switch (hash)
				{
					case 1483687941:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.loaded = ((bool) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 2144012733:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.complite = ((global::pony.events.Signal) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 103479213:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.progress = ((global::pony.events.Signal) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 1373469718:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.complites = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 338842564:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.total = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 271358105:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.totalActions = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 1731068925:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.actions = ((global::List<object>) (global::List<object>.__hx_cast<object>(((global::List) (@value) ))) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 399259966:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.beginWait = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					case 1042925606:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.intensivity = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return @value;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				switch (hash)
				{
					case 1579254431:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fastEnd"), ((int) (1579254431) ))) );
					}
					
					
					case 1315598519:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addAction"), ((int) (1315598519) ))) );
					}
					
					
					case 5047259:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) );
					}
					
					
					case 221002537:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("counterPercent"), ((int) (221002537) ))) );
					}
					
					
					case 802823687:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("listPercent"), ((int) (802823687) ))) );
					}
					
					
					case 117802505:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) );
					}
					
					
					case 810936873:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("begin"), ((int) (810936873) ))) );
					}
					
					
					case 1324505717:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("wait"), ((int) (1324505717) ))) );
					}
					
					
					case 1135985308:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fast"), ((int) (1135985308) ))) );
					}
					
					
					case 1169898256:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
					}
					
					
					case 1483687941:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.loaded;
					}
					
					
					case 2144012733:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.complite;
					}
					
					
					case 103479213:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.progress;
					}
					
					
					case 1373469718:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.complites;
					}
					
					
					case 338842564:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.total;
					}
					
					
					case 271358105:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.totalActions;
					}
					
					
					case 1731068925:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.actions;
					}
					
					
					case 399259966:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.beginWait;
					}
					
					
					case 1042925606:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.intensivity;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				switch (hash)
				{
					case 1373469718:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((double) (this.complites) );
					}
					
					
					case 338842564:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((double) (this.total) );
					}
					
					
					case 271358105:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((double) (this.totalActions) );
					}
					
					
					case 399259966:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((double) (this.beginWait) );
					}
					
					
					case 1042925606:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return ((double) (this.intensivity) );
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				switch (hash)
				{
					case 1579254431:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.fastEnd();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 1315598519:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.addAction(((global::haxe.lang.Function) (dynargs[0]) ));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 5047259:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.end();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 221002537:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.counterPercent();
					}
					
					
					case 802823687:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return this.listPercent();
					}
					
					
					case 117802505:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.update();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 810936873:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.begin();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 1324505717:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.wait();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 1135985308:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.fast();
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					case 1169898256:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						this.init(global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[0]));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						break;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("loaded");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("complite");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("progress");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("complites");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("total");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("totalActions");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("actions");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("beginWait");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				baseArr.push("intensivity");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Loader.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



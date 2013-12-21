
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Timer : global::pony.events.Signal 
	{
		public    Timer(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    Timer(int delay, global::haxe.lang.Null<bool> autoStart) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				global::pony.Timer.__hx_ctor_pony_Timer(this, delay, autoStart);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_Timer(global::pony.Timer __temp_me99, int delay, global::haxe.lang.Null<bool> autoStart)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				bool __temp_autoStart98 = ( (global::haxe.lang.Runtime.eq((autoStart).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (autoStart.@value) );
				global::pony.events.Signal.__hx_ctor_pony_events_Signal(__temp_me99, default(object));
				__temp_me99.delay = delay;
				if (__temp_autoStart98) 
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					__temp_me99.start();
				}
				
			}
			#line default
		}
		
		
		public static   global::pony.Timer tick(int delay)
		{
			unchecked 
			{
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				{
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					global::Array<int> count = new global::Array<int>(new int[]{1});
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					global::pony.Timer _this = new global::pony.Timer(((int) (delay) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) ));
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{_this});
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					object __temp_stmt484 = default(object);
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					{
						#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						object f = global::pony._Function.Function_Impl_.@from(new global::pony.Timer_tick_81__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (count) ))) )), 0);
						#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						__temp_stmt484 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					_this.@add(__temp_stmt484, new global::haxe.lang.Null<int>(10000, true));
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					return _this;
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return new global::pony.Timer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return new global::pony.Timer(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[1]));
			}
			#line default
		}
		
		
		public  int delay;
		
		public  global::haxe.Timer t;
		
		public virtual   global::pony.Timer start()
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.stop();
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.t = new global::haxe.Timer(((int) (this.delay) ));
				this.t.run = ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("run"), ((int) (5695307) ))) );
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return this;
			}
			#line default
		}
		
		
		public virtual   void run()
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.Timer __temp_expr482 = this;
			}
			#line default
		}
		
		
		public virtual   global::pony.Timer stop()
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				if (( this.t != default(global::haxe.Timer) )) 
				{
					this.t.stop();
					this.t = default(global::haxe.Timer);
				}
				
				#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return this;
			}
			#line default
		}
		
		
		public   void clear()
		{
			unchecked 
			{
				#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.stop();
				this.removeAllListeners();
			}
			#line default
		}
		
		
		public   global::pony.Timer setTickCount(int count)
		{
			unchecked 
			{
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				global::Array<int> count1 = new global::Array<int>(new int[]{count});
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{this});
				object __temp_stmt483 = default(object);
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				{
					#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					object f = global::pony._Function.Function_Impl_.@from(new global::pony.Timer_setTickCount_76__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (count1) ))) )), 0);
					#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					__temp_stmt483 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.@add(__temp_stmt483, new global::haxe.lang.Null<int>(10000, true));
				return this;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				switch (hash)
				{
					case 1462163331:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						this.delay = ((int) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				switch (hash)
				{
					case 116:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						this.t = ((global::haxe.Timer) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return @value;
					}
					
					
					case 1462163331:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						this.delay = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				switch (hash)
				{
					case 1777426480:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setTickCount"), ((int) (1777426480) ))) );
					}
					
					
					case 1213952397:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("clear"), ((int) (1213952397) ))) );
					}
					
					
					case 1281093634:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("stop"), ((int) (1281093634) ))) );
					}
					
					
					case 5695307:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("run"), ((int) (5695307) ))) );
					}
					
					
					case 67859554:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("start"), ((int) (67859554) ))) );
					}
					
					
					case 116:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return this.t;
					}
					
					
					case 1462163331:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return this.delay;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				switch (hash)
				{
					case 1462163331:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return ((double) (this.delay) );
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				switch (hash)
				{
					case 1777426480:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return this.setTickCount(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1213952397:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						this.clear();
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						break;
					}
					
					
					case 1281093634:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return this.stop();
					}
					
					
					case 5695307:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						this.run();
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						break;
					}
					
					
					case 67859554:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return this.start();
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				baseArr.push("t");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				baseArr.push("delay");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				{
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Timer_setTickCount_76__Fun : global::haxe.lang.Function 
	{
		public    Timer_setTickCount_76__Fun(global::Array<object> _g, global::Array<int> count1) : base(0, 0)
		{
			unchecked 
			{
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this._g = _g;
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.count1 = count1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				if ((  -- this.count1[0] == 0 )) 
				{
					#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					((global::pony.Timer) (this._g[0]) ).stop();
					#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					((global::pony.Timer) (this._g[0]) ).removeAllListeners();
				}
				
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<int> count1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Timer_tick_81__Fun : global::haxe.lang.Function 
	{
		public    Timer_tick_81__Fun(global::Array<object> _g, global::Array<int> count) : base(0, 0)
		{
			unchecked 
			{
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this._g = _g;
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				this.count = count;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				if ((  -- this.count[0] == 0 )) 
				{
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					((global::pony.Timer) (this._g[0]) ).stop();
					#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
					((global::pony.Timer) (this._g[0]) ).removeAllListeners();
				}
				
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Timer.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<int> count;
		
	}
}




#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  class SwitchableList : global::haxe.lang.HxObject, global::pony.IWards 
	{
		public    SwitchableList(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    SwitchableList(global::Array<object> a, global::haxe.lang.Null<int> def, global::haxe.lang.Null<int> swto)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				global::pony.ui.SwitchableList.__hx_ctor_pony_ui_SwitchableList(this, a, def, swto);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_ui_SwitchableList(global::pony.ui.SwitchableList __temp_me127, global::Array<object> a, global::haxe.lang.Null<int> def, global::haxe.lang.Null<int> swto)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				int __temp_swto126 = ( (global::haxe.lang.Runtime.eq((swto).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (2) )) : (swto.@value) );
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				int __temp_def125 = ( (global::haxe.lang.Runtime.eq((def).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (def.@value) );
				__temp_me127.swto = __temp_swto126;
				__temp_me127.currentPos = __temp_def125;
				__temp_me127.change = __temp_me127.@select = new global::pony.events.Signal(((object) (__temp_me127) ));
				__temp_me127.list = a;
				{
					#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					int _g1 = 0;
					#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					int _g = a.length;
					#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					while (( _g1 < _g ))
					{
						#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						int i = _g1++;
						if (( i == __temp_def125 )) 
						{
							#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
							((global::pony.ui.ButtonCore) (a[i]) )._set_mode(__temp_swto126);
						}
						
						{
							#line 191 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal s = ((global::pony.ui.ButtonCore) (a[i]) ).click.subArgs(new global::Array<object>(new object[]{new global::Array<object>(new object[]{0}), new global::Array<object>(new object[]{i})}));
							#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
							global::pony.events.Signal _this = __temp_me127.@select;
							#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
							s.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (_this) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
							#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
							global::pony.events.Signal __temp_expr618 = _this;
						}
						
					}
					
				}
				
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				object __temp_stmt619 = default(object);
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				{
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me127) ), global::haxe.lang.Runtime.toString("setState"), ((int) (306175759) ))) ), 1);
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					__temp_stmt619 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				__temp_me127.@select.@add(__temp_stmt619, new global::haxe.lang.Null<int>(-1, true));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				return new global::pony.ui.SwitchableList(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				return new global::pony.ui.SwitchableList(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (arr[0]) ))) ), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[2]));
			}
			#line default
		}
		
		
		public  global::pony.events.Signal change;
		
		public  int currentPos;
		
		public  global::Array<object> list;
		
		public  global::pony.events.Signal @select;
		
		public  int swto;
		
		public virtual   void setState(int n)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				((global::pony.ui.ButtonCore) (this.list[this.currentPos]) )._set_mode(0);
				((global::pony.ui.ButtonCore) (this.list[n]) )._set_mode(this.swto);
				this.currentPos = n;
			}
			#line default
		}
		
		
		public virtual   void next()
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				if (( ( this.currentPos + 1 ) < this.list.length )) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.@select;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( this.currentPos + 1 )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr616 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void prev()
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				if (( ( this.currentPos - 1 ) >= 0 )) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.@select;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( this.currentPos - 1 )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr617 = _this;
				}
				
			}
			#line default
		}
		
		
		public   int _get_state()
		{
			unchecked 
			{
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				return this.currentPos;
			}
			#line default
		}
		
		
		public   int _set_state(int v)
		{
			unchecked 
			{
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				return this.currentPos = v;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				switch (hash)
				{
					case 1281243935:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.swto = ((int) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 67859985:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this._set_state(((int) (@value) ));
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 1194336987:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.currentPos = ((int) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				switch (hash)
				{
					case 1281243935:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.swto = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 1781734140:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.@select = ((global::pony.events.Signal) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 67859985:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this._set_state(((int) (global::haxe.lang.Runtime.toInt(@value)) ));
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 1202920542:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.list = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 1194336987:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.currentPos = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					case 930255216:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.change = ((global::pony.events.Signal) (@value) );
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return @value;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				switch (hash)
				{
					case 721796724:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_state"), ((int) (721796724) ))) );
					}
					
					
					case 1203032680:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_state"), ((int) (1203032680) ))) );
					}
					
					
					case 1247723251:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("prev"), ((int) (1247723251) ))) );
					}
					
					
					case 1224901875:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("next"), ((int) (1224901875) ))) );
					}
					
					
					case 306175759:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setState"), ((int) (306175759) ))) );
					}
					
					
					case 1281243935:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this.swto;
					}
					
					
					case 1781734140:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this.@select;
					}
					
					
					case 67859985:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this._get_state();
					}
					
					
					case 1202920542:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this.list;
					}
					
					
					case 1194336987:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this.currentPos;
					}
					
					
					case 930255216:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this.change;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				switch (hash)
				{
					case 1281243935:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((double) (this.swto) );
					}
					
					
					case 67859985:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((double) (this._get_state()) );
					}
					
					
					case 1194336987:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return ((double) (this.currentPos) );
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
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
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				switch (hash)
				{
					case 721796724:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this._set_state(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1203032680:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return this._get_state();
					}
					
					
					case 1247723251:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.prev();
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						break;
					}
					
					
					case 1224901875:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.next();
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						break;
					}
					
					
					case 306175759:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						this.setState(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						break;
					}
					
					
					default:
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("swto");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("select");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("state");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("list");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("currentPos");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				baseArr.push("change");
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
				{
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/SwitchableList.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public   int state
		{
			get { return _get_state(); }
			set { _set_state(value); }
		}
	}
}



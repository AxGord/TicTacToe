
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  class FocusManager : global::haxe.lang.HxObject 
	{
		static FocusManager() 
		{
			#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
			global::pony.ui.FocusManager.list = new global::haxe.ds.StringMap<object>();
		}
		public    FocusManager(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    FocusManager()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				global::pony.ui.FocusManager.__hx_ctor_pony_ui_FocusManager(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_ui_FocusManager(global::pony.ui.FocusManager __temp_me124)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  global::haxe.ds.StringMap<object> list;
		
		public static  global::pony.ui.IFocus current;
		
		public static   void reg(global::pony.ui.IFocus o)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				if ( ! (global::pony.ui.FocusManager.list.exists(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(o, "focusGroup", 1549161543, true)))) ) 
				{
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.Priority<object> @value = new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (default(global::Array<object>)) ))) ));
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.ui.FocusManager.list.@set(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(o, "focusGroup", 1549161543, true)), @value);
				}
				
				global::pony.Priority<object> g = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(o, "focusGroup", 1549161543, true))).@value) ))) );
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				g.addElement(o, global::haxe.lang.Null<object>.ofDynamic<int>(global::haxe.lang.Runtime.getField(o, "focusPriority", 1545678684, false)));
				#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				{
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object listener = default(object);
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_stmt601 = default(object);
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					{
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						object l = default(object);
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						{
							#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.ui.FocusManager)) ), global::haxe.lang.Runtime.toString("newFocus"), ((int) (668181336) ))) ), 2);
							#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						__temp_stmt601 = l;
					}
					
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					listener = ((object) (__temp_stmt601) );
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.events.Signal this1 = ((global::pony.events.Signal) (global::haxe.lang.Runtime.getField(o, "focus", 76111832, true)) );
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(-5, true));
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_expr602 = this1.target;
				}
				
			}
			#line default
		}
		
		
		public static   void unreg(global::pony.ui.IFocus o)
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(o, "focusGroup", 1549161543, true))).@value) ))) ).removeElement(o);
				{
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object listener = default(object);
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_stmt603 = default(object);
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					{
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						object l = default(object);
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						{
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.ui.FocusManager)) ), global::haxe.lang.Runtime.toString("newFocus"), ((int) (668181336) ))) ), 2);
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						__temp_stmt603 = l;
					}
					
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					listener = ((object) (__temp_stmt603) );
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.events.Signal this1 = ((global::pony.events.Signal) (global::haxe.lang.Runtime.getField(o, "focus", 76111832, true)) );
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					this1.@remove(((object) (listener) ));
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_expr604 = this1.target;
				}
				
			}
			#line default
		}
		
		
		public static   void newFocus(bool b, global::pony.ui.IFocus o)
		{
			unchecked 
			{
				#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				if (b) 
				{
					if (( global::pony.ui.FocusManager.current != default(global::pony.ui.IFocus) )) 
					{
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						global::pony.events.Signal this1 = ((global::pony.events.Signal) (global::haxe.lang.Runtime.getField(global::pony.ui.FocusManager.current, "focus", 76111832, true)) );
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						{
							#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<bool>(new bool[]{false})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							global::pony.events.Signal __temp_expr605 = this1;
						}
						
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						object __temp_expr606 = this1.target;
					}
					
					global::pony.ui.FocusManager.current = o;
					{
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						global::pony.Priority<object> _this = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(global::pony.ui.FocusManager.current, "focusGroup", 1549161543, true))).@value) ))) );
						#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						while (( ((global::pony.ui.IFocus) (_this.loop()) ) != o ))
						{
							#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
							object __temp_expr607 = default(object);
						}
						
					}
					
				}
				 else 
				{
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					if (( global::pony.ui.FocusManager.current == o )) 
					{
						#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						global::pony.ui.FocusManager.current = default(global::pony.ui.IFocus);
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   void selectGroup(string name)
		{
			unchecked 
			{
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				if (string.Equals(name, default(string))) 
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					name = "";
				}
				
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				global::pony.ui.IFocus __temp_stmt609 = default(global::pony.ui.IFocus);
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.Priority<object> _this = ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(name).@value) ))) );
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					__temp_stmt609 = ((global::pony.ui.IFocus) (_this.data[0]) );
				}
				
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				object __temp_stmt608 = global::haxe.lang.Runtime.getField(__temp_stmt609, "focus", 76111832, true);
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				global::pony.events.Signal this1 = ((global::pony.events.Signal) (__temp_stmt608) );
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<bool>(new bool[]{true})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.events.Signal __temp_expr610 = this1;
				}
				
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				object __temp_expr611 = this1.target;
			}
			#line default
		}
		
		
		public static   global::pony.ui.IFocus next()
		{
			unchecked 
			{
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				if (( global::pony.ui.FocusManager.current == default(global::pony.ui.IFocus) )) 
				{
					#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					return default(global::pony.ui.IFocus);
				}
				
				global::pony.ui.IFocus e = ((global::pony.ui.IFocus) (((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(global::pony.ui.FocusManager.current, "focusGroup", 1549161543, true))).@value) ))) ).loop()) );
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.events.Signal this1 = ((global::pony.events.Signal) (global::haxe.lang.Runtime.getField(e, "focus", 76111832, true)) );
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					{
						#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<bool>(new bool[]{true})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						global::pony.events.Signal __temp_expr612 = this1;
					}
					
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_expr613 = this1.target;
				}
				
				return e;
			}
			#line default
		}
		
		
		public static   global::pony.ui.IFocus prev()
		{
			unchecked 
			{
				#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				if (( global::pony.ui.FocusManager.current == default(global::pony.ui.IFocus) )) 
				{
					#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					return default(global::pony.ui.IFocus);
				}
				
				global::pony.ui.IFocus e = ((global::pony.ui.IFocus) (((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(global::pony.ui.FocusManager.current, "focusGroup", 1549161543, true))).@value) ))) ).backLoop()) );
				{
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					global::pony.events.Signal this1 = ((global::pony.events.Signal) (global::haxe.lang.Runtime.getField(e, "focus", 76111832, true)) );
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					{
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<bool>(new bool[]{true})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
						global::pony.events.Signal __temp_expr614 = this1;
					}
					
					#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
					object __temp_expr615 = this1.target;
				}
				
				return e;
			}
			#line default
		}
		
		
		public static   global::pony.Priority<object> _get_p()
		{
			unchecked 
			{
				#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				return ((global::pony.Priority<object>) (global::pony.Priority<object>.__hx_cast<object>(((global::pony.Priority) (global::pony.ui.FocusManager.list.@get(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(global::pony.ui.FocusManager.current, "focusGroup", 1549161543, true))).@value) ))) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				return new global::pony.ui.FocusManager(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/FocusManager.hx"
				return new global::pony.ui.FocusManager();
			}
			#line default
		}
		
		
		public static   global::pony.Priority<object> p
		{
			get { return _get_p(); }
		}
	}
}



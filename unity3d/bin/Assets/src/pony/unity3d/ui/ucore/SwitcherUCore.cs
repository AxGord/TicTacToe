
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class SwitcherUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    SwitcherUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    SwitcherUCore() : base()
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				this.@select = new global::pony.events.Signal(((object) (default(object)) ));
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				return new global::pony.unity3d.ui.ucore.SwitcherUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				return new global::pony.unity3d.ui.ucore.SwitcherUCore();
			}
			#line default
		}
		
		
		public  global::pony.events.Signal @select;
		
		public  global::pony.ui.SwitchableList core;
		
		public  global::Array<object> names;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				global::hugs.NativeArrayIterator<object> a = global::hugs.ComponentMethods.getComponentsInChildrenOfType<object>(this, typeof(global::pony.unity3d.ui.TintButton), default(global::haxe.lang.Null<bool>));
				{
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{});
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					{
						#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator255 = a;
						#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						while (__temp_iterator255.hasNext())
						{
							#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
							global::pony.unity3d.ui.TintButton e = ((global::pony.unity3d.ui.TintButton) (__temp_iterator255.next()) );
							#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
							_g.push(e.name);
						}
						
					}
					
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					this.names = _g;
				}
				
				a.i = 0;
				global::Array<object> __temp_stmt759 = default(global::Array<object>);
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				{
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					global::Array<object> _g1 = new global::Array<object>(new object[]{});
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					{
						#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator256 = a;
						#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						while (__temp_iterator256.hasNext())
						{
							#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
							global::pony.unity3d.ui.TintButton e1 = ((global::pony.unity3d.ui.TintButton) (__temp_iterator256.next()) );
							#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
							_g1.push(e1.core);
						}
						
					}
					
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					__temp_stmt759 = _g1;
				}
				
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				object __temp_stmt758 = global::Array<object>.__hx_cast<object>(((global::Array) (__temp_stmt759) ));
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				this.core = new global::pony.ui.SwitchableList(((global::Array<object>) (__temp_stmt758) ), new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(1, true));
				object __temp_stmt760 = default(object);
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				{
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) ), 1);
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					__temp_stmt760 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				this.core.@select.@add(__temp_stmt760, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public virtual   void sw(int n)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.@select;
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{global::haxe.lang.Runtime.toString(this.names[n])})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr761 = _this;
			}
			#line default
		}
		
		
		public virtual   void @set(string name)
		{
			unchecked 
			{
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				this.sw(global::Lambda.indexOf<object>(this.names, name));
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				if (isCheck) 
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					if (throwErrors) 
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return default(object);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				if (throwErrors) 
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.active = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 377786312:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.names = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 1103412575:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.core = ((global::pony.ui.SwitchableList) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					case 1781734140:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.@select = ((global::pony.events.Signal) (@value) );
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 5741474:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sw"), ((int) (25764) ))) );
					}
					
					
					case 389604418:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 377786312:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.names;
					}
					
					
					case 1103412575:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.core;
					}
					
					
					case 1781734140:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.@select;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 5741474:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.@set(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						break;
					}
					
					
					case 25764:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.sw(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						this.Start();
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("hideFlags");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("name");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("tag");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("active");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("gameObject");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("particleSystem");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("particleEmitter");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("hingeJoint");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("collider");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("guiTexture");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("guiElement");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("networkView");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("guiText");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("audio");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("renderer");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("constantForce");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("animation");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("light");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("camera");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("rigidbody");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("transform");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("enabled");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("useGUILayout");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("names");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("core");
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/SwitcherUCore.hx"
				baseArr.push("select");
			}
			#line default
		}
		
		
	}
}



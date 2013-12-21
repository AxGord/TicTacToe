
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class Button : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    Button(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    Button() : base()
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.prevState = false;
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.tooltip = "";
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.panel = true;
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.defaultMode = 0;
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.core = new global::pony.ui.ButtonCore();
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return new global::pony.unity3d.ui.Button(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return new global::pony.unity3d.ui.Button();
			}
			#line default
		}
		
		
		public  int defaultMode;
		
		public  bool panel;
		
		public  string tooltip;
		
		public  int[] autoSwith;
		
		public  global::pony.ui.ButtonCore core;
		
		public  bool prevState;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				global::Array<object> _g1 = new global::Array<object>(new object[]{this});
				global::Array<int> __temp_stmt686 = default(global::Array<int>);
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				{
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					global::Array<int> _g = new global::Array<int>(new int[]{});
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						global::hugs.NativeArrayIterator<int> __temp_iterator249 = new global::hugs.NativeArrayIterator<int>(((int[]) (this.autoSwith) ));
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						while (__temp_iterator249.hasNext())
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							int v = __temp_iterator249.next();
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							_g.push(v);
						}
						
					}
					
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					__temp_stmt686 = _g;
				}
				
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this.core._set_sw(__temp_stmt686);
				if ( ! (string.Equals(this.tooltip, "")) ) 
				{
					object __temp_stmt687 = default(object);
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) ), 0);
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt687 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus})).@add(__temp_stmt687, default(global::haxe.lang.Null<int>));
					object __temp_stmt688 = default(object);
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt688 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default})).@add(__temp_stmt688, default(global::haxe.lang.Null<int>));
					object __temp_stmt689 = default(object);
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt689 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
					}
					
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press})).@add(__temp_stmt689, default(global::haxe.lang.Null<int>));
					object __temp_stmt690 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt690 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.change.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave})).@add(__temp_stmt690, default(global::haxe.lang.Null<int>));
				}
				
				#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				{
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					object listener = default(object);
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					object __temp_stmt691 = default(object);
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object l = default(object);
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						{
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							object f4 = global::pony._Function.Function_Impl_.@from(new global::pony.unity3d.ui.Button_Start_70__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g1) ))) )), 0);
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f4, false);
						}
						
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						__temp_stmt691 = l;
					}
					
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					listener = ((object) (__temp_stmt691) );
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.fixedUpdate;
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					{
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						int priority = 0;
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object listener1 = ((object) (listener) );
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						object __temp_stmt692 = default(object);
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						{
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							object f5 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							object this2 = default(object);
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							{
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								object __temp_getvar250 = f5;
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								double __temp_ret251 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar250, "used", 1303220797, true)) );
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								object __temp_expr693 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar250, "used", 1303220797, ( __temp_ret251 + 1.0 ))) );
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								double __temp_expr694 = __temp_ret251;
							}
							
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							{
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								bool __temp_odecl684 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								bool __temp_odecl685 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
								#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
								this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f5, __temp_odecl685, true, default(global::pony.events.Event), __temp_odecl684}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
							}
							
							#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
							__temp_stmt692 = this2;
						}
						
						#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this1.@add(((object) (__temp_stmt692) ), new global::haxe.lang.Null<int>(priority, true));
					}
					
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					object __temp_expr695 = this1.target;
				}
				
			}
			#line default
		}
		
		
		public virtual   void @out()
		{
			unchecked 
			{
				#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				global::pony.unity3d.Tooltip.hideText(this);
			}
			#line default
		}
		
		
		public virtual   void over()
		{
			unchecked 
			{
				#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				global::pony.unity3d.Tooltip.showText(this.tooltip, "", this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), new global::haxe.lang.Null<bool>(true, true));
			}
			#line default
		}
		
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				bool h = default(bool);
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (( this.panel ||  ! (global::pony.unity3d.Fixed2dCamera.exists)  )) 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x - global::pony.unity3d.Fixed2dCamera.begin )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				 else 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x + ( ((double) ((( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.begin ))) ) / 2 ) )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				
				bool down = global::UnityEngine.Input.GetMouseButton(0);
				if (( this.prevState != h )) 
				{
					if (h) 
					{
						#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.core.mouseOver(down);
					}
					 else 
					{
						this.core.mouseOut();
					}
					
					this.prevState = h;
				}
				
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (down) 
				{
					#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					this.core.mouseDown();
				}
				 else 
				{
					this.core.mouseUp();
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (isCheck) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					if (throwErrors) 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				if (throwErrors) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 438291652:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.defaultMode = ((int) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.active = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.enabled = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1868699166:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.prevState = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1103412575:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.core = ((global::pony.ui.ButtonCore) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1679321610:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.autoSwith = ((int[]) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1787604227:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.tooltip = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 1028815620:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.panel = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					case 438291652:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.defaultMode = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return @value;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.useGUILayout;
					}
					
					
					case 999946793:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 1236832596:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) );
					}
					
					
					case 5546126:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) );
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1868699166:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.prevState;
					}
					
					
					case 1103412575:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.core;
					}
					
					
					case 1679321610:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.autoSwith;
					}
					
					
					case 1787604227:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.tooltip;
					}
					
					
					case 1028815620:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.panel;
					}
					
					
					case 438291652:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return this.defaultMode;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 438291652:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((double) (this.defaultMode) );
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 999946793:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.Update();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 1236832596:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.over();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 5546126:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.@out();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						this.Start();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						break;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("hideFlags");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("name");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("tag");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("active");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("gameObject");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("particleSystem");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("particleEmitter");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("hingeJoint");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("collider");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiTexture");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiElement");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("networkView");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("guiText");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("audio");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("renderer");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("constantForce");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("animation");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("light");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("camera");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("rigidbody");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("transform");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("enabled");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("useGUILayout");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("prevState");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("core");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("autoSwith");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("tooltip");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("panel");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				baseArr.push("defaultMode");
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class Button_Start_70__Fun : global::haxe.lang.Function 
	{
		public    Button_Start_70__Fun(global::Array<object> _g1) : base(0, 0)
		{
			unchecked 
			{
				#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				this._g1 = _g1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				((global::pony.unity3d.ui.Button) (this._g1[0]) ).core._set_mode(((global::pony.unity3d.ui.Button) (this._g1[0]) ).defaultMode);
				#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/Button.hx"
				return default(object);
			}
			#line default
		}
		
		
		public  global::Array<object> _g1;
		
	}
}



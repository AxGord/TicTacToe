
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class InputUCore : global::pony.unity3d.ui.TintButton, global::pony.ui.IFocus 
	{
		static InputUCore() 
		{
			#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
			global::pony.unity3d.ui.ucore.InputUCore.caretTime = 0.5;
			global::pony.unity3d.ui.ucore.InputUCore.ct = ((double) (0) );
			global::pony.unity3d.ui.ucore.InputUCore.cb = false;
		}
		public    InputUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    InputUCore() : base()
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.focusGroup = "";
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.focusPriority = 0;
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.max = 0;
				#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.changed = new global::pony.events.Signal(((object) (this) ));
				{
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					global::pony.events.Signal this1 = global::pony.events.Signal.create<object>(this);
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					this.focus = ((global::pony.events.Signal) (this1) );
				}
				
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					int priority = 0;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					object listener = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					object __temp_stmt736 = default(object);
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						object l = default(object);
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("onFocus"), ((int) (449248825) ))) ), 1);
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						__temp_stmt736 = l;
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					listener = ((object) (__temp_stmt736) );
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					global::pony.events.Signal this2 = this.focus;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					this2.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					object __temp_expr737 = this2.target;
				}
				
				object __temp_stmt738 = default(object);
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					global::haxe.lang.Function __temp_stmt739 = default(global::haxe.lang.Function);
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					{
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						global::haxe.lang.Function __temp_stmt740 = default(global::haxe.lang.Function);
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						{
							#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							global::Array<object> _e = new global::Array<object>(new object[]{this.focus});
							#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							__temp_stmt740 = new global::pony.unity3d.ui.ucore.InputUCore_new_69__Fun_0(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_e) ))) ));
						}
						
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						global::Array<object> f2 = new global::Array<object>(new object[]{__temp_stmt740});
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						__temp_stmt739 = new global::pony.unity3d.ui.ucore.InputUCore_new_69__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
					}
					
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					object f1 = global::pony._Function.Function_Impl_.@from(__temp_stmt739, 0);
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					__temp_stmt738 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
				}
				
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.core.click.subArgs(new global::Array<object>(new object[]{0})).@add(__temp_stmt738, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public static  double caretTime;
		
		public static  double ct;
		
		public static  bool cb;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return new global::pony.unity3d.ui.ucore.InputUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return new global::pony.unity3d.ui.ucore.InputUCore();
			}
			#line default
		}
		
		
		public  string text;
		
		public  int max;
		
		public  int focusPriority;
		
		public  string focusGroup;
		
		public  global::pony.events.Signal focus;
		
		public  global::pony.events.Signal changed;
		
		public  bool selected;
		
		public virtual   void onFocus(bool b)
		{
			unchecked 
			{
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.selected = b;
				this.core._set_mode(( (b) ? (2) : (0) ));
				if ( ! (b) ) 
				{
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).text = this.text;
				}
				
			}
			#line default
		}
		
		
		public override   void Start()
		{
			unchecked 
			{
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				base.Start();
				this.text = ((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).text;
				global::pony.ui.FocusManager.reg(this);
			}
			#line default
		}
		
		
		public   global::UnityEngine.GUIText _get_gt()
		{
			unchecked 
			{
				#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return ((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) );
			}
			#line default
		}
		
		
		public override   void Update()
		{
			unchecked 
			{
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				base.Update();
				if (this.selected) 
				{
					{
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						int _g = 0;
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						string _g1 = global::UnityEngine.Input.inputString;
						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						while (( _g < _g1.Length ))
						{
							#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							char ch = _g1[_g];
							#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							 ++ _g;
							this.core._set_mode(2);
							if (( ch == 13 )) 
							{
								this.core._set_mode(0);
								#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal _this = this.changed;
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.text})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal __temp_expr727 = _this;
								}
								
								#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
								continue;
							}
							
							#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
							if (( ch == 8 )) 
							{
								this.text = global::haxe.lang.StringExt.substr(this.text, 0, new global::haxe.lang.Null<int>(-1, true));
							}
							 else 
							{
								if (( ( this.max == 0 ) || ( this.text.Length < this.max ) )) 
								{
									global::pony.unity3d.ui.ucore.InputUCore __temp_dynop252 = this;
									#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
									__temp_dynop252.text = global::haxe.lang.Runtime.concat(__temp_dynop252.text, global::Std.@string(ch));
								}
								
							}
							
						}
						
					}
					
					#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					global::pony.unity3d.ui.ucore.InputUCore.ct += ((double) (global::UnityEngine.Time.deltaTime) );
					if (( global::pony.unity3d.ui.ucore.InputUCore.ct >= global::pony.unity3d.ui.ucore.InputUCore.caretTime )) 
					{
						global::pony.unity3d.ui.ucore.InputUCore.ct -= global::pony.unity3d.ui.ucore.InputUCore.caretTime;
						global::pony.unity3d.ui.ucore.InputUCore.cb =  ! (global::pony.unity3d.ui.ucore.InputUCore.cb) ;
					}
					
					#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					if (global::pony.unity3d.ui.ucore.InputUCore.cb) 
					{
						#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).text = global::haxe.lang.Runtime.concat(this.text, "|");
					}
					 else 
					{
						#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).text = this.text;
					}
					
				}
				 else 
				{
					((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).text = this.text;
				}
				
			}
			#line default
		}
		
		
		public   int _get_y()
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					double x = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.y) ));
					#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					return ((int) (x) );
				}
				
			}
			#line default
		}
		
		
		public virtual   int _set_y(int v)
		{
			unchecked 
			{
				#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				int __temp_stmt728 = default(int);
				#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					double x = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.y) ));
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					__temp_stmt728 = ((int) (x) );
				}
				
				#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				if (( __temp_stmt728 != v )) 
				{
					float __temp_stmt729 = ((float) (((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset.x) );
					#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					float __temp_stmt730 = ((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset.y;
					#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					int __temp_stmt731 = default(int);
					#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					{
						#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						double x1 = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.y) ));
						#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						__temp_stmt731 = ((int) (x1) );
					}
					
					#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset = new global::UnityEngine.Vector2(__temp_stmt729, ((float) (( ( __temp_stmt730 - __temp_stmt731 ) + v )) ));
					this.guiTexture.pixelInset = new global::UnityEngine.Rect(((float) (this.guiTexture.pixelInset.x) ), ((float) (v) ), ((float) (this.guiTexture.pixelInset.width) ), ((float) (this.guiTexture.pixelInset.height) ));
				}
				
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return v;
			}
			#line default
		}
		
		
		public   int _get_x()
		{
			unchecked 
			{
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					double x = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.x) ));
					#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					return ((int) (x) );
				}
				
			}
			#line default
		}
		
		
		public virtual   int _set_x(int v)
		{
			unchecked 
			{
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				int __temp_stmt732 = default(int);
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					double x = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.x) ));
					#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					__temp_stmt732 = ((int) (x) );
				}
				
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				if (( __temp_stmt732 != v )) 
				{
					float __temp_stmt733 = ((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset.x;
					#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					int __temp_stmt734 = default(int);
					#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					{
						#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						double x1 = global::System.Math.Ceiling(((double) (this.guiTexture.pixelInset.x) ));
						#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						__temp_stmt734 = ((int) (x1) );
					}
					
					#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					float __temp_stmt735 = ((float) (((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset.y) );
					#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					((global::UnityEngine.GUIText) (global::hugs.ComponentMethods.getComponentInChildrenOfType<object>(this, typeof(global::UnityEngine.GUIText))) ).pixelOffset = new global::UnityEngine.Vector2(((float) (( ( __temp_stmt733 - __temp_stmt734 ) + v )) ), __temp_stmt735);
					this.guiTexture.pixelInset = new global::UnityEngine.Rect(((float) (v) ), ((float) (this.guiTexture.pixelInset.y) ), ((float) (this.guiTexture.pixelInset.width) ), ((float) (this.guiTexture.pixelInset.height) ));
				}
				
				#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return v;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				switch (hash)
				{
					case 121:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this._set_y(((int) (@value) ));
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 120:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this._set_x(((int) (@value) ));
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 1545678684:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.focusPriority = ((int) (@value) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 5442212:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.max = ((int) (@value) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
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
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				switch (hash)
				{
					case 121:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this._set_y(((int) (global::haxe.lang.Runtime.toInt(@value)) ));
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 120:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this._set_x(((int) (global::haxe.lang.Runtime.toInt(@value)) ));
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 829237851:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.selected = ((bool) (@value) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 1288483060:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.changed = ((global::pony.events.Signal) (@value) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 76111832:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.focus = ((global::pony.events.Signal) (@value) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 1549161543:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.focusGroup = global::haxe.lang.Runtime.toString(@value);
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 1545678684:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.focusPriority = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 5442212:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.max = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					case 1291439277:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.text = global::haxe.lang.Runtime.toString(@value);
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
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
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				switch (hash)
				{
					case 2049940315:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_x"), ((int) (2049940315) ))) );
					}
					
					
					case 291546447:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_x"), ((int) (291546447) ))) );
					}
					
					
					case 2049940316:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_y"), ((int) (2049940316) ))) );
					}
					
					
					case 291546448:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_y"), ((int) (291546448) ))) );
					}
					
					
					case 999946793:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 590344566:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_gt"), ((int) (590344566) ))) );
					}
					
					
					case 389604418:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 449248825:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("onFocus"), ((int) (449248825) ))) );
					}
					
					
					case 23085:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_gt();
					}
					
					
					case 121:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_y();
					}
					
					
					case 120:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_x();
					}
					
					
					case 829237851:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.selected;
					}
					
					
					case 1288483060:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.changed;
					}
					
					
					case 76111832:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.focus;
					}
					
					
					case 1549161543:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.focusGroup;
					}
					
					
					case 1545678684:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.focusPriority;
					}
					
					
					case 5442212:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.max;
					}
					
					
					case 1291439277:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this.text;
					}
					
					
					default:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
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
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				switch (hash)
				{
					case 121:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((double) (this._get_y()) );
					}
					
					
					case 120:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((double) (this._get_x()) );
					}
					
					
					case 1545678684:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((double) (this.focusPriority) );
					}
					
					
					case 5442212:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return ((double) (this.max) );
					}
					
					
					default:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
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
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				switch (hash)
				{
					case 389604418:case 999946793:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 2049940315:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._set_x(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 291546447:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_x();
					}
					
					
					case 2049940316:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._set_y(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 291546448:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_y();
					}
					
					
					case 590344566:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return this._get_gt();
					}
					
					
					case 449248825:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						this.onFocus(((bool) (dynargs[0]) ));
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("gt");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("y");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("x");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("selected");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("changed");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("focus");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("focusGroup");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("focusPriority");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("max");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				baseArr.push("text");
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public   int x
		{
			get { return _get_x(); }
			set { _set_x(value); }
		}
		public   int y
		{
			get { return _get_y(); }
			set { _set_y(value); }
		}
		public   global::UnityEngine.GUIText gt
		{
			get { return _get_gt(); }
		}
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class InputUCore_new_69__Fun_0 : global::haxe.lang.Function 
	{
		public    InputUCore_new_69__Fun_0(global::Array<object> _e) : base(1, 0)
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this._e = _e;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				bool a = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((bool) (((object) (__fn_float1) )) )) : (((bool) (__fn_dyn1) )) );
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				{
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					{
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						((global::pony.events.Signal) (this._e[0]) ).dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<bool>(new bool[]{a})) ), ((object) (((global::pony.events.Signal) (this._e[0]) ).target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
						object __temp_expr741 = this._e[0];
					}
					
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
					return ((object) (((global::pony.events.Signal) (this._e[0]) ).target) );
				}
				
			}
			#line default
		}
		
		
		public  global::Array<object> _e;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class InputUCore_new_69__Fun : global::haxe.lang.Function 
	{
		public    InputUCore_new_69__Fun(global::Array<object> f2) : base(0, 0)
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/InputUCore.hx"
				return ((object) (((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke1_o(default(double), true)) );
			}
			#line default
		}
		
		
		public  global::Array<object> f2;
		
	}
}



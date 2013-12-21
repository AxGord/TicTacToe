
namespace pony.ui
{
	public enum ButtonStates
	{
		Default, Focus, Leave, Press
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  class ButtonCore : global::haxe.lang.HxObject 
	{
		static ButtonCore() 
		{
			#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
			global::pony.ui.ButtonCore.MOUSE_FOCUS = true;
			global::pony.ui.ButtonCore.tickDelay = 200;
			global::pony.ui.ButtonCore.tickFirstDelay = 600;
		}
		public    ButtonCore(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    ButtonCore()
		{
			unchecked 
			{
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				global::pony.ui.ButtonCore.__hx_ctor_pony_ui_ButtonCore(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_ui_ButtonCore(global::pony.ui.ButtonCore __temp_me123)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				__temp_me123.mouseState = global::pony.ui.ButtonStates.Default;
				__temp_me123.keyboardState = global::pony.ui.ButtonStates.Default;
				__temp_me123.tabState = global::pony.ui.ButtonStates.Default;
				__temp_me123.fakeState = global::pony.ui.ButtonStates.Default;
				__temp_me123.prevSummary = global::pony.ui.ButtonStates.Default;
				__temp_me123.prevVisual = global::pony.ui.ButtonStates.Default;
				__temp_me123.prevTab = false;
				__temp_me123.prevMode = __temp_me123._set_mode(0);
				__temp_me123.change = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.changeVisual = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.click = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.tick = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.down = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.up = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.onMode = new global::pony.events.Signal(((object) (default(object)) ));
				__temp_me123.change.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me123) ), global::haxe.lang.Runtime.toString("changeState"), ((int) (701570689) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				__temp_me123.waitUp = false;
			}
			#line default
		}
		
		
		public static  bool MOUSE_FOCUS;
		
		public static  int tickDelay;
		
		public static  int tickFirstDelay;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				return new global::pony.ui.ButtonCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				return new global::pony.ui.ButtonCore();
			}
			#line default
		}
		
		
		public  global::pony.ui.ButtonStates mouseState;
		
		public  global::pony.ui.ButtonStates tabState;
		
		public  global::pony.ui.ButtonStates keyboardState;
		
		public  global::pony.ui.ButtonStates fakeState;
		
		public  global::pony.ui.ButtonStates summaryState;
		
		public  global::pony.ui.ButtonStates visualState;
		
		public  global::pony.ui.ButtonStates prevSummary;
		
		public  global::pony.ui.ButtonStates prevVisual;
		
		public  bool prevTab;
		
		public  global::pony.Timer timer;
		
		public  int prevMode;
		
		public  bool waitUp;
		
		public  int mode;
		
		public  global::pony.events.Signal change;
		
		public  global::pony.events.Signal changeVisual;
		
		public  global::pony.events.Signal click;
		
		public  global::pony.events.Signal tick;
		
		public  global::pony.events.Signal down;
		
		public  global::pony.events.Signal up;
		
		public  global::pony.events.Signal @select;
		
		public  global::pony.events.Signal unselect;
		
		public  global::pony.events.Signal onMode;
		
		public  global::Array<int> sw;
		
		public virtual   int _set_mode(int v)
		{
			unchecked 
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.mode = v;
				this.update();
				return this.mode;
			}
			#line default
		}
		
		
		public virtual   void mouseOver(bool btnDown)
		{
			unchecked 
			{
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				global::pony.ui.ButtonStates _g = this.mouseState;
				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (global::Type.enumIndex(_g))
				{
					case 0:
					{
						#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if ( ! (btnDown) ) 
						{
							this.mouseState = global::pony.ui.ButtonStates.Focus;
							this.update();
						}
						 else 
						{
							#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.waitUp = true;
						}
						
						#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 2:
					{
						#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseState = global::pony.ui.ButtonStates.Press;
						this.update();
						#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					default:
					{
						#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						{
						}
						
						#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void mouseOut()
		{
			unchecked 
			{
				#line 119 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.waitUp = false;
				{
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g = this.mouseState;
					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 1:
						{
							#line 122 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mouseState = global::pony.ui.ButtonStates.Default;
							this.update();
							#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
						
						case 3:
						{
							#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mouseState = global::pony.ui.ButtonStates.Leave;
							this.update();
							#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
						
						default:
						{
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							{
							}
							
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void mouseUp()
		{
			unchecked 
			{
				#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g = this.mouseState;
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 0:
						{
							if (this.waitUp) 
							{
								this.mouseState = global::pony.ui.ButtonStates.Focus;
								this.update();
							}
							 else 
							{
								#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								{
								}
								
							}
							
							break;
						}
						
						
						case 2:
						{
							#line 137 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mouseState = global::pony.ui.ButtonStates.Default;
							this.update();
							#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
						
						case 3:
						{
							#line 140 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mouseState = global::pony.ui.ButtonStates.Focus;
							this.update();
							#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
						
						default:
						{
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							{
							}
							
							#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
					}
					
				}
				
				#line 144 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.waitUp = false;
			}
			#line default
		}
		
		
		public virtual   void mouseDown()
		{
			unchecked 
			{
				#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.mouseState != global::pony.ui.ButtonStates.Focus )) 
				{
					#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.mouseState = global::pony.ui.ButtonStates.Press;
				this.update();
			}
			#line default
		}
		
		
		public virtual   void setFocus()
		{
			unchecked 
			{
				#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.tabState != global::pony.ui.ButtonStates.Default )) 
				{
					#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.tabState = global::pony.ui.ButtonStates.Focus;
				this.update();
			}
			#line default
		}
		
		
		public virtual   void leaveFocus()
		{
			unchecked 
			{
				#line 160 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.tabState != global::pony.ui.ButtonStates.Default )) 
				{
					#line 160 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.tabState = global::pony.ui.ButtonStates.Default;
				this.update();
			}
			#line default
		}
		
		
		public virtual   void enterDown()
		{
			unchecked 
			{
				#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.tabState != global::pony.ui.ButtonStates.Focus )) 
				{
					#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.tabState = global::pony.ui.ButtonStates.Press;
				this.update();
			}
			#line default
		}
		
		
		public virtual   void enterUp()
		{
			unchecked 
			{
				#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.tabState != global::pony.ui.ButtonStates.Press )) 
				{
					#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.tabState = global::pony.ui.ButtonStates.Press;
				this.update();
			}
			#line default
		}
		
		
		public virtual   void keyDown()
		{
			unchecked 
			{
				#line 178 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.keyboardState != global::pony.ui.ButtonStates.Default )) 
				{
					#line 178 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.keyboardState = global::pony.ui.ButtonStates.Press;
			}
			#line default
		}
		
		
		public virtual   void keyUp()
		{
			unchecked 
			{
				#line 183 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.keyboardState != global::pony.ui.ButtonStates.Press )) 
				{
					#line 183 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					return ;
				}
				
				this.keyboardState = global::pony.ui.ButtonStates.Default;
			}
			#line default
		}
		
		
		public virtual   global::pony.ui.ButtonStates _get_summaryState()
		{
			unchecked 
			{
				#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g = this.mouseState;
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g1 = this.tabState;
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g2 = this.keyboardState;
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 2:
						{
							#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							global::pony.ui.ButtonStates b = _g2;
							#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							global::pony.ui.ButtonStates a = _g1;
							if (( ( a != global::pony.ui.ButtonStates.Press ) && ( b != global::pony.ui.ButtonStates.Press ) )) 
							{
								#line 189 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								return global::pony.ui.ButtonStates.Leave;
							}
							 else 
							{
								#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								switch (global::Type.enumIndex(_g2))
								{
									case 3:
									{
										#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Press;
									}
									
									
									default:
									{
										#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										switch (global::Type.enumIndex(_g1))
										{
											case 3:
											{
												#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												return global::pony.ui.ButtonStates.Press;
											}
											
											
											default:
											{
												#line 192 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												return global::pony.ui.ButtonStates.Default;
											}
											
										}
										
									}
									
								}
								
							}
							
						}
						
						
						case 3:
						{
							#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g2))
							{
								case 3:
								{
									#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								default:
								{
									#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									switch (global::Type.enumIndex(_g1))
									{
										case 3:
										{
											#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											return global::pony.ui.ButtonStates.Press;
										}
										
										
										default:
										{
											#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											return global::pony.ui.ButtonStates.Press;
										}
										
									}
									
								}
								
							}
							
						}
						
						
						case 1:
						{
							#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g2))
							{
								case 3:
								{
									#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								default:
								{
									#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									switch (global::Type.enumIndex(_g1))
									{
										case 3:
										{
											#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											return global::pony.ui.ButtonStates.Press;
										}
										
										
										default:
										{
											return global::pony.ui.ButtonStates.Focus;
										}
										
									}
									
								}
								
							}
							
						}
						
						
						default:
						{
							#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g2))
							{
								case 3:
								{
									#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								default:
								{
									#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									switch (global::Type.enumIndex(_g1))
									{
										case 3:
										{
											#line 190 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											return global::pony.ui.ButtonStates.Press;
										}
										
										
										default:
										{
											#line 192 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											return global::pony.ui.ButtonStates.Default;
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   global::pony.ui.ButtonStates _get_visualState()
		{
			unchecked 
			{
				#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g = this._get_summaryState();
					#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g1 = this.fakeState;
					#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 3:
						{
							return global::pony.ui.ButtonStates.Press;
						}
						
						
						case 1:
						{
							#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g1))
							{
								case 3:
								{
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								case 1:
								{
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										return global::pony.ui.ButtonStates.Focus;
									}
									
								}
								
								
								default:
								{
									#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										return global::pony.ui.ButtonStates.Focus;
									}
									
								}
								
							}
							
						}
						
						
						case 2:
						{
							#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g1))
							{
								case 3:
								{
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								case 1:
								{
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										return global::pony.ui.ButtonStates.Focus;
									}
									
								}
								
								
								default:
								{
									#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Leave;
									}
									
								}
								
							}
							
						}
						
						
						default:
						{
							#line 197 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g1))
							{
								case 3:
								{
									return global::pony.ui.ButtonStates.Press;
								}
								
								
								case 1:
								{
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										return global::pony.ui.ButtonStates.Focus;
									}
									
								}
								
								
								default:
								{
									#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									if (( ( this.mouseState == global::pony.ui.ButtonStates.Focus ) &&  ! (global::pony.ui.ButtonCore.MOUSE_FOCUS)  )) 
									{
										#line 199 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									 else 
									{
										#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										return global::pony.ui.ButtonStates.Default;
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void update()
		{
			unchecked 
			{
				#line 207 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				bool f = false;
				bool nt = ( this.tabState == global::pony.ui.ButtonStates.Focus );
				if (( this.prevTab != nt )) 
				{
					this.prevTab = nt;
					if (nt) 
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this = this.@select;
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr578 = _this;
					}
					 else 
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this1 = this.unselect;
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr577 = _this1;
					}
					
					#line 215 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					f = true;
				}
				
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				bool pmm = ( this.prevMode != this.mode );
				this.prevMode = this.mode;
				if (( this.prevSummary != this._get_summaryState() )) 
				{
					this.prevSummary = this._get_summaryState();
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array args = new global::Array<object>(new object[]{this._get_summaryState(), this.mode});
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this2 = this.change;
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this2.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (_this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr579 = _this2;
					}
					
				}
				
				#line 223 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( ( ( this.prevVisual != this._get_visualState() ) || f ) || pmm )) 
				{
					this.prevVisual = this._get_visualState();
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::Array args1 = new global::Array<object>(new object[]{this._get_visualState(), this.mode, f});
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this3 = this.changeVisual;
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this3.dispatchEvent(new global::pony.events.Event(((global::Array) (args1) ), ((object) (_this3.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr580 = _this3;
					}
					
				}
				
				#line 227 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (pmm) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this4 = this.onMode;
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this4.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this4.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr581 = _this4;
				}
				
			}
			#line default
		}
		
		
		public   void sendVisual()
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::Array args = new global::Array<object>(new object[]{this._get_visualState(), this.mode, false});
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.changeVisual;
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr582 = _this;
			}
			#line default
		}
		
		
		public virtual   void changeState(global::pony.events.Event @event)
		{
			unchecked 
			{
				#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g = default(global::pony.ui.ButtonStates);
					#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					if (( ((global::pony.events.Event) (global::haxe.lang.Runtime.getField(@event.currentListener, "prev", 1247723251, true)) ) == default(global::pony.events.Event) )) 
					{
						#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						_g = global::pony.ui.ButtonStates.Default;
					}
					 else 
					{
						#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						_g = ((global::pony.ui.ButtonStates) (((global::pony.events.Event) (global::haxe.lang.Runtime.getField(@event.currentListener, "prev", 1247723251, true)) ).args[0]) );
					}
					
					#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					global::pony.ui.ButtonStates _g1 = default(global::pony.ui.ButtonStates);
					#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					_g1 = ((global::pony.ui.ButtonStates) (@event.args[0]) );
					#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					switch (global::Type.enumIndex(_g))
					{
						case 3:
						{
							#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							global::pony.ui.ButtonStates s = _g1;
							{
								if (( s != global::pony.ui.ButtonStates.Leave )) 
								{
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal _this = this.click;
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal __temp_expr595 = _this;
								}
								
								#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								if (( this.timer != default(global::pony.Timer) )) 
								{
									#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									global::pony.Timer _this1 = this.timer;
									#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									_this1.stop();
									#line 240 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									_this1.removeAllListeners();
								}
								
								#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
								{
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal _this2 = this.up;
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									_this2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									global::pony.events.Signal __temp_expr596 = _this2;
								}
								
							}
							
							#line 238 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
						
						default:
						{
							#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							switch (global::Type.enumIndex(_g1))
							{
								case 3:
								{
									#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
									{
										#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony.events.Signal _this3 = this.down;
										#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										_this3.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this3.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
										#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										global::pony.events.Signal __temp_expr587 = _this3;
									}
									
									#line 244 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									if ( ! ((( this.tick.listeners.data.length == 0 ))) ) 
									{
										#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
										{
											#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
											global::pony.events.Signal _this4 = this.tick;
											#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
											_this4.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this4.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
											#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
											global::pony.events.Signal __temp_expr588 = _this4;
										}
										
										#line 246 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
										this.timer = global::pony.Timer.tick(global::pony.ui.ButtonCore.tickFirstDelay);
										{
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											int priority = 0;
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											object listener = default(object);
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											{
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tickListener"), ((int) (1066312945) ))) ), 0);
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
											}
											
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											object __temp_stmt589 = default(object);
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											{
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object f1 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object this1 = default(object);
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												{
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													object __temp_getvar238 = f1;
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													double __temp_ret239 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar238, "used", 1303220797, true)) );
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													object __temp_expr590 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar238, "used", 1303220797, ( __temp_ret239 + 1.0 ))) );
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													double __temp_expr591 = __temp_ret239;
												}
												
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												{
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													bool __temp_odecl583 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													bool __temp_odecl584 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
													#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f1, __temp_odecl584, true, default(global::pony.events.Event), __temp_odecl583}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
												}
												
												#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												__temp_stmt589 = this1;
											}
											
											#line 247 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											this.timer.@add(((object) (__temp_stmt589) ), new global::haxe.lang.Null<int>(priority, true));
										}
										
										{
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											int priority1 = 0;
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											object listener1 = default(object);
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											{
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("beginTicks"), ((int) (100089741) ))) ), 0);
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												listener1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
											}
											
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											object __temp_stmt592 = default(object);
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											{
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object f3 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												object this2 = default(object);
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												{
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													object __temp_getvar240 = f3;
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													double __temp_ret241 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar240, "used", 1303220797, true)) );
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													object __temp_expr593 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar240, "used", 1303220797, ( __temp_ret241 + 1.0 ))) );
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													double __temp_expr594 = __temp_ret241;
												}
												
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												{
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													bool __temp_odecl585 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													bool __temp_odecl586 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
													#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
													this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f3, __temp_odecl586, true, default(global::pony.events.Event), __temp_odecl585}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
												}
												
												#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
												__temp_stmt592 = this2;
											}
											
											#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
											this.timer.@add(((object) (__temp_stmt592) ), new global::haxe.lang.Null<int>(priority1, true));
										}
										
									}
									
									#line 242 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									break;
								}
								
								
								default:
								{
									#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									{
									}
									
									#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
									break;
								}
								
							}
							
							#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							break;
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void tickListener()
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.tick;
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.mode})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr597 = _this;
			}
			#line default
		}
		
		
		public virtual   void beginTicks()
		{
			unchecked 
			{
				#line 257 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.timer = new global::pony.Timer(((int) (global::pony.ui.ButtonCore.tickDelay) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) ));
				object __temp_stmt598 = default(object);
				#line 258 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 258 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tickListener"), ((int) (1066312945) ))) ), 0);
					#line 258 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					__temp_stmt598 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 258 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.timer.@add(__temp_stmt598, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public   void killTimer()
		{
			unchecked 
			{
				#line 262 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.timer != default(global::pony.Timer) )) 
				{
					global::pony.Timer _this = this.timer;
					#line 263 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					_this.stop();
					#line 263 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					_this.removeAllListeners();
				}
				
			}
			#line default
		}
		
		
		public virtual   global::Array<int> _set_sw(global::Array<int> a)
		{
			unchecked 
			{
				#line 267 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				if (( this.sw != default(global::Array<int>) )) 
				{
					#line 267 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					throw global::haxe.lang.HaxeException.wrap("sw setted");
				}
				
				{
					#line 268 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					int _g1 = 0;
					#line 268 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					int _g = a.length;
					#line 268 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					while (( _g1 < _g ))
					{
						#line 268 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						int i = _g1++;
						object __temp_stmt599 = default(object);
						#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						{
							#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							global::haxe.lang.Function __temp_stmt600 = default(global::haxe.lang.Function);
							#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							{
								#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								global::Array<int> v = new global::Array<int>(new int[]{a[i]});
								#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								global::Array<object> f1 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_mode"), ((int) (1987635296) ))) )});
								#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
								__temp_stmt600 = new global::pony.ui.ButtonCore_set_sw_269__Fun(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (v) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f1) ))) ));
							}
							
							#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							object f = global::pony._Function.Function_Impl_.@from(__temp_stmt600, 0);
							#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							__temp_stmt599 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.click.subArgs(new global::Array<object>(new object[]{i})).@add(__temp_stmt599, default(global::haxe.lang.Null<int>));
					}
					
				}
				
				return this.sw = a;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (hash)
				{
					case 1214305123:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if (handleProperties) 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this._set_mode(((int) (@value) ));
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						 else 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mode = ((int) (@value) );
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						
					}
					
					
					case 288273398:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.prevMode = ((int) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
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
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (hash)
				{
					case 25764:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if (handleProperties) 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this._set_sw(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (@value) ))) ));
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						 else 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.sw = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (@value) ))) );
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						
					}
					
					
					case 1793776674:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.onMode = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1819953685:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.unselect = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1781734140:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.@select = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 26203:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.up = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1114503266:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.down = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1291633501:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.tick = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1214151752:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.click = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1455021136:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.changeVisual = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 930255216:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.change = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1214305123:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if (handleProperties) 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this._set_mode(((int) (global::haxe.lang.Runtime.toInt(@value)) ));
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						 else 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							this.mode = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return @value;
						}
						
					}
					
					
					case 873851952:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.waitUp = ((bool) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 288273398:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.prevMode = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 271957957:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.timer = ((global::pony.Timer) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1003154722:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.prevTab = ((bool) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1879150099:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.prevVisual = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1731299443:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.prevSummary = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 855034673:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.visualState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1211609355:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.summaryState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 319426108:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.fakeState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1474227178:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.keyboardState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 1924134780:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.tabState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					case 567830956:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseState = ((global::pony.ui.ButtonStates) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
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
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (hash)
				{
					case 1870155873:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_sw"), ((int) (1870155873) ))) );
					}
					
					
					case 2106848071:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("killTimer"), ((int) (2106848071) ))) );
					}
					
					
					case 100089741:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("beginTicks"), ((int) (100089741) ))) );
					}
					
					
					case 1066312945:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tickListener"), ((int) (1066312945) ))) );
					}
					
					
					case 701570689:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeState"), ((int) (701570689) ))) );
					}
					
					
					case 283265576:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("sendVisual"), ((int) (283265576) ))) );
					}
					
					
					case 117802505:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) );
					}
					
					
					case 1943569096:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_visualState"), ((int) (1943569096) ))) );
					}
					
					
					case 1289133460:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_summaryState"), ((int) (1289133460) ))) );
					}
					
					
					case 1593752026:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("keyUp"), ((int) (1593752026) ))) );
					}
					
					
					case 474442145:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("keyDown"), ((int) (474442145) ))) );
					}
					
					
					case 1892560275:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("enterUp"), ((int) (1892560275) ))) );
					}
					
					
					case 1470496154:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("enterDown"), ((int) (1470496154) ))) );
					}
					
					
					case 695024481:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("leaveFocus"), ((int) (695024481) ))) );
					}
					
					
					case 314427606:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setFocus"), ((int) (314427606) ))) );
					}
					
					
					case 1858253095:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("mouseDown"), ((int) (1858253095) ))) );
					}
					
					
					case 1081275360:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("mouseUp"), ((int) (1081275360) ))) );
					}
					
					
					case 605939561:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("mouseOut"), ((int) (605939561) ))) );
					}
					
					
					case 1980582425:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("mouseOver"), ((int) (1980582425) ))) );
					}
					
					
					case 1987635296:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_mode"), ((int) (1987635296) ))) );
					}
					
					
					case 25764:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.sw;
					}
					
					
					case 1793776674:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.onMode;
					}
					
					
					case 1819953685:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.unselect;
					}
					
					
					case 1781734140:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.@select;
					}
					
					
					case 26203:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.up;
					}
					
					
					case 1114503266:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.down;
					}
					
					
					case 1291633501:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.tick;
					}
					
					
					case 1214151752:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.click;
					}
					
					
					case 1455021136:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.changeVisual;
					}
					
					
					case 930255216:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.change;
					}
					
					
					case 1214305123:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.mode;
					}
					
					
					case 873851952:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.waitUp;
					}
					
					
					case 288273398:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.prevMode;
					}
					
					
					case 271957957:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.timer;
					}
					
					
					case 1003154722:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.prevTab;
					}
					
					
					case 1879150099:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.prevVisual;
					}
					
					
					case 1731299443:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.prevSummary;
					}
					
					
					case 855034673:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if (handleProperties) 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return this._get_visualState();
						}
						 else 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return this.visualState;
						}
						
					}
					
					
					case 1211609355:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						if (handleProperties) 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return this._get_summaryState();
						}
						 else 
						{
							#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
							return this.summaryState;
						}
						
					}
					
					
					case 319426108:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.fakeState;
					}
					
					
					case 1474227178:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.keyboardState;
					}
					
					
					case 1924134780:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.tabState;
					}
					
					
					case 567830956:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this.mouseState;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
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
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (hash)
				{
					case 1214305123:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((double) (this.mode) );
					}
					
					
					case 288273398:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return ((double) (this.prevMode) );
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
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
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				switch (hash)
				{
					case 1870155873:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this._set_sw(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (dynargs[0]) ))) ));
					}
					
					
					case 2106848071:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.killTimer();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 100089741:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.beginTicks();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1066312945:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.tickListener();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 701570689:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.changeState(((global::pony.events.Event) (dynargs[0]) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 283265576:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.sendVisual();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 117802505:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.update();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1943569096:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this._get_visualState();
					}
					
					
					case 1289133460:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this._get_summaryState();
					}
					
					
					case 1593752026:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.keyUp();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 474442145:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.keyDown();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1892560275:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.enterUp();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1470496154:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.enterDown();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 695024481:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.leaveFocus();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 314427606:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.setFocus();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1858253095:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseDown();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1081275360:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseUp();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 605939561:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseOut();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1980582425:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						this.mouseOver(((bool) (dynargs[0]) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						break;
					}
					
					
					case 1987635296:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return this._set_mode(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("sw");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("onMode");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("unselect");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("select");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("up");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("down");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("tick");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("click");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("changeVisual");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("change");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("mode");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("waitUp");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("prevMode");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("timer");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("prevTab");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("prevVisual");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("prevSummary");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("visualState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("summaryState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("fakeState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("keyboardState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("tabState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				baseArr.push("mouseState");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.ui
{
	public  class ButtonCore_set_sw_269__Fun : global::haxe.lang.Function 
	{
		public    ButtonCore_set_sw_269__Fun(global::Array<int> v, global::Array<object> f1) : base(0, 1)
		{
			unchecked 
			{
				#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.v = v;
				#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				this.f1 = f1;
			}
			#line default
		}
		
		
		public override   double __hx_invoke0_f()
		{
			unchecked 
			{
				#line 269 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/ui/ButtonCore.hx"
				return ((double) (((int) (((global::haxe.lang.Function) (this.f1[0]) ).__hx_invoke1_f(((double) (this.v[0]) ), global::haxe.lang.Runtime.undefined)) )) );
			}
			#line default
		}
		
		
		public  global::Array<int> v;
		
		public  global::Array<object> f1;
		
	}
}



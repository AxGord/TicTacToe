
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class Keyboard : global::haxe.lang.HxObject, global::pony.ui.IKeyboard<object> 
	{
		public    Keyboard(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Keyboard()
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				global::pony.unity3d.Keyboard.__hx_ctor_pony_unity3d_Keyboard(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_unity3d_Keyboard(global::pony.unity3d.Keyboard __temp_me129)
		{
			unchecked 
			{
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
					#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					global::pony.events.Signal this1 = global::pony.events.Signal.create<object>(__temp_me129);
					#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					__temp_me129.down = ((global::pony.events.Signal) (this1) );
				}
				
				{
					#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					global::pony.events.Signal this2 = global::pony.events.Signal.create<object>(__temp_me129);
					#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					__temp_me129.up = ((global::pony.events.Signal) (this2) );
				}
				
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				__temp_me129.keys = global::Type.allEnums<global::UnityEngine.KeyCode>(typeof(global::UnityEngine.KeyCode));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				return new global::pony.unity3d.Keyboard(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				return new global::pony.unity3d.Keyboard();
			}
			#line default
		}
		
		
		public virtual   object pony_ui_IKeyboard_cast<T_c>()
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				return this;
			}
			#line default
		}
		
		
		public  global::pony.events.Signal down;
		
		public  global::pony.events.Signal up;
		
		public  global::Array<global::UnityEngine.KeyCode> keys;
		
		public   void enable()
		{
			unchecked 
			{
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object listener = default(object);
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object __temp_stmt628 = default(object);
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					object l = default(object);
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					{
						#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
						#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					__temp_stmt628 = l;
				}
				
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				listener = ((object) (__temp_stmt628) );
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				global::pony.events.Signal this1 = global::pony.DeltaTime.update;
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(-120, true));
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object __temp_expr629 = this1.target;
			}
			#line default
		}
		
		
		public   void disable()
		{
			unchecked 
			{
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object listener = default(object);
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object __temp_stmt630 = default(object);
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					object l = default(object);
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					{
						#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) ), 0);
						#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					__temp_stmt630 = l;
				}
				
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				listener = ((object) (__temp_stmt630) );
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				global::pony.events.Signal this1 = global::pony.DeltaTime.update;
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				this1.@remove(((object) (listener) ));
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				object __temp_expr631 = this1.target;
			}
			#line default
		}
		
		
		public virtual   void update()
		{
			unchecked 
			{
				#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				if (global::UnityEngine.Input.anyKeyDown) 
				{
					int _g = 0;
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					global::Array<global::UnityEngine.KeyCode> _g1 = this.keys;
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					while (( _g < _g1.length ))
					{
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						global::UnityEngine.KeyCode k = _g1[_g];
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						 ++ _g;
						if (global::UnityEngine.Input.GetKeyDown(((global::UnityEngine.KeyCode) (k) ))) 
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
							this.dispatchKey(this.down, k);
						}
						
						if (global::UnityEngine.Input.GetKeyUp(((global::UnityEngine.KeyCode) (k) ))) 
						{
							#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
							this.dispatchKey(this.up, k);
						}
						
					}
					
				}
				 else 
				{
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					int _g2 = 0;
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					global::Array<global::UnityEngine.KeyCode> _g11 = this.keys;
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					while (( _g2 < _g11.length ))
					{
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						global::UnityEngine.KeyCode k1 = _g11[_g2];
						#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						 ++ _g2;
						if (global::UnityEngine.Input.GetKeyUp(((global::UnityEngine.KeyCode) (k1) ))) 
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
							this.dispatchKey(this.up, k1);
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void dispatchKey(global::pony.events.Signal s, global::UnityEngine.KeyCode k)
		{
			unchecked 
			{
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				global::pony.ui.Key k1 = default(global::pony.ui.Key);
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					global::UnityEngine.KeyCode __temp_switch632 = (k);
					if (( __temp_switch632 == global::UnityEngine.KeyCode.A )) 
					{
						#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						k1 = global::pony.ui.Key.A;
					}
					 else 
					{
						if (( __temp_switch632 == global::UnityEngine.KeyCode.B )) 
						{
							#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
							k1 = global::pony.ui.Key.B;
						}
						 else 
						{
							if (( __temp_switch632 == global::UnityEngine.KeyCode.C )) 
							{
								#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
								k1 = global::pony.ui.Key.C;
							}
							 else 
							{
								if (( __temp_switch632 == global::UnityEngine.KeyCode.D )) 
								{
									#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
									k1 = global::pony.ui.Key.D;
								}
								 else 
								{
									if (( __temp_switch632 == global::UnityEngine.KeyCode.E )) 
									{
										#line 77 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
										k1 = global::pony.ui.Key.E;
									}
									 else 
									{
										if (( __temp_switch632 == global::UnityEngine.KeyCode.F )) 
										{
											#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
											k1 = global::pony.ui.Key.F;
										}
										 else 
										{
											if (( __temp_switch632 == global::UnityEngine.KeyCode.G )) 
											{
												#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
												k1 = global::pony.ui.Key.G;
											}
											 else 
											{
												if (( __temp_switch632 == global::UnityEngine.KeyCode.H )) 
												{
													#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
													k1 = global::pony.ui.Key.H;
												}
												 else 
												{
													if (( __temp_switch632 == global::UnityEngine.KeyCode.I )) 
													{
														#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
														k1 = global::pony.ui.Key.I;
													}
													 else 
													{
														if (( __temp_switch632 == global::UnityEngine.KeyCode.J )) 
														{
															#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
															k1 = global::pony.ui.Key.J;
														}
														 else 
														{
															if (( __temp_switch632 == global::UnityEngine.KeyCode.K )) 
															{
																#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																k1 = global::pony.ui.Key.K;
															}
															 else 
															{
																if (( __temp_switch632 == global::UnityEngine.KeyCode.L )) 
																{
																	#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																	k1 = global::pony.ui.Key.L;
																}
																 else 
																{
																	if (( __temp_switch632 == global::UnityEngine.KeyCode.M )) 
																	{
																		#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																		k1 = global::pony.ui.Key.M;
																	}
																	 else 
																	{
																		if (( __temp_switch632 == global::UnityEngine.KeyCode.N )) 
																		{
																			#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																			k1 = global::pony.ui.Key.N;
																		}
																		 else 
																		{
																			if (( __temp_switch632 == global::UnityEngine.KeyCode.O )) 
																			{
																				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																				k1 = global::pony.ui.Key.O;
																			}
																			 else 
																			{
																				if (( __temp_switch632 == global::UnityEngine.KeyCode.P )) 
																				{
																					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																					k1 = global::pony.ui.Key.P;
																				}
																				 else 
																				{
																					if (( __temp_switch632 == global::UnityEngine.KeyCode.Q )) 
																					{
																						#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																						k1 = global::pony.ui.Key.Q;
																					}
																					 else 
																					{
																						if (( __temp_switch632 == global::UnityEngine.KeyCode.R )) 
																						{
																							#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																							k1 = global::pony.ui.Key.R;
																						}
																						 else 
																						{
																							if (( __temp_switch632 == global::UnityEngine.KeyCode.S )) 
																							{
																								#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																								k1 = global::pony.ui.Key.S;
																							}
																							 else 
																							{
																								if (( __temp_switch632 == global::UnityEngine.KeyCode.T )) 
																								{
																									#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																									k1 = global::pony.ui.Key.T;
																								}
																								 else 
																								{
																									if (( __temp_switch632 == global::UnityEngine.KeyCode.U )) 
																									{
																										#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																										k1 = global::pony.ui.Key.U;
																									}
																									 else 
																									{
																										if (( __temp_switch632 == global::UnityEngine.KeyCode.V )) 
																										{
																											#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																											k1 = global::pony.ui.Key.V;
																										}
																										 else 
																										{
																											if (( __temp_switch632 == global::UnityEngine.KeyCode.W )) 
																											{
																												#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																												k1 = global::pony.ui.Key.W;
																											}
																											 else 
																											{
																												if (( __temp_switch632 == global::UnityEngine.KeyCode.X )) 
																												{
																													#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																													k1 = global::pony.ui.Key.X;
																												}
																												 else 
																												{
																													if (( __temp_switch632 == global::UnityEngine.KeyCode.Y )) 
																													{
																														#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																														k1 = global::pony.ui.Key.Y;
																													}
																													 else 
																													{
																														if (( __temp_switch632 == global::UnityEngine.KeyCode.Z )) 
																														{
																															#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																															k1 = global::pony.ui.Key.Z;
																														}
																														 else 
																														{
																															if (( __temp_switch632 == global::UnityEngine.KeyCode.Backspace )) 
																															{
																																#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																k1 = global::pony.ui.Key.Backspace;
																															}
																															 else 
																															{
																																if (( __temp_switch632 == global::UnityEngine.KeyCode.Tab )) 
																																{
																																	#line 100 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																	k1 = global::pony.ui.Key.Tab;
																																}
																																 else 
																																{
																																	if (( __temp_switch632 == global::UnityEngine.KeyCode.Escape )) 
																																	{
																																		#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																		k1 = global::pony.ui.Key.Escape;
																																	}
																																	 else 
																																	{
																																		if (( __temp_switch632 == global::UnityEngine.KeyCode.Space )) 
																																		{
																																			#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																			k1 = global::pony.ui.Key.Space;
																																		}
																																		 else 
																																		{
																																			if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad0 )) 
																																			{
																																				#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																				k1 = global::pony.ui.Key.Keypad0;
																																			}
																																			 else 
																																			{
																																				if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad1 )) 
																																				{
																																					#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																					k1 = global::pony.ui.Key.Keypad1;
																																				}
																																				 else 
																																				{
																																					if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad2 )) 
																																					{
																																						#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																						k1 = global::pony.ui.Key.Keypad2;
																																					}
																																					 else 
																																					{
																																						if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad3 )) 
																																						{
																																							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																							k1 = global::pony.ui.Key.Keypad3;
																																						}
																																						 else 
																																						{
																																							if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad4 )) 
																																							{
																																								#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																								k1 = global::pony.ui.Key.Keypad4;
																																							}
																																							 else 
																																							{
																																								if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad5 )) 
																																								{
																																									#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																									k1 = global::pony.ui.Key.Keypad5;
																																								}
																																								 else 
																																								{
																																									if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad6 )) 
																																									{
																																										#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																										k1 = global::pony.ui.Key.Keypad6;
																																									}
																																									 else 
																																									{
																																										if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad7 )) 
																																										{
																																											#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																											k1 = global::pony.ui.Key.Keypad7;
																																										}
																																										 else 
																																										{
																																											if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad8 )) 
																																											{
																																												#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																												k1 = global::pony.ui.Key.Keypad8;
																																											}
																																											 else 
																																											{
																																												if (( __temp_switch632 == global::UnityEngine.KeyCode.Keypad9 )) 
																																												{
																																													#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																													k1 = global::pony.ui.Key.Keypad9;
																																												}
																																												 else 
																																												{
																																													if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadDivide )) 
																																													{
																																														#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																														k1 = global::pony.ui.Key.KeypadDivide;
																																													}
																																													 else 
																																													{
																																														if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadEquals )) 
																																														{
																																															#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																															k1 = global::pony.ui.Key.Equals;
																																														}
																																														 else 
																																														{
																																															if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadMultiply )) 
																																															{
																																																#line 115 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																k1 = global::pony.ui.Key.KeypadMultiply;
																																															}
																																															 else 
																																															{
																																																if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadMinus )) 
																																																{
																																																	#line 116 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																	k1 = global::pony.ui.Key.KeypadMinus;
																																																}
																																																 else 
																																																{
																																																	if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadPlus )) 
																																																	{
																																																		#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																		k1 = global::pony.ui.Key.KeypadPlus;
																																																	}
																																																	 else 
																																																	{
																																																		if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadEnter )) 
																																																		{
																																																			#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																			k1 = global::pony.ui.Key.KeypadEnter;
																																																		}
																																																		 else 
																																																		{
																																																			if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadPeriod )) 
																																																			{
																																																				#line 119 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																				k1 = global::pony.ui.Key.KeypadDot;
																																																			}
																																																			 else 
																																																			{
																																																				if (( __temp_switch632 == global::UnityEngine.KeyCode.UpArrow )) 
																																																				{
																																																					#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																					k1 = global::pony.ui.Key.Up;
																																																				}
																																																				 else 
																																																				{
																																																					if (( __temp_switch632 == global::UnityEngine.KeyCode.DownArrow )) 
																																																					{
																																																						#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																						k1 = global::pony.ui.Key.Down;
																																																					}
																																																					 else 
																																																					{
																																																						if (( __temp_switch632 == global::UnityEngine.KeyCode.RightArrow )) 
																																																						{
																																																							#line 122 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																							k1 = global::pony.ui.Key.Right;
																																																						}
																																																						 else 
																																																						{
																																																							if (( __temp_switch632 == global::UnityEngine.KeyCode.LeftArrow )) 
																																																							{
																																																								#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																								k1 = global::pony.ui.Key.Left;
																																																							}
																																																							 else 
																																																							{
																																																								if (( __temp_switch632 == global::UnityEngine.KeyCode.Insert )) 
																																																								{
																																																									#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																									k1 = global::pony.ui.Key.Insert;
																																																								}
																																																								 else 
																																																								{
																																																									if (( __temp_switch632 == global::UnityEngine.KeyCode.Delete )) 
																																																									{
																																																										#line 125 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																										k1 = global::pony.ui.Key.Delete;
																																																									}
																																																									 else 
																																																									{
																																																										if (( __temp_switch632 == global::UnityEngine.KeyCode.Home )) 
																																																										{
																																																											#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																											k1 = global::pony.ui.Key.Home;
																																																										}
																																																										 else 
																																																										{
																																																											if (( __temp_switch632 == global::UnityEngine.KeyCode.End )) 
																																																											{
																																																												#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																												k1 = global::pony.ui.Key.End;
																																																											}
																																																											 else 
																																																											{
																																																												if (( __temp_switch632 == global::UnityEngine.KeyCode.PageUp )) 
																																																												{
																																																													#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																													k1 = global::pony.ui.Key.PageUp;
																																																												}
																																																												 else 
																																																												{
																																																													if (( __temp_switch632 == global::UnityEngine.KeyCode.PageDown )) 
																																																													{
																																																														#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																														k1 = global::pony.ui.Key.PageDown;
																																																													}
																																																													 else 
																																																													{
																																																														if (( __temp_switch632 == global::UnityEngine.KeyCode.F1 )) 
																																																														{
																																																															#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																															k1 = global::pony.ui.Key.F1;
																																																														}
																																																														 else 
																																																														{
																																																															if (( __temp_switch632 == global::UnityEngine.KeyCode.F2 )) 
																																																															{
																																																																#line 131 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																k1 = global::pony.ui.Key.F2;
																																																															}
																																																															 else 
																																																															{
																																																																if (( __temp_switch632 == global::UnityEngine.KeyCode.F3 )) 
																																																																{
																																																																	#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																	k1 = global::pony.ui.Key.F3;
																																																																}
																																																																 else 
																																																																{
																																																																	if (( __temp_switch632 == global::UnityEngine.KeyCode.F4 )) 
																																																																	{
																																																																		#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																		k1 = global::pony.ui.Key.F4;
																																																																	}
																																																																	 else 
																																																																	{
																																																																		if (( __temp_switch632 == global::UnityEngine.KeyCode.F5 )) 
																																																																		{
																																																																			#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																			k1 = global::pony.ui.Key.F5;
																																																																		}
																																																																		 else 
																																																																		{
																																																																			if (( __temp_switch632 == global::UnityEngine.KeyCode.F6 )) 
																																																																			{
																																																																				#line 135 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																				k1 = global::pony.ui.Key.F6;
																																																																			}
																																																																			 else 
																																																																			{
																																																																				if (( __temp_switch632 == global::UnityEngine.KeyCode.F7 )) 
																																																																				{
																																																																					#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																					k1 = global::pony.ui.Key.F7;
																																																																				}
																																																																				 else 
																																																																				{
																																																																					if (( __temp_switch632 == global::UnityEngine.KeyCode.F8 )) 
																																																																					{
																																																																						#line 137 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																						k1 = global::pony.ui.Key.F8;
																																																																					}
																																																																					 else 
																																																																					{
																																																																						if (( __temp_switch632 == global::UnityEngine.KeyCode.F9 )) 
																																																																						{
																																																																							#line 138 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																							k1 = global::pony.ui.Key.F9;
																																																																						}
																																																																						 else 
																																																																						{
																																																																							if (( __temp_switch632 == global::UnityEngine.KeyCode.F10 )) 
																																																																							{
																																																																								#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																								k1 = global::pony.ui.Key.F10;
																																																																							}
																																																																							 else 
																																																																							{
																																																																								if (( __temp_switch632 == global::UnityEngine.KeyCode.F11 )) 
																																																																								{
																																																																									#line 140 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																									k1 = global::pony.ui.Key.F11;
																																																																								}
																																																																								 else 
																																																																								{
																																																																									if (( __temp_switch632 == global::UnityEngine.KeyCode.F12 )) 
																																																																									{
																																																																										#line 141 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																										k1 = global::pony.ui.Key.F12;
																																																																									}
																																																																									 else 
																																																																									{
																																																																										if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha1 )) 
																																																																										{
																																																																											#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																											k1 = global::pony.ui.Key.Number1;
																																																																										}
																																																																										 else 
																																																																										{
																																																																											if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha2 )) 
																																																																											{
																																																																												#line 143 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																												k1 = global::pony.ui.Key.Number2;
																																																																											}
																																																																											 else 
																																																																											{
																																																																												if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha3 )) 
																																																																												{
																																																																													#line 144 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																													k1 = global::pony.ui.Key.Number3;
																																																																												}
																																																																												 else 
																																																																												{
																																																																													if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha4 )) 
																																																																													{
																																																																														#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																														k1 = global::pony.ui.Key.Number4;
																																																																													}
																																																																													 else 
																																																																													{
																																																																														if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha5 )) 
																																																																														{
																																																																															#line 146 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																															k1 = global::pony.ui.Key.Number5;
																																																																														}
																																																																														 else 
																																																																														{
																																																																															if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha6 )) 
																																																																															{
																																																																																#line 147 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																k1 = global::pony.ui.Key.Number6;
																																																																															}
																																																																															 else 
																																																																															{
																																																																																if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha7 )) 
																																																																																{
																																																																																	#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																	k1 = global::pony.ui.Key.Number7;
																																																																																}
																																																																																 else 
																																																																																{
																																																																																	if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha8 )) 
																																																																																	{
																																																																																		#line 149 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																		k1 = global::pony.ui.Key.Number8;
																																																																																	}
																																																																																	 else 
																																																																																	{
																																																																																		if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha9 )) 
																																																																																		{
																																																																																			#line 150 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																			k1 = global::pony.ui.Key.Number9;
																																																																																		}
																																																																																		 else 
																																																																																		{
																																																																																			if (( __temp_switch632 == global::UnityEngine.KeyCode.Alpha0 )) 
																																																																																			{
																																																																																				#line 151 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																				k1 = global::pony.ui.Key.Number0;
																																																																																			}
																																																																																			 else 
																																																																																			{
																																																																																				if (( __temp_switch632 == global::UnityEngine.KeyCode.Print )) 
																																																																																				{
																																																																																					#line 152 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																					k1 = global::pony.ui.Key.PrintScreen;
																																																																																				}
																																																																																				 else 
																																																																																				{
																																																																																					if (( __temp_switch632 == global::UnityEngine.KeyCode.Pause )) 
																																																																																					{
																																																																																						#line 153 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																						k1 = global::pony.ui.Key.Pause;
																																																																																					}
																																																																																					 else 
																																																																																					{
																																																																																						if (( __temp_switch632 == global::UnityEngine.KeyCode.ScrollLock )) 
																																																																																						{
																																																																																							#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																							k1 = global::pony.ui.Key.ScrollLock;
																																																																																						}
																																																																																						 else 
																																																																																						{
																																																																																							if (( __temp_switch632 == global::UnityEngine.KeyCode.Numlock )) 
																																																																																							{
																																																																																								#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																								k1 = global::pony.ui.Key.NumLock;
																																																																																							}
																																																																																							 else 
																																																																																							{
																																																																																								if (( __temp_switch632 == global::UnityEngine.KeyCode.KeypadEquals )) 
																																																																																								{
																																																																																									#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																									k1 = global::pony.ui.Key.Equals;
																																																																																								}
																																																																																								 else 
																																																																																								{
																																																																																									if (( __temp_switch632 == global::UnityEngine.KeyCode.Minus )) 
																																																																																									{
																																																																																										#line 157 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																										k1 = global::pony.ui.Key.Minus;
																																																																																									}
																																																																																									 else 
																																																																																									{
																																																																																										if (( __temp_switch632 == global::UnityEngine.KeyCode.BackQuote )) 
																																																																																										{
																																																																																											#line 158 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																											k1 = global::pony.ui.Key.Tilde;
																																																																																										}
																																																																																										 else 
																																																																																										{
																																																																																											if (( __temp_switch632 == global::UnityEngine.KeyCode.Period )) 
																																																																																											{
																																																																																												#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																												k1 = global::pony.ui.Key.Dot;
																																																																																											}
																																																																																											 else 
																																																																																											{
																																																																																												if (( __temp_switch632 == global::UnityEngine.KeyCode.Slash )) 
																																																																																												{
																																																																																													#line 160 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																													k1 = global::pony.ui.Key.RightSlash;
																																																																																												}
																																																																																												 else 
																																																																																												{
																																																																																													if (( __temp_switch632 == global::UnityEngine.KeyCode.Backslash )) 
																																																																																													{
																																																																																														#line 161 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																														k1 = global::pony.ui.Key.LeftSlash;
																																																																																													}
																																																																																													 else 
																																																																																													{
																																																																																														if (( __temp_switch632 == global::UnityEngine.KeyCode.Quote )) 
																																																																																														{
																																																																																															#line 162 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																															k1 = global::pony.ui.Key.Quote;
																																																																																														}
																																																																																														 else 
																																																																																														{
																																																																																															if (( __temp_switch632 == global::UnityEngine.KeyCode.LeftShift )) 
																																																																																															{
																																																																																																#line 163 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																k1 = global::pony.ui.Key.Shift;
																																																																																															}
																																																																																															 else 
																																																																																															{
																																																																																																if (( __temp_switch632 == global::UnityEngine.KeyCode.LeftControl )) 
																																																																																																{
																																																																																																	#line 164 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																	k1 = global::pony.ui.Key.Ctrl;
																																																																																																}
																																																																																																 else 
																																																																																																{
																																																																																																	if (( __temp_switch632 == global::UnityEngine.KeyCode.LeftAlt )) 
																																																																																																	{
																																																																																																		#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																		k1 = global::pony.ui.Key.Alt;
																																																																																																	}
																																																																																																	 else 
																																																																																																	{
																																																																																																		if (( __temp_switch632 == global::UnityEngine.KeyCode.CapsLock )) 
																																																																																																		{
																																																																																																			#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																			k1 = global::pony.ui.Key.CapsLock;
																																																																																																		}
																																																																																																		 else 
																																																																																																		{
																																																																																																			if (( __temp_switch632 == global::UnityEngine.KeyCode.LeftWindows )) 
																																																																																																			{
																																																																																																				#line 167 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																				k1 = global::pony.ui.Key.LeftWin;
																																																																																																			}
																																																																																																			 else 
																																																																																																			{
																																																																																																				if (( __temp_switch632 == global::UnityEngine.KeyCode.RightWindows )) 
																																																																																																				{
																																																																																																					#line 168 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																					k1 = global::pony.ui.Key.RightWin;
																																																																																																				}
																																																																																																				 else 
																																																																																																				{
																																																																																																					if (( __temp_switch632 == global::UnityEngine.KeyCode.Plus )) 
																																																																																																					{
																																																																																																						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																						k1 = global::pony.ui.Key.Plus;
																																																																																																					}
																																																																																																					 else 
																																																																																																					{
																																																																																																						if (( __temp_switch632 == global::UnityEngine.KeyCode.Return )) 
																																																																																																						{
																																																																																																							#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
																																																																																																							k1 = global::pony.ui.Key.Enter;
																																																																																																						}
																																																																																																						
																																																																																																					}
																																																																																																					
																																																																																																				}
																																																																																																				
																																																																																																			}
																																																																																																			
																																																																																																		}
																																																																																																		
																																																																																																	}
																																																																																																	
																																																																																																}
																																																																																																
																																																																																															}
																																																																																															
																																																																																														}
																																																																																														
																																																																																													}
																																																																																													
																																																																																												}
																																																																																												
																																																																																											}
																																																																																											
																																																																																										}
																																																																																										
																																																																																									}
																																																																																									
																																																																																								}
																																																																																								
																																																																																							}
																																																																																							
																																																																																						}
																																																																																						
																																																																																					}
																																																																																					
																																																																																				}
																																																																																				
																																																																																			}
																																																																																			
																																																																																		}
																																																																																		
																																																																																	}
																																																																																	
																																																																																}
																																																																																
																																																																															}
																																																																															
																																																																														}
																																																																														
																																																																													}
																																																																													
																																																																												}
																																																																												
																																																																											}
																																																																											
																																																																										}
																																																																										
																																																																									}
																																																																									
																																																																								}
																																																																								
																																																																							}
																																																																							
																																																																						}
																																																																						
																																																																					}
																																																																					
																																																																				}
																																																																				
																																																																			}
																																																																			
																																																																		}
																																																																		
																																																																	}
																																																																	
																																																																}
																																																																
																																																															}
																																																															
																																																														}
																																																														
																																																													}
																																																													
																																																												}
																																																												
																																																											}
																																																											
																																																										}
																																																										
																																																									}
																																																									
																																																								}
																																																								
																																																							}
																																																							
																																																						}
																																																						
																																																					}
																																																					
																																																				}
																																																				
																																																			}
																																																			
																																																		}
																																																		
																																																	}
																																																	
																																																}
																																																
																																															}
																																															
																																														}
																																														
																																													}
																																													
																																												}
																																												
																																											}
																																											
																																										}
																																										
																																									}
																																									
																																								}
																																								
																																							}
																																							
																																						}
																																						
																																					}
																																					
																																				}
																																				
																																			}
																																			
																																		}
																																		
																																	}
																																	
																																}
																																
																															}
																															
																														}
																														
																													}
																													
																												}
																												
																											}
																											
																										}
																										
																									}
																									
																								}
																								
																							}
																							
																						}
																						
																					}
																					
																				}
																				
																			}
																			
																		}
																		
																	}
																	
																}
																
															}
															
														}
														
													}
													
												}
												
											}
											
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				if (( k1 != default(global::pony.ui.Key) )) 
				{
					#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					{
						#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						s.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<global::pony.ui.Key>(new global::pony.ui.Key[]{k1})) ), ((object) (s.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						global::pony.events.Signal __temp_expr633 = s;
					}
					
					#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					object __temp_expr634 = s.target;
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				switch (hash)
				{
					case 1191633396:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.keys = ((global::Array<global::UnityEngine.KeyCode>) (global::Array<object>.__hx_cast<global::UnityEngine.KeyCode>(((global::Array) (@value) ))) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return @value;
					}
					
					
					case 26203:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.up = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return @value;
					}
					
					
					case 1114503266:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.down = ((global::pony.events.Signal) (@value) );
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return @value;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
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
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				switch (hash)
				{
					case 1721492229:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("dispatchKey"), ((int) (1721492229) ))) );
					}
					
					
					case 117802505:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("update"), ((int) (117802505) ))) );
					}
					
					
					case 827877864:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("disable"), ((int) (827877864) ))) );
					}
					
					
					case 2022157955:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("enable"), ((int) (2022157955) ))) );
					}
					
					
					case 1191633396:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return this.keys;
					}
					
					
					case 26203:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return this.up;
					}
					
					
					case 1114503266:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return this.down;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				switch (hash)
				{
					case 1721492229:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.dispatchKey(((global::pony.events.Signal) (dynargs[0]) ), ((global::UnityEngine.KeyCode) (dynargs[1]) ));
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						break;
					}
					
					
					case 117802505:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.update();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						break;
					}
					
					
					case 827877864:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.disable();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						break;
					}
					
					
					case 2022157955:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						this.enable();
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						break;
					}
					
					
					default:
					{
						#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				baseArr.push("keys");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				baseArr.push("up");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				baseArr.push("down");
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Keyboard.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



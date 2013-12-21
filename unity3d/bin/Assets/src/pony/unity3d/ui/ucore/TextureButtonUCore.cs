
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore : global::pony.unity3d.ui.TintButton 
	{
		public    TextureButtonUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    TextureButtonUCore() : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return new global::pony.unity3d.ui.ucore.TextureButtonUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return new global::pony.unity3d.ui.ucore.TextureButtonUCore();
			}
			#line default
		}
		
		
		public  global::UnityEngine.Texture[] defs;
		
		public  global::UnityEngine.Texture[] overs;
		
		public  global::UnityEngine.Texture[] press;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				{
					#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					int _g1 = 0;
					#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					int _g = ( this.overs as global::System.Array ).Length;
					#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					while (( _g1 < _g ))
					{
						#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						int i = _g1++;
						#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						if (( this.overs[i] != default(global::UnityEngine.Texture) )) 
						{
							global::haxe.lang.Function __temp_stmt703 = default(global::haxe.lang.Function);
							#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							{
								#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> t = new global::Array<object>(new object[]{this.overs[i]});
								#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> f = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) )});
								#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								__temp_stmt703 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_24__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f) ))) ));
							}
							
							#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							object __temp_stmt702 = global::pony._Function.Function_Impl_.@from(__temp_stmt703, 1);
							#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus, i})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt702, true), default(global::haxe.lang.Null<int>));
							global::haxe.lang.Function __temp_stmt705 = default(global::haxe.lang.Function);
							#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							{
								#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> t1 = new global::Array<object>(new object[]{this.overs[i]});
								#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> f1 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) )});
								#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								__temp_stmt705 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_25__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f1) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t1) ))) ));
							}
							
							#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							object __temp_stmt704 = global::pony._Function.Function_Impl_.@from(__temp_stmt705, 1);
							#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave, i})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt704, true), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					int _g11 = 0;
					#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					int _g2 = ( this.press as global::System.Array ).Length;
					#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					while (( _g11 < _g2 ))
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						int i1 = _g11++;
						#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						if (( this.press[i1] != default(global::UnityEngine.Texture) )) 
						{
							global::haxe.lang.Function __temp_stmt707 = default(global::haxe.lang.Function);
							#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							{
								#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> t2 = new global::Array<object>(new object[]{this.press[i1]});
								#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) )});
								#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								__temp_stmt707 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_29__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t2) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
							}
							
							#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							object __temp_stmt706 = global::pony._Function.Function_Impl_.@from(__temp_stmt707, 1);
							#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press, i1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt706, true), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 32 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				if (( ( this.defs as global::System.Array ).Length == 0 )) 
				{
					global::haxe.lang.Function __temp_stmt717 = default(global::haxe.lang.Function);
					#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					{
						#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						global::Array<object> t3 = new global::Array<object>(new object[]{this.guiTexture.texture});
						#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						global::Array<object> f3 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) )});
						#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						__temp_stmt717 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_33__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t3) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f3) ))) ));
					}
					
					#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					object __temp_stmt716 = global::pony._Function.Function_Impl_.@from(__temp_stmt717, 1);
					#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default, 0})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt716, true), default(global::haxe.lang.Null<int>));
				}
				 else 
				{
					#line 35 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					this.defs[0] = this.guiTexture.texture;
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						int _g12 = 0;
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						int _g3 = ( this.defs as global::System.Array ).Length;
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						while (( _g12 < _g3 ))
						{
							#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							int i2 = _g12++;
							#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
							if (( this.defs[i2] != default(global::UnityEngine.Texture) )) 
							{
								global::haxe.lang.Function __temp_stmt709 = default(global::haxe.lang.Function);
								#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								{
									#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									global::Array<object> t4 = new global::Array<object>(new object[]{this.defs[i2]});
									#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									global::Array<object> f4 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) )});
									#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									__temp_stmt709 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_37__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t4) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f4) ))) ));
								}
								
								#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								object __temp_stmt708 = global::pony._Function.Function_Impl_.@from(__temp_stmt709, 1);
								#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default, i2})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt708, true), default(global::haxe.lang.Null<int>));
								object __temp_stmt710 = default(object);
								#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								{
									#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									global::haxe.lang.Function __temp_stmt711 = default(global::haxe.lang.Function);
									#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									{
										#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> t5 = new global::Array<object>(new object[]{this.defs[i2]});
										#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> f6 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_txset"), ((int) (369870815) ))) )});
										#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										__temp_stmt711 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_38__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t5) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f6) ))) ));
									}
									
									#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									object f5 = global::pony._Function.Function_Impl_.@from(__temp_stmt711, 0);
									#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									__temp_stmt710 = global::pony.events._Listener.Listener_Impl_._fromFunction(f5, false);
								}
								
								#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus, i2})).@add(__temp_stmt710, default(global::haxe.lang.Null<int>));
								object __temp_stmt712 = default(object);
								#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								{
									#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									global::haxe.lang.Function __temp_stmt713 = default(global::haxe.lang.Function);
									#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									{
										#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> t6 = new global::Array<object>(new object[]{this.defs[i2]});
										#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> f8 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_txset"), ((int) (369870815) ))) )});
										#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										__temp_stmt713 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_39__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f8) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t6) ))) ));
									}
									
									#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									object f7 = global::pony._Function.Function_Impl_.@from(__temp_stmt713, 0);
									#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									__temp_stmt712 = global::pony.events._Listener.Listener_Impl_._fromFunction(f7, false);
								}
								
								#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave, i2})).@add(__temp_stmt712, default(global::haxe.lang.Null<int>));
								object __temp_stmt714 = default(object);
								#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								{
									#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									global::haxe.lang.Function __temp_stmt715 = default(global::haxe.lang.Function);
									#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									{
										#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> t7 = new global::Array<object>(new object[]{this.defs[i2]});
										#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										global::Array<object> f10 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_txset"), ((int) (369870815) ))) )});
										#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
										__temp_stmt715 = new global::pony.unity3d.ui.ucore.TextureButtonUCore_Start_40__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f10) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (t7) ))) ));
									}
									
									#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									object f9 = global::pony._Function.Function_Impl_.@from(__temp_stmt715, 0);
									#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
									__temp_stmt714 = global::pony.events._Listener.Listener_Impl_._fromFunction(f9, false);
								}
								
								#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
								this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press, i2})).@add(__temp_stmt714, default(global::haxe.lang.Null<int>));
							}
							
						}
						
					}
					
				}
				
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				base.Start();
			}
			#line default
		}
		
		
		public virtual   void txset(global::UnityEngine.Texture t, global::pony.events.Event e)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.restoreColor();
				this.guiTexture.texture = t;
				{
					#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					if (( e.parent != default(global::pony.events.Event) )) 
					{
						#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						e.parent.stopPropagation();
					}
					
					#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					e._stopPropagation = true;
				}
				
			}
			#line default
		}
		
		
		public virtual   void _txset(global::UnityEngine.Texture t)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.guiTexture.texture = t;
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				switch (hash)
				{
					case 1216893827:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						this.press = ((global::UnityEngine.Texture[]) (@value) );
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return @value;
					}
					
					
					case 935762079:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						this.overs = ((global::UnityEngine.Texture[]) (@value) );
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return @value;
					}
					
					
					case 1114002190:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						this.defs = ((global::UnityEngine.Texture[]) (@value) );
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
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
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				switch (hash)
				{
					case 369870815:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("_txset"), ((int) (369870815) ))) );
					}
					
					
					case 438599838:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("txset"), ((int) (438599838) ))) );
					}
					
					
					case 389604418:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1216893827:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return this.press;
					}
					
					
					case 935762079:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return this.overs;
					}
					
					
					case 1114002190:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return this.defs;
					}
					
					
					default:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
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
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 369870815:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						this._txset(((global::UnityEngine.Texture) (dynargs[0]) ));
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						break;
					}
					
					
					case 438599838:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						this.txset(((global::UnityEngine.Texture) (dynargs[0]) ), ((global::pony.events.Event) (dynargs[1]) ));
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				baseArr.push("press");
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				baseArr.push("overs");
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				baseArr.push("defs");
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				{
					#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_24__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_24__Fun(global::Array<object> t, global::Array<object> f) : base(1, 0)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t = t;
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f = f;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				global::pony.events.Event e = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.Texture) (this.t[0]) ), e);
			}
			#line default
		}
		
		
		public  global::Array<object> t;
		
		public  global::Array<object> f;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_25__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_25__Fun(global::Array<object> f1, global::Array<object> t1) : base(1, 0)
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f1 = f1;
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t1 = t1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				global::pony.events.Event e1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f1[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.Texture) (this.t1[0]) ), e1);
			}
			#line default
		}
		
		
		public  global::Array<object> f1;
		
		public  global::Array<object> t1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_29__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_29__Fun(global::Array<object> t2, global::Array<object> f2) : base(1, 0)
		{
			unchecked 
			{
				#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t2 = t2;
				#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				global::pony.events.Event e2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.Texture) (this.t2[0]) ), e2);
			}
			#line default
		}
		
		
		public  global::Array<object> t2;
		
		public  global::Array<object> f2;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_33__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_33__Fun(global::Array<object> t3, global::Array<object> f3) : base(1, 0)
		{
			unchecked 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t3 = t3;
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f3 = f3;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				global::pony.events.Event e3 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f3[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.Texture) (this.t3[0]) ), e3);
			}
			#line default
		}
		
		
		public  global::Array<object> t3;
		
		public  global::Array<object> f3;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_37__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_37__Fun(global::Array<object> t4, global::Array<object> f4) : base(1, 0)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t4 = t4;
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f4 = f4;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				global::pony.events.Event e4 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f4[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.Texture) (this.t4[0]) ), e4);
			}
			#line default
		}
		
		
		public  global::Array<object> t4;
		
		public  global::Array<object> f4;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_38__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_38__Fun(global::Array<object> t5, global::Array<object> f6) : base(0, 0)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t5 = t5;
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f6 = f6;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f6[0]) ).__hx_invoke1_o(default(double), ((global::UnityEngine.Texture) (this.t5[0]) ));
			}
			#line default
		}
		
		
		public  global::Array<object> t5;
		
		public  global::Array<object> f6;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_39__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_39__Fun(global::Array<object> f8, global::Array<object> t6) : base(0, 0)
		{
			unchecked 
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f8 = f8;
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t6 = t6;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f8[0]) ).__hx_invoke1_o(default(double), ((global::UnityEngine.Texture) (this.t6[0]) ));
			}
			#line default
		}
		
		
		public  global::Array<object> f8;
		
		public  global::Array<object> t6;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class TextureButtonUCore_Start_40__Fun : global::haxe.lang.Function 
	{
		public    TextureButtonUCore_Start_40__Fun(global::Array<object> f10, global::Array<object> t7) : base(0, 0)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.f10 = f10;
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				this.t7 = t7;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/TextureButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f10[0]) ).__hx_invoke1_o(default(double), ((global::UnityEngine.Texture) (this.t7[0]) ));
			}
			#line default
		}
		
		
		public  global::Array<object> f10;
		
		public  global::Array<object> t7;
		
	}
}



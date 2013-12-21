
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class GOButtonUCore : global::pony.unity3d.ui.TextureButton 
	{
		public    GOButtonUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    GOButtonUCore() : base()
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return new global::pony.unity3d.ui.ucore.GOButtonUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return new global::pony.unity3d.ui.ucore.GOButtonUCore();
			}
			#line default
		}
		
		
		public  global::UnityEngine.GameObject[] goDefs;
		
		public  global::UnityEngine.GameObject[] goOvers;
		
		public  global::UnityEngine.GameObject[] goPress;
		
		public  global::UnityEngine.GameObject glast;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				object __temp_stmt718 = default(object);
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				{
					#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goRestore"), ((int) (1677871622) ))) ), 0);
					#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					__temp_stmt718 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.core.changeVisual.@add(__temp_stmt718, default(global::haxe.lang.Null<int>));
				#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				{
					#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g1 = 0;
					#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g = ( this.goOvers as global::System.Array ).Length;
					#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					while (( _g1 < _g ))
					{
						#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						int i = _g1++;
						#line 25 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						if (( this.goOvers[i] != default(global::UnityEngine.GameObject) )) 
						{
							this.goOvers[i].active = false;
							global::haxe.lang.Function __temp_stmt720 = default(global::haxe.lang.Function);
							#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							{
								#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> g = new global::Array<object>(new object[]{this.goOvers[i]});
								#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> f1 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goset"), ((int) (402393722) ))) )});
								#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								__temp_stmt720 = new global::pony.unity3d.ui.ucore.GOButtonUCore_Start_27__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f1) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (g) ))) ));
							}
							
							#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							object __temp_stmt719 = global::pony._Function.Function_Impl_.@from(__temp_stmt720, 1);
							#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus, i})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt719, true), default(global::haxe.lang.Null<int>));
							global::haxe.lang.Function __temp_stmt722 = default(global::haxe.lang.Function);
							#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							{
								#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> g1 = new global::Array<object>(new object[]{this.goOvers[i]});
								#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> f2 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goset"), ((int) (402393722) ))) )});
								#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								__temp_stmt722 = new global::pony.unity3d.ui.ucore.GOButtonUCore_Start_28__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (g1) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f2) ))) ));
							}
							
							#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							object __temp_stmt721 = global::pony._Function.Function_Impl_.@from(__temp_stmt722, 1);
							#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave, i})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt721, true), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				{
					#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g11 = 0;
					#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g2 = ( this.goPress as global::System.Array ).Length;
					#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					while (( _g11 < _g2 ))
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						int i1 = _g11++;
						#line 31 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						if (( this.goPress[i1] != default(global::UnityEngine.GameObject) )) 
						{
							this.goPress[i1].active = false;
							global::haxe.lang.Function __temp_stmt724 = default(global::haxe.lang.Function);
							#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							{
								#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> g2 = new global::Array<object>(new object[]{this.goPress[i1]});
								#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> f3 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goset"), ((int) (402393722) ))) )});
								#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								__temp_stmt724 = new global::pony.unity3d.ui.ucore.GOButtonUCore_Start_33__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f3) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (g2) ))) ));
							}
							
							#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							object __temp_stmt723 = global::pony._Function.Function_Impl_.@from(__temp_stmt724, 1);
							#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press, i1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt723, true), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				{
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g12 = 0;
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					int _g3 = ( this.goDefs as global::System.Array ).Length;
					#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					while (( _g12 < _g3 ))
					{
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						int i2 = _g12++;
						#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						if (( this.goDefs[i2] != default(global::UnityEngine.GameObject) )) 
						{
							this.goDefs[i2].active = false;
							global::haxe.lang.Function __temp_stmt726 = default(global::haxe.lang.Function);
							#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							{
								#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> g3 = new global::Array<object>(new object[]{this.goDefs[i2]});
								#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								global::Array<object> f4 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goset"), ((int) (402393722) ))) )});
								#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
								__temp_stmt726 = new global::pony.unity3d.ui.ucore.GOButtonUCore_Start_38__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (g3) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f4) ))) ));
							}
							
							#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							object __temp_stmt725 = global::pony._Function.Function_Impl_.@from(__temp_stmt726, 1);
							#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
							this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default, i2})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(__temp_stmt725, true), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 41 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				base.Start();
			}
			#line default
		}
		
		
		public virtual   void goset(global::UnityEngine.GameObject g, global::pony.events.Event e)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.restoreColor();
				this.guiTexture.enabled = false;
				g.active = true;
				this.glast = g;
				{
					#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					if (( e.parent != default(global::pony.events.Event) )) 
					{
						#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						e.parent.stopPropagation();
					}
					
					#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					e._stopPropagation = true;
				}
				
			}
			#line default
		}
		
		
		public virtual   void goRestore()
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.guiTexture.enabled = true;
				if (( this.glast != default(global::UnityEngine.GameObject) )) 
				{
					#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
					this.glast.active = false;
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				switch (hash)
				{
					case 368233021:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.glast = ((global::UnityEngine.GameObject) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return @value;
					}
					
					
					case 2020972603:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.goPress = ((global::UnityEngine.GameObject[]) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return @value;
					}
					
					
					case 1739840855:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.goOvers = ((global::UnityEngine.GameObject[]) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return @value;
					}
					
					
					case 1165757782:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.goDefs = ((global::UnityEngine.GameObject[]) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				switch (hash)
				{
					case 1677871622:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goRestore"), ((int) (1677871622) ))) );
					}
					
					
					case 402393722:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goset"), ((int) (402393722) ))) );
					}
					
					
					case 389604418:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 368233021:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return this.glast;
					}
					
					
					case 2020972603:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return this.goPress;
					}
					
					
					case 1739840855:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return this.goOvers;
					}
					
					
					case 1165757782:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return this.goDefs;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1677871622:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.goRestore();
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						break;
					}
					
					
					case 402393722:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						this.goset(((global::UnityEngine.GameObject) (dynargs[0]) ), ((global::pony.events.Event) (dynargs[1]) ));
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				baseArr.push("glast");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				baseArr.push("goPress");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				baseArr.push("goOvers");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				baseArr.push("goDefs");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
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
	public  class GOButtonUCore_Start_27__Fun : global::haxe.lang.Function 
	{
		public    GOButtonUCore_Start_27__Fun(global::Array<object> f1, global::Array<object> g) : base(1, 0)
		{
			unchecked 
			{
				#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.f1 = f1;
				#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.g = g;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				global::pony.events.Event e = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 27 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f1[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.GameObject) (this.g[0]) ), e);
			}
			#line default
		}
		
		
		public  global::Array<object> f1;
		
		public  global::Array<object> g;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class GOButtonUCore_Start_28__Fun : global::haxe.lang.Function 
	{
		public    GOButtonUCore_Start_28__Fun(global::Array<object> g1, global::Array<object> f2) : base(1, 0)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.g1 = g1;
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.f2 = f2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				global::pony.events.Event e1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f2[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.GameObject) (this.g1[0]) ), e1);
			}
			#line default
		}
		
		
		public  global::Array<object> g1;
		
		public  global::Array<object> f2;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class GOButtonUCore_Start_33__Fun : global::haxe.lang.Function 
	{
		public    GOButtonUCore_Start_33__Fun(global::Array<object> f3, global::Array<object> g2) : base(1, 0)
		{
			unchecked 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.f3 = f3;
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.g2 = g2;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				global::pony.events.Event e2 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f3[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.GameObject) (this.g2[0]) ), e2);
			}
			#line default
		}
		
		
		public  global::Array<object> f3;
		
		public  global::Array<object> g2;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class GOButtonUCore_Start_38__Fun : global::haxe.lang.Function 
	{
		public    GOButtonUCore_Start_38__Fun(global::Array<object> g3, global::Array<object> f4) : base(1, 0)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.g3 = g3;
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				this.f4 = f4;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				global::pony.events.Event e3 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((global::pony.events.Event) (((object) (__fn_float1) )) )) : (((global::pony.events.Event) (__fn_dyn1) )) );
				#line 38 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/GOButtonUCore.hx"
				return ((global::haxe.lang.Function) (this.f4[0]) ).__hx_invoke2_o(default(double), default(double), ((global::UnityEngine.GameObject) (this.g3[0]) ), e3);
			}
			#line default
		}
		
		
		public  global::Array<object> g3;
		
		public  global::Array<object> f4;
		
	}
}



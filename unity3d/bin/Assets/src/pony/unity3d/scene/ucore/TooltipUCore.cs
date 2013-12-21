
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class TooltipUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    TooltipUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    TooltipUCore() : base()
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.lighted = false;
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.bigText = "";
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.text = "tooltip";
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				return new global::pony.unity3d.scene.ucore.TooltipUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				return new global::pony.unity3d.scene.ucore.TooltipUCore();
			}
			#line default
		}
		
		
		public  string text;
		
		public  string bigText;
		
		public  global::UnityEngine.Color colorMod;
		
		public  global::UnityEngine.Texture texture;
		
		public  global::Array<object> savedColors;
		
		public  bool subs;
		
		public  global::Array<object> subObjects;
		
		public  global::pony.unity3d.scene.MouseHelper ovr;
		
		public  bool lighted;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if (( ( this.colorMod == default(global::UnityEngine.Color) ) || ( ( ( this.colorMod.r == 0 ) && ( this.colorMod.g == 0 ) ) && ( this.colorMod.b == 0 ) ) )) 
				{
					if (( ((global::UnityEngine.Color) (global::pony.unity3d.Tooltip.defaultColorMod.@value) ) != default(global::UnityEngine.Color) )) 
					{
						this.colorMod = ((global::UnityEngine.Color) (global::pony.unity3d.Tooltip.defaultColorMod.@value) );
					}
					 else 
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						object __temp_stmt667 = default(object);
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						{
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("onDCL"), ((int) (845393966) ))) ), 1);
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							__temp_stmt667 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::pony.unity3d.Tooltip.defaultColorMod.@add(__temp_stmt667, default(global::haxe.lang.Null<int>));
					}
					
				}
				 else 
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::UnityEngine.Color v = this.colorMod;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::pony.events.LV<object> _this = global::pony.unity3d.Tooltip.defaultColorMod;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					if (( v != ((global::UnityEngine.Color) (_this.@value) ) )) 
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						_this.@value = v;
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						{
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{v})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							global::pony.events.LV<object> __temp_expr665 = _this;
						}
						
					}
					
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::UnityEngine.Color __temp_expr666 = v;
				}
				
				if (( global::pony.unity3d.Tooltip.texture == default(global::UnityEngine.Texture) )) 
				{
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::pony.unity3d.Tooltip.texture = this.texture;
				}
				
				#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				global::hugs.NativeArrayIterator<object> it = ((global::hugs.NativeArrayIterator<object>) (global::hugs.NativeArrayIterator<object>.__hx_cast<object>(((global::hugs.NativeArrayIterator) (global::hugs.GameObjectMethods.getComponentsInChildrenOfType<object>(this.gameObject, typeof(global::UnityEngine.Transform), default(global::haxe.lang.Null<bool>))) ))) );
				{
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{});
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					{
						#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator248 = it;
						#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						while (__temp_iterator248.hasNext())
						{
							#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							global::UnityEngine.Transform e = ((global::UnityEngine.Transform) (__temp_iterator248.next()) );
							#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							if (( ( e != this.transform ) && ( e.renderer != default(global::UnityEngine.Renderer) ) )) 
							{
								#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
								_g.push(e);
							}
							
						}
						
					}
					
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					this.subObjects = _g;
				}
				
				this.subs = ( this.subObjects.length > 0 );
				#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if ( ! (this.subs) ) 
				{
					this.subObjects = new global::Array<object>(new object[]{this.transform});
				}
				
				#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.ovr = ((global::pony.unity3d.scene.MouseHelper) (global::hugs.GameObjectMethods.getOrAddTypedComponent<object>(this.gameObject, typeof(global::pony.unity3d.scene.MouseHelper))) );
				object __temp_stmt668 = default(object);
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				{
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) ), 0);
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					__temp_stmt668 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
				}
				
				#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.ovr.over.@add(__temp_stmt668, default(global::haxe.lang.Null<int>));
				object __temp_stmt669 = default(object);
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					__temp_stmt669 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.ovr.@out.@add(__temp_stmt669, default(global::haxe.lang.Null<int>));
				object __temp_stmt670 = default(object);
				#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				{
					#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("pressOut"), ((int) (1879103691) ))) ), 0);
					#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					__temp_stmt670 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
				}
				
				#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.ovr.middleUp.@add(__temp_stmt670, default(global::haxe.lang.Null<int>));
				object __temp_stmt671 = default(object);
				#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				{
					#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					object f4 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("press"), ((int) (1216893827) ))) ), 0);
					#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					__temp_stmt671 = global::pony.events._Listener.Listener_Impl_._fromFunction(f4, false);
				}
				
				#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.ovr.middleDown.@add(__temp_stmt671, default(global::haxe.lang.Null<int>));
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.saveColors();
			}
			#line default
		}
		
		
		public virtual   void saveColors()
		{
			unchecked 
			{
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.savedColors = new global::Array<object>(new object[]{});
				{
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					int _g = 0;
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::Array<object> _g1 = this.subObjects;
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					while (( _g < _g1.length ))
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::UnityEngine.Transform e = ((global::UnityEngine.Transform) (_g1[_g]) );
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						 ++ _g;
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						if (e.renderer.material.HasProperty("_Color")) 
						{
							this.savedColors.push(e.renderer.material.color);
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void onDCL(global::UnityEngine.Color cl)
		{
			unchecked 
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				this.colorMod = cl;
			}
			#line default
		}
		
		
		public virtual   void over()
		{
			unchecked 
			{
				#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				try 
				{
					if (global::pony.unity3d.scene.MouseHelper.middleMousePressed) 
					{
						global::pony.unity3d.Tooltip.showText(this.text, this.bigText, this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), default(global::haxe.lang.Null<bool>));
					}
					 else 
					{
						#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::pony.unity3d.Tooltip.showText(this.text, "", this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), default(global::haxe.lang.Null<bool>));
					}
					
					this.lightUp();
				}
				catch (global::System.Exception __temp_catchallException672)
				{
					object __temp_catchall673 = __temp_catchallException672;
					#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					if (( __temp_catchall673 is global::haxe.lang.HaxeException )) 
					{
						#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						__temp_catchall673 = ((global::haxe.lang.HaxeException) (__temp_catchallException672) ).obj;
					}
					
					#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					{
						#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						object _ = __temp_catchall673;
						#line 107 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						{
						}
						
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public virtual   void @out()
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				try 
				{
					global::pony.unity3d.Tooltip.hideText(this);
					this.lightDown();
				}
				catch (global::System.Exception __temp_catchallException674)
				{
					object __temp_catchall675 = __temp_catchallException674;
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					if (( __temp_catchall675 is global::haxe.lang.HaxeException )) 
					{
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						__temp_catchall675 = ((global::haxe.lang.HaxeException) (__temp_catchallException674) ).obj;
					}
					
					#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					{
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						object _ = __temp_catchall675;
						#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						{
						}
						
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public virtual   void pressOut()
		{
			unchecked 
			{
				#line 119 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				global::pony.unity3d.Tooltip.showText(this.text, "", this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), default(global::haxe.lang.Null<bool>));
			}
			#line default
		}
		
		
		public virtual   void press()
		{
			unchecked 
			{
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				global::pony.unity3d.Tooltip.showText(this.text, this.bigText, this, new global::haxe.lang.Null<int>(this.gameObject.layer, true), default(global::haxe.lang.Null<bool>));
			}
			#line default
		}
		
		
		public virtual   void lightUp()
		{
			unchecked 
			{
				#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if (this.lighted) 
				{
					#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					return ;
				}
				
				this.lighted = true;
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					int _g = 0;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::Array<object> _g1 = this.subObjects;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					while (( _g < _g1.length ))
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::UnityEngine.Transform e = ((global::UnityEngine.Transform) (_g1[_g]) );
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						 ++ _g;
						if (e.renderer.material.HasProperty("_Color")) 
						{
							global::UnityEngine.Color sColor = e.renderer.material.color;
							e.renderer.material.color = new global::UnityEngine.Color(((float) (( sColor.r + this.colorMod.r )) ), ((float) (( sColor.g + this.colorMod.g )) ), ((float) (( sColor.b + this.colorMod.b )) ));
						}
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void lightDown()
		{
			unchecked 
			{
				#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if ( ! (this.lighted) ) 
				{
					#line 139 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					return ;
				}
				
				this.lighted = false;
				int i = 0;
				{
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					int _g = 0;
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					global::Array<object> _g1 = this.subObjects;
					#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					while (( _g < _g1.length ))
					{
						#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						global::UnityEngine.Transform e = ((global::UnityEngine.Transform) (_g1[_g]) );
						#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						 ++ _g;
						#line 144 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						try 
						{
							#line 144 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							e.renderer.material.color = ((global::UnityEngine.Color) (this.savedColors[i++]) );
						}
						catch (global::System.Exception __temp_catchallException676)
						{
							object __temp_catchall677 = __temp_catchallException676;
							#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							if (( __temp_catchall677 is global::haxe.lang.HaxeException )) 
							{
								#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
								__temp_catchall677 = ((global::haxe.lang.HaxeException) (__temp_catchallException676) ).obj;
							}
							
							#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
							{
								#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
								object _ = __temp_catchall677;
								#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
								{
								}
								
							}
							
						}
						
						
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if (isCheck) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					if (throwErrors) 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				if (throwErrors) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.active = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 434326197:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.lighted = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 5546347:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.ovr = ((global::pony.unity3d.scene.MouseHelper) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 2126059316:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.subObjects = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 1281140467:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.subs = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 1171039127:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.savedColors = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 518047963:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.texture = ((global::UnityEngine.Texture) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 166403359:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.colorMod = ((global::UnityEngine.Color) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 1825116557:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.bigText = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					case 1291439277:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.text = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 999020632:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lightDown"), ((int) (999020632) ))) );
					}
					
					
					case 434322641:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lightUp"), ((int) (434322641) ))) );
					}
					
					
					case 1216893827:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("press"), ((int) (1216893827) ))) );
					}
					
					
					case 1879103691:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("pressOut"), ((int) (1879103691) ))) );
					}
					
					
					case 5546126:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) );
					}
					
					
					case 1236832596:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) );
					}
					
					
					case 845393966:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("onDCL"), ((int) (845393966) ))) );
					}
					
					
					case 255873229:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("saveColors"), ((int) (255873229) ))) );
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 434326197:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.lighted;
					}
					
					
					case 5546347:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.ovr;
					}
					
					
					case 2126059316:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.subObjects;
					}
					
					
					case 1281140467:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.subs;
					}
					
					
					case 1171039127:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.savedColors;
					}
					
					
					case 518047963:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.texture;
					}
					
					
					case 166403359:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.colorMod;
					}
					
					
					case 1825116557:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.bigText;
					}
					
					
					case 1291439277:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return this.text;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 999020632:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.lightDown();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 434322641:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.lightUp();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 1216893827:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.press();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 1879103691:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.pressOut();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 5546126:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.@out();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 1236832596:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.over();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 845393966:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.onDCL(((global::UnityEngine.Color) (dynargs[0]) ));
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 255873229:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.saveColors();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						this.Start();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("hideFlags");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("name");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("tag");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("active");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("gameObject");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("particleSystem");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("particleEmitter");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("hingeJoint");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("collider");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("guiTexture");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("guiElement");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("networkView");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("guiText");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("audio");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("renderer");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("constantForce");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("animation");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("light");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("camera");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("rigidbody");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("transform");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("enabled");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("useGUILayout");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("lighted");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("ovr");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("subObjects");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("subs");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("savedColors");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("texture");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("colorMod");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("bigText");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/TooltipUCore.hx"
				baseArr.push("text");
			}
			#line default
		}
		
		
	}
}



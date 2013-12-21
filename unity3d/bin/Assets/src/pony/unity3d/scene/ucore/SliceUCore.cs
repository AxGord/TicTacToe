
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class SliceUCore : global::pony.unity3d.scene.TooltipSaver 
	{
		public    SliceUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    SliceUCore() : base()
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
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				return new global::pony.unity3d.scene.ucore.SliceUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				return new global::pony.unity3d.scene.ucore.SliceUCore();
			}
			#line default
		}
		
		
		public  global::UnityEngine.Material untransparentTexture;
		
		public  global::UnityEngine.GameObject buttonForSlice;
		
		public  global::pony.ui.ButtonCore buttonSlice;
		
		public  global::Array<object> childrenMaterials;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				base.Start();
				{
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{});
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					{
						#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator245 = global::hugs.ComponentMethods.getComponentsInChildrenOfType<object>(this, typeof(global::UnityEngine.Renderer), default(global::haxe.lang.Null<bool>));
						#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						while (__temp_iterator245.hasNext())
						{
							#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							global::UnityEngine.Renderer e = ((global::UnityEngine.Renderer) (__temp_iterator245.next()) );
							#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							_g.push(e.material);
						}
						
					}
					
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					this.childrenMaterials = _g;
				}
				
				this.buttonSlice = ((global::pony.unity3d.ui.TintButton) (global::hugs.GameObjectMethods.getTypedComponent<object>(this.buttonForSlice, typeof(global::pony.unity3d.ui.TintButton))) ).core;
				object __temp_stmt664 = default(object);
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				{
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("click"), ((int) (1214151752) ))) ), 1);
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					__temp_stmt664 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				this.buttonSlice.click.@add(__temp_stmt664, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public   void click(int mode)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				if (( mode == 2 )) 
				{
					{
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator246 = global::hugs.ComponentMethods.getComponentsInChildrenOfType<object>(this, typeof(global::UnityEngine.Renderer), default(global::haxe.lang.Null<bool>));
						#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						while (__temp_iterator246.hasNext())
						{
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							global::UnityEngine.Renderer e = ((global::UnityEngine.Renderer) (__temp_iterator246.next()) );
							#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							e.material = this.untransparentTexture;
						}
						
					}
					
				}
				 else 
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					int i = 0;
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						global::hugs.NativeArrayIterator<object> __temp_iterator247 = global::hugs.ComponentMethods.getComponentsInChildrenOfType<object>(this, typeof(global::UnityEngine.Renderer), default(global::haxe.lang.Null<bool>));
						#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						while (__temp_iterator247.hasNext())
						{
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							global::UnityEngine.Renderer e1 = ((global::UnityEngine.Renderer) (__temp_iterator247.next()) );
							#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
							e1.material = ((global::UnityEngine.Material) (this.childrenMaterials[i++]) );
						}
						
					}
					
				}
				
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					int _g = 0;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					global::Array<object> _g1 = this.tooltips;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					while (( _g < _g1.length ))
					{
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						global::pony.unity3d.scene.Tooltip e2 = ((global::pony.unity3d.scene.Tooltip) (_g1[_g]) );
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						 ++ _g;
						#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						e2.saveColors();
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				switch (hash)
				{
					case 205315245:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						this.childrenMaterials = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return @value;
					}
					
					
					case 1282573568:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						this.buttonSlice = ((global::pony.ui.ButtonCore) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return @value;
					}
					
					
					case 1830595739:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						this.buttonForSlice = ((global::UnityEngine.GameObject) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return @value;
					}
					
					
					case 933864514:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						this.untransparentTexture = ((global::UnityEngine.Material) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
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
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				switch (hash)
				{
					case 1214151752:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("click"), ((int) (1214151752) ))) );
					}
					
					
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 205315245:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return this.childrenMaterials;
					}
					
					
					case 1282573568:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return this.buttonSlice;
					}
					
					
					case 1830595739:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return this.buttonForSlice;
					}
					
					
					case 933864514:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return this.untransparentTexture;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
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
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1214151752:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						this.click(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				baseArr.push("childrenMaterials");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				baseArr.push("buttonSlice");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				baseArr.push("buttonForSlice");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				baseArr.push("untransparentTexture");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/SliceUCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



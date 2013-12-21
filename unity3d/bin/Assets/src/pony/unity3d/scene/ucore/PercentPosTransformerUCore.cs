
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class PercentPosTransformerUCore : global::pony.unity3d.scene.ucore.PercentPosUCore 
	{
		public    PercentPosTransformerUCore(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    PercentPosTransformerUCore() : base()
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
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentPosTransformerUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentPosTransformerUCore();
			}
			#line default
		}
		
		
		public  global::UnityEngine.GameObject defaultView;
		
		public  global::UnityEngine.GameObject transformedView;
		
		public  float[] points;
		
		public override   double _set_percent(double v)
		{
			unchecked 
			{
				#line 20 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				v = base._set_percent(v);
				int i = ( this.points as global::System.Array ).Length;
				while (( i-- > 0 ))
				{
					#line 22 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
					if (( ( this.nullPos + ( this.size * v ) ) > this.points[i] )) 
					{
						this.defaultView.active = ( ( i % 2 ) != 0 );
						this.transformedView.active =  ! (this.defaultView.active) ;
						break;
					}
					
				}
				
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				return v;
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				switch (hash)
				{
					case 1999508003:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						this.points = ((float[]) (@value) );
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return @value;
					}
					
					
					case 906418384:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						this.transformedView = ((global::UnityEngine.GameObject) (@value) );
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return @value;
					}
					
					
					case 537799622:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						this.defaultView = ((global::UnityEngine.GameObject) (@value) );
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
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
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				switch (hash)
				{
					case 155324904:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_percent"), ((int) (155324904) ))) );
					}
					
					
					case 1999508003:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return this.points;
					}
					
					
					case 906418384:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return this.transformedView;
					}
					
					
					case 537799622:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return this.defaultView;
					}
					
					
					default:
					{
						#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				baseArr.push("points");
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				baseArr.push("transformedView");
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				baseArr.push("defaultView");
				#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
				{
					#line 12 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosTransformerUCore.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



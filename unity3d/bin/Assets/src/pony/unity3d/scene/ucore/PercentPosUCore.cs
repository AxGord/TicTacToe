
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class PercentPosUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject, global::pony.IPercent 
	{
		public    PercentPosUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    PercentPosUCore() : base()
		{
			unchecked 
			{
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				this.percent = ((double) (1) );
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentPosUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentPosUCore();
			}
			#line default
		}
		
		
		public  double percent;
		
		public  double nullPos;
		
		public  double initPos;
		
		public  double size;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				this.initPos = ((double) (this.transform.localPosition.y) );
				this.size = global::System.Math.Abs(((double) (( (( this.nullPos > this.initPos )) ? (( this.nullPos - this.initPos )) : (( this.initPos - this.nullPos )) )) ));
			}
			#line default
		}
		
		
		public virtual   double _set_percent(double v)
		{
			unchecked 
			{
				#line 29 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				if (( this.size == 0 )) 
				{
					if (( this.renderer != default(global::UnityEngine.Renderer) )) 
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.renderer.enabled = false;
					}
					
					return v;
				}
				
				#line 33 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				if (( ( v > 0 ) || ( this.renderer == default(global::UnityEngine.Renderer) ) )) 
				{
					this.transform.localPosition = new global::UnityEngine.Vector3(((float) (this.transform.localPosition.x) ), ((float) (( this.nullPos + ( this.size * v ) )) ), ((float) (this.transform.localPosition.z) ));
					if (( this.renderer != default(global::UnityEngine.Renderer) )) 
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.renderer.enabled = true;
					}
					
				}
				 else 
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
					this.renderer.enabled = false;
				}
				
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				return this.percent = v;
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				if (isCheck) 
				{
					#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
					if (throwErrors) 
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
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
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				if (throwErrors) 
				{
					#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				switch (hash)
				{
					case 1280549057:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.size = ((double) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 1267475556:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.initPos = ((double) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 484509005:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.nullPos = ((double) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						if (handleProperties) 
						{
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							this._set_percent(@value);
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							return @value;
						}
						 else 
						{
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							this.percent = ((double) (@value) );
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
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
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.active = ((bool) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 1280549057:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.size = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 1267475556:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.initPos = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 484509005:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.nullPos = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						if (handleProperties) 
						{
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							return @value;
						}
						 else 
						{
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							this.percent = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
							#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
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
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 155324904:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_percent"), ((int) (155324904) ))) );
					}
					
					
					case 389604418:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1280549057:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.size;
					}
					
					
					case 1267475556:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.initPos;
					}
					
					
					case 484509005:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.nullPos;
					}
					
					
					case 2027596485:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
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
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				switch (hash)
				{
					case 1280549057:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.size;
					}
					
					
					case 1267475556:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.initPos;
					}
					
					
					case 484509005:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.nullPos;
					}
					
					
					case 2027596485:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
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
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 155324904:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 389604418:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						this.Start();
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("hideFlags");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("name");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("tag");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("active");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("gameObject");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("particleSystem");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("particleEmitter");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("hingeJoint");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("collider");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("guiTexture");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("guiElement");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("networkView");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("guiText");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("audio");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("renderer");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("constantForce");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("animation");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("light");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("camera");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("rigidbody");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("transform");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("enabled");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("useGUILayout");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("size");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("initPos");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("nullPos");
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentPosUCore.hx"
				baseArr.push("percent");
			}
			#line default
		}
		
		
	}
}



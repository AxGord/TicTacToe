
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class PercentSizeUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject, global::pony.IPercent 
	{
		public    PercentSizeUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    PercentSizeUCore() : base()
		{
			unchecked 
			{
				#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				this.d = ((double) (2) );
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				this.zeroInCenter = true;
				#line 15 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				this.percent = ((double) (1) );
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentSizeUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				return new global::pony.unity3d.scene.ucore.PercentSizeUCore();
			}
			#line default
		}
		
		
		public  double percent;
		
		public  bool zeroInCenter;
		
		public  double d;
		
		public  double initValue;
		
		public  double initPos;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 23 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				this.initValue = ((double) (this.transform.lossyScale.y) );
				this.initPos = ((double) (this.transform.localPosition.y) );
			}
			#line default
		}
		
		
		public virtual   double _set_percent(double v)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				if (( v > 0 )) 
				{
					this.renderer.enabled = true;
					this.transform.localScale = new global::UnityEngine.Vector3(((float) (this.transform.localScale.x) ), ((float) (( v * this.initValue )) ), ((float) (this.transform.localScale.z) ));
					if (this.zeroInCenter) 
					{
						this.transform.localPosition = new global::UnityEngine.Vector3(((float) (this.transform.localPosition.x) ), ((float) (( this.initPos - (( (( v < 1 )) ? (( ( (( 1 - v )) * this.initValue ) / this.d )) : (((double) (0) )) )) )) ), ((float) (this.transform.localPosition.z) ));
					}
					
				}
				 else 
				{
					#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
					this.renderer.enabled = false;
				}
				
				#line 36 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				return this.percent = v;
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				if (isCheck) 
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
					if (throwErrors) 
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				if (throwErrors) 
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				switch (hash)
				{
					case 1267475556:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.initPos = ((double) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 1296734785:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.initValue = ((double) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 100:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.d = ((double) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						if (handleProperties) 
						{
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							this._set_percent(@value);
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							return @value;
						}
						 else 
						{
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							this.percent = ((double) (@value) );
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.active = ((bool) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 1267475556:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.initPos = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 1296734785:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.initValue = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 100:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.d = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 752591586:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.zeroInCenter = ((bool) (@value) );
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						if (handleProperties) 
						{
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							return @value;
						}
						 else 
						{
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							this.percent = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
							#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 155324904:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_percent"), ((int) (155324904) ))) );
					}
					
					
					case 389604418:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1267475556:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.initPos;
					}
					
					
					case 1296734785:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.initValue;
					}
					
					
					case 100:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.d;
					}
					
					
					case 752591586:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.zeroInCenter;
					}
					
					
					case 2027596485:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				switch (hash)
				{
					case 1267475556:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.initPos;
					}
					
					
					case 1296734785:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.initValue;
					}
					
					
					case 100:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.d;
					}
					
					
					case 2027596485:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
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
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 155324904:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 389604418:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						this.Start();
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("hideFlags");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("name");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("tag");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("active");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("gameObject");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("particleSystem");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("particleEmitter");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("hingeJoint");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("collider");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("guiTexture");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("guiElement");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("networkView");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("guiText");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("audio");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("renderer");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("constantForce");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("animation");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("light");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("camera");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("rigidbody");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("transform");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("enabled");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("useGUILayout");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("initPos");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("initValue");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("d");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("zeroInCenter");
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/PercentSizeUCore.hx"
				baseArr.push("percent");
			}
			#line default
		}
		
		
	}
}



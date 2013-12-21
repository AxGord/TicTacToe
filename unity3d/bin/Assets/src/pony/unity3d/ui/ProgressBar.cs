
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class ProgressBar : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject, global::pony.IPercent 
	{
		public    ProgressBar(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    ProgressBar() : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				return new global::pony.unity3d.ui.ProgressBar(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				return new global::pony.unity3d.ui.ProgressBar();
			}
			#line default
		}
		
		
		public  double percent;
		
		public  float full;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				this.full = this.guiTexture.pixelInset.width;
				this.@set(((double) (0) ));
			}
			#line default
		}
		
		
		public virtual   void @set(double progress)
		{
			unchecked 
			{
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				this.guiTexture.pixelInset = new global::UnityEngine.Rect(((float) (this.guiTexture.pixelInset.x) ), ((float) (this.guiTexture.pixelInset.y) ), ((float) (( this.full * progress )) ), ((float) (this.guiTexture.pixelInset.height) ));
			}
			#line default
		}
		
		
		public   double _set_percent(double v)
		{
			unchecked 
			{
				#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				this.@set(v);
				return v;
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				if (isCheck) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
					if (throwErrors) 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				if (throwErrors) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				switch (hash)
				{
					case 1136978319:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.full = ((float) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						if (handleProperties) 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							this._set_percent(@value);
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							return @value;
						}
						 else 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							this.percent = ((double) (@value) );
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.active = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.enabled = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 1136978319:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.full = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return @value;
					}
					
					
					case 2027596485:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						if (handleProperties) 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							return @value;
						}
						 else 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							this.percent = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.useGUILayout;
					}
					
					
					case 155324904:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_percent"), ((int) (155324904) ))) );
					}
					
					
					case 5741474:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
					}
					
					
					case 389604418:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1136978319:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.full;
					}
					
					
					case 2027596485:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				switch (hash)
				{
					case 1136978319:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((double) (this.full) );
					}
					
					
					case 2027596485:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this.percent;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 155324904:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return this._set_percent(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 5741474:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.@set(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						this.Start();
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						break;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("hideFlags");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("name");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("tag");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("active");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("gameObject");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("particleSystem");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("particleEmitter");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("hingeJoint");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("collider");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("guiTexture");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("guiElement");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("networkView");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("guiText");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("audio");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("renderer");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("constantForce");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("animation");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("light");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("camera");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("rigidbody");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("transform");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("enabled");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("useGUILayout");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("full");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ProgressBar.hx"
				baseArr.push("percent");
			}
			#line default
		}
		
		
	}
}



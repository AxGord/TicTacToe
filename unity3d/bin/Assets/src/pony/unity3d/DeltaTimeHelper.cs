
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class DeltaTimeHelper : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    DeltaTimeHelper(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    DeltaTimeHelper() : base()
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				return new global::pony.unity3d.DeltaTimeHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				return new global::pony.unity3d.DeltaTimeHelper();
			}
			#line default
		}
		
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 14 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				global::pony.DeltaTime.fixedValue = ((double) (global::UnityEngine.Time.fixedDeltaTime) );
				global::pony.DeltaTime.@value = ( global::pony.DeltaTime.fixedValue * global::pony.DeltaTime.speed );
				{
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					{
						#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<double>(new double[]{global::pony.DeltaTime.@value})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						global::pony.events.Signal __temp_expr262 = this1;
					}
					
					#line 16 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					object __temp_expr263 = this1.target;
				}
				
				{
					#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					global::pony.events.Signal this2 = global::pony.DeltaTime.fixedUpdate;
					#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					{
						#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<double>(new double[]{global::pony.DeltaTime.fixedValue})) ), ((object) (this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						global::pony.events.Signal __temp_expr264 = this2;
					}
					
					#line 17 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					object __temp_expr265 = this2.target;
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				if (isCheck) 
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					if (throwErrors) 
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				if (throwErrors) 
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				switch (hash)
				{
					default:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.active = ((bool) (@value) );
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.enabled = ((bool) (@value) );
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return this.useGUILayout;
					}
					
					
					case 999946793:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					default:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				switch (hash)
				{
					default:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
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
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 999946793:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						this.Update();
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						break;
					}
					
					
					default:
					{
						#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("hideFlags");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("name");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("tag");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("active");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("gameObject");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("particleSystem");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("particleEmitter");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("hingeJoint");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("collider");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("guiTexture");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("guiElement");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("networkView");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("guiText");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("audio");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("renderer");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("constantForce");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("animation");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("light");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("camera");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("rigidbody");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("transform");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("enabled");
				#line 11 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/DeltaTimeHelper.hx"
				baseArr.push("useGUILayout");
			}
			#line default
		}
		
		
	}
}


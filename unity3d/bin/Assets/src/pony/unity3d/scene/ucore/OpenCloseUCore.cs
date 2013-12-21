
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class OpenCloseUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    OpenCloseUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    OpenCloseUCore() : base()
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				this.open = false;
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				{
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					global::pony.events.Signal this1 = global::pony.events.Signal.create<object>(this);
					#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.onOpen = ((global::pony.events.Signal) (this1) );
				}
				
				{
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					global::pony.events.Signal this2 = global::pony.events.Signal.create<object>(this);
					#line 53 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.onClose = ((global::pony.events.Signal) (this2) );
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				return new global::pony.unity3d.scene.ucore.OpenCloseUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				return new global::pony.unity3d.scene.ucore.OpenCloseUCore();
			}
			#line default
		}
		
		
		public  global::UnityEngine.Vector3 openPos;
		
		public  global::UnityEngine.Quaternion openRotation;
		
		public  bool open;
		
		public  global::pony.events.Signal onOpen;
		
		public  global::pony.events.Signal onClose;
		
		public  global::UnityEngine.Vector3 startPos;
		
		public  global::UnityEngine.Quaternion startRotation;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				this.startPos = this.transform.position;
				this.startRotation = this.transform.rotation;
				if (( ( ( this.openPos.x == 0 ) && ( this.openPos.y == 0 ) ) && ( this.openPos.z == 0 ) )) 
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.openPos = this.startPos;
				}
				
				if (( ( ( this.openRotation.x == 0 ) && ( this.openRotation.y == 0 ) ) && ( this.openRotation.z == 0 ) )) 
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.openRotation = this.startRotation;
				}
				
			}
			#line default
		}
		
		
		public virtual   bool _set_open(bool to)
		{
			unchecked 
			{
				#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				if (( this.open == to )) 
				{
					#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					return to;
				}
				
				if (to) 
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.transform.position = this.openPos;
				}
				 else 
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.transform.position = this.startPos;
				}
				
				if (to) 
				{
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.transform.rotation = this.openRotation;
				}
				 else 
				{
					#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this.transform.rotation = this.startRotation;
				}
				
				if (to) 
				{
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					global::pony.events.Signal this1 = this.onOpen;
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this1.dispatchEmpty(default(object));
					#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					object __temp_expr644 = this1.target;
				}
				 else 
				{
					global::pony.events.Signal this2 = this.onClose;
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					this2.dispatchEmpty(default(object));
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					object __temp_expr643 = this2.target;
				}
				
				return this.open = to;
			}
			#line default
		}
		
		
		public virtual   void change()
		{
			unchecked 
			{
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				this._set_open( ! (this.open) );
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				if (isCheck) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					if (throwErrors) 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				if (throwErrors) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.active = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 222404544:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.startRotation = ((global::UnityEngine.Quaternion) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1117325906:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.startPos = ((global::UnityEngine.Vector3) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1587590681:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.onClose = ((global::pony.events.Signal) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1816005769:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.onOpen = ((global::pony.events.Signal) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1236534218:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						if (handleProperties) 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
							this._set_open(((bool) (@value) ));
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
							return @value;
						}
						 else 
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
							this.open = ((bool) (@value) );
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
							return @value;
						}
						
					}
					
					
					case 1185142568:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.openRotation = ((global::UnityEngine.Quaternion) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					case 1077021674:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.openPos = ((global::UnityEngine.Vector3) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 930255216:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("change"), ((int) (930255216) ))) );
					}
					
					
					case 2009864391:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_open"), ((int) (2009864391) ))) );
					}
					
					
					case 389604418:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 222404544:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.startRotation;
					}
					
					
					case 1117325906:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.startPos;
					}
					
					
					case 1587590681:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.onClose;
					}
					
					
					case 1816005769:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.onOpen;
					}
					
					
					case 1236534218:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.open;
					}
					
					
					case 1185142568:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.openRotation;
					}
					
					
					case 1077021674:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this.openPos;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 930255216:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.change();
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						break;
					}
					
					
					case 2009864391:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return this._set_open(((bool) (dynargs[0]) ));
					}
					
					
					case 389604418:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						this.Start();
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("hideFlags");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("name");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("tag");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("active");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("gameObject");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("particleSystem");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("particleEmitter");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("hingeJoint");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("collider");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("guiTexture");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("guiElement");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("networkView");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("guiText");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("audio");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("renderer");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("constantForce");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("animation");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("light");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("camera");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("rigidbody");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("transform");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("enabled");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("useGUILayout");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("startRotation");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("startPos");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("onClose");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("onOpen");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("open");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("openRotation");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/OpenCloseUCore.hx"
				baseArr.push("openPos");
			}
			#line default
		}
		
		
	}
}



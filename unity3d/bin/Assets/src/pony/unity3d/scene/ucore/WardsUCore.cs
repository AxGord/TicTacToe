
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene.ucore
{
	public  class WardsUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject, global::pony.IWards 
	{
		public    WardsUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    WardsUCore() : base()
		{
			unchecked 
			{
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.rn = ((float) (0) );
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.currentPos = -1;
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.speed = ((float) (200) );
				#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.withTimeScale = true;
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.withRotation = true;
				#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.change = new global::pony.events.Signal(((object) (this) ));
				object __temp_stmt683 = default(object);
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				{
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeHandler"), ((int) (648696890) ))) ), 1);
					#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					__temp_stmt683 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.change.@add(__temp_stmt683, default(global::haxe.lang.Null<int>));
				this.changed = new global::pony.events.Signal(((object) (this) ));
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				return new global::pony.unity3d.scene.ucore.WardsUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				return new global::pony.unity3d.scene.ucore.WardsUCore();
			}
			#line default
		}
		
		
		public  bool withRotation;
		
		public  bool withTimeScale;
		
		public  float speed;
		
		public  int currentPos;
		
		public  global::pony.events.Signal change;
		
		public  global::pony.events.Signal changed;
		
		public  global::UnityEngine.GameObject target;
		
		public  global::Array<object> wards;
		
		public  global::haxe.lang.Null<int> toN;
		
		public  global::UnityEngine.Transform toObj;
		
		public  float rn;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (( this.target == default(global::UnityEngine.GameObject) )) 
				{
					#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					this.target = global::hugs.GameObjectMethods.getChildGameObject(this.gameObject, "obj");
				}
				
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				this.wards = new global::Array<object>(new object[]{});
				{
					#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					int _g = 1;
					#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					while (( _g < 10000 ))
					{
						#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						int i = _g++;
						global::UnityEngine.Transform t = this.transform.Find(global::Std.@string(i));
						if (( t == default(global::UnityEngine.Transform) )) 
						{
							#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
							break;
						}
						
						this.wards.push(t);
					}
					
				}
				
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				{
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					global::pony.events.Signal _this = this.change;
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{0})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					global::pony.events.Signal __temp_expr678 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void changeHandler(int n)
		{
			unchecked 
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (( n == this.currentPos )) 
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					return ;
				}
				
				this.currentPos = n;
				this.toN = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(n, true).@value, true);
				this.toObj = ((global::UnityEngine.Transform) (this.wards[n]) );
			}
			#line default
		}
		
		
		public   void @goto(int n)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal _this = this.change;
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{n})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
				global::pony.events.Signal __temp_expr679 = _this;
			}
			#line default
		}
		
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (( this.toObj == default(global::UnityEngine.Transform) )) 
				{
					#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					return ;
				}
				
				float dt = default(float);
				#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (this.withTimeScale) 
				{
					#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					dt = global::UnityEngine.Time.deltaTime;
				}
				 else 
				{
					#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					dt = global::UnityEngine.Time.fixedDeltaTime;
				}
				
				global::UnityEngine.Vector3 p = this.toObj.position;
				global::UnityEngine.Quaternion r = this.toObj.rotation;
				this.target.transform.position = global::UnityEngine.Vector3.MoveTowards(this.target.transform.position, p, ( this.speed * dt ));
				if (this.withRotation) 
				{
					this.target.transform.rotation = global::UnityEngine.Quaternion.Slerp(this.target.transform.rotation, r, ( ( this.speed * (this.rn += ( this.speed * 2 )) ) * dt ));
				}
				
				if (( this.target.transform.position == p )) 
				{
					#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					this.toN = new global::haxe.lang.Null<int>(default(global::haxe.lang.Null<int>).@value, true);
					this.toObj = default(global::UnityEngine.Transform);
					this.rn = ((float) (0) );
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal _this = this.changed;
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{this.currentPos})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						global::pony.events.Signal __temp_expr680 = _this;
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void goNext()
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (( this.currentPos < ( this.wards.length - 1 ) )) 
				{
					global::pony.events.Signal _this = this.change;
					#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( this.currentPos + 1 )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					global::pony.events.Signal __temp_expr681 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void goPrev()
		{
			unchecked 
			{
				#line 117 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (( this.currentPos > 0 )) 
				{
					global::pony.events.Signal _this = this.change;
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{( this.currentPos - 1 )})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					global::pony.events.Signal __temp_expr682 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (isCheck) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					if (throwErrors) 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				if (throwErrors) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				switch (hash)
				{
					case 25532:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.rn = ((float) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 1194336987:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.currentPos = ((int) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 23697287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.speed = ((float) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.active = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 25532:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.rn = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 337002812:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.toObj = ((global::UnityEngine.Transform) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 5793395:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.toN = new global::haxe.lang.Null<int>(global::haxe.lang.Null<object>.ofDynamic<int>(@value).@value, true);
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 1159959223:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.wards = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 116192081:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.target = ((global::UnityEngine.GameObject) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 1288483060:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.changed = ((global::pony.events.Signal) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 930255216:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.change = ((global::pony.events.Signal) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 1194336987:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.currentPos = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 23697287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.speed = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 916069463:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.withTimeScale = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					case 557770084:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.withRotation = ((bool) (@value) );
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 1299478843:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goPrev"), ((int) (1299478843) ))) );
					}
					
					
					case 1276657467:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goNext"), ((int) (1276657467) ))) );
					}
					
					
					case 999946793:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 1147771299:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("goto"), ((int) (1147771299) ))) );
					}
					
					
					case 648696890:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeHandler"), ((int) (648696890) ))) );
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 25532:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.rn;
					}
					
					
					case 337002812:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.toObj;
					}
					
					
					case 5793395:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return (this.toN).toDynamic();
					}
					
					
					case 1159959223:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.wards;
					}
					
					
					case 116192081:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.target;
					}
					
					
					case 1288483060:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.changed;
					}
					
					
					case 930255216:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.change;
					}
					
					
					case 1194336987:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.currentPos;
					}
					
					
					case 23697287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.speed;
					}
					
					
					case 916069463:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.withTimeScale;
					}
					
					
					case 557770084:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return this.withRotation;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				switch (hash)
				{
					case 25532:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((double) (this.rn) );
					}
					
					
					case 1194336987:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((double) (this.currentPos) );
					}
					
					
					case 23697287:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((double) (this.speed) );
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
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
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1299478843:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.goPrev();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					case 1276657467:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.goNext();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					case 999946793:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.Update();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					case 1147771299:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.@goto(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					case 648696890:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.changeHandler(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						this.Start();
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("hideFlags");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("name");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("tag");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("active");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("gameObject");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("particleSystem");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("particleEmitter");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("hingeJoint");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("collider");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("guiTexture");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("guiElement");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("networkView");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("guiText");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("audio");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("renderer");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("constantForce");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("animation");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("light");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("camera");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("rigidbody");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("transform");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("enabled");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("useGUILayout");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("rn");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("toObj");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("toN");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("wards");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("target");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("changed");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("change");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("currentPos");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("speed");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("withTimeScale");
				#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/ucore/WardsUCore.hx"
				baseArr.push("withRotation");
			}
			#line default
		}
		
		
	}
}



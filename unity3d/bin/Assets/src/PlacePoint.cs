
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class PlacePoint : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
{
	public    PlacePoint(global::haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
		#line default
	}
	
	
	public    PlacePoint() : base()
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
			#line 17 "src/PlacePoint.hx"
			return new global::PlacePoint(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static   object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			return new global::PlacePoint();
		}
		#line default
	}
	
	
	public  global::pony.events.Signal click;
	
	public  global::UnityEngine.GameObject g;
	
	public virtual   void Start()
	{
		unchecked 
		{
			#line 24 "src/PlacePoint.hx"
			global::pony.unity3d.scene.MouseHelper h = ((global::pony.unity3d.scene.MouseHelper) (global::hugs.GameObjectMethods.getOrAddTypedComponent<object>(this.gameObject, typeof(global::pony.unity3d.scene.MouseHelper))) );
			object __temp_stmt285 = default(object);
			#line 25 "src/PlacePoint.hx"
			{
				#line 25 "src/PlacePoint.hx"
				object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) ), 0);
				#line 25 "src/PlacePoint.hx"
				__temp_stmt285 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
			}
			
			#line 25 "src/PlacePoint.hx"
			h.over.@add(__temp_stmt285, default(global::haxe.lang.Null<int>));
			object __temp_stmt286 = default(object);
			#line 26 "src/PlacePoint.hx"
			{
				#line 26 "src/PlacePoint.hx"
				object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) ), 0);
				#line 26 "src/PlacePoint.hx"
				__temp_stmt286 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
			}
			
			#line 26 "src/PlacePoint.hx"
			h.@out.@add(__temp_stmt286, default(global::haxe.lang.Null<int>));
			this.click = h.down;
		}
		#line default
	}
	
	
	public virtual   void over()
	{
		unchecked 
		{
			#line 31 "src/PlacePoint.hx"
			this.transform.localScale = new global::UnityEngine.Vector3(((float) (2) ), ((float) (2) ), ((float) (2) ));
		}
		#line default
	}
	
	
	public virtual   void @out()
	{
		unchecked 
		{
			#line 35 "src/PlacePoint.hx"
			this.transform.localScale = new global::UnityEngine.Vector3(((float) (1) ), ((float) (1) ), ((float) (1) ));
		}
		#line default
	}
	
	
	public virtual   void @set(global::pony.events.Event e)
	{
		unchecked 
		{
			#line 39 "src/PlacePoint.hx"
			if (( this.g != default(global::UnityEngine.GameObject) )) 
			{
				global::UnityEngine.Object.Destroy(((global::UnityEngine.Object) (this.g) ));
				this.g = default(global::UnityEngine.GameObject);
			}
			
			#line 43 "src/PlacePoint.hx"
			global::Player p = ((global::Player) (e.args[0]) );
			if (( p != default(global::Player) )) 
			{
				this.g = ((global::UnityEngine.GameObject) (global::UnityEngine.Object.Instantiate(((global::UnityEngine.GameObject) (global::Scene.players.@get(p).@value) ), ((global::UnityEngine.Vector3) (this.transform.position) ), ((global::UnityEngine.Quaternion) (this.transform.rotation) ))) );
				this.g.active = true;
				this.gameObject.active = false;
			}
			 else 
			{
				#line 49 "src/PlacePoint.hx"
				this.gameObject.active = true;
			}
			
		}
		#line default
	}
	
	
	public virtual   bool __hx_deleteField(string field, int hash)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			return false;
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			if (isCheck) 
			{
				#line 17 "src/PlacePoint.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			 else 
			{
				#line 17 "src/PlacePoint.hx"
				if (throwErrors) 
				{
					#line 17 "src/PlacePoint.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found.");
				}
				 else 
				{
					#line 17 "src/PlacePoint.hx"
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
			#line 17 "src/PlacePoint.hx"
			if (throwErrors) 
			{
				#line 17 "src/PlacePoint.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			 else 
			{
				#line 17 "src/PlacePoint.hx"
				return default(double);
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupSetField(string field, int hash, object @value)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		#line default
	}
	
	
	public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			switch (hash)
			{
				default:
				{
					#line 17 "src/PlacePoint.hx"
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
			#line 17 "src/PlacePoint.hx"
			switch (hash)
			{
				case 1575675685:
				{
					#line 17 "src/PlacePoint.hx"
					this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 1224700491:
				{
					#line 17 "src/PlacePoint.hx"
					this.name = global::haxe.lang.Runtime.toString(@value);
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 5790298:
				{
					#line 17 "src/PlacePoint.hx"
					this.tag = global::haxe.lang.Runtime.toString(@value);
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 373703110:
				{
					#line 17 "src/PlacePoint.hx"
					this.active = ((bool) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 2117141633:
				{
					#line 17 "src/PlacePoint.hx"
					this.enabled = ((bool) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 896046654:
				{
					#line 17 "src/PlacePoint.hx"
					this.useGUILayout = ((bool) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 103:
				{
					#line 17 "src/PlacePoint.hx"
					this.g = ((global::UnityEngine.GameObject) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				case 1214151752:
				{
					#line 17 "src/PlacePoint.hx"
					this.click = ((global::pony.events.Signal) (@value) );
					#line 17 "src/PlacePoint.hx"
					return @value;
				}
				
				
				default:
				{
					#line 17 "src/PlacePoint.hx"
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
			#line 17 "src/PlacePoint.hx"
			switch (hash)
			{
				case 1826409040:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
				}
				
				
				case 304123084:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
				}
				
				
				case 276486854:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
				}
				
				
				case 295397041:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
				}
				
				
				case 1955029599:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
				}
				
				
				case 1575675685:
				{
					#line 17 "src/PlacePoint.hx"
					return this.hideFlags;
				}
				
				
				case 1224700491:
				{
					#line 17 "src/PlacePoint.hx"
					return this.name;
				}
				
				
				case 294420221:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
				}
				
				
				case 139469119:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
				}
				
				
				case 967979664:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
				}
				
				
				case 2122408236:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
				}
				
				
				case 1328964235:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
				}
				
				
				case 1723652455:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
				}
				
				
				case 89600725:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
				}
				
				
				case 2134927590:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
				}
				
				
				case 5790298:
				{
					#line 17 "src/PlacePoint.hx"
					return this.tag;
				}
				
				
				case 373703110:
				{
					#line 17 "src/PlacePoint.hx"
					return this.active;
				}
				
				
				case 1471506513:
				{
					#line 17 "src/PlacePoint.hx"
					return this.gameObject;
				}
				
				
				case 1751728597:
				{
					#line 17 "src/PlacePoint.hx"
					return this.particleSystem;
				}
				
				
				case 524620744:
				{
					#line 17 "src/PlacePoint.hx"
					return this.particleEmitter;
				}
				
				
				case 964013983:
				{
					#line 17 "src/PlacePoint.hx"
					return this.hingeJoint;
				}
				
				
				case 1238753076:
				{
					#line 17 "src/PlacePoint.hx"
					return this.collider;
				}
				
				
				case 674101152:
				{
					#line 17 "src/PlacePoint.hx"
					return this.guiTexture;
				}
				
				
				case 262266241:
				{
					#line 17 "src/PlacePoint.hx"
					return this.guiElement;
				}
				
				
				case 1515196979:
				{
					#line 17 "src/PlacePoint.hx"
					return this.networkView;
				}
				
				
				case 801759432:
				{
					#line 17 "src/PlacePoint.hx"
					return this.guiText;
				}
				
				
				case 662730966:
				{
					#line 17 "src/PlacePoint.hx"
					return this.audio;
				}
				
				
				case 853263683:
				{
					#line 17 "src/PlacePoint.hx"
					return this.renderer;
				}
				
				
				case 1431885287:
				{
					#line 17 "src/PlacePoint.hx"
					return this.constantForce;
				}
				
				
				case 1261760260:
				{
					#line 17 "src/PlacePoint.hx"
					return this.animation;
				}
				
				
				case 1962709206:
				{
					#line 17 "src/PlacePoint.hx"
					return this.light;
				}
				
				
				case 931940005:
				{
					#line 17 "src/PlacePoint.hx"
					return this.camera;
				}
				
				
				case 1895479501:
				{
					#line 17 "src/PlacePoint.hx"
					return this.rigidbody;
				}
				
				
				case 1167273324:
				{
					#line 17 "src/PlacePoint.hx"
					return this.transform;
				}
				
				
				case 2117141633:
				{
					#line 17 "src/PlacePoint.hx"
					return this.enabled;
				}
				
				
				case 2084823382:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
				}
				
				
				case 1856815770:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
				}
				
				
				case 832859768:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
				}
				
				
				case 987108662:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
				}
				
				
				case 602588383:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
				}
				
				
				case 1641152943:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
				}
				
				
				case 1416948632:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
				}
				
				
				case 757431474:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
				}
				
				
				case 896046654:
				{
					#line 17 "src/PlacePoint.hx"
					return this.useGUILayout;
				}
				
				
				case 5741474:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
				}
				
				
				case 5546126:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("out"), ((int) (5546126) ))) );
				}
				
				
				case 1236832596:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("over"), ((int) (1236832596) ))) );
				}
				
				
				case 389604418:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
				}
				
				
				case 103:
				{
					#line 17 "src/PlacePoint.hx"
					return this.g;
				}
				
				
				case 1214151752:
				{
					#line 17 "src/PlacePoint.hx"
					return this.click;
				}
				
				
				default:
				{
					#line 17 "src/PlacePoint.hx"
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
			#line 17 "src/PlacePoint.hx"
			switch (hash)
			{
				default:
				{
					#line 17 "src/PlacePoint.hx"
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
			#line 17 "src/PlacePoint.hx"
			switch (hash)
			{
				case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
				{
					#line 17 "src/PlacePoint.hx"
					return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
				}
				
				
				case 5741474:
				{
					#line 17 "src/PlacePoint.hx"
					this.@set(((global::pony.events.Event) (dynargs[0]) ));
					#line 17 "src/PlacePoint.hx"
					break;
				}
				
				
				case 5546126:
				{
					#line 17 "src/PlacePoint.hx"
					this.@out();
					#line 17 "src/PlacePoint.hx"
					break;
				}
				
				
				case 1236832596:
				{
					#line 17 "src/PlacePoint.hx"
					this.over();
					#line 17 "src/PlacePoint.hx"
					break;
				}
				
				
				case 389604418:
				{
					#line 17 "src/PlacePoint.hx"
					this.Start();
					#line 17 "src/PlacePoint.hx"
					break;
				}
				
				
				default:
				{
					#line 17 "src/PlacePoint.hx"
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
			#line 17 "src/PlacePoint.hx"
			return default(object);
		}
		#line default
	}
	
	
	public virtual   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 17 "src/PlacePoint.hx"
			baseArr.push("hideFlags");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("name");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("tag");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("active");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("gameObject");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("particleSystem");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("particleEmitter");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("hingeJoint");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("collider");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("guiTexture");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("guiElement");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("networkView");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("guiText");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("audio");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("renderer");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("constantForce");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("animation");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("light");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("camera");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("rigidbody");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("transform");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("enabled");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("useGUILayout");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("g");
			#line 17 "src/PlacePoint.hx"
			baseArr.push("click");
		}
		#line default
	}
	
	
}



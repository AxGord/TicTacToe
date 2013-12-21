
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui.ucore
{
	public  class LoadScreenUCore : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    LoadScreenUCore(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    LoadScreenUCore() : base()
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				this.fastLoad = false;
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				this.loader = new global::pony.Loader(new global::haxe.lang.Null<int>(1, true), new global::haxe.lang.Null<int>(100, true));
				global::pony.unity3d.ui.LoadScreen.lastLoader = this.loader;
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				return new global::pony.unity3d.ui.ucore.LoadScreenUCore(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				return new global::pony.unity3d.ui.ucore.LoadScreenUCore();
			}
			#line default
		}
		
		
		public  bool fastLoad;
		
		public  global::UnityEngine.Texture background;
		
		public  global::UnityEngine.Texture main;
		
		public  global::UnityEngine.GameObject bgTextureObject;
		
		public  global::UnityEngine.GameObject mainTextureObject;
		
		public  global::UnityEngine.GameObject up;
		
		public  global::pony.unity3d.ui.ProgressBar progress;
		
		public  global::pony.Loader loader;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				this.fastLoad = false;
				#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				global::pony.unity3d.Fixed2dCamera._set_visible(false);
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (( this.background != default(global::UnityEngine.Texture) )) 
				{
					this.bgTextureObject = new global::UnityEngine.GameObject(global::haxe.lang.Runtime.toString("GUITexture LoadScreen Background"));
					global::UnityEngine.GUITexture guiTextureObject = ((global::UnityEngine.GUITexture) (this.bgTextureObject.AddComponent(global::haxe.lang.Runtime.toString("GUITexture"))) );
					guiTextureObject.texture = this.background;
					this.bgTextureObject.transform.position = new global::UnityEngine.Vector3(((float) (0.5) ), ((float) (0.5) ), ((float) (100) ));
				}
				
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (( this.main != default(global::UnityEngine.Texture) )) 
				{
					this.mainTextureObject = new global::UnityEngine.GameObject(global::haxe.lang.Runtime.toString("GUITexture LoadScreen Main"));
					global::UnityEngine.GUITexture mguiTextureObject = ((global::UnityEngine.GUITexture) (this.mainTextureObject.AddComponent(global::haxe.lang.Runtime.toString("GUITexture"))) );
					mguiTextureObject.texture = this.main;
					mguiTextureObject.transform.localScale = new global::UnityEngine.Vector3(((float) (0) ), ((float) (0) ));
					mguiTextureObject.pixelInset = new global::UnityEngine.Rect((  - (this.main.width)  / 2 ), (  - (this.main.height)  / 2 ), ((float) (this.main.width) ), ((float) (this.main.height) ));
					this.mainTextureObject.transform.position = new global::UnityEngine.Vector3(((float) (0.5) ), ((float) (0.5) ), ((float) (101) ));
				}
				
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (( this.progress != default(global::pony.unity3d.ui.ProgressBar) )) 
				{
					object __temp_stmt744 = default(object);
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					{
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.progress) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) ), 1);
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						__temp_stmt744 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					this.loader.progress.@add(__temp_stmt744, default(global::haxe.lang.Null<int>));
				}
				
				#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				{
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					int priority = 0;
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					object listener = default(object);
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) ), 0);
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						listener = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					object __temp_stmt745 = default(object);
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					{
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						object f2 = global::haxe.lang.Runtime.getField(listener, "f", 102, true);
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						object this1 = default(object);
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							object __temp_getvar253 = f2;
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							double __temp_ret254 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar253, "used", 1303220797, true)) );
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							object __temp_expr746 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar253, "used", 1303220797, ( __temp_ret254 + 1.0 ))) );
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							double __temp_expr747 = __temp_ret254;
						}
						
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							bool __temp_odecl742 = ((bool) (global::haxe.lang.Runtime.getField(listener, "event", 1975830554, true)) );
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							bool __temp_odecl743 = ((bool) (global::haxe.lang.Runtime.getField(listener, "ignoreReturn", 98429794, true)) );
							#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
							this1 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f2, __temp_odecl743, true, default(global::pony.events.Event), __temp_odecl742}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						__temp_stmt745 = this1;
					}
					
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					this.loader.complite.@add(((object) (__temp_stmt745) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				this.loader.init(new global::haxe.lang.Null<bool>(this.fastLoad, true));
			}
			#line default
		}
		
		
		public virtual   void end()
		{
			unchecked 
			{
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				global::pony.unity3d.Fixed2dCamera._set_visible(true);
				if (( this.bgTextureObject != default(global::UnityEngine.GameObject) )) 
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					global::UnityEngine.Object.Destroy(((global::UnityEngine.Object) (this.bgTextureObject) ));
				}
				
				if (( this.mainTextureObject != default(global::UnityEngine.GameObject) )) 
				{
					#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					global::UnityEngine.Object.Destroy(((global::UnityEngine.Object) (this.mainTextureObject) ));
				}
				
				if (( this.progress != default(global::pony.unity3d.ui.ProgressBar) )) 
				{
					object __temp_stmt748 = default(object);
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					{
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.progress) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) ), 1);
						#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						__temp_stmt748 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					this.loader.progress.@remove(__temp_stmt748);
					global::UnityEngine.Object.Destroy(((global::UnityEngine.Object) (this.progress.gameObject) ));
				}
				
				#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (( this.up != default(global::UnityEngine.GameObject) )) 
				{
					#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					global::UnityEngine.Object.Destroy(((global::UnityEngine.Object) (this.up) ));
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (isCheck) 
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					if (throwErrors) 
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
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
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				if (throwErrors) 
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
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
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.active = ((bool) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.enabled = ((bool) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 1483687955:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.loader = ((global::pony.Loader) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 103479213:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.progress = ((global::pony.unity3d.ui.ProgressBar) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 26203:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.up = ((global::UnityEngine.GameObject) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 1829108225:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.mainTextureObject = ((global::UnityEngine.GameObject) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 1280791797:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.bgTextureObject = ((global::UnityEngine.GameObject) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 1213610041:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.main = ((global::UnityEngine.Texture) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 639472622:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.background = ((global::UnityEngine.Texture) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					case 64095970:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.fastLoad = ((bool) (@value) );
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return @value;
					}
					
					
					default:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
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
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.useGUILayout;
					}
					
					
					case 5047259:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) );
					}
					
					
					case 389604418:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1483687955:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.loader;
					}
					
					
					case 103479213:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.progress;
					}
					
					
					case 26203:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.up;
					}
					
					
					case 1829108225:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.mainTextureObject;
					}
					
					
					case 1280791797:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.bgTextureObject;
					}
					
					
					case 1213610041:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.main;
					}
					
					
					case 639472622:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.background;
					}
					
					
					case 64095970:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return this.fastLoad;
					}
					
					
					default:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
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
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				switch (hash)
				{
					default:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
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
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 5047259:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.end();
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						this.Start();
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						break;
					}
					
					
					default:
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("hideFlags");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("name");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("tag");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("active");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("gameObject");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("particleSystem");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("particleEmitter");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("hingeJoint");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("collider");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("guiTexture");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("guiElement");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("networkView");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("guiText");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("audio");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("renderer");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("constantForce");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("animation");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("light");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("camera");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("rigidbody");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("transform");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("enabled");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("useGUILayout");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("loader");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("progress");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("up");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("mainTextureObject");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("bgTextureObject");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("main");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("background");
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/ucore/LoadScreenUCore.hx"
				baseArr.push("fastLoad");
			}
			#line default
		}
		
		
	}
}



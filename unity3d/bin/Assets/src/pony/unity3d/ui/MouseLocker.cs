
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class MouseLocker : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		public    MouseLocker(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    MouseLocker() : base()
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				this.prevState = false;
				#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				this.panel = false;
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				return new global::pony.unity3d.ui.MouseLocker(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				return new global::pony.unity3d.ui.MouseLocker();
			}
			#line default
		}
		
		
		public  bool panel;
		
		public  bool prevState;
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				bool h = default(bool);
				#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				if (this.panel) 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x - global::pony.unity3d.Fixed2dCamera.begin )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				 else 
				{
					h = ( this.guiTexture as global::UnityEngine.GUIElement ).HitTest(((global::UnityEngine.Vector3) (new global::UnityEngine.Vector3(((float) (( global::UnityEngine.Input.mousePosition.x + ( ((double) ((( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.begin ))) ) / 2 ) )) ), ((float) (global::UnityEngine.Input.mousePosition.y) ))) ));
				}
				
				if (( this.prevState != h )) 
				{
					if (h) 
					{
						#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						global::pony.events.LV<int> _g = global::pony.unity3d.scene.MouseHelper.@lock;
						#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int _g1 = _g.@value;
						#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						{
							#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int v = ( _g1 + 1 );
							#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							if (( v != _g.@value )) 
							{
								#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								_g.@value = v;
								#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								{
									#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									_g.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{v})) ), ((object) (_g.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									global::pony.events.LV<int> __temp_expr752 = _g;
								}
								
							}
							
							#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int __temp_expr753 = v;
						}
						
						#line 50 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int __temp_expr754 = _g1;
					}
					 else 
					{
						global::pony.events.LV<int> _g2 = global::pony.unity3d.scene.MouseHelper.@lock;
						#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int _g11 = _g2.@value;
						#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						{
							#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int v1 = ( _g11 - 1 );
							#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							if (( v1 != _g2.@value )) 
							{
								#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								_g2.@value = v1;
								#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								{
									#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									_g2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{v1})) ), ((object) (_g2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									global::pony.events.LV<int> __temp_expr749 = _g2;
								}
								
							}
							
							#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int __temp_expr750 = v1;
						}
						
						#line 51 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int __temp_expr751 = _g11;
					}
					
					this.prevState = h;
				}
				
			}
			#line default
		}
		
		
		public virtual   void OnDisable()
		{
			unchecked 
			{
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				if (this.prevState) 
				{
					this.prevState = false;
					{
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						global::pony.events.LV<int> _g = global::pony.unity3d.scene.MouseHelper.@lock;
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int _g1 = _g.@value;
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						{
							#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int v = ( _g1 - 1 );
							#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							if (( v != _g.@value )) 
							{
								#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								_g.@value = v;
								#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
								{
									#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									_g.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{v})) ), ((object) (_g.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
									global::pony.events.LV<int> __temp_expr755 = _g;
								}
								
							}
							
							#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
							int __temp_expr756 = v;
						}
						
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						int __temp_expr757 = _g1;
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				if (isCheck) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
					if (throwErrors) 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				if (throwErrors) 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				switch (hash)
				{
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.active = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.enabled = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 1868699166:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.prevState = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					case 1028815620:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.panel = ((bool) (@value) );
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return @value;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.useGUILayout;
					}
					
					
					case 718668393:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("OnDisable"), ((int) (718668393) ))) );
					}
					
					
					case 999946793:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 1868699166:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.prevState;
					}
					
					
					case 1028815620:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return this.panel;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				switch (hash)
				{
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
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
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 718668393:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.OnDisable();
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						break;
					}
					
					
					case 999946793:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						this.Update();
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						break;
					}
					
					
					default:
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("hideFlags");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("name");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("tag");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("active");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("gameObject");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("particleSystem");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("particleEmitter");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("hingeJoint");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("collider");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("guiTexture");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("guiElement");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("networkView");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("guiText");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("audio");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("renderer");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("constantForce");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("animation");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("light");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("camera");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("rigidbody");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("transform");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("enabled");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("useGUILayout");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("prevState");
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/MouseLocker.hx"
				baseArr.push("panel");
			}
			#line default
		}
		
		
	}
}



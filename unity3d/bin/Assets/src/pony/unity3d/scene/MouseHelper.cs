
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.scene
{
	public  class MouseHelper : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject 
	{
		static MouseHelper() 
		{
			#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
			global::pony.unity3d.scene.MouseHelper.globalMiddleDown = new global::pony.events.Signal(((object) (default(object)) ));
			global::pony.unity3d.scene.MouseHelper.globalMiddleUp = new global::pony.events.Signal(((object) (default(object)) ));
			global::pony.unity3d.scene.MouseHelper.@lock = new global::pony.events.LV<int>(((int) (0) ));
			global::pony.unity3d.scene.MouseHelper.middleMousePressed = false;
			global::pony.unity3d.scene.MouseHelper.inited = false;
		}
		public    MouseHelper(global::haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    MouseHelper() : base()
		{
			unchecked 
			{
				#line 64 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this.sub = false;
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this.ovrs = 0;
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this._overed = 0;
				#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this.over = new global::pony.events.Signal(((object) (default(object)) ));
				this.@out = new global::pony.events.Signal(((object) (default(object)) ));
				this.down = new global::pony.events.Signal(((object) (default(object)) ));
				this.middleDown = new global::pony.events.Signal(((object) (default(object)) ));
				this.middleUp = new global::pony.events.Signal(((object) (default(object)) ));
				object __temp_stmt658 = default(object);
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				{
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("resetOvrs"), ((int) (262448663) ))) ), 0);
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					__temp_stmt658 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				global::pony.unity3d.scene.MouseHelper.@lock.@add(__temp_stmt658, default(global::haxe.lang.Null<int>));
				object __temp_stmt659 = default(object);
				#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("updateOverState"), ((int) (928502996) ))) ), 0);
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					__temp_stmt659 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
				}
				
				#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				global::pony.unity3d.scene.MouseHelper.@lock.@add(__temp_stmt659, default(global::haxe.lang.Null<int>));
			}
			#line default
		}
		
		
		public static  global::pony.events.Signal globalMiddleDown;
		
		public static  global::pony.events.Signal globalMiddleUp;
		
		public static  global::pony.events.LV<int> @lock;
		
		public static  bool middleMousePressed;
		
		public static  bool inited;
		
		public static   void updateStatic()
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (global::UnityEngine.Input.GetMouseButton(2)) 
				{
					#line 70 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					if ( ! (global::pony.unity3d.scene.MouseHelper.middleMousePressed) ) 
					{
						global::pony.unity3d.scene.MouseHelper.middleMousePressed = true;
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal _this = global::pony.unity3d.scene.MouseHelper.globalMiddleDown;
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal __temp_expr655 = _this;
						}
						
					}
					
				}
				 else 
				{
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					if (global::pony.unity3d.scene.MouseHelper.middleMousePressed) 
					{
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal _this1 = global::pony.unity3d.scene.MouseHelper.globalMiddleUp;
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal __temp_expr654 = _this1;
						}
						
						#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						global::pony.unity3d.scene.MouseHelper.middleMousePressed = false;
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   void init()
		{
			unchecked 
			{
				#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (global::pony.unity3d.scene.MouseHelper.inited) 
				{
					#line 84 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return ;
				}
				
				global::pony.unity3d.scene.MouseHelper.inited = true;
				{
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					int priority = 0;
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					object listener = default(object);
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					object __temp_stmt656 = default(object);
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					{
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						object l = default(object);
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						{
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.unity3d.scene.MouseHelper)) ), global::haxe.lang.Runtime.toString("updateStatic"), ((int) (96437143) ))) ), 0);
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						__temp_stmt656 = l;
					}
					
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					listener = ((object) (__temp_stmt656) );
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
					#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					object __temp_expr657 = this1.target;
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				return new global::pony.unity3d.scene.MouseHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				return new global::pony.unity3d.scene.MouseHelper();
			}
			#line default
		}
		
		
		public  bool overed;
		
		public  global::pony.events.Signal over;
		
		public  global::pony.events.Signal @out;
		
		public  global::pony.events.Signal down;
		
		public  global::pony.events.Signal middleDown;
		
		public  global::pony.events.Signal middleUp;
		
		public  int _overed;
		
		public  global::pony.unity3d.scene.MouseHelper ovr;
		
		public  int ovrs;
		
		public  bool sub;
		
		public virtual   void Start()
		{
			unchecked 
			{
				#line 102 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				global::pony.unity3d.scene.MouseHelper.init();
				if (( ( global::pony.unity3d.ui.LoadScreen.lastLoader != default(global::pony.Loader) ) &&  ! (this.sub)  )) 
				{
					global::pony.unity3d.ui.LoadScreen.lastLoader.addAction(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ft"), ((int) (22862) ))) ));
				}
				 else 
				{
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					this.ft();
				}
				
			}
			#line default
		}
		
		
		public virtual   void ft()
		{
			unchecked 
			{
				#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (( ( this.renderer != default(global::UnityEngine.Renderer) ) && ( this.collider == default(global::UnityEngine.Collider) ) )) 
				{
					global::hugs.GameObjectMethods.addTypedComponent<object>(this.gameObject, typeof(global::UnityEngine.BoxCollider));
				}
				
				#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				{
					#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					global::hugs.NativeArrayIterator<object> __temp_iterator244 = global::hugs.GameObjectMethods.getComponentsInChildrenOfType<object>(this.gameObject, typeof(global::UnityEngine.Transform), default(global::haxe.lang.Null<bool>));
					#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					while (__temp_iterator244.hasNext())
					{
						#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						global::UnityEngine.Transform e = ((global::UnityEngine.Transform) (__temp_iterator244.next()) );
						if (( e == this.transform )) 
						{
							#line 114 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							continue;
						}
						
						this.ovr = ((global::pony.unity3d.scene.MouseHelper) (global::hugs.GameObjectMethods.getTypedComponent<object>(e.gameObject, typeof(global::pony.unity3d.scene.MouseHelper))) );
						if (( this.ovr == default(global::pony.unity3d.scene.MouseHelper) )) 
						{
							this.ovr = ((global::pony.unity3d.scene.MouseHelper) (global::hugs.GameObjectMethods.addTypedComponent<object>(e.gameObject, typeof(global::pony.unity3d.scene.MouseHelper))) );
							this.ovr.sub = true;
						}
						
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						object __temp_stmt646 = default(object);
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						{
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subOver"), ((int) (398206708) ))) ), 0);
							#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							__temp_stmt646 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 120 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ovr.over.@add(__temp_stmt646, default(global::haxe.lang.Null<int>));
						object __temp_stmt647 = default(object);
						#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						{
							#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subOut"), ((int) (435134190) ))) ), 0);
							#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							__temp_stmt647 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
						}
						
						#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ovr.@out.@add(__temp_stmt647, default(global::haxe.lang.Null<int>));
						this.ovr.down.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.down) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
						this.ovr.middleDown.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleDown) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
						this.ovr.middleUp.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleUp) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void resetOvrs()
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (this._get_overed()) 
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.@out;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr648 = _this;
				}
				
				this.ovrs = 0;
				this._overed = 0;
			}
			#line default
		}
		
		
		public virtual   void subOver()
		{
			unchecked 
			{
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if ( ! (this._get_overed()) ) 
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.over;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr649 = _this;
				}
				
				#line 138 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this.ovrs++;
			}
			#line default
		}
		
		
		public virtual   void subOut()
		{
			unchecked 
			{
				#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				this.ovrs--;
				if ( ! (this._get_overed()) ) 
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.@out;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr650 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   void Update()
		{
			unchecked 
			{
				#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (( global::pony.unity3d.scene.MouseHelper.@lock.@value > 0 )) 
				{
					#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return ;
				}
				
				if (( this._overed == 0 )) 
				{
					#line 149 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return ;
				}
				
				this._overed--;
				if (( this._overed == 0 )) 
				{
					#line 151 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					this.updateOverState();
				}
				
			}
			#line default
		}
		
		
		public virtual   void OnMouseOver()
		{
			unchecked 
			{
				#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (( global::pony.unity3d.scene.MouseHelper.@lock.@value > 0 )) 
				{
					#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return ;
				}
				
				if (( this._overed == 2 )) 
				{
					#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return ;
				}
				
				this._overed = 2;
				this.updateOverState();
			}
			#line default
		}
		
		
		public virtual   void updateOverState()
		{
			unchecked 
			{
				#line 162 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (( ( this._overed == 2 ) && ( global::pony.unity3d.scene.MouseHelper.@lock.@value == 0 ) )) 
				{
					if ( ! (this._get_overed()) ) 
					{
						this.ovrs++;
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal _this = this.over;
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal __temp_expr652 = _this;
						}
						
						#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						global::pony.unity3d.scene.MouseHelper.globalMiddleDown.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleDown) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
						global::pony.unity3d.scene.MouseHelper.globalMiddleUp.@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleUp) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true), default(global::haxe.lang.Null<int>));
					}
					
				}
				 else 
				{
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					if (this._get_overed()) 
					{
						this.ovrs--;
						#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
						{
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal _this1 = this.@out;
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
							global::pony.events.Signal __temp_expr651 = _this1;
						}
						
						#line 173 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						global::pony.unity3d.scene.MouseHelper.globalMiddleDown.@remove(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleDown) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true));
						global::pony.unity3d.scene.MouseHelper.globalMiddleUp.@remove(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.middleUp) ), global::haxe.lang.Runtime.toString("dispatchEvent"), ((int) (1181009664) ))) ), 1), true));
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void OnMouseDown()
		{
			unchecked 
			{
				#line 180 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (this._get_overed()) 
				{
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal _this = this.down;
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					_this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{})) ), ((object) (_this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/Signal.hx"
					global::pony.events.Signal __temp_expr653 = _this;
				}
				
			}
			#line default
		}
		
		
		public virtual   bool _get_overed()
		{
			unchecked 
			{
				#line 184 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				return ( this.ovrs > 0 );
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (isCheck) 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					if (throwErrors) 
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
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
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				if (throwErrors) 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				switch (hash)
				{
					case 1236835496:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ovrs = ((int) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 74840146:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this._overed = ((int) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
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
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				switch (hash)
				{
					case 1575675685:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 1224700491:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.name = global::haxe.lang.Runtime.toString(@value);
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 5790298:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.tag = global::haxe.lang.Runtime.toString(@value);
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 373703110:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.active = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 2117141633:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.enabled = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 896046654:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.useGUILayout = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 5745024:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.sub = ((bool) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 1236835496:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ovrs = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 5546347:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ovr = ((global::pony.unity3d.scene.MouseHelper) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 74840146:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this._overed = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 1077566736:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.middleUp = ((global::pony.events.Signal) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 2115683927:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.middleDown = ((global::pony.events.Signal) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 1114503266:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.down = ((global::pony.events.Signal) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 5546126:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.@out = ((global::pony.events.Signal) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					case 1236832596:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.over = ((global::pony.events.Signal) (@value) );
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
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
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				switch (hash)
				{
					case 1826409040:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetType"), ((int) (1826409040) ))) );
					}
					
					
					case 304123084:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ToString"), ((int) (304123084) ))) );
					}
					
					
					case 276486854:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetInstanceID"), ((int) (276486854) ))) );
					}
					
					
					case 295397041:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetHashCode"), ((int) (295397041) ))) );
					}
					
					
					case 1955029599:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Equals"), ((int) (1955029599) ))) );
					}
					
					
					case 1575675685:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.hideFlags;
					}
					
					
					case 1224700491:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.name;
					}
					
					
					case 294420221:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessageUpwards"), ((int) (294420221) ))) );
					}
					
					
					case 139469119:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("SendMessage"), ((int) (139469119) ))) );
					}
					
					
					case 967979664:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentsInChildren"), ((int) (967979664) ))) );
					}
					
					
					case 2122408236:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponents"), ((int) (2122408236) ))) );
					}
					
					
					case 1328964235:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponentInChildren"), ((int) (1328964235) ))) );
					}
					
					
					case 1723652455:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("GetComponent"), ((int) (1723652455) ))) );
					}
					
					
					case 89600725:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CompareTag"), ((int) (89600725) ))) );
					}
					
					
					case 2134927590:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("BroadcastMessage"), ((int) (2134927590) ))) );
					}
					
					
					case 5790298:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.tag;
					}
					
					
					case 373703110:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.active;
					}
					
					
					case 1471506513:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.gameObject;
					}
					
					
					case 1751728597:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.particleSystem;
					}
					
					
					case 524620744:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.particleEmitter;
					}
					
					
					case 964013983:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.hingeJoint;
					}
					
					
					case 1238753076:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.collider;
					}
					
					
					case 674101152:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.guiTexture;
					}
					
					
					case 262266241:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.guiElement;
					}
					
					
					case 1515196979:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.networkView;
					}
					
					
					case 801759432:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.guiText;
					}
					
					
					case 662730966:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.audio;
					}
					
					
					case 853263683:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.renderer;
					}
					
					
					case 1431885287:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.constantForce;
					}
					
					
					case 1261760260:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.animation;
					}
					
					
					case 1962709206:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.light;
					}
					
					
					case 931940005:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.camera;
					}
					
					
					case 1895479501:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.rigidbody;
					}
					
					
					case 1167273324:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.transform;
					}
					
					
					case 2117141633:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.enabled;
					}
					
					
					case 2084823382:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopCoroutine"), ((int) (2084823382) ))) );
					}
					
					
					case 1856815770:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StopAllCoroutines"), ((int) (1856815770) ))) );
					}
					
					
					case 832859768:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine_Auto"), ((int) (832859768) ))) );
					}
					
					
					case 987108662:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("StartCoroutine"), ((int) (987108662) ))) );
					}
					
					
					case 602588383:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("IsInvoking"), ((int) (602588383) ))) );
					}
					
					
					case 1641152943:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("InvokeRepeating"), ((int) (1641152943) ))) );
					}
					
					
					case 1416948632:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Invoke"), ((int) (1416948632) ))) );
					}
					
					
					case 757431474:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("CancelInvoke"), ((int) (757431474) ))) );
					}
					
					
					case 896046654:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.useGUILayout;
					}
					
					
					case 109467260:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_overed"), ((int) (109467260) ))) );
					}
					
					
					case 1966615528:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("OnMouseDown"), ((int) (1966615528) ))) );
					}
					
					
					case 928502996:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("updateOverState"), ((int) (928502996) ))) );
					}
					
					
					case 2088944858:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("OnMouseOver"), ((int) (2088944858) ))) );
					}
					
					
					case 999946793:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Update"), ((int) (999946793) ))) );
					}
					
					
					case 435134190:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subOut"), ((int) (435134190) ))) );
					}
					
					
					case 398206708:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("subOver"), ((int) (398206708) ))) );
					}
					
					
					case 262448663:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("resetOvrs"), ((int) (262448663) ))) );
					}
					
					
					case 22862:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ft"), ((int) (22862) ))) );
					}
					
					
					case 389604418:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 5745024:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.sub;
					}
					
					
					case 1236835496:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.ovrs;
					}
					
					
					case 5546347:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.ovr;
					}
					
					
					case 74840146:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this._overed;
					}
					
					
					case 1077566736:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.middleUp;
					}
					
					
					case 2115683927:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.middleDown;
					}
					
					
					case 1114503266:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.down;
					}
					
					
					case 5546126:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.@out;
					}
					
					
					case 1236832596:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this.over;
					}
					
					
					case 369026739:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						if (handleProperties) 
						{
							#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							return this._get_overed();
						}
						 else 
						{
							#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
							return this.overed;
						}
						
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
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
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				switch (hash)
				{
					case 1236835496:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((double) (this.ovrs) );
					}
					
					
					case 74840146:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((double) (this._overed) );
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
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
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				switch (hash)
				{
					case 757431474:case 1416948632:case 1641152943:case 602588383:case 987108662:case 832859768:case 1856815770:case 2084823382:case 2134927590:case 89600725:case 1723652455:case 1328964235:case 2122408236:case 967979664:case 139469119:case 294420221:case 1955029599:case 295397041:case 276486854:case 304123084:case 1826409040:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 109467260:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return this._get_overed();
					}
					
					
					case 1966615528:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.OnMouseDown();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 928502996:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.updateOverState();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 2088944858:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.OnMouseOver();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 999946793:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.Update();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 435134190:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.subOut();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 398206708:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.subOver();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 262448663:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.resetOvrs();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 22862:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.ft();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					case 389604418:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						this.Start();
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						break;
					}
					
					
					default:
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				return default(object);
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("hideFlags");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("name");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("tag");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("active");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("gameObject");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("particleSystem");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("particleEmitter");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("hingeJoint");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("collider");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("guiTexture");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("guiElement");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("networkView");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("guiText");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("audio");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("renderer");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("constantForce");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("animation");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("light");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("camera");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("rigidbody");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("transform");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("enabled");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("useGUILayout");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("sub");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("ovrs");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("ovr");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("_overed");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("middleUp");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("middleDown");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("down");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("out");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("over");
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/scene/MouseHelper.hx"
				baseArr.push("overed");
			}
			#line default
		}
		
		
	}
}



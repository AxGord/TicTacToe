
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d.ui
{
	public  class TintButton : global::pony.unity3d.ui.Button 
	{
		public    TintButton(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    TintButton() : base()
		{
			unchecked 
			{
				#line 45 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.tint = ((float) (0.2) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return new global::pony.unity3d.ui.TintButton(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return new global::pony.unity3d.ui.TintButton();
			}
			#line default
		}
		
		
		public  float tint;
		
		public  global::UnityEngine.Color sclr;
		
		public override   void Start()
		{
			unchecked 
			{
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				base.Start();
				this.sclr = this.guiTexture.color;
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus, 1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("cancle"), ((int) (942928780) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave, 1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("cancle"), ((int) (942928780) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press, 1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("cancle"), ((int) (942928780) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default, 1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("cancle"), ((int) (942928780) ))) ), 1), true), default(global::haxe.lang.Null<int>));
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				object __temp_stmt697 = default(object);
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tfocus"), ((int) (1710176996) ))) ), 0);
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					__temp_stmt697 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
				}
				
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Focus})).@add(__temp_stmt697, default(global::haxe.lang.Null<int>));
				object __temp_stmt698 = default(object);
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tleave"), ((int) (1404637187) ))) ), 0);
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					__temp_stmt698 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
				}
				
				#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Leave})).@add(__temp_stmt698, default(global::haxe.lang.Null<int>));
				object __temp_stmt699 = default(object);
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tpress"), ((int) (703475343) ))) ), 0);
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					__temp_stmt699 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
				}
				
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Press})).@add(__temp_stmt699, default(global::haxe.lang.Null<int>));
				object __temp_stmt700 = default(object);
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("restoreColor"), ((int) (651837237) ))) ), 0);
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					__temp_stmt700 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
				}
				
				#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.core.changeVisual.subArgs(new global::Array<object>(new object[]{global::pony.ui.ButtonStates.Default})).@add(__temp_stmt700, default(global::haxe.lang.Null<int>));
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					global::pony.ui.ButtonCore _this = this.core;
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					{
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::Array args = new global::Array<object>(new object[]{_this._get_visualState(), _this.mode, false});
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::pony.events.Signal _this1 = _this.changeVisual;
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						_this1.dispatchEvent(new global::pony.events.Event(((global::Array) (args) ), ((object) (_this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						global::pony.events.Signal __temp_expr701 = _this1;
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void tfocus()
		{
			unchecked 
			{
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r + this.tint )) ), ((float) (( this.sclr.g + this.tint )) ), ((float) (( this.sclr.b + this.tint )) ));
			}
			#line default
		}
		
		
		public virtual   void tpress()
		{
			unchecked 
			{
				#line 66 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - this.tint )) ), ((float) (( this.sclr.g - this.tint )) ), ((float) (( this.sclr.b - this.tint )) ));
			}
			#line default
		}
		
		
		public virtual   void tleave()
		{
			unchecked 
			{
				#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.guiTexture.color = new global::UnityEngine.Color(((float) (( this.sclr.r - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.g - ( ((double) (this.tint) ) / 2 ) )) ), ((float) (( this.sclr.b - ( ((double) (this.tint) ) / 2 ) )) ));
			}
			#line default
		}
		
		
		public virtual   void restoreColor()
		{
			unchecked 
			{
				#line 68 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.guiTexture.color = new global::UnityEngine.Color(((float) (this.sclr.r) ), ((float) (this.sclr.g) ), ((float) (this.sclr.b) ));
			}
			#line default
		}
		
		
		public virtual   void cancle(global::pony.events.Event e)
		{
			unchecked 
			{
				#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				this.restoreColor();
				{
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					if (( e.parent != default(global::pony.events.Event) )) 
					{
						#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						e.parent.stopPropagation();
					}
					
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					e._stopPropagation = true;
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tint = ((float) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 1280247574:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.sclr = ((global::UnityEngine.Color) (@value) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tint = ((float) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return @value;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 942928780:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("cancle"), ((int) (942928780) ))) );
					}
					
					
					case 651837237:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("restoreColor"), ((int) (651837237) ))) );
					}
					
					
					case 1404637187:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tleave"), ((int) (1404637187) ))) );
					}
					
					
					case 703475343:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tpress"), ((int) (703475343) ))) );
					}
					
					
					case 1710176996:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("tfocus"), ((int) (1710176996) ))) );
					}
					
					
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
					}
					
					
					case 1280247574:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.sclr;
					}
					
					
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return this.tint;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 1291635963:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return ((double) (this.tint) );
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				switch (hash)
				{
					case 389604418:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 942928780:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.cancle(((global::pony.events.Event) (dynargs[0]) ));
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					case 651837237:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.restoreColor();
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					case 1404637187:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tleave();
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					case 703475343:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tpress();
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					case 1710176996:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						this.tfocus();
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						break;
					}
					
					
					default:
					{
						#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("sclr");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				baseArr.push("tint");
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/ui/TintButton.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



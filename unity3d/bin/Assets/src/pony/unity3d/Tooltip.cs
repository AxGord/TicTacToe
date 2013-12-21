
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class Tooltip : global::haxe.lang.HxObject 
	{
		static Tooltip() 
		{
			#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
			global::pony.unity3d.Tooltip.limitBorder = ((double) (50) );
			global::pony.unity3d.Tooltip.border = ((float) (5) );
			#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
			global::pony.unity3d.Tooltip.defaultColorMod = new global::pony.events.LV<object>(((object) (default(global::UnityEngine.Color)) ));
			global::pony.unity3d.Tooltip.panel = false;
		}
		public    Tooltip(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Tooltip()
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.__hx_ctor_pony_unity3d_Tooltip(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_unity3d_Tooltip(global::pony.unity3d.Tooltip __temp_me132)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  double limitBorder;
		
		public static  float border;
		
		public static  global::UnityEngine.GameObject textObject;
		
		public static  global::UnityEngine.GameObject textureObject;
		
		public static  global::UnityEngine.GUIText guiTextObject;
		
		public static  global::UnityEngine.GUITexture guiTextureObject;
		
		public static  global::UnityEngine.Rect r;
		
		public static  global::UnityEngine.Rect lr;
		
		public static  global::UnityEngine.GameObject longTextObject;
		
		public static  global::UnityEngine.GUIText guiLongTextObject;
		
		public static  global::UnityEngine.Texture texture;
		
		public static  global::pony.events.LV<object> defaultColorMod;
		
		public static  bool panel;
		
		public static  object target;
		
		public static   void init()
		{
			unchecked 
			{
				#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.textureObject = new global::UnityEngine.GameObject(global::haxe.lang.Runtime.toString("GUIText Tooltip Texture"));
				global::pony.unity3d.Tooltip.guiTextureObject = ((global::UnityEngine.GUITexture) (global::pony.unity3d.Tooltip.textureObject.AddComponent(global::haxe.lang.Runtime.toString("GUITexture"))) );
				global::pony.unity3d.Tooltip.guiTextureObject.texture = global::pony.unity3d.Tooltip.texture;
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.textObject = new global::UnityEngine.GameObject(global::haxe.lang.Runtime.toString("GUIText Tooltip"));
				global::pony.unity3d.Tooltip.textObject.transform.position = new global::UnityEngine.Vector3(((float) (0.5) ), ((float) (0.5) ));
				global::pony.unity3d.Tooltip.guiTextObject = ((global::UnityEngine.GUIText) (global::pony.unity3d.Tooltip.textObject.AddComponent(global::haxe.lang.Runtime.toString("GUIText"))) );
				global::pony.unity3d.Tooltip.guiTextObject.material.color = new global::UnityEngine.Color(((float) (0) ), ((float) (0) ), ((float) (0) ));
				#line 85 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.guiTextObject.fontSize = 14;
				#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.longTextObject = new global::UnityEngine.GameObject(global::haxe.lang.Runtime.toString("GUIText Tooltip Long"));
				global::pony.unity3d.Tooltip.longTextObject.transform.position = new global::UnityEngine.Vector3(((float) (0.5) ), ((float) (0.5) ));
				global::pony.unity3d.Tooltip.guiLongTextObject = ((global::UnityEngine.GUIText) (global::pony.unity3d.Tooltip.longTextObject.AddComponent(global::haxe.lang.Runtime.toString("GUIText"))) );
				global::pony.unity3d.Tooltip.guiLongTextObject.material.color = new global::UnityEngine.Color(((float) (0) ), ((float) (0) ), ((float) (0) ));
				global::pony.unity3d.Tooltip.guiLongTextObject.fontSize = 10;
			}
			#line default
		}
		
		
		public static   void showText(string text, string bigText, object obj, global::haxe.lang.Null<int> layer, global::haxe.lang.Null<bool> panel)
		{
			unchecked 
			{
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::haxe.lang.Null<bool> __temp_panel131 = ( (global::haxe.lang.Runtime.eq((panel).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (new global::haxe.lang.Null<bool>(false, true)) : (((global::haxe.lang.Null<bool>) (panel) )) );
				global::pony.unity3d.Tooltip.target = obj;
				if (( global::pony.unity3d.Tooltip.textObject == default(global::UnityEngine.GameObject) )) 
				{
					global::pony.unity3d.Tooltip.init();
				}
				
				#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.panel = __temp_panel131.@value;
				if (( ! (global::haxe.lang.Runtime.eq((layer).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) )) 
				{
					global::pony.unity3d.Tooltip.textObject.layer = layer.@value;
					global::pony.unity3d.Tooltip.textureObject.layer = layer.@value;
					global::pony.unity3d.Tooltip.longTextObject.layer = layer.@value;
				}
				
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.guiTextObject.enabled = true;
				global::pony.unity3d.Tooltip.guiTextureObject.enabled = true;
				#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.guiTextObject.text = global::pony.WordWrap.wordWrap(text, ( (string.Equals(bigText, "")) ? (30) : (50) ));
				#line 116 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.r = ( global::pony.unity3d.Tooltip.guiTextObject as global::UnityEngine.GUIElement ).GetScreenRect();
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				int w = default(int);
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				if (( __temp_panel131.@value && global::pony.unity3d.Fixed2dCamera.exists )) 
				{
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					w = global::pony.unity3d.Fixed2dCamera.SIZE;
				}
				 else 
				{
					#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					w = ( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.SIZE );
				}
				
				int h = global::UnityEngine.Screen.height;
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				if ( ! (string.Equals(bigText, "")) ) 
				{
					#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					global::pony.unity3d.Tooltip.guiLongTextObject.enabled = true;
					global::pony.unity3d.Tooltip.guiLongTextObject.text = global::pony.WordWrap.wordWrap(bigText, 75);
					global::pony.unity3d.Tooltip.lr = ( global::pony.unity3d.Tooltip.guiLongTextObject as global::UnityEngine.GUIElement ).GetScreenRect();
					global::pony.unity3d.Tooltip.r.height += global::pony.unity3d.Tooltip.lr.height;
					global::pony.unity3d.Tooltip.r.width = ((float) (global::System.Math.Max(((double) (global::pony.unity3d.Tooltip.r.width) ), ((double) (global::pony.unity3d.Tooltip.lr.width) ))) );
				}
				 else 
				{
					#line 129 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					global::pony.unity3d.Tooltip.guiLongTextObject.enabled = false;
				}
				
				global::pony.unity3d.Tooltip.guiTextureObject.pixelInset = new global::UnityEngine.Rect(((float) (( ( ((double) (w) ) / 2 ) - global::pony.unity3d.Tooltip.border )) ), ((float) (( ( ( ((double) (h) ) / 2 ) - global::pony.unity3d.Tooltip.r.height ) - global::pony.unity3d.Tooltip.border )) ), ((float) (( (  - (w)  + global::pony.unity3d.Tooltip.r.width ) + ( global::pony.unity3d.Tooltip.border * 2 ) )) ), ((float) (( (  - (h)  + global::pony.unity3d.Tooltip.r.height ) + ( global::pony.unity3d.Tooltip.border * 2 ) )) ));
				#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				if (( __temp_panel131.@value && global::pony.unity3d.Fixed2dCamera.exists )) 
				{
					{
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						int priority = 0;
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object listener = default(object);
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object __temp_stmt637 = default(object);
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						{
							#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							object l = default(object);
							#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							{
								#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
								object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.unity3d.Tooltip)) ), global::haxe.lang.Runtime.toString("moveTextPanel"), ((int) (1894751686) ))) ), 0);
								#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
								l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
							}
							
							#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							__temp_stmt637 = l;
						}
						
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						listener = ((object) (__temp_stmt637) );
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						global::pony.events.Signal this1 = global::pony.DeltaTime.update;
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
						#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object __temp_expr638 = this1.target;
					}
					
					global::pony.unity3d.Tooltip.moveTextPanel();
				}
				 else 
				{
					#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					{
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						int priority1 = 0;
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object listener1 = default(object);
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object __temp_stmt635 = default(object);
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						{
							#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							object l1 = default(object);
							#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							{
								#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
								object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.unity3d.Tooltip)) ), global::haxe.lang.Runtime.toString("moveText"), ((int) (1873885278) ))) ), 0);
								#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
								l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
							}
							
							#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							__temp_stmt635 = l1;
						}
						
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						listener1 = ((object) (__temp_stmt635) );
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						global::pony.events.Signal this2 = global::pony.DeltaTime.update;
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						this2.@add(((object) (listener1) ), new global::haxe.lang.Null<int>(priority1, true));
						#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object __temp_expr636 = this2.target;
					}
					
					global::pony.unity3d.Tooltip.moveText();
				}
				
			}
			#line default
		}
		
		
		public static   void moveTextPanel()
		{
			unchecked 
			{
				#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				global::pony.unity3d.Tooltip.textObject.transform.position = new global::UnityEngine.Vector3(((float) (( 1 - ( (( ( global::UnityEngine.Screen.width - global::UnityEngine.Input.mousePosition.x ) + ( ((double) (global::pony.unity3d.Tooltip.r.width) ) / 2 ) )) / global::pony.unity3d.Fixed2dCamera.SIZE ) )) ), ( (( ( global::UnityEngine.Input.mousePosition.y + global::pony.unity3d.Tooltip.r.height ) + ( global::pony.unity3d.Tooltip.border * 2 ) )) / global::UnityEngine.Screen.height ), ((float) (500) ));
				global::pony.unity3d.Tooltip.textureObject.transform.position = new global::UnityEngine.Vector3(((float) (( 1 - ( (( ( global::UnityEngine.Screen.width - global::UnityEngine.Input.mousePosition.x ) + ( ((double) (global::pony.unity3d.Tooltip.r.width) ) / 2 ) )) / global::pony.unity3d.Fixed2dCamera.SIZE ) )) ), ( (( ( global::UnityEngine.Input.mousePosition.y + global::pony.unity3d.Tooltip.r.height ) + ( global::pony.unity3d.Tooltip.border * 2 ) )) / global::UnityEngine.Screen.height ), ((float) (499) ));
			}
			#line default
		}
		
		
		public static   void moveText()
		{
			unchecked 
			{
				#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				double limx = ( global::pony.unity3d.Tooltip.limitBorder / (( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.SIZE )) );
				double limy = ( global::pony.unity3d.Tooltip.limitBorder / global::UnityEngine.Screen.height );
				double x = ( (( global::UnityEngine.Input.mousePosition.x - ( ((double) (global::pony.unity3d.Tooltip.r.width) ) / 2 ) )) / (( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.SIZE )) );
				double y = ( ((double) ((( ( global::UnityEngine.Input.mousePosition.y + global::pony.unity3d.Tooltip.r.height ) + ( global::pony.unity3d.Tooltip.border * 2 ) ))) ) / global::UnityEngine.Screen.height );
				double dw = ( 1 - ( ((double) (global::pony.unity3d.Tooltip.r.width) ) / (( global::UnityEngine.Screen.width - global::pony.unity3d.Fixed2dCamera.SIZE )) ) );
				double dh = ( ((double) (global::pony.unity3d.Tooltip.r.height) ) / global::UnityEngine.Screen.height );
				{
					#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					double max = ( dw - limx );
					#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					if (( x < limx )) 
					{
						#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						x = limx;
					}
					 else 
					{
						#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						if (( x > max )) 
						{
							#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							x = max;
						}
						 else 
						{
							#line 154 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							x = x;
						}
						
					}
					
				}
				
				{
					#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					double max1 = ( 1 - limy );
					#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					double min = ( dh + limy );
					#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					if (( y < min )) 
					{
						#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						y = min;
					}
					 else 
					{
						#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						if (( y > max1 )) 
						{
							#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							y = max1;
						}
						 else 
						{
							#line 155 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							y = y;
						}
						
					}
					
				}
				
				global::pony.unity3d.Tooltip.textObject.transform.position = new global::UnityEngine.Vector3(((float) (x) ), ((float) (y) ), ((float) (500) ));
				global::pony.unity3d.Tooltip.textureObject.transform.position = new global::UnityEngine.Vector3(((float) (x) ), ((float) (y) ), ((float) (499) ));
				y = ( ((double) ((( ( ( global::UnityEngine.Input.mousePosition.y + global::pony.unity3d.Tooltip.r.height ) + ( global::pony.unity3d.Tooltip.border * 2 ) ) - 15 ))) ) / global::UnityEngine.Screen.height );
				{
					#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					double max2 = ( 1 - limy );
					#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					double min1 = ( dh + limy );
					#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					if (( y < min1 )) 
					{
						#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						y = min1;
					}
					 else 
					{
						#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						if (( y > max2 )) 
						{
							#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							y = max2;
						}
						 else 
						{
							#line 159 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							y = y;
						}
						
					}
					
				}
				
				global::pony.unity3d.Tooltip.longTextObject.transform.position = new global::UnityEngine.Vector3(((float) (x) ), ((float) (y) ), ((float) (500) ));
			}
			#line default
		}
		
		
		public static   void hideText(object obj)
		{
			unchecked 
			{
				#line 164 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				if (( ! (global::haxe.lang.Runtime.eq(global::pony.unity3d.Tooltip.target, obj)) )) 
				{
					#line 164 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					return ;
				}
				
				if (( global::pony.unity3d.Tooltip.textObject == default(global::UnityEngine.GameObject) )) 
				{
					#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					return ;
				}
				
				global::pony.unity3d.Tooltip.guiTextObject.enabled = false;
				global::pony.unity3d.Tooltip.guiTextureObject.enabled = false;
				global::pony.unity3d.Tooltip.guiLongTextObject.enabled = false;
				{
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object listener = default(object);
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object __temp_stmt639 = default(object);
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					{
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object l = default(object);
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						{
							#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.unity3d.Tooltip)) ), global::haxe.lang.Runtime.toString("moveText"), ((int) (1873885278) ))) ), 0);
							#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
						}
						
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						__temp_stmt639 = l;
					}
					
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					listener = ((object) (__temp_stmt639) );
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					this1.@remove(((object) (listener) ));
					#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object __temp_expr640 = this1.target;
				}
				
				{
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object listener1 = default(object);
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object __temp_stmt641 = default(object);
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					{
						#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						object l1 = default(object);
						#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						{
							#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::pony.unity3d.Tooltip)) ), global::haxe.lang.Runtime.toString("moveTextPanel"), ((int) (1894751686) ))) ), 0);
							#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
							l1 = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
						}
						
						#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
						__temp_stmt641 = l1;
					}
					
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					listener1 = ((object) (__temp_stmt641) );
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					global::pony.events.Signal this2 = global::pony.DeltaTime.update;
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					this2.@remove(((object) (listener1) ));
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
					object __temp_expr642 = this2.target;
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				return new global::pony.unity3d.Tooltip(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 54 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/Tooltip.hx"
				return new global::pony.unity3d.Tooltip();
			}
			#line default
		}
		
		
	}
}



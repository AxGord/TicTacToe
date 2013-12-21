
public enum Ch
{
	None, Pl, Ai
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class EntryPoint__Main
{
	public static void Main()
	{
		global::cs.Boot.init();
		global::Main.main();
	}
}
public  class Main : global::pony.unity3d.DeltaTimeHelper 
{
	public    Main(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
	{
		unchecked 
		{
		}
		#line default
	}
	
	
	public    Main() : base()
	{
		unchecked 
		{
			#line 24 "src/Main.hx"
			this.game = new global::TicTacToe(((bool) (true) ));
		}
		#line default
	}
	
	
	public static   void main()
	{
		unchecked 
		{
			#line 100 "src/Main.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 21 "src/Main.hx"
			return new global::Main(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 21 "src/Main.hx"
			return new global::Main();
		}
		#line default
	}
	
	
	public  global::TicTacToe game;
	
	public  global::Array<global::Ch> players;
	
	public virtual   void Start()
	{
		unchecked 
		{
			#line 30 "src/Main.hx"
			{
				#line 30 "src/Main.hx"
				global::UI.mainMenu = global::UnityEngine.GameObject.Find("/UI/MainMenu");
				#line 30 "src/Main.hx"
				global::UI.endText = global::UnityEngine.GameObject.Find("/UI/EndText");
				#line 30 "src/Main.hx"
				global::UI.bGame = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bGame"), typeof(global::pony.unity3d.ui.Button))) ).core;
				#line 30 "src/Main.hx"
				global::UI.bMenu = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/bMenu"), typeof(global::pony.unity3d.ui.Button))) ).core;
				#line 30 "src/Main.hx"
				global::UI.bReturn = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bReturn"), typeof(global::pony.unity3d.ui.Button))) ).core;
				#line 30 "src/Main.hx"
				global::UI.bExit = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bExit"), typeof(global::pony.unity3d.ui.Button))) ).core;
				#line 30 "src/Main.hx"
				global::UI.bRandom = ((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find("/UI/MainMenu/bRandom"), typeof(global::pony.unity3d.ui.Button))) ).core;
				#line 30 "src/Main.hx"
				{
					#line 30 "src/Main.hx"
					global::Array<object> _g = new global::Array<object>(new object[]{});
					#line 30 "src/Main.hx"
					{
						#line 30 "src/Main.hx"
						int _g1 = 1;
						#line 30 "src/Main.hx"
						while (( _g1 < 4 ))
						{
							#line 30 "src/Main.hx"
							int i = _g1++;
							#line 30 "src/Main.hx"
							_g.push(((global::pony.unity3d.ui.Button) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(global::haxe.lang.Runtime.concat("/UI/MainMenu/bS", global::haxe.lang.Runtime.toString(i))), typeof(global::pony.unity3d.ui.Button))) ).core);
						}
						
					}
					
					#line 30 "src/Main.hx"
					global::UI.bS = _g;
				}
				
			}
			
			{
				#line 31 "src/Main.hx"
				{
					#line 31 "src/Main.hx"
					global::Array<object> _g2 = new global::Array<object>(new object[]{});
					#line 31 "src/Main.hx"
					{
						#line 31 "src/Main.hx"
						int _g11 = 0;
						#line 31 "src/Main.hx"
						while (( _g11 < 27 ))
						{
							#line 31 "src/Main.hx"
							int i1 = _g11++;
							#line 31 "src/Main.hx"
							_g2.push(((global::PlacePoint) (global::hugs.GameObjectMethods.getTypedComponent<object>(global::UnityEngine.GameObject.Find(global::haxe.lang.Runtime.concat("/Points/", global::haxe.lang.Runtime.toString(i1))), typeof(global::PlacePoint))) ));
						}
						
					}
					
					#line 31 "src/Main.hx"
					global::Scene.points = _g2;
				}
				
				#line 31 "src/Main.hx"
				{
					#line 31 "src/Main.hx"
					global::haxe.ds.EnumValueMap<global::Player, object> _g12 = new global::haxe.ds.EnumValueMap<global::Player, object>();
					#line 31 "src/Main.hx"
					_g12.@set(global::Player.X, global::UnityEngine.GameObject.Find("/Players/X"));
					#line 31 "src/Main.hx"
					_g12.@set(global::Player.Toe, global::UnityEngine.GameObject.Find("/Players/O"));
					#line 31 "src/Main.hx"
					_g12.@set(global::Player.Rhomb, global::UnityEngine.GameObject.Find("/Players/Rhomb"));
					#line 31 "src/Main.hx"
					global::Scene.players = _g12;
				}
				
			}
			
			global::UI.endText.guiText.enabled = false;
			object __temp_stmt268 = default(object);
			#line 33 "src/Main.hx"
			{
				#line 33 "src/Main.hx"
				object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (typeof(global::UnityEngine.Application)) ), global::haxe.lang.Runtime.toString("Quit"), ((int) (904096751) ))) ), 0);
				#line 33 "src/Main.hx"
				__temp_stmt268 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
			}
			
			#line 33 "src/Main.hx"
			global::UI.bExit.click.@add(__temp_stmt268, default(global::haxe.lang.Null<int>));
			{
				#line 34 "src/Main.hx"
				object listener = default(object);
				#line 34 "src/Main.hx"
				object __temp_stmt269 = default(object);
				#line 34 "src/Main.hx"
				{
					#line 34 "src/Main.hx"
					object l = default(object);
					#line 34 "src/Main.hx"
					{
						#line 34 "src/Main.hx"
						object f1 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) ), 0);
						#line 34 "src/Main.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f1, false);
					}
					
					#line 34 "src/Main.hx"
					__temp_stmt269 = l;
				}
				
				#line 34 "src/Main.hx"
				listener = ((object) (__temp_stmt269) );
				#line 34 "src/Main.hx"
				global::pony.events.Signal this1 = global::pony.DeltaTime.fixedUpdate;
				#line 34 "src/Main.hx"
				{
					#line 34 "src/Main.hx"
					int priority = 0;
					#line 34 "src/Main.hx"
					object listener1 = ((object) (listener) );
					#line 34 "src/Main.hx"
					object __temp_stmt270 = default(object);
					#line 34 "src/Main.hx"
					{
						#line 34 "src/Main.hx"
						object f2 = global::haxe.lang.Runtime.getField(listener1, "f", 102, true);
						#line 34 "src/Main.hx"
						object this2 = default(object);
						#line 34 "src/Main.hx"
						{
							#line 34 "src/Main.hx"
							object __temp_getvar141 = f2;
							#line 34 "src/Main.hx"
							double __temp_ret142 = ((double) (global::haxe.lang.Runtime.getField_f(__temp_getvar141, "used", 1303220797, true)) );
							#line 34 "src/Main.hx"
							object __temp_expr271 = ((object) (global::haxe.lang.Runtime.setField(__temp_getvar141, "used", 1303220797, ( __temp_ret142 + 1.0 ))) );
							#line 34 "src/Main.hx"
							double __temp_expr272 = __temp_ret142;
						}
						
						#line 34 "src/Main.hx"
						{
							#line 34 "src/Main.hx"
							bool __temp_odecl266 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "event", 1975830554, true)) );
							#line 34 "src/Main.hx"
							bool __temp_odecl267 = ((bool) (global::haxe.lang.Runtime.getField(listener1, "ignoreReturn", 98429794, true)) );
							#line 34 "src/Main.hx"
							this2 = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{102, 98429794, 373703110, 1247723251, 1975830554}), new global::Array<object>(new object[]{f2, __temp_odecl267, true, default(global::pony.events.Event), __temp_odecl266}), new global::Array<int>(new int[]{1248019663, 1303220797}), new global::Array<double>(new double[]{((double) (1) ), ((double) (0) )}));
						}
						
						#line 34 "src/Main.hx"
						__temp_stmt270 = this2;
					}
					
					#line 34 "src/Main.hx"
					this1.@add(((object) (__temp_stmt270) ), new global::haxe.lang.Null<int>(priority, true));
				}
				
				#line 34 "src/Main.hx"
				object __temp_expr273 = this1.target;
			}
			
		}
		#line default
	}
	
	
	public virtual   void init()
	{
		unchecked 
		{
			#line 38 "src/Main.hx"
			{
				#line 38 "src/Main.hx"
				global::Array<global::Ch> _g = new global::Array<global::Ch>(new global::Ch[]{});
				#line 38 "src/Main.hx"
				{
					#line 38 "src/Main.hx"
					int _g1 = 0;
					#line 38 "src/Main.hx"
					global::Array<object> _g2 = global::UI.bS;
					#line 38 "src/Main.hx"
					while (( _g1 < _g2.length ))
					{
						#line 38 "src/Main.hx"
						global::pony.ui.ButtonCore b = ((global::pony.ui.ButtonCore) (_g2[_g1]) );
						#line 38 "src/Main.hx"
						 ++ _g1;
						#line 38 "src/Main.hx"
						_g.push(this.chcnv(b.mode));
					}
					
				}
				
				#line 38 "src/Main.hx"
				this.players = _g;
			}
			
			{
				#line 39 "src/Main.hx"
				int _g21 = 0;
				#line 39 "src/Main.hx"
				int _g11 = global::UI.bS.length;
				#line 39 "src/Main.hx"
				while (( _g21 < _g11 ))
				{
					#line 39 "src/Main.hx"
					int i = _g21++;
					object __temp_stmt274 = default(object);
					#line 40 "src/Main.hx"
					{
						#line 40 "src/Main.hx"
						global::haxe.lang.Function __temp_stmt275 = default(global::haxe.lang.Function);
						#line 40 "src/Main.hx"
						{
							#line 40 "src/Main.hx"
							global::Array<int> n = new global::Array<int>(new int[]{i});
							#line 40 "src/Main.hx"
							global::Array<object> f1 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ch"), ((int) (22181) ))) )});
							#line 40 "src/Main.hx"
							__temp_stmt275 = new global::Main_init_40__Fun(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f1) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (n) ))) ));
						}
						
						#line 40 "src/Main.hx"
						object f = global::pony._Function.Function_Impl_.@from(__temp_stmt275, 1);
						#line 40 "src/Main.hx"
						__temp_stmt274 = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 40 "src/Main.hx"
					((global::pony.ui.ButtonCore) (global::UI.bS[i]) ).onMode.@add(__temp_stmt274, default(global::haxe.lang.Null<int>));
				}
				
			}
			
			#line 42 "src/Main.hx"
			this.openMenu();
			#line 44 "src/Main.hx"
			{
				#line 44 "src/Main.hx"
				object __temp_iterator143 = global::Scene.players.iterator();
				#line 44 "src/Main.hx"
				while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator143, "hasNext", 407283053, default(global::Array))) ))
				{
					#line 44 "src/Main.hx"
					global::UnityEngine.GameObject p = ((global::UnityEngine.GameObject) (global::haxe.lang.Runtime.callField(__temp_iterator143, "next", 1224901875, default(global::Array))) );
					#line 44 "src/Main.hx"
					p.gameObject.active = false;
				}
				
			}
			
			#line 46 "src/Main.hx"
			object __temp_stmt276 = default(object);
			#line 46 "src/Main.hx"
			{
				#line 46 "src/Main.hx"
				object f2 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("startGame"), ((int) (2102553972) ))) ), 0);
				#line 46 "src/Main.hx"
				__temp_stmt276 = global::pony.events._Listener.Listener_Impl_._fromFunction(f2, false);
			}
			
			#line 46 "src/Main.hx"
			global::UI.bGame.click.@add(__temp_stmt276, default(global::haxe.lang.Null<int>));
			object __temp_stmt277 = default(object);
			#line 47 "src/Main.hx"
			{
				#line 47 "src/Main.hx"
				object f3 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("openMenu"), ((int) (1771381385) ))) ), 0);
				#line 47 "src/Main.hx"
				__temp_stmt277 = global::pony.events._Listener.Listener_Impl_._fromFunction(f3, false);
			}
			
			#line 47 "src/Main.hx"
			global::UI.bMenu.click.@add(__temp_stmt277, default(global::haxe.lang.Null<int>));
			object __temp_stmt278 = default(object);
			#line 48 "src/Main.hx"
			{
				#line 48 "src/Main.hx"
				object f4 = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("closeMenu"), ((int) (304596343) ))) ), 0);
				#line 48 "src/Main.hx"
				__temp_stmt278 = global::pony.events._Listener.Listener_Impl_._fromFunction(f4, false);
			}
			
			#line 48 "src/Main.hx"
			global::UI.bReturn.click.subArgs(new global::Array<object>(new object[]{0})).@add(__temp_stmt278, default(global::haxe.lang.Null<int>));
			#line 50 "src/Main.hx"
			{
				#line 50 "src/Main.hx"
				int _g22 = 0;
				#line 50 "src/Main.hx"
				int _g12 = global::Scene.points.length;
				#line 50 "src/Main.hx"
				while (( _g22 < _g12 ))
				{
					#line 50 "src/Main.hx"
					int i1 = _g22++;
					global::PlacePoint p1 = ((global::PlacePoint) (global::Scene.points[i1]) );
					this.game.drawPoint.subArgs(new global::Array<object>(new object[]{i1})).@add(global::pony.events._Listener.Listener_Impl_._fromFunction(global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (p1) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) ), 1), true), default(global::haxe.lang.Null<int>));
					object __temp_stmt279 = default(object);
					#line 53 "src/Main.hx"
					{
						#line 53 "src/Main.hx"
						global::haxe.lang.Function __temp_stmt280 = default(global::haxe.lang.Function);
						#line 53 "src/Main.hx"
						{
							#line 53 "src/Main.hx"
							global::Array<int> to = new global::Array<int>(new int[]{i1});
							#line 53 "src/Main.hx"
							global::Array<object> f6 = new global::Array<object>(new object[]{((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this.game) ), global::haxe.lang.Runtime.toString("makeTurn"), ((int) (1134813323) ))) )});
							#line 53 "src/Main.hx"
							__temp_stmt280 = new global::Main_init_53__Fun(((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (to) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f6) ))) ));
						}
						
						#line 53 "src/Main.hx"
						object f5 = global::pony._Function.Function_Impl_.@from(__temp_stmt280, 0);
						#line 53 "src/Main.hx"
						__temp_stmt279 = global::pony.events._Listener.Listener_Impl_._fromFunction(f5, false);
					}
					
					#line 53 "src/Main.hx"
					p1.click.@add(__temp_stmt279, default(global::haxe.lang.Null<int>));
				}
				
			}
			
			#line 56 "src/Main.hx"
			{
				#line 56 "src/Main.hx"
				int priority = 0;
				#line 56 "src/Main.hx"
				object listener = default(object);
				#line 56 "src/Main.hx"
				object __temp_stmt281 = default(object);
				#line 56 "src/Main.hx"
				{
					#line 56 "src/Main.hx"
					object l = default(object);
					#line 56 "src/Main.hx"
					{
						#line 56 "src/Main.hx"
						object f7 = global::pony._Function.Function_Impl_.@from(( (( global::Main_init_56__Fun.__hx_current != default(global::Main_init_56__Fun) )) ? (global::Main_init_56__Fun.__hx_current) : (global::Main_init_56__Fun.__hx_current = ((global::Main_init_56__Fun) (new global::Main_init_56__Fun()) )) ), 0);
						#line 56 "src/Main.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f7, false);
					}
					
					#line 56 "src/Main.hx"
					__temp_stmt281 = l;
				}
				
				#line 56 "src/Main.hx"
				listener = ((object) (__temp_stmt281) );
				#line 56 "src/Main.hx"
				global::pony.events.Signal this1 = this.game.win;
				#line 56 "src/Main.hx"
				this1.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
				#line 56 "src/Main.hx"
				object __temp_expr282 = this1.target;
			}
			
		}
		#line default
	}
	
	
	public virtual   void ch(int n, int mode)
	{
		unchecked 
		{
			#line 63 "src/Main.hx"
			this.players[n] = this.chcnv(mode);
		}
		#line default
	}
	
	
	public virtual   global::Ch chcnv(int mode)
	{
		unchecked 
		{
			#line 65 "src/Main.hx"
			switch (mode)
			{
				case 0:
				{
					return global::Ch.Ai;
				}
				
				
				case 2:
				{
					return global::Ch.Pl;
				}
				
				
				case 3:
				{
					return global::Ch.None;
				}
				
				
				default:
				{
					{
					}
					
					#line 69 "src/Main.hx"
					break;
				}
				
			}
			
			#line 65 "src/Main.hx"
			return default(global::Ch);
		}
		#line default
	}
	
	
	public virtual   void openMenu()
	{
		unchecked 
		{
			#line 73 "src/Main.hx"
			global::UI.mainMenu.active = true;
			{
				#line 74 "src/Main.hx"
				int _g = 0;
				#line 74 "src/Main.hx"
				global::Array<object> _g1 = global::Scene.points;
				#line 74 "src/Main.hx"
				while (( _g < _g1.length ))
				{
					#line 74 "src/Main.hx"
					global::PlacePoint p = ((global::PlacePoint) (_g1[_g]) );
					#line 74 "src/Main.hx"
					 ++ _g;
					#line 74 "src/Main.hx"
					p.click.silent = true;
				}
				
			}
			
			global::UI.endText.guiText.enabled = false;
		}
		#line default
	}
	
	
	public virtual   void closeMenu()
	{
		unchecked 
		{
			#line 79 "src/Main.hx"
			global::UI.mainMenu.active = false;
			{
				#line 80 "src/Main.hx"
				int _g = 0;
				#line 80 "src/Main.hx"
				global::Array<object> _g1 = global::Scene.points;
				#line 80 "src/Main.hx"
				while (( _g < _g1.length ))
				{
					#line 80 "src/Main.hx"
					global::PlacePoint p = ((global::PlacePoint) (_g1[_g]) );
					#line 80 "src/Main.hx"
					 ++ _g;
					#line 80 "src/Main.hx"
					p.click.silent = false;
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   void startGame()
	{
		unchecked 
		{
			#line 84 "src/Main.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "Start game", new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"startGame", "Main", "Main.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (84) )})));
			global::UI.bReturn._set_mode(0);
			{
				#line 86 "src/Main.hx"
				global::TicTacToe _this = this.game;
				#line 86 "src/Main.hx"
				{
					#line 86 "src/Main.hx"
					global::Array<global::Player> _g = new global::Array<global::Player>(new global::Player[]{});
					#line 86 "src/Main.hx"
					{
						#line 86 "src/Main.hx"
						int _g2 = 0;
						#line 86 "src/Main.hx"
						int _g1 = _this.areaSize;
						#line 86 "src/Main.hx"
						while (( _g2 < _g1 ))
						{
							#line 86 "src/Main.hx"
							int _ = _g2++;
							#line 86 "src/Main.hx"
							_g.push(default(global::Player));
						}
						
					}
					
					#line 86 "src/Main.hx"
					_this.area = _g;
				}
				
				#line 86 "src/Main.hx"
				{
					#line 86 "src/Main.hx"
					int _g11 = 0;
					#line 86 "src/Main.hx"
					int _g3 = _this.areaSize;
					#line 86 "src/Main.hx"
					while (( _g11 < _g3 ))
					{
						#line 86 "src/Main.hx"
						int i = _g11++;
						#line 86 "src/Main.hx"
						global::pony.events.Signal this1 = _this.drawPoint;
						#line 86 "src/Main.hx"
						{
							#line 86 "src/Main.hx"
							this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{i, default(global::Player)})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 86 "src/Main.hx"
							global::pony.events.Signal __temp_expr283 = this1;
						}
						
						#line 86 "src/Main.hx"
						object __temp_expr284 = this1.target;
					}
					
				}
				
				#line 86 "src/Main.hx"
				_this.gameComplite = false;
			}
			
			this.closeMenu();
			int nc = 0;
			{
				#line 89 "src/Main.hx"
				int _g4 = 0;
				#line 89 "src/Main.hx"
				global::Array<global::Ch> _g12 = this.players;
				#line 89 "src/Main.hx"
				while (( _g4 < _g12.length ))
				{
					#line 89 "src/Main.hx"
					global::Ch p = _g12[_g4];
					#line 89 "src/Main.hx"
					 ++ _g4;
					#line 89 "src/Main.hx"
					if (( p != global::Ch.None )) 
					{
						#line 89 "src/Main.hx"
						nc++;
					}
					
				}
				
			}
			
			global::Array<global::Player> ais = new global::Array<global::Player>(new global::Player[]{});
			{
				#line 91 "src/Main.hx"
				int _g13 = 0;
				#line 91 "src/Main.hx"
				int _g5 = this.players.length;
				#line 91 "src/Main.hx"
				while (( _g13 < _g5 ))
				{
					#line 91 "src/Main.hx"
					int i1 = _g13++;
					#line 91 "src/Main.hx"
					if (( this.players[i1] == global::Ch.Ai )) 
					{
						#line 91 "src/Main.hx"
						switch (i1)
						{
							case 0:
							{
								ais.push(global::Player.X);
								#line 92 "src/Main.hx"
								break;
							}
							
							
							case 1:
							{
								ais.push(global::Player.Toe);
								#line 93 "src/Main.hx"
								break;
							}
							
							
							case 2:
							{
								ais.push(global::Player.Rhomb);
								#line 94 "src/Main.hx"
								break;
							}
							
							
							default:
							{
								{
								}
								
								#line 95 "src/Main.hx"
								break;
							}
							
						}
						
					}
					
				}
				
			}
			
			#line 97 "src/Main.hx"
			this.game.start(nc, new global::haxe.lang.Null<bool>(( global::UI.bRandom.mode == 0 ), true), ais);
		}
		#line default
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			#line 21 "src/Main.hx"
			switch (hash)
			{
				case 169150962:
				{
					#line 21 "src/Main.hx"
					this.players = ((global::Array<global::Ch>) (global::Array<object>.__hx_cast<global::Ch>(((global::Array) (@value) ))) );
					#line 21 "src/Main.hx"
					return @value;
				}
				
				
				case 1147073522:
				{
					#line 21 "src/Main.hx"
					this.game = ((global::TicTacToe) (@value) );
					#line 21 "src/Main.hx"
					return @value;
				}
				
				
				default:
				{
					#line 21 "src/Main.hx"
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
			#line 21 "src/Main.hx"
			switch (hash)
			{
				case 2102553972:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("startGame"), ((int) (2102553972) ))) );
				}
				
				
				case 304596343:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("closeMenu"), ((int) (304596343) ))) );
				}
				
				
				case 1771381385:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("openMenu"), ((int) (1771381385) ))) );
				}
				
				
				case 1169497574:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("chcnv"), ((int) (1169497574) ))) );
				}
				
				
				case 22181:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("ch"), ((int) (22181) ))) );
				}
				
				
				case 1169898256:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
				}
				
				
				case 389604418:
				{
					#line 21 "src/Main.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("Start"), ((int) (389604418) ))) );
				}
				
				
				case 169150962:
				{
					#line 21 "src/Main.hx"
					return this.players;
				}
				
				
				case 1147073522:
				{
					#line 21 "src/Main.hx"
					return this.game;
				}
				
				
				default:
				{
					#line 21 "src/Main.hx"
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_invokeField(string field, int hash, global::Array dynargs)
	{
		unchecked 
		{
			#line 21 "src/Main.hx"
			switch (hash)
			{
				case 2102553972:
				{
					#line 21 "src/Main.hx"
					this.startGame();
					#line 21 "src/Main.hx"
					break;
				}
				
				
				case 304596343:
				{
					#line 21 "src/Main.hx"
					this.closeMenu();
					#line 21 "src/Main.hx"
					break;
				}
				
				
				case 1771381385:
				{
					#line 21 "src/Main.hx"
					this.openMenu();
					#line 21 "src/Main.hx"
					break;
				}
				
				
				case 1169497574:
				{
					#line 21 "src/Main.hx"
					return this.chcnv(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 22181:
				{
					#line 21 "src/Main.hx"
					this.ch(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					#line 21 "src/Main.hx"
					break;
				}
				
				
				case 1169898256:
				{
					#line 21 "src/Main.hx"
					this.init();
					#line 21 "src/Main.hx"
					break;
				}
				
				
				case 389604418:
				{
					#line 21 "src/Main.hx"
					this.Start();
					#line 21 "src/Main.hx"
					break;
				}
				
				
				default:
				{
					#line 21 "src/Main.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			#line 21 "src/Main.hx"
			return default(object);
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 21 "src/Main.hx"
			baseArr.push("players");
			#line 21 "src/Main.hx"
			baseArr.push("game");
			#line 21 "src/Main.hx"
			{
				#line 21 "src/Main.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Main_init_40__Fun : global::haxe.lang.Function 
{
	public    Main_init_40__Fun(global::Array<object> f1, global::Array<int> n) : base(1, 0)
	{
		unchecked 
		{
			#line 40 "src/Main.hx"
			this.f1 = f1;
			#line 40 "src/Main.hx"
			this.n = n;
		}
		#line default
	}
	
	
	public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
	{
		unchecked 
		{
			#line 40 "src/Main.hx"
			int a1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((int) (__fn_float1) )) : (((int) (global::haxe.lang.Runtime.toInt(__fn_dyn1)) )) );
			#line 40 "src/Main.hx"
			return ((global::haxe.lang.Function) (this.f1[0]) ).__hx_invoke2_o(((double) (this.n[0]) ), ((double) (a1) ), global::haxe.lang.Runtime.undefined, global::haxe.lang.Runtime.undefined);
		}
		#line default
	}
	
	
	public  global::Array<object> f1;
	
	public  global::Array<int> n;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Main_init_53__Fun : global::haxe.lang.Function 
{
	public    Main_init_53__Fun(global::Array<int> to, global::Array<object> f6) : base(0, 0)
	{
		unchecked 
		{
			#line 53 "src/Main.hx"
			this.to = to;
			#line 53 "src/Main.hx"
			this.f6 = f6;
		}
		#line default
	}
	
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			#line 53 "src/Main.hx"
			return ((global::haxe.lang.Function) (this.f6[0]) ).__hx_invoke1_o(((double) (this.to[0]) ), global::haxe.lang.Runtime.undefined);
		}
		#line default
	}
	
	
	public  global::Array<int> to;
	
	public  global::Array<object> f6;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Main_init_56__Fun : global::haxe.lang.Function 
{
	public    Main_init_56__Fun() : base(0, 0)
	{
		unchecked 
		{
		}
		#line default
	}
	
	
	public static  global::Main_init_56__Fun __hx_current;
	
	public override   object __hx_invoke0_o()
	{
		unchecked 
		{
			#line 57 "src/Main.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "Game complite!", new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"init", "Main", "Main.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (57) )})));
			global::UI.endText.guiText.enabled = true;
			global::UI.bReturn._set_mode(1);
			#line 56 "src/Main.hx"
			return default(object);
		}
		#line default
	}
	
	
}



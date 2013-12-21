
public enum Player
{
	None, X, Toe, Rhomb
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class TicTacToe : global::haxe.lang.HxObject 
{
	static TicTacToe() 
	{
		#line 19 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
		global::TicTacToe.lines2d = new global::Array<object>(new object[]{new global::Array<int>(new int[]{0, 1, 2}), new global::Array<int>(new int[]{3, 4, 5}), new global::Array<int>(new int[]{6, 7, 8}), new global::Array<int>(new int[]{0, 3, 6}), new global::Array<int>(new int[]{1, 4, 7}), new global::Array<int>(new int[]{2, 5, 8}), new global::Array<int>(new int[]{6, 4, 2}), new global::Array<int>(new int[]{0, 4, 8})});
		#line 26 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
		global::TicTacToe.lines3d = new global::Array<object>(new object[]{new global::Array<int>(new int[]{0, 1, 2}), new global::Array<int>(new int[]{3, 4, 5}), new global::Array<int>(new int[]{6, 7, 8}), new global::Array<int>(new int[]{0, 3, 6}), new global::Array<int>(new int[]{1, 4, 7}), new global::Array<int>(new int[]{2, 5, 8}), new global::Array<int>(new int[]{6, 4, 2}), new global::Array<int>(new int[]{0, 4, 8}), new global::Array<int>(new int[]{9, 10, 11}), new global::Array<int>(new int[]{12, 13, 14}), new global::Array<int>(new int[]{15, 16, 17}), new global::Array<int>(new int[]{9, 12, 15}), new global::Array<int>(new int[]{10, 13, 16}), new global::Array<int>(new int[]{11, 14, 17}), new global::Array<int>(new int[]{11, 13, 15}), new global::Array<int>(new int[]{9, 13, 17}), new global::Array<int>(new int[]{18, 19, 20}), new global::Array<int>(new int[]{21, 22, 23}), new global::Array<int>(new int[]{24, 25, 26}), new global::Array<int>(new int[]{18, 21, 24}), new global::Array<int>(new int[]{19, 22, 25}), new global::Array<int>(new int[]{20, 23, 26}), new global::Array<int>(new int[]{20, 22, 24}), new global::Array<int>(new int[]{18, 22, 26}), new global::Array<int>(new int[]{8, 16, 24}), new global::Array<int>(new int[]{7, 16, 25}), new global::Array<int>(new int[]{6, 16, 26}), new global::Array<int>(new int[]{6, 16, 26}), new global::Array<int>(new int[]{3, 12, 21}), new global::Array<int>(new int[]{4, 13, 22}), new global::Array<int>(new int[]{5, 14, 23}), new global::Array<int>(new int[]{3, 13, 23}), new global::Array<int>(new int[]{5, 13, 21}), new global::Array<int>(new int[]{0, 9, 18}), new global::Array<int>(new int[]{1, 10, 19}), new global::Array<int>(new int[]{2, 11, 20}), new global::Array<int>(new int[]{0, 10, 20}), new global::Array<int>(new int[]{2, 10, 18}), new global::Array<int>(new int[]{8, 12, 18}), new global::Array<int>(new int[]{0, 12, 24}), new global::Array<int>(new int[]{1, 13, 25}), new global::Array<int>(new int[]{7, 13, 19}), new global::Array<int>(new int[]{2, 14, 26}), new global::Array<int>(new int[]{6, 13, 20}), new global::Array<int>(new int[]{4, 13, 22}), new global::Array<int>(new int[]{8, 14, 20}), new global::Array<int>(new int[]{0, 13, 26}), new global::Array<int>(new int[]{2, 13, 24}), new global::Array<int>(new int[]{6, 12, 18})});
	}
	public    TicTacToe(global::haxe.lang.EmptyObject empty)
	{
		unchecked 
		{
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    TicTacToe(bool d3)
	{
		unchecked 
		{
			#line 52 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			global::TicTacToe.__hx_ctor__TicTacToe(this, d3);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__TicTacToe(global::TicTacToe __temp_me14, bool d3)
	{
		unchecked 
		{
			#line 49 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			__temp_me14.currentPlayerId = 0;
			#line 42 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			__temp_me14.areaSize = 9;
			#line 54 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			__temp_me14.d3 = d3;
			if (d3) 
			{
				__temp_me14.areaSize *= 3;
				__temp_me14.lines = global::TicTacToe.lines3d;
			}
			 else 
			{
				#line 59 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				__temp_me14.lines = global::TicTacToe.lines2d;
			}
			
			#line 61 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			__temp_me14.ps = global::Type.allEnums<global::Player>(typeof(global::Player));
			__temp_me14.ps.shift();
			{
				#line 63 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::pony.events.Signal this1 = global::pony.events.Signal.create<object>(__temp_me14);
				#line 63 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				__temp_me14.drawPoint = ((global::pony.events.Signal) (this1) );
			}
			
			{
				#line 64 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::pony.events.Signal this2 = global::pony.events.Signal.create<object>(__temp_me14);
				#line 64 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				__temp_me14.win = ((global::pony.events.Signal) (this2) );
			}
			
			{
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int priority = 0;
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				object listener = default(object);
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				object __temp_stmt295 = default(object);
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					object l = default(object);
					#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					{
						#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						object f = global::pony._Function.Function_Impl_.@from(((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (__temp_me14) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) ), 0);
						#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						l = global::pony.events._Listener.Listener_Impl_._fromFunction(f, false);
					}
					
					#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					__temp_stmt295 = l;
				}
				
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				listener = ((object) (__temp_stmt295) );
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::pony.events.Signal this3 = __temp_me14.win;
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this3.@add(((object) (listener) ), new global::haxe.lang.Null<int>(priority, true));
				#line 65 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				object __temp_expr296 = this3.target;
			}
			
			{
				#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<global::Player> _g = new global::Array<global::Player>(new global::Player[]{});
				#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g2 = 0;
					#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g1 = __temp_me14.areaSize;
					#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					while (( _g2 < _g1 ))
					{
						#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _ = _g2++;
						#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						_g.push(default(global::Player));
					}
					
				}
				
				#line 66 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				__temp_me14.area = _g;
			}
			
		}
		#line default
	}
	
	
	public static  global::Array<object> lines2d;
	
	public static  global::Array<object> lines3d;
	
	public static  new object __hx_createEmpty()
	{
		unchecked 
		{
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			return new global::TicTacToe(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr)
	{
		unchecked 
		{
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			return new global::TicTacToe(((bool) (arr[0]) ));
		}
		#line default
	}
	
	
	public  global::pony.events.Signal drawPoint;
	
	public  global::pony.events.Signal win;
	
	public  bool gameComplite;
	
	public  global::Array<global::Player> area;
	
	public  int areaSize;
	
	public  bool d3;
	
	public  global::Array<global::Player> ai;
	
	public  global::Array<object> lines;
	
	public  global::Array<global::Player> ps;
	
	public  int currentPlayerId;
	
	public  int playersCount;
	
	public virtual   void end()
	{
		unchecked 
		{
			#line 69 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			this.gameComplite = true;
		}
		#line default
	}
	
	
	public   global::Player _get_turn()
	{
		unchecked 
		{
			#line 71 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			return this.ps[this.currentPlayerId];
		}
		#line default
	}
	
	
	public virtual   void start(int playersCount, global::haxe.lang.Null<bool> randomBeginer, global::Array<global::Player> ai)
	{
		unchecked 
		{
			#line 73 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			bool __temp_randomBeginer13 = ( (global::haxe.lang.Runtime.eq((randomBeginer).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (randomBeginer.@value) );
			this.playersCount = playersCount;
			if (( ai == default(global::Array<global::Player>) )) 
			{
				#line 75 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.ai = new global::Array<global::Player>(new global::Player[]{});
			}
			 else 
			{
				#line 75 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.ai = ai;
			}
			
			if (__temp_randomBeginer13) 
			{
				#line 76 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				double v = ( global::Math.rand.NextDouble() * playersCount );
				#line 76 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 76 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					double x = global::System.Math.Floor(((double) (v) ));
					#line 76 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.currentPlayerId = ((int) (x) );
				}
				
			}
			 else 
			{
				#line 76 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.currentPlayerId = 0;
			}
			
			this.aiTurn(default(global::haxe.lang.Null<int>));
		}
		#line default
	}
	
	
	public   void emptyArea()
	{
		unchecked 
		{
			#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<global::Player> _g = new global::Array<global::Player>(new global::Player[]{});
				#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g2 = 0;
					#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g1 = this.areaSize;
					#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					while (( _g2 < _g1 ))
					{
						#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _ = _g2++;
						#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						_g.push(default(global::Player));
					}
					
				}
				
				#line 81 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.area = _g;
			}
			
		}
		#line default
	}
	
	
	public   void empty()
	{
		unchecked 
		{
			#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<global::Player> _g = new global::Array<global::Player>(new global::Player[]{});
				#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g2 = 0;
					#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g1 = this.areaSize;
					#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					while (( _g2 < _g1 ))
					{
						#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _ = _g2++;
						#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						_g.push(default(global::Player));
					}
					
				}
				
				#line 85 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.area = _g;
			}
			
			{
				#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g11 = 0;
				#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g3 = this.areaSize;
				#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g11 < _g3 ))
				{
					#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int i = _g11++;
					#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::pony.events.Signal this1 = this.drawPoint;
					#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					{
						#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{i, default(global::Player)})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						global::pony.events.Signal __temp_expr287 = this1;
					}
					
					#line 86 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					object __temp_expr288 = this1.target;
				}
				
			}
			
			this.gameComplite = false;
		}
		#line default
	}
	
	
	public virtual   void makeTurn(int to)
	{
		unchecked 
		{
			#line 91 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			this.push(this.ps[this.currentPlayerId], to);
			this.aiTurn(new global::haxe.lang.Null<int>(to, true));
		}
		#line default
	}
	
	
	public   void swTurn()
	{
		unchecked 
		{
			#line 96 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			this.currentPlayerId++;
			if (( this.currentPlayerId >= this.playersCount )) 
			{
				#line 97 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.currentPlayerId = 0;
			}
			
		}
		#line default
	}
	
	
	public virtual   void push(global::Player v, int to)
	{
		unchecked 
		{
			#line 101 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			if (this.gameComplite) 
			{
				#line 101 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				return ;
			}
			
			if (( this.area[to] != default(global::Player) )) 
			{
				#line 102 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Point ", global::haxe.lang.Runtime.toString(to)), " not empty! ("), global::Std.@string(v)), ")"));
			}
			
			this.area[to] = v;
			{
				#line 104 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::pony.events.Signal this1 = this.drawPoint;
				#line 104 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 104 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{to, v})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
					#line 104 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::pony.events.Signal __temp_expr289 = this1;
				}
				
				#line 104 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				object __temp_expr290 = this1.target;
			}
			
			{
				#line 105 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				this.currentPlayerId++;
				#line 105 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				if (( this.currentPlayerId >= this.playersCount )) 
				{
					#line 105 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.currentPlayerId = 0;
				}
				
			}
			
			{
				#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g = 0;
				#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<object> _g1 = this.lines;
				#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g < _g1.length ))
				{
					#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::Array<int> l = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (_g1[_g]) ))) );
					#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					 ++ _g;
					#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					{
						#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _g2 = 0;
						#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						global::Array<global::Player> _g3 = this.ps;
						#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						while (( _g2 < _g3.length ))
						{
							#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							global::Player p = _g3[_g2];
							#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							 ++ _g2;
							#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							int c = 0;
							#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							{
								#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								int _g4 = 0;
								#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								while (( _g4 < l.length ))
								{
									#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									int n = l[_g4];
									#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									 ++ _g4;
									#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									if (( this.area[n] == p )) 
									{
										#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
										c++;
									}
									
								}
								
							}
							
							#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							if (( c == 3 )) 
							{
								#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								global::pony.events.Signal this2 = this.win;
								#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								{
									#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									this2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<global::Player>(new global::Player[]{p})) ), ((object) (this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
									#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									global::pony.events.Signal __temp_expr291 = this2;
								}
								
								#line 106 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								object __temp_expr292 = this2.target;
							}
							
						}
						
					}
					
				}
				
			}
			
		}
		#line default
	}
	
	
	public   void checkWin()
	{
		unchecked 
		{
			#line 110 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			int _g = 0;
			#line 110 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			global::Array<object> _g1 = this.lines;
			#line 110 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			while (( _g < _g1.length ))
			{
				#line 110 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<int> l = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (_g1[_g]) ))) );
				#line 110 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				 ++ _g;
				{
					#line 111 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int _g2 = 0;
					#line 111 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::Array<global::Player> _g3 = this.ps;
					#line 111 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					while (( _g2 < _g3.length ))
					{
						#line 111 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						global::Player p = _g3[_g2];
						#line 111 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						 ++ _g2;
						int c = 0;
						{
							#line 113 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							int _g4 = 0;
							#line 113 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							while (( _g4 < l.length ))
							{
								#line 113 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								int n = l[_g4];
								#line 113 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								 ++ _g4;
								if (( this.area[n] == p )) 
								{
									#line 114 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									c++;
								}
								
							}
							
						}
						
						if (( c == 3 )) 
						{
							global::pony.events.Signal this1 = this.win;
							#line 116 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							{
								#line 116 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<global::Player>(new global::Player[]{p})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
								#line 116 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								global::pony.events.Signal __temp_expr293 = this1;
							}
							
							#line 116 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							object __temp_expr294 = this1.target;
						}
						
					}
					
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   void aiTurn(global::haxe.lang.Null<int> last)
	{
		unchecked 
		{
			#line 122 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			if (this.gameComplite) 
			{
				#line 122 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				return ;
			}
			
			if (( global::Lambda.indexOf<global::Player>(this.ai, this.ps[this.currentPlayerId]) == -1 )) 
			{
				#line 123 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				return ;
			}
			
			#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g = 0;
				#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<object> _g1 = this.lines;
				#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g < _g1.length ))
				{
					#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::Array<int> l = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (_g1[_g]) ))) );
					#line 125 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					 ++ _g;
					int c = 0;
					int num = 0;
					{
						#line 128 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _g2 = 0;
						#line 128 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						while (( _g2 < l.length ))
						{
							#line 128 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							int n = l[_g2];
							#line 128 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							 ++ _g2;
							if (( this.area[n] == this.ps[this.currentPlayerId] )) 
							{
								#line 129 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								c++;
							}
							 else 
							{
								num = n;
							}
							
						}
						
					}
					
					if (( ( c == 2 ) && ( this.area[num] == default(global::Player) ) )) 
					{
						this.push(this.ps[this.currentPlayerId], num);
						this.aiTurn(new global::haxe.lang.Null<int>(num, true));
						return ;
					}
					
				}
				
			}
			
			#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g3 = 0;
				#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<object> _g11 = this.lines;
				#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g3 < _g11.length ))
				{
					#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::Array<int> l1 = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (_g11[_g3]) ))) );
					#line 139 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					 ++ _g3;
					int c1 = 0;
					{
						#line 141 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						int _g21 = 0;
						#line 141 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						global::Array<global::Player> _g31 = this.ps;
						#line 141 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						while (( _g21 < _g31.length ))
						{
							#line 141 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							global::Player p = _g31[_g21];
							#line 141 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
							 ++ _g21;
							int num1 = 0;
							{
								#line 143 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								int _g4 = 0;
								#line 143 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
								while (( _g4 < l1.length ))
								{
									#line 143 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									int n1 = l1[_g4];
									#line 143 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
									 ++ _g4;
									if (( this.area[n1] == p )) 
									{
										#line 144 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
										c1++;
									}
									 else 
									{
										num1 = n1;
									}
									
								}
								
							}
							
							if (( ( c1 == 2 ) && ( this.area[num1] == default(global::Player) ) )) 
							{
								this.push(this.ps[this.currentPlayerId], num1);
								this.aiTurn(new global::haxe.lang.Null<int>(num1, true));
								return ;
							}
							
						}
						
					}
					
				}
				
			}
			
			#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			if (( ! (global::haxe.lang.Runtime.eq((last).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) )) 
			{
				#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g5 = 0;
				#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				global::Array<object> _g12 = this.lines;
				#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g5 < _g12.length ))
				{
					#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					global::Array<int> l2 = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (_g12[_g5]) ))) );
					#line 154 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					 ++ _g5;
					if (( global::haxe.lang.Runtime.eq(l2[0], (last).toDynamic()) && ( this.area[l2[2]] == default(global::Player) ) )) 
					{
						this.push(this.ps[this.currentPlayerId], l2[2]);
						this.aiTurn(new global::haxe.lang.Null<int>(l2[2], true));
						return ;
					}
					
					#line 160 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					if (( global::haxe.lang.Runtime.eq(l2[2], (last).toDynamic()) && ( this.area[l2[0]] == default(global::Player) ) )) 
					{
						this.push(this.ps[this.currentPlayerId], l2[0]);
						this.aiTurn(new global::haxe.lang.Null<int>(l2[0], true));
						return ;
					}
					
				}
				
			}
			
			#line 167 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			global::Array<int> emptys = new global::Array<int>(new int[]{});
			{
				#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g13 = 0;
				#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				int _g6 = this.areaSize;
				#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				while (( _g13 < _g6 ))
				{
					#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					int i = _g13++;
					#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					if (( this.area[i] == default(global::Player) )) 
					{
						#line 168 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
						emptys.push(i);
					}
					
				}
				
			}
			
			int pos = default(int);
			#line 169 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 169 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				double v = ( global::Math.rand.NextDouble() * emptys.length );
				#line 169 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				{
					#line 169 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					double x = global::System.Math.Floor(((double) (v) ));
					#line 169 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					pos = ((int) (x) );
				}
				
			}
			
			pos = emptys[pos];
			this.push(this.ps[this.currentPlayerId], pos);
			this.aiTurn(new global::haxe.lang.Null<int>(pos, true));
		}
		#line default
	}
	
	
	public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			switch (hash)
			{
				case 536370557:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.playersCount = ((int) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 480591605:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.currentPlayerId = ((int) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 599958254:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.areaSize = ((int) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				default:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
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
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			switch (hash)
			{
				case 536370557:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.playersCount = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 480591605:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.currentPlayerId = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 25091:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.ps = ((global::Array<global::Player>) (global::Array<object>.__hx_cast<global::Player>(((global::Array) (@value) ))) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 1963056639:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.lines = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 21736:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.ai = ((global::Array<global::Player>) (global::Array<object>.__hx_cast<global::Player>(((global::Array) (@value) ))) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 22351:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.d3 = ((bool) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 599958254:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.areaSize = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 1081379725:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.area = ((global::Array<global::Player>) (global::Array<object>.__hx_cast<global::Player>(((global::Array) (@value) ))) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 985398223:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.gameComplite = ((bool) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 5941276:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.win = ((global::pony.events.Signal) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				case 245033388:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.drawPoint = ((global::pony.events.Signal) (@value) );
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return @value;
				}
				
				
				default:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
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
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			switch (hash)
			{
				case 1972371589:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("aiTurn"), ((int) (1972371589) ))) );
				}
				
				
				case 753759284:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("checkWin"), ((int) (753759284) ))) );
				}
				
				
				case 1247875546:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("push"), ((int) (1247875546) ))) );
				}
				
				
				case 932748865:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("swTurn"), ((int) (932748865) ))) );
				}
				
				
				case 1134813323:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("makeTurn"), ((int) (1134813323) ))) );
				}
				
				
				case 1876572813:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("empty"), ((int) (1876572813) ))) );
				}
				
				
				case 2102181050:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("emptyArea"), ((int) (2102181050) ))) );
				}
				
				
				case 67859554:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("start"), ((int) (67859554) ))) );
				}
				
				
				case 1287694086:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_turn"), ((int) (1287694086) ))) );
				}
				
				
				case 5047259:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("end"), ((int) (5047259) ))) );
				}
				
				
				case 536370557:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.playersCount;
				}
				
				
				case 480591605:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.currentPlayerId;
				}
				
				
				case 25091:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.ps;
				}
				
				
				case 1963056639:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.lines;
				}
				
				
				case 1292233597:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this._get_turn();
				}
				
				
				case 21736:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.ai;
				}
				
				
				case 22351:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.d3;
				}
				
				
				case 599958254:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.areaSize;
				}
				
				
				case 1081379725:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.area;
				}
				
				
				case 985398223:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.gameComplite;
				}
				
				
				case 5941276:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.win;
				}
				
				
				case 245033388:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this.drawPoint;
				}
				
				
				default:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
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
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			switch (hash)
			{
				case 536370557:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((double) (this.playersCount) );
				}
				
				
				case 480591605:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((double) (this.currentPlayerId) );
				}
				
				
				case 599958254:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return ((double) (this.areaSize) );
				}
				
				
				default:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
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
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			switch (hash)
			{
				case 1972371589:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.aiTurn(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]));
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 753759284:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.checkWin();
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 1247875546:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.push(((global::Player) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 932748865:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.swTurn();
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 1134813323:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.makeTurn(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 1876572813:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.empty();
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 2102181050:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.emptyArea();
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 67859554:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.start(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]), ((global::Array<global::Player>) (global::Array<object>.__hx_cast<global::Player>(((global::Array) (dynargs[2]) ))) ));
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				case 1287694086:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return this._get_turn();
				}
				
				
				case 5047259:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					this.end();
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					break;
				}
				
				
				default:
				{
					#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			return default(object);
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr)
	{
		unchecked 
		{
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("playersCount");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("currentPlayerId");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("ps");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("lines");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("turn");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("ai");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("d3");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("areaSize");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("area");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("gameComplite");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("win");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			baseArr.push("drawPoint");
			#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
			{
				#line 14 "D:\\for presentation\\TicTacToe\\logic\\TicTacToe.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
	public   global::Player turn
	{
		get { return _get_turn(); }
	}
}



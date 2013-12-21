
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class DeltaTime : global::haxe.lang.HxObject 
	{
		static DeltaTime() 
		{
			#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
			{
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this1 = global::pony.events.Signal.createEmpty();
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.update = ((global::pony.events.Signal) (this1) );
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this2 = global::pony.events.Signal.createEmpty();
					#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.fixedUpdate = ((global::pony.events.Signal) (this2) );
				}
				
			}
			
			#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
			global::pony.DeltaTime.speed = ((double) (1) );
			#line 42 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
			global::pony.DeltaTime.@value = ((double) (0) );
			global::pony.DeltaTime.fixedValue = ((double) (0) );
		}
		public    DeltaTime(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    DeltaTime()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				global::pony.DeltaTime.__hx_ctor_pony_DeltaTime(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_DeltaTime(global::pony.DeltaTime __temp_me93)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  double speed;
		
		public static  global::pony.events.Signal update;
		
		public static  global::pony.events.Signal fixedUpdate;
		
		public static  double @value;
		
		public static  double fixedValue;
		
		public static  double t;
		
		public static   void tick()
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				double __temp_stmt419 = default(double);
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::Date _this = global::Date.now();
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					__temp_stmt419 = ( ((double) (_this.date.Ticks) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
				}
				
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				global::pony.DeltaTime.fixedValue = ( (( __temp_stmt419 - global::pony.DeltaTime.t )) / 1000 );
				{
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::Date _this1 = global::Date.now();
					#line 56 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.t = ( ((double) (_this1.date.Ticks) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
				}
				
				global::pony.DeltaTime.@value = ( global::pony.DeltaTime.fixedValue * global::pony.DeltaTime.speed );
				{
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this1 = global::pony.DeltaTime.update;
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					{
						#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<double>(new double[]{global::pony.DeltaTime.@value})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						global::pony.events.Signal __temp_expr420 = this1;
					}
					
					#line 58 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					object __temp_expr421 = this1.target;
				}
				
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this2 = global::pony.DeltaTime.fixedUpdate;
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					{
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						this2.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<double>(new double[]{global::pony.DeltaTime.fixedValue})) ), ((object) (this2.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						global::pony.events.Signal __temp_expr422 = this2;
					}
					
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					object __temp_expr423 = this2.target;
				}
				
			}
			#line default
		}
		
		
		public static   void @set()
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::Date _this = global::Date.now();
					#line 62 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.t = ( ((double) (_this.date.Ticks) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
				}
				
			}
			#line default
		}
		
		
		public static   double @get()
		{
			unchecked 
			{
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				double __temp_stmt424 = default(double);
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::Date _this = global::Date.now();
					#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					__temp_stmt424 = ( ((double) (_this.date.Ticks) ) / ((double) (global::System.TimeSpan.TicksPerMillisecond) ) );
				}
				
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				return ( (( __temp_stmt424 - global::pony.DeltaTime.t )) / 1000 );
			}
			#line default
		}
		
		
		public static   void createSignals()
		{
			unchecked 
			{
				#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				{
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this1 = global::pony.events.Signal.createEmpty();
					#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.update = ((global::pony.events.Signal) (this1) );
				}
				
				{
					#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.events.Signal this2 = global::pony.events.Signal.createEmpty();
					#line 89 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					global::pony.DeltaTime.fixedUpdate = ((global::pony.events.Signal) (this2) );
				}
				
			}
			#line default
		}
		
		
		public static   void testRun(global::haxe.lang.Null<double> sec)
		{
			unchecked 
			{
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				double __temp_sec92 = ( (global::haxe.lang.Runtime.eq((sec).toDynamic(), (default(global::haxe.lang.Null<double>)).toDynamic())) ? (((double) (60) )) : (sec.@value) );
				int d = default(int);
				#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				if (( __temp_sec92 < 100 )) 
				{
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					d = 10;
				}
				 else 
				{
					#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					if (( __temp_sec92 < 1000 )) 
					{
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						d = 50;
					}
					 else 
					{
						#line 97 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						d = 100;
					}
					
				}
				
				while (( __temp_sec92 > 0 ))
				{
					double r = ( global::Math.rand.NextDouble() * d );
					if (( __temp_sec92 >= r )) 
					{
						__temp_sec92 -= r;
					}
					 else 
					{
						#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						r = __temp_sec92;
						__temp_sec92 = ((double) (0) );
					}
					
					#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
					{
						#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						global::pony.events.Signal this1 = global::pony.DeltaTime.update;
						#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						{
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
							this1.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<double>(new double[]{r})) ), ((object) (this1.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
							global::pony.events.Signal __temp_expr425 = this1;
						}
						
						#line 106 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
						object __temp_expr426 = this1.target;
					}
					
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				return new global::pony.DeltaTime(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/DeltaTime.hx"
				return new global::pony.DeltaTime();
			}
			#line default
		}
		
		
	}
}



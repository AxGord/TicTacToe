
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  class LV<T> : global::pony.events.Signal, global::pony.events.LV 
	{
		public    LV(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    LV(T @value) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				global::pony.events.LV<object>.__hx_ctor_pony_events_LV<T>(this, @value);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_events_LV<T_c>(global::pony.events.LV<T_c> __temp_me112, T_c @value)
		{
			unchecked 
			{
				#line 39 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				global::pony.events.Signal.__hx_ctor_pony_events_Signal(__temp_me112, default(object));
				{
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					if (( ! (global::haxe.lang.Runtime.eq(@value, __temp_me112.@value)) )) 
					{
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						__temp_me112.@value = @value;
						#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						{
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							__temp_me112.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{@value})) ), ((object) (__temp_me112.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
							#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							global::pony.events.LV<T_c> __temp_expr496 = __temp_me112;
						}
						
					}
					
					#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					T_c __temp_expr497 = @value;
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<T_c_c>(global::pony.events.LV me)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				return ( (( me != default(global::pony.events.LV) )) ? (me.pony_events_LV_cast<T_c_c>()) : (default(global::pony.events.LV)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				return new global::pony.events.LV<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				return new global::pony.events.LV<object>(((object) (arr[0]) ));
			}
			#line default
		}
		
		
		public virtual   object pony_events_LV_cast<T_c>()
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					return this;
				}
				
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				global::pony.events.LV<T_c> new_me = new global::pony.events.LV<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				{
					#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					object __temp_iterator199 = global::Reflect.fields(this).iterator();
					#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator199, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator199, "next", 1224901875, default(global::Array)));
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						switch (field)
						{
							default:
							{
								#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  T @value;
		
		public   T _set_value(T v)
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				if (( ! (global::haxe.lang.Runtime.eq(v, this.@value)) )) 
				{
					this.@value = v;
					{
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						this.dispatchEvent(new global::pony.events.Event(((global::Array) (new global::Array<object>(new object[]{v})) ), ((object) (this.target) ), ((global::pony.events.Event) (default(global::pony.events.Event)) )));
						#line 46 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						global::pony.events.LV<T> __temp_expr495 = this;
					}
					
				}
				
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				return v;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				switch (hash)
				{
					case 834174833:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						if (handleProperties) 
						{
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							this._set_value(global::haxe.lang.Runtime.genericCast<T>(@value));
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							return @value;
						}
						 else 
						{
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							this.@value = global::haxe.lang.Runtime.genericCast<T>(@value);
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
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
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				switch (hash)
				{
					case 834174833:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						if (handleProperties) 
						{
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							this._set_value(global::haxe.lang.Runtime.genericCast<T>(@value));
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							return @value;
						}
						 else 
						{
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							this.@value = global::haxe.lang.Runtime.genericCast<T>(@value);
							#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
							return @value;
						}
						
					}
					
					
					default:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
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
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				switch (hash)
				{
					case 1488111572:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set_value"), ((int) (1488111572) ))) );
					}
					
					
					case 834174833:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						return this.@value;
					}
					
					
					default:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
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
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				switch (hash)
				{
					case 834174833:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.@value) ))) );
					}
					
					
					default:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
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
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				switch (hash)
				{
					case 1488111572:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						return this._set_value(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					default:
					{
						#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				baseArr.push("value");
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
				{
					#line 34 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/events/LV.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.events
{
	public  interface LV : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object pony_events_LV_cast<T_c>();
		
	}
}



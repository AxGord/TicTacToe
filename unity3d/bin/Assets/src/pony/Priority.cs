
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority<T> : global::haxe.lang.HxObject, global::pony.Priority 
	{
		public    Priority(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Priority(global::Array<T> data)
		{
			unchecked 
			{
				#line 79 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::pony.Priority<object>.__hx_ctor_pony_Priority<T>(this, data);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_Priority<T_c>(global::pony.Priority<T_c> __temp_me91, global::Array<T_c> data)
		{
			unchecked 
			{
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				__temp_me91.@double = false;
				__temp_me91.clear();
				if (( data != default(global::Array<T_c>) )) 
				{
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					__temp_me91.data = data;
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<T_c_c>(global::pony.Priority me)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return ( (( me != default(global::pony.Priority) )) ? (me.pony_Priority_cast<T_c_c>()) : (default(global::pony.Priority)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return new global::pony.Priority<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return new global::pony.Priority<object>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (arr[0]) ))) ));
			}
			#line default
		}
		
		
		public virtual   object pony_Priority_cast<T_c>()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return this;
				}
				
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::pony.Priority<T_c> new_me = new global::pony.Priority<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_iterator182 = global::Reflect.fields(this).iterator();
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator182, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator182, "next", 1224901875, default(global::Array)));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						switch (field)
						{
							default:
							{
								#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  int length;
		
		public  int min;
		
		public  int max;
		
		public  T first;
		
		public  T last;
		
		public  bool empty;
		
		public  bool @double;
		
		public  global::Array<T> data;
		
		public  global::haxe.ds.IntMap<int> hash;
		
		public  global::Array<int> counters;
		
		public virtual   global::pony.Priority<T> addElement(T e, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority85 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				bool __temp_boolv412 =  ! (this.@double) ;
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				bool __temp_boolv411 = false;
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (__temp_boolv412) 
				{
					#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					{
						#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						global::Array<T> element = new global::Array<T>(new T[]{e});
						#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						__temp_boolv411 = global::Lambda.exists<T>(this.data, new global::pony.Priority_addElement_91__Fun<T>(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (element) ))) )));
					}
					
				}
				
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				bool __temp_stmt410 = ( __temp_boolv412 && __temp_boolv411 );
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (__temp_stmt410) 
				{
					#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return this;
				}
				
				int s = default(int);
				#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (this.hash.exists(__temp_priority85)) 
				{
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					s = this.hash.@get(__temp_priority85).@value;
				}
				 else 
				{
					#line 92 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					s = 0;
				}
				
				int c = 0;
				{
					#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_iterator183 = this.hash.keys();
					#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator183, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.callField(__temp_iterator183, "next", 1224901875, default(global::Array)))) );
						if (( k < __temp_priority85 )) 
						{
							#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							c += this.hash.@get(k).@value;
						}
						
					}
					
				}
				
				c += s;
				this.data.insert(c, e);
				{
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g1 = 0;
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = this.counters.length;
					#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g1 < _g ))
					{
						#line 98 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k1 = _g1++;
						if (( c < this.counters[k1] )) 
						{
							#line 99 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							this.counters[k1]++;
						}
						
					}
					
				}
				
				this.hash.@set(__temp_priority85, ( s + 1 ));
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.Priority<T> addArray(global::Array<T> a, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 109 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority86 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = 0;
					#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g < a.length ))
					{
						#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T e = a[_g];
						#line 110 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						 ++ _g;
						this.addElement(e, new global::haxe.lang.Null<int>(__temp_priority86, true));
					}
					
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   object iterator()
		{
			unchecked 
			{
				#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::Array<object> _g = new global::Array<object>(new object[]{this});
				global::Array<int> n = new global::Array<int>(new int[]{( this.counters.push(0) - 1 )});
				{
					global::haxe.lang.Function __temp_odecl413 = new global::pony.Priority_iterator_127__Fun<T>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (n) ))) ));
					#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					global::haxe.lang.Function __temp_odecl414 = new global::pony.Priority_iterator_136__Fun<T>(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (_g) ))) ), ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (n) ))) ));
					#line 126 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{407283053, 1224901875}), new global::Array<object>(new object[]{__temp_odecl413, __temp_odecl414}), new global::Array<int>(new int[]{}), new global::Array<double>(new double[]{}));
				}
				
			}
			#line default
		}
		
		
		public virtual   global::pony.Priority<T> clear()
		{
			unchecked 
			{
				#line 144 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.hash = new global::haxe.ds.IntMap<int>();
				this.data = new global::Array<T>();
				this.counters = new global::Array<int>(new int[]{0});
				return this;
			}
			#line default
		}
		
		
		public   bool existsElement(T element)
		{
			unchecked 
			{
				#line 150 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::Array<T> element1 = new global::Array<T>(new T[]{element});
				return global::Lambda.exists<T>(this.data, new global::pony.Priority_existsElement_151__Fun<T>(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (element1) ))) )));
			}
			#line default
		}
		
		
		public   bool existsFunction(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 153 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return global::Lambda.exists<T>(this.data, f);
			}
			#line default
		}
		
		
		public virtual   bool existsArray(global::Array<T> a)
		{
			unchecked 
			{
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				{
					#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = 0;
					#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g < a.length ))
					{
						#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T e = a[_g];
						#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						 ++ _g;
						#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						bool __temp_stmt415 = default(bool);
						#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						{
							#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							global::Array<T> element = new global::Array<T>(new T[]{e});
							#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							__temp_stmt415 = global::Lambda.exists<T>(this.data, new global::pony.Priority_existsArray_156__Fun<T>(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (element) ))) )));
						}
						
						#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (__temp_stmt415) 
						{
							#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return true;
						}
						
					}
					
				}
				
				return false;
			}
			#line default
		}
		
		
		public virtual   T search(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 163 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::Array<object> f1 = new global::Array<object>(new object[]{f});
				global::Array<T> s = new global::Array<T>(new T[]{default(T)});
				global::Lambda.exists<T>(this.data, new global::pony.Priority_search_165__Fun<T>(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (s) ))) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (f1) ))) )));
				#line 172 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return s[0];
			}
			#line default
		}
		
		
		public virtual   bool removeElement(T e)
		{
			unchecked 
			{
				#line 179 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int i = global::Lambda.indexOf<T>(this.data, e);
				if (( i == -1 )) 
				{
					#line 180 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return false;
				}
				
				{
					#line 181 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g1 = 0;
					#line 181 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = this.counters.length;
					#line 181 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g1 < _g ))
					{
						#line 181 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k = _g1++;
						if (( i < this.counters[k] )) 
						{
							#line 182 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							this.counters[k]--;
						}
						
					}
					
				}
				
				this.data.@remove(e);
				global::Array<int> a = new global::Array<int>(new int[]{});
				{
					#line 185 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_iterator184 = this.hash.keys();
					#line 185 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator184, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 185 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k1 = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.callField(__temp_iterator184, "next", 1224901875, default(global::Array)))) );
						a.push(k1);
					}
					
				}
				
				a.sort(( (( global::pony.Priority_removeElement_187__Fun.__hx_current != default(global::pony.Priority_removeElement_187__Fun) )) ? (global::pony.Priority_removeElement_187__Fun.__hx_current) : (global::pony.Priority_removeElement_187__Fun.__hx_current = ((global::pony.Priority_removeElement_187__Fun) (new global::pony.Priority_removeElement_187__Fun()) )) ));
				{
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g2 = 0;
					#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g2 < a.length ))
					{
						#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k2 = a[_g2];
						#line 188 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						 ++ _g2;
						if (( i > 0 )) 
						{
							i -= this.hash.@get(k2).@value;
						}
						 else 
						{
							#line 192 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							{
								#line 192 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
								int @value = ( this.hash.@get(k2).@value - 1 );
								#line 192 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
								this.hash.@set(k2, @value);
							}
							
							break;
						}
						
					}
					
				}
				
				#line 196 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (this.@double) 
				{
					#line 196 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					this.removeElement(e);
				}
				
				return true;
			}
			#line default
		}
		
		
		public virtual   bool removeFunction(global::haxe.lang.Function f)
		{
			unchecked 
			{
				#line 201 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				T e = this.search(f);
				if (( ! (global::haxe.lang.Runtime.eq(e, default(T))) )) 
				{
					#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return this.removeElement(e);
				}
				 else 
				{
					return false;
				}
				
			}
			#line default
		}
		
		
		public virtual   bool removeArray(global::Array<T> a)
		{
			unchecked 
			{
				#line 207 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				bool f = true;
				{
					#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = 0;
					#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g < a.length ))
					{
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T e = a[_g];
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						 ++ _g;
						#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if ( ! (this.removeElement(e)) ) 
						{
							#line 208 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							f = false;
						}
						
					}
					
				}
				
				return f;
			}
			#line default
		}
		
		
		public virtual   void repriority(global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 216 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority87 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				this.hash = new global::haxe.ds.IntMap<int>();
				this.hash.@set(__temp_priority87, this.data.length);
			}
			#line default
		}
		
		
		public virtual   global::pony.Priority<T> changeElement(T e, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 221 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority88 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				if (this.removeElement(e)) 
				{
					#line 222 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					this.addElement(e, new global::haxe.lang.Null<int>(__temp_priority88, true));
				}
				 else 
				{
					throw global::haxe.lang.HaxeException.wrap("Element not exists");
				}
				
				return this;
			}
			#line default
		}
		
		
		public virtual   global::pony.Priority<T> changeFunction(global::haxe.lang.Function f, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 227 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority89 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				T e = this.search(f);
				return this.changeElement(e, new global::haxe.lang.Null<int>(__temp_priority89, true));
			}
			#line default
		}
		
		
		public virtual   global::pony.Priority<T> changeArray(global::Array<T> a, global::haxe.lang.Null<int> priority)
		{
			unchecked 
			{
				#line 232 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int __temp_priority90 = ( (global::haxe.lang.Runtime.eq((priority).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (priority.@value) );
				{
					#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					int _g = 0;
					#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (( _g < a.length ))
					{
						#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T e = a[_g];
						#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						 ++ _g;
						#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.changeElement(e, new global::haxe.lang.Null<int>(__temp_priority90, true));
					}
					
				}
				
				return this;
			}
			#line default
		}
		
		
		public   string toString()
		{
			unchecked 
			{
				#line 237 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return this.data.toString();
			}
			#line default
		}
		
		
		public   T _get_first()
		{
			unchecked 
			{
				#line 239 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return this.data[0];
			}
			#line default
		}
		
		
		public   T _get_last()
		{
			unchecked 
			{
				#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return this.data[( this.data.length - 1 )];
			}
			#line default
		}
		
		
		public   int _get_length()
		{
			unchecked 
			{
				#line 243 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return this.data.length;
			}
			#line default
		}
		
		
		public   bool _get_empty()
		{
			unchecked 
			{
				#line 248 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return ( this.data.length == 0 );
			}
			#line default
		}
		
		
		public virtual   T loop()
		{
			unchecked 
			{
				#line 255 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (( this.counters[0] >= this.data.length )) 
				{
					this.counters[0] = 0;
					if (( this.data.length == 0 )) 
					{
						#line 257 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return default(T);
					}
					
				}
				
				#line 259 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return this.data[this.counters[0]++];
			}
			#line default
		}
		
		
		public   global::pony.Priority<T> resetLoop()
		{
			unchecked 
			{
				#line 266 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.counters[0] = 0;
				return this;
			}
			#line default
		}
		
		
		public   void reloop(T e)
		{
			unchecked 
			{
				#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				while (( ! (global::haxe.lang.Runtime.eq(this.loop(), e)) ))
				{
					#line 275 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_expr416 = default(object);
				}
				
			}
			#line default
		}
		
		
		public virtual   T backLoop()
		{
			unchecked 
			{
				#line 282 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (( this.data.length == 0 )) 
				{
					this.counters[0] = 0;
					return default(T);
				}
				
				#line 286 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.counters[0]--;
				if (( this.counters[0] < 1 )) 
				{
					#line 287 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					this.counters[0] = this.data.length;
				}
				
				return this.data[( this.counters[0] - 1 )];
			}
			#line default
		}
		
		
		public virtual   int _get_min()
		{
			unchecked 
			{
				#line 295 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::haxe.lang.Null<int> n = default(global::haxe.lang.Null<int>);
				{
					#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_iterator185 = this.hash.keys();
					#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator185, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.callField(__temp_iterator185, "next", 1224901875, default(global::Array)))) );
						if (( global::haxe.lang.Runtime.eq((n).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) || ( k < n.@value ) )) 
						{
							n = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(k, true).@value, true);
						}
						
					}
					
				}
				
				return n.@value;
			}
			#line default
		}
		
		
		public virtual   int _get_max()
		{
			unchecked 
			{
				#line 306 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				global::haxe.lang.Null<int> n = default(global::haxe.lang.Null<int>);
				{
					#line 307 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					object __temp_iterator186 = this.hash.keys();
					#line 307 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator186, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 307 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						int k = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.callField(__temp_iterator186, "next", 1224901875, default(global::Array)))) );
						if (( global::haxe.lang.Runtime.eq((n).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) || ( k > n.@value ) )) 
						{
							n = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(k, true).@value, true);
						}
						
					}
					
				}
				
				return n.@value;
			}
			#line default
		}
		
		
		public virtual   void addElementToBegin(T e)
		{
			unchecked 
			{
				#line 317 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.addElement(e, new global::haxe.lang.Null<int>(( this._get_min() - 1 ), true));
			}
			#line default
		}
		
		
		public virtual   void addElementToEnd(T e)
		{
			unchecked 
			{
				#line 323 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.addElement(e, new global::haxe.lang.Null<int>(( this._get_max() + 1 ), true));
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				switch (hash)
				{
					case 1202522710:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.last = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 10319920:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.first = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 5442212:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.max = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.min = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 520590566:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.length = ((int) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				switch (hash)
				{
					case 287272439:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.counters = ((global::Array<int>) (global::Array<object>.__hx_cast<int>(((global::Array) (@value) ))) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 1158164430:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.hash = ((global::haxe.ds.IntMap<int>) (global::haxe.ds.IntMap<object>.__hx_cast<int>(((global::haxe.ds.IntMap) (@value) ))) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 1113806378:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.data = ((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (@value) ))) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 852175633:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.@double = ((bool) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 1876572813:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.empty = ((bool) (@value) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 1202522710:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.last = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 10319920:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.first = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 5442212:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.max = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 5443986:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.min = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					case 520590566:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return @value;
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				switch (hash)
				{
					case 2056779909:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addElementToEnd"), ((int) (2056779909) ))) );
					}
					
					
					case 180804947:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addElementToBegin"), ((int) (180804947) ))) );
					}
					
					
					case 650629947:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_max"), ((int) (650629947) ))) );
					}
					
					
					case 650631721:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_min"), ((int) (650631721) ))) );
					}
					
					
					case 179784747:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("backLoop"), ((int) (179784747) ))) );
					}
					
					
					case 64970647:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("reloop"), ((int) (64970647) ))) );
					}
					
					
					case 228831187:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("resetLoop"), ((int) (228831187) ))) );
					}
					
					
					case 1203218020:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("loop"), ((int) (1203218020) ))) );
					}
					
					
					case 864261860:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_empty"), ((int) (864261860) ))) );
					}
					
					
					case 261031087:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_length"), ((int) (261031087) ))) );
					}
					
					
					case 1197983199:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_last"), ((int) (1197983199) ))) );
					}
					
					
					case 1145492615:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_first"), ((int) (1145492615) ))) );
					}
					
					
					case 946786476:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toString"), ((int) (946786476) ))) );
					}
					
					
					case 1263867401:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeArray"), ((int) (1263867401) ))) );
					}
					
					
					case 1838016680:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeFunction"), ((int) (1838016680) ))) );
					}
					
					
					case 1730761516:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("changeElement"), ((int) (1730761516) ))) );
					}
					
					
					case 363219479:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("repriority"), ((int) (363219479) ))) );
					}
					
					
					case 600001205:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeArray"), ((int) (600001205) ))) );
					}
					
					
					case 1588127612:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeFunction"), ((int) (1588127612) ))) );
					}
					
					
					case 1594821336:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeElement"), ((int) (1594821336) ))) );
					}
					
					
					case 1660395368:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("search"), ((int) (1660395368) ))) );
					}
					
					
					case 1020723741:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("existsArray"), ((int) (1020723741) ))) );
					}
					
					
					case 775930132:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("existsFunction"), ((int) (775930132) ))) );
					}
					
					
					case 772631616:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("existsElement"), ((int) (772631616) ))) );
					}
					
					
					case 1213952397:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("clear"), ((int) (1213952397) ))) );
					}
					
					
					case 328878574:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iterator"), ((int) (328878574) ))) );
					}
					
					
					case 518820792:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addArray"), ((int) (518820792) ))) );
					}
					
					
					case 1843321499:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addElement"), ((int) (1843321499) ))) );
					}
					
					
					case 287272439:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.counters;
					}
					
					
					case 1158164430:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.hash;
					}
					
					
					case 1113806378:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.data;
					}
					
					
					case 852175633:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.@double;
					}
					
					
					case 1876572813:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_empty();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.empty;
						}
						
					}
					
					
					case 1202522710:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_last();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.last;
						}
						
					}
					
					
					case 10319920:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_first();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.first;
						}
						
					}
					
					
					case 5442212:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_max();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.max;
						}
						
					}
					
					
					case 5443986:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_min();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.min;
						}
						
					}
					
					
					case 520590566:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this._get_length();
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return this.length;
						}
						
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				switch (hash)
				{
					case 1202522710:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T __temp_stmt417 = default(T);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (global::haxe.lang.Runtime.toDouble(this._get_last())) );
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							__temp_stmt417 = this.last;
						}
						
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (__temp_stmt417) ))) );
					}
					
					
					case 10319920:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						T __temp_stmt418 = default(T);
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (global::haxe.lang.Runtime.toDouble(this._get_first())) );
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							__temp_stmt418 = this.first;
						}
						
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (__temp_stmt418) ))) );
					}
					
					
					case 5442212:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this._get_max()) );
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this.max) );
						}
						
					}
					
					
					case 5443986:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this._get_min()) );
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this.min) );
						}
						
					}
					
					
					case 520590566:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						if (handleProperties) 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this._get_length()) );
						}
						 else 
						{
							#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
							return ((double) (this.length) );
						}
						
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
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
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				switch (hash)
				{
					case 2056779909:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.addElementToEnd(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						break;
					}
					
					
					case 180804947:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.addElementToBegin(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						break;
					}
					
					
					case 650629947:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_max();
					}
					
					
					case 650631721:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_min();
					}
					
					
					case 179784747:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.backLoop();
					}
					
					
					case 64970647:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.reloop(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						break;
					}
					
					
					case 228831187:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.resetLoop();
					}
					
					
					case 1203218020:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.loop();
					}
					
					
					case 864261860:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_empty();
					}
					
					
					case 261031087:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_length();
					}
					
					
					case 1197983199:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_last();
					}
					
					
					case 1145492615:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this._get_first();
					}
					
					
					case 946786476:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.toString();
					}
					
					
					case 1263867401:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.changeArray(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1838016680:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.changeFunction(((global::haxe.lang.Function) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1730761516:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.changeElement(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 363219479:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						this.repriority(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]));
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						break;
					}
					
					
					case 600001205:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.removeArray(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ));
					}
					
					
					case 1588127612:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.removeFunction(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 1594821336:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.removeElement(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 1660395368:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.search(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 1020723741:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.existsArray(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ));
					}
					
					
					case 775930132:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.existsFunction(((global::haxe.lang.Function) (dynargs[0]) ));
					}
					
					
					case 772631616:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.existsElement(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 1213952397:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.clear();
					}
					
					
					case 328878574:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.iterator();
					}
					
					
					case 518820792:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.addArray(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					case 1843321499:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return this.addElement(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[1]));
					}
					
					
					default:
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("counters");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("hash");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("data");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("double");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("empty");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("last");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("first");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("max");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("min");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				baseArr.push("length");
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				{
					#line 37 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_addElement_91__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_addElement_91__Fun(global::Array<T> element) : base(1, 0)
		{
			unchecked 
			{
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.element = element;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				T e1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.genericCast<T>(__fn_float1)) : (global::haxe.lang.Runtime.genericCast<T>(__fn_dyn1)) );
				#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return global::haxe.lang.Runtime.eq(e1, this.element[0]);
			}
			#line default
		}
		
		
		public  global::Array<T> element;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_iterator_127__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_iterator_127__Fun(global::Array<object> _g, global::Array<int> n) : base(0, 0)
		{
			unchecked 
			{
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this._g = _g;
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.n = n;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				if (( ((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).counters.length < this.n[0] )) 
				{
					#line 128 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).counters.push(this.n[0]);
				}
				
				if (( ! (global::haxe.lang.Runtime.eq(((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).data[((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).counters[this.n[0]]], default(T))) )) 
				{
					return true;
				}
				 else 
				{
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).counters.splice(this.n[0], 1);
					return false;
				}
				
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<int> n;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_iterator_136__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_iterator_136__Fun(global::Array<object> _g, global::Array<int> n) : base(0, 0)
		{
			unchecked 
			{
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this._g = _g;
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.n = n;
			}
			#line default
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return ((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).data[((global::pony.Priority<T>) (global::pony.Priority<object>.__hx_cast<T>(((global::pony.Priority) (this._g[0]) ))) ).counters[this.n[0]]++];
			}
			#line default
		}
		
		
		public  global::Array<object> _g;
		
		public  global::Array<int> n;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_existsElement_151__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_existsElement_151__Fun(global::Array<T> element1) : base(1, 0)
		{
			unchecked 
			{
				#line 151 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.element1 = element1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 151 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				T e = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.genericCast<T>(__fn_float1)) : (global::haxe.lang.Runtime.genericCast<T>(__fn_dyn1)) );
				#line 151 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return global::haxe.lang.Runtime.eq(e, this.element1[0]);
			}
			#line default
		}
		
		
		public  global::Array<T> element1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_existsArray_156__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_existsArray_156__Fun(global::Array<T> element) : base(1, 0)
		{
			unchecked 
			{
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.element = element;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				T e1 = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.genericCast<T>(__fn_float1)) : (global::haxe.lang.Runtime.genericCast<T>(__fn_dyn1)) );
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return global::haxe.lang.Runtime.eq(e1, this.element[0]);
			}
			#line default
		}
		
		
		public  global::Array<T> element;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_search_165__Fun<T> : global::haxe.lang.Function 
	{
		public    Priority_search_165__Fun(global::Array<T> s, global::Array<object> f1) : base(1, 0)
		{
			unchecked 
			{
				#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.s = s;
				#line 166 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				this.f1 = f1;
			}
			#line default
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				T e = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (global::haxe.lang.Runtime.genericCast<T>(__fn_float1)) : (global::haxe.lang.Runtime.genericCast<T>(__fn_dyn1)) );
				if (((bool) (((global::haxe.lang.Function) (this.f1[0]) ).__hx_invoke1_o(default(double), e)) )) 
				{
					this.s[0] = e;
					return true;
				}
				 else 
				{
					#line 170 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
					return false;
				}
				
			}
			#line default
		}
		
		
		public  global::Array<T> s;
		
		public  global::Array<object> f1;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Priority_removeElement_187__Fun : global::haxe.lang.Function 
	{
		public    Priority_removeElement_187__Fun() : base(2, 1)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public static  global::pony.Priority_removeElement_187__Fun __hx_current;
		
		public override   double __hx_invoke2_f(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				#line 187 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int y = ( (global::haxe.lang.Runtime.eq(__fn_dyn2, global::haxe.lang.Runtime.undefined)) ? (((int) (__fn_float2) )) : (((int) (global::haxe.lang.Runtime.toInt(__fn_dyn2)) )) );
				#line 187 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				int x = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((int) (__fn_float1) )) : (((int) (global::haxe.lang.Runtime.toInt(__fn_dyn1)) )) );
				#line 187 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Priority.hx"
				return ((double) (( x - y )) );
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  interface Priority : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object pony_Priority_cast<T_c>();
		
	}
}



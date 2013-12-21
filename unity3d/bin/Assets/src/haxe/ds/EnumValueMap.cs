
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class EnumValueMap<K, V> : global::haxe.ds.BalancedTree<K, V>, global::haxe.ds.EnumValueMap, global::IMap<K, V> 
	{
		public    EnumValueMap(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
			#line default
		}
		
		
		public    EnumValueMap() : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.EnumValueMap<object, object>.__hx_ctor_haxe_ds_EnumValueMap<K, V>(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_ds_EnumValueMap<K_c, V_c>(global::haxe.ds.EnumValueMap<K_c, V_c> __temp_me32)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.BalancedTree<object, object>.__hx_ctor_haxe_ds_BalancedTree<K_c, V_c>(__temp_me32);
			}
			#line default
		}
		
		
		public static  new object __hx_cast<K_c_c, V_c_c>(global::haxe.ds.EnumValueMap me)
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return ( (( me != default(global::haxe.ds.EnumValueMap) )) ? (me.haxe_ds_EnumValueMap_cast<K_c_c, V_c_c>()) : (default(global::haxe.ds.EnumValueMap)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return new global::haxe.ds.EnumValueMap<object, object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return new global::haxe.ds.EnumValueMap<object, object>();
			}
			#line default
		}
		
		
		public virtual   object haxe_ds_EnumValueMap_cast<K_c, V_c>()
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				if (( global::haxe.lang.Runtime.eq(typeof(K), typeof(K_c)) && global::haxe.lang.Runtime.eq(typeof(V), typeof(V_c)) )) 
				{
					#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					return this;
				}
				
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				global::haxe.ds.EnumValueMap<K_c, V_c> new_me = new global::haxe.ds.EnumValueMap<K_c, V_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				{
					#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					object __temp_iterator149 = global::Reflect.fields(this).iterator();
					#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator149, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator149, "next", 1224901875, default(global::Array)));
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						switch (field)
						{
							default:
							{
								#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return new_me;
			}
			#line default
		}
		
		
		public virtual   object IMap_cast<K_c, V_c>()
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return this.haxe_ds_EnumValueMap_cast<K_c, V_c>();
			}
			#line default
		}
		
		
		public virtual   object haxe_ds_BalancedTree_cast<K_c, V_c>()
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return this.haxe_ds_EnumValueMap_cast<K_c, V_c>();
			}
			#line default
		}
		
		
		public override   int compare(K __temp_k133, K __temp_k234)
		{
			unchecked 
			{
				#line 33 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				object k2 = ((object) (__temp_k234) );
				#line 33 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				object k1 = ((object) (__temp_k133) );
				int d = ( global::Type.enumIndex(k1) - global::Type.enumIndex(k2) );
				if (( d != 0 )) 
				{
					#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					return d;
				}
				
				global::Array p1 = global::Type.enumParameters(k1);
				global::Array p2 = global::Type.enumParameters(k2);
				if (( ( ((int) (global::haxe.lang.Runtime.getField_f(p1, "length", 520590566, true)) ) == 0 ) && ( ((int) (global::haxe.lang.Runtime.getField_f(p2, "length", 520590566, true)) ) == 0 ) )) 
				{
					#line 38 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					return 0;
				}
				
				return this.compareArgs(p1, p2);
			}
			#line default
		}
		
		
		public virtual   int compareArgs(global::Array a1, global::Array a2)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				int ld = ( ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(a2, "length", 520590566, true)) ) );
				if (( ld != 0 )) 
				{
					#line 44 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					return ld;
				}
				
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					int _g1 = 0;
					#line 45 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					int _g = ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) );
					#line 45 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
					while (( _g1 < _g ))
					{
						#line 45 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						int i = _g1++;
						int d = this.compareArg(a1[i], a2[i]);
						if (( d != 0 )) 
						{
							#line 47 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
							return d;
						}
						
					}
					
				}
				
				#line 49 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				return 0;
			}
			#line default
		}
		
		
		public virtual   int compareArg(object v1, object v2)
		{
			unchecked 
			{
				#line 53 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				if (( global::Reflect.isEnumValue(v1) && global::Reflect.isEnumValue(v2) )) 
				{
					return this.compare(global::haxe.lang.Runtime.genericCast<K>(v1), global::haxe.lang.Runtime.genericCast<K>(v2));
				}
				 else 
				{
					if (( ( v1 is global::Array ) && ( v2 is global::Array ) )) 
					{
						return this.compareArgs(((global::Array) (v1) ), ((global::Array) (v2) ));
					}
					 else 
					{
						#line 58 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return global::Reflect.compare<object>(v1, v2);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				switch (hash)
				{
					case 244830897:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("compareArg"), ((int) (244830897) ))) );
					}
					
					
					case 910198946:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("compareArgs"), ((int) (910198946) ))) );
					}
					
					
					case 57219237:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("compare"), ((int) (57219237) ))) );
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
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
				#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
				switch (hash)
				{
					case 57219237:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 244830897:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return this.compareArg(dynargs[0], dynargs[1]);
					}
					
					
					case 910198946:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return this.compareArgs(((global::Array) (dynargs[0]) ), ((global::Array) (dynargs[1]) ));
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/EnumValueMap.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  interface EnumValueMap : global::haxe.lang.IHxObject, global::haxe.ds.BalancedTree, global::haxe.lang.IGenericObject 
	{
		   object haxe_ds_EnumValueMap_cast<K_c, V_c>();
		
	}
}



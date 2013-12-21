
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class Tools : global::haxe.lang.HxObject 
	{
		public    Tools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Tools()
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::pony.Tools.__hx_ctor_pony_Tools(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_Tools(global::pony.Tools __temp_me103)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   bool equal(object a, object b, global::haxe.lang.Null<int> maxDepth)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				int __temp_maxDepth100 = ( (global::haxe.lang.Runtime.eq((maxDepth).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (1) )) : (maxDepth.@value) );
				if (global::haxe.lang.Runtime.eq(a, b)) 
				{
					#line 60 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return true;
				}
				
				if (( __temp_maxDepth100 == 0 )) 
				{
					#line 61 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return false;
				}
				
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::ValueType type = global::Type.@typeof(a);
				#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				switch (global::Type.enumIndex(type))
				{
					case 1:case 2:case 3:case 0:
					{
						return false;
					}
					
					
					case 5:
					{
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						try 
						{
							#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							return global::Reflect.compareMethods(a, b);
						}
						catch (global::System.Exception __temp_catchallException485)
						{
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							object __temp_catchall486 = __temp_catchallException485;
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							if (( __temp_catchall486 is global::haxe.lang.HaxeException )) 
							{
								#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								__temp_catchall486 = ((global::haxe.lang.HaxeException) (__temp_catchallException485) ).obj;
							}
							
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							{
								#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								object _ = __temp_catchall486;
								#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
						}
						
						
					}
					
					
					case 7:
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						global::System.Type t = ((global::System.Type) (type.@params[0]) );
						#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						{
							if ( ! (global::haxe.lang.Runtime.typeEq(t, global::Type.getEnum(b))) ) 
							{
								#line 74 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							if (( global::Type.enumIndex(a) != global::Type.enumIndex(b) )) 
							{
								#line 76 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							#line 78 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							global::Array a1 = global::Type.enumParameters(a);
							global::Array b1 = global::Type.enumParameters(b);
							#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							if (( ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) ) != ((int) (global::haxe.lang.Runtime.getField_f(b1, "length", 520590566, true)) ) )) 
							{
								#line 81 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							{
								#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								int _g1 = 0;
								#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								int _g = ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) );
								#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								while (( _g1 < _g ))
								{
									#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									int i = _g1++;
									if ( ! (global::pony.Tools.equal(a1[i], b1[i], new global::haxe.lang.Null<int>(( __temp_maxDepth100 - 1 ), true))) ) 
									{
										#line 83 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
										return false;
									}
									
								}
								
							}
							
							return true;
						}
						
					}
					
					
					case 4:
					{
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if (( a is global::System.Type )) 
						{
							#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							return false;
						}
						
						#line 86 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						break;
					}
					
					
					case 8:
					{
						{
						}
						
						#line 87 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						break;
					}
					
					
					case 6:
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						global::System.Type t1 = ((global::System.Type) (type.@params[0]) );
						#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if (global::haxe.lang.Runtime.refEq(t1, typeof(global::Array))) 
						{
							if ( ! (( b is global::Array )) ) 
							{
								#line 91 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							if (( ! (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.getField(a, "length", 520590566, true), global::haxe.lang.Runtime.getField(b, "length", 520590566, true))) )) 
							{
								#line 93 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							{
								#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								int _g11 = 0;
								#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								int _g2 = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.getField(a, "length", 520590566, true))) );
								#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								while (( _g11 < _g2 ))
								{
									#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									int i1 = _g11++;
									if ( ! (global::pony.Tools.equal(((object) (global::haxe.lang.Runtime.callField(a, "__get", 1915412854, new global::Array<object>(new object[]{i1}))) ), ((object) (global::haxe.lang.Runtime.callField(b, "__get", 1915412854, new global::Array<object>(new object[]{i1}))) ), new global::haxe.lang.Null<int>(( __temp_maxDepth100 - 1 ), true))) ) 
									{
										#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
										return false;
									}
									
								}
								
							}
							
							return true;
						}
						
						#line 88 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						break;
					}
					
					
				}
				
				#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					global::ValueType _g3 = global::Type.@typeof(b);
					#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					switch (global::Type.enumIndex(_g3))
					{
						case 1:case 2:case 3:case 5:case 7:case 0:
						{
							return false;
						}
						
						
						case 4:
						{
							if (( b is global::System.Type )) 
							{
								#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							#line 103 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							break;
						}
						
						
						case 6:
						{
							#line 101 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							global::System.Type t2 = ((global::System.Type) (_g3.@params[0]) );
							#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							if (global::haxe.lang.Runtime.refEq(t2, typeof(global::Array))) 
							{
								#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								return false;
							}
							
							#line 104 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							break;
						}
						
						
						case 8:
						{
							{
							}
							
							#line 105 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							break;
						}
						
						
					}
					
				}
				
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::Array<object> fields = global::Reflect.fields(a);
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( fields.length == global::Reflect.fields(b).length )) 
				{
					if (( fields.length == 0 )) 
					{
						#line 112 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return true;
					}
					
					{
						#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						int _g4 = 0;
						#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						while (( _g4 < fields.length ))
						{
							#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							string f = global::haxe.lang.Runtime.toString(fields[_g4]);
							#line 113 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							 ++ _g4;
							if ((  ! (global::Reflect.hasField(b, f))  ||  ! (global::pony.Tools.equal(global::Reflect.field(a, f), global::Reflect.field(b, f), new global::haxe.lang.Null<int>(( __temp_maxDepth100 - 1 ), true)))  )) 
							{
								return false;
							}
							
						}
						
					}
					
					return true;
				}
				
				#line 118 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return false;
			}
			#line default
		}
		
		
		public static   int superIndexOf<T>(object it, T v, global::haxe.lang.Null<int> maxDepth)
		{
			unchecked 
			{
				#line 121 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				int __temp_maxDepth101 = ( (global::haxe.lang.Runtime.eq((maxDepth).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (1) )) : (maxDepth.@value) );
				int i = 0;
				{
					#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					object __temp_iterator195 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::Array))) );
					#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator195, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 123 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						T e = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(__temp_iterator195, "next", 1224901875, default(global::Array)));
						if (global::pony.Tools.equal(e, v, new global::haxe.lang.Null<int>(__temp_maxDepth101, true))) 
						{
							#line 124 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							return i;
						}
						
						i++;
					}
					
				}
				
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return -1;
			}
			#line default
		}
		
		
		public static   int superMultyIndexOf<T>(object it, global::Array<T> av, global::haxe.lang.Null<int> maxDepth)
		{
			unchecked 
			{
				#line 130 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				int __temp_maxDepth102 = ( (global::haxe.lang.Runtime.eq((maxDepth).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (1) )) : (maxDepth.@value) );
				int i = 0;
				{
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					object __temp_iterator196 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::Array))) );
					#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator196, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 132 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						T e = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(__temp_iterator196, "next", 1224901875, default(global::Array)));
						{
							#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							int _g = 0;
							#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							while (( _g < av.length ))
							{
								#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								T v = av[_g];
								#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								 ++ _g;
								#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								if (global::pony.Tools.equal(e, v, new global::haxe.lang.Null<int>(__temp_maxDepth102, true))) 
								{
									#line 133 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									return i;
								}
								
							}
							
						}
						
						i++;
					}
					
				}
				
				#line 136 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return -1;
			}
			#line default
		}
		
		
		public static   int multyIndexOf<T>(object it, global::Array<T> av)
		{
			unchecked 
			{
				#line 140 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				int i = 0;
				{
					#line 141 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					object __temp_iterator197 = ((object) (global::haxe.lang.Runtime.callField(it, "iterator", 328878574, default(global::Array))) );
					#line 141 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator197, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 141 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						T e = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(__temp_iterator197, "next", 1224901875, default(global::Array)));
						{
							#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							int _g = 0;
							#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							while (( _g < av.length ))
							{
								#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								T v = av[_g];
								#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								 ++ _g;
								#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								if (global::haxe.lang.Runtime.eq(e, v)) 
								{
									#line 142 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									return i;
								}
								
							}
							
						}
						
						i++;
					}
					
				}
				
				#line 145 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return -1;
			}
			#line default
		}
		
		
		public static   double percentCalc(double p, double min, double max)
		{
			unchecked 
			{
				#line 148 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return ( ( (( max - min )) * p ) + min );
			}
			#line default
		}
		
		
		public static   global::haxe.io.BytesInput cut(global::haxe.io.BytesInput inp)
		{
			unchecked 
			{
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::haxe.io.BytesOutput @out = new global::haxe.io.BytesOutput();
				int cntNull = 0;
				bool flagNull = true;
				int cur = -99;
				while (true)
				{
					#line 163 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					try 
					{
						#line 163 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						cur = inp.readByte();
					}
					catch (global::System.Exception __temp_catchallException487)
					{
						#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						object __temp_catchall488 = __temp_catchallException487;
						#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if (( __temp_catchall488 is global::haxe.lang.HaxeException )) 
						{
							#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							__temp_catchall488 = ((global::haxe.lang.HaxeException) (__temp_catchallException487) ).obj;
						}
						
						#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						{
							#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							object _ = __temp_catchall488;
							#line 165 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							break;
						}
						
					}
					
					
					#line 167 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					if (( cur == 0 )) 
					{
						#line 169 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if ( ! (flagNull) ) 
						{
							flagNull = true;
						}
						
						cntNull++;
					}
					 else 
					{
						#line 175 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if (flagNull) 
						{
							while (( cntNull-- > 0 ))
							{
								@out.writeByte(0);
							}
							
						}
						
						flagNull = false;
						@out.writeByte(cur);
					}
					
				}
				
				#line 182 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				@out.close();
				return new global::haxe.io.BytesInput(((global::haxe.io.Bytes) (@out.getBytes()) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.Tools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.Tools();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class ArrayTools : global::haxe.lang.HxObject 
	{
		public    ArrayTools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    ArrayTools()
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::pony.ArrayTools.__hx_ctor_pony_ArrayTools(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_ArrayTools(global::pony.ArrayTools __temp_me104)
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   bool thereIs<T>(object a, global::Array<T> b)
		{
			unchecked 
			{
				#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
					#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					object __temp_iterator198 = ((object) (global::haxe.lang.Runtime.callField(a, "iterator", 328878574, default(global::Array))) );
					#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator198, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						global::Array<T> e = ((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (global::haxe.lang.Runtime.callField(__temp_iterator198, "next", 1224901875, default(global::Array))) ))) );
						#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						if (global::pony.Tools.equal(e, b, default(global::haxe.lang.Null<int>))) 
						{
							#line 205 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							return true;
						}
						
					}
					
				}
				
				return false;
			}
			#line default
		}
		
		
		public static   double arithmeticMean(global::Array<double> a)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				double s = ((double) (0) );
				{
					#line 211 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					int _g = 0;
					#line 211 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (( _g < a.length ))
					{
						#line 211 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						double e = a[_g];
						#line 211 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						 ++ _g;
						#line 211 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						s += e;
					}
					
				}
				
				return ( s / a.length );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.ArrayTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.ArrayTools();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class FloatTools : global::haxe.lang.HxObject 
	{
		public    FloatTools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    FloatTools()
		{
			unchecked 
			{
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::pony.FloatTools.__hx_ctor_pony_FloatTools(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_FloatTools(global::pony.FloatTools __temp_me107)
		{
			unchecked 
			{
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   string _toFixed(double v, int n, global::haxe.lang.Null<int> begin, string d, string beginS, string endS)
		{
			unchecked 
			{
				#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (string.Equals(endS, default(string))) 
				{
					#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					endS = "0";
				}
				
				#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (string.Equals(beginS, default(string))) 
				{
					#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					beginS = "0";
				}
				
				#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (string.Equals(d, default(string))) 
				{
					#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					d = ".";
				}
				
				#line 233 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				int __temp_begin105 = ( (global::haxe.lang.Runtime.eq((begin).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (begin.@value) );
				if (( __temp_begin105 != 0 )) 
				{
					string s = global::pony.FloatTools._toFixed(v, n, new global::haxe.lang.Null<int>(0, true), d, beginS, endS);
					global::Array<object> a = global::haxe.lang.StringExt.split(s, d);
					int d1 = ( __temp_begin105 - global::haxe.lang.Runtime.toString(a[0]).Length );
					return global::haxe.lang.Runtime.concat(global::pony.StringTls.repeat(beginS, d1), s);
				}
				
				#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( n == 0 )) 
				{
					#line 241 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return global::Std.@string(((int) (v) ));
				}
				
				double p = global::System.Math.Pow(((double) (10) ), ((double) (n) ));
				int __temp_stmt489 = default(int);
				#line 243 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
					#line 243 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					double x = global::System.Math.Floor(((double) (( v * p )) ));
					#line 243 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					__temp_stmt489 = ((int) (x) );
				}
				
				#line 243 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				v = ( __temp_stmt489 / p );
				string s1 = global::Std.@string(v);
				global::Array<object> a1 = global::haxe.lang.StringExt.split(s1, ".");
				if (( a1.length <= 1 )) 
				{
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(s1, d), global::pony.StringTls.repeat(endS, n));
				}
				 else 
				{
					#line 249 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(a1[0]), d), global::haxe.lang.Runtime.toString(a1[1])), global::pony.StringTls.repeat(endS, ( n - global::haxe.lang.Runtime.toString(a1[1]).Length )));
				}
				
			}
			#line default
		}
		
		
		public static   bool inRange(double v, double min, double max)
		{
			unchecked 
			{
				#line 252 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return ( ( min <= v ) && ( v <= max ) );
			}
			#line default
		}
		
		
		public static   bool approximately(double a, double b, global::haxe.lang.Null<double> range)
		{
			unchecked 
			{
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				double __temp_range106 = ( (global::haxe.lang.Runtime.eq((range).toDynamic(), (default(global::haxe.lang.Null<double>)).toDynamic())) ? (((double) (1) )) : (range.@value) );
				#line 254 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return ( ( ( b - __temp_range106 ) <= a ) && ( a <= ( b + __temp_range106 ) ) );
			}
			#line default
		}
		
		
		public static   double limit(double v, double min, double max)
		{
			unchecked 
			{
				#line 257 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( v < min )) 
				{
					#line 257 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return min;
				}
				 else 
				{
					if (( v > max )) 
					{
						#line 258 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return max;
					}
					 else 
					{
						return v;
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   double cultureAdd(double a, double b, double max)
		{
			unchecked 
			{
				#line 264 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( ( a + b ) >= max )) 
				{
					return max;
				}
				 else 
				{
					#line 267 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return ( a + b );
				}
				
			}
			#line default
		}
		
		
		public static   double cultureSub(double a, double b, double min)
		{
			unchecked 
			{
				#line 271 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( ( a - b ) <= min )) 
				{
					#line 271 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return min;
				}
				 else 
				{
					return ( a - b );
				}
				
			}
			#line default
		}
		
		
		public static   double cultureTarget(double a, double b, double step)
		{
			unchecked 
			{
				#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( a > b )) 
				{
					#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					if (( ( a - step ) <= b )) 
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return b;
					}
					 else 
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return ( a - step );
					}
					
				}
				 else 
				{
					#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					if (( ( a + step ) >= b )) 
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return b;
					}
					 else 
					{
						#line 276 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						return ( a + step );
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   double midValue(double a, double b, double aCount, double bCount)
		{
			unchecked 
			{
				#line 280 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return ( (( ( aCount * a ) + ( bCount * b ) )) / (( aCount + bCount )) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.FloatTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 217 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.FloatTools();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class StringTls : global::haxe.lang.HxObject 
	{
		public    StringTls(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    StringTls()
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::pony.StringTls.__hx_ctor_pony_StringTls(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_StringTls(global::pony.StringTls __temp_me108)
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   string repeat(string s, int count)
		{
			unchecked 
			{
				#line 287 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				string r = "";
				while (( count-- > 0 ))
				{
					#line 288 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					r = global::haxe.lang.Runtime.concat(r, s);
				}
				
				return r;
			}
			#line default
		}
		
		
		public static   bool isTrue(string s)
		{
			unchecked 
			{
				#line 292 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				string __temp_stmt490 = default(string);
				#line 292 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
					#line 292 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					string s1 = s.ToLower();
					#line 292 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					__temp_stmt490 = s1.Trim();
				}
				
				#line 292 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return string.Equals(__temp_stmt490, "true");
			}
			#line default
		}
		
		
		public static   global::Array<object> explode(string s, global::Array<object> delimiters)
		{
			unchecked 
			{
				#line 295 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::Array<object> r = new global::Array<object>(new object[]{s});
				{
					#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					int _g = 0;
					#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					while (( _g < delimiters.length ))
					{
						#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						string d = global::haxe.lang.Runtime.toString(delimiters[_g]);
						#line 296 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						 ++ _g;
						global::Array<object> sr = new global::Array<object>(new object[]{});
						{
							#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							int _g1 = 0;
							#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							while (( _g1 < r.length ))
							{
								#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								string e = global::haxe.lang.Runtime.toString(r[_g1]);
								#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								 ++ _g1;
								#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								int _g2 = 0;
								#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								global::Array<object> _g3 = global::haxe.lang.StringExt.split(e, d);
								#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
								while (( _g2 < _g3.length ))
								{
									#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									string se = global::haxe.lang.Runtime.toString(_g3[_g2]);
									#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									 ++ _g2;
									#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
									if ( ! (string.Equals(se, "")) ) 
									{
										#line 298 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
										sr.push(se);
									}
									
								}
								
							}
							
						}
						
						r = sr;
					}
					
				}
				
				#line 301 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return r;
			}
			#line default
		}
		
		
		public static   double parsePercent(string s)
		{
			unchecked 
			{
				#line 311 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (( global::haxe.lang.StringExt.indexOf(s, "%", default(global::haxe.lang.Null<int>)) != -1 )) 
				{
					return ( global::Std.parseFloat(global::haxe.lang.StringExt.substr(s, 0, new global::haxe.lang.Null<int>(( s.Length - 1 ), true))) / 100 );
				}
				 else 
				{
					#line 314 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					return global::Std.parseFloat(s);
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.StringTls(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 284 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.StringTls();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony
{
	public  class XmlTools : global::haxe.lang.HxObject 
	{
		public    XmlTools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 318 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    XmlTools()
		{
			unchecked 
			{
				#line 318 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				global::pony.XmlTools.__hx_ctor_pony_XmlTools(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_XmlTools(global::pony.XmlTools __temp_me109)
		{
			unchecked 
			{
				#line 318 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   bool isTrue(global::haxe.xml.Fast x, string name)
		{
			unchecked 
			{
				#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				bool __temp_boolv493 = x.has.resolve(name);
				#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				bool __temp_boolv492 = false;
				#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				if (__temp_boolv493) 
				{
					#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
					{
						#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						string s = x.att.resolve(name);
						#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						string __temp_stmt494 = default(string);
						#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						{
							#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							string s1 = s.ToLower();
							#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
							__temp_stmt494 = s1.Trim();
						}
						
						#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
						__temp_boolv492 = string.Equals(__temp_stmt494, "true");
					}
					
				}
				
				#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				bool __temp_stmt491 = ( __temp_boolv493 && __temp_boolv492 );
				#line 319 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return __temp_stmt491;
			}
			#line default
		}
		
		
		public static   global::haxe.xml.Fast fast(string text)
		{
			unchecked 
			{
				#line 320 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::haxe.xml.Fast(((global::Xml) (global::Xml.parse(text)) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 318 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.XmlTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 318 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/Tools.hx"
				return new global::pony.XmlTools();
			}
			#line default
		}
		
		
	}
}



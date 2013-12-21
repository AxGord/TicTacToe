
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class ComponentMethods : global::haxe.lang.HxObject 
	{
		public    ComponentMethods(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    ComponentMethods()
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.ComponentMethods.__hx_ctor_hugs_ComponentMethods(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_ComponentMethods(global::hugs.ComponentMethods __temp_me59)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   T getTypedComponent<T>(global::UnityEngine.Component c, global::System.Type type)
		{
			unchecked 
			{
				#line 16 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::haxe.lang.Runtime.genericCast<T>(((object) (c.GetComponent(((global::System.Type) (type) ))) ));
			}
			#line default
		}
		
		
		public static   T getComponentInChildrenOfType<T>(global::UnityEngine.Component c, global::System.Type type)
		{
			unchecked 
			{
				#line 20 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::haxe.lang.Runtime.genericCast<T>(((object) (c.GetComponentInChildren(((global::System.Type) (type) ))) ));
			}
			#line default
		}
		
		
		public static   global::hugs.NativeArrayIterator<T> getComponentsInChildrenOfType<T>(global::UnityEngine.Component c, global::System.Type type, global::haxe.lang.Null<bool> includeInactive)
		{
			unchecked 
			{
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				bool __temp_includeInactive58 = ( (global::haxe.lang.Runtime.eq((includeInactive).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (includeInactive.@value) );
				#line 24 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ((global::hugs.NativeArrayIterator<T>) (global::hugs.NativeArrayIterator<object>.__hx_cast<T>(((global::hugs.NativeArrayIterator) (new global::hugs.NativeArrayIterator<object>(((object[]) (c.GetComponentsInChildren(((global::System.Type) (type) ), ((bool) (__temp_includeInactive58) ))) ))) ))) );
			}
			#line default
		}
		
		
		public static   T getOrAddTypedComponent<T>(global::UnityEngine.Component c, global::System.Type type)
		{
			unchecked 
			{
				#line 28 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::hugs.GameObjectMethods.getOrAddTypedComponent<T>(c.gameObject, type);
			}
			#line default
		}
		
		
		public static   global::UnityEngine.GameObject getChildGameObject(global::UnityEngine.Component c, string name)
		{
			unchecked 
			{
				#line 31 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::hugs.GameObjectMethods.getChildGameObject(c.gameObject, name);
			}
			#line default
		}
		
		
		public static   T getParentTypedComponent<T>(global::UnityEngine.Component c, global::System.Type type)
		{
			unchecked 
			{
				#line 34 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::hugs.GameObjectMethods.getParentTypedComponent<T>(c.gameObject, type);
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.ComponentMethods(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 13 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.ComponentMethods();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class EnumeratorMethods : global::haxe.lang.HxObject 
	{
		public    EnumeratorMethods(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    EnumeratorMethods()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.EnumeratorMethods.__hx_ctor_hugs_EnumeratorMethods(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_EnumeratorMethods(global::hugs.EnumeratorMethods __temp_me60)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   object iterator(global::System.Collections.IEnumerable enumerable)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorAdapter<object>(((global::System.Collections.IEnumerator) (enumerable.GetEnumerator()) ));
			}
			#line default
		}
		
		
		public static   object iteratorT<T>(global::System.Collections.IEnumerable enumerable, global::System.Type type)
		{
			unchecked 
			{
				#line 44 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorAdapter<T>(((global::System.Collections.IEnumerator) (enumerable.GetEnumerator()) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorMethods(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 37 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorMethods();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class GameObjectMethods : global::haxe.lang.HxObject 
	{
		public    GameObjectMethods(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    GameObjectMethods()
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.GameObjectMethods.__hx_ctor_hugs_GameObjectMethods(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_GameObjectMethods(global::hugs.GameObjectMethods __temp_me62)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   T getTypedComponent<T>(global::UnityEngine.GameObject g, global::System.Type type)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::haxe.lang.Runtime.genericCast<T>(((object) (g.GetComponent(((global::System.Type) (type) ))) ));
			}
			#line default
		}
		
		
		public static   T addTypedComponent<T>(global::UnityEngine.GameObject g, global::System.Type type)
		{
			unchecked 
			{
				#line 55 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return global::haxe.lang.Runtime.genericCast<T>(((object) (g.AddComponent(((global::System.Type) (type) ))) ));
			}
			#line default
		}
		
		
		public static   global::hugs.NativeArrayIterator<T> getComponentsOfType<T>(global::UnityEngine.GameObject g, global::System.Type type)
		{
			unchecked 
			{
				#line 59 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ((global::hugs.NativeArrayIterator<T>) (global::hugs.NativeArrayIterator<object>.__hx_cast<T>(((global::hugs.NativeArrayIterator) (new global::hugs.NativeArrayIterator<object>(((object[]) (g.GetComponents(((global::System.Type) (type) ))) ))) ))) );
			}
			#line default
		}
		
		
		public static   global::hugs.NativeArrayIterator<T> getComponentsInChildrenOfType<T>(global::UnityEngine.GameObject g, global::System.Type type, global::haxe.lang.Null<bool> includeInactive)
		{
			unchecked 
			{
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				bool __temp_includeInactive61 = ( (global::haxe.lang.Runtime.eq((includeInactive).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (includeInactive.@value) );
				#line 63 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ((global::hugs.NativeArrayIterator<T>) (global::hugs.NativeArrayIterator<object>.__hx_cast<T>(((global::hugs.NativeArrayIterator) (new global::hugs.NativeArrayIterator<object>(((object[]) (g.GetComponentsInChildren(((global::System.Type) (type) ), ((bool) (__temp_includeInactive61) ))) ))) ))) );
			}
			#line default
		}
		
		
		public static   T getOrAddTypedComponent<T>(global::UnityEngine.GameObject c, global::System.Type type)
		{
			unchecked 
			{
				#line 67 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				T o = global::hugs.GameObjectMethods.getTypedComponent<T>(c, type);
				if (global::haxe.lang.Runtime.eq(o, default(T))) 
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					return global::hugs.GameObjectMethods.addTypedComponent<T>(c.gameObject, type);
				}
				 else 
				{
					#line 68 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					return o;
				}
				
			}
			#line default
		}
		
		
		public static   global::UnityEngine.GameObject getChildGameObject(global::UnityEngine.GameObject gameObject, string name)
		{
			unchecked 
			{
				#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					global::hugs.NativeArrayIterator<object> __temp_iterator152 = global::hugs.GameObjectMethods.getComponentsInChildrenOfType<object>(gameObject, typeof(global::UnityEngine.Transform), default(global::haxe.lang.Null<bool>));
					#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					while (__temp_iterator152.hasNext())
					{
						#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						global::UnityEngine.Transform t = ((global::UnityEngine.Transform) (__temp_iterator152.next()) );
						#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						if (string.Equals(t.gameObject.name, name)) 
						{
							#line 72 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
							return t.gameObject;
						}
						
					}
					
				}
				
				return default(global::UnityEngine.GameObject);
			}
			#line default
		}
		
		
		public static   T getParentTypedComponent<T>(global::UnityEngine.GameObject gameObject, global::System.Type type)
		{
			unchecked 
			{
				#line 77 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::UnityEngine.GameObject cur = gameObject;
				global::UnityEngine.Transform t = default(global::UnityEngine.Transform);
				while (( (t = cur.transform.parent) != default(global::UnityEngine.Transform) ))
				{
					cur = t.gameObject;
					T c = global::hugs.GameObjectMethods.getTypedComponent<T>(cur, type);
					if (( ! (global::haxe.lang.Runtime.eq(c, default(T))) )) 
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return c;
					}
					
				}
				
				#line 84 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return default(T);
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.GameObjectMethods(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 48 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.GameObjectMethods();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class QuaternionMethods : global::haxe.lang.HxObject 
	{
		public    QuaternionMethods(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    QuaternionMethods()
		{
			unchecked 
			{
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.QuaternionMethods.__hx_ctor_hugs_QuaternionMethods(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_QuaternionMethods(global::hugs.QuaternionMethods __temp_me63)
		{
			unchecked 
			{
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 mulVector3(global::UnityEngine.Quaternion a, global::UnityEngine.Vector3 b)
		{
			unchecked 
			{
				#line 92 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a*b;
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Quaternion mul(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b)
		{
			unchecked 
			{
				#line 96 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a*b;
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 rotatePoint(global::UnityEngine.Quaternion a, global::UnityEngine.Vector3 b)
		{
			unchecked 
			{
				#line 100 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a*b;
			}
			#line default
		}
		
		
		public static   bool eq(global::UnityEngine.Quaternion a, global::UnityEngine.Quaternion b)
		{
			unchecked 
			{
				#line 104 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a==b;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.QuaternionMethods(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 89 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.QuaternionMethods();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class Vector3Methods : global::haxe.lang.HxObject 
	{
		public    Vector3Methods(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Vector3Methods()
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.Vector3Methods.__hx_ctor_hugs_Vector3Methods(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_Vector3Methods(global::hugs.Vector3Methods __temp_me64)
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 @add(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			unchecked 
			{
				#line 111 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a+b;
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 sub(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			unchecked 
			{
				#line 115 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a-b;
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 mul(global::UnityEngine.Vector3 a, float b)
		{
			unchecked 
			{
				#line 119 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return b*a;
			}
			#line default
		}
		
		
		public static   global::UnityEngine.Vector3 div(global::UnityEngine.Vector3 a, float b)
		{
			unchecked 
			{
				#line 123 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a/b;
			}
			#line default
		}
		
		
		public static   bool eq(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			unchecked 
			{
				#line 127 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return a==b;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.Vector3Methods(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 108 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.Vector3Methods();
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class EnumeratorAdapter<T> : global::haxe.lang.HxObject, global::hugs.EnumeratorAdapter 
	{
		public    EnumeratorAdapter(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    EnumeratorAdapter(global::System.Collections.IEnumerator enumerator)
		{
			unchecked 
			{
				#line 137 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.EnumeratorAdapter<object>.__hx_ctor_hugs_EnumeratorAdapter<T>(this, enumerator);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_EnumeratorAdapter<T_c>(global::hugs.EnumeratorAdapter<T_c> __temp_me65, global::System.Collections.IEnumerator enumerator)
		{
			unchecked 
			{
				#line 138 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				__temp_me65.enumerator = enumerator;
			}
			#line default
		}
		
		
		public static   object __hx_cast<T_c_c>(global::hugs.EnumeratorAdapter me)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ( (( me != default(global::hugs.EnumeratorAdapter) )) ? (me.hugs_EnumeratorAdapter_cast<T_c_c>()) : (default(global::hugs.EnumeratorAdapter)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorAdapter<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.EnumeratorAdapter<object>(((global::System.Collections.IEnumerator) (arr[0]) ));
			}
			#line default
		}
		
		
		public virtual   object hugs_EnumeratorAdapter_cast<T_c>()
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					return this;
				}
				
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.EnumeratorAdapter<T_c> new_me = new global::hugs.EnumeratorAdapter<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					object __temp_iterator153 = global::Reflect.fields(this).iterator();
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator153, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator153, "next", 1224901875, default(global::Array)));
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						switch (field)
						{
							default:
							{
								#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  global::System.Collections.IEnumerator enumerator;
		
		public virtual   T next()
		{
			unchecked 
			{
				#line 143 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return (T)this.enumerator.Current;
			}
			#line default
		}
		
		
		public virtual   bool hasNext()
		{
			unchecked 
			{
				#line 147 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return this.enumerator.MoveNext();
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 536726916:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						this.enumerator = ((global::System.Collections.IEnumerator) (@value) );
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 407283053:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("hasNext"), ((int) (407283053) ))) );
					}
					
					
					case 1224901875:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("next"), ((int) (1224901875) ))) );
					}
					
					
					case 536726916:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.enumerator;
					}
					
					
					default:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 407283053:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.hasNext();
					}
					
					
					case 1224901875:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.next();
					}
					
					
					default:
					{
						#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				baseArr.push("enumerator");
				#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
					#line 134 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  interface EnumeratorAdapter : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object hugs_EnumeratorAdapter_cast<T_c>();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  class NativeArrayIterator<T> : global::haxe.lang.HxObject, global::hugs.NativeArrayIterator 
	{
		public    NativeArrayIterator(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    NativeArrayIterator(T[] ar)
		{
			unchecked 
			{
				#line 156 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.NativeArrayIterator<object>.__hx_ctor_hugs_NativeArrayIterator<T>(this, ar);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_hugs_NativeArrayIterator<T_c>(global::hugs.NativeArrayIterator<T_c> __temp_me69, T_c[] ar)
		{
			unchecked 
			{
				#line 157 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				__temp_me69.array = ar;
				__temp_me69.i = 0;
			}
			#line default
		}
		
		
		public static   object __hx_cast<T_c_c>(global::hugs.NativeArrayIterator me)
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ( (( me != default(global::hugs.NativeArrayIterator) )) ? (me.hugs_NativeArrayIterator_cast<T_c_c>()) : (default(global::hugs.NativeArrayIterator)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.NativeArrayIterator<object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::hugs.NativeArrayIterator<object>(((object[]) (arr[0]) ));
			}
			#line default
		}
		
		
		public virtual   object hugs_NativeArrayIterator_cast<T_c>()
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) 
				{
					#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					return this;
				}
				
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::hugs.NativeArrayIterator<T_c> new_me = new global::hugs.NativeArrayIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
					#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					object __temp_iterator154 = global::Reflect.fields(this).iterator();
					#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator154, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator154, "next", 1224901875, default(global::Array)));
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						switch (field)
						{
							case "array":
							{
								#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								{
									#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
									T_c[] __temp_new_arr66 = new T_c[((int) (this.array.Length) )];
									#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
									int __temp_i67 = -1;
									#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
									while ((  ++ __temp_i67 < this.array.Length ))
									{
										#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
										object __temp_obj68 = ((object) (this.array[__temp_i67]) );
										#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
										if ( ! (global::haxe.lang.Runtime.eq(__temp_obj68, default(T[]))) ) 
										{
											#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
											__temp_new_arr66[__temp_i67] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj68);
										}
										
									}
									
									#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
									new_me.array = __temp_new_arr66;
								}
								
								#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								break;
							}
							
							
							default:
							{
								#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  T[] array;
		
		public  int i;
		
		public virtual   T next()
		{
			unchecked 
			{
				#line 161 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return this.array[this.i++];
			}
			#line default
		}
		
		
		public virtual   bool hasNext()
		{
			unchecked 
			{
				#line 163 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return ( this.i < ( this.array as global::System.Array ).Length );
			}
			#line default
		}
		
		
		public   void reset()
		{
			unchecked 
			{
				#line 165 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				this.i = 0;
			}
			#line default
		}
		
		
		public   global::IntIterator keys()
		{
			unchecked 
			{
				#line 167 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return new global::IntIterator(((int) (0) ), ((int) (( this.array as global::System.Array ).Length) ));
			}
			#line default
		}
		
		
		public virtual   global::Array<T> haxeArray()
		{
			unchecked 
			{
				#line 170 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				global::Array<T> a = new global::Array<T>(new T[]{});
				{
					#line 171 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					global::hugs.NativeArrayIterator<T> __temp_iterator155 = this;
					#line 171 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					while (__temp_iterator155.hasNext())
					{
						#line 171 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						T e = __temp_iterator155.next();
						#line 171 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						a.push(e);
					}
					
				}
				
				return a;
			}
			#line default
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 105:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						this.i = ((int) (@value) );
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 105:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return @value;
					}
					
					
					case 630156697:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						this.array = ((T[]) (@value) );
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return @value;
					}
					
					
					default:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 1997004691:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("haxeArray"), ((int) (1997004691) ))) );
					}
					
					
					case 1191633396:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("keys"), ((int) (1191633396) ))) );
					}
					
					
					case 1724402127:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("reset"), ((int) (1724402127) ))) );
					}
					
					
					case 407283053:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("hasNext"), ((int) (407283053) ))) );
					}
					
					
					case 1224901875:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("next"), ((int) (1224901875) ))) );
					}
					
					
					case 105:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.i;
					}
					
					
					case 630156697:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.array;
					}
					
					
					default:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 105:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return ((double) (this.i) );
					}
					
					
					default:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
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
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				switch (hash)
				{
					case 1997004691:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.haxeArray();
					}
					
					
					case 1191633396:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.keys();
					}
					
					
					case 1724402127:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						this.reset();
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						break;
					}
					
					
					case 407283053:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.hasNext();
					}
					
					
					case 1224901875:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return this.next();
					}
					
					
					default:
					{
						#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				baseArr.push("i");
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				baseArr.push("array");
				#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
				{
					#line 152 "C:\\HaxeToolkit\\haxe\\lib\\HUGS/0,1,4/hugs/HUGSWrapper.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace hugs
{
	public  interface NativeArrayIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object hugs_NativeArrayIterator_cast<T_c>();
		
	}
}



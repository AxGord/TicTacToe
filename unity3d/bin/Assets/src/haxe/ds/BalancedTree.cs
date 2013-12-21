
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class BalancedTree<K, V> : global::haxe.lang.HxObject, global::haxe.ds.BalancedTree 
	{
		public    BalancedTree(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    BalancedTree()
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.BalancedTree<object, object>.__hx_ctor_haxe_ds_BalancedTree<K, V>(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_ds_BalancedTree<K_c, V_c>(global::haxe.ds.BalancedTree<K_c, V_c> __temp_me29)
		{
			unchecked 
			{
				#line 41 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<K_c_c, V_c_c>(global::haxe.ds.BalancedTree me)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return ( (( me != default(global::haxe.ds.BalancedTree) )) ? (me.haxe_ds_BalancedTree_cast<K_c_c, V_c_c>()) : (default(global::haxe.ds.BalancedTree)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new global::haxe.ds.BalancedTree<object, object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new global::haxe.ds.BalancedTree<object, object>();
			}
			#line default
		}
		
		
		public virtual   object haxe_ds_BalancedTree_cast<K_c, V_c>()
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( global::haxe.lang.Runtime.eq(typeof(K), typeof(K_c)) && global::haxe.lang.Runtime.eq(typeof(V), typeof(V_c)) )) 
				{
					#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					return this;
				}
				
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.BalancedTree<K_c, V_c> new_me = new global::haxe.ds.BalancedTree<K_c, V_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
					#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					object __temp_iterator147 = global::Reflect.fields(this).iterator();
					#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator147, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator147, "next", 1224901875, default(global::Array)));
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						switch (field)
						{
							default:
							{
								#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  global::haxe.ds.TreeNode<K, V> root;
		
		public virtual   void @set(K key, V @value)
		{
			unchecked 
			{
				#line 51 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				this.root = this.setLoop(key, @value, this.root);
			}
			#line default
		}
		
		
		public virtual   global::haxe.lang.Null<V> @get(K key)
		{
			unchecked 
			{
				#line 62 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.TreeNode<K, V> node = this.root;
				while (( node != default(global::haxe.ds.TreeNode<K, V>) ))
				{
					int c = this.compare(key, node.key);
					if (( c == 0 )) 
					{
						#line 65 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return new global::haxe.lang.Null<V>(node.@value, true);
					}
					
					if (( c < 0 )) 
					{
						#line 66 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						node = node.left;
					}
					 else 
					{
						node = node.right;
					}
					
				}
				
				#line 69 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return default(global::haxe.lang.Null<V>);
			}
			#line default
		}
		
		
		public virtual   object iterator()
		{
			unchecked 
			{
				#line 116 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::Array<V> ret = new global::Array<V>(new V[]{});
				this.iteratorLoop(this.root, ret);
				return ret.iterator();
			}
			#line default
		}
		
		
		public virtual   global::haxe.ds.TreeNode<K, V> setLoop(K k, V v, global::haxe.ds.TreeNode<K, V> node)
		{
			unchecked 
			{
				#line 133 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( node == default(global::haxe.ds.TreeNode<K, V>) )) 
				{
					#line 133 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (default(global::haxe.ds.TreeNode<K, V>)) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (default(global::haxe.ds.TreeNode<K, V>)) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				}
				
				int c = this.compare(k, node.key);
				if (( c == 0 )) 
				{
					#line 135 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (node.left) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (node.right) ))) ), new global::haxe.lang.Null<int>(( (( node == default(global::haxe.ds.TreeNode<K, V>) )) ? (0) : (node._height) ), true));
				}
				 else 
				{
					if (( c < 0 )) 
					{
						global::haxe.ds.TreeNode<K, V> nl = this.setLoop(k, v, node.left);
						return this.balance(nl, node.key, node.@value, node.right);
					}
					 else 
					{
						#line 140 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K, V> nr = this.setLoop(k, v, node.right);
						return this.balance(node.left, node.key, node.@value, nr);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void iteratorLoop(global::haxe.ds.TreeNode<K, V> node, global::Array<V> acc)
		{
			unchecked 
			{
				#line 154 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( node != default(global::haxe.ds.TreeNode<K, V>) )) 
				{
					this.iteratorLoop(node.left, acc);
					acc.push(node.@value);
					this.iteratorLoop(node.right, acc);
				}
				
			}
			#line default
		}
		
		
		public virtual   global::haxe.ds.TreeNode<K, V> balance(global::haxe.ds.TreeNode<K, V> l, K k, V v, global::haxe.ds.TreeNode<K, V> r)
		{
			unchecked 
			{
				#line 188 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				int hl = default(int);
				#line 188 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( l == default(global::haxe.ds.TreeNode<K, V>) )) 
				{
					#line 188 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					hl = 0;
				}
				 else 
				{
					#line 188 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					hl = l._height;
				}
				
				int hr = default(int);
				#line 189 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( r == default(global::haxe.ds.TreeNode<K, V>) )) 
				{
					#line 189 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					hr = 0;
				}
				 else 
				{
					#line 189 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					hr = r._height;
				}
				
				if (( hl > ( hr + 2 ) )) 
				{
					int __temp_stmt299 = default(int);
					#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					{
						#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K, V> _this = l.left;
						#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt299 = ( (( _this == default(global::haxe.ds.TreeNode<K, V>) )) ? (0) : (_this._height) );
					}
					
					#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					int __temp_stmt300 = default(int);
					#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					{
						#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K, V> _this1 = l.right;
						#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt300 = ( (( _this1 == default(global::haxe.ds.TreeNode<K, V>) )) ? (0) : (_this1._height) );
					}
					
					#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					if (( __temp_stmt299 >= __temp_stmt300 )) 
					{
						#line 191 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l.left) ))) ), global::haxe.lang.Runtime.genericCast<K>(l.key), global::haxe.lang.Runtime.genericCast<V>(l.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l.right) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					 else 
					{
						return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l.left) ))) ), global::haxe.lang.Runtime.genericCast<K>(l.key), global::haxe.lang.Runtime.genericCast<V>(l.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l.right.left) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), global::haxe.lang.Runtime.genericCast<K>(l.right.key), global::haxe.lang.Runtime.genericCast<V>(l.right.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l.right.right) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					
				}
				 else 
				{
					if (( hr > ( hl + 2 ) )) 
					{
						int __temp_stmt297 = default(int);
						#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						{
							#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
							global::haxe.ds.TreeNode<K, V> _this2 = r.right;
							#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
							__temp_stmt297 = ( (( _this2 == default(global::haxe.ds.TreeNode<K, V>) )) ? (0) : (_this2._height) );
						}
						
						#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						int __temp_stmt298 = default(int);
						#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						{
							#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
							global::haxe.ds.TreeNode<K, V> _this3 = r.left;
							#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
							__temp_stmt298 = ( (( _this3 == default(global::haxe.ds.TreeNode<K, V>) )) ? (0) : (_this3._height) );
						}
						
						#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						if (( __temp_stmt297 > __temp_stmt298 )) 
						{
							#line 194 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
							return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r.left) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), global::haxe.lang.Runtime.genericCast<K>(r.key), global::haxe.lang.Runtime.genericCast<V>(r.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r.right) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
						}
						 else 
						{
							return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r.left.left) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), global::haxe.lang.Runtime.genericCast<K>(r.left.key), global::haxe.lang.Runtime.genericCast<V>(r.left.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r.left.right) ))) ), global::haxe.lang.Runtime.genericCast<K>(r.key), global::haxe.lang.Runtime.genericCast<V>(r.@value), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r.right) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ))) ))) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
						}
						
					}
					 else 
					{
						#line 197 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return new global::haxe.ds.TreeNode<K, V>(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (l) ))) ), global::haxe.lang.Runtime.genericCast<K>(k), global::haxe.lang.Runtime.genericCast<V>(v), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (r) ))) ), new global::haxe.lang.Null<int>(( (( (( hl > hr )) ? (hl) : (hr) )) + 1 ), true));
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   int compare(K k1, K k2)
		{
			unchecked 
			{
				#line 202 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return global::Reflect.compare<K>(k1, k2);
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 1269755426:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.root = ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (@value) ))) );
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					default:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
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
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 57219237:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("compare"), ((int) (57219237) ))) );
					}
					
					
					case 596483356:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("balance"), ((int) (596483356) ))) );
					}
					
					
					case 1692511090:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iteratorLoop"), ((int) (1692511090) ))) );
					}
					
					
					case 222029606:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setLoop"), ((int) (222029606) ))) );
					}
					
					
					case 328878574:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("iterator"), ((int) (328878574) ))) );
					}
					
					
					case 5144726:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get"), ((int) (5144726) ))) );
					}
					
					
					case 5741474:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("set"), ((int) (5741474) ))) );
					}
					
					
					case 1269755426:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.root;
					}
					
					
					default:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
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
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 57219237:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.compare(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]), global::haxe.lang.Runtime.genericCast<K>(dynargs[1]));
					}
					
					
					case 596483356:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.balance(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (dynargs[0]) ))) ), global::haxe.lang.Runtime.genericCast<K>(dynargs[1]), global::haxe.lang.Runtime.genericCast<V>(dynargs[2]), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (dynargs[3]) ))) ));
					}
					
					
					case 1692511090:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.iteratorLoop(((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (dynargs[0]) ))) ), ((global::Array<V>) (global::Array<object>.__hx_cast<V>(((global::Array) (dynargs[1]) ))) ));
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						break;
					}
					
					
					case 222029606:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.setLoop(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]), global::haxe.lang.Runtime.genericCast<V>(dynargs[1]), ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (dynargs[2]) ))) ));
					}
					
					
					case 328878574:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.iterator();
					}
					
					
					case 5144726:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return (this.@get(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]))).toDynamic();
					}
					
					
					case 5741474:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.@set(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]), global::haxe.lang.Runtime.genericCast<V>(dynargs[1]));
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						break;
					}
					
					
					default:
					{
						#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("root");
				#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
					#line 35 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  interface BalancedTree : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object haxe_ds_BalancedTree_cast<K_c, V_c>();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  class TreeNode<K, V> : global::haxe.lang.HxObject, global::haxe.ds.TreeNode 
	{
		public    TreeNode(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    TreeNode(global::haxe.ds.TreeNode<K, V> l, K k, V v, global::haxe.ds.TreeNode<K, V> r, global::haxe.lang.Null<int> h)
		{
			unchecked 
			{
				#line 220 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.TreeNode<object, object>.__hx_ctor_haxe_ds_TreeNode<K, V>(this, l, k, v, r, h);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_ds_TreeNode<K_c, V_c>(global::haxe.ds.TreeNode<K_c, V_c> __temp_me31, global::haxe.ds.TreeNode<K_c, V_c> l, K_c k, V_c v, global::haxe.ds.TreeNode<K_c, V_c> r, global::haxe.lang.Null<int> h)
		{
			unchecked 
			{
				#line 220 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				int __temp_h30 = ( (global::haxe.lang.Runtime.eq((h).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (-1) )) : (h.@value) );
				__temp_me31.left = l;
				__temp_me31.key = k;
				__temp_me31.@value = v;
				__temp_me31.right = r;
				if (( __temp_h30 == -1 )) 
				{
					int __temp_stmt301 = default(int);
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					int __temp_stmt302 = default(int);
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					{
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K_c, V_c> _this = __temp_me31.left;
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt302 = ( (( _this == default(global::haxe.ds.TreeNode<K_c, V_c>) )) ? (0) : (_this._height) );
					}
					
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					int __temp_stmt303 = default(int);
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					{
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K_c, V_c> _this1 = __temp_me31.right;
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt303 = ( (( _this1 == default(global::haxe.ds.TreeNode<K_c, V_c>) )) ? (0) : (_this1._height) );
					}
					
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					if (( __temp_stmt302 > __temp_stmt303 )) 
					{
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K_c, V_c> _this2 = __temp_me31.left;
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt301 = ( (( _this2 == default(global::haxe.ds.TreeNode<K_c, V_c>) )) ? (0) : (_this2._height) );
					}
					 else 
					{
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						global::haxe.ds.TreeNode<K_c, V_c> _this3 = __temp_me31.right;
						#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						__temp_stmt301 = ( (( _this3 == default(global::haxe.ds.TreeNode<K_c, V_c>) )) ? (0) : (_this3._height) );
					}
					
					#line 226 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					__temp_me31._height = ( __temp_stmt301 + 1 );
				}
				 else 
				{
					#line 228 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					__temp_me31._height = __temp_h30;
				}
				
			}
			#line default
		}
		
		
		public static   object __hx_cast<K_c_c, V_c_c>(global::haxe.ds.TreeNode me)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return ( (( me != default(global::haxe.ds.TreeNode) )) ? (me.haxe_ds_TreeNode_cast<K_c_c, V_c_c>()) : (default(global::haxe.ds.TreeNode)) );
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new global::haxe.ds.TreeNode<object, object>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new global::haxe.ds.TreeNode<object, object>(((global::haxe.ds.TreeNode<object, object>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<object, object>(((global::haxe.ds.TreeNode) (arr[0]) ))) ), ((object) (arr[1]) ), ((object) (arr[2]) ), ((global::haxe.ds.TreeNode<object, object>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<object, object>(((global::haxe.ds.TreeNode) (arr[3]) ))) ), global::haxe.lang.Null<object>.ofDynamic<int>(arr[4]));
			}
			#line default
		}
		
		
		public virtual   object haxe_ds_TreeNode_cast<K_c, V_c>()
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				if (( global::haxe.lang.Runtime.eq(typeof(K), typeof(K_c)) && global::haxe.lang.Runtime.eq(typeof(V), typeof(V_c)) )) 
				{
					#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					return this;
				}
				
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				global::haxe.ds.TreeNode<K_c, V_c> new_me = new global::haxe.ds.TreeNode<K_c, V_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
					#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					object __temp_iterator148 = global::Reflect.fields(this).iterator();
					#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator148, "hasNext", 407283053, default(global::Array))) ))
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						string field = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator148, "next", 1224901875, default(global::Array)));
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						switch (field)
						{
							default:
							{
								#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
								global::Reflect.setField(new_me, field, ((object) (global::Reflect.field(this, field)) ));
								#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				return new_me;
			}
			#line default
		}
		
		
		public  global::haxe.ds.TreeNode<K, V> left;
		
		public  global::haxe.ds.TreeNode<K, V> right;
		
		public  K key;
		
		public  V @value;
		
		public  int _height;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 1891834246:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this._height = ((int) (@value) );
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 834174833:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.@value = global::haxe.lang.Runtime.genericCast<V>(((object) (@value) ));
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 5343647:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.key = global::haxe.lang.Runtime.genericCast<K>(((object) (@value) ));
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					default:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
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
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 1891834246:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this._height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 834174833:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.@value = global::haxe.lang.Runtime.genericCast<V>(@value);
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 5343647:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.key = global::haxe.lang.Runtime.genericCast<K>(@value);
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 1768164316:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.right = ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (@value) ))) );
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					case 1202718727:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						this.left = ((global::haxe.ds.TreeNode<K, V>) (global::haxe.ds.TreeNode<object, object>.__hx_cast<K, V>(((global::haxe.ds.TreeNode) (@value) ))) );
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return @value;
					}
					
					
					default:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
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
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 1891834246:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this._height;
					}
					
					
					case 834174833:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.@value;
					}
					
					
					case 5343647:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.key;
					}
					
					
					case 1768164316:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.right;
					}
					
					
					case 1202718727:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return this.left;
					}
					
					
					default:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
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
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				switch (hash)
				{
					case 1891834246:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((double) (this._height) );
					}
					
					
					case 834174833:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.@value) ))) );
					}
					
					
					case 5343647:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.key) ))) );
					}
					
					
					default:
					{
						#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr)
		{
			unchecked 
			{
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("_height");
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("value");
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("key");
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("right");
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				baseArr.push("left");
				#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
				{
					#line 210 "C:\\HaxeToolkit\\haxe\\std/haxe/ds/BalancedTree.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds
{
	public  interface TreeNode : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject 
	{
		   object haxe_ds_TreeNode_cast<K_c, V_c>();
		
	}
}



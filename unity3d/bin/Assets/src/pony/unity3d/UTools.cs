
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace pony.unity3d
{
	public  class UTools : global::haxe.lang.HxObject 
	{
		public    UTools(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    UTools()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::pony.unity3d.UTools.__hx_ctor_pony_unity3d_UTools(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_pony_unity3d_UTools(global::pony.unity3d.UTools __temp_me136)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   bool init(string key, string camera, global::haxe.lang.Null<int> defWidth, global::haxe.lang.Null<int> defHeight, global::haxe.lang.Null<bool> fs)
		{
			unchecked 
			{
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				bool __temp_fs135 = ( (global::haxe.lang.Runtime.eq((fs).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (fs.@value) );
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				int __temp_defHeight134 = ( (global::haxe.lang.Runtime.eq((defHeight).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (600) )) : (defHeight.@value) );
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				int __temp_defWidth133 = ( (global::haxe.lang.Runtime.eq((defWidth).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (800) )) : (defWidth.@value) );
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				if (string.Equals(camera, default(string))) 
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					camera = "/Camera";
				}
				
				#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				if (string.Equals(key, default(string))) 
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					key = "";
				}
				
				object args = global::pony.unity3d.UTools.getArgs(new global::Array<object>(new object[]{"quality", "width", "height"}), ( (string.Equals(key, "")) ? (new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{}), new global::Array<double>(new double[]{}))) : (new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{5691732}), new global::Array<object>(new object[]{key}), new global::Array<int>(new int[]{}), new global::Array<double>(new double[]{}))) ));
				if (( ! (((bool) (global::haxe.lang.Runtime.getField(args, "reg", 5691732, true)) )) )) 
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					return false;
				}
				
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::haxe.lang.Null<int> cfg_quality = global::Std.parseInt(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(args, "quality", 1145832639, true)));
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::haxe.lang.Null<int> cfg_width = global::Std.parseInt(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(args, "width", 1247983110, true)));
				#line 49 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::haxe.lang.Null<int> cfg_height = global::Std.parseInt(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(args, "height", 38537191, true)));
				global::UnityEngine.QualitySettings.SetQualityLevel(cfg_quality.@value);
				#line 52 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				if (( ( cfg_width.@value > 0 ) && ( cfg_height.@value > 0 ) )) 
				{
					global::UnityEngine.Screen.SetResolution(cfg_width.@value, cfg_height.@value, ((bool) (__temp_fs135) ));
				}
				 else 
				{
					#line 55 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					global::UnityEngine.Screen.SetResolution(((int) (__temp_defWidth133) ), ((int) (__temp_defHeight134) ), ((bool) (false) ));
				}
				
				#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				if (string.Equals(camera, default(string))) 
				{
					#line 57 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					return true;
				}
				
				global::UnityEngine.GameObject cam = global::UnityEngine.GameObject.Find(camera);
				if (( cam == default(global::UnityEngine.GameObject) )) 
				{
					#line 59 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					return true;
				}
				
				global::pony.unity3d.UTools.compEnabled(cam, "AntialiasingAsPostEffect", ( cfg_quality.@value >= 1 ));
				global::pony.unity3d.UTools.compEnabled(cam, "NoiseAndGrain", global::pony.unity3d.UTools.compEnabled(cam, "DepthOfFieldScatter", global::pony.unity3d.UTools.compEnabled(cam, "BloomAndLensFlares", global::pony.unity3d.UTools.compEnabled(cam, "NoiseAndGrain", global::pony.unity3d.UTools.compEnabled(cam, "DepthOfFieldScatter", global::pony.unity3d.UTools.compEnabled(cam, "SSAOEffect", global::haxe.lang.Runtime.eq((cfg_quality).toDynamic(), 2)))))));
				return true;
			}
			#line default
		}
		
		
		public static   object getArgs(global::Array<object> vs, object ks)
		{
			unchecked 
			{
				#line 67 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				object r = new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{}), new global::Array<object>(new object[]{}), new global::Array<int>(new int[]{}), new global::Array<double>(new double[]{}));
				global::haxe.ds.StringMap<object> vls = new global::haxe.ds.StringMap<object>();
				if (( ! (global::haxe.lang.Runtime.eq(ks, default(object))) )) 
				{
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					int _g = 0;
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					global::Array<object> _g1 = global::Reflect.fields(ks);
					#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					while (( _g < _g1.length ))
					{
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						string f = global::haxe.lang.Runtime.toString(_g1[_g]);
						#line 69 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						 ++ _g;
						global::Reflect.setField(r, f, false);
						{
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
							string key = global::haxe.lang.Runtime.concat("-", global::Std.@string(global::Reflect.field(ks, f)));
							#line 71 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
							vls.@set(key, f);
						}
						
					}
					
				}
				
				#line 73 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::Array<object> pvs = new global::Array<object>(new object[]{});
				if (( vs != default(global::Array<object>) )) 
				{
					int _g2 = 0;
					#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					while (( _g2 < vs.length ))
					{
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						string v = global::haxe.lang.Runtime.toString(vs[_g2]);
						#line 75 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						 ++ _g2;
						global::Reflect.setField(r, v, default(object));
						pvs.push(global::haxe.lang.Runtime.concat("-", v));
					}
					
				}
				
				#line 80 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				string[] a = global::System.Environment.GetCommandLineArgs();
				bool skip = true;
				{
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					int _g11 = 0;
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					int _g3 = ( a as global::System.Array ).Length;
					#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					while (( _g11 < _g3 ))
					{
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						int i = _g11++;
						#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
						if (skip) 
						{
							#line 82 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
							skip = false;
						}
						 else 
						{
							if (( global::Lambda.indexOf<object>(pvs, a[i]) != -1 )) 
							{
								global::Reflect.setField(r, global::haxe.lang.StringExt.substr(a[i], 1, default(global::haxe.lang.Null<int>)), a[( i + 1 )]);
								skip = true;
							}
							 else 
							{
								if (vls.exists(a[i])) 
								{
									global::Reflect.setField(r, global::haxe.lang.Runtime.toString(vls.@get(a[i]).@value), true);
								}
								
							}
							
						}
						
					}
					
				}
				
				#line 90 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				return r;
			}
			#line default
		}
		
		
		public static   bool compEnabled(global::UnityEngine.GameObject g, string name, bool enabled)
		{
			unchecked 
			{
				#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				global::UnityEngine.Behaviour c = default(global::UnityEngine.Behaviour);
				#line 94 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				c = ((global::UnityEngine.Behaviour) (g.GetComponent(global::haxe.lang.Runtime.toString(name))) );
				if (( c != default(global::UnityEngine.Behaviour) )) 
				{
					#line 95 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
					c.enabled = enabled;
				}
				
				return enabled;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				return new global::pony.unity3d.UTools(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr)
		{
			unchecked 
			{
				#line 40 "C:\\HaxeToolkit\\haxe\\lib\\pony/git/pony/unity3d/UTools.hx"
				return new global::pony.unity3d.UTools();
			}
			#line default
		}
		
		
	}
}



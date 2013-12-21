package ;
import pony.events.Event;
import pony.events.Signal;
import TicTacToe;
import pony.unity3d.scene.MouseHelper;
import unityengine.MonoBehaviour;
import unityengine.Vector3;
import unityengine.Object;
import unityengine.GameObject;
using hugs.HUGSWrapper;

/**
 * PlacePoint
 * @author AxGord <axgord@gmail.com>
 */

class PlacePoint extends MonoBehaviour {

	public var click:Signal;
	
	private var g:GameObject;
	
	private function Start():Void {
		var h = getOrAddTypedComponent(MouseHelper);
		h.over.add(over);
		h.out.add(out);
		click = h.down;
	}
	
	private function over():Void {
		transform.localScale = new Vector3(2, 2, 2);
	}
	
	private function out():Void {
		transform.localScale = new Vector3(1, 1, 1);
	}
	
	public function set(e:Event):Void {
		if (g != null) {
			Object.Destroy(g);
			g = null;
		}
		var p:Player = e.args[0];
		if (p != null) {
			g = cast Object.Instantiate(Scene.players[p],transform.position,transform.rotation);
			g.active = true;
			gameObject.active = false;
		} else {
			gameObject.active = true;
		}
	}
	
}
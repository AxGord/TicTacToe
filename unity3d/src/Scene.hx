package ;
import TicTacToe;
import pony.magic.StaticInit;
import pony.unity3d.StaticAccess;
import pony.ui.ButtonCore;
import unityengine.GameObject;

/**
 * Scene
 * @author AxGord <axgord@gmail.com>
 */
class Scene implements StaticInit {

	public static var points:Array<PlacePoint> = [for (i in 0...27) StaticAccess.component('/Points/$i',PlacePoint)];	
	
	public static var players:Map<Player, GameObject> = [
		Player.X => GameObject.Find('/Players/X'),
		Player.Toe => GameObject.Find('/Players/O'),
		Player.Rhomb => GameObject.Find('/Players/Rhomb')
	];
	
}
package ;
import TicTacToe;
import pony.magic.StaticInit;
import pony.unity3d.StaticAccess;
import pony.ui.ButtonCore;
import unityengine.GameObject;

/**
 * UI
 * @author AxGord <axgord@gmail.com>
 */
class UI implements StaticInit {

	public static var mainMenu:GameObject = GameObject.Find('/UI/MainMenu');
	public static var endText:GameObject = GameObject.Find('/UI/EndText');
	
	public static var bGame:ButtonCore = StaticAccess.button('/UI/MainMenu/bGame');
	public static var bMenu:ButtonCore = StaticAccess.button('/UI/bMenu');
	public static var bReturn:ButtonCore = StaticAccess.button('/UI/MainMenu/bReturn');
	public static var bExit:ButtonCore = StaticAccess.button('/UI/MainMenu/bExit');
	
	public static var bRandom:ButtonCore = StaticAccess.button('/UI/MainMenu/bRandom');
	
	public static var bS:Array<ButtonCore> = [for (i in 1...4) StaticAccess.button('/UI/MainMenu/bS$i')];
	
	
}
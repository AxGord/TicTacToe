package ;
import pony.DeltaTime;
import pony.events.Event;
import pony.unity3d.DeltaTimeHelper;
import TicTacToe;
import unityengine.MonoBehaviour;
import unityengine.Application;
using hugs.HUGSWrapper;

import pony.unity3d.ui.TintButton;

enum Ch {
	None; Pl; Ai;
}

/**
 * Main
 * @author AxG
 */

class Main extends DeltaTimeHelper 
{
	
	private var game:TicTacToe = new TicTacToe(true);
	
	private var players:Array<Ch>;
	
	private function Start():Void
	{
		UI.initStatic();
		Scene.initStatic();
		UI.endText.guiText.enabled = false;
		UI.bExit.click.add(Application.Quit);
		DeltaTime.fixedUpdate.once(init);
	}
	
	private function init():Void {
		players = [for (b in UI.bS) chcnv(b.mode) ];
		for (i in 0...UI.bS.length)
			UI.bS[i].onMode.add(ch.bind(i));
		
		openMenu();
		
		for (p in Scene.players) p.gameObject.active = false;
		
		UI.bGame.click.add(startGame);
		UI.bMenu.click.add(openMenu);
		UI.bReturn.click.sub(0).add(closeMenu);
		
		for (i in 0...Scene.points.length) {
			var p = Scene.points[i];
			game.drawPoint.sub(i).add(p.set);
			p.click.add(game.makeTurn.bind(i));
		}
		
		game.win.add(function() {
			trace('Game complite!');
			UI.endText.guiText.enabled = true;
			UI.bReturn.mode = 1;
		});
	}
	
	private function ch(n:Int, mode:Int):Void players[n] = chcnv(mode);
	
	private function chcnv(mode:Int):Ch return switch mode {
		case 0: Ch.Ai;
		case 2: Ch.Pl;
		case 3: Ch.None;
		case _:
	}
	
	public function openMenu():Void {
		UI.mainMenu.active = true;
		for (p in Scene.points) p.click.silent = true;
		UI.endText.guiText.enabled = false;
	}
	
	public function closeMenu():Void {
		UI.mainMenu.active = false;
		for (p in Scene.points) p.click.silent = false;
	}
	
	private function startGame():Void {
		trace('Start game');
		UI.bReturn.mode = 0;
		game.empty();
		closeMenu();
		var nc = 0;
		for (p in players) if (p != Ch.None) nc++;
		var ais:Array<Player> = [];
		for (i in 0...players.length) if (players[i] == Ch.Ai) switch i {
			case 0: ais.push(X);
			case 1: ais.push(Toe);
			case 2: ais.push(Rhomb);
			case _:
		};
		game.start(nc, UI.bRandom.mode == 0, ais);
	}
	
	private static function main(){}
}
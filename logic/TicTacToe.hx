package ;
import pony.events.Signal;
import pony.events.Signal1;
import pony.events.Signal2;

enum Player {
	None;  X; Toe; Rhomb;
}

/**
 * Tic Tac Toe 3D
 * @author AxGord <axgord@gmail.com>
 */
class TicTacToe
{
	/**
	 * @author Anna
	 */
	private static var lines2d:Array<Array<Int>> = [
		[0,1,2], [3,4,5], [6,7,8], [0,3,6], [1,4,7], [2,5,8], [6,4,2], [0,4,8]
	];
	
	/**
	 * @author Anna
	 */
	private static var lines3d:Array<Array<Int>> = [
		[0,1,2], [3,4,5], [6,7,8], [0,3,6], [1,4,7], [2,5,8], [6,4,2], [0,4,8],
		[9,10,11], [12,13,14], [15,16,17], [9,12,15], [10,13,16], [11,14,17], [11,13,15], [9,13,17], 
		[18,19,20], [21,22,23], [24,25,26], [18,21,24], [19,22,25], [20,23,26], [20,22,24], [18,22,26], 
		[8,16,24], [7,16,25], [6,16,26], [6,16,26], 
		[3,12,21], [4,13,22], [5,14,23], [3,13,23], [5,13,21], 
		[0,9,18], [1,10,19], [2,11,20], [0,10,20], [2,10,18],
		[8,12,18], [0,12,24], [1,13,25], [7,13,19], [2,14,26], [6,13,20],
		[4,13,22],[8,14,20], [0,13,26], [2,13,24], [6,12,18]
	];
	
	public var drawPoint(default, null):Signal2<TicTacToe, Int, Player>;
	public var win(default, null):Signal1<TicTacToe, Player>;
	public var gameComplite(default, null):Bool;
	
	private var area:Array<Player>;
	private var areaSize:Int = 9;
	private var d3:Bool;
	private var ai:Array<Player>;
	private var turn(get,never):Player;
	private var lines:Array<Array<Int>>;
	private var ps:Array<Player>;
	
	private var currentPlayerId:Int = 0;
	private var playersCount:Int;
	
	public function new(d3:Bool) 
	{
		this.d3 = d3;
		if (d3) {
			areaSize *= 3;
			lines = lines3d;
		} else {
			lines = lines2d;
		}
		ps = Player.createAll();
		ps.shift();
		drawPoint = Signal.create(this);
		win = Signal.create(this);
		win.add(end);
		emptyArea();
	}
	
	private function end():Void gameComplite = true;
	
	inline private function get_turn():Player return ps[currentPlayerId];
	
	public function start(playersCount:Int, randomBeginer:Bool = false, ?ai:Array<Player>):Void {
		this.playersCount = playersCount;
		this.ai = ai == null ? [] : ai;
		currentPlayerId = randomBeginer ? Math.floor(Math.random()*playersCount) : 0;
		aiTurn();
	}
	
	inline public function emptyArea():Void {
		area = [for (_ in 0...areaSize) null];
	}
	
	inline public function empty():Void {
		emptyArea();
		for (i in 0...areaSize) drawPoint.dispatch(i, null);
		gameComplite = false;
	}
	
	public function makeTurn(to:Int):Void {
		push(turn, to);
		aiTurn(to);
	}
	
	inline public function swTurn():Void {
		currentPlayerId++;
		if (currentPlayerId >= playersCount) currentPlayerId = 0;
	}
	
	private function push(v:Player, to:Int):Void {
		if (gameComplite) return;
		if (area[to] != null) throw 'Point $to not empty! ($v)';
		area[to] = v;
		drawPoint.dispatch(to, v);
		swTurn();
		checkWin();
	}
	
	private inline function checkWin():Void {
		for (l in lines) {
			for (p in ps) {
				var c:Int = 0;
				for (n in l)
					if (area[n] == p) c++;
				if (c == 3)
					win.dispatch(p);
			}
		}
	}
	
	public function aiTurn(?last:Null<Int>):Void {
		if (gameComplite) return;
		if (Lambda.indexOf(ai, turn) == -1) return;
		//Try win
		for (l in lines) {
			var c:Int = 0;
			var num:Int = 0;
			for (n in l)
				if (area[n] == turn) c++;
				else num = n;
			if (c == 2 && area[num] == null) {
				push(turn, num);
				aiTurn(num);
				return;
			}
		}
		//Defend
		
		for (l in lines) {
			var c:Int = 0;
			for (p in ps) {
				var num:Int = 0;
				for (n in l)
					if (area[n] == p) c++;
					else num = n;
				if (c == 2 && area[num] == null) {
					push(turn, num);
					aiTurn(num);
					return;
				}
			}
		}
		//Counter attack
		if (last != null) for (l in lines) {
			if (l[0] == last && area[l[2]] == null) {
				push(turn, l[2]);
				aiTurn(l[2]);
				return;
			}
			if (l[2] == last && area[l[0]] == null) {
				push(turn, l[0]);
				aiTurn(l[0]);
				return;
			}
		}
		
		var emptys:Array<Int> = [];
		for (i in 0...areaSize) if (area[i] == null) emptys.push(i);
		var pos:Int = Math.floor(Math.random() * emptys.length);
		pos = emptys[pos];
		push(turn, pos);
		aiTurn(pos);
	}
	
}
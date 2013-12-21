package ;

import haxe.unit.TestCase;
import haxe.unit.TestRunner;
import TicTacToe;

/**
 * TicTacToe tests
 * @author AxGord <axgord@gmail.com>
 */

class Main
{
	
	static function main() 
	{
		var tr = new TestRunner();
		tr.add(new Test2D());
		tr.add(new Test3D());
		tr.run();
	}
	
}

class Test2D extends TestCase {
	
	var game:TicTacToe;
	var area:Array<Player>;
	
	override function setup() {
		area = [for (_ in 0...9) null];
		game = new TicTacToe(false);
		game.drawPoint.add(addToArea);
	}
	
	function addToArea(to:Int, p:Player) {
		area[to] = p;
	}
	
	public function testGame() {
		
		game.start(2, [Toe]);
		game.makeTurn(0);
		game.makeTurn(1);
		
		assertEquals(area[0], X);
		assertEquals(area[2], Toe);
		
	}
	
}
class Test3D extends TestCase {
	
	var game:TicTacToe;
	var area:Array<Player>;
	
	override function setup() {
		area = [for (_ in 0...9*3) null];
		game = new TicTacToe(false);
		game.drawPoint.add(addToArea);
	}
	
	function addToArea(to:Int, p:Player) {
		area[to] = p;
	}
	
	public function testGame() {
		
		game.start(2, [Toe]);
		game.makeTurn(0);
		
		assertEquals(area[0], X);
		//assertEquals(area[2], Toe);
		
	}
	
	public function testAutoGame():Void {
		game.start(2, [X, Toe]);
	}
	
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Boss {        
		private int mp = 53; 
		
		public void Magic() { 			
		if (mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		  } else {Debug.Log ("MPが足りないため魔法が使えない。");
		}
		}
	}

	public class Test : MonoBehaviour {

		void Start () {

		int[] array = {0, 5, 10, 15, 20};

		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//for (int i = array.Length; i >= 0; i--) { エラーが出ますどうしてでしょうか？
		for (int i = 4; i >= 0; i--) {	
			Debug.Log (array[i]);
		}

		Boss boss = new Boss ();

		for (int i = 0; i <= 10; i++) {
			boss.Magic ();}
	}
}
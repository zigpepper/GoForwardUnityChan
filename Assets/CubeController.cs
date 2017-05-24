using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// 効果音変数(課題用追加)
	private AudioSource sound01;

	// Use this for initialization
	void Start(){
		//AudioSourceコンポーネントを取得し、変数に格納(課題用追加)
		sound01 = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);
		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
			
	}

	//他の物に衝突した場合効果音を鳴らす（課題用追加）
	void OnCollisionEnter2D(Collision2D other) {
		//UnityChanに衝突した場合は何もしない（課題用追加）
		if (other.gameObject.tag == "Player") {
			//地面か他のブロックと衝突した時に効果音を鳴らす（課題用追加）
		} else {
			sound01.PlayOneShot(sound01.clip);
		}
	}

}
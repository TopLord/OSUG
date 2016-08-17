using UnityEngine;
using System.Collections;

namespace S1 {
	public class GameManager_TogglePause : MonoBehaviour {

		//Reference GameManager_Master script
		private GameManager_Master gameManagerMaster;
		private bool isPaused;

		void OnEnable() {

			SetInitialReferences ();
			gameManagerMaster.MenuToggleEvent += TogglePause;
		}

		void OnDisable(){
			gameManagerMaster.MenuToggleEvent -= TogglePause;
		}

		void SetInitialReferences() {
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void TogglePause(){
			if (isPaused) {
				Time.timeScale = 1;
				isPaused = false;
			} else {
				Time.timeScale = 0;
				isPaused = true;
			}
		}

	}//end class
}//end namespace
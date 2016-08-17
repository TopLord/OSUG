using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace S1
{
	public class GameManager_GoToMenuScene : MonoBehaviour {
		private GameManager_Master gameManagerMaster;

		void OnEnable(){
			SetInitialReference ();
			gameManagerMaster.GoToMenuSceneEvent += GoToMenuScene;
		}

		void OnDisable() {
			gameManagerMaster.GoToMenuSceneEvent -= GoToMenuScene;
		}

		void SetInitialReference(){
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void GoToMenuScene(){
			SceneManager.LoadScene (0);
		}


	}//end class
}//end namespace
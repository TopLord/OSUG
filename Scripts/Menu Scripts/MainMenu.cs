using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace S1
{
	public class MainMenu : MonoBehaviour {

		public void PlayGame(){
			SceneManager.LoadScene (1);
		}

		public void ExitGame (){
			Application.Quit();
		}

	}
}
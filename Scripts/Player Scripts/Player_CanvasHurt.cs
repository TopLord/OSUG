using UnityEngine;
using System.Collections;

/// <summary>
/// Player canvas hurt.
/// A simple hit notification that causes the player
/// screen to become red for secontsTillHide
/// </summary>
namespace S1
{
	public class Player_CanvasHurt : MonoBehaviour {

		public GameObject hurtCanvas;
		private Player_Master playerMaster;
		private float secondsTillHide = 2;

		void OnEnable() {
			SetInitialReferences ();
			playerMaster.EventPlayerHealthDeduction += TurnOnHurtEffect;
		
		}

		void OnDisable() {
			playerMaster.EventPlayerHealthDeduction -= TurnOnHurtEffect;
		
		}

		void SetInitialReferences() {
			playerMaster = GetComponent<Player_Master> ();
		
		}
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		void TurnOnHurtEffect(int dummy){
			if (hurtCanvas != null) {
				StopAllCoroutines ();
				hurtCanvas.SetActive (true);
				StartCoroutine (ResetHurtCanvas ());
			}
		}

		IEnumerator ResetHurtCanvas(){
			yield return new WaitForSeconds (secondsTillHide);
			hurtCanvas.SetActive (false);
		}
	}
}

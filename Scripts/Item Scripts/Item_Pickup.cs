using UnityEngine;
using System.Collections;

namespace S1
{
	public class Item_Pickup : MonoBehaviour {
		
		private Item_Master itemMaster;
		//private Transform myTransform;

		void OnEnable() {

			SetInitialReferences ();
			itemMaster.EventPickupAction += CarryOutPickupActions;
		
		}

		void OnDisable() {

			itemMaster.EventPickupAction -= CarryOutPickupActions;
		
		}

		void SetInitialReferences() {

			itemMaster = GetComponent<Item_Master> ();
		
		}

		//transform will become parent of the weapon camera
		void CarryOutPickupActions(Transform tParent) {

			transform.SetParent (tParent);
			itemMaster.CallEventObjectPickup ();
			transform.gameObject.SetActive (false);
		}


	}
}

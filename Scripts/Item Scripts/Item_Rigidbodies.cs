using UnityEngine;
using System.Collections;

/// <summary>
/// Item rigidbodies.
/// Performs simple check on whatever item is in the players hand/inventory
/// and decides if that items kinematic properties needs to be disabled
/// </summary>
namespace S1
{
	public class Item_Rigidbodies : MonoBehaviour {

		private Item_Master itemMaster;
		public Rigidbody[] rigidBodies;

		void OnEnable() {

			SetInitialReferences ();
			CheckIfStartsInInventory ();
			itemMaster.EventObjectThrow += SetIsKinematicToFalse;
			itemMaster.EventObjectPickup += SetIsKinematicToTrue;
		
		}

		void OnDisable() {

			itemMaster.EventObjectThrow -= SetIsKinematicToFalse;
			itemMaster.EventObjectPickup -= SetIsKinematicToTrue;
		
		}

		void SetInitialReferences() {

			itemMaster = GetComponent<Item_Master> ();
		
		}
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		void CheckIfStartsInInventory(){

			if (transform.root.CompareTag (GameManager_References._playerTag)) {
				SetIsKinematicToTrue ();
			}
		}

		void SetIsKinematicToTrue() {

			if (rigidBodies.Length > 0) {
				foreach (Rigidbody rBody in rigidBodies) {
					rBody.isKinematic = true;
				}
			}
		}

		void SetIsKinematicToFalse(){

			if (rigidBodies.Length > 0) {
				foreach (Rigidbody rBody in rigidBodies) {
					rBody.isKinematic = false;
				}
			}
		}
	}
}

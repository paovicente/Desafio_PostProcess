using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    [SerializeField] GameObject globalVolumeManager;

    private void OnTriggerStay(Collider other) {

        if (other.gameObject.name == "cross"){
            globalVolumeManager.GetComponent<GlobalVolumeManager>().OnDamageFilter(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        
        globalVolumeManager.GetComponent<GlobalVolumeManager>().OnDamageFilter(false);
    }
}

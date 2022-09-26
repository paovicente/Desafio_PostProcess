using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GlobalVolumeManager : MonoBehaviour {

    private PostProcessVolume globalVolume;

    [SerializeField] bool isDamageFilter = false;

    // Start is called before the first frame update
    void Start(){

        globalVolume = GetComponent<PostProcessVolume>();
    }

    public void OnDamageFilter(bool activateFilter){

        ColorGrading colorFX;

        isDamageFilter = activateFilter;

        if (globalVolume.profile.TryGetSettings(out colorFX))
            colorFX.active = isDamageFilter;
        
    }

}

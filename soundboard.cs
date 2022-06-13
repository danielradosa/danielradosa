using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundboard : MonoBehaviour
{
public AudioClip[] aClips;
public AudioSource[] audioS;
string btnName;

void Update()
{
if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit Hit;
        if (Physics.Raycast(ray, out Hit)) {
            btnName = Hit.transform.name;
            switch (btnName)
                {
                    case "PAD 1":
                    if(!audioS[0].isPlaying){
                        audioS[0].clip = aClips[0];
                        audioS[0].Play();

                    } else {
                        audioS[0].Stop();
                    }
                    break;

                    case "PAD 2":
                    if(!audioS[1].isPlaying){
                        audioS[1].clip = aClips[1];
                        audioS[1].Play();
                    }else{
                        audioS[1].Stop();
                    }
                        break;
                        case "PAD 3":
                    if(!audioS[2].isPlaying){
                        audioS[2].clip = aClips[2];
                        audioS[2].Play();
                    }else{
                        audioS[2].Stop();
                    }
                        break;
                        case "PAD 4":
                    if(!audioS[3].isPlaying){
                        audioS[3].clip = aClips[3];
                        audioS[3].Play();
                    }else{
                        audioS[3].Stop();
                    }
                        break;
                        case "PAD 5":
                    if(!audioS[4].isPlaying){
                        audioS[4].clip = aClips[4];
                        audioS[4].Play();
                    }else{
                        audioS[4].Stop();
                    }
                        break;
                        case "PAD 6":
                    if(!audioS[5].isPlaying){
                        audioS[5].clip = aClips[5];
                        audioS[5].Play();
                    }else{
                        audioS[5].Stop();
                    }
                        break;
                
                        case "PAD 7":
                    if(!audioS[6].isPlaying){
                        audioS[6].clip = aClips[6];
                        audioS[6].Play();
                    }else{
                        audioS[6].Stop();
                    }
                        break;
                        case "PAD 8":
                    if(!audioS[7].isPlaying){
                        audioS[7].clip = aClips[7];
                        audioS[7].Play();
                    }else{
                        audioS[7].Stop();
                    }
                        break;
                        case "PAD 9":
                    if(!audioS[8].isPlaying){
                        audioS[8].clip = aClips[8];
                        audioS[8].Play();
                    }else{
                        audioS[8].Stop();
                    }
                        break;
                        case "PAD 10":
                    if(!audioS[9].isPlaying){
                        audioS[9].clip = aClips[9];
                        audioS[9].Play();
                    }else{
                        audioS[9].Stop();
                    }
                        break;
                    case "PAD 11":
                    if(!audioS[10].isPlaying){
                        audioS[10].clip = aClips[10];
                        audioS[10].Play();
                    }else{
                        audioS[10].Stop();
                    }
                        break;
                    case "PAD 12":
                    if(!audioS[11].isPlaying){
                        audioS[11].clip = aClips[11];
                        audioS[11].Play();
                    }else{
                        audioS[11].Stop();
                    }
                        break;
                    case "PAD 13":
                    if(!audioS[12].isPlaying){
                        audioS[12].clip = aClips[12];
                        audioS[12].Play();
                    }else{
                        audioS[12].Stop();
                    }
                        break;
                    case "PAD 14":
                    if(!audioS[13].isPlaying){
                        audioS[13].clip = aClips[13];
                        audioS[13].Play();
                    }else{
                        audioS[13].Stop();
                    }
                        break;
                    case "PAD 15":
                    if(!audioS[14].isPlaying){
                        audioS[14].clip = aClips[14];
                        audioS[14].Play();
                    }else{
                        audioS[14].Stop();
                    }
                        break;
                        case "PAD 16":
                    if(!audioS[15].isPlaying){
                        audioS[15].clip = aClips[15];
                        audioS[15].Play();
                    }else{
                        audioS[15].Stop();
                    }
                        break;
                    
                
                    default:
                    break;
                }
            }    
        }
    }
}
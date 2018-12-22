using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class Controller : MonoBehaviour {
    public Leap.Controller controllerButActually;
    AudioSource First;
    AudioSource Second;
    AudioSource Third;
    AudioSource Fourth;
    AudioSource Fifth;
    AudioSource Sixth;
    AudioSource Seventh;
    AudioSource Eigth;
    AudioSource Ninth;
    AudioSource Tenth;

    // Use this for initialization
    void Start ()
    {
        AudioSource[] allSources = GetComponents<AudioSource>();
        First = allSources[0];
        Second = allSources[1];
        Third = allSources[2];
        Fourth = allSources[3];
        Fifth = allSources[4];
        Sixth = allSources[5];
        Seventh = allSources[6];
        Eigth = allSources[7];
        Ninth = allSources[8];
        Tenth = allSources[9];
    }
	
	// Update is called once per frame
	void Update ()
    {
        controllerButActually = new Leap.Controller();
        
        Frame frame = controllerButActually.Frame();
        List<Hand> handsInFrame = frame.Hands;

        foreach (Hand hand in handsInFrame)
        {
            List<Finger> fingers = hand.Fingers;
            foreach (Finger digit in fingers)
            {

                if (hand.IsLeft)
                {

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_INDEX)
                    {                       
                        {
                            First.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_MIDDLE)
                    {
                        {
                            Second.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_PINKY)
                    {
                        {
                            Third.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_RING)
                    {
                        {

                            Fourth.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_THUMB)
                    {                      
                        {
                            Fifth.Play();
                        }
                    }

                }
                

                if (hand.IsRight)
                {
                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_INDEX)
                    {
                        {
                            Sixth.Play();
                        }
                    }


                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_MIDDLE)
                    {
                        {
                            Seventh.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_PINKY)
                    {
                        {
                            Eigth.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_RING)
                    {
                        {
                            Ninth.Play();
                        }
                    }

                    if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_THUMB)
                    {
                        {
                            Tenth.Play();
                        }
                    }
                }


                if (!digit.IsExtended && digit.Type == Leap.Finger.FingerType.TYPE_THUMB)
                {

                }
            }


        }


    }


}

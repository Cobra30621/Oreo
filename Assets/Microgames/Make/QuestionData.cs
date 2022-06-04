using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum OREO{
    O = 0, RE = 1
}

[System.Serializable]
public class Question{
    public AudioClip audioClip;
    public List<OREO> oreos;
}

[CreateAssetMenu(fileName = "QuestionData", menuName = "ScriptableObjects/QuestionData")]
public class QuestionData : ScriptableObject
{
    public List<Question> questions;

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Story flow")]
public class StoryFlow : ScriptableObject

{

    [TextArea(10, 14)] [SerializeField] string storyText; // Текст рассказа
    [SerializeField] AudioClip storySpeach; //Аудио рассказа
    [SerializeField] Sprite storySprite; // Картинка  рассказа
    [SerializeField] StoryFlow[] storyFlows; // Переходы между рассказами 
                                             /*
                                              Для будущего обновления сделать картинку рассказа
                                              что бы при смене потока меняласьи картинка
                                              */
    public string GetStoryText()
    {
        return storyText;
    }

    public AudioClip GetStorySpeach()
    {
        return storySpeach;
    }

    public StoryFlow[] GetNextStoryFlow()
    {
        return storyFlows;
    }
    

}

    

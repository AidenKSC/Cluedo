using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    //public Sprite[] characterCards = new Sprite[6];
    public List<Sprite> characterSprites;
    public List<Sprite> weaponSprites;
    public List<Sprite> roomSprites;
    public List<Sprite> murderSprites;
    //public Sprite[] weaponCards = new Sprite[6];
    //public Sprite[] roomCards = new Sprite[9];
    
    public Button mybutton;
    public Button revealbtn; 

    System.Random random = new System.Random();
    public static List<string> murderCards = new List<string>();
    public Image murderCard1;
    public Image murderCard2;
    public Image murderCard3;
    public static List<string> characters = new List<string>() { "Mrs White", "Mrs Peacock", "Miss Scarlet", "Colonel Mustard", "Mr. Green", "Professor Plum" };
    public static List<string> weapons = new List<string>() { "candlestick", "revolver", "rope", "wrench", "lead pipe", "knife" };
    public static List<string> rooms = new List<string>() { "study", "library", "conservatory", "hall", "kitchen", "ballroom", "dining room", "lounge", "billiard room" }; 

    // Start is called before the first frame update
    void Start()
    {
        PlayCards();
        mybutton.onClick.AddListener(TaskOnClick);
        revealbtn.onClick.AddListener(ShowMiddleCards);
        murderCard1.enabled = false;
        murderCard2.enabled = false;
        murderCard3.enabled = false;
        revealbtn.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        MiddleCards();
        mybutton.gameObject.SetActive(false);
        revealbtn.enabled = true; 
        
    }
    public void PlayCards()
    {
        Shuffle(characters);
        Shuffle(weapons);
        Shuffle(rooms);

        foreach (string card in characters)
        {
            print(card);
        }
    
    }
    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }
    void MiddleCards() 
    {
       
        int charRandom = random.Next(characters.Count - 1);
        int weaponRandom = random.Next(weapons.Count - 1);
        int roomRandom = random.Next(rooms.Count - 1);
        murderCards.Add(characters[charRandom]);
        murderCards.Add(weapons[weaponRandom]);
        murderCards.Add(rooms[roomRandom]);
        murderSprites.Add(characterSprites[charRandom]);
        murderSprites.Add(weaponSprites[weaponRandom]);
        murderSprites.Add(roomSprites[roomRandom]);
        characters.RemoveAt(charRandom);
        weapons.RemoveAt(weaponRandom);
        rooms.RemoveAt(roomRandom);
        characterSprites.RemoveAt(charRandom);
        weaponSprites.RemoveAt(weaponRandom);
        roomSprites.RemoveAt(roomRandom);

        foreach (string card in murderCards)
        {
            print(card);
        }


    }

    void ShowMiddleCards()
    {
       
       
            murderCard1.sprite = murderSprites[0];
            murderCard1.enabled = true;

            murderCard2.sprite = murderSprites[1];
            murderCard2.enabled = true;

            murderCard3.sprite = murderSprites[2];
            murderCard3.enabled = true;
      

       
    }
}

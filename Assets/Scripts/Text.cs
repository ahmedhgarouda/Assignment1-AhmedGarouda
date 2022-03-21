//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Proyecto26;
//using UnityEngine.UI;
//using System;

//public class Text : MonoBehaviour
//{
//    public Text scoreText;
//    public InputField nameText;
//    public static string playerName;

//    User user = new User();

//    // Start is called before the first frame update
//    void Start()
//    {
//        scoreText.text = "Hello";
//    }
//    public void OnSubmit()
//    {
//        playerName = nameText.text; ;
//        PostToDatabase();
//    }

//    private void PostToDatabase()
//    {
//        User user = new User();
//        RestClient.Put("https://assignment-1-255c7-default-rtdb.firebaseio.com/" + playerName + ".json", user);

//    }
//    public void OnGetScore()
//    {
//        RetrieveFromDatabase();

//    }
//    private void UpdateScore()
//    {
//        scoreText.text = "Hello : " + user.userName;
//    }
//    private void RetrieveFromDatabase()
//    {
//        RestClient.Get<User>("https://assignment-1-255c7-default-rtdb.firebaseio.com/" + playerName + ".json").Then(response =>
//        {
//            user = response;
//            UpdateScore();
//        });
//    }
//}
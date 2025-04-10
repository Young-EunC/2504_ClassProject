using ClassProject02.User;
using ClassProject02.Maps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject02.Object
{
    public abstract class GameObject
    {
        public string name;
        public string invstText;
        public string confirmText;
        public Vector2 position;
        public char appearance;

        public abstract void Interact(Player player, Map map);
        //public bool ConfirmInteract() {
        //    bool returnValue = false, isValidInput;
        //    do {
        //        ConsoleKey userInput = Console.ReadKey(true).Key;
        //        if (userInput == ConsoleKey.Y)
        //        {
        //            isValidInput = true;
        //            returnValue = true;
        //        }
        //        else if (userInput == ConsoleKey.N)
        //        {
        //            isValidInput = true;
        //            returnValue = false;
        //        }
        //        else
        //        {
        //            isValidInput = false;
        //        }
        //    } while (!isValidInput);
        //    return returnValue;
        //}
        //public void PrintScript(Queue<string[]> script)
        //{
        //    while (script.Count != 0) {
        //        Console.SetCursorPosition(2, 8);
        //        Console.Write("----------------------------------------");
        //        string[] eachFecet = script.Dequeue();
        //        for (int lineCnt = 0; lineCnt < 3; lineCnt++) {
        //            if (lineCnt < eachFecet.Length)
        //            {
        //                Console.SetCursorPosition(2, (9 + lineCnt));
        //                Console.Write(eachFecet[lineCnt]);
        //            }
        //            else
        //            {
        //                Console.SetCursorPosition(2, (9 + lineCnt));
        //                Console.Write("                                        ");
        //            }
        //        }
        //        Thread.Sleep(2000);
        //    }
        //}
        //public Queue<string[]> ConvertTextToScript(string text) 
        //{
        //    string[] rawText = text.Split(' ');
        //    string[] tempLine = new string[4];
        //    string[] tempFacet = new string[3];

        //    List<string> rawScript = new List<string>();
        //    Queue<string[]> script = new Queue<string[]>();

        //    // 각 단어를 4개씩 line으로 묶어 list에 저장한다. => 남은 단어가 4개 이하면 남은 단어를 저장 못함
        //    for (int wordCnt = 0; wordCnt < rawText.Length; wordCnt++)
        //    {
        //        tempLine[(wordCnt % 4)] = rawText[wordCnt];
        //        if (((wordCnt + 1) % 4) == 0) {
        //            rawScript.Add(String.Join(' ', tempLine));
        //            Array.Clear(tempLine);
        //        }
        //    }
        //    // line으로 묶인 list를 3줄씩 queue에 string[] 형식으로 add한다.=> 남은 줄 수가 4개 이하면 남은 줄을 저장 못함
        //    for (int lineCnt = 0; lineCnt < rawScript.Count; lineCnt++)
        //    {
        //        tempFacet[(lineCnt % 3)] = rawScript[lineCnt];
        //        if ((lineCnt + 1) % 3 == 0) {
        //            script.Enqueue(tempFacet);
        //            Array.Clear(tempFacet);
        //        }
        //    }
        //    return script;
        //}
    }
}

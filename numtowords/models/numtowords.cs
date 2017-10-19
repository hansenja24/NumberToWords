using System.Collections.Generic;
using System;

namespace numToWords.Models
{
  public class numWords
  {
    private string _inputNum;

    Dictionary<char,string> num = new Dictionary<char,string>(){
      {'0',""},{'1',"one"},{'2',"two"},{'3',"three"},{'4',"four"},{'5',"five"},{'6',"six"},{'7',"seven"},{'8',"eight"},{'9',"nine"}
    };
    Dictionary<char,string> tenth = new Dictionary<char,string>(){
      {'0',"ten"},{'1',"eleven"},{'2',"twelve"},{'3',"thirteen"},{'4',"fourteen"},{'5',"fifteen"},{'6',"sixteen"},{'7',"seventeen"},{'8',"eighteen"},{'9',"nineteen"}
    };
    Dictionary<char,string> tenthEx = new Dictionary<char,string>(){
      {'2',"twenty"},{'3',"thirty"},{'4',"fourty"},{'5',"fifty"},{'6',"sixty"},{'7',"seventy"},{'8',"eighty"},{'9',"ninety"}
    };
    Dictionary<int,string> moreTen = new Dictionary<int,string>(){
      {1,"hundred"},{4,"thousand"},{7,"million"},{10,"billion"},{13,"trillion"}
    };

    public numWords(string inputNum)
    {
      _inputNum = inputNum;
    }


    public string getWord()
    {
      string result = "";
      List<string> listNum = new List<string>{};

      for(var i = _inputNum.Length; i > 0; i-=3)
      {
        if(i >= 3)
        {
          listNum.Add(_inputNum[i-3].ToString()+_inputNum[i-2].ToString()+_inputNum[i-1].ToString());
        }
        else if(i == 2)
        {
          listNum.Add(_inputNum[i-2].ToString()+_inputNum[i-1].ToString());
        }
        else if(i == 1)
        {
          listNum.Add(_inputNum[i-1].ToString());
        }
      }

      foreach (var element in listNum)
      {
        if(element.Length == 3)
        {
          // result += num[int.Parse(element[1])] + " " + "hundred";
        }
        ///Already dividing by seperate numbers, need to give a word to the each number in the list

      }
      return result;

    }
  }
}

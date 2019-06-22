using System;

namespace SortingItOutAgain
{
    public class Text
    {
        public string CurrentText;

        public Text()
        {
           
        }

        public Text(string Input)
        {
            CurrentText = Input;
        }

        public string SortLetters()
        {
            CurrentText = CurrentText.ToLower();
            for(int i = 0; i < CurrentText.Length; i++)
            {
                for(int j = i; j < CurrentText.Length; j++)
                {
                    if(CurrentText[i] > CurrentText[j])
                    {
                        //Swap item i with item j
                        string temp1 = CurrentText.Substring(0, i) + CurrentText[j];
                        string temp2 = CurrentText.Substring(i, j - i);
                        string temp3 = CurrentText[i] + CurrentText.Substring(j);

                        CurrentText = temp1 + temp2 + temp3;
                    }
                }
            }

            return CurrentText;
        }
    }
}
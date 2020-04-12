/* TicTacToe Implementation */

using System;
using System.Collections.Generic;

namespace CodingExercises
{
    public class TicTacToe
    {
        private enum TicOrTac{Empty, X, O};
        private enum WinnerState{None,User1,User2};

            static int[] SelectRandomIndex(){
            int randonIndexX; int randonIndexY;
            do{
                randonIndexX = input.Next(0,3);
                randonIndexY = input.Next(0,3);
                // Console.WriteLine($"{randonIndexX}, {randonIndexY} for indices");
            }while(randomIndexDictionary.ContainsKey(randonIndexX.ToString() + randonIndexY.ToString()));
            
            randomIndexDictionary.Add(randonIndexX.ToString() + randonIndexY.ToString(), true);
            return new int[]{randonIndexX, randonIndexY};
        }
        static Dictionary<string, bool> randomIndexDictionary = new Dictionary<string, bool>();

        static Random input = new Random();
        public static void PlayTicTacToe(){
            
            TicOrTac[,] tictacArray = new TicOrTac[3, 3];
            //Initialize the array values to be Blank-  0
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    tictacArray[i,j] = TicOrTac.Empty;
                }
            }
            // tictacArray[0,0] = TicOrTac.Empty;
            bool winner = false;
            int[] userInputIndex = new int[2];
            TicOrTac userInput ;
            WinnerState winnerState;
            PrintTicTac(tictacArray);
            
                int k = 0;
                bool userState = true;
                while (!winner)
                {                   
                    userInputIndex = SelectRandomIndex();
                    userInput = userState ? TicOrTac.X : TicOrTac.O;

                    Console.WriteLine("{2} selected index values : ({0}, {1}) and the Input is:{3}",userInputIndex[0],userInputIndex[1],userState? "User 1" : "User 2", (TicOrTac)userInput);
                    tictacArray[userInputIndex[0],userInputIndex[1]]  = userInput;
                    PrintTicTac(tictacArray);
                    winnerState = CheckTicTacWinner(tictacArray);
                    if(winnerState != WinnerState.None){
                        winner = true;
                        Console.WriteLine($"{winnerState} has won the game!!");
                    }
                    if(k == 8 && !winner){
                        Console.WriteLine("No one has won the game");
                        break;
                    }
                    k++;
                    userState = !userState;                    
                }
        }

        private static WinnerState CheckTicTacWinner(TicOrTac[,] tictacArray){
            int lrCountUser1 = 0;
            int rlCountUser1 = 0;
            int lrCountUser2 = 0;
            int rlCountUser2 = 0;
            int j = 0, k = 2, l = 0;
            for(int i=0; i<3; i++){
                if(tictacArray[i,j].Equals(TicOrTac.X) && tictacArray[i,j+1].Equals(TicOrTac.X) && tictacArray[i,j+2].Equals(TicOrTac.X)){
                    return WinnerState.User1;
                }
                if(tictacArray[i,j].Equals(TicOrTac.O) && tictacArray[i,j+1].Equals(TicOrTac.O) && tictacArray[i,j+2].Equals(TicOrTac.O)){
                    return WinnerState.User2;
                }
                if(tictacArray[l,i].Equals(TicOrTac.X) && tictacArray[l+1,i].Equals(TicOrTac.X) && tictacArray[l+2,i].Equals(TicOrTac.X)){
                    return WinnerState.User1;
                }
                if(tictacArray[l,i].Equals(TicOrTac.O) && tictacArray[l+1,i].Equals(TicOrTac.O) && tictacArray[l+2,i].Equals(TicOrTac.O)){
                    return WinnerState.User2;
                }
                if(tictacArray[i,i].Equals(TicOrTac.X) && lrCountUser2 == 0) {
                    lrCountUser1++;
                }
                if(tictacArray[i,i].Equals(TicOrTac.O) && lrCountUser1 == 0) {
                    lrCountUser2++;
                }
                if(tictacArray[i,k].Equals(TicOrTac.X) && rlCountUser2 == 0){
                    k= k-1;
                    rlCountUser1++;
                }
                else if(tictacArray[i,k].Equals(TicOrTac.O) && rlCountUser1 == 0){
                    k= k-1;
                    rlCountUser2++;
                }
            }
            //0,0; 1,1; 2,2
            //0,2; 1,1; 2,0
            if(lrCountUser1 == 3) return WinnerState.User1;
            if(lrCountUser2 == 3) return WinnerState.User2;
            if(rlCountUser1 == 3) return WinnerState.User1;
            if(rlCountUser2 == 3) return WinnerState.User2;
            return WinnerState.None;
        }
        private static void PrintTicTac(TicOrTac[,] tictacArray)
        {
            for(int i=0; i < 3; i++ ){
                for(int j = 0; j < 3; j++ ){
                    Console.Write("|_{0}_|",tictacArray[i,j] == TicOrTac.Empty ? "_" : tictacArray[i,j].ToString());
                }
                Console.WriteLine("");
            }
        }
    }
}